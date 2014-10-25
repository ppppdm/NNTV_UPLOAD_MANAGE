Imports System.Data.SqlClient

Public Class TapeSend
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Cancel_Button.Click
        Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonGetTime.Click
        TextBoxSendTime.Text = Now
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Button1.Click
        Dim tapeName = TextBoxTapeName.Text
        Dim startTimecode = TextBoxStartTime.Text
        Dim endTimecode = TextBoxEndTime.Text
        Dim length = TextBoxLength.Text
        'Dim inBcTime = TextBoxSendTime.Text
        Dim inBcSendPer = TextBoxSendPerson.Text
        Dim inBcRecvPer = TextBoxRecvPerson.Text
        Dim remark = TextBoxRemark.Text
        Dim identical = CheckBoxTape.Checked

        If tapeName = "" Then
            MsgBox("!")
        ElseIf startTimecode = "" Then
            MsgBox("!")
        ElseIf endTimecode = "" Then
            MsgBox("!")
        ElseIf length = "" Then
            MsgBox("!")
            'ElseIf in_bc_time = "" Then
            '    MsgBox("!")
        ElseIf inBcSendPer = "" Then
            MsgBox("!")
        ElseIf inBcRecvPer = "" Then
            MsgBox("!")
        ElseIf identical = False Then
            MsgBox("带芯带盒不同!")
        Else
            '存入数据库
            Dim connection As New SqlConnection(ConnStr)

            '打开数据库
            Try
                connection.Open()

                Dim paras() As SqlParameter = _
                        {New SqlParameter("@tape_name", tapeName), _
                         New SqlParameter("@start_timecode", startTimecode), _
                         New SqlParameter("@end_timecode", endTimecode), _
                         New SqlParameter("@length", length), _
                         New SqlParameter("@in_bc_send_per", inBcSendPer), _
                         New SqlParameter("@in_bc_recv_per", inBcRecvPer), _
                         New SqlParameter("@identical", identical), _
                         New SqlParameter("@remark", remark), _
                         New SqlParameter("@tape_status", 1)}

                '
                Const queryString As String = _
                          "insert into tape(tape_name,start_timecode,end_timecode,length,in_bc_send_per,in_bc_recv_per,identical,remark,tape_status, in_bc_time) values (@tape_name,@start_timecode,@end_timecode,@length,@in_bc_send_per,@in_bc_recv_per,@identical,@remark,@tape_status, getdate());"
                'Debug
                Console.WriteLine(queryString)

                Dim command As New SqlCommand(queryString, connection)
                command.Parameters.AddRange(paras)

                Console.WriteLine(command.CommandText)

                'cmd.Parameters.AddRange(paras);
                command.ExecuteReader()
            Catch ex As Exception
                MsgBox("数据库连接失败!")
            Finally
                connection.Close()
            End Try
        End If
    End Sub
End Class
