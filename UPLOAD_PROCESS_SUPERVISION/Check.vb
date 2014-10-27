Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO
Imports System.Threading.Thread

Public Class Check
    Private _materialId As Guid = Nothing
    Private _checkupId As Guid = Nothing
    Private _workAcq As AccessControlQuery

    Private Const _paramKeyF5 As Integer = 100
    Private Const _paramKeyF6 As Integer = 200
    Private Const _paramKeyF7 As Integer = 300
    Private Const _paramKeyF8 As Integer = 400

    Private cutflag1 As Integer
    Private cutflag2 As Integer
    Private cutflag3 As Integer
    Private cutflag4 As Integer
    Private _flagFigure As Integer

    Private Const ScreenShotJpgHead = "screenShotJpgHead.jpg"

    Private Const ScreenShotJpgMid = "ScreenShotJpgMid.jpg"

    Private Const ScreenShotJpgTail = "ScreenShotJpgTail.jpg"

    Private Const ScreenShotJpgEsp = "ScreenShotJpgEsp.jpg"

    Private Const ScreenShotBmpHead = "ScreenShotBmpHead.bmp"

    Private Const ScreenShotBmpMid = "ScreenShotBmpMid.bmp"

    Private Const ScreenShotBmpTail = "ScreenShotBmpTail.bmp"

    Private Const ScreenShotBmpEsp = "ScreenShotBmpEsp.bmp"

    Public Declare Function Set_Audit_TimeCode Lib "APIHOOK_DLL_AUDIT" _
           (ByVal a As String, ByRef b As Integer) As Integer

    Public DY_Check_CheckPointHead As Integer = 4
    Public DY_Check_CheckPointMid As Integer = 5
    Public DY_Check_CheckPointTail As Integer = 6

    Dim Showing As Boolean

    Dim MousePos As POINTAPI

    Private Declare Function GetCursorPos Lib "User32" _
            (ByRef lpPoint As POINTAPI) As Integer

    Private Declare Function GetWindowRect Lib "User32" _
            (ByVal hWnd As Integer, ByRef lpRect As RECT) As Integer

    Private Structure POINTAPI
        Dim X As Integer
        Dim Y As Integer
    End Structure

    Private Structure RECT
        Dim Left_Renamed As Integer
        Dim Top_Renamed As Integer
        Dim Right_Renamed As Integer
        Dim Bottom_Renamed As Integer
    End Structure

    '窗体销毁
    Private Sub Check_Disposed _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles Me.Disposed
        '取消后台线程
        BackgroundWorker1.CancelAsync()

        '注销热键
        UnregisterHotKey(Me.Handle, _paramKeyF5)
        UnregisterHotKey(Me.Handle, _paramKeyF6)
        UnregisterHotKey(Me.Handle, _paramKeyF7)
        UnregisterHotKey(Me.Handle, _paramKeyF8)

        '主界面恢复
        QueryForm.WindowState = FormWindowState.Normal
    End Sub

    '窗体加载
    Private Sub check_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load

        '素材id
        _materialId = QueryForm.MaterialId
        _checkupId = Guid.NewGuid()

        cutflag1 = 0  '截图1按下的标志
        cutflag2 = 0  '截图2按下的标志
        cutflag3 = 0  '截图3按下的标志
        cutflag4 = 0  '截图4按下的标志
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
        Me.Height = System.Windows.Forms.SystemInformation.CaptionHeight + GroupBox1.Height
        Me.Width = GroupBox1.Width
        '使窗口居中
        Me.Left = (My.Computer.Screen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2

        '///////////////////在推送审点到大洋之前，不能进行截图////////////////'
        ButtonScreenShotHead.Enabled = False
        ButtonScreenShotMid.Enabled = False
        ButtonScreenShotTail.Enabled = False

        '注册热键
        RegisterHotKey(Me.Handle, _paramKeyF5, KeyModifiers.None, Keys.F5)
        RegisterHotKey(Me.Handle, _paramKeyF6, KeyModifiers.None, Keys.F6)
        RegisterHotKey(Me.Handle, _paramKeyF7, KeyModifiers.None, Keys.F7)
        RegisterHotKey(Me.Handle, _paramKeyF8, KeyModifiers.None, Keys.F8)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case id
                Case _paramKeyF5
                    DoScreenShot(PictureBox1, "check_point1_screenshot")
                Case _paramKeyF6
                    DoScreenShot(PictureBox2, "check_point2_screenshot")
                Case _paramKeyF7
                    DoScreenShot(PictureBox3, "check_point3_screenshot")
                Case _paramKeyF8
                    DoScreenShot(PictureBox4, "episode_screenshot")
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub DoScreenShot(ByVal picBox As PictureBox, ByVal dbcolumn As String)
        WindowState = 1  '最小化程序窗口
        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim h As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, My.Computer.Screen.WorkingArea.Size)
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


        'Dim com4 As SqlCommand = New SqlCommand
        'com4.Connection = sqlconn
        'com4.CommandText = "select * from longset"
        'Dim reader2 = com4.ExecuteReader()
        'Dim blong, _
        '    mlong, _
        '    elong As Single
        'If (reader2.Read()) Then
        '    blong = (reader2("blong"))  '获取片头30秒的位置 
        '    mlong = (reader2("mlong"))  '获取片中30秒的位置 
        '    elong = (reader2("elong"))  '获取片尾30秒的位置 
        'End If
        'reader2.Close()
        'sqlconn.Close()

        '根据时长，获取各审点的时码
        TextBoxCheckPointHead.Text = CheckHeadLen
        'MessageBox.Show(TextBoxCheckPointHead.Text)

        TextBoxCheckPointMid.Text = CheckMiddLen
        'MessageBox.Show(mtc.Text)

        TextBoxCheckPointTail.Text = CheckTailLen
        'MessageBox.Show(etc.Text)
    End Sub

    '计算审核点
    Private Function CalculateCheckTime(ByVal lengthS As String, ByVal checkPoint As Single)
        Dim len(), _
            len_var(4) As String
        Dim len1(4), _
            len_long, _
            len_b As Integer
        len = Split(lengthS, ":")
        ' MessageBox.Show(len(0) + ":" + len(1) + ":" + len(2) + ":" + len(3))

        len1(0) = Val(len(0))
        len1(1) = Val(len(1))
        len1(2) = Val(len(2))
        len1(3) = Val(len(3))
        len_long = len1(0) * 60 * 60 * 24 + len1(1) * 60 * 24 + len1(2) * 24 + len1(3)
        len_b = len_long * checkPoint
        ' MessageBox.Show(len_b)
        len_var(0) = CStr(Fix((len_b / (60 * 60 * 24)))) '时码的时
        len_var(1) = CStr(CInt((len_b Mod (60 * 60 * 24)) / (60 * 24))) '时码的分
        len_var(2) = CStr(Fix((len_b Mod (60 * 24)) / 24)) '时码的秒
        len_var(3) = CStr(len_b Mod 24) '时码的帧
        'MessageBox.Show(len_var(1))
        If ((len_var(0).Length = 1)) Then
            len_var(0) = "0" + len_var(0)
        End If
        If ((len_var(1).Length = 1)) Then
            len_var(1) = "0" + len_var(1)
        End If
        If ((len_var(2).Length = 1)) Then
            len_var(2) = "0" + len_var(2)
        End If
        If ((len_var(3).Length = 1)) Then
            len_var(3) = "0" + len_var(3)
        End If
        Return len_var(0) + ":" + len_var(1) + ":" + _
                                     len_var(2) + ":" + len_var(3) ' 片头审点时码
    End Function

    '存储图片到数据库
    Private Sub StoreImgToDb(ByVal img As Bitmap, ByVal dbField As String)

        Dim ms As MemoryStream = New MemoryStream()
        img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)

        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
        Dim queryString As String = "update checkup set " & _
                                    dbField + " = @screenshot " & _
                                    "where " & _
                                    "checkup_id = @checkup_id"
        Dim param() As SqlParameter = { _
                                      New SqlParameter("@screenshot", ms.ToArray()), _
                                      New SqlParameter("@checkup_id", _checkupId) _
                                      }

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
    Private Sub ButtonScreenShotHead_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonScreenShotHead.Click
        WindowState = 1  '最小化程序窗口

        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim h As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, My.Computer.Screen.WorkingArea.Size)
        PictureBox1.Image = bmp

        '图片存储到数据库中
        StoreImgToDb(bmp, "check_point1_screenshot")

        'bmp.Save(ScreenShotBmpHead)

        Sleep(100) '延迟0.1秒
        WindowState = 0

        cutflag1 = 1
        If _
            (cutflag1 = 1 And cutflag2 = 1 And cutflag3 = 1 And cutflag4 = 1) Then
            ButtonFinishCheck.Enabled = True
        End If
    End Sub

    '点击片中屏幕截图
    Private Sub ButtonScreenShotMid_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonScreenShotMid.Click
        WindowState = 1  '最小化程序窗口

        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim h As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, My.Computer.Screen.WorkingArea.Size)
        PictureBox2.Image = bmp

        '图片存储到数据库中
        StoreImgToDb(bmp, "check_point2_screenshot")

        'bmp.Save(ScreenShotBmpHead)

        Sleep(100) '延迟0.1秒
        WindowState = 0

        cutflag2 = 1
        If _
            (cutflag1 = 1 And cutflag2 = 1 And cutflag3 = 1 And cutflag4 = 1) Then
            ButtonFinishCheck.Enabled = True
        End If
    End Sub

    '点击片尾屏幕截图
    Private Sub ButtonScreenShotTail_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonScreenShotTail.Click
        WindowState = 1  '最小化程序窗口

        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim h As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, My.Computer.Screen.WorkingArea.Size)
        PictureBox3.Image = bmp

        '图片存储到数据库中
        StoreImgToDb(bmp, "check_point3_screenshot")

        'bmp.Save(ScreenShotBmpHead)

        Sleep(100) '延迟0.1秒
        WindowState = 0

        cutflag3 = 1
        If _
            (cutflag1 = 1 And cutflag2 = 1 And cutflag3 = 1 And cutflag4 = 1) Then
            ButtonFinishCheck.Enabled = True
        End If
    End Sub

    '点击"落幅截图"
    Private Sub ButtonScreenShotDate_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonScreenShotDate.Click
        WindowState = 1  '最小化程序窗口

        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim h As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, My.Computer.Screen.WorkingArea.Size)
        PictureBox4.Image = bmp

        '图片存储到数据库中
        StoreImgToDb(bmp, "episode_screenshot")

        'bmp.Save(ScreenShotBmpHead)

        Sleep(100) '延迟0.1秒
        WindowState = 0

        CheckBoxDateEpisodeCheck.Checked = True
        cutflag4 = 1
        If _
            (cutflag1 = 1 And cutflag2 = 1 And cutflag3 = 1 And cutflag4 = 1) Then
            ButtonFinishCheck.Enabled = True
        End If
    End Sub

    '审核开始
    Private Sub ButtonStartCheck_Click _
    (ByVal sender As Object, ByVal e As EventArgs) _
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

            Dim newS As String = ret.Substring(0, LabelPMaterialName.Text.Length)

            If newS = LabelPMaterialName.Text Then
                Set_Button_Status("2", 111)    '点击默认通道审片按钮

                '推送审核点至审核界面
                Set_Audit_TimeCode(TextBoxCheckPointHead.Text, DY_Check_CheckPointHead)
                Set_Audit_TimeCode(TextBoxCheckPointMid.Text, DY_Check_CheckPointMid)
                Set_Audit_TimeCode(TextBoxCheckPointTail.Text, DY_Check_CheckPointTail)
            Else
                Set_Button_Status("2", 51)     '点击查询按钮
                Sleep(1000)
                Set_ListView_Str(ret, 0, 0, 3) '选择搜索出的素材条目
                If ret = materialName Then
                    Set_Button_Status("2", 111)    '点击默认通道审片按钮

                    '推送审核点至审核界面
                    Set_Audit_TimeCode(TextBoxCheckPointHead.Text, DY_Check_CheckPointHead)
                    Set_Audit_TimeCode(TextBoxCheckPointMid.Text, DY_Check_CheckPointMid)
                    Set_Audit_TimeCode(TextBoxCheckPointTail.Text, DY_Check_CheckPointTail)
                Else
                    MsgBox("请手动点击审片")
                End If
            End If


            Dim com2 As SqlCommand = New SqlCommand
            Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
            com2.Connection = sqlconn
            com2.CommandText = "insert into checkup (" & _
                               "tape_name, " & _
                               "check_type, " & _
                               "length, " & _
                               "check_status, " & _
                               "checkup_id, " & _
                               "material_id) " & _
                               "values (" & _
                               "@tape_name, " & _
                               "@check_type, " & _
                               "@length, " & _
                               "@check_status," & _
                               "@checkup_id, " & _
                               "@material_id)"

            Dim params As SqlParameter() = {New SqlParameter("@tape_name", LabelPMaterialName.Text), _
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
            Me.Height = System.Windows.Forms.SystemInformation.CaptionHeight + _
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
    Private Sub ButtonFinishCheck_Click _
        (ByVal sender As Object, ByVal e As EventArgs) _
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
            Dim sqlquery1 As String = "update checkup set " & _
                                     "date_or_episode_check = @date_or_episode_check, " & _
                                     "sound_picture_sync = @sound_picture_sync, " & _
                                     "volume_check = @volume_check, " & _
                                     "check_point1_timecode = @check_point1_timecode, " & _
                                     "check_point2_timecode = @check_point2_timecode, " & _
                                     "check_point3_timecode = @check_point3_timecode, " & _
                                     "check_status = @check_status, " & _
                                     "remark = @remark, " & _
                                     "check_person = @check_person, " & _
                                     "check_time = @check_time " & _
                                     "where " & _
                                     "checkup_id = @checkup_id"

            Dim com1 As SqlCommand = New SqlCommand(sqlquery1, sqlconn)
            Dim params1 As SqlParameter() = {New SqlParameter("@date_or_episode_check", CheckBoxDateEpisodeCheck.Checked), _
                                            New SqlParameter("@sound_picture_sync", CheckBoxSoundPicSyncCheck.Checked), _
                                            New SqlParameter("@volume_check", CheckBoxVolumeCheck.Checked), _
                                            New SqlParameter("@check_point1_timecode", TextBoxCheckPointHead.Text), _
                                            New SqlParameter("@check_point2_timecode", TextBoxCheckPointMid.Text), _
                                            New SqlParameter("@check_point3_timecode", TextBoxCheckPointTail.Text), _
                                            New SqlParameter("@check_status", StatusHaveCheckUp), _
                                            New SqlParameter("@remark", TextBoxRemark.Text), _
                                            New SqlParameter("@check_person", TextBoxChecker.Text), _
                                            New SqlParameter("@check_time", daytime), _
                                            New SqlParameter("@checkup_id", _checkupId)}
            com1.Parameters.AddRange(params1)

            '更新表material_id
            Dim sqlquery2 As String = "update material set " & _
                                      "status = @status, " & _
                                      "start_timecode = @start_timecode, " & _
                                      "end_timecode = @end_timecode " & _
                                      "where " & _
                                      "id = @material_id"

            Dim com2 As SqlCommand = New SqlCommand(sqlquery2, sqlconn)
            'bug
            Dim params2 As SqlParameter() = {New SqlParameter("@status", StatusHaveCheckUp), _
                                            New SqlParameter("@start_timecode", "00:00:00:00"), _
                                            New SqlParameter("@end_timecode", "11"), _
                                            New SqlParameter("@material_id", _materialId)}
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
    Private Sub ButtonCancelCheck_Click _
        (ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles ButtonCancelCheck.Click
        Dim daytime = Now()
        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
        Dim sqlquery1 As String = "update checkup set " & _
                                 "date_or_episode_check = @date_or_episode_check, " & _
                                 "sound_picture_sync = @sound_picture_sync, " & _
                                 "volume_check = @volume_check, " & _
                                 "check_point1_timecode = @check_point1_timecode, " & _
                                 "check_point2_timecode = @check_point2_timecode, " & _
                                 "check_point3_timecode = @check_point3_timecode, " & _
                                 "check_status = @check_status, " & _
                                 "remark = @remark, " & _
                                 "check_person = @check_person, " & _
                                 "check_time = @check_time " & _
                                 "where " & _
                                 "checkup_id = @checkup_id"

        Dim com1 As SqlCommand = New SqlCommand(sqlquery1, sqlconn)
        Dim params1 As SqlParameter() = {New SqlParameter("@date_or_episode_check", CheckBoxDateEpisodeCheck.Checked), _
                                        New SqlParameter("@sound_picture_sync", CheckBoxSoundPicSyncCheck.Checked), _
                                        New SqlParameter("@volume_check", CheckBoxVolumeCheck.Checked), _
                                        New SqlParameter("@check_point1_timecode", TextBoxCheckPointHead.Text), _
                                        New SqlParameter("@check_point2_timecode", TextBoxCheckPointMid.Text), _
                                        New SqlParameter("@check_point3_timecode", TextBoxCheckPointTail.Text), _
                                        New SqlParameter("@check_status", StatusFailCheckUp), _
                                        New SqlParameter("@remark", TextBoxRemark.Text), _
                                        New SqlParameter("@check_person", TextBoxChecker.Text), _
                                        New SqlParameter("@check_time", daytime), _
                                        New SqlParameter("@checkup_id", _checkupId)}
        com1.Parameters.AddRange(params1)


        Dim sqlquery2 As String = "update material set " & _
                                 "status = @status " & _
                                 "where " & _
                                 "id = @material_id"
        Dim com2 As SqlCommand = New SqlCommand(sqlquery2, sqlconn)
        Dim params2 As SqlParameter() = {New SqlParameter("@status", StatusFailCheckUp), _
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

    Private Sub BackgroundWorker1_DoWork _
        (ByVal sender As Object, _
         ByVal e As DoWorkEventArgs) _
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

    Private Sub BackgroundWorker1_ProgressChanged _
        (ByVal sender As Object, ByVal e As ProgressChangedEventArgs) _
        Handles BackgroundWorker1.ProgressChanged

        ' This event handler is called after the background thread
        ' reads a line from the source file.
        ' This method runs on the main thread.

        Dim result As AccessControlQuery.AccessControlResult = CType _
            (e.UserState, AccessControlQuery.AccessControlResult)

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

    Private Sub GroupBox1_MouseMove _
        (ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles GroupBox1.MouseMove
        'Dim Button As Short = EventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(e.X)
        Dim Y As Single = VB6.PixelsToTwipsY(e.Y) '经过

        If VB6.PixelsToTwipsX(Me.Left) = VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - 75 Then '已被隐藏，符合出现的条件
            Showing = True
            Do Until VB6.PixelsToTwipsX(Me.Left) <= VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width) + 70 '出现
                System.Windows.Forms.Application.DoEvents()
                Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 50)
            Loop
            Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width) + 70)
            Showing = False
        End If
        If Timer1.Enabled = False Then Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick _
        (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Timer1.Tick
        GetCursorPos(MousePos)
        Dim F As RECT
        GetWindowRect(Me.Handle.ToInt32, F) '得到窗体的位置
        If MousePos.X < F.Left_Renamed Or MousePos.X > F.Right_Renamed Or MousePos.Y < F.Top_Renamed Or MousePos.Y > F.Bottom_Renamed Then
            If Showing = True Then Exit Sub
            Timer1.Enabled = False
            If VB6.PixelsToTwipsX(Me.Left) >= VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width) Then '窗体被拉到屏幕最右端
                Do Until VB6.PixelsToTwipsX(Me.Left) >= VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - 70 '隐藏
                    System.Windows.Forms.Application.DoEvents()
                    Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 50)
                Loop
                Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - 70)
            End If
        End If
    End Sub

    Private Sub GroupBox2_MouseMove _
        (ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles GroupBox2.MouseMove
        'Dim Button As Short = EventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(e.X)
        Dim Y As Single = VB6.PixelsToTwipsY(e.Y) '经过

        If VB6.PixelsToTwipsX(Me.Left) = VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - 75 Then '已被隐藏，符合出现的条件
            Showing = True
            Do Until VB6.PixelsToTwipsX(Me.Left) <= VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width) + 70 '出现
                System.Windows.Forms.Application.DoEvents()
                Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 50)
            Loop
            Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width) + 70)
            Showing = False
        End If
        If Timer1.Enabled = False Then Timer1.Enabled = True
    End Sub

    Private Sub TextBoxChecker_TextChanged _
        (ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles TextBoxChecker.TextChanged
        If Not TextBoxChecker.Text = "" Then
            _flagFigure = 1
        Else
            _flagFigure = 0
        End If
    End Sub

    Private Sub PictureBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDoubleClick
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

    Private Sub PictureBox2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDoubleClick
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

    Private Sub PictureBox3_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDoubleClick
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

    Private Sub PictureBox4_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseDoubleClick
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