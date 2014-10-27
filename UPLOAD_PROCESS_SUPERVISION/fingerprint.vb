Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class fingerprint
    Private Sub fingerprint_Load(ByVal sender As Object, _
                                 ByVal e As EventArgs) _
        Handles MyBase.Load
        Label2.Text = "请输入指纹，完成后请点确认键"
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, _
                              ByVal e As EventArgs) Handles Button1.Click
        'a:设置sql数据库连接
        '初始化sql server 2005数据库连接SqlConnectio对象
        ConnStr = "Server=" & DbServer & ";Database=" & DbDbNamme & ";User ID=" & _
                  DbUser & ";Password=" & DbPawd & ";"
        Dim sql2005 As SqlConnection = New SqlConnection(ConnStr)
        '打开连接
        sql2005.Open()

        '初始化一个sql命令SqlCommand对象
        Dim sqlCom As SqlCommand = New SqlCommand

        '给SqlCommand设置Connection属性
        sqlCom.Connection = sql2005

        'b:设置access数据库连接
        '初始化Access 2000数据库连接OleDbConnection对象
        Dim conn1 As New OleDbConnection
        conn1.ConnectionString = _
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ZKTime5.0\att2000.mdb;Persist Security Info=False"
        Dim com As OleDbCommand = New OleDbCommand
        com.Connection = conn1
        conn1.Open()
        Dim timeb As String
        Dim timee As String
        Dim timet = Now()
        timeb = DateAdd("n", -1, timet)  '将现在当前时间减去1分钟，用于取得最新当前打指纹的人的时间
        timee = DateAdd("n", 1, timet) '将现在当前时间加上1分钟
        '设置CommandText属性，该属性指定要执行的SQL语句或存储过程。如增删查改等等。
        com.CommandText = _
            "select USERINFO.Name,CHECKINOUT.CHECKTIME from CHECKINOUT,USERINFO where CHECKINOUT.USERID=USERINFO.USERID  order by CHECKINOUT.CHECKTIME desc"
        'com.CommandText = "select USERINFO.Name from CHECKINOUT,USERINFO,CHECKINOUT.CHECKTIME where CHECKINOUT.USERID=USERINFO.USERID   and CHECKINOUT.CHECKTIME> '" & timeb & "'  and CHECKINOUT.CHECKTIME<'" & timee & "' order by CHECKINOUT.CHECKTIME desc"
        'com.CommandText = "select USERINFO.Badgenumber,CHECKINOUT.CHECKTIME from CHECKINOUT,USERINFO where CHECKINOUT.USERID=USERINFO.USERID  order by CHECKINOUT.CHECKTIME desc"


        Dim uname As String
        Dim ctime As String
        'MessageBox.Show(com.CommandText)
        Dim reader = com.ExecuteReader() 'ExecuteReader()用于执行查询类的sql语句

        If (reader.Read()) Then
            ctime = reader("CHECKTIME")
            If (ctime > timeb And ctime < timee) Then
                uname = reader("Name") '把你要的字段的数据值取出，保存在变量中
                Console.WriteLine(uname)
                Console.WriteLine(ctime)


                'uname = uname.Trim()
                'MessageBox.Show(uname)
                ctime = reader("CHECKTIME")
                reader.Close()  '关闭一个阅读器Reader，方便后文使用其他的Reader
                Dim department = "播出部"
                ' uname = "张莉莉"
                sqlCom.CommandText = _
                    "select name from person where department='" & department & _
                    "' and name='" & uname & "'"
                Console.WriteLine(sqlCom.CommandText)
                ' MessageBox.Show(sqlCom.CommandText)
                Dim reader1 = sqlCom.ExecuteReader()
                If (reader1.Read()) Then
                    'MessageBox.Show(uname)
                    'user1 = uname
                    MessageBox.Show(uname + "恭喜，签名成功！")
                    reader1.Close()
                    Me.Close()
                Else
                    MessageBox.Show("不在指纹库中,您无权操作")
                End If
                reader1.Close()
            End If
        Else
            MessageBox.Show("签名失败，请确认您是否有权限或重新签名！")
        End If
        reader.Close()
        '关闭数据库连接
        sql2005.Close()
        conn1.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, _
                              ByVal e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class