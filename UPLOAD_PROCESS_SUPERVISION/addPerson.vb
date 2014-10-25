Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AddPerson

    Private _workAcq As AccessControlQuery

    Private Sub AddPerson_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        EndThread()
    End Sub

    Private Sub AddPerson_Load _
        (ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Load
        GroupBoxPersonManage.Hide()

        '启动指纹后台
        StartThread()
    End Sub

    Private Sub ButtonLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        Dim Account = TextBoxAccount.Text
        Dim Password = TextBoxPassword.Text

        Dim queryStr As String = "select * from accessmanage " & _
                                "where " & _
                                "(person_name = @person_name) and " & _
                                "(password = @password) "

        Dim params As SqlParameter() = { _
                                New SqlParameter("@person_name", Account), _
                                New SqlParameter("@password", Password) _
                                }
        Dim conn As SqlConnection = New SqlConnection(ConnStr)
        Dim comm As SqlCommand = New SqlCommand(queryStr, conn)

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

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click

        Dim personName As String = TextBoxPersonName.Text
        If Not personName = "" Then

            Dim conn As SqlConnection = New SqlConnection(ConnStr)

            Dim queryStr1 As String = "select * from accessmanage " & _
                                     "where " & _
                                     "(person_name = @person_name)"

            Dim params1 As SqlParameter() = { _
                                    New SqlParameter("@person_name", personName) _
                                    }

            Dim comm1 As SqlCommand = New SqlCommand(queryStr1, conn)
            comm1.Parameters.AddRange(params1)


            Dim queryStr2 As String = "select * from person " & _
                                     "where " & _
                                     "(name = @name)"

            Dim params2 As SqlParameter() = { _
                                    New SqlParameter("@name", personName) _
                                    }

            Dim comm2 As SqlCommand = New SqlCommand(queryStr2, conn)
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

    Private Sub ButtonRegister_Click _
        (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonRegister.Click
        '将人员信息存入数据库


        Dim personName As String = TextBoxPersonName.Text
        Dim id As String = TextBoxID.Text
        Dim password As String = TextBoxRegPassword.Text
        Dim department As String = TextBoxDepartment.Text
        Dim telephone As String = TextBoxPhone.Text
        Dim inbc_send As Boolean = CheckBoxInBcSendPerson.Checked
        Dim inbc_recv As Boolean = CheckBoxInBcRecvPerson.Checked
        Dim outbc_send As Boolean = CheckBoxOutBcSendPerson.Checked
        Dim outbc_recv As Boolean = CheckBoxOutBcRecvPerson.Checked
        Dim upload As Boolean = CheckBoxUpload.Checked
        Dim checkup As Boolean = CheckBoxCheckup.Checked
        Dim edit As Boolean = CheckBoxEdit.Checked
        Dim admin As Boolean = CheckBoxAdmin.Checked



        '用于判断信息是否符合数据库中要求sql
        Dim conn As SqlConnection = New SqlConnection(ConnStr)
        Dim queryStr0 As String = "select * from accessmanage where person_id = @id"
        Dim com0 As SqlCommand = New SqlCommand(queryStr0, conn)
        com0.Parameters.Add(New SqlParameter("@id", id))

        '
        Const queryString As String = "insert into person (name, id, department, telephone) " & _
                                    "values (@personName, @id, @department, @telephone);"

        Dim paras() As SqlParameter = { _
                         New SqlParameter("@personName", personName), _
                         New SqlParameter("@id", id), _
                         New SqlParameter("@department", department), _
                         New SqlParameter("@telephone", telephone) _
                        }

        Const queryString2 As String = "insert into accessmanage (" & _
                                    "person_name, " & _
                                    "person_id, " & _
                                    "password, " & _
                                    "inbc_send, " & _
                                    "inbc_recv, " & _
                                    "outbc_send, " & _
                                    "outbc_recv, " & _
                                    "upload, " & _
                                    "checkup, " & _
                                    "edit, " & _
                                    "admin )" & _
                                    "values (" & _
                                    "@person_name, " & _
                                    "@person_id, " & _
                                    "@password, " & _
                                    "@inbc_send, " & _
                                    "@inbc_recv, " & _
                                    "@outbc_send, " & _
                                    "@outbc_recv, " & _
                                    "@upload, " & _
                                    "@checkup, " & _
                                    "@edit, " & _
                                    "@admin )"

        Dim paras2() As SqlParameter = { _
                         New SqlParameter("@person_name", personName), _
                         New SqlParameter("@person_id", id), _
                         New SqlParameter("@password", password), _
                         New SqlParameter("@inbc_send", inbc_send), _
                         New SqlParameter("@inbc_recv", inbc_recv), _
                         New SqlParameter("@outbc_send", outbc_send), _
                         New SqlParameter("@outbc_recv", outbc_recv), _
                         New SqlParameter("@upload", upload), _
                         New SqlParameter("@checkup", checkup), _
                         New SqlParameter("@edit", edit), _
                         New SqlParameter("@admin", admin) _
                        }

        Console.WriteLine(ConnStr)

        Dim comm As SqlCommand = New SqlCommand(queryString, conn)
        comm.Parameters.AddRange(paras)

        Dim comm2 As SqlCommand = New SqlCommand(queryString2, conn)
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

    Private Sub BackgroundWorker1_ProgressChanged _
    (ByVal sender As Object, ByVal e As ProgressChangedEventArgs) _
    Handles BackgroundWorker1.ProgressChanged

        ' This event handler is called after the background thread
        ' reads a line from the source file.
        ' This method runs on the main thread.

        Dim result As AccessControlQuery.AccessControlResult = CType _
            (e.UserState, AccessControlQuery.AccessControlResult)

        TextBoxID.Text = result.Name

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
