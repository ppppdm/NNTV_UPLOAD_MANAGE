Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Threading

Public Class TapeReceive
    Private _tapeRecvSendPerId As String
    Private _tapeRecvRecvPerId As String
    Private _tapeRecvSendPerDepartment As String = ""

    Private TapeViewList As List(Of TapeRecTapeAttribute) = New List(Of TapeRecTapeAttribute)

    Private _startX As Integer
    Private _startY As Integer

    Private _locationX As Integer
    Private _locationY As Integer

    Private _leftMargin As Integer = 8
    Private _middleMargin As Integer = 8
    Private _rightMargin As Integer = 8

    Private _unitW As Integer
    Private _unitH As Integer

    Structure TapeNameModler
        Dim DateStr As String
        Dim TapeNameStr As String
    End Structure

    Private _lastTapeNameModler As TapeNameModler = New TapeNameModler

    Private _workAcq As AccessControlQuery

    Private Sub TapeReceive_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
        'ComboBoxMediaType.SelectedIndex = 0
        TextBoxRecvTime.Text = Now
        'SetStartTimeZero()
        'SetLengthZero()

        _startX = 205
        _startY = 12

        AddOneTapeRecAttribute()

        setUnitXAndY()

        '启动后台线程
        StartThread()

    End Sub

    Private Sub setUnitXAndY()
        _unitW = TapeViewList(0).Width
        _unitH = TapeViewList(0).Height
    End Sub

    Private Function AddOneTapeRecAttribute() As TapeRecTapeAttribute

        If TapeViewList.Count < 5 Then
            Dim uc As New TapeRecTapeAttribute
            Me.Controls.Add(uc)
            AddHandler uc.ButtonCloseClick, AddressOf UC_ButtonCloseClick
            TapeViewList.Add(uc)
            ReLocateTapeRecAttribute()
            ReSizeTapeRecieve()
            Return uc
        End If
        Return Nothing
    End Function

    Private Sub RemoveOneTapeRecAttribute(ByVal uc As TapeRecTapeAttribute)


        Me.Controls.Remove(uc)
        RemoveHandler uc.ButtonCloseClick, AddressOf UC_ButtonCloseClick
        TapeViewList.Remove(uc)
        ReLocateTapeRecAttribute()
        ReSizeTapeRecieve()

        If TapeViewList.Count = 0 Then
            AddOneTapeRecAttribute()
        End If

    End Sub

    Private Sub ReLocateTapeRecAttribute()
        'uc.Location = New Point(Me.Width, 10)
        Dim i As Integer
        Dim j As Integer

        For i = 0 To TapeViewList.Count - 1
            If i < 3 Then
                TapeViewList(i).Location = New Point(_startX + i * _unitW + (i + 1) * _middleMargin, _startY)
            ElseIf i >= 3 Then
                j = i - 2
                TapeViewList(i).Location = New Point(_startX + j * _unitW + (j + 1) * _middleMargin, _startY + _unitH + _middleMargin)
            End If
        Next

    End Sub

    Private Sub ReSizeTapeRecieve()
        Dim w As Integer = 0
        'Dim h As Integer = 0

        w += ButtonAdd.Width + _middleMargin

        If TapeViewList.Count < 3 Then
            w += _unitW * TapeViewList.Count + _middleMargin * TapeViewList.Count
        ElseIf TapeViewList.Count >= 3 Then
            w += _unitW * 3 + _middleMargin * 2
        End If

        If Panel1.Width > w Then
            w = Panel1.Width
        End If

        If PanelSearchResult.Visible = True Then
            w += PanelSearchResult.Width + _middleMargin
        End If

        w += _leftMargin + _rightMargin

        Me.Width = w
    End Sub

    Private Sub UC_ButtonCloseClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim uc As TapeRecTapeAttribute = CType(sender, TapeRecTapeAttribute)
        RemoveOneTapeRecAttribute(uc)
    End Sub

    Private Sub TapeReceive_Disposed(ByVal sender As Object, _
                                     ByVal e As EventArgs) Handles Me.Disposed
        '结束后台线程
        EndThread()

        '主界面恢复
        QueryForm.WindowState = FormWindowState.Normal
    End Sub

    'Private Sub SetLengthZero() '时长设为0
    '    TextBoxLengthH.Text = "00"
    '    TextBoxLengthM.Text = "00"
    '    TextBoxLengthS.Text = "00"
    '    TextBoxLengthF.Text = "00"
    'End Sub

    'Private Sub SetStartTimeZero() '开始时码设为0
    '    TextBoxStartTimeH.Text = "00"
    '    TextBoxStartTimeM.Text = "00"
    '    TextBoxStartTimeS.Text = "00"
    '    TextBoxStartTimeF.Text = "00"
    'End Sub

    Private Sub ButtonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonCancel.Click

        Dispose()
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonOK.Click
        'Time8() '时码补足8位

        Dim i As Integer
        Dim tapeTotal As Integer = TapeViewList.Count

        Dim inBcTime = TextBoxRecvTime.Text
        Dim inBcSendPer = TextBoxSendPerson.Text
        Dim inBcRecvPer = TextBoxRecvPerson.Text
        Dim remark = TextBoxRemark.Text
        Dim identical = CheckBoxTape.Checked
        Dim status = StatusNotUpload
        If inBcRecvPer = "" Then
            status = StatusNotRecvConfirm
        End If

        If inBcSendPer = "" Then
            MsgBox("送带人!")
            'ElseIf inBcRecvPer = "" Then
            '    MsgBox("收带人!")
        ElseIf identical = False Then
            MsgBox("带芯带盒不同!")
        ElseIf _tapeRecvSendPerId = Nothing Then
            MsgBox("请按指纹机确认送带人")
        Else
            Dim connection As New SqlConnection(ConnStr)
            Const queryString As String = "insert into tape( " & "id, " & _
                                          "tape_name, " & "start_timecode,  " & _
                                              "end_timecode, " & "length, " & _
                                              "in_bc_send_per, " & _
                                              "in_bc_recv_per, " & "remark, " & _
                                              "tape_status, " & "in_bc_time, " & _
                                              "program_type, " & "identical, " & _
                                              "department, " & "in_bc_send_per_id, " & _
                                              "media_type, " & "channel ) " & _
                                              "values ( " & "@id, " & "@tape_name, " & _
                                              "@start_timecode, " & _
                                              "@end_timecode, " & "@length, " & _
                                              "@in_bc_send_per, " & _
                                              "@in_bc_recv_per, " & "@remark, " & _
                                              "@tape_status, " & "@in_bc_time, " & _
                                              "@program_type, " & "@identical, " & _
                                              "@department, " & _
                                              "@in_bc_send_per_id, " & _
                                              "@media_type, " & "@channel)"

            Dim command As New SqlCommand(queryString, connection)

            Try

                connection.Open()

                For i = 0 To TapeViewList.Count - 1
                    command.Parameters.Clear()

                    Dim uc As TapeRecTapeAttribute = TapeViewList(i)
                    Dim id = Guid.NewGuid()
                    Dim tapeName = uc.TextBoxTapeName.Text
                    Dim startTimecode = uc.TextBoxStartTimeH.Text & ":" & _
                                        uc.TextBoxStartTimeM.Text & ":" & _
                                        uc.TextBoxStartTimeS.Text & ":" & _
                                        uc.TextBoxStartTimeF.Text
                    Dim endTimecode = uc.TextBoxEndTimeH.Text & ":" & uc.TextBoxEndTimeM.Text & _
                                      ":" & uc.TextBoxEndTimeS.Text & ":" & _
                                      uc.TextBoxEndTimeF.Text
                    Dim length = uc.TextBoxLengthH.Text & ":" & uc.TextBoxLengthM.Text & ":" & _
                                 uc.TextBoxLengthS.Text & ":" & uc.TextBoxLengthF.Text

                    Dim channel = uc.ComboBoxChannel.Text
                    Dim programType = uc.ComboBoxProgramType.Text
                    Dim mediaType = uc.ComboBoxMediaType.Text

                    If CheckTapeName(tapeName) = True Then

                        Dim paras() As SqlParameter = _
                                {New SqlParameter("@id", id), _
                                 New SqlParameter("@tape_name", tapeName), _
                                 New SqlParameter("@start_timecode", startTimecode), _
                                 New SqlParameter("@end_timecode", endTimecode), _
                                 New SqlParameter("@length", length), _
                                 New SqlParameter("@in_bc_send_per", inBcSendPer), _
                                 New SqlParameter("@in_bc_recv_per", inBcRecvPer), _
                                 New SqlParameter("@in_bc_time", inBcTime), _
                                 New SqlParameter("@remark", remark), _
                                 New SqlParameter("@tape_status", status), _
                                 New SqlParameter("@program_type", programType), _
                                 New SqlParameter("@identical", identical), _
                                 New SqlParameter("@department", _tapeRecvSendPerDepartment), _
                                 New SqlParameter("@in_bc_send_per_id", _tapeRecvSendPerId), _
                                 New SqlParameter("@media_type", mediaType), _
                                 New SqlParameter("@channel", channel)}

                        command.Parameters.AddRange(paras)
                        Try
                            command.ExecuteNonQuery()
                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                        End Try
                    End If

                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
        End If

        Dispose()
    End Sub

    Private Function CheckTapeName(ByVal tapeName As String) As Boolean
        If tapeName = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    ''输入时码时调用函数验证输入、计算出点、切换输入焦点
    'Private Sub TextBoxStartTimeH_TextChanged(ByVal sender As Object, _
    '                                          ByVal e As EventArgs)

    '    TimeInputCheck(TextBoxStartTimeH, TextBoxStartTimeM, 99, False)
    'End Sub

    'Private Sub TextBoxStartTimeM_TextChanged(ByVal sender As Object, _
    '                                          ByVal e As EventArgs)

    '    TimeInputCheck(TextBoxStartTimeM, TextBoxStartTimeS, 60, False)
    'End Sub

    'Private Sub TextBoxStartTimeS_TextChanged(ByVal sender As Object, _
    '                                          ByVal e As EventArgs)

    '    TimeInputCheck(TextBoxStartTimeS, TextBoxStartTimeF, 60, False)
    'End Sub

    'Private Sub TextBoxStartTimeF_TextChanged(ByVal sender As Object, _
    '                                          ByVal e As EventArgs)

    '    TimeInputCheck(TextBoxStartTimeF, TextBoxLengthH, 25, False)
    'End Sub

    'Private Sub TextBoxLengthH_TextChanged(ByVal sender As Object, _
    '                                       ByVal e As EventArgs)

    '    TimeInputCheck(TextBoxLengthH, TextBoxLengthM, 99, True)
    'End Sub

    'Private Sub TextBoxLengthM_TextChanged(ByVal sender As Object, _
    '                                       ByVal e As EventArgs)

    '    TimeInputCheck(TextBoxLengthM, TextBoxLengthS, 60, True)
    'End Sub

    'Private Sub TextBoxLengthS_TextChanged(ByVal sender As Object, _
    '                                       ByVal e As EventArgs)

    '    TimeInputCheck(TextBoxLengthS, TextBoxLengthF, 60, True)
    'End Sub

    'Private Sub TextBoxLengthF_TextChanged(ByVal sender As Object, _
    '                                       ByVal e As EventArgs)

    '    If IsNumeric(TextBoxLengthF.Text) Then
    '        CalcEndTime()
    '        If TextBoxLengthF.TextLength = 2 Then
    '            If _
    '                CInt(TextBoxLengthF.Text) >= 25 Or _
    '                CInt(TextBoxLengthF.Text) < 0 Then
    '                TextBoxLengthF.Text = "00"
    '                TextBoxLengthF.SelectAll()
    '            End If
    '        End If
    '    Else
    '        TextBoxLengthF.Text = "00"
    '        TextBoxLengthF.SelectAll()
    '    End If
    'End Sub

    ''计算出点
    'Private Sub CalcEndTime()
    '    If _
    '        (ComboBoxMediaType.SelectedIndex <= 1) And _
    '        IsNumeric(TextBoxLengthF.Text) And IsNumeric(TextBoxLengthS.Text) And _
    '        IsNumeric(TextBoxLengthM.Text) And IsNumeric(TextBoxLengthH.Text) And _
    '        IsNumeric(TextBoxStartTimeF.Text) And _
    '        IsNumeric(TextBoxStartTimeS.Text) And _
    '        IsNumeric(TextBoxStartTimeM.Text) And _
    '        IsNumeric(TextBoxStartTimeH.Text) Then
    '        Dim endTimeH = 0, _
    '            endTimeM = 0, _
    '            endTimeS = 0, _
    '            endTimeF As Integer
    '        If _
    '            CInt( _
    '                TextBoxLengthH.Text & TextBoxLengthM.Text & _
    '                TextBoxLengthS.Text & TextBoxLengthF.Text) <> 0 Then
    '            endTimeF = CInt(TextBoxStartTimeF.Text) + _
    '                       CInt(TextBoxLengthF.Text) - 1 '帧相加
    '            If endTimeF > 24 Then '进位
    '                endTimeS += 1
    '                endTimeF -= 25
    '            ElseIf endTimeF < 0 Then '借位
    '                endTimeS -= 1
    '                endTimeF += 25
    '            End If
    '            endTimeS += CInt(TextBoxStartTimeS.Text) + _
    '                        CInt(TextBoxLengthS.Text)    '秒相加
    '            If endTimeS > 59 Then
    '                endTimeM += 1
    '                endTimeS -= 60
    '            ElseIf endTimeS < 0 Then
    '                endTimeM -= 1
    '                endTimeS += 60
    '            End If
    '            endTimeM += CInt(TextBoxStartTimeM.Text) + _
    '                        CInt(TextBoxLengthM.Text)    '分相加
    '            If endTimeM > 59 Then
    '                endTimeH += 1
    '                endTimeM -= 60
    '            ElseIf endTimeM < 0 Then
    '                endTimeH -= 1
    '                endTimeM += 60
    '            End If
    '            endTimeH += CInt(TextBoxStartTimeH.Text) + _
    '                        CInt(TextBoxLengthH.Text)    '时相加
    '            '输出，不足2位的补0
    '            TextBoxEndTimeF.Text = _
    '                Microsoft.VisualBasic.Right("00" & endTimeF, 2) _
    '            '结果的左边补2个0后取右边2位
    '            TextBoxEndTimeS.Text = _
    '                Microsoft.VisualBasic.Right("00" & endTimeS, 2)
    '            TextBoxEndTimeM.Text = _
    '                Microsoft.VisualBasic.Right("00" & endTimeM, 2)
    '            TextBoxEndTimeH.Text = _
    '                Microsoft.VisualBasic.Right("00" & endTimeH, 2)
    '        Else '时长为0,结束时码与开始时码相同
    '            TextBoxEndTimeF.Text = TextBoxStartTimeF.Text
    '            TextBoxEndTimeS.Text = TextBoxStartTimeS.Text
    '            TextBoxEndTimeM.Text = TextBoxStartTimeM.Text
    '            TextBoxEndTimeH.Text = TextBoxStartTimeH.Text
    '        End If
    '    End If
    'End Sub

    ''输入时码后计算出点，输入焦点跳到下一个框
    'Private Sub TimeInputCheck(ByRef thisTextTox As TextBox, _
    '                           ByRef nextTextBox As TextBox, _
    '                           ByVal maxNum As Integer, _
    '                           ByVal isLength As Boolean)
    '    If IsNumeric(thisTextTox.Text) Then
    '        CalcEndTime()   '计算出点
    '        If thisTextTox.TextLength = 2 Then
    '            If _
    '                CInt(thisTextTox.Text) <= maxNum And _
    '                CInt(thisTextTox.Text) >= 0 Then
    '                nextTextBox.Focus()
    '                nextTextBox.SelectAll()
    '            Else
    '                thisTextTox.Text = "00"   '输入错误，改回00
    '                thisTextTox.Focus()
    '            End If
    '        End If
    '    ElseIf ComboBoxMediaType.SelectedIndex <= 1 Or isLength Then
    '        thisTextTox.Text = "00"
    '        thisTextTox.Focus()
    '    End If
    'End Sub

    ''点击时码输入框时全选内容
    'Private Sub TextBoxStartTimeH_Click(ByVal sender As Object, _
    '                                    ByVal e As EventArgs)

    '    TextBoxStartTimeH.SelectAll()
    'End Sub

    'Private Sub TextBoxStartTimeM_Click(ByVal sender As Object, _
    '                                    ByVal e As EventArgs)

    '    TextBoxStartTimeM.SelectAll()
    'End Sub

    'Private Sub TextBoxStartTimeS_Click(ByVal sender As Object, _
    '                                    ByVal e As EventArgs)

    '    TextBoxStartTimeS.SelectAll()
    'End Sub

    'Private Sub TextBoxStartTimeF_Click(ByVal sender As Object, _
    '                                    ByVal e As EventArgs)

    '    TextBoxStartTimeF.SelectAll()
    'End Sub

    'Private Sub TextBoxLengthH_Click(ByVal sender As Object, _
    '                                 ByVal e As EventArgs)

    '    TextBoxLengthH.SelectAll()
    'End Sub

    'Private Sub TextBoxLengthM_Click(ByVal sender As Object, _
    '                                 ByVal e As EventArgs)

    '    TextBoxLengthM.SelectAll()
    'End Sub

    'Private Sub TextBoxLengthS_Click(ByVal sender As Object, _
    '                                 ByVal e As EventArgs)

    '    TextBoxLengthS.SelectAll()
    'End Sub

    'Private Sub TextBoxLengthF_Click(ByVal sender As Object, _
    '                                 ByVal e As EventArgs)

    '    TextBoxLengthF.SelectAll()
    'End Sub

    '时码补足8位
    'Private Sub Time8()
    '    If (ComboBoxMediaType.SelectedIndex > 1) Then
    '        TextBoxStartTimeF.Text = _
    '            Microsoft.VisualBasic.Right("00" & TextBoxStartTimeF.Text, 2) _
    '        '结果的左边补2个0后取右边2位
    '        TextBoxStartTimeS.Text = _
    '            Microsoft.VisualBasic.Right("00" & TextBoxStartTimeS.Text, 2)
    '        TextBoxStartTimeM.Text = _
    '            Microsoft.VisualBasic.Right("00" & TextBoxStartTimeM.Text, 2)
    '        TextBoxStartTimeH.Text = _
    '            Microsoft.VisualBasic.Right("00" & TextBoxStartTimeH.Text, 2)
    '    End If

    '    TextBoxLengthF.Text = _
    '        Microsoft.VisualBasic.Right("00" & TextBoxLengthF.Text, 2)
    '    TextBoxLengthS.Text = _
    '        Microsoft.VisualBasic.Right("00" & TextBoxLengthS.Text, 2)
    '    TextBoxLengthM.Text = _
    '        Microsoft.VisualBasic.Right("00" & TextBoxLengthM.Text, 2)
    '    TextBoxLengthH.Text = _
    '        Microsoft.VisualBasic.Right("00" & TextBoxLengthH.Text, 2)
    'End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, _
                                                     ByVal e As  _
                                                        RunWorkerCompletedEventArgs) _
        Handles BackgroundWorker1.RunWorkerCompleted

        ' This event handler is called when the background thread finishes.
        ' This method runs on the main thread.

        If e.Error IsNot Nothing Then
            MsgBox("Error: " & e.Error.Message)
        ElseIf e.Cancelled Then
            Console.Write("Word counting canceled.")
        Else
            Console.Write("Finished figureprint backgroundworker")
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, _
                                                  ByVal e As  _
                                                     ProgressChangedEventArgs) _
        Handles BackgroundWorker1.ProgressChanged

        ' This event handler is called after the background thread
        ' reads a line from the source file.
        ' This method runs on the main thread.

        Dim result As AccessControlQuery.AccessControlResult = CType(e.UserState,  _
                                                                     AccessControlQuery.AccessControlResult)
        Dim id As String = result.Name

        '查询数据库 根据name获取信息

        Dim connection As New SqlConnection(ConnStr)
        Const queryString As String = _
                  "select * from accessmanage where person_id = @id"
        Dim command As New SqlCommand(queryString, connection)

        Dim connection2 As New SqlConnection(ConnStr)
        Const queryString2 As String = "select * from person where id = @id"
        Dim command2 As New SqlCommand(queryString2, connection2)


        Dim pname As String
        Dim department As String
        Dim inbcSend As Boolean
        Dim inbcRecv As Boolean


        'result.Name 是db中的名字,默认为id
        command.Parameters.Add(New SqlParameter("@id", id))
        command2.Parameters.Add(New SqlParameter("@id", id))

        Try
            connection.Open()
            connection2.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim reader2 As SqlDataReader = command2.ExecuteReader()

            If reader.Read And reader2.Read Then
                pname = reader("person_name")
                inbcSend = reader("inbc_send")
                inbcRecv = reader("inbc_recv")
                department = reader2("department")

                If inbcSend = True And inbcRecv = True Then
                    If Not department = "播出部" Then
                        TextBoxSendPerson.Text = pname
                        _tapeRecvSendPerId = id
                        _tapeRecvSendPerDepartment = department
                    ElseIf TextBoxSendPerson.Focused() Then
                        TextBoxSendPerson.Text = pname
                        _tapeRecvSendPerId = id
                        _tapeRecvSendPerDepartment = department
                    ElseIf TextBoxRecvPerson.Focused() Then
                        TextBoxRecvPerson.Text = pname
                        _tapeRecvRecvPerId = id
                    Else
                        TextBoxSendPerson.Text = pname
                        _tapeRecvSendPerId = id
                        _tapeRecvSendPerDepartment = department
                    End If

                ElseIf inbcSend = True Then
                    TextBoxSendPerson.Text = pname
                    _tapeRecvSendPerId = id
                    _tapeRecvSendPerDepartment = department
                ElseIf inbcRecv = True Then
                    TextBoxSendPerson.Text = pname
                    _tapeRecvRecvPerId = id
                Else
                    MsgBox("没有接收或送磁带权限!")
                End If

            Else
                MsgBox("数据库无此信息,请手动输入")
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection2.Close()
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, _
                                         ByVal e As DoWorkEventArgs) _
        Handles BackgroundWorker1.DoWork

        ' This event handler is where the actual work is done.
        ' This method runs on the background thread.

        ' Get the BackgroundWorker object that raised this event.
        Dim worker As BackgroundWorker
        worker = CType(sender, BackgroundWorker)

        Dim t As Thread = Thread.CurrentThread()

        ' Get the Works object and call the main method.
        Dim workAcq As AccessControlQuery = CType(e.Argument, AccessControlQuery)
        workAcq.StartAccessControl(worker)
    End Sub

    '载入界面时调用此方法调用后台线程
    Sub StartThread()
        ' This method runs on the main thread.

        ' Initialize the object that the background worker calls.
        _workAcq = New AccessControlQuery

        ' Start the asynchronous operation.
        BackgroundWorker1.RunWorkerAsync(_workAcq)
    End Sub

    '销毁界面前调用此方法调用后台线程
    Sub EndThread()
        _workAcq.EndAccessControl()
    End Sub

    'Private Sub ComboBoxMediaType_SelectedIndexChanged( _
    '                                                   ByVal sender As _
    '                                                      Object, _
    '                                                   ByVal e As _
    '                                                      EventArgs)

    '    If ComboBoxMediaType.SelectedIndex > 1 Then '非编上载
    '        TextBoxStartTimeH.Text = ""
    '        TextBoxStartTimeM.Text = ""
    '        TextBoxStartTimeS.Text = ""
    '        TextBoxStartTimeF.Text = ""
    '        TextBoxEndTimeH.Text = ""
    '        TextBoxEndTimeM.Text = ""
    '        TextBoxEndTimeS.Text = ""
    '        TextBoxEndTimeF.Text = ""
    '        TextBoxStartTimeH.ReadOnly = True
    '        TextBoxStartTimeM.ReadOnly = True
    '        TextBoxStartTimeS.ReadOnly = True
    '        TextBoxStartTimeF.ReadOnly = True
    '    Else '磁带采集
    '        TextBoxStartTimeH.Text = "00"
    '        TextBoxStartTimeM.Text = "00"
    '        TextBoxStartTimeS.Text = "00"
    '        TextBoxStartTimeF.Text = "00"
    '        CalcEndTime()
    '        TextBoxStartTimeH.ReadOnly = False
    '        TextBoxStartTimeM.ReadOnly = False
    '        TextBoxStartTimeS.ReadOnly = False
    '        TextBoxStartTimeF.ReadOnly = False
    '    End If

    '    ComboBoxMediaType.Focus()
    'End Sub

    Private Sub TextBoxSendPerson_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxSendPerson.TextChanged
        'If TextBoxTapeName.Text = "" Then
        Dim sendPerson As String = TextBoxSendPerson.Text
        Dim queryString As String = _
                "SELECT TOP 10 * from tape WHERE in_bc_send_per = '" & _
                sendPerson & "' ORDER by in_bc_time DESC"
        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
        Dim sqlcom As SqlCommand = New SqlCommand(queryString, sqlconn)

        Try
            sqlconn.Open()
            Dim reader As SqlDataReader = sqlcom.ExecuteReader()

            ListBoxTapeName.Items.Clear()
            While reader.Read()
                ListBoxTapeName.Items.Add(reader("tape_name"))
            End While
            reader.Close()

            If ListBoxTapeName.Items.Count <> 0 Then
                ListBoxTapeName.Height = ListBoxTapeName.Items.Count * _
                                         ListBoxTapeName.ItemHeight + 4
                ListBoxTapeName.Show()
            Else
                ListBoxTapeName.Height = ListBoxTapeName.ItemHeight
                ListBoxTapeName.Hide()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try

        ' End If
    End Sub

    '鼠标点击，选定
    Private Sub ListBoxTapeName_MouseClick(ByVal sender As Object, _
                                           ByVal e As MouseEventArgs) _
        Handles ListBoxTapeName.MouseClick
        ListToText()
    End Sub

    '选定的磁带名填入磁带名框
    Private Sub ListToText()

        Dim uc As TapeRecTapeAttribute = Nothing

        If TapeViewList.Count > 1 Then
            uc = AddOneTapeRecAttribute()
        End If

        If TapeViewList.Count = 1 Then
            uc = TapeViewList(0)
            If Not uc.TextBoxTapeName.Text = "" Then
                uc = AddOneTapeRecAttribute()
            End If
        End If

        If Not TypeName(uc) = "Nothing" Then
            Dim tapeName As String = ListBoxTapeName.Text

            ''如果磁带名如“六位日期+节目名称”则自动填入已知信息
            If _
                IsNumeric(Mid(tapeName, 1, 6)) And _
                Mid(tapeName, 7, 1) <> "" Then

                Dim dateStr As String = Mid(tapeName, 1, 6)
                Dim tapeNameStr As String = Mid(tapeName, 7)
                If _lastTapeNameModler.TapeNameStr = tapeNameStr Then
                    dateStr = _lastTapeNameModler.DateStr
                End If

                'dateStr 增加一天
                dateStr = AddedOneDay(dateStr)

                _lastTapeNameModler.TapeNameStr = tapeNameStr
                _lastTapeNameModler.DateStr = dateStr

                uc.TextBoxTapeName.Text = dateStr + tapeNameStr

                Dim truename = Mid(tapeName, 7)
                Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
                Dim sqlstr = _
                        "SELECT TOP 2 * FROM tape Where tape_name LIKE '%" + _
                        truename + "' ORDER by in_bc_time DESC;"
                Dim command As New SqlCommand(sqlstr, sqlconn)
                Try
                    sqlconn.Open()

                    Dim reader As SqlDataReader = command.ExecuteReader()
                    Dim Achannel(2) As String
                    Dim Astart(2) As String
                    Dim Alength(2) As String
                    Dim aProgramType(2) As String
                    Dim aMediaType(2) As String
                    Dim i = 0
                    While reader.Read()
                        Achannel(i) = reader("channel").ToString()
                        Astart(i) = reader("start_timecode").ToString()
                        Alength(i) = reader("length").ToString()
                        aProgramType(i) = reader("program_type").ToString()
                        aMediaType(i) = reader("media_type").ToString()
                        i += 1
                    End While
                    reader.Close()

                    '若最后2次收到该节目的频道、时码、长度相同，则自动填入
                    If Achannel(0) = Achannel(1) Then
                        uc.ComboBoxChannel.Text = Achannel(0)
                    Else
                        uc.ComboBoxChannel.Text = ""
                    End If
                    If Astart(0) = Astart(1) Then
                        uc.TextBoxStartTimeH.Text = Mid(Astart(0), 1, 2)
                        uc.TextBoxStartTimeM.Text = Mid(Astart(0), 4, 2)
                        uc.TextBoxStartTimeS.Text = Mid(Astart(0), 7, 2)
                        uc.TextBoxStartTimeF.Text = Mid(Astart(0), 10, 2)
                    Else
                        uc.TextBoxStartTimeH.Text = "00"
                        uc.TextBoxStartTimeM.Text = "00"
                        uc.TextBoxStartTimeS.Text = "00"
                        uc.TextBoxStartTimeF.Text = "00"
                    End If
                    If Alength(0) = Alength(1) Then
                        uc.TextBoxLengthH.Text = Mid(Alength(0), 1, 2)
                        uc.TextBoxLengthM.Text = Mid(Alength(0), 4, 2)
                        uc.TextBoxLengthS.Text = Mid(Alength(0), 7, 2)
                        uc.TextBoxLengthF.Text = Mid(Alength(0), 10, 2)
                    Else
                        uc.TextBoxLengthH.Text = "00"
                        uc.TextBoxLengthM.Text = "00"
                        uc.TextBoxLengthS.Text = "00"
                        uc.TextBoxLengthF.Text = "00"
                    End If

                    If aProgramType(0) = aProgramType(1) Then
                        uc.ComboBoxProgramType.Text = aProgramType(0)
                    End If

                    If aMediaType(0) = aMediaType(1) Then
                        uc.ComboBoxMediaType.Text = aMediaType(0)
                    End If

                    uc.TextBoxTapeName.Focus()
                    uc.TextBoxTapeName.SelectionLength = 6 '选中前6个字符，即日期
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                Finally
                    sqlconn.Close()
                End Try
            Else ''磁带名自动填入
                uc.TextBoxTapeName.Text = tapeName
            End If
        End If

    End Sub

    Private Function AddedOneDay(ByVal dateStr As String) As String
        Try
            Dim ds As String = "20" + dateStr
            Dim dt As Date = CDate(Strings.Format(CInt(ds), "0000-00-00"))
            dt = dt.AddDays(1)
            dateStr = dt.ToString("yyMMdd")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        
        Return dateStr
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        AddOneTapeRecAttribute()
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAdd.MouseEnter
        ButtonAdd.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAdd.MouseLeave
        ButtonAdd.FlatAppearance.BorderSize = 0
    End Sub

End Class

