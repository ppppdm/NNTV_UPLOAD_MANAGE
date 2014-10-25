Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class tape_send

    Private _tapeId As Guid

    Dim _workAcq As AccessControlQuery

    Private Sub ButtonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonCancel.Click
        Dispose()
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonOK.Click
        Dim tapeName = TextBoxTapeName.Text
        Dim outBcTime = TextBoxSendTime.Text
        Dim outBcRecvPer = TextBoxRecvPerson.Text
        Dim outBcSendPer = TextBoxSendPerson.Text

        If tapeName = "" Then
            MsgBox("磁带名!")
        ElseIf outBcSendPer = "" Then
            MsgBox("发带人!")
        ElseIf outBcRecvPer = "" Then
            MsgBox("收带人!")
        Else
            '存入数据库
            Dim connection As New SqlConnection(ConnStr)

            '打开数据库
            Try
                connection.Open()

                Const queryString As String = "update tape set " & _
                                            "out_bc_time = @out_bc_time, " & _
                                            "out_bc_send_per = @out_bc_send_per, " & _
                                            "out_bc_recv_per = @out_bc_recv_per, " & _
                                            "tape_status = @tape_status " & _
                                            "where " & _
                                            "tape_name = @tape_name"

                'Console.WriteLine(queryString)

                Dim command As New SqlCommand(queryString, connection)


                Dim paras() As SqlParameter = { _
                   New SqlParameter("@tape_name", tapeName), _
                   New SqlParameter("@out_bc_time", outBcTime), _
                   New SqlParameter("@out_bc_send_per", outBcSendPer), _
                   New SqlParameter("@out_bc_recv_per", outBcRecvPer), _
                   New SqlParameter("@tape_status", StatusSendedOut) _
                   }
                command.Parameters.AddRange(paras)

                'Console.WriteLine(command.CommandText)

                command.ExecuteReader()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connection.Close()
            End Try
            Dispose()
        End If
    End Sub

    Private Sub tape_send_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed
        '取消后台线程
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub tape_send_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        _tapeId = QueryForm.TapeId
        Dim connection As New SqlConnection(ConnStr)
        Const queryString As String = _
                  "select tape_name from tape where id = @id"
        Dim command As New SqlCommand(queryString, connection)
        command.Parameters.Add(New SqlParameter("@id", _tapeId))

        Try
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If (reader.Read()) Then
                TextBoxTapeName.Text = reader("tape_name")
            Else
                MsgBox("find tape error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        connection.Close()
        End Try

        TextBoxSendTime.Text = Now
        StartThread()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged _
        (ByVal sender As Object, ByVal e As ProgressChangedEventArgs) _
        Handles BackgroundWorker1.ProgressChanged

        ' This event handler is called after the background thread
        ' reads a line from the source file.
        ' This method runs on the main thread.

        Dim result As AccessControlQuery.AccessControlResult = CType _
            (e.UserState, AccessControlQuery.AccessControlResult)

        '查询数据库 根据name获取信息

        Dim connection As New SqlConnection(ConnStr)
        Const queryString As String = _
                  "select name, department from person where id = @id"
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
                    TextBoxSendPerson.Text = pname
                Else
                    MsgBox("非播出部人员")
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

    Private Sub BackgroundWorker1_DoWork _
        (ByVal sender As Object, ByVal e As DoWorkEventArgs) _
        Handles BackgroundWorker1.DoWork

        ' This event handler is where the actual work is done.
        ' This method runs on the background thread.

        ' Get the BackgroundWorker object that raised this event.
        Dim worker As BackgroundWorker
        worker = CType(sender, BackgroundWorker)

        ' Get the Works object and call the main method.
        Dim workAcq As AccessControlQuery = CType _
            (e.Argument, AccessControlQuery)
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