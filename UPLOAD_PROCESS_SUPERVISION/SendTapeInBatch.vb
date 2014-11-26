Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class SendTapeInBatch

    Private _idList As ArrayList

    Private _workAcq As AccessControlQuery

    Private Sub SendTapeInBatch_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        '结束指纹后台
        EndThread()
    End Sub

    Private Sub SendTapeInBatch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        _idList = New ArrayList(QueryForm.IdLIst)

        TextBoxSendTime.Text = Now()

        setTapeInfo()

        '启动指纹后台
        StartThread()

    End Sub

    Private Sub setTapeInfo()

        Dim whereStr As String = "where "
        Dim queryString As String = "select * from tape "
        Dim connection As New SqlConnection(ConnStr)
        Dim command As New SqlCommand()

        Dim i As Integer
        Dim param As String
        For i = 0 To _idList.Count - 1
            param = "@id" + i.ToString
            whereStr += "id=" + param + " or "
            command.Parameters.Add(New SqlParameter(param, _idList(i).Value))
        Next
        whereStr = whereStr.Remove(whereStr.Length - 3)

        command.Connection = connection
        command.CommandText = queryString + whereStr

        Try
            connection.Open()
            Dim reader As SqlDataReader = Command.ExecuteReader()
            While reader.Read()
                TextBoxTapeName.Text += reader("tape_name") + vbCrLf
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Dispose()
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Dim whereStr As String = "where "
        Dim queryString As String = "update tape set tape_status=@tape_status, " & _
                                    "out_bc_send_per=@out_bc_send_per, " & _
                                    "out_bc_recv_per=@out_bc_recv_per, " & _
                                    "out_bc_time=@out_bc_time "

        Dim outBcSendPer As String = TextBoxSendPerson.Text
        Dim outBcRecvPer As String = TextBoxRecvPerson.Text
        Dim outBcTime As String = TextBoxSendTime.Text
        Dim connection As New SqlConnection(ConnStr)
        Dim command As New SqlCommand()


        If outBcSendPer = "" Then
            MsgBox("请填发带人")
        ElseIf outBcRecvPer = "" Then
            MsgBox("请填取带人")
        Else


            Dim i As Integer
            Dim param As String
            For i = 0 To _idList.Count - 1
                param = "@id" + i.ToString
                whereStr += "id=" + param + " or "
                command.Parameters.Add(New SqlParameter(param, _idList(i).Value))
            Next
            whereStr = whereStr.Remove(whereStr.Length - 3)


            command.Connection = connection
            command.CommandText = queryString + whereStr
            command.Parameters.Add(New SqlParameter("@tape_status", StatusSendedOut))
            command.Parameters.Add(New SqlParameter("@out_bc_send_per", outBcSendPer))
            command.Parameters.Add(New SqlParameter("@out_bc_recv_per", outBcRecvPer))
            command.Parameters.Add(New SqlParameter("@out_bc_time", outBcTime))

            Try
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

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, _
                                                 ByVal e As _
                                                    ProgressChangedEventArgs) _
       Handles BackgroundWorker1.ProgressChanged

        ' This event handler is called after the background thread
        ' reads a line from the source file.
        ' This method runs on the main thread.

        Dim result As AccessControlQuery.AccessControlResult = CType(e.UserState, _
                                                                     AccessControlQuery.AccessControlResult)

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
                    TextBoxRecvPerson.Text = pname
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

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, _
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
End Class