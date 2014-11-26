Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO
Imports System.Threading.Thread
Imports System.Drawing.Imaging

Public Class Check

    Private Structure PointAPI
        Dim X As Integer
        Dim Y As Integer
    End Structure

    Private Structure Rect
        Dim Left_Renamed As Integer
        Dim Top_Renamed As Integer
        Dim Right_Renamed As Integer
        Dim Bottom_Renamed As Integer
    End Structure

    Private Const ParamKeyF5 As Integer = 100
    Private Const ParamKeyF6 As Integer = 200
    Private Const ParamKeyF7 As Integer = 300
    Private Const ParamKeyF8 As Integer = 400

    Public Const DyCheckCheckPointHead As Integer = 4
    Public Const DyCheckCheckPointMid As Integer = 5
    Public Const DyCheckCheckPointTail As Integer = 6

    Private _materialId As Guid = Nothing
    Private _checkupId As Guid = Nothing
    Private _workAcq As AccessControlQuery

    Private _cutflag1 As Integer
    Private _cutflag2 As Integer
    Private _cutflag3 As Integer
    Private _cutflag4 As Integer
    Private _flagFigure As Integer

    Dim _showing As Boolean
    Dim _mousePos As PointAPI

    Private Declare Function GetCursorPos Lib "User32" (ByRef lpPoint As PointAPI) _
        As Integer

    Private Declare Function GetWindowRect Lib "User32" (ByVal hWnd As Integer, _
                                                        ByRef lpRect As Rect) _
        As Integer

    '窗体销毁
    Private Sub Check_Disposed(ByVal sender As Object, ByVal e As EventArgs) _
        Handles Me.Disposed
        '取消后台线程
        BackgroundWorker1.CancelAsync()

        '注销热键
        UnregisterHotKey(Me.Handle, ParamKeyF5)
        UnregisterHotKey(Me.Handle, ParamKeyF6)
        UnregisterHotKey(Me.Handle, ParamKeyF7)
        UnregisterHotKey(Me.Handle, ParamKeyF8)

        '主界面恢复
        QueryForm.WindowState = FormWindowState.Normal
    End Sub

    '窗体加载
    Private Sub check_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load

        '素材id
        _materialId = QueryForm.MaterialId
        _checkupId = Guid.NewGuid()

        _cutflag1 = 0  '截图1按下的标志
        _cutflag2 = 0  '截图2按下的标志
        _cutflag3 = 0  '截图3按下的标志
        _cutflag4 = 0  '截图4按下的标志
        ButtonFinishCheck.Enabled = False
        PictureBox2.Visible = True

        '设置素材信息
        SetMaterialInfo()

        '启动指纹后台线程
        StartThread()

        '界面设置,仅显示groupbox1
        GroupBox1.Visible = True
        GroupBox2.Visible = False

        '按照panel1调整窗口大小
        Me.Height = SystemInformation.CaptionHeight + _
                    GroupBox1.Height
        Me.Width = GroupBox1.Width
        '使窗口居中
        Me.Left = (My.Computer.Screen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2

        '///////////////////在推送审点到大洋之前，不能进行截图////////////////'
        ButtonScreenShotHead.Enabled = False
        ButtonScreenShotMid.Enabled = False
        ButtonScreenShotTail.Enabled = False

        '注册热键
        RegisterHotKey(Me.Handle, ParamKeyF5, KeyModifiers.None, Keys.F5)
        RegisterHotKey(Me.Handle, ParamKeyF6, KeyModifiers.None, Keys.F6)
        RegisterHotKey(Me.Handle, ParamKeyF7, KeyModifiers.None, Keys.F7)
        RegisterHotKey(Me.Handle, ParamKeyF8, KeyModifiers.None, Keys.F8)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case id
                Case ParamKeyF5
                    DoScreenShot(PictureBox1, "check_point1_screenshot")
                    MyToast.Show("片头已截图", 2000)
                Case ParamKeyF6
                    DoScreenShot(PictureBox2, "check_point2_screenshot")
                    MyToast.Show("片中已截图", 2000)
                Case ParamKeyF7
                    DoScreenShot(PictureBox3, "check_point3_screenshot")
                    MyToast.Show("片尾已截图", 2000)
                Case ParamKeyF8
                    DoScreenShot(PictureBox4, "episode_screenshot")
                    MyToast.Show("落副已截图", 2000)
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub DoScreenShot(ByVal picBox As PictureBox, _
                             ByVal dbcolumn As String)
        WindowState = 1  '最小化程序窗口
        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim h As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size)
        picBox.Image = bmp

        '图片存储到数据库中
        StoreImgToDb(bmp, dbcolumn)

        Sleep(100) '延迟0.1秒
        WindowState = 0

        ButtonFinishCheck.Enabled = True
    End Sub

    '设置窗体素材信息
    Private Sub SetMaterialInfo()
        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)

        Dim com1 As SqlCommand = New SqlCommand
        com1.Connection = sqlconn
        com1.CommandText = _
            "select material_name, start_timecode, length from material where id='" & _
            _materialId.ToString() & "'"

        sqlconn.Open()
        '/////////////////查询上载表中要审核的节目的节目名称/////////////////////////'

        Dim reader1 = com1.ExecuteReader()
        If (reader1.Read()) Then
            LabelPMaterialName.Text = reader1("material_name")
            TextBoxStartTimeCode.Text = reader1("start_timecode")
            TextBoxLength.Text = (reader1("length"))  '显示当前编辑的节目的节目时长     
        End If
        reader1.Close()

        '根据时长，获取各审点的时码
        TextBoxCheckPointHead.Text = CheckHeadLen

        TextBoxCheckPointMid.Text = CheckMiddLen

        TextBoxCheckPointTail.Text = CheckTailLen

    End Sub

    '存储图片到数据库
    Private Sub StoreImgToDb(ByVal img As Bitmap, ByVal dbField As String)

        Dim ms As MemoryStream = New MemoryStream()
        img.Save(ms, ImageFormat.Bmp)

        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
        Dim queryString As String = "update checkup set " & _
                                    dbField + " = @screenshot " & "where " & _
                                    "checkup_id = @checkup_id"
        Dim param() As SqlParameter = _
                {New SqlParameter("@screenshot", ms.ToArray()), _
                 New SqlParameter("@checkup_id", _checkupId)}

        Dim sqlcomm As SqlCommand = New SqlCommand(queryString, sqlconn)
        sqlcomm.Parameters.AddRange(param)

        Try
            sqlconn.Open()
            sqlcomm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    '点击片头屏幕截图
    Private Sub ButtonScreenShotHead_Click(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles ButtonScreenShotHead.Click
        WindowState = 1  '最小化程序窗口

        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim h As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size)
        PictureBox1.Image = bmp

        '图片存储到数据库中
        StoreImgToDb(bmp, "check_point1_screenshot")

        'bmp.Save(ScreenShotBmpHead)

        Sleep(100) '延迟0.1秒
        WindowState = 0

        _cutflag1 = 1
        If (_cutflag1 = 1 And _cutflag2 = 1 And _cutflag3 = 1 And _cutflag4 = 1) _
            Then
            ButtonFinishCheck.Enabled = True
        End If
    End Sub

    '点击片中屏幕截图
    Private Sub ButtonScreenShotMid_Click(ByVal sender As Object, _
                                          ByVal e As EventArgs) _
        Handles ButtonScreenShotMid.Click
        WindowState = 1  '最小化程序窗口

        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim h As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size)
        PictureBox2.Image = bmp

        '图片存储到数据库中
        StoreImgToDb(bmp, "check_point2_screenshot")

        'bmp.Save(ScreenShotBmpHead)

        Sleep(100) '延迟0.1秒
        WindowState = 0

        _cutflag2 = 1
        If (_cutflag1 = 1 And _cutflag2 = 1 And _cutflag3 = 1 And _cutflag4 = 1) _
            Then
            ButtonFinishCheck.Enabled = True
        End If
    End Sub

    '点击片尾屏幕截图
    Private Sub ButtonScreenShotTail_Click(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles ButtonScreenShotTail.Click
        WindowState = 1  '最小化程序窗口

        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim h As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size)
        PictureBox3.Image = bmp

        '图片存储到数据库中
        StoreImgToDb(bmp, "check_point3_screenshot")

        'bmp.Save(ScreenShotBmpHead)

        Sleep(100) '延迟0.1秒
        WindowState = 0

        _cutflag3 = 1
        If (_cutflag1 = 1 And _cutflag2 = 1 And _cutflag3 = 1 And _cutflag4 = 1) _
            Then
            ButtonFinishCheck.Enabled = True
        End If
    End Sub

    '点击"落幅截图"
    Private Sub ButtonScreenShotDate_Click(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles ButtonScreenShotDate.Click
        WindowState = 1  '最小化程序窗口

        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim h As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size)
        PictureBox4.Image = bmp

        '图片存储到数据库中
        StoreImgToDb(bmp, "episode_screenshot")

        'bmp.Save(ScreenShotBmpHead)

        Sleep(100) '延迟0.1秒
        WindowState = 0

        CheckBoxDateEpisodeCheck.Checked = True
        _cutflag4 = 1
        If (_cutflag1 = 1 And _cutflag2 = 1 And _cutflag3 = 1 And _cutflag4 = 1) _
            Then
            ButtonFinishCheck.Enabled = True
        End If
    End Sub

    '审核开始
    Private Sub ButtonStartCheck_Click(ByVal sender As Object, _
                                       ByVal e As EventArgs) _
        Handles ButtonStartCheck.Click


        If (CheckBoxNameCheck.Checked = False) Then
            MessageBox.Show("请核对节目名称！！")
        ElseIf (CheckBoxLenCheck.Checked = False) Then
            MessageBox.Show("请核对节目时长！！")
        Else

            Dim materialName As String = LabelPMaterialName.Text
            Dim a() As Char
            ReDim a(0 To 255)
            Dim ret As String = New String(a)

            '在上载模块软件中找到素材并打开审核界面
            'Set_Button_Status("2", 44)     '勾选素材名称checkbox
            'Set_Button_Status("2", 44)
            'Sleep(200)
            '请手动勾选素材名称checkbox!!
            Set_Edit_Str(materialName, 13) '素材名称
            Set_Button_Status("2", 51)     '点击查询按钮
            Sleep(1000)
            Set_ListView_Str(ret, 0, 0, 3) '选择搜索出的素材条目

            Dim newS As String = ret.Substring(0, _
                                               LabelPMaterialName.Text.Length)

            If newS = LabelPMaterialName.Text Then
                Set_Button_Status("2", 111)    '点击默认通道审片按钮

                '推送审核点至审核界面
                Set_Audit_TimeCode(TextBoxCheckPointHead.Text, _
                                   DyCheckCheckPointHead)
                Set_Audit_TimeCode(TextBoxCheckPointMid.Text, _
                                   DyCheckCheckPointMid)
                Set_Audit_TimeCode(TextBoxCheckPointTail.Text, _
                                   DyCheckCheckPointTail)
            Else
                Set_Button_Status("2", 51)     '点击查询按钮
                Sleep(1000)
                Set_ListView_Str(ret, 0, 0, 3) '选择搜索出的素材条目
                If ret = materialName Then
                    Set_Button_Status("2", 111)    '点击默认通道审片按钮

                    '推送审核点至审核界面
                    Set_Audit_TimeCode(TextBoxCheckPointHead.Text, _
                                       DyCheckCheckPointHead)
                    Set_Audit_TimeCode(TextBoxCheckPointMid.Text, _
                                       DyCheckCheckPointMid)
                    Set_Audit_TimeCode(TextBoxCheckPointTail.Text, _
                                       DyCheckCheckPointTail)
                Else
                    MsgBox("请手动点击审片")
                End If
            End If


            Dim com2 As SqlCommand = New SqlCommand
            Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
            com2.Connection = sqlconn
            com2.CommandText = "insert into checkup (" & "tape_name, " & _
                               "check_type, " & "length, " & "check_status, " & _
                               "checkup_id, " & "material_id) " & "values (" & _
                               "@tape_name, " & "@check_type, " & "@length, " & _
                               "@check_status," & "@checkup_id, " & _
                               "@material_id)"

            Dim params As SqlParameter() = _
                    {New SqlParameter("@tape_name", LabelPMaterialName.Text), _
                     New SqlParameter("@check_type", StatusCheckingUp), _
                     New SqlParameter("@length", TextBoxLength.Text), _
                     New SqlParameter("@check_status", StatusCheckingUp), _
                     New SqlParameter("@checkup_id", _checkupId), _
                     New SqlParameter("@material_id", _materialId)}


            com2.Parameters.AddRange(params)

            Try
                sqlconn.Open()
                '往checkup表中插入一条数据
                com2.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                sqlconn.Close()
            End Try

            '开始审核后仅显示groupbox2,并使界面靠在显示器右侧
            GroupBox1.Visible = False
            GroupBox2.Visible = True

            '调整groupbox2在窗口的位置
            GroupBox2.Location = New Point(0, 0)

            '调整窗口大小
            Me.Height = SystemInformation.CaptionHeight + _
                        GroupBox2.Height
            Me.Width = GroupBox2.Width

            '调整窗口位置
            Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width
            Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2

            '将窗口前置
            Me.TopMost = True

            '设置截图按钮可用
            ButtonScreenShotHead.Enabled = True
            ButtonScreenShotMid.Enabled = True
            ButtonScreenShotTail.Enabled = True
        End If
    End Sub

    '审核完成
    Private Sub ButtonFinishCheck_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles ButtonFinishCheck.Click

        If (_flagFigure = 0) Then
            MessageBox.Show("请进行指纹签名！！")
        ElseIf (CheckBoxDateEpisodeCheck.Checked = False) Then
            MessageBox.Show("请核对落幅日期或集数！！")

        ElseIf (CheckBoxSoundPicSyncCheck.Checked = False) Then
            MessageBox.Show("请检查声画是否同步！！")

        ElseIf (CheckBoxVolumeCheck.Checked = False) Then
            MessageBox.Show("请检查音量是否正常！！")
        Else
            Dim daytime = Now()
            Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)

            '更新表checkup
            Const sqlquery1 As String = "update checkup set " & _
                                        "date_or_episode_check = @date_or_episode_check, " & _
                                        "sound_picture_sync = @sound_picture_sync, " & _
                                        "volume_check = @volume_check, " & _
                                        "check_point1_timecode = @check_point1_timecode, " & _
                                        "check_point2_timecode = @check_point2_timecode, " & _
                                        "check_point3_timecode = @check_point3_timecode, " & _
                                        "check_status = @check_status, " & _
                                        "remark = @remark, " & _
                                        "check_person = @check_person, " & _
                                        "check_time = @check_time " & "where " & _
                                        "checkup_id = @checkup_id"

            Dim com1 As SqlCommand = New SqlCommand(sqlquery1, sqlconn)
            Dim params1 As SqlParameter() = _
                    {New SqlParameter("@date_or_episode_check", _
                                      CheckBoxDateEpisodeCheck.Checked), _
                     New SqlParameter("@sound_picture_sync", _
                                      CheckBoxSoundPicSyncCheck.Checked), _
                     New SqlParameter("@volume_check", _
                                      CheckBoxVolumeCheck.Checked), _
                     New SqlParameter("@check_point1_timecode", _
                                      TextBoxCheckPointHead.Text), _
                     New SqlParameter("@check_point2_timecode", _
                                      TextBoxCheckPointMid.Text), _
                     New SqlParameter("@check_point3_timecode", _
                                      TextBoxCheckPointTail.Text), _
                     New SqlParameter("@check_status", StatusHaveCheckUp), _
                     New SqlParameter("@remark", TextBoxRemark.Text), _
                     New SqlParameter("@check_person", TextBoxChecker.Text), _
                     New SqlParameter("@check_time", daytime), _
                     New SqlParameter("@checkup_id", _checkupId)}
            com1.Parameters.AddRange(params1)

            '更新表material_id
            'Const sqlquery2 As String = "update material set " & _
            '                            "status = @status, " & _
            '                            "start_timecode = @start_timecode, " & _
            '                            "end_timecode = @end_timecode " & "where " & _
            '                            "id = @material_id"


            Const sqlquery2 As String = "update material set " & _
                                        "status = @status " & _
                                        "where " & _
                                        "id = @material_id"

            Dim com2 As SqlCommand = New SqlCommand(sqlquery2, sqlconn)
            'bug
            Dim params2 As SqlParameter() = _
                    {New SqlParameter("@status", StatusHaveCheckUp), _
                     New SqlParameter("@material_id", _materialId)}
            '        New SqlParameter("@start_timecode", "00:00:00:00"), _
            '        New SqlParameter("@end_timecode", "11"), _
            com2.Parameters.AddRange(params2)


            Try
                sqlconn.Open()
                com1.ExecuteNonQuery()
                com2.ExecuteNonQuery()
                MessageBox.Show("完成审核")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                sqlconn.Close()
            End Try

            Me.Dispose()
        End If
    End Sub

    '取消审核
    Private Sub ButtonCancelCheck_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles ButtonCancelCheck.Click
        Dim daytime = Now()
        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
        Const sqlquery1 As String = "update checkup set " & _
                                    "date_or_episode_check = @date_or_episode_check, " & _
                                    "sound_picture_sync = @sound_picture_sync, " & _
                                    "volume_check = @volume_check, " & _
                                    "check_point1_timecode = @check_point1_timecode, " & _
                                    "check_point2_timecode = @check_point2_timecode, " & _
                                    "check_point3_timecode = @check_point3_timecode, " & _
                                    "check_status = @check_status, " & _
                                    "remark = @remark, " & _
                                    "check_person = @check_person, " & _
                                    "check_time = @check_time " & "where " & _
                                    "checkup_id = @checkup_id"

        Dim com1 As SqlCommand = New SqlCommand(sqlquery1, sqlconn)
        Dim params1 As SqlParameter() = _
                {New SqlParameter("@date_or_episode_check", _
                                  CheckBoxDateEpisodeCheck.Checked), _
                 New SqlParameter("@sound_picture_sync", _
                                  CheckBoxSoundPicSyncCheck.Checked), _
                 New SqlParameter("@volume_check", CheckBoxVolumeCheck.Checked), _
                 New SqlParameter("@check_point1_timecode", _
                                  TextBoxCheckPointHead.Text), _
                 New SqlParameter("@check_point2_timecode", _
                                  TextBoxCheckPointMid.Text), _
                 New SqlParameter("@check_point3_timecode", _
                                  TextBoxCheckPointTail.Text), _
                 New SqlParameter("@check_status", StatusFailCheckUp), _
                 New SqlParameter("@remark", TextBoxRemark.Text), _
                 New SqlParameter("@check_person", TextBoxChecker.Text), _
                 New SqlParameter("@check_time", daytime), _
                 New SqlParameter("@checkup_id", _checkupId)}
        com1.Parameters.AddRange(params1)


        Const sqlquery2 As String = "update material set " & "status = @status " & _
                                    "where " & "id = @material_id"
        Dim com2 As SqlCommand = New SqlCommand(sqlquery2, sqlconn)
        Dim params2 As SqlParameter() = _
                {New SqlParameter("@status", StatusFailCheckUp), _
                 New SqlParameter("@material_id", _materialId)}
        com2.Parameters.AddRange(params2)

        Try
            sqlconn.Open()
            com1.ExecuteNonQuery()
            com2.ExecuteNonQuery()
            MessageBox.Show("素材审核已取消")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try

        Me.Dispose()
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

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, _
                                                  ByVal e As  _
                                                     ProgressChangedEventArgs) _
        Handles BackgroundWorker1.ProgressChanged

        ' This event handler is called after the background thread
        ' reads a line from the source file.
        ' This method runs on the main thread.

        Dim result As AccessControlQuery.AccessControlResult = CType(e.UserState,  _
                                                                     AccessControlQuery.AccessControlResult)

        '查询数据库 根据name获取信息
        Dim connStr As String = "Server=" & DbServer & ";Database=" & DbDbNamme & _
                                ";User ID=" & DbUser & ";Password=" & DbPawd & _
                                ";"
        Dim connection As New SqlConnection(connStr)
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
                    TextBoxChecker.Text = pname
                Else
                    MsgBox("非播出部人员")
                End If

            Else
                MsgBox("数据库无此信息,请手动输入")
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("数据库连接失败!")
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub GroupBox1_MouseMove(ByVal sender As Object, _
                                    ByVal e As  _
                                       MouseEventArgs) _
        Handles GroupBox1.MouseMove
        'Dim Button As Short = EventArgs.Button \ &H100000
        'Dim shift As Short = ModifierKeys \ &H10000
        'Dim X As Single = PixelsToTwipsX(e.X)
        'Dim Y As Single = PixelsToTwipsY(e.Y) '经过

        If _
            PixelsToTwipsX(Me.Left) = _
            PixelsToTwipsX( _
                Screen.PrimaryScreen.Bounds.Width) - 75 _
            Then '已被隐藏，符合出现的条件
            _showing = True
            Do _
                Until _
                    PixelsToTwipsX(Me.Left) <= _
                    PixelsToTwipsX( _
                        Screen.PrimaryScreen.Bounds.Width) - _
                    PixelsToTwipsX(Me.Width) + 70 '出现
                Application.DoEvents()
                Me.Left = TwipsToPixelsX(PixelsToTwipsX(Me.Left) - 50)
            Loop
            Me.Left = _
                TwipsToPixelsX( _
                    PixelsToTwipsX( _
                        Screen.PrimaryScreen.Bounds.Width) - _
                    PixelsToTwipsX(Me.Width) + 70)
            _showing = False
        End If
        If Timer1.Enabled = False Then Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, _
                            ByVal e As EventArgs) Handles Timer1.Tick
        GetCursorPos(_mousePos)
        Dim F As Rect
        GetWindowRect(Me.Handle.ToInt32, F) '得到窗体的位置
        If _
            _mousePos.X < F.Left_Renamed Or _mousePos.X > F.Right_Renamed Or _
            _mousePos.Y < F.Top_Renamed Or _mousePos.Y > F.Bottom_Renamed Then
            If _showing = True Then Exit Sub
            Timer1.Enabled = False
            If _
                PixelsToTwipsX(Me.Left) >= _
                PixelsToTwipsX( _
                    Screen.PrimaryScreen.Bounds.Width) - _
                PixelsToTwipsX(Me.Width) Then '窗体被拉到屏幕最右端
                Do _
                    Until _
                        PixelsToTwipsX(Me.Left) >= _
                        PixelsToTwipsX( _
                            Screen.PrimaryScreen.Bounds. _
                                              Width) - 70 '隐藏
                    Application.DoEvents()
                    Me.Left = _
                        TwipsToPixelsX(PixelsToTwipsX(Me.Left) + 50)
                Loop
                Me.Left = _
                    TwipsToPixelsX( _
                        PixelsToTwipsX( _
                            Screen.PrimaryScreen.Bounds. _
                                              Width) - 70)
            End If
        End If
    End Sub

    Private Sub GroupBox2_MouseMove(ByVal sender As Object, _
                                    ByVal e As  _
                                       MouseEventArgs) _
        Handles GroupBox2.MouseMove
        'Dim Button As Short = EventArgs.Button \ &H100000
        'Dim Shift As Short = ModifierKeys \ &H10000
        'Dim X As Single = PixelsToTwipsX(e.X)
        'Dim Y As Single = PixelsToTwipsY(e.Y) '经过

        If _
            PixelsToTwipsX(Me.Left) = _
            PixelsToTwipsX( _
                Screen.PrimaryScreen.Bounds.Width) - 75 _
            Then '已被隐藏，符合出现的条件
            _showing = True
            Do _
                Until _
                    PixelsToTwipsX(Me.Left) <= _
                    PixelsToTwipsX( _
                        Screen.PrimaryScreen.Bounds.Width) - _
                    PixelsToTwipsX(Me.Width) + 70 '出现
                Application.DoEvents()
                Me.Left = TwipsToPixelsX(PixelsToTwipsX(Me.Left) - 50)
            Loop
            Me.Left = _
                TwipsToPixelsX( _
                    PixelsToTwipsX( _
                        Screen.PrimaryScreen.Bounds.Width) - _
                    PixelsToTwipsX(Me.Width) + 70)
            _showing = False
        End If
        If Timer1.Enabled = False Then Timer1.Enabled = True
    End Sub

    Private Sub TextBoxChecker_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxChecker.TextChanged
        If Not TextBoxChecker.Text = "" Then
            _flagFigure = 1
        Else
            _flagFigure = 0
        End If
    End Sub

    Private Sub PictureBox1_MouseDoubleClick(ByVal sender As Object, _
                                             ByVal e As  _
                                                MouseEventArgs) _
        Handles PictureBox1.MouseDoubleClick
        If Not PictureBox1.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox1.Image)
        End If

        If Not PictureBox2.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox2.Image)
        End If

        If Not PictureBox3.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox3.Image)
        End If

        If Not PictureBox4.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox4.Image)
        End If

        ImageViewer.Show()
    End Sub

    Private Sub PictureBox2_MouseDoubleClick(ByVal sender As Object, _
                                             ByVal e As  _
                                                MouseEventArgs) _
        Handles PictureBox2.MouseDoubleClick
        If Not PictureBox1.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox1.Image)
        End If

        If Not PictureBox2.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox2.Image)
        End If

        If Not PictureBox3.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox3.Image)
        End If

        If Not PictureBox4.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox4.Image)
        End If

        ImageViewer.Show()
    End Sub

    Private Sub PictureBox3_MouseDoubleClick(ByVal sender As Object, _
                                             ByVal e As  _
                                                MouseEventArgs) _
        Handles PictureBox3.MouseDoubleClick
        If Not PictureBox1.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox1.Image)
        End If

        If Not PictureBox2.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox2.Image)
        End If

        If Not PictureBox3.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox3.Image)
        End If

        If Not PictureBox4.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox4.Image)
        End If

        ImageViewer.Show()
    End Sub

    Private Sub PictureBox4_MouseDoubleClick(ByVal sender As Object, _
                                             ByVal e As  _
                                                MouseEventArgs) _
        Handles PictureBox4.MouseDoubleClick
        If Not PictureBox1.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox1.Image)
        End If

        If Not PictureBox2.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox2.Image)
        End If

        If Not PictureBox3.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox3.Image)
        End If

        If Not PictureBox4.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBox4.Image)
        End If

        ImageViewer.Show()
    End Sub
End Class
'