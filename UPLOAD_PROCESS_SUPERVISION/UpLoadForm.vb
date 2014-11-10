Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Thread
Imports System.Drawing.Imaging

Public Class UpLoadForm

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

    Private _tapeId As Guid = Nothing

    Private _materialId As Guid = Nothing

    Private _cameraUsing As Boolean = False

    Private Const ScreenShotBmp As String = "screenShotBmp.bmp"

    Private _workAcq As AccessControlQuery

    Private _channel As String

    Private ReadOnly _tapeIdentificationList As String(,) = _
            {{"新闻综合", "1"}, {"都市生活", "2"}, {"影视娱乐", "3"}, {"南宁公共", "4"}}

    Public Const DyUploadTapeNameTextBox As Integer = 11

    Public Const DyUploadStartTimeCodeTextBox As Integer = 0

    Public Const DyUploadEndTimeCodeTextBox As Integer = 1

    Public Const DyUploadLengthTextBox As Integer = 2

    Public Const DyUploadUpLoadChannelTextBox As Integer = 0

    Public Const DyUploadUploadSignalSourceTextBox As Integer = 2

    Public Const DyUploadUploadTaskTypeTextBox As Integer = 1

    Public Const DyUploadUploadProgramTypeTextBox As Integer = 8

    Public Const DyUploadUploadTapeFlageTextBox As Integer = 9

    Public Const DyUploadUpLoadChannelComboBox As Integer = 0

    Public Const DyUploadUploadSignalSourceComboBox As Integer = 1

    Public Const DyUploadUploadTaskTypeComboBox As Integer = 2

    Public Const DyUploadUploadProgramTypeComboBox As Integer = 5

    Dim _mousePos As PointAPI

    Dim _showing As Boolean

    Private Declare Function GetCursorPos Lib "User32" (ByRef lpPoint As PointAPI) _
        As Integer

    Private Declare Function GetWindowRect Lib "User32" (ByVal hWnd As Integer, _
                                                        ByRef lpRect As Rect) _
        As Integer


    Private Sub UpLoadForm_Disposed(ByVal sender As Object, _
                                    ByVal e As EventArgs) Handles Me.Disposed
        '取消后台线程
        EndThread()

        '关闭摄像头
        If _cameraUsing Then
            ClearGraphs()
        End If

        '主界面恢复
        QueryForm.WindowState = FormWindowState.Normal
    End Sub

    Private Sub UpLoadForm_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load

        If UseCamera Then
            Try
                '打开摄像头，实时监控
                InitStillGraph(PictureBoxCamera.Handle)
                _cameraUsing = True
            Catch err As Exception
                Console.WriteLine(err)
            End Try

        End If

        '初始化_tapeId
        _tapeId = QueryForm.TapeId

        '获取一个新的guid作为素材id
        _materialId = Guid.NewGuid()

        '设置tape信息
        SetTapeInfo()

        '启动指纹后台线程
        StartThread()

        '获得当前系统时间
        TextBoxUploadTime.Text = Now()

        '界面设置
        '仅显示panel1
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        '按照panel1调整窗口大小
        Me.Height = SystemInformation.CaptionHeight + _
                    Panel1.Height
        Me.Width = Panel1.Width
        '使窗口居中
        Me.Left = (My.Computer.Screen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub SetTapeInfo()
        Dim queryString As String = "select tape_name, " & "in_bc_time, " & _
                                    "start_timecode, " & "end_timecode, " & _
                                    "length, " & "program_type, " & "channel " & _
                                    "from tape " & "where id='" & _
                                    _tapeId.ToString() & "'"

        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
        Dim command As SqlCommand = New SqlCommand(queryString, sqlconn)
        Dim reader As SqlDataReader
        Dim inbcsttimecode As String
        Dim inbclengthcode As String
        Dim inbcendtimecode As String
        Dim arr() As String
        Dim channel As String

        Try
            sqlconn.Open()
            reader = command.ExecuteReader()

            If (reader.Read()) Then
                TextBoxTapeName.Text = reader("tape_name")
                LableTimeInBcTime.Text = (reader("in_bc_time"))   '当前编辑的项目的创建时间
                TextBoxProgramType.Text = reader("program_type")  '节目类型
                inbcsttimecode = (reader("start_timecode")) _
                '当前编辑的项目的创建起始时码
                inbclengthcode = (reader("length"))               '当前编辑的项目的创建时长
                inbcendtimecode = (reader("end_timecode")) _
                '当前编辑的项目的创建终止时码
                channel = reader("channel")                       '节目所属频道
                _channel = channel.Trim()

                '显示创建的起始时码
                arr = inbcsttimecode.Split(":")
                LableRecvHourOfStartTimeCode.Text = arr(0)
                LableRecvMinOfStartTimeCode.Text = arr(1)
                LableRecvSecOfStartTimeCode.Text = arr(2)
                LableRecvFrameOfStartTimeCode.Text = arr(3)

                '显示创建的时长
                arr = inbclengthcode.Split(":")
                LableRecvHourOfLength.Text = arr(0)
                LableRecvMinOfLength.Text = arr(1)
                LableRecvSecOfLength.Text = arr(2)
                LableRecvFrameOfLength.Text = arr(3)

                '显示创建的终止时码
                arr = inbcendtimecode.Split(":")
                LableRecvHourOfEndTimeCode.Text = arr(0)
                LableRecvMinOfEndTimeCode.Text = arr(1)
                LableRecvSecOfEndTimeCode.Text = arr(2)
                LableRecvFrameOfEndTimeCode.Text = arr(3)

            Else
                LableRecvHourOfStartTimeCode.Text = "无"
                LableRecvMinOfStartTimeCode.Text = "此"
                LableRecvSecOfStartTimeCode.Text = "节"
                LableRecvFrameOfStartTimeCode.Text = " 目"

                LableRecvHourOfLength.Text = "无"
                LableRecvMinOfLength.Text = "此"
                LableRecvSecOfLength.Text = "节"
                LableRecvFrameOfLength.Text = "目"

                LableRecvHourOfEndTimeCode.Text = "无"
                LableRecvMinOfEndTimeCode.Text = "此"
                LableRecvSecOfEndTimeCode.Text = "节"
                LableRecvFrameOfEndTimeCode.Text = "目"

            End If

            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub ButtonScreenShotOfDaYangUpload_Click(ByVal sender As Object, _
                                                     ByVal e As EventArgs) _
        Handles ButtonScreenShotOfDaYangUpload.Click

        WindowState = 1  '最小化程序窗口
        Sleep(300) '延迟0.3秒

        '获取屏幕截图bmp图片
        Dim w As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim h As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim bmp As New Bitmap(w, h)
        Dim gs As Graphics = Graphics.FromImage(bmp)

        gs.CopyFromScreen(0, 0, 0, 0, My.Computer.Screen.WorkingArea.Size)
        PictureBoxScreenShotOfDaYangUpload.Image = bmp

        bmp.Save(ScreenShotBmp)

        '图片存储到数据库中
        StoreImgToDb(bmp, "screenshot")

        WindowState = 0  '恢复程序窗口

        'CapDlgTest(My.Computer.Screen.WorkingArea., Picturescr.Handle)

        '将bmp图片编码为jpg格式
        'Dim a As String = ScreenShotBmp
        'Dim b As String = ScreenShotJpg
        'EncBmpToJpg(a, b)
        'PictureBoxScreenShotOfDaYangUpload.ImageLocation = (ScreenShotBmp)
    End Sub

    Private Sub ButtonScreenShotOfCamera_Click(ByVal sender As Object, _
                                               ByVal e As EventArgs) _
        Handles ButtonScreenShotOfCamera.Click

        If _cameraUsing Then
            OnpStillCapture(PictureBoxScreenShotOfCamera.Handle) '摄像头图像截图
            Dim bmp As New Bitmap("StillCap0000.bmp")

            PictureBoxScreenShotOfCamera.Image = bmp
            'Console.WriteLine(PictureBoxScreenShotOfCamera.Image)

            '图片存储到数据库中
            StoreImgToDb(bmp, "camera")
        Else
            MsgBox("没有打开摄像头")
        End If
    End Sub

    Private Sub ButtonGoBack_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonGoBack.Click
        Panel1.Visible = True
        Panel2.Visible = True
        Panel3.Visible = True

        '调整panel1 2 3的位置
        Panel1.Location = New Point(0, 0)
        Panel3.Location = New Point(Panel1.Width, 0)
        Panel2.Location = New Point(Panel1.Width, Panel3.Height)

        '调整窗体大小
        Me.Height = SystemInformation.CaptionHeight + _
                    Panel1.Height
        Me.Width = Panel1.Width

        '使窗口居中
        Me.Left = (My.Computer.Screen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub ButtonInquiry_Click(ByVal sender As Object, _
                                    ByVal e As EventArgs) _
        Handles ButtonInquiry.Click
        Const connstr As String = _
                  "Server=(local);Database=nntv_ps;User ID=sa;Password=nntv@2014;"
        Dim queryString As String = _
                "select in_bc_time,start_timecode,end_timecode,length from tape where tape_name='" & _
                TextBoxTapeName.Text & "'"

        Dim sqlconn As SqlConnection = New SqlConnection(connstr)
        Dim command As SqlCommand = New SqlCommand(queryString, sqlconn)
        Dim reader As SqlDataReader
        Dim inbcsttimecode As String
        Dim inbclengthcode As String
        Dim inbcendtimecode As String
        Dim arr() As String
        Try
            '打开数据库,读取磁带交接的内容
            sqlconn.Open()

            reader = command.ExecuteReader()


            If (reader.Read()) Then
                LableTimeInBcTime.Text = (reader("in_bc_time"))   '当前编辑的项目的创建时间
                inbcsttimecode = (reader("start_timecode")) _
                '当前编辑的项目的创建起始时码
                inbclengthcode = (reader("length"))               '当前编辑的项目的创建时长
                inbcendtimecode = (reader("end_timecode")) _
                '当前编辑的项目的创建终止时码

                '显示创建的起始时码
                arr = inbcsttimecode.Split(":")
                LableRecvHourOfStartTimeCode.Text = arr(0)
                LableRecvMinOfStartTimeCode.Text = arr(1)
                LableRecvSecOfStartTimeCode.Text = arr(2)
                LableRecvFrameOfStartTimeCode.Text = arr(3)

                '显示创建的时长
                arr = inbclengthcode.Split(":")
                LableRecvHourOfLength.Text = arr(0)
                LableRecvMinOfLength.Text = arr(1)
                LableRecvSecOfLength.Text = arr(2)
                LableRecvFrameOfLength.Text = arr(3)

                '显示创建的终止时码
                arr = inbcendtimecode.Split(":")
                LableRecvHourOfEndTimeCode.Text = arr(0)
                LableRecvMinOfEndTimeCode.Text = arr(1)
                LableRecvSecOfEndTimeCode.Text = arr(2)
                LableRecvFrameOfEndTimeCode.Text = arr(3)

            Else
                LableRecvHourOfStartTimeCode.Text = "无"
                LableRecvMinOfStartTimeCode.Text = "此"
                LableRecvSecOfStartTimeCode.Text = "节"
                LableRecvFrameOfStartTimeCode.Text = " 目"

                LableRecvHourOfLength.Text = "无"
                LableRecvMinOfLength.Text = "此"
                LableRecvSecOfLength.Text = "节"
                LableRecvFrameOfLength.Text = "目"

                LableRecvHourOfEndTimeCode.Text = "无"
                LableRecvMinOfEndTimeCode.Text = "此"
                LableRecvSecOfEndTimeCode.Text = "节"
                LableRecvFrameOfEndTimeCode.Text = "目"

            End If

            reader.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub ButtonStartUpload_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles ButtonStartUpload.Click

        '开始时码
        Dim startTimeCode = TextBoxUploadStartTimeCodeHour.Text & ":" & _
                            TextBoxUploadStartTimeCodeMin.Text & ":" & _
                            TextBoxUploadStartTimeCodeSec.Text & ":" & _
                            TextBoxUploadStartTimeCodeFrame.Text
        '磁带时长
        Dim length = TextBoxUploadLenHour.Text & ":" & TextBoxUploadLenMin.Text & _
                     ":" & TextBoxUploadLenSec.Text & ":" & _
                     TextBoxUploadLenFrame.Text _
        '结束时码
        Dim endTimeCode = TextBoxUploadEndTimeCodeHour.Text & ":" & _
                          TextBoxUploadEndTimeCodeMin.Text & ":" & _
                          TextBoxUploadEndTimeCodeSec.Text & ":" & _
                          TextBoxUploadEndTimeCodeFrame.Text

        Dim source = ComboBoxSignalSource.Text                    '上载信号源
        Dim upLoadTime = TextBoxUploadTime.Text                   '磁带上载时间
        Dim tapeName = TextBoxTapeName.Text                       '磁带名
        'Dim remark = TextBoxRemark.Text                          '备注
        'Dim volumeCheck As Boolean = CheckBoxVolumeCheck.Checked '音量check
        'Dim imageCheck = CheckBoxImageCheck.Checked              '图像check
        'Dim episodeCheck = CheckBoxEpisodeCheck.Checked          '期数集数check
        Dim uploder = TextBoxUploader.Text                        '上传者
        Dim uploadChannel = ComboBoxUploadChannel.Text            '上载通道
        Dim machineName = Environment.MachineName                 '机器名
        'Dim taskType = ComboBoxTaskType.Text
        Dim programType = TextBoxProgramType.Text
        Dim tapeIdentification = GetByChannel(_channel)              '磁带标识


        '将上载信息写入数据库 
        Const queryS1 As String = "insert into material (" & "material_name, " & _
                                  "id, " & "tape_id, " & "start_timecode, " & _
                                  "end_timecode, " & "length, " & "status " & _
                                  ") values (" & "@material_name ," & _
                                  "@material_id, " & "@tape_id, " & _
                                  "@start_timecode, " & "@end_timecode, " & _
                                  "@length, " & "@status " & ")"

        Dim param1() As SqlParameter = _
                {New SqlParameter("@material_name", tapeName), _
                 New SqlParameter("@material_id", _materialId), _
                 New SqlParameter("@tape_id", _tapeId), _
                 New SqlParameter("@start_timecode", startTimeCode), _
                 New SqlParameter("@end_timecode", endTimeCode), _
                 New SqlParameter("@length", length), _
                 New SqlParameter("@status", StatusUploading)}

        Const queryS2 As String = "insert into upload (" & "tape_name, " & _
                                  "tape_id, " & "material_id, " & _
                                  "upload_time, " & "start_timecode, " & _
                                  "end_timecode, " & "length, " & "upload_per, " & _
                                  "upload_type, " & "upload_channel, " & _
                                  "upload_pc, " & "upload_status" & ") values (" & _
                                  "@tape_name, " & "@tape_id, " & _
                                  "@material_id, " & "@upload_time, " & _
                                  "@start_timecode, " & "@end_timecode, " & _
                                  "@length, " & "@upload_per, " & _
                                  "@upload_type, " & "@upload_channel, " & _
                                  "@upload_pc, " & "@upload_status " & ")"

        Dim param2() As SqlParameter = _
                {New SqlParameter("@tape_name", tapeName), _
                 New SqlParameter("@tape_id", _tapeId), _
                 New SqlParameter("@material_id", _materialId), _
                 New SqlParameter("@upload_time", upLoadTime), _
                 New SqlParameter("@start_timecode", startTimeCode), _
                 New SqlParameter("@end_timecode", endTimeCode), _
                 New SqlParameter("@length", length), _
                 New SqlParameter("@upload_per", uploder), _
                 New SqlParameter("@upload_type", source), _
                 New SqlParameter("@upload_channel", uploadChannel), _
                 New SqlParameter("@upload_pc", machineName), _
                 New SqlParameter("@upload_status", StatusUploading)}

        Const queryS3 As String = "select count(material_id) " & "from upload " & _
                                  "where " & "material_id = @material_id"

        Dim param3() As SqlParameter = _
                {New SqlParameter("@material_id", _materialId)}

        'Console.WriteLine(queryString)

        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)

        Dim sqlcom1 As SqlCommand = New SqlCommand(queryS1, sqlconn)
        sqlcom1.Parameters.AddRange(param1)

        Dim sqlcom2 As SqlCommand = New SqlCommand(queryS2, sqlconn)
        sqlcom2.Parameters.AddRange(param2)

        Dim sqlcom3 As SqlCommand = New SqlCommand(queryS3, sqlconn)
        sqlcom3.Parameters.AddRange(param3)

        Try
            sqlconn.Open()

            Dim reader As SqlDataReader = sqlcom3.ExecuteReader()

            If reader.Read() And reader(0) > 0 Then
                reader.Close()
                Console.WriteLine("Db table 'upload' have the same material id!")
                Console.WriteLine("The id :" + _materialId.ToString)
            Else
                reader.Close()
                sqlcom1.ExecuteNonQuery()
                sqlcom2.ExecuteNonQuery()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try

        '调用myhook.dll 中的函数 
        '将上载通道,任务类型,信号源
        '磁带的名称,始码,止码,长度
        '节目类型,磁带标识  推送到上载界面
        'Set_Edit_Str(uploadChannel, DY_Upload_UpLoadChannelTextBox)
        'Set_Edit_Str(taskType, DY_Upload_UploadTaskTypeTextBox)
        'Set_Edit_Str(source, DY_Upload_UploadSignalSourceTextBox)

        Dim i As Integer
        Dim s As String = ""
        i = ComboBoxUploadChannel.SelectedIndex
        Set_ComboBox(s, i, 0)
        i = ComboBoxTaskType.SelectedIndex
        Set_ComboBox(s, i, 1)
        i = ComboBoxSignalSource.SelectedIndex
        Set_ComboBox(s, i, 2)

        Set_Edit_Str(tapeName, DyUploadTapeNameTextBox)
        Set_Upload_TimeCode(startTimeCode, DyUploadStartTimeCodeTextBox)
        Set_Upload_TimeCode(endTimeCode, DyUploadEndTimeCodeTextBox)
        Set_Upload_TimeCode(length, DyUploadLengthTextBox)

        Set_Edit_Str(programType, DyUploadUploadProgramTypeTextBox)
        Set_Edit_Str(tapeIdentification, DyUploadUploadTapeFlageTextBox)

        '按下上载界面添加任务按钮
        Set_Button_Status("2", 9)

        '按下上载界面开始任务按钮


        '推送到上载数据后，显示屏幕截图
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = True

        '按照panel2和panel3调整窗口大小
        Me.Height = SystemInformation.CaptionHeight + _
                    Panel2.Height + Panel3.Height
        Me.Width = Panel2.Width
        '调整panel2和panel3在窗口的位置
        Panel3.Location = New Point(0, 0)
        Panel2.Location = New Point(0, Panel3.Height)

        '调整窗口位置
        Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width

        '将窗口前置
        Me.TopMost = True

        '设置取消上载和完成上载为true
        ButtonStopUpload.Enabled = True
        ButtonFinishUpload.Enabled = True

        'Go Forward 按钮设置为可用
        ButtonForward.Visible = True
        ButtonForward.Enabled = True

        '开始上载设置为不可用
        ButtonStartUpload.Enabled = False
    End Sub

    Private Sub ButtonFinishUpload_Click(ByVal sender As Object, _
                                         ByVal e As EventArgs) _
        Handles ButtonFinishUpload.Click
        '写数据库,上载完成
        Dim remark = TextBoxRemark.Text                           '备注
        Dim volumeCheck As Boolean = CheckBoxVolumeCheck.Checked  '音量check
        Dim imageCheck = CheckBoxImageCheck.Checked               '图像check
        Dim episodeCheck = CheckBoxEpisodeCheck.Checked           '期数集数check

        Const queryS1 As String = "update material set " & "status = @status " & _
                                  "where " & "id = @material_id"

        Dim param1() As SqlParameter = _
                {New SqlParameter("@status", StatusNotCheckUp), _
                 New SqlParameter("@material_id", _materialId)}

        Const queryS2 As String = "update upload set " & "remark = @remark, " & _
                                  "volume_check = @volumeCheck, " & _
                                  "image_check = @imageCheck, " & _
                                  "episode_check = @episodeCheck, " & _
                                  "upload_status = @upload_status " & "where " & _
                                  "material_id = @material_id"

        Dim param2() As SqlParameter = _
                {New SqlParameter("@remark", remark), _
                 New SqlParameter("@volumeCheck", volumeCheck), _
                 New SqlParameter("@imageCheck", imageCheck), _
                 New SqlParameter("@episodeCheck", episodeCheck), _
                 New SqlParameter("@upload_status", StatusNotCheckUp), _
                 New SqlParameter("@material_id", _materialId)}

        Const queryS3 As String = "update tape set " & _
                                  "tape_status = @tape_status " & "where " & _
                                  "id = @tape_id"

        Dim param3() As SqlParameter = _
                {New SqlParameter("@tape_status", StatusNotCheckUp), _
                 New SqlParameter("@tape_id", _tapeId)}


        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)

        Dim sqlcom1 As SqlCommand = New SqlCommand(queryS1, sqlconn)
        sqlcom1.Parameters.AddRange(param1)

        Dim sqlcom2 As SqlCommand = New SqlCommand(queryS2, sqlconn)
        sqlcom2.Parameters.AddRange(param2)

        Dim sqlcom3 As SqlCommand = New SqlCommand(queryS3, sqlconn)
        sqlcom3.Parameters.AddRange(param3)

        Try
            sqlconn.Open()
            sqlcom1.ExecuteNonQuery()
            sqlcom2.ExecuteNonQuery()
            sqlcom3.ExecuteNonQuery()
            MsgBox("上载完成")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try


        Close()
    End Sub

    Private Sub ButtonStopUpload_Click(ByVal sender As Object, _
                                       ByVal e As EventArgs) _
        Handles ButtonStopUpload.Click
        '写数据库本次上载取消,记录下备注和状态
        '弹框让用户确定是否取消

        Dim remark = TextBoxRemark.Text                           '备注
        Dim volumeCheck As Boolean = CheckBoxVolumeCheck.Checked  '音量check
        Dim imageCheck = CheckBoxImageCheck.Checked               '图像check
        Dim episodeCheck = CheckBoxEpisodeCheck.Checked           '期数集数check

        Const queryS1 As String = "delete material " & "where " & _
                                  "id = @material_id"

        Dim param1() As SqlParameter = _
                {New SqlParameter("@material_id", _materialId)}

        Const queryS2 As String = "update upload set " & "remark = @remark, " & _
                                  "volume_check = @volumeCheck, " & _
                                  "image_check = @imageCheck, " & _
                                  "episode_check = @episodeCheck, " & _
                                  "upload_status = @upload_status " & "where " & _
                                  "material_id = @material_id"

        Dim param2() As SqlParameter = _
                {New SqlParameter("@remark", remark), _
                 New SqlParameter("@volumeCheck", volumeCheck), _
                 New SqlParameter("@imageCheck", imageCheck), _
                 New SqlParameter("@episodeCheck", episodeCheck), _
                 New SqlParameter("@upload_status", StatusFailUpload), _
                 New SqlParameter("@material_id", _materialId)}

        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
        Dim sqlcom1 As SqlCommand = New SqlCommand(queryS1, sqlconn)
        sqlcom1.Parameters.AddRange(param1)

        Dim sqlcom2 As SqlCommand = New SqlCommand(queryS2, sqlconn)
        sqlcom2.Parameters.AddRange(param2)


        Try
            sqlconn.Open()
            sqlcom1.ExecuteNonQuery()
            sqlcom2.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try


        Close()
    End Sub

    Private Sub SetButtonStartUpload()
        If _
            TextBoxUploadStartTimeCodeHour.Text = _
            LableRecvHourOfStartTimeCode.Text And _
            TextBoxUploadStartTimeCodeMin.Text = _
            LableRecvMinOfStartTimeCode.Text And _
            TextBoxUploadStartTimeCodeSec.Text = _
            LableRecvSecOfStartTimeCode.Text And _
            TextBoxUploadStartTimeCodeFrame.Text = _
            LableRecvFrameOfStartTimeCode.Text And _
            TextBoxUploadLenHour.Text = LableRecvHourOfLength.Text And _
            TextBoxUploadLenMin.Text = LableRecvMinOfLength.Text And _
            TextBoxUploadLenSec.Text = LableRecvSecOfLength.Text And _
            TextBoxUploadLenFrame.Text = LableRecvFrameOfLength.Text Then
            ButtonStartUpload.Enabled = True
            ButtonStartUpload.BackColor = ButtonGoBack.BackColor
        Else

            ButtonStartUpload.Enabled = False
            ButtonStartUpload.BackColor = Color.Empty
        End If
    End Sub

    Private Sub SetRightOrWrongImageVisible(ByVal correct As PictureBox, _
                                            ByVal wrong As PictureBox)
        If _
            TextBoxUploadStartTimeCodeHour.Text = _
            LableRecvHourOfStartTimeCode.Text And _
            TextBoxUploadStartTimeCodeMin.Text = _
            LableRecvMinOfStartTimeCode.Text And _
            TextBoxUploadStartTimeCodeSec.Text = _
            LableRecvSecOfStartTimeCode.Text And _
            TextBoxUploadStartTimeCodeFrame.Text = _
            LableRecvFrameOfStartTimeCode.Text Then

            correct.Visible = True
            wrong.Visible = False
        Else
            correct.Visible = False
            wrong.Visible = True
        End If
    End Sub

    Private Sub TimeInputCheck(ByVal thisTextBox As TextBox, _
                               ByVal nextTextBox As TextBox, _
                               ByVal maxNum As Integer)
        If IsNumeric(thisTextBox.Text) = False Then
            '如果输入不是数字就显示为0
            thisTextBox.Text = "00"
        End If

        If thisTextBox.TextLength = 2 Then '输入时码的光标自动下移
            nextTextBox.Focus()
        End If

        If CInt(thisTextBox.Text) > maxNum Then
            '如果输入的数字大于maxNum,光标移到最初
            thisTextBox.Text = "00"
            thisTextBox.Focus()
        End If
    End Sub

    Private Sub TextBoxUploadStartTimeCodeHour_Click(ByVal sender As Object, _
                                                     ByVal e As EventArgs) _
        Handles TextBoxUploadStartTimeCodeHour.Click
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub TextBoxUploadStartTimeCodeHour_TextChanged( _
                                                           ByVal sender As _
                                                              Object, _
                                                           ByVal e As EventArgs) _
        Handles TextBoxUploadStartTimeCodeHour.TextChanged

        TimeInputCheck(CType(sender, TextBox), _
                       TextBoxUploadStartTimeCodeMin, _
                       24)
        SetRightOrWrongImageVisible(PB3, PB5)
        SetButtonStartUpload()
    End Sub

    Private Sub TextBoxUploadStartTimeCodeMin_Click(ByVal sender As Object, _
                                                    ByVal e As EventArgs) _
        Handles TextBoxUploadStartTimeCodeMin.Click
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub TextBoxUploadStartTimeCodeMin_TextChanged(ByVal sender As Object, _
                                                          ByVal e As EventArgs) _
        Handles TextBoxUploadStartTimeCodeMin.TextChanged

        TimeInputCheck(CType(sender, TextBox), _
                       TextBoxUploadStartTimeCodeSec, _
                       59)
        SetRightOrWrongImageVisible(PB3, PB5)
        SetButtonStartUpload()
    End Sub

    Private Sub TextBoxUploadStartTimeCodeSec_Click(ByVal sender As Object, _
                                                    ByVal e As EventArgs) _
        Handles TextBoxUploadStartTimeCodeSec.Click
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub TextBoxUploadStartTimeCodeSec_TextChanged(ByVal sender As Object, _
                                                          ByVal e As EventArgs) _
        Handles TextBoxUploadStartTimeCodeSec.TextChanged

        TimeInputCheck(CType(sender, TextBox), _
                       TextBoxUploadStartTimeCodeFrame, _
                       59)
        SetRightOrWrongImageVisible(PB3, PB5)
        SetButtonStartUpload()
    End Sub

    Private Sub TextBoxUploadStartTimeCodeFrame_Click(ByVal sender As Object, _
                                                      ByVal e As  _
                                                         EventArgs) _
        Handles TextBoxUploadStartTimeCodeFrame.Click
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub TextBoxUploadStartTimeCodeFrame_TextChanged( _
                                                            ByVal sender As _
                                                               Object, _
                                                            ByVal e As EventArgs) _
        Handles TextBoxUploadStartTimeCodeFrame.TextChanged

        TimeInputCheck(CType(sender, TextBox), TextBoxUploadLenHour, 24)
        SetRightOrWrongImageVisible(PB3, PB5)
        SetButtonStartUpload()
    End Sub

    Private Sub TextBoxUploadLenHour_Click(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxUploadLenHour.Click
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub TextBoxUploadLenHour_TextChanged(ByVal sender As Object, _
                                                 ByVal e As EventArgs) _
        Handles TextBoxUploadLenHour.TextChanged

        TimeInputCheck(CType(sender, TextBox), TextBoxUploadLenMin, 24)
        SetRightOrWrongImageVisible(PB4, PB6)
        SetButtonStartUpload()
    End Sub

    Private Sub TextBoxUploadLenMin_Click(ByVal sender As Object, _
                                          ByVal e As EventArgs) _
        Handles TextBoxUploadLenMin.Click
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub TextBoxUploadLenMin_TextChanged(ByVal sender As Object, _
                                                ByVal e As EventArgs) _
        Handles TextBoxUploadLenMin.TextChanged

        TimeInputCheck(CType(sender, TextBox), TextBoxUploadLenSec, 59)
        SetRightOrWrongImageVisible(PB4, PB6)
        SetButtonStartUpload()
    End Sub

    Private Sub TextBoxUploadLenSec_Click(ByVal sender As Object, _
                                          ByVal e As EventArgs) _
        Handles TextBoxUploadLenSec.Click
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub TextBoxUploadLenSec_TextChanged(ByVal sender As Object, _
                                                ByVal e As EventArgs) _
        Handles TextBoxUploadLenSec.TextChanged

        TimeInputCheck(CType(sender, TextBox), TextBoxUploadLenFrame, 59)
        SetRightOrWrongImageVisible(PB4, PB6)
        SetButtonStartUpload()
    End Sub

    Private Sub TextBoxUploadLenFrame_Click(ByVal sender As Object, _
                                            ByVal e As EventArgs) _
        Handles TextBoxUploadLenFrame.Click
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub TextBoxUploadLenFrame_TextChanged(ByVal sender As Object, _
                                                  ByVal e As EventArgs) _
        Handles TextBoxUploadLenFrame.TextChanged
        If IsNumeric(TextBoxUploadLenFrame.Text) = False Then _
            TextBoxUploadLenFrame.Text = "00"
        If TextBoxUploadLenFrame.TextLength = 2 Then '输入时码的光标自动下移
            TextBoxRemark.Focus()
            Call CalEndTime()

        End If

        If TextBoxUploadLenFrame.Text > 24 Then
            TextBoxUploadLenFrame.Text = "00"
            TextBoxUploadLenFrame.Focus()
        End If

        SetRightOrWrongImageVisible(PB4, PB6)
        SetButtonStartUpload()
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonClear.Click
        '重置页面
        TextBoxTapeName.Text = ""
        ComboBoxSignalSource.Text = ""
        TextBoxUploadStartTimeCodeHour.Text = ""
        TextBoxUploadStartTimeCodeMin.Text = ""
        TextBoxUploadStartTimeCodeSec.Text = ""
        TextBoxUploadStartTimeCodeFrame.Text = ""
        TextBoxUploadLenHour.Text = ""
        TextBoxUploadLenMin.Text = ""
        TextBoxUploadLenSec.Text = ""
        TextBoxUploadLenFrame.Text = ""
        TextBoxUploadEndTimeCodeHour.Text = ""
        TextBoxUploadEndTimeCodeMin.Text = ""
        TextBoxUploadEndTimeCodeSec.Text = ""
        TextBoxUploadEndTimeCodeFrame.Text = ""
        TextBoxUploadTime.Text = Now()
        CheckBoxVolumeCheck.Checked = 0
        CheckBoxImageCheck.Checked = 0
        CheckBoxEpisodeCheck.Checked = 0
        TextBoxRemark.Text = ""
    End Sub

    Private Sub CalEndTime()
        Dim endTimeH = 0, _
            endTimeM = 0, _
            endTimeS = 0, _
            endTimeF
        endTimeF = CInt(TextBoxUploadStartTimeCodeFrame.Text) + _
                   CInt(TextBoxUploadLenFrame.Text) - 1 '帧相加
        If endTimeF > 24 Then '进位
            endTimeS += 1
            endTimeF -= 25
        ElseIf endTimeF < 0 Then '借位
            endTimeS -= 1
            endTimeF += 25
        End If
        endTimeS += CInt(TextBoxUploadStartTimeCodeSec.Text) + _
                    CInt(TextBoxUploadLenSec.Text)    '秒相加
        If endTimeS > 59 Then
            endTimeM += 1
            endTimeS -= 60
        ElseIf endTimeS < 0 Then
            endTimeM -= 1
            endTimeS += 60
        End If
        endTimeM += CInt(TextBoxUploadStartTimeCodeMin.Text) + _
                    CInt(TextBoxUploadLenMin.Text)    '分相加
        If endTimeM > 59 Then
            endTimeH += 1
            endTimeM -= 60
        ElseIf endTimeM < 0 Then
            endTimeH -= 1
            endTimeM += 60
        End If
        endTimeH += CInt(TextBoxUploadStartTimeCodeHour.Text) + _
                    CInt(TextBoxUploadLenHour.Text)    '时相加
        If endTimeH < 0 Then '结束时码小于0，输入错误
            MsgBox("时码错误!")
        Else '输出，不足2位的补0
            TextBoxUploadEndTimeCodeFrame.Text = _
                Microsoft.VisualBasic.Right("00" & endTimeF, 2) _
            '帧，结果的左边补2个0后取右边2位
            TextBoxUploadEndTimeCodeSec.Text = _
                Microsoft.VisualBasic.Right("00" & endTimeS, 2)
            TextBoxUploadEndTimeCodeMin.Text = _
                Microsoft.VisualBasic.Right("00" & endTimeM, 2)
            TextBoxUploadEndTimeCodeHour.Text = _
                Microsoft.VisualBasic.Right("00" & endTimeH, 2)
        End If
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
                    TextBoxUploader.Text = pname
                Else
                    MsgBox("非播出部人员")
                End If

            Else
                MsgBox("数据库无此信息,请手动输入")
            End If
            reader.Close()
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

    Private Sub StoreImgToDb(ByVal img As Bitmap, ByVal column As String)
        'Dim fs As FileStream = New FileStream(ScreenShotBmp, FileMode.Open)
        'Dim br As BinaryReader = New BinaryReader(fs)
        'Dim buffbyte() As Byte = br.ReadBytes(fs.Length)

        Dim ms As MemoryStream = New MemoryStream()
        img.Save(ms, ImageFormat.Bmp)


        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
        Dim queryString As String = "update upload set " & column & _
                                    " = @screenshot " & "where " & _
                                    "material_id = @material_id"
        Dim param() As SqlParameter = _
                {New SqlParameter("@screenshot", ms.ToArray()), _
                 New SqlParameter("@material_id", _materialId)}

        Dim sqlcomm As SqlCommand = New SqlCommand(queryString, sqlconn)
        sqlcomm.Parameters.AddRange(param)

        Try
            sqlconn.Open()
            sqlcomm.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, _
                            ByVal e As EventArgs) Handles Timer1.Tick
        GetCursorPos(_mousePos)
        Dim f As Rect
        GetWindowRect(Me.Handle.ToInt32, f) '得到窗体的位置
        If _
            _mousePos.X < f.Left_Renamed Or _mousePos.X > f.Right_Renamed Or _
            _mousePos.Y < f.Top_Renamed Or _mousePos.Y > f.Bottom_Renamed Then
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

    Private Sub Panel3_MouseMove(ByVal sender As Object, _
                                 ByVal e As MouseEventArgs) _
        Handles Panel3.MouseMove
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

    Private Sub Panel2_MouseMove(ByVal sender As Object, _
                                 ByVal e As MouseEventArgs) _
        Handles Panel2.MouseMove
        Dim Shift As Short = ModifierKeys \ &H10000
        Dim X As Single = PixelsToTwipsX(e.X)
        Dim Y As Single = PixelsToTwipsY(e.Y) '经过

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

    Private Sub Panel1_MouseMove(ByVal sender As Object, _
                                 ByVal e As MouseEventArgs) _
        Handles Panel1.MouseMove
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

    Private Sub PictureBoxScreenShotOfDaYangUpload_MouseDoubleClick( _
                                                                    ByVal sender _
                                                                       As Object, _
                                                                    ByVal e As  _
                                                                       MouseEventArgs) _
        Handles PictureBoxScreenShotOfDaYangUpload.MouseDoubleClick
        If Not PictureBoxScreenShotOfDaYangUpload.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add( _
                PictureBoxScreenShotOfDaYangUpload.Image)
            ImageViewer.Show()
        End If
    End Sub

    Private Sub PictureBoxScreenShotOfCamera_MouseDoubleClick( _
                                                              ByVal sender As _
                                                                 Object, _
                                                              ByVal e As  _
                                                                 MouseEventArgs) _
        Handles PictureBoxScreenShotOfCamera.MouseDoubleClick
        If Not PictureBoxScreenShotOfDaYangUpload.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add( _
                PictureBoxScreenShotOfDaYangUpload.Image)
            ImageViewer.Show()
        End If
    End Sub

    Private Sub ComboBoxTaskType_SelectedIndexChanged( _
                                                      ByVal sender As _
                                                         Object, _
                                                      ByVal e As  _
                                                         EventArgs) _
        Handles ComboBoxTaskType.SelectedIndexChanged
        If ComboBoxTaskType.SelectedItem.ToString = "VRT上载" Then
            ComboBoxSignalSource.Items.Clear()
            ComboBoxSignalSource.Items.AddRange(New Object() _
                                                   {"录像机1", "录像机2", "录像机3"})
        End If

        If ComboBoxTaskType.SelectedItem.ToString = "线路上载" Then
            ComboBoxSignalSource.Items.Clear()
            ComboBoxSignalSource.Items.AddRange(New Object() _
                                                   {"线路信号1", "线路信号2", "线路信号3"})

        End If
    End Sub

    Private Function GetByChannel(ByVal channel As String) As String
        Dim i = 0
        While i < _tapeIdentificationList.Length / 2
            If _tapeIdentificationList(i, 0) = channel Then
                Return _tapeIdentificationList(i, 1)
            End If
            i += 1
        End While

        'Default value is "1"
        Return "1"
    End Function

    Private Sub ButtonForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonForward.Click
        '按照panel2和panel3调整窗口大小
        Me.Height = SystemInformation.CaptionHeight + _
                    Panel2.Height + Panel3.Height
        Me.Width = Panel2.Width
        '调整panel2和panel3在窗口的位置
        Panel3.Location = New Point(0, 0)
        Panel2.Location = New Point(0, Panel3.Height)

        '调整窗口位置
        Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width

        '将窗口前置
        Me.TopMost = True
    End Sub
End Class
