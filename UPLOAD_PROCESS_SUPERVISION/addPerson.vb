Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AddPerson
    Private _workAcq As AccessControlQuery

    Private Sub AddPerson_Disposed(ByVal sender As Object, _
                                   ByVal e As EventArgs) Handles Me.Disposed
        EndThread()
    End Sub

    Private Sub AddPerson_Load(ByVal sender As Object, _
                               ByVal e As EventArgs) Handles Me.Load
        GroupBoxPersonManage.Hide()

        '启动指纹后台
        StartThread()
    End Sub

    Private Sub ButtonLogin_Click(ByVal sender As Object, _
                                  ByVal e As EventArgs) _
        Handles ButtonLogin.Click
        Dim account = TextBoxAccount.Text
        Dim password = TextBoxPassword.Text

        Const queryStr As String = "select * from accessmanage " & "where " & _
                                   "(person_name = @person_name) and " & _
                                   "(password = @password) "

        Dim params As SqlParameter() = {New SqlParameter("@person_name", _
                                                         account), _
                                        New SqlParameter("@password", _
                                                         password)}
        Dim conn As SqlConnection = New SqlConnection(ConnStr)
        Dim comm As SqlCommand = New SqlCommand(queryStr, _
                                                conn)

        comm.Parameters.AddRange(params)

        Try
            conn.Open()
            Dim reader As SqlDataReader = comm.ExecuteReader()
            If reader.Read() Then
                'MsgBox("登录成功")
                GroupBoxPersonManage.Visible = True
            Else

                MsgBox("登录失败")
            End If
            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As Object, _
                                  ByVal e As EventArgs) _
        Handles ButtonQuery.Click

        Dim personName As String = TextBoxPersonName.Text
        If Not personName = "" Then

            Dim conn As SqlConnection = New SqlConnection(ConnStr)

            Const queryStr1 As String = "select * from accessmanage " & "where " & _
                                        "(person_name = @person_name)"

            Dim params1 As SqlParameter() = {New SqlParameter("@person_name", _
                                                              personName)}

            Dim comm1 As SqlCommand = New SqlCommand(queryStr1, _
                                                     conn)
            comm1.Parameters.AddRange(params1)


            Const queryStr2 As String = "select * from person " & "where " & _
                                        "(name = @name)"

            Dim params2 As SqlParameter() = {New SqlParameter("@name", _
                                                              personName)}

            Dim comm2 As SqlCommand = New SqlCommand(queryStr2, _
                                                     conn)
            comm2.Parameters.AddRange(params2)

            Try
                conn.Open()
                Dim reader As SqlDataReader = comm1.ExecuteReader()
                If reader.Read() Then
                    CheckBoxInBcSendPerson.Checked = reader("inbc_send")
                    CheckBoxInBcRecvPerson.Checked = reader("inbc_recv")
                    CheckBoxOutBcSendPerson.Checked = reader("outbc_send")
                    CheckBoxOutBcRecvPerson.Checked = reader("outbc_recv")
                    CheckBoxUpload.Checked = reader("upload")
                    CheckBoxCheckup.Checked = reader("checkup")
                    CheckBoxEdit.Checked = reader("edit")
                    CheckBoxAdmin.Checked = reader("admin")

                End If
                reader.Close()


                '读取人物信息
                reader = comm2.ExecuteReader()
                If reader.Read() Then
                    TextBoxPersonName.Text = reader("name")
                    TextBoxID.Text = reader("id")
                    TextBoxDepartment.Text = reader("department")
                    TextBoxPhone.Text = reader("telephone")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MsgBox("请输入查询名字")
            TextBoxPersonName.Focus()
        End If
    End Sub

    Private Sub ButtonRegister_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles ButtonRegister.Click
        '将人员信息存入数据库


        Dim personName As String = TextBoxPersonName.Text
        Dim id As String = TextBoxID.Text
        Dim password As String = TextBoxRegPassword.Text
        Dim department As String = TextBoxDepartment.Text
        Dim telephone As String = TextBoxPhone.Text
        Dim inbcSend As Boolean = CheckBoxInBcSendPerson.Checked
        Dim inbcRecv As Boolean = CheckBoxInBcRecvPerson.Checked
        Dim outbcSend As Boolean = CheckBoxOutBcSendPerson.Checked
        Dim outbcRecv As Boolean = CheckBoxOutBcRecvPerson.Checked
        Dim upload As Boolean = CheckBoxUpload.Checked
        Dim checkup As Boolean = CheckBoxCheckup.Checked
        Dim edit As Boolean = CheckBoxEdit.Checked
        Dim admin As Boolean = CheckBoxAdmin.Checked


        '用于判断信息是否符合数据库中要求sql
        Dim conn As SqlConnection = New SqlConnection(ConnStr)
        Const queryStr0 As String = "select * from accessmanage where person_id = @id"
        Dim com0 As SqlCommand = New SqlCommand(queryStr0, _
                                                conn)
        com0.Parameters.Add(New SqlParameter("@id", _
                                             id))

        '
        Const queryString As String = _
                  "insert into person (name, id, department, telephone) " & _
                  "values (@personName, @id, @department, @telephone);"

        Dim paras() As SqlParameter = {New SqlParameter("@personName", _
                                                        personName), _
                                       New SqlParameter("@id", _
                                                        id), _
                                       New SqlParameter("@department", _
                                                        department), _
                                       New SqlParameter("@telephone", _
                                                        telephone)}

        Const queryString2 As String = "insert into accessmanage (" & _
                                       "person_name, " & "person_id, " & _
                                       "password, " & "inbc_send, " & _
                                       "inbc_recv, " & "outbc_send, " & _
                                       "outbc_recv, " & "upload, " & "checkup, " & _
                                       "edit, " & "admin )" & "values (" & _
                                       "@person_name, " & "@person_id, " & _
                                       "@password, " & "@inbc_send, " & _
                                       "@inbc_recv, " & "@outbc_send, " & _
                                       "@outbc_recv, " & "@upload, " & _
                                       "@checkup, " & "@edit, " & "@admin )"

        Dim paras2() As SqlParameter = {New SqlParameter("@person_name", _
                                                         personName), _
                                        New SqlParameter("@person_id", _
                                                         id), _
                                        New SqlParameter("@password", _
                                                         password), _
                                        New SqlParameter("@inbc_send", _
                                                         inbcSend), _
                                        New SqlParameter("@inbc_recv", _
                                                         inbcRecv), _
                                        New SqlParameter("@outbc_send", _
                                                         outbcSend), _
                                        New SqlParameter("@outbc_recv", _
                                                         outbcRecv), _
                                        New SqlParameter("@upload", _
                                                         upload), _
                                        New SqlParameter("@checkup", _
                                                         checkup), _
                                        New SqlParameter("@edit", _
                                                         edit), _
                                        New SqlParameter("@admin", _
                                                         admin)}

        Console.WriteLine(ConnStr)

        Dim comm As SqlCommand = New SqlCommand(queryString, _
                                                conn)
        comm.Parameters.AddRange(paras)

        Dim comm2 As SqlCommand = New SqlCommand(queryString2, _
                                                 conn)
        comm2.Parameters.AddRange(paras2)


        '判断输入的各信息是否符合要求
        If password = "" Then
            MsgBox("密码不能为空")
        Else
            '判断信息是否符合数据库中要求sql
            Try
                conn.Open()
                Dim reader As SqlDataReader = com0.ExecuteReader()
                If reader.Read() Then

                    MsgBox("此ID已注册,请联系管理员")
                    reader.Close()
                Else
                    '可以注册
                    reader.Close()
                    comm.ExecuteNonQuery()
                    comm2.ExecuteNonQuery()
                    MsgBox("注册成功")
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
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
                                                                     AccessControlQuery _
                .AccessControlResult)

        TextBoxID.Text = result.Name
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
