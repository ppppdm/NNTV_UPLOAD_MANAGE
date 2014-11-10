Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Threading

Public Class ReceiveTapeInBatch

    Private _tapeRecvSendPerId As String
    Private _tapeRecvRecvPerId As String
    Private _tapeRecvSendPerDepartment As String = ""

    Private _workAcq As AccessControlQuery

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim tapeName = TextBoxTapeName.Text
        'Dim startTimecode = TextBoxStartTimeH.Text & ":" & _
        '                    TextBoxStartTimeM.Text & ":" & _
        '                    TextBoxStartTimeS.Text & ":" & _
        '                    TextBoxStartTimeF.Text
        'Dim endTimecode = TextBoxEndTimeH.Text & ":" & TextBoxEndTimeM.Text & _
        '                  ":" & TextBoxEndTimeS.Text & ":" & _
        '                  TextBoxEndTimeF.Text
        'Dim length = TextBoxLengthH.Text & ":" & TextBoxLengthM.Text & ":" & _
        '             TextBoxLengthS.Text & ":" & TextBoxLengthF.Text
        Dim inBcTime = TextBoxRecvTime.Text
        Dim inBcSendPer = TextBoxSendPerson.Text
        Dim inBcRecvPer = TextBoxRecvPerson.Text
        Dim remark = TextBoxRemark.Text
        Dim identical = CheckBoxTape.Checked
        Dim channel = ComboBoxChannel.Text
        Dim programType = ComboBoxProgramType.Text
        Dim mediaType = ComboBoxMediaType.Text
        Dim status = StatusNotUpload
        If inBcRecvPer = "" Then
            status = StatusNotRecvConfirm
        End If

        Dim numHead = NumericUpDownHead.Value  '带子开始的集数
        Dim numTail = NumericUpDownTail.Value  '带子结束的集数

        If tapeName = "" Then
            MsgBox("磁带名!")
        ElseIf inBcSendPer = "" Then
            MsgBox("送带人!")
            'ElseIf inBcRecvPer = "" Then
            '    MsgBox("收带人!")
        ElseIf identical = False Then
            MsgBox("带芯带盒不同!")
        ElseIf _tapeRecvSendPerId = Nothing Then
            MsgBox("请按指纹机确认送带人")
        Else
            '存入数据库

            Dim connection As New SqlConnection(ConnStr)

            Dim paras() As SqlParameter = _
                    {New SqlParameter("@in_bc_send_per", inBcSendPer), _
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


            Const queryString As String = "insert into tape( " & "id, " & _
                                          "tape_name, " & _
                                          "in_bc_send_per, " & _
                                          "in_bc_recv_per, " & "remark, " & _
                                          "tape_status, " & "in_bc_time, " & _
                                          "program_type, " & "identical, " & _
                                          "department, " & "in_bc_send_per_id, " & _
                                          "media_type, " & "channel ) " & _
                                          "values ( " & "@id, " & "@tape_name, " & _
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
                Dim i As Integer
                For i = numHead To numTail
                    Dim id = Guid.NewGuid()
                    Dim paramID = New SqlParameter("@id", id)
                    Dim paramTapeName = New SqlParameter("@tape_name", tapeName + i.ToString)

                    command.Parameters.Add(paramID)
                    command.Parameters.Add(paramTapeName)

                    command.ExecuteNonQuery()

                    command.Parameters.Remove(paramID)
                    command.Parameters.Remove(paramTapeName)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try

            Dispose()
        End If

    End Sub

    Private Sub ReceiveTapeInBatch_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        '结束后台线程
        EndThread()

        '主界面恢复
        QueryForm.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ReceiveTapeInBatch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        TextBoxRecvTime.Text = Now

        StartThread()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, _
                                                     ByVal e As _
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
                                                  ByVal e As _
                                                     ProgressChangedEventArgs) _
        Handles BackgroundWorker1.ProgressChanged

        ' This event handler is called after the background thread
        ' reads a line from the source file.
        ' This method runs on the main thread.

        Dim result As AccessControlQuery.AccessControlResult = CType(e.UserState, _
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
End Class