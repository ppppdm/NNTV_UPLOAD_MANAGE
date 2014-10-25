Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class tape_receive

    Dim connection As New SqlConnection(ConnStr)
    Dim _workAcq As AccessControlQuery

    '设置时码初始值
    Private Sub tape_receive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '打开数据库
        Try
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Dispose()
        End Try
        TextBoxRecvTime.Text = Now
        SetStartTimeZero()
        SetLengthZero()

        '启动后台线程
        StartThread()

    End Sub

    Private Sub SetLengthZero() '时长设为0
        TextBoxLengthH.Text = "00"
        TextBoxLengthM.Text = "00"
        TextBoxLengthS.Text = "00"
        TextBoxLengthF.Text = "00"
    End Sub
    Private Sub SetStartTimeZero()  '开始时码设为0
        TextBoxStartTimeH.Text = "00"
        TextBoxStartTimeM.Text = "00"
        TextBoxStartTimeS.Text = "00"
        TextBoxStartTimeF.Text = "00"
    End Sub

    Private Sub ButtonCancel_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonCancel.Click
        '结束后台线程
        BackgroundWorker1.CancelAsync()

        Dispose()
        connection.Close()
    End Sub

    Private Sub ButtonOK_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonOK.Click
        Time8() '时码补足8位
        Dim tapeName = TextBoxTapeName.Text
        Dim startTimecode = TextBoxStartTimeH.Text & TextBoxStartTimeM.Text & _
                             TextBoxStartTimeS.Text & TextBoxStartTimeF.Text
        Dim endTimecode = TextBoxEndTimeH.Text & TextBoxEndTimeM.Text & _
                           TextBoxEndTimeS.Text & TextBoxEndTimeF.Text
        Dim length = TextBoxLengthH.Text & TextBoxLengthM.Text & _
                     TextBoxLengthS.Text & TextBoxLengthF.Text
        Dim inBcTime = TextBoxRecvTime.Text
        Dim inBcSendPer = TextBoxSendPerson.Text
        Dim inBcRecvPer = TextBoxRecvPerson.Text
        Dim remark = TextBoxRemark.Text
        Dim identical = CheckBoxTape.Checked
        Dim channel = ComboBoxChannel.Text

        If tapeName = "" Then
            MsgBox("磁带名!")
        ElseIf inBcSendPer = "" Then
            MsgBox("送带人!")
        ElseIf inBcRecvPer = "" Then
            MsgBox("收带人!")
        ElseIf identical = False Then
            MsgBox("带芯带盒不同!")
        Else
            '存入数据库
            Dim paras() As SqlParameter = { _
                         New SqlParameter("@tape_name", tapeName), _
                         New SqlParameter("@start_timecode", startTimecode), _
                         New SqlParameter("@end_timecode", endTimecode), _
                         New SqlParameter("@length", length), _
                         New SqlParameter("@in_bc_send_per", inBcSendPer), _
                         New SqlParameter("@in_bc_recv_per", inBcRecvPer), _
                         New SqlParameter("@in_bc_time", inBcTime), _
                         New SqlParameter("@remark", remark), _
                         New SqlParameter("@tape_status", StatusNotUpload), _
                         New SqlParameter("@channel", channel) _
                         }

            Dim queryString As String = GetQueryString()

            Dim command As New SqlCommand(queryString, connection)

            command.Parameters.AddRange(paras)

            Try            
                command.ExecuteReader()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connection.Close()
            '结束后台线程
            BackgroundWorker1.CancelAsync()

            Dispose()
        End If
    End Sub

    Private Function GetQueryString() As String
        Dim queryString As String

        queryString = "insert into tape" + _
            "(id,tape_name,start_timecode,end_timecode,length,in_bc_send_per,in_bc_recv_per,remark,tape_status,in_bc_time,channel) " + _
            "values (newid(),@tape_name,@start_timecode,@end_timecode,@length,@in_bc_send_per,@in_bc_recv_per,@remark,@tape_status,getdate(),@channel);"

        Return queryString
    End Function

  
    '时码时长禁止输入非数字
    Private Sub TextBoxStartTimeH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStartTimeH.KeyPress
        If Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8) Then e.Handled = True
    End Sub
    Private Sub TextBoxStartTimeM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStartTimeM.KeyPress
        If Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8) Then e.Handled = True
    End Sub
    Private Sub TextBoxStartTimeS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStartTimeS.KeyPress
        If Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8) Then e.Handled = True
    End Sub
    Private Sub TextBoxStartTimeF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxStartTimeF.KeyPress
        If Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8) Then e.Handled = True
    End Sub
    Private Sub TextBoxLengthH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLengthH.KeyPress
        If Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8) Then e.Handled = True
    End Sub
    Private Sub TextBoxLengthM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLengthM.KeyPress
        If Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8) Then e.Handled = True
    End Sub
    Private Sub TextBoxLengthS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLengthS.KeyPress
        If Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8) Then e.Handled = True
    End Sub
    Private Sub TextBoxLengthF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLengthF.KeyPress
        If Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Chr(8) Then e.Handled = True
    End Sub
    '输入时码时调用函数验证输入、计算出点、切换输入焦点
    Private Sub TextBoxStartTimeH_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxStartTimeH.TextChanged
        TimeInputCheck(TextBoxStartTimeH, TextBoxStartTimeM, 99, False)
    End Sub

    Private Sub TextBoxStartTimeM_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxStartTimeM.TextChanged
        TimeInputCheck(TextBoxStartTimeM, TextBoxStartTimeS, 60, False)
    End Sub

    Private Sub TextBoxStartTimeS_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxStartTimeS.TextChanged
        TimeInputCheck(TextBoxStartTimeS, TextBoxStartTimeF, 60, False)
    End Sub

    Private Sub TextBoxStartTimeF_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxStartTimeF.TextChanged
        TimeInputCheck(TextBoxStartTimeF, TextBoxLengthH, 25, False)
    End Sub

    Private Sub TextBoxLengthH_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxLengthH.TextChanged
        TimeInputCheck(TextBoxLengthH, TextBoxLengthM, 99, True)
    End Sub

    Private Sub TextBoxLengthM_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxLengthM.TextChanged
        TimeInputCheck(TextBoxLengthM, TextBoxLengthS, 60, True)
    End Sub

    Private Sub TextBoxLengthS_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxLengthS.TextChanged
        TimeInputCheck(TextBoxLengthS, TextBoxLengthF, 60, True)
    End Sub

    Private Sub TextBoxLengthF_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
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
            CheckBoxNoStartTime.Checked = False And _
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
                CInt _
                    ( _
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
                TextBoxEndTimeF.Text = Microsoft.VisualBasic.Right _
                    ("00" & endTimeF, 2)  '结果的左边补2个0后取右边2位
                TextBoxEndTimeS.Text = Microsoft.VisualBasic.Right _
                    ("00" & endTimeS, 2)
                TextBoxEndTimeM.Text = Microsoft.VisualBasic.Right _
                    ("00" & endTimeM, 2)
                TextBoxEndTimeH.Text = Microsoft.VisualBasic.Right _
                    ("00" & endTimeH, 2)
            Else    '时长为0,结束时码与开始时码相同
                TextBoxEndTimeF.Text = TextBoxStartTimeF.Text
                TextBoxEndTimeS.Text = TextBoxStartTimeS.Text
                TextBoxEndTimeM.Text = TextBoxStartTimeM.Text
                TextBoxEndTimeH.Text = TextBoxStartTimeH.Text
            End If
        End If
    End Sub

    '输入时码后计算出点，输入焦点跳到下一个框
    Private Sub TimeInputCheck _
        (ByRef thisTextTox As TextBox, _
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
        ElseIf CheckBoxNoStartTime.Checked = False Or isLength Then
            thisTextTox.Text = "00"
            thisTextTox.Focus()
        End If
    End Sub

  '点击时码输入框时全选内容
    Private Sub TextBoxStartTimeH_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxStartTimeH.Click
        TextBoxStartTimeH.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeM_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxStartTimeM.Click
        TextBoxStartTimeM.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeS_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxStartTimeS.Click
        TextBoxStartTimeS.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeF_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxStartTimeF.Click
        TextBoxStartTimeF.SelectAll()
    End Sub

    Private Sub TextBoxLengthH_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxLengthH.Click
        TextBoxLengthH.SelectAll()
    End Sub

    Private Sub TextBoxLengthM_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxLengthM.Click
        TextBoxLengthM.SelectAll()
    End Sub

    Private Sub TextBoxLengthS_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxLengthS.Click
        TextBoxLengthS.SelectAll()
    End Sub

    Private Sub TextBoxLengthF_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles TextBoxLengthF.Click
        TextBoxLengthF.SelectAll()
    End Sub

    '非编上载无时码
    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles CheckBoxNoStartTime.Click
        If CheckBoxNoStartTime.Checked Then '非编上载
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
        Else    '磁带采集
            TextBoxStartTimeH.Text = "00"
            TextBoxStartTimeM.Text = "00"
            TextBoxStartTimeS.Text = "00"
            TextBoxStartTimeF.Text = "00"
            CalcEndTime()
            TextBoxStartTimeH.ReadOnly = False
            TextBoxStartTimeM.ReadOnly = False
            TextBoxStartTimeS.ReadOnly = False
            TextBoxStartTimeF.ReadOnly = False
            TextBoxStartTimeH.Focus()
        End If
    End Sub

    '时码补足8位
    Private Sub Time8()
        If CheckBoxNoStartTime.Checked = False Then
            TextBoxStartTimeF.Text = Microsoft.VisualBasic.Right _
                ("00" & TextBoxStartTimeF.Text, 2)  '结果的左边补2个0后取右边2位
            TextBoxStartTimeS.Text = Microsoft.VisualBasic.Right _
                ("00" & TextBoxStartTimeS.Text, 2)
            TextBoxStartTimeM.Text = Microsoft.VisualBasic.Right _
                ("00" & TextBoxStartTimeM.Text, 2)
            TextBoxStartTimeH.Text = Microsoft.VisualBasic.Right _
                ("00" & TextBoxStartTimeH.Text, 2)
        End If
        TextBoxLengthF.Text = Microsoft.VisualBasic.Right _
            ("00" & TextBoxLengthF.Text, 2)
        TextBoxLengthS.Text = Microsoft.VisualBasic.Right _
            ("00" & TextBoxLengthS.Text, 2)
        TextBoxLengthM.Text = Microsoft.VisualBasic.Right _
            ("00" & TextBoxLengthM.Text, 2)
        TextBoxLengthH.Text = Microsoft.VisualBasic.Right _
            ("00" & TextBoxLengthH.Text, 2)
    End Sub

    '焦点离开磁带名输入框，隐藏搜索结果
    Private Sub TextBoxTapeName_Leave(sender As Object, e As EventArgs) Handles TextBoxTapeName.Leave
        If Not ListBoxTapeName.Focused Then ListBoxTapeName.Hide()
    End Sub
    '焦点进入磁带名输入框，且输入框为空，搜索最近磁带名并列出
    Private Sub TextBoxTapeName_Enter(sender As Object, e As EventArgs) Handles TextBoxTapeName.Enter
        If TextBoxTapeName.Text = "" Then ReflashList("SELECT TOP 10 tape_name FROM tape ORDER by in_bc_time DESC;")
    End Sub
    '输入磁带名，更新搜索结果，根据输入的关键字搜索磁带名并列出
    Private Sub TextBoxTapeName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTapeName.TextChanged
        ReflashList("SELECT TOP 10 tape_name FROM tape Where tape_name LIKE '%" + TextBoxTapeName.Text + "%' ORDER by in_bc_time DESC;")
    End Sub
    '在磁带名输入框输入上下方向键或回车
    Private Sub TextBoxTapeName_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxTapeName.KeyDown
        If e.KeyCode = Keys.Down And ListBoxTapeName.SelectedIndex < ListBoxTapeName.Items.Count - 1 Then
            ListBoxTapeName.SelectedIndex += 1  '输入下方向键，焦点下移
        ElseIf e.KeyCode = Keys.Up And ListBoxTapeName.SelectedIndex > 0 Then
            ListBoxTapeName.SelectedIndex -= 1  '输入上方向键，焦点上移
        ElseIf e.KeyCode = Keys.Enter Then
            ListToText()    '输入回车键，选定
        End If
    End Sub
    '鼠标点击，选定
    Private Sub ListBoxTapeName_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBoxTapeName.MouseClick
        ListToText()
    End Sub
    '在listbox列出项，参数为sql语句
    Private Sub ReflashList(sqlstr As String)
        ListBoxTapeName.Items.Clear()
        Dim command As New SqlCommand(sqlstr, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            ListBoxTapeName.Items.Add(reader(0))
        End While
        reader.Close()
        If ListBoxTapeName.Items.Count <> 0 Then
            ListBoxTapeName.Height = ListBoxTapeName.Items.Count * ListBoxTapeName.ItemHeight + 4
            ListBoxTapeName.Show()
        Else
            ListBoxTapeName.Hide()
        End If
    End Sub
    '选定的磁带名填入磁带名框
    Private Sub ListToText()
        TextBoxTapeName.Text = ListBoxTapeName.Text
        ListBoxTapeName.Hide()

        '如果磁带名如“六位日期+节目名称”则自动填入已知信息
        If IsNumeric(Mid(TextBoxTapeName.Text, 1, 6)) And Mid(TextBoxTapeName.Text, 7, 1) <> "" Then
            Dim truename = Mid(TextBoxTapeName.Text, 7)
            Dim sqlstr = "SELECT TOP 2 channel, start_timecode, length FROM tape Where tape_name LIKE '%" + truename + "' ORDER by in_bc_time DESC;"
            Dim command As New SqlCommand(sqlstr, connection)
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
        End If
    End Sub
    '根据送带人搜索最近送带并列出
    Private Sub TextBoxSendPerson_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSendPerson.TextChanged
        ReflashList("SELECT TOP 10 tape_name FROM tape Where in_bc_send_per LIKE '" + TextBoxSendPerson.Text + "' ORDER by in_bc_time DESC;")
    End Sub


    Private Sub tape_receive_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        connection.Close()
        Me.Dispose()
    End Sub

Private Sub BackgroundWorker1_RunWorkerCompleted( _
    ByVal sender As Object, _
    ByVal e As RunWorkerCompletedEventArgs) _
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

    Private Sub BackgroundWorker1_ProgressChanged( _
    ByVal sender As Object, _
    ByVal e As ProgressChangedEventArgs) _
    Handles BackgroundWorker1.ProgressChanged

        ' This event handler is called after the background thread
        ' reads a line from the source file.
        ' This method runs on the main thread.

        Dim result As AccessControlQuery.AccessControlResult = _
            CType(e.UserState, AccessControlQuery.AccessControlResult)

        '查询数据库 根据name获取信息
        Dim connStr As String = "Server=" & DbServer & ";Database=" & DbDbNamme & _
                              ";User ID=" & DbUser & ";Password=" & DbPawd & _
                              ";"
        Dim connection As New SqlConnection(connStr)
        Const queryString As String = "select name, department from person where id = @id"
        Dim command As New SqlCommand(queryString, connection)
        Dim pname As String
        Dim department As String

        command.Parameters.Add(New SqlParameter("@id", result.Name))

        Try
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read Then
                pname = reader("name")
                department = reader("department")

                If department = "播出部" Then
                    TextBoxRecvPerson.Text = pname
                Else
                    TextBoxSendPerson.Text = pname
                End If

            Else
                MsgBox("数据库无此信息,请手动输入")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub BackgroundWorker1_DoWork( _
    ByVal sender As Object, _
    ByVal e As DoWorkEventArgs) _
    Handles BackgroundWorker1.DoWork

        ' This event handler is where the actual work is done.
        ' This method runs on the background thread.

        ' Get the BackgroundWorker object that raised this event.
        Dim worker As BackgroundWorker
        worker = CType(sender, BackgroundWorker)

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

    Private Sub CheckBoxTape_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTape.CheckedChanged

    End Sub

    Private Sub LabelRemark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelRemark.Click

    End Sub
End Class

