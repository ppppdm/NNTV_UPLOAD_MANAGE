Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Threading

Public Class TapeReceive
    Private _tapeRecvSendPerId As String
    Private _tapeRecvRecvPerId As String
    Private _tapeRecvSendPerDepartment As String = ""

    Private _workAcq As AccessControlQuery

    Private Sub TapeReceive_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
        ComboBoxMediaType.SelectedIndex = 0
        TextBoxRecvTime.Text = Now
        SetStartTimeZero()
        SetLengthZero()

        '启动后台线程
        StartThread()

        '使窗口居中
        Me.Left = (My.Computer.Screen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub TapeReceive_Disposed(ByVal sender As Object, _
                                     ByVal e As EventArgs) Handles Me.Disposed
        '结束后台线程
        EndThread()

        '主界面恢复
        QueryForm.WindowState = FormWindowState.Normal
    End Sub

    Private Sub SetLengthZero() '时长设为0
        TextBoxLengthH.Text = "00"
        TextBoxLengthM.Text = "00"
        TextBoxLengthS.Text = "00"
        TextBoxLengthF.Text = "00"
    End Sub

    Private Sub SetStartTimeZero() '开始时码设为0
        TextBoxStartTimeH.Text = "00"
        TextBoxStartTimeM.Text = "00"
        TextBoxStartTimeS.Text = "00"
        TextBoxStartTimeF.Text = "00"
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonCancel.Click

        Dispose()
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonOK.Click
        Time8() '时码补足8位
        Dim id = Guid.NewGuid()
        Dim tapeName = TextBoxTapeName.Text
        Dim startTimecode = TextBoxStartTimeH.Text & ":" & _
                            TextBoxStartTimeM.Text & ":" & _
                            TextBoxStartTimeS.Text & ":" & _
                            TextBoxStartTimeF.Text
        Dim endTimecode = TextBoxEndTimeH.Text & ":" & TextBoxEndTimeM.Text & _
                          ":" & TextBoxEndTimeS.Text & ":" & _
                          TextBoxEndTimeF.Text
        Dim length = TextBoxLengthH.Text & ":" & TextBoxLengthM.Text & ":" & _
                     TextBoxLengthS.Text & ":" & TextBoxLengthF.Text
        Dim inBcTime = TextBoxRecvTime.Text
        Dim inBcSendPer = TextBoxSendPerson.Text
        Dim inBcRecvPer = TextBoxRecvPerson.Text
        Dim remark = TextBoxRemark.Text
        Dim identical = CheckBoxTape.Checked
        Dim channel = ComboBoxChannel.Text
        Dim programType = ComboBoxProgramType.Text
        Dim mediaType = ComboBoxMediaType.Text

        If tapeName = "" Then
            MsgBox("磁带名!")
        ElseIf inBcSendPer = "" Then
            MsgBox("送带人!")
        ElseIf inBcRecvPer = "" Then
            MsgBox("收带人!")
        ElseIf identical = False Then
            MsgBox("带芯带盒不同!")
        ElseIf _tapeRecvSendPerId = Nothing Then
            MsgBox("请按指纹机确认送带人")
        Else
            '存入数据库

            Dim connection As New SqlConnection(ConnStr)

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
                     New SqlParameter("@tape_status", StatusNotUpload), _
                     New SqlParameter("@program_type", programType), _
                     New SqlParameter("@identical", identical), _
                     New SqlParameter("@department", _tapeRecvSendPerDepartment), _
                     New SqlParameter("@in_bc_send_per_id", _tapeRecvSendPerId), _
                     New SqlParameter("@media_type", mediaType), _
                     New SqlParameter("@channel", channel)}


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

            command.Parameters.AddRange(paras)

            Console.WriteLine(queryString)

            Try
                '打开数据库
                connection.Open()
                command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try

            Dispose()
        End If
    End Sub

    '输入时码时调用函数验证输入、计算出点、切换输入焦点
    Private Sub TextBoxStartTimeH_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxStartTimeH.TextChanged
        TimeInputCheck(TextBoxStartTimeH, TextBoxStartTimeM, 99, False)
    End Sub

    Private Sub TextBoxStartTimeM_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxStartTimeM.TextChanged
        TimeInputCheck(TextBoxStartTimeM, TextBoxStartTimeS, 60, False)
    End Sub

    Private Sub TextBoxStartTimeS_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxStartTimeS.TextChanged
        TimeInputCheck(TextBoxStartTimeS, TextBoxStartTimeF, 60, False)
    End Sub

    Private Sub TextBoxStartTimeF_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxStartTimeF.TextChanged
        TimeInputCheck(TextBoxStartTimeF, TextBoxLengthH, 25, False)
    End Sub

    Private Sub TextBoxLengthH_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxLengthH.TextChanged
        TimeInputCheck(TextBoxLengthH, TextBoxLengthM, 99, True)
    End Sub

    Private Sub TextBoxLengthM_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxLengthM.TextChanged
        TimeInputCheck(TextBoxLengthM, TextBoxLengthS, 60, True)
    End Sub

    Private Sub TextBoxLengthS_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxLengthS.TextChanged
        TimeInputCheck(TextBoxLengthS, TextBoxLengthF, 60, True)
    End Sub

    Private Sub TextBoxLengthF_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxLengthF.TextChanged
        If IsNumeric(TextBoxLengthF.Text) Then
            CalcEndTime()
            If TextBoxLengthF.TextLength = 2 Then
                If _
                    CInt(TextBoxLengthF.Text) >= 25 Or _
                    CInt(TextBoxLengthF.Text) < 0 Then
                    TextBoxLengthF.Text = "00"
                    TextBoxLengthF.SelectAll()
                End If
            End If
        Else
            TextBoxLengthF.Text = "00"
            TextBoxLengthF.SelectAll()
        End If
    End Sub

    '计算出点
    Private Sub CalcEndTime()
        If _
            (ComboBoxMediaType.SelectedIndex <= 1) And _
            IsNumeric(TextBoxLengthF.Text) And IsNumeric(TextBoxLengthS.Text) And _
            IsNumeric(TextBoxLengthM.Text) And IsNumeric(TextBoxLengthH.Text) And _
            IsNumeric(TextBoxStartTimeF.Text) And _
            IsNumeric(TextBoxStartTimeS.Text) And _
            IsNumeric(TextBoxStartTimeM.Text) And _
            IsNumeric(TextBoxStartTimeH.Text) Then
            Dim endTimeH = 0, _
                endTimeM = 0, _
                endTimeS = 0, _
                endTimeF As Integer
            If _
                CInt( _
                    TextBoxLengthH.Text & TextBoxLengthM.Text & _
                    TextBoxLengthS.Text & TextBoxLengthF.Text) <> 0 Then
                endTimeF = CInt(TextBoxStartTimeF.Text) + _
                           CInt(TextBoxLengthF.Text) - 1 '帧相加
                If endTimeF > 24 Then '进位
                    endTimeS += 1
                    endTimeF -= 25
                ElseIf endTimeF < 0 Then '借位
                    endTimeS -= 1
                    endTimeF += 25
                End If
                endTimeS += CInt(TextBoxStartTimeS.Text) + _
                            CInt(TextBoxLengthS.Text)    '秒相加
                If endTimeS > 59 Then
                    endTimeM += 1
                    endTimeS -= 60
                ElseIf endTimeS < 0 Then
                    endTimeM -= 1
                    endTimeS += 60
                End If
                endTimeM += CInt(TextBoxStartTimeM.Text) + _
                            CInt(TextBoxLengthM.Text)    '分相加
                If endTimeM > 59 Then
                    endTimeH += 1
                    endTimeM -= 60
                ElseIf endTimeM < 0 Then
                    endTimeH -= 1
                    endTimeM += 60
                End If
                endTimeH += CInt(TextBoxStartTimeH.Text) + _
                            CInt(TextBoxLengthH.Text)    '时相加
                '输出，不足2位的补0
                TextBoxEndTimeF.Text = _
                    Microsoft.VisualBasic.Right("00" & endTimeF, 2) _
                '结果的左边补2个0后取右边2位
                TextBoxEndTimeS.Text = _
                    Microsoft.VisualBasic.Right("00" & endTimeS, 2)
                TextBoxEndTimeM.Text = _
                    Microsoft.VisualBasic.Right("00" & endTimeM, 2)
                TextBoxEndTimeH.Text = _
                    Microsoft.VisualBasic.Right("00" & endTimeH, 2)
            Else '时长为0,结束时码与开始时码相同
                TextBoxEndTimeF.Text = TextBoxStartTimeF.Text
                TextBoxEndTimeS.Text = TextBoxStartTimeS.Text
                TextBoxEndTimeM.Text = TextBoxStartTimeM.Text
                TextBoxEndTimeH.Text = TextBoxStartTimeH.Text
            End If
        End If
    End Sub

    '输入时码后计算出点，输入焦点跳到下一个框
    Private Sub TimeInputCheck(ByRef thisTextTox As TextBox, _
                               ByRef nextTextBox As TextBox, _
                               ByVal maxNum As Integer, _
                               ByVal isLength As Boolean)
        If IsNumeric(thisTextTox.Text) Then
            CalcEndTime()   '计算出点
            If thisTextTox.TextLength = 2 Then
                If _
                    CInt(thisTextTox.Text) <= maxNum And _
                    CInt(thisTextTox.Text) >= 0 Then
                    nextTextBox.Focus()
                    nextTextBox.SelectAll()
                Else
                    thisTextTox.Text = "00"   '输入错误，改回00
                    thisTextTox.Focus()
                End If
            End If
        ElseIf ComboBoxMediaType.SelectedIndex <= 1 Or isLength Then
            thisTextTox.Text = "00"
            thisTextTox.Focus()
        End If
    End Sub

    '点击时码输入框时全选内容
    Private Sub TextBoxStartTimeH_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxStartTimeH.Click
        TextBoxStartTimeH.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeM_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxStartTimeM.Click
        TextBoxStartTimeM.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeS_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxStartTimeS.Click
        TextBoxStartTimeS.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeF_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxStartTimeF.Click
        TextBoxStartTimeF.SelectAll()
    End Sub

    Private Sub TextBoxLengthH_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxLengthH.Click
        TextBoxLengthH.SelectAll()
    End Sub

    Private Sub TextBoxLengthM_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxLengthM.Click
        TextBoxLengthM.SelectAll()
    End Sub

    Private Sub TextBoxLengthS_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxLengthS.Click
        TextBoxLengthS.SelectAll()
    End Sub

    Private Sub TextBoxLengthF_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxLengthF.Click
        TextBoxLengthF.SelectAll()
    End Sub

    '时码补足8位
    Private Sub Time8()
        If (ComboBoxMediaType.SelectedIndex > 1) Then
            TextBoxStartTimeF.Text = _
                Microsoft.VisualBasic.Right("00" & TextBoxStartTimeF.Text, 2) _
            '结果的左边补2个0后取右边2位
            TextBoxStartTimeS.Text = _
                Microsoft.VisualBasic.Right("00" & TextBoxStartTimeS.Text, 2)
            TextBoxStartTimeM.Text = _
                Microsoft.VisualBasic.Right("00" & TextBoxStartTimeM.Text, 2)
            TextBoxStartTimeH.Text = _
                Microsoft.VisualBasic.Right("00" & TextBoxStartTimeH.Text, 2)
        End If

        TextBoxLengthF.Text = _
            Microsoft.VisualBasic.Right("00" & TextBoxLengthF.Text, 2)
        TextBoxLengthS.Text = _
            Microsoft.VisualBasic.Right("00" & TextBoxLengthS.Text, 2)
        TextBoxLengthM.Text = _
            Microsoft.VisualBasic.Right("00" & TextBoxLengthM.Text, 2)
        TextBoxLengthH.Text = _
            Microsoft.VisualBasic.Right("00" & TextBoxLengthH.Text, 2)
    End Sub

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

    Private Sub ComboBoxMediaType_SelectedIndexChanged( _
                                                       ByVal sender As _
                                                          Object, _
                                                       ByVal e As  _
                                                          EventArgs) _
        Handles ComboBoxMediaType.SelectedIndexChanged
        If ComboBoxMediaType.SelectedIndex > 1 Then '非编上载
            TextBoxStartTimeH.Text = ""
            TextBoxStartTimeM.Text = ""
            TextBoxStartTimeS.Text = ""
            TextBoxStartTimeF.Text = ""
            TextBoxEndTimeH.Text = ""
            TextBoxEndTimeM.Text = ""
            TextBoxEndTimeS.Text = ""
            TextBoxEndTimeF.Text = ""
            TextBoxStartTimeH.ReadOnly = True
            TextBoxStartTimeM.ReadOnly = True
            TextBoxStartTimeS.ReadOnly = True
            TextBoxStartTimeF.ReadOnly = True
        Else '磁带采集
            TextBoxStartTimeH.Text = "00"
            TextBoxStartTimeM.Text = "00"
            TextBoxStartTimeS.Text = "00"
            TextBoxStartTimeF.Text = "00"
            CalcEndTime()
            TextBoxStartTimeH.ReadOnly = False
            TextBoxStartTimeM.ReadOnly = False
            TextBoxStartTimeS.ReadOnly = False
            TextBoxStartTimeF.ReadOnly = False
        End If

        ComboBoxMediaType.Focus()
    End Sub

    Private Sub TextBoxSendPerson_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxSendPerson.TextChanged
        If TextBoxTapeName.Text = "" Then
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
                    'ListBoxTapeName.Height = ListBoxTapeName.ItemHeight
                    ListBoxTapeName.Hide()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                sqlconn.Close()
            End Try

        End If
    End Sub

    '鼠标点击，选定
    Private Sub ListBoxTapeName_MouseClick(ByVal sender As Object, _
                                           ByVal e As MouseEventArgs) _
        Handles ListBoxTapeName.MouseClick
        ListToText()
    End Sub

    '选定的磁带名填入磁带名框
    Private Sub ListToText()
        TextBoxTapeName.Text = ListBoxTapeName.Text
        ListBoxTapeName.Hide()

        '如果磁带名如“六位日期+节目名称”则自动填入已知信息
        If _
            IsNumeric(Mid(TextBoxTapeName.Text, 1, 6)) And _
            Mid(TextBoxTapeName.Text, 7, 1) <> "" Then
            Dim truename = Mid(TextBoxTapeName.Text, 7)
            Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
            Dim sqlstr = _
                    "SELECT TOP 2 channel, start_timecode, length FROM tape Where tape_name LIKE '%" + _
                    truename + "' ORDER by in_bc_time DESC;"
            Dim command As New SqlCommand(sqlstr, sqlconn)
            Try
                sqlconn.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim Achannel(2) As String
                Dim Astart(2) As String
                Dim Alength(2) As String
                Dim i = 0
                While reader.Read()
                    Achannel(i) = reader(0)
                    Astart(i) = reader(1)
                    Alength(i) = reader(2)
                    i += 1
                End While
                reader.Close()

                '若最后2次收到该节目的频道、时码、长度相同，则自动填入
                If Achannel(0) = Achannel(1) Then
                    ComboBoxChannel.Text = Achannel(0)
                Else
                    ComboBoxChannel.Text = ""
                End If
                If Astart(0) = Astart(1) Then
                    TextBoxStartTimeH.Text = Mid(Astart(0), 1, 2)
                    TextBoxStartTimeM.Text = Mid(Astart(0), 3, 2)
                    TextBoxStartTimeS.Text = Mid(Astart(0), 5, 2)
                    TextBoxStartTimeF.Text = Mid(Astart(0), 7, 2)
                Else
                    SetStartTimeZero()
                End If
                If Alength(0) = Alength(1) Then
                    TextBoxLengthH.Text = Mid(Alength(0), 1, 2)
                    TextBoxLengthM.Text = Mid(Alength(0), 3, 2)
                    TextBoxLengthS.Text = Mid(Alength(0), 5, 2)
                    TextBoxLengthF.Text = Mid(Alength(0), 7, 2)
                Else
                    SetLengthZero()
                End If
                TextBoxTapeName.Focus()
                TextBoxTapeName.SelectionLength = 6 '选中前6个字符，即日期
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            Finally
                sqlconn.Close()
            End Try
        End If
    End Sub
End Class

