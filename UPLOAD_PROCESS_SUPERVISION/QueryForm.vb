Imports System.Data.SqlClient

Public Class QueryForm
    Public TapeId As Guid = Nothing
    Public MaterialId As Guid = Nothing
    Public IdLIst As ArrayList = New ArrayList()

    Private Sub QueryForm_load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Me.Load
        'init
        InitGlobalVariables()

        '加载QueryForm时的初始化工作
        '根据Setting的高级查询选项配置设置查询界面的高级查询选项
        SetAoQueryByAoSetting()
    End Sub

    Private Sub SendInToolStripMenuItem_Click(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles SendInToolStripMenuItem.Click
        'open tape send in windows/dialog
        TapeReceive.Show()
        'QueryForm界面最小化
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As Object, _
                                               ByVal e As EventArgs) _
        Handles OptionsToolStripMenuItem.Click
        'open setting dialog
        Setting.Show()
    End Sub

    Private Sub AddPeopleToolStripMenuItem1_Click(ByVal sender As Object, _
                                                  ByVal e As EventArgs) _
        Handles AddPeopleToolStripMenuItem1.Click
        'open add_people dialog
        AddPerson.Show()
    End Sub

    Private Sub SendTapeToolStripMenuItem_Click(ByVal sender As Object, _
                                                ByVal e As EventArgs) _
        Handles SendTapeToolStripMenuItem.Click
        TapeSend.Show()
    End Sub

    Private Sub SendInBatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendInBatchToolStripMenuItem.Click
        ReceiveTapeInBatch.Show()
        'QueryForm界面最小化
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub WatchUploadToolStripMenuItem_Click(ByVal sender As Object, _
                                                   ByVal e As EventArgs) _
        Handles WatchUploadToolStripMenuItem.Click
        WatchUpload.Show()
    End Sub

    Private Sub WatchCheckupToolStripMenuItem_Click( _
                                                    ByVal sender As _
                                                       Object, _
                                                    ByVal e As EventArgs) _
        Handles WatchCheckupToolStripMenuItem.Click
        WatchCheck.Show()
    End Sub

    Private Sub UploadToolStripMenuItem_Click(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles UploadToolStripMenuItem.Click
        '打开上载界面
        UpLoadForm.Show()
        'QueryForm界面最小化
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CheckUpToolStripMenuItem_Click(ByVal sender As Object, _
                                               ByVal e As EventArgs) _
        Handles CheckUpToolStripMenuItem.Click
        '打开审核界面
        Check.Show()
        'QueryForm界面最小化
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BackCheckToolStripMenuItem_Click(ByVal sender As Object, _
                                                 ByVal e As EventArgs) _
        Handles BackCheckToolStripMenuItem.Click
        '同样打开审核界面
        Check.Show()
        'QueryForm界面最小化
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ToolStripMenuItemRecvTapeConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemRecvTapeConfirm.Click
        TapeRecOnlyRecv.Show()
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonQuery.Click

        Dim queryDataTable As DataTable = New DataTable()
        'Dim connStr As String = "Server=" & DbServer & ";Database=" & DbDbNamme & _
        '                        ";User ID=" & DbUser & ";Password=" & DbPawd & _
        '                        ";"
        Dim connection As New SqlConnection(ConnStr)

        Try
            '打开数据库
            connection.Open()

            Dim queryString As String = GetQueryString()

            'sqlCommand
            Dim command As New SqlCommand(queryString, connection)

            'sqlDataAdapter
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)

            adapter.Fill(queryDataTable)

            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "DB Error")
        End Try

        '使用读出的数据填充dataGridView
        FillDataGridView_dt(queryDataTable)

        'Dim reader As SqlDataReader = command.ExecuteReader()

        'FillDataGridView(reader)

        '根据状态改变行的颜色
        ChangeDataGridViewRowColor()
    End Sub

    Private Function GetQueryString() As String
        Dim queryText As String = TextBoxQuery.Text
        Dim selectStr As String = ""
        Dim selectTable As String
        Dim conditionStr As String = ""
        Dim queryStr As String
        Dim joinstr As String
        Dim whereStr As String
        Dim i

        '获取查询的表格是tape还是material
        If RadioButtonTape.Checked = True Then
            '如果查询的表格是tape
            selectTable = "tape"

            '获得需要查询的列
            For i = 0 To Swo.GetLength(0) - 1
                If Swo(i, SwoValue) = True Then
                    If Swo(i, SwoDbColumnName) = "tape_status" Then
                        selectStr += "tape_status.tape_status,"
                    Else
                        selectStr += Swo(i, SwoDbColumnName) + ","
                    End If
                End If
            Next
            selectStr = selectStr.Remove(selectStr.Length - 1)

            '赋值Joinstr
            joinstr = _
                "INNER JOIN tape_status ON tape.tape_status = tape_status.code "

            '赋值WhereStr
            whereStr = "WHERE tape_name LIKE '%"

        Else
            '如果查询的表格是material
            selectTable = "material"

            '获得需要查询的列
            For i = 0 To SwoMaterial.GetLength(0) - 1
                If SwoMaterial(i, SwoValue) = True Then
                    If SwoMaterial(i, SwoDbColumnName) = "status" Then
                        selectStr += "tape_status.material_status,"
                    Else
                        selectStr += SwoMaterial(i, SwoDbColumnName) + ","
                    End If
                End If
            Next
            selectStr = selectStr.Remove(selectStr.Length - 1)

            '赋值Joinstr
            joinstr = _
                "INNER JOIN tape_status ON material.status = tape_status.code " & _
                "INNER JOIN upload ON material.id = upload.material_id "

            '赋值WhereStr
            whereStr = "WHERE material_name LIKE '%"

        End If


        '获得查询的条件
        If CheckBox3.Checked = False Then
            If CheckBox1.Checked = True Then
                conditionStr += " tape_status = 1 OR"
            End If
            If CheckBox2.Checked = True Then
                conditionStr += " tape_status = 2 OR"
            End If

            If conditionStr = "" Then
                conditionStr = "tape_status = " + Integer.MaxValue.ToString()
            Else
                conditionStr = conditionStr.Remove(conditionStr.Length - 2)
            End If

            conditionStr = "AND (" + conditionStr + ")"
        End If

        'Debug
        Console.WriteLine(queryText)
        Console.WriteLine(selectStr)
        Console.WriteLine(conditionStr)

        queryStr = "SELECT id," + selectStr + " FROM " + selectTable + " " + _
                   joinstr + whereStr + queryText + "%' " + conditionStr + ";"

        Console.WriteLine(queryStr)
        Return queryStr

        'Return "SELECT tape_name, length, tape_status.status _
        'FROM tape inner join tape_status ON tape.tape_status = tape_status.code _
        'Where tape_name LIKE '%" + queryText + "%';"
    End Function

    Private Sub FillDataGridView_dt(ByRef dt As DataTable)

        '清空原来的查询结果
        DataGridView1.Rows.Clear()

        'Console.WriteLine(dt.Rows.Count)
        Dim row As DataRow
        Dim i

        For i = 0 To dt.Rows.Count - 1
            'Console.WriteLine(dt.Rows(i).Item("tape_name"))
            'Console.WriteLine(dt.Rows(i).ItemArray.Length)
            row = dt.Rows(i)
            DataGridView1.Rows.Add(row.ItemArray)
        Next
    End Sub

    Private Sub ChangeDataGridViewRowColor()
        Dim i
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim row = DataGridView1.Rows(i)
            Try
                If row.Cells("状态").Value = "未采集" Then
                    row.DefaultCellStyle.BackColor = Color.Yellow
                End If

                If row.Cells("状态").Value = "正在采集" Then
                    row.DefaultCellStyle.BackColor = Color.Yellow
                End If

                If row.Cells("状态").Value = "未审核" Then
                    row.DefaultCellStyle.BackColor = Color.DarkGray
                End If

                If row.Cells("状态").Value = "正在审核" Then
                    row.DefaultCellStyle.BackColor = Color.Green
                End If

                If row.Cells("状态").Value = "已发带" Then
                    row.DefaultCellStyle.BackColor = Color.AntiqueWhite
                End If

                If row.Cells("状态").Value = "已送带,未确认" Then
                    row.DefaultCellStyle.BackColor = Color.FloralWhite
                End If

            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        Next
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, _
                                             ByVal e As  _
                                                DataGridViewCellMouseEventArgs) _
        Handles DataGridView1.CellMouseClick
        Dim mr As DataGridViewSelectedRowCollection = DataGridView1.SelectedRows
        Dim i
        Dim id As Guid

        '取消之前选中的行,将鼠标选中单元所在的行设置为选中
        'Console.WriteLine(DataGridView1.SelectedRows.Count)
        'For i = 0 To DataGridView1.SelectedRows.Count - 1
        '    mr(i).Selected = False
        'Next
        'If e.RowIndex >= 0 Then
        '    DataGridView1.Rows(e.RowIndex).Selected = True

        '    '记录下所选的行信息
        '    'Console.WriteLine(DataGridView1.Rows(e.RowIndex).Cells("名称").Value)
        '    id = DataGridView1.Rows(e.RowIndex).Cells("id").Value
        '    TapeId = id
        '    MaterialId = id

        '    '如果是鼠标右键点击则弹出菜单
        '    If e.Button = MouseButtons.Right Then
        '        SetContextMenuStripItemStatus(id)
        '        ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        '    End If
        'End If


        Dim dv As DataGridView = CType(sender, DataGridView)
        Dim selectedRows As DataGridViewSelectedRowCollection = dv.SelectedRows
        Dim c As Integer = selectedRows.Count

        '判断是选择了一行还是多行
        If c = 1 Then
            Console.WriteLine("select one row")
            '如果是右键点击则弹出菜单
            If e.Button = Forms.MouseButtons.Right And dv.Rows(e.RowIndex).Selected Then

                id = selectedRows.Item(0).Cells("id").Value
                TapeId = id
                MaterialId = id

                SetContextMenuStripItemStatus(id)
                ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
            End If
        ElseIf c > 1 Then
            Console.WriteLine("select multi rows")
            '
            If e.Button = Forms.MouseButtons.Right And dv.Rows(e.RowIndex).Selected Then

                IdLIst.Clear()
                For i = 0 To c - 1
                    IdLIst.Add(selectedRows.Item(i).Cells("id"))
                Next

                SetContextMenuStripItemStatusMultiRows(selectedRows)
                'SetContextMenuStripItemStatusByIds(IdLIst)
                ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
            End If
        Else
            Console.WriteLine("select " + c.ToString + " row(s)")
        End If

    End Sub

    Private Sub SetContextMenuStripItemStatus(ByVal id As Guid)
        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)

        If RadioButtonTape.Checked = True Then
            Dim queryStr As String = "select * from tape where id ='" + id.ToString() + "'"
            Dim comm As SqlCommand = New SqlCommand(queryStr, sqlconn)

            '默认情况下查询右键菜单
            UploadToolStripMenuItem.Enabled = True
            WatchUploadToolStripMenuItem.Enabled = True
            FixTimeCodeToolStripMenuItem.Enabled = True
            SendTapeToolStripMenuItem.Enabled = True
            CheckUpToolStripMenuItem.Enabled = False
            BackCheckToolStripMenuItem.Enabled = False
            WatchCheckupToolStripMenuItem.Enabled = False
            ToolStripMenuItemRecvTapeConfirm.Enabled = False
            SendTapeInBatchToolStripMenuItem.Enabled = False

            Try
                sqlconn.Open()
                Dim reader As SqlDataReader = comm.ExecuteReader()
                If reader.Read() Then
                    Dim status = reader("tape_status")
                    '如果状态是已发带
                    If status = StatusSendedOut Then
                        UploadToolStripMenuItem.Enabled = False
                        SendTapeToolStripMenuItem.Enabled = False
                        FixTimeCodeToolStripMenuItem.Enabled = False
                    End If

                    '如果状态是已送带，收带未确认
                    If status = StatusNotRecvConfirm Then
                        UploadToolStripMenuItem.Enabled = False
                        WatchUploadToolStripMenuItem.Enabled = False
                        ToolStripMenuItemRecvTapeConfirm.Enabled = True
                    End If

                End If
            Catch ex As Exception

            Finally
                sqlconn.Close()
            End Try
        End If

        If RadioButtonMaterial.Checked = True Then
            '设置查询右键菜单
            UploadToolStripMenuItem.Enabled = False
            WatchUploadToolStripMenuItem.Enabled = False
            FixTimeCodeToolStripMenuItem.Enabled = False
            SendTapeToolStripMenuItem.Enabled = False
            CheckUpToolStripMenuItem.Enabled = True
            BackCheckToolStripMenuItem.Enabled = True
            WatchCheckupToolStripMenuItem.Enabled = True
            SendTapeInBatchToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub SetContextMenuStripItemStatusByIds(ByVal ids As ArrayList)
        If RadioButtonTape.Checked Then
            '默认情况下查询右键菜单
            UploadToolStripMenuItem.Enabled = False
            WatchUploadToolStripMenuItem.Enabled = False
            FixTimeCodeToolStripMenuItem.Enabled = False
            SendTapeToolStripMenuItem.Enabled = False
            CheckUpToolStripMenuItem.Enabled = False
            BackCheckToolStripMenuItem.Enabled = False
            WatchCheckupToolStripMenuItem.Enabled = False
            ToolStripMenuItemRecvTapeConfirm.Enabled = False
            SendTapeInBatchToolStripMenuItem.Enabled = False
        End If

        If RadioButtonMaterial.Checked = True Then
            '设置查询右键菜单
            UploadToolStripMenuItem.Enabled = False
            WatchUploadToolStripMenuItem.Enabled = False
            FixTimeCodeToolStripMenuItem.Enabled = False
            SendTapeToolStripMenuItem.Enabled = False
            CheckUpToolStripMenuItem.Enabled = False
            BackCheckToolStripMenuItem.Enabled = False
            WatchCheckupToolStripMenuItem.Enabled = False
            SendTapeInBatchToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub SetContextMenuStripItemStatusMultiRows(ByVal selectedRows As DataGridViewSelectedRowCollection)
        If RadioButtonTape.Checked Then
            '默认情况下查询右键菜单
            UploadToolStripMenuItem.Enabled = False
            WatchUploadToolStripMenuItem.Enabled = False
            FixTimeCodeToolStripMenuItem.Enabled = False
            SendTapeToolStripMenuItem.Enabled = False
            CheckUpToolStripMenuItem.Enabled = False
            BackCheckToolStripMenuItem.Enabled = False
            WatchCheckupToolStripMenuItem.Enabled = False
            ToolStripMenuItemRecvTapeConfirm.Enabled = False
            SendTapeInBatchToolStripMenuItem.Enabled = False



            '如果全部都不是 已发带 则 批发带选项可选
            Dim i As System.Collections.IEnumerator = selectedRows.GetEnumerator
            Dim st As String
            Dim flag As Boolean = True
            While i.MoveNext
                Dim r As DataGridViewRow = CType(i.Current(), DataGridViewRow)
                st = r.Cells("状态").Value
                If st = "已发带" Then
                    flag = False
                    Exit While
                End If
            End While

            If flag = True Then
                SendTapeInBatchToolStripMenuItem.Enabled = True
            End If

        End If

        If RadioButtonMaterial.Checked = True Then
            '设置查询右键菜单
            UploadToolStripMenuItem.Enabled = False
            WatchUploadToolStripMenuItem.Enabled = False
            FixTimeCodeToolStripMenuItem.Enabled = False
            SendTapeToolStripMenuItem.Enabled = False
            CheckUpToolStripMenuItem.Enabled = False
            BackCheckToolStripMenuItem.Enabled = False
            WatchCheckupToolStripMenuItem.Enabled = False
            SendTapeInBatchToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub InitGlobalVariables()
        '打开并读取配置文件config.ini
        Console.WriteLine(My.Computer.FileSystem.CurrentDirectory)

        Try
            CFUtil = New ConfigFileUtil(ConfigFile)

            '初始化数据库dns
            DbServer = CFUtil.Read("DB", "Server")
            DbDbNamme = CFUtil.Read("DB", "Database")
            DbUser = CFUtil.Read("DB", "User")
            DbPawd = CFUtil.Read("DB", "PassWord")

            '初始化指纹机
            FigurePrintIP = CFUtil.Read("FigurePrint", "IP")

            '初始化摄像头
            UseCamera = CType(CFUtil.Read("Camera", "IsUse"), Boolean)

            '初始化审核点时长
            CheckHeadLen = CType(CFUtil.Read("Check", "HeadLen"), Integer)
            CheckMiddLen = CType(CFUtil.Read("Check", "MiddLen"), Integer)
            CheckTailLen = CType(CFUtil.Read("Check", "TailLen"), Integer)

            '初始化db connstr
            ConnStr = "Server=" & DbServer & ";Database=" & DbDbNamme & _
                      ";User ID=" & DbUser & ";Password=" & DbPawd & ";"

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        '读取数据库中的配置信息

        '初始化线程管理list
        MyThreadList = New ThreadList
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As Object, _
                                         ByVal e As EventArgs) _
        Handles CheckBox3.CheckedChanged
        '当选中checkbox3时,其他选项不可用
        '取消选中checkbox3时,其他选项可用
        If CheckBox3.Checked Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
        End If
    End Sub

    Private Sub RadioButtonTape_CheckedChanged(ByVal sender As Object, _
                                               ByVal e As EventArgs) _
        Handles RadioButtonTape.CheckedChanged
        If RadioButtonTape.Checked = True Then
            '初始化DataGridView
            DataGridView1.ColumnCount = 0
            '首先添加一个id列,并设置该列为隐藏
            DataGridView1.ColumnCount += 1
            DataGridView1.Columns(0).Name = "id"
            DataGridView1.Columns(0).Visible = False

            Dim i
            Dim j = 1
            For i = 0 To Swo.GetLength(0) - 1
                If Swo(i, SwoValue) = True Then
                    DataGridView1.ColumnCount += 1
                    DataGridView1.Columns(j).Name = Swo(i, SwoDataViewName)
                    DataGridView1.Columns(j).HeaderText = Swo(i, _
                                                              SwoDataViewName)
                    j += 1
                End If
            Next
        End If
    End Sub

    Private Sub RadioButtonMaterial_CheckedChanged(ByVal sender As Object, _
                                                   ByVal e As EventArgs) _
        Handles RadioButtonMaterial.CheckedChanged
        If RadioButtonMaterial.Checked = True Then
            '初始化DataGridView
            DataGridView1.ColumnCount = 0
            '首先添加一个id列,并设置该列为隐藏
            DataGridView1.ColumnCount += 1
            DataGridView1.Columns(0).Name = "id"
            DataGridView1.Columns(0).Visible = False

            Dim i
            Dim j = 1
            For i = 0 To SwoMaterial.GetLength(0) - 1
                If SwoMaterial(i, SwoValue) = True Then
                    DataGridView1.ColumnCount += 1
                    DataGridView1.Columns(j).Name = SwoMaterial(i, _
                                                                SwoDataViewName)
                    DataGridView1.Columns(j).HeaderText = SwoMaterial(i, _
                                                                      SwoDataViewName)
                    j += 1
                End If
            Next
        End If
    End Sub

    Private Sub FixTimeCodeToolStripMenuItem_Click(ByVal sender As Object, _
                                                   ByVal e As EventArgs) _
        Handles FixTimeCodeToolStripMenuItem.Click
        FixTimeCode.Show()
    End Sub

    Private Sub SetAoQueryByAoSetting()
        'Dim w As Integer
        'Dim i As Integer

        'Dim myType As Type = GetType(AdvancedOptions)
        'Dim myFieldInfo() As FieldInfo = myType.GetFields()

        'GroupBoxAoQuery.Controls.Clear()

        'For i = 0 To myFieldInfo.Length - 1
        '    Console.WriteLine(ControlChars.NewLine + "Name            : {0}", myFieldInfo(i).Name)
        '    Console.WriteLine("Declaring Type  : {0}", myFieldInfo(i).DeclaringType)
        '    Console.WriteLine("IsPublic        : {0}", myFieldInfo(i).IsPublic)
        '    Console.WriteLine("MemberType      : {0}", myFieldInfo(i).MemberType)
        '    Console.WriteLine("FieldType       : {0}", myFieldInfo(i).FieldType)
        '    Console.WriteLine("IsFamily        : {0}", myFieldInfo(i).IsFamily)
        '    Console.WriteLine("Value           : {0}", myFieldInfo(i).GetValue(Nothing))

        '    'Dim checkbox As New CheckBox()
        '    'GroupBoxAoQuery.Controls.Add(checkbox)

        '    'checkbox.AutoSize = True
        '    'checkbox.Location = New Point(200, 31)

        '    'Dim aType As Type = GetType(MVCUnit)
        '    'Dim fi() As FieldInfo = aType.GetFields
        '    'Dim j
        '    'For j = 0 To fi.Length - 1
        '    '    fi.GetValue(myFieldInfo(i))
        '    'Next
        'Next
    End Sub

    Private Sub SendTapeInBatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendTapeInBatchToolStripMenuItem.Click
        SendTapeInBatch.Show()
        WindowState = FormWindowState.Minimized
    End Sub
End Class
