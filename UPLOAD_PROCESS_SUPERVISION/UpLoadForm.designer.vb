<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpLoadForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpLoadForm))
        Me.Labletapename = New System.Windows.Forms.Label
        Me.LableRecvStartTimeCode = New System.Windows.Forms.Label
        Me.LableRecvLength = New System.Windows.Forms.Label
        Me.TextBoxRemark = New System.Windows.Forms.TextBox
        Me.PictureBoxScreenShotOfDaYangUpload = New System.Windows.Forms.PictureBox
        Me.ButtonFinishUpload = New System.Windows.Forms.Button
        Me.ButtonStopUpload = New System.Windows.Forms.Button
        Me.LableRecvHourOfStartTimeCode = New System.Windows.Forms.Label
        Me.LableRecvHourOfLength = New System.Windows.Forms.Label
        Me.ButtonScreenShotOfCamera = New System.Windows.Forms.Button
        Me.PictureBoxScreenShotOfCamera = New System.Windows.Forms.PictureBox
        Me.ButtonStartUpload = New System.Windows.Forms.Button
        Me.PictureBoxCamera = New System.Windows.Forms.PictureBox
        Me.ButtonScreenShotOfDaYangUpload = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ComboBoxTaskType = New System.Windows.Forms.ComboBox
        Me.LabelTaskType = New System.Windows.Forms.Label
        Me.TextBoxProgramType = New System.Windows.Forms.TextBox
        Me.LabelProgramType = New System.Windows.Forms.Label
        Me.ComboBoxUploadChannel = New System.Windows.Forms.ComboBox
        Me.LabelUploadChannel = New System.Windows.Forms.Label
        Me.LabelUploader = New System.Windows.Forms.Label
        Me.TextBoxUploader = New System.Windows.Forms.TextBox
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.LableRecvFrameOfEndTimeCode = New System.Windows.Forms.Label
        Me.LableRecvSecOfEndTimeCode = New System.Windows.Forms.Label
        Me.LableRecvMinOfEndTimeCode = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.LableRecvHourOfEndTimeCode = New System.Windows.Forms.Label
        Me.LableRecvEndTimeCode = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TextBoxUploadEndTimeCodeFrame = New System.Windows.Forms.TextBox
        Me.TextBoxUploadEndTimeCodeSec = New System.Windows.Forms.TextBox
        Me.TextBoxUploadEndTimeCodeMin = New System.Windows.Forms.TextBox
        Me.TextBoxUploadEndTimeCodeHour = New System.Windows.Forms.TextBox
        Me.LabelUploadEndTimeCode = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.LableRecvFrameOfLength = New System.Windows.Forms.Label
        Me.LableRecvSecOfLength = New System.Windows.Forms.Label
        Me.LableRecvMinOfLength = New System.Windows.Forms.Label
        Me.LableRecvFrameOfStartTimeCode = New System.Windows.Forms.Label
        Me.LableRecvSecOfStartTimeCode = New System.Windows.Forms.Label
        Me.LableRecvMinOfStartTimeCode = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBoxUploadLenFrame = New System.Windows.Forms.TextBox
        Me.TextBoxUploadStartTimeCodeFrame = New System.Windows.Forms.TextBox
        Me.TextBoxUploadLenSec = New System.Windows.Forms.TextBox
        Me.TextBoxUploadStartTimeCodeSec = New System.Windows.Forms.TextBox
        Me.TextBoxUploadLenMin = New System.Windows.Forms.TextBox
        Me.TextBoxUploadStartTimeCodeMin = New System.Windows.Forms.TextBox
        Me.ButtonInquiry = New System.Windows.Forms.Button
        Me.TextBoxTapeName = New System.Windows.Forms.TextBox
        Me.PB6 = New System.Windows.Forms.PictureBox
        Me.PB5 = New System.Windows.Forms.PictureBox
        Me.PB4 = New System.Windows.Forms.PictureBox
        Me.PB3 = New System.Windows.Forms.PictureBox
        Me.LableTimeInBcTime = New System.Windows.Forms.Label
        Me.TextBoxUploadLenHour = New System.Windows.Forms.TextBox
        Me.TextBoxUploadStartTimeCodeHour = New System.Windows.Forms.TextBox
        Me.ComboBoxSignalSource = New System.Windows.Forms.ComboBox
        Me.LableSignalSource = New System.Windows.Forms.Label
        Me.TextBoxUploadTime = New System.Windows.Forms.TextBox
        Me.LabelInBcTime = New System.Windows.Forms.Label
        Me.LabelUploadTime = New System.Windows.Forms.Label
        Me.LabelUploadLength = New System.Windows.Forms.Label
        Me.LabelUploadStartTimeCode = New System.Windows.Forms.Label
        Me.CheckBoxEpisodeCheck = New System.Windows.Forms.CheckBox
        Me.CheckBoxImageCheck = New System.Windows.Forms.CheckBox
        Me.CheckBoxVolumeCheck = New System.Windows.Forms.CheckBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ButtonGoBack = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxScreenShotOfDaYangUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxScreenShotOfCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PB6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Labletapename
        '
        Me.Labletapename.AutoSize = True
        Me.Labletapename.Location = New System.Drawing.Point(14, 18)
        Me.Labletapename.Name = "Labletapename"
        Me.Labletapename.Size = New System.Drawing.Size(65, 12)
        Me.Labletapename.TabIndex = 0
        Me.Labletapename.Text = "节目名称："
        '
        'LableRecvStartTimeCode
        '
        Me.LableRecvStartTimeCode.AutoSize = True
        Me.LableRecvStartTimeCode.Location = New System.Drawing.Point(14, 77)
        Me.LableRecvStartTimeCode.Name = "LableRecvStartTimeCode"
        Me.LableRecvStartTimeCode.Size = New System.Drawing.Size(89, 12)
        Me.LableRecvStartTimeCode.TabIndex = 3
        Me.LableRecvStartTimeCode.Text = "交接起始时码："
        '
        'LableRecvLength
        '
        Me.LableRecvLength.AutoSize = True
        Me.LableRecvLength.Location = New System.Drawing.Point(14, 102)
        Me.LableRecvLength.Name = "LableRecvLength"
        Me.LableRecvLength.Size = New System.Drawing.Size(65, 12)
        Me.LableRecvLength.TabIndex = 4
        Me.LableRecvLength.Text = "交接时长："
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Location = New System.Drawing.Point(114, 330)
        Me.TextBoxRemark.Multiline = True
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(215, 73)
        Me.TextBoxRemark.TabIndex = 13
        Me.TextBoxRemark.Text = "备注:"
        '
        'PictureBoxScreenShotOfDaYangUpload
        '
        Me.PictureBoxScreenShotOfDaYangUpload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxScreenShotOfDaYangUpload.Location = New System.Drawing.Point(114, 3)
        Me.PictureBoxScreenShotOfDaYangUpload.Name = "PictureBoxScreenShotOfDaYangUpload"
        Me.PictureBoxScreenShotOfDaYangUpload.Size = New System.Drawing.Size(215, 156)
        Me.PictureBoxScreenShotOfDaYangUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxScreenShotOfDaYangUpload.TabIndex = 16
        Me.PictureBoxScreenShotOfDaYangUpload.TabStop = False
        '
        'ButtonFinishUpload
        '
        Me.ButtonFinishUpload.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFinishUpload.Enabled = False
        Me.ButtonFinishUpload.Location = New System.Drawing.Point(243, 409)
        Me.ButtonFinishUpload.Name = "ButtonFinishUpload"
        Me.ButtonFinishUpload.Size = New System.Drawing.Size(86, 28)
        Me.ButtonFinishUpload.TabIndex = 18
        Me.ButtonFinishUpload.Text = "上载完成"
        Me.ButtonFinishUpload.UseVisualStyleBackColor = False
        '
        'ButtonStopUpload
        '
        Me.ButtonStopUpload.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonStopUpload.Enabled = False
        Me.ButtonStopUpload.Location = New System.Drawing.Point(141, 409)
        Me.ButtonStopUpload.Name = "ButtonStopUpload"
        Me.ButtonStopUpload.Size = New System.Drawing.Size(86, 28)
        Me.ButtonStopUpload.TabIndex = 19
        Me.ButtonStopUpload.Text = "取消上载"
        Me.ButtonStopUpload.UseVisualStyleBackColor = False
        '
        'LableRecvHourOfStartTimeCode
        '
        Me.LableRecvHourOfStartTimeCode.AutoSize = True
        Me.LableRecvHourOfStartTimeCode.Location = New System.Drawing.Point(109, 77)
        Me.LableRecvHourOfStartTimeCode.Name = "LableRecvHourOfStartTimeCode"
        Me.LableRecvHourOfStartTimeCode.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvHourOfStartTimeCode.TabIndex = 31
        Me.LableRecvHourOfStartTimeCode.Text = "__"
        '
        'LableRecvHourOfLength
        '
        Me.LableRecvHourOfLength.AutoSize = True
        Me.LableRecvHourOfLength.Location = New System.Drawing.Point(109, 102)
        Me.LableRecvHourOfLength.Name = "LableRecvHourOfLength"
        Me.LableRecvHourOfLength.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvHourOfLength.TabIndex = 32
        Me.LableRecvHourOfLength.Text = "__"
        '
        'ButtonScreenShotOfCamera
        '
        Me.ButtonScreenShotOfCamera.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonScreenShotOfCamera.Location = New System.Drawing.Point(12, 215)
        Me.ButtonScreenShotOfCamera.Name = "ButtonScreenShotOfCamera"
        Me.ButtonScreenShotOfCamera.Size = New System.Drawing.Size(82, 40)
        Me.ButtonScreenShotOfCamera.TabIndex = 39
        Me.ButtonScreenShotOfCamera.Text = "摄像头采集界面屏幕抓图"
        Me.ButtonScreenShotOfCamera.UseVisualStyleBackColor = False
        '
        'PictureBoxScreenShotOfCamera
        '
        Me.PictureBoxScreenShotOfCamera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxScreenShotOfCamera.Location = New System.Drawing.Point(114, 170)
        Me.PictureBoxScreenShotOfCamera.Name = "PictureBoxScreenShotOfCamera"
        Me.PictureBoxScreenShotOfCamera.Size = New System.Drawing.Size(212, 146)
        Me.PictureBoxScreenShotOfCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxScreenShotOfCamera.TabIndex = 40
        Me.PictureBoxScreenShotOfCamera.TabStop = False
        '
        'ButtonStartUpload
        '
        Me.ButtonStartUpload.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonStartUpload.Enabled = False
        Me.ButtonStartUpload.Location = New System.Drawing.Point(121, 452)
        Me.ButtonStartUpload.Name = "ButtonStartUpload"
        Me.ButtonStartUpload.Size = New System.Drawing.Size(88, 28)
        Me.ButtonStartUpload.TabIndex = 46
        Me.ButtonStartUpload.Text = "开始上载"
        Me.ButtonStartUpload.UseVisualStyleBackColor = False
        '
        'PictureBoxCamera
        '
        Me.PictureBoxCamera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxCamera.Location = New System.Drawing.Point(114, 10)
        Me.PictureBoxCamera.Name = "PictureBoxCamera"
        Me.PictureBoxCamera.Size = New System.Drawing.Size(212, 154)
        Me.PictureBoxCamera.TabIndex = 52
        Me.PictureBoxCamera.TabStop = False
        '
        'ButtonScreenShotOfDaYangUpload
        '
        Me.ButtonScreenShotOfDaYangUpload.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonScreenShotOfDaYangUpload.Location = New System.Drawing.Point(12, 19)
        Me.ButtonScreenShotOfDaYangUpload.Name = "ButtonScreenShotOfDaYangUpload"
        Me.ButtonScreenShotOfDaYangUpload.Size = New System.Drawing.Size(82, 43)
        Me.ButtonScreenShotOfDaYangUpload.TabIndex = 17
        Me.ButtonScreenShotOfDaYangUpload.Text = "大洋采集界面屏幕抓图"
        Me.ButtonScreenShotOfDaYangUpload.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBoxTaskType)
        Me.Panel1.Controls.Add(Me.LabelTaskType)
        Me.Panel1.Controls.Add(Me.ButtonStartUpload)
        Me.Panel1.Controls.Add(Me.TextBoxProgramType)
        Me.Panel1.Controls.Add(Me.LabelProgramType)
        Me.Panel1.Controls.Add(Me.ComboBoxUploadChannel)
        Me.Panel1.Controls.Add(Me.LabelUploadChannel)
        Me.Panel1.Controls.Add(Me.LabelUploader)
        Me.Panel1.Controls.Add(Me.TextBoxUploader)
        Me.Panel1.Controls.Add(Me.ButtonClear)
        Me.Panel1.Controls.Add(Me.LableRecvFrameOfEndTimeCode)
        Me.Panel1.Controls.Add(Me.LableRecvSecOfEndTimeCode)
        Me.Panel1.Controls.Add(Me.LableRecvMinOfEndTimeCode)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.LableRecvHourOfEndTimeCode)
        Me.Panel1.Controls.Add(Me.LableRecvEndTimeCode)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.TextBoxUploadEndTimeCodeFrame)
        Me.Panel1.Controls.Add(Me.TextBoxUploadEndTimeCodeSec)
        Me.Panel1.Controls.Add(Me.TextBoxUploadEndTimeCodeMin)
        Me.Panel1.Controls.Add(Me.TextBoxUploadEndTimeCodeHour)
        Me.Panel1.Controls.Add(Me.LabelUploadEndTimeCode)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.LableRecvFrameOfLength)
        Me.Panel1.Controls.Add(Me.LableRecvSecOfLength)
        Me.Panel1.Controls.Add(Me.LableRecvMinOfLength)
        Me.Panel1.Controls.Add(Me.LableRecvFrameOfStartTimeCode)
        Me.Panel1.Controls.Add(Me.LableRecvSecOfStartTimeCode)
        Me.Panel1.Controls.Add(Me.LableRecvMinOfStartTimeCode)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBoxUploadLenFrame)
        Me.Panel1.Controls.Add(Me.TextBoxUploadStartTimeCodeFrame)
        Me.Panel1.Controls.Add(Me.TextBoxUploadLenSec)
        Me.Panel1.Controls.Add(Me.TextBoxUploadStartTimeCodeSec)
        Me.Panel1.Controls.Add(Me.TextBoxUploadLenMin)
        Me.Panel1.Controls.Add(Me.TextBoxUploadStartTimeCodeMin)
        Me.Panel1.Controls.Add(Me.ButtonInquiry)
        Me.Panel1.Controls.Add(Me.TextBoxTapeName)
        Me.Panel1.Controls.Add(Me.PB6)
        Me.Panel1.Controls.Add(Me.PB5)
        Me.Panel1.Controls.Add(Me.PB4)
        Me.Panel1.Controls.Add(Me.PB3)
        Me.Panel1.Controls.Add(Me.LableTimeInBcTime)
        Me.Panel1.Controls.Add(Me.TextBoxUploadLenHour)
        Me.Panel1.Controls.Add(Me.TextBoxUploadStartTimeCodeHour)
        Me.Panel1.Controls.Add(Me.ComboBoxSignalSource)
        Me.Panel1.Controls.Add(Me.LableRecvHourOfLength)
        Me.Panel1.Controls.Add(Me.LableRecvHourOfStartTimeCode)
        Me.Panel1.Controls.Add(Me.LableSignalSource)
        Me.Panel1.Controls.Add(Me.TextBoxUploadTime)
        Me.Panel1.Controls.Add(Me.LabelInBcTime)
        Me.Panel1.Controls.Add(Me.LabelUploadTime)
        Me.Panel1.Controls.Add(Me.LableRecvLength)
        Me.Panel1.Controls.Add(Me.LableRecvStartTimeCode)
        Me.Panel1.Controls.Add(Me.LabelUploadLength)
        Me.Panel1.Controls.Add(Me.LabelUploadStartTimeCode)
        Me.Panel1.Controls.Add(Me.Labletapename)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(348, 496)
        Me.Panel1.TabIndex = 54
        '
        'ComboBoxTaskType
        '
        Me.ComboBoxTaskType.FormattingEnabled = True
        Me.ComboBoxTaskType.Items.AddRange(New Object() {"VRT上载", "线路上载"})
        Me.ComboBoxTaskType.Location = New System.Drawing.Point(243, 204)
        Me.ComboBoxTaskType.Name = "ComboBoxTaskType"
        Me.ComboBoxTaskType.Size = New System.Drawing.Size(81, 20)
        Me.ComboBoxTaskType.TabIndex = 101
        '
        'LabelTaskType
        '
        Me.LabelTaskType.AutoSize = True
        Me.LabelTaskType.Location = New System.Drawing.Point(182, 207)
        Me.LabelTaskType.Name = "LabelTaskType"
        Me.LabelTaskType.Size = New System.Drawing.Size(53, 12)
        Me.LabelTaskType.TabIndex = 100
        Me.LabelTaskType.Text = "任务类型"
        '
        'TextBoxProgramType
        '
        Me.TextBoxProgramType.Location = New System.Drawing.Point(89, 44)
        Me.TextBoxProgramType.Name = "TextBoxProgramType"
        Me.TextBoxProgramType.Size = New System.Drawing.Size(104, 21)
        Me.TextBoxProgramType.TabIndex = 99
        '
        'LabelProgramType
        '
        Me.LabelProgramType.AutoSize = True
        Me.LabelProgramType.Location = New System.Drawing.Point(16, 47)
        Me.LabelProgramType.Name = "LabelProgramType"
        Me.LabelProgramType.Size = New System.Drawing.Size(65, 12)
        Me.LabelProgramType.TabIndex = 98
        Me.LabelProgramType.Text = "节目类型："
        '
        'ComboBoxUploadChannel
        '
        Me.ComboBoxUploadChannel.FormattingEnabled = True
        Me.ComboBoxUploadChannel.Items.AddRange(New Object() {"第1上载通道", "第2上载通道"})
        Me.ComboBoxUploadChannel.Location = New System.Drawing.Point(89, 204)
        Me.ComboBoxUploadChannel.Name = "ComboBoxUploadChannel"
        Me.ComboBoxUploadChannel.Size = New System.Drawing.Size(81, 20)
        Me.ComboBoxUploadChannel.TabIndex = 97
        '
        'LabelUploadChannel
        '
        Me.LabelUploadChannel.AutoSize = True
        Me.LabelUploadChannel.Location = New System.Drawing.Point(14, 207)
        Me.LabelUploadChannel.Name = "LabelUploadChannel"
        Me.LabelUploadChannel.Size = New System.Drawing.Size(53, 12)
        Me.LabelUploadChannel.TabIndex = 96
        Me.LabelUploadChannel.Text = "上载通道"
        '
        'LabelUploader
        '
        Me.LabelUploader.AutoSize = True
        Me.LabelUploader.Location = New System.Drawing.Point(19, 427)
        Me.LabelUploader.Name = "LabelUploader"
        Me.LabelUploader.Size = New System.Drawing.Size(41, 12)
        Me.LabelUploader.TabIndex = 95
        Me.LabelUploader.Text = "上载人"
        '
        'TextBoxUploader
        '
        Me.TextBoxUploader.Location = New System.Drawing.Point(83, 424)
        Me.TextBoxUploader.Name = "TextBoxUploader"
        Me.TextBoxUploader.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxUploader.TabIndex = 94
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonClear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ButtonClear.Location = New System.Drawing.Point(20, 452)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(88, 28)
        Me.ButtonClear.TabIndex = 93
        Me.ButtonClear.Text = "清空"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'LableRecvFrameOfEndTimeCode
        '
        Me.LableRecvFrameOfEndTimeCode.AutoSize = True
        Me.LableRecvFrameOfEndTimeCode.Location = New System.Drawing.Point(198, 130)
        Me.LableRecvFrameOfEndTimeCode.Name = "LableRecvFrameOfEndTimeCode"
        Me.LableRecvFrameOfEndTimeCode.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvFrameOfEndTimeCode.TabIndex = 92
        Me.LableRecvFrameOfEndTimeCode.Text = "__"
        '
        'LableRecvSecOfEndTimeCode
        '
        Me.LableRecvSecOfEndTimeCode.AutoSize = True
        Me.LableRecvSecOfEndTimeCode.Location = New System.Drawing.Point(166, 130)
        Me.LableRecvSecOfEndTimeCode.Name = "LableRecvSecOfEndTimeCode"
        Me.LableRecvSecOfEndTimeCode.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvSecOfEndTimeCode.TabIndex = 91
        Me.LableRecvSecOfEndTimeCode.Text = "__"
        '
        'LableRecvMinOfEndTimeCode
        '
        Me.LableRecvMinOfEndTimeCode.AutoSize = True
        Me.LableRecvMinOfEndTimeCode.Location = New System.Drawing.Point(135, 130)
        Me.LableRecvMinOfEndTimeCode.Name = "LableRecvMinOfEndTimeCode"
        Me.LableRecvMinOfEndTimeCode.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvMinOfEndTimeCode.TabIndex = 90
        Me.LableRecvMinOfEndTimeCode.Text = "__"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(182, 130)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(10, 18)
        Me.Label31.TabIndex = 89
        Me.Label31.Text = "："
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(152, 130)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(10, 18)
        Me.Label30.TabIndex = 88
        Me.Label30.Text = "："
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(125, 130)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(10, 18)
        Me.Label29.TabIndex = 87
        Me.Label29.Text = "："
        '
        'LableRecvHourOfEndTimeCode
        '
        Me.LableRecvHourOfEndTimeCode.AutoSize = True
        Me.LableRecvHourOfEndTimeCode.Location = New System.Drawing.Point(109, 130)
        Me.LableRecvHourOfEndTimeCode.Name = "LableRecvHourOfEndTimeCode"
        Me.LableRecvHourOfEndTimeCode.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvHourOfEndTimeCode.TabIndex = 86
        Me.LableRecvHourOfEndTimeCode.Text = "__"
        '
        'LableRecvEndTimeCode
        '
        Me.LableRecvEndTimeCode.AutoSize = True
        Me.LableRecvEndTimeCode.Location = New System.Drawing.Point(14, 130)
        Me.LableRecvEndTimeCode.Name = "LableRecvEndTimeCode"
        Me.LableRecvEndTimeCode.Size = New System.Drawing.Size(89, 12)
        Me.LableRecvEndTimeCode.TabIndex = 85
        Me.LableRecvEndTimeCode.Text = "交接终止时码："
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(200, 334)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(10, 18)
        Me.Label20.TabIndex = 84
        Me.Label20.Text = "："
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(160, 334)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 18)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "："
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(114, 334)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(10, 18)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "："
        '
        'TextBoxUploadEndTimeCodeFrame
        '
        Me.TextBoxUploadEndTimeCodeFrame.Enabled = False
        Me.TextBoxUploadEndTimeCodeFrame.Location = New System.Drawing.Point(212, 331)
        Me.TextBoxUploadEndTimeCodeFrame.Name = "TextBoxUploadEndTimeCodeFrame"
        Me.TextBoxUploadEndTimeCodeFrame.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadEndTimeCodeFrame.TabIndex = 81
        '
        'TextBoxUploadEndTimeCodeSec
        '
        Me.TextBoxUploadEndTimeCodeSec.Enabled = False
        Me.TextBoxUploadEndTimeCodeSec.Location = New System.Drawing.Point(170, 331)
        Me.TextBoxUploadEndTimeCodeSec.Name = "TextBoxUploadEndTimeCodeSec"
        Me.TextBoxUploadEndTimeCodeSec.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadEndTimeCodeSec.TabIndex = 80
        '
        'TextBoxUploadEndTimeCodeMin
        '
        Me.TextBoxUploadEndTimeCodeMin.Enabled = False
        Me.TextBoxUploadEndTimeCodeMin.Location = New System.Drawing.Point(130, 331)
        Me.TextBoxUploadEndTimeCodeMin.Name = "TextBoxUploadEndTimeCodeMin"
        Me.TextBoxUploadEndTimeCodeMin.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadEndTimeCodeMin.TabIndex = 79
        '
        'TextBoxUploadEndTimeCodeHour
        '
        Me.TextBoxUploadEndTimeCodeHour.Enabled = False
        Me.TextBoxUploadEndTimeCodeHour.Location = New System.Drawing.Point(90, 331)
        Me.TextBoxUploadEndTimeCodeHour.Name = "TextBoxUploadEndTimeCodeHour"
        Me.TextBoxUploadEndTimeCodeHour.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadEndTimeCodeHour.TabIndex = 78
        '
        'LabelUploadEndTimeCode
        '
        Me.LabelUploadEndTimeCode.AutoSize = True
        Me.LabelUploadEndTimeCode.Location = New System.Drawing.Point(14, 334)
        Me.LabelUploadEndTimeCode.Name = "LabelUploadEndTimeCode"
        Me.LabelUploadEndTimeCode.Size = New System.Drawing.Size(65, 12)
        Me.LabelUploadEndTimeCode.TabIndex = 77
        Me.LabelUploadEndTimeCode.Text = "终止时码："
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(182, 102)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(10, 18)
        Me.Label28.TabIndex = 76
        Me.Label28.Text = "："
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(152, 102)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(10, 18)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "："
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(125, 102)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(10, 18)
        Me.Label26.TabIndex = 74
        Me.Label26.Text = "："
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(182, 77)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(10, 18)
        Me.Label25.TabIndex = 73
        Me.Label25.Text = "："
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(152, 77)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 18)
        Me.Label24.TabIndex = 72
        Me.Label24.Text = "："
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(125, 77)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 18)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "："
        '
        'LableRecvFrameOfLength
        '
        Me.LableRecvFrameOfLength.AutoSize = True
        Me.LableRecvFrameOfLength.Location = New System.Drawing.Point(198, 102)
        Me.LableRecvFrameOfLength.Name = "LableRecvFrameOfLength"
        Me.LableRecvFrameOfLength.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvFrameOfLength.TabIndex = 70
        Me.LableRecvFrameOfLength.Text = "__"
        '
        'LableRecvSecOfLength
        '
        Me.LableRecvSecOfLength.AutoSize = True
        Me.LableRecvSecOfLength.Location = New System.Drawing.Point(166, 102)
        Me.LableRecvSecOfLength.Name = "LableRecvSecOfLength"
        Me.LableRecvSecOfLength.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvSecOfLength.TabIndex = 69
        Me.LableRecvSecOfLength.Text = "__"
        '
        'LableRecvMinOfLength
        '
        Me.LableRecvMinOfLength.AutoSize = True
        Me.LableRecvMinOfLength.Location = New System.Drawing.Point(135, 102)
        Me.LableRecvMinOfLength.Name = "LableRecvMinOfLength"
        Me.LableRecvMinOfLength.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvMinOfLength.TabIndex = 68
        Me.LableRecvMinOfLength.Text = "__"
        '
        'LableRecvFrameOfStartTimeCode
        '
        Me.LableRecvFrameOfStartTimeCode.AutoSize = True
        Me.LableRecvFrameOfStartTimeCode.Location = New System.Drawing.Point(198, 77)
        Me.LableRecvFrameOfStartTimeCode.Name = "LableRecvFrameOfStartTimeCode"
        Me.LableRecvFrameOfStartTimeCode.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvFrameOfStartTimeCode.TabIndex = 67
        Me.LableRecvFrameOfStartTimeCode.Text = "__"
        '
        'LableRecvSecOfStartTimeCode
        '
        Me.LableRecvSecOfStartTimeCode.AutoSize = True
        Me.LableRecvSecOfStartTimeCode.Location = New System.Drawing.Point(166, 77)
        Me.LableRecvSecOfStartTimeCode.Name = "LableRecvSecOfStartTimeCode"
        Me.LableRecvSecOfStartTimeCode.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvSecOfStartTimeCode.TabIndex = 66
        Me.LableRecvSecOfStartTimeCode.Text = "__"
        '
        'LableRecvMinOfStartTimeCode
        '
        Me.LableRecvMinOfStartTimeCode.AutoSize = True
        Me.LableRecvMinOfStartTimeCode.Location = New System.Drawing.Point(135, 77)
        Me.LableRecvMinOfStartTimeCode.Name = "LableRecvMinOfStartTimeCode"
        Me.LableRecvMinOfStartTimeCode.Size = New System.Drawing.Size(17, 12)
        Me.LableRecvMinOfStartTimeCode.TabIndex = 65
        Me.LableRecvMinOfStartTimeCode.Text = "__"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(200, 303)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(10, 18)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "："
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(160, 303)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 18)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "："
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(114, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 18)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "："
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(200, 274)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 18)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "："
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(160, 274)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 18)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "："
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(114, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 18)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "："
        '
        'TextBoxUploadLenFrame
        '
        Me.TextBoxUploadLenFrame.Location = New System.Drawing.Point(212, 300)
        Me.TextBoxUploadLenFrame.Name = "TextBoxUploadLenFrame"
        Me.TextBoxUploadLenFrame.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadLenFrame.TabIndex = 58
        '
        'TextBoxUploadStartTimeCodeFrame
        '
        Me.TextBoxUploadStartTimeCodeFrame.Location = New System.Drawing.Point(212, 265)
        Me.TextBoxUploadStartTimeCodeFrame.Name = "TextBoxUploadStartTimeCodeFrame"
        Me.TextBoxUploadStartTimeCodeFrame.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadStartTimeCodeFrame.TabIndex = 57
        '
        'TextBoxUploadLenSec
        '
        Me.TextBoxUploadLenSec.Location = New System.Drawing.Point(170, 300)
        Me.TextBoxUploadLenSec.Name = "TextBoxUploadLenSec"
        Me.TextBoxUploadLenSec.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadLenSec.TabIndex = 56
        '
        'TextBoxUploadStartTimeCodeSec
        '
        Me.TextBoxUploadStartTimeCodeSec.Location = New System.Drawing.Point(170, 265)
        Me.TextBoxUploadStartTimeCodeSec.Name = "TextBoxUploadStartTimeCodeSec"
        Me.TextBoxUploadStartTimeCodeSec.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadStartTimeCodeSec.TabIndex = 55
        '
        'TextBoxUploadLenMin
        '
        Me.TextBoxUploadLenMin.Location = New System.Drawing.Point(130, 300)
        Me.TextBoxUploadLenMin.Name = "TextBoxUploadLenMin"
        Me.TextBoxUploadLenMin.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadLenMin.TabIndex = 54
        '
        'TextBoxUploadStartTimeCodeMin
        '
        Me.TextBoxUploadStartTimeCodeMin.Location = New System.Drawing.Point(130, 265)
        Me.TextBoxUploadStartTimeCodeMin.Name = "TextBoxUploadStartTimeCodeMin"
        Me.TextBoxUploadStartTimeCodeMin.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadStartTimeCodeMin.TabIndex = 53
        '
        'ButtonInquiry
        '
        Me.ButtonInquiry.Location = New System.Drawing.Point(269, 14)
        Me.ButtonInquiry.Name = "ButtonInquiry"
        Me.ButtonInquiry.Size = New System.Drawing.Size(55, 21)
        Me.ButtonInquiry.TabIndex = 52
        Me.ButtonInquiry.Text = "查询"
        Me.ButtonInquiry.UseVisualStyleBackColor = True
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Location = New System.Drawing.Point(90, 15)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(173, 21)
        Me.TextBoxTapeName.TabIndex = 51
        '
        'PB6
        '
        Me.PB6.Enabled = False
        Me.PB6.Image = CType(resources.GetObject("PB6.Image"), System.Drawing.Image)
        Me.PB6.Location = New System.Drawing.Point(250, 302)
        Me.PB6.Name = "PB6"
        Me.PB6.Size = New System.Drawing.Size(16, 21)
        Me.PB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB6.TabIndex = 50
        Me.PB6.TabStop = False
        Me.PB6.Visible = False
        '
        'PB5
        '
        Me.PB5.Enabled = False
        Me.PB5.Image = CType(resources.GetObject("PB5.Image"), System.Drawing.Image)
        Me.PB5.Location = New System.Drawing.Point(250, 263)
        Me.PB5.Name = "PB5"
        Me.PB5.Size = New System.Drawing.Size(16, 21)
        Me.PB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB5.TabIndex = 49
        Me.PB5.TabStop = False
        Me.PB5.Visible = False
        '
        'PB4
        '
        Me.PB4.Enabled = False
        Me.PB4.Image = CType(resources.GetObject("PB4.Image"), System.Drawing.Image)
        Me.PB4.Location = New System.Drawing.Point(250, 303)
        Me.PB4.Name = "PB4"
        Me.PB4.Size = New System.Drawing.Size(29, 20)
        Me.PB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB4.TabIndex = 48
        Me.PB4.TabStop = False
        Me.PB4.Visible = False
        '
        'PB3
        '
        Me.PB3.Enabled = False
        Me.PB3.Image = CType(resources.GetObject("PB3.Image"), System.Drawing.Image)
        Me.PB3.Location = New System.Drawing.Point(250, 265)
        Me.PB3.Name = "PB3"
        Me.PB3.Size = New System.Drawing.Size(29, 21)
        Me.PB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB3.TabIndex = 47
        Me.PB3.TabStop = False
        Me.PB3.Visible = False
        '
        'LableTimeInBcTime
        '
        Me.LableTimeInBcTime.AutoSize = True
        Me.LableTimeInBcTime.Location = New System.Drawing.Point(95, 159)
        Me.LableTimeInBcTime.Name = "LableTimeInBcTime"
        Me.LableTimeInBcTime.Size = New System.Drawing.Size(137, 12)
        Me.LableTimeInBcTime.TabIndex = 43
        Me.LableTimeInBcTime.Text = "2014年3月12日 12:00:00"
        '
        'TextBoxUploadLenHour
        '
        Me.TextBoxUploadLenHour.Location = New System.Drawing.Point(90, 300)
        Me.TextBoxUploadLenHour.Name = "TextBoxUploadLenHour"
        Me.TextBoxUploadLenHour.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadLenHour.TabIndex = 36
        '
        'TextBoxUploadStartTimeCodeHour
        '
        Me.TextBoxUploadStartTimeCodeHour.Location = New System.Drawing.Point(90, 265)
        Me.TextBoxUploadStartTimeCodeHour.Name = "TextBoxUploadStartTimeCodeHour"
        Me.TextBoxUploadStartTimeCodeHour.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxUploadStartTimeCodeHour.TabIndex = 35
        '
        'ComboBoxSignalSource
        '
        Me.ComboBoxSignalSource.BackColor = System.Drawing.Color.White
        Me.ComboBoxSignalSource.FormattingEnabled = True
        Me.ComboBoxSignalSource.Items.AddRange(New Object() {"录像机1", "录像机2", "录像机3"})
        Me.ComboBoxSignalSource.Location = New System.Drawing.Point(89, 236)
        Me.ComboBoxSignalSource.Name = "ComboBoxSignalSource"
        Me.ComboBoxSignalSource.Size = New System.Drawing.Size(81, 20)
        Me.ComboBoxSignalSource.TabIndex = 34
        '
        'LableSignalSource
        '
        Me.LableSignalSource.AutoSize = True
        Me.LableSignalSource.Location = New System.Drawing.Point(14, 239)
        Me.LableSignalSource.Name = "LableSignalSource"
        Me.LableSignalSource.Size = New System.Drawing.Size(53, 12)
        Me.LableSignalSource.TabIndex = 29
        Me.LableSignalSource.Text = "信号源："
        '
        'TextBoxUploadTime
        '
        Me.TextBoxUploadTime.Location = New System.Drawing.Point(90, 361)
        Me.TextBoxUploadTime.Name = "TextBoxUploadTime"
        Me.TextBoxUploadTime.Size = New System.Drawing.Size(146, 21)
        Me.TextBoxUploadTime.TabIndex = 28
        '
        'LabelInBcTime
        '
        Me.LabelInBcTime.AutoSize = True
        Me.LabelInBcTime.Location = New System.Drawing.Point(14, 159)
        Me.LabelInBcTime.Name = "LabelInBcTime"
        Me.LabelInBcTime.Size = New System.Drawing.Size(65, 12)
        Me.LabelInBcTime.TabIndex = 6
        Me.LabelInBcTime.Text = "交接日期："
        '
        'LabelUploadTime
        '
        Me.LabelUploadTime.AutoSize = True
        Me.LabelUploadTime.Location = New System.Drawing.Point(14, 367)
        Me.LabelUploadTime.Name = "LabelUploadTime"
        Me.LabelUploadTime.Size = New System.Drawing.Size(65, 12)
        Me.LabelUploadTime.TabIndex = 5
        Me.LabelUploadTime.Text = "当前时间："
        '
        'LabelUploadLength
        '
        Me.LabelUploadLength.AutoSize = True
        Me.LabelUploadLength.Location = New System.Drawing.Point(14, 300)
        Me.LabelUploadLength.Name = "LabelUploadLength"
        Me.LabelUploadLength.Size = New System.Drawing.Size(65, 12)
        Me.LabelUploadLength.TabIndex = 2
        Me.LabelUploadLength.Text = "节目时长："
        '
        'LabelUploadStartTimeCode
        '
        Me.LabelUploadStartTimeCode.AutoSize = True
        Me.LabelUploadStartTimeCode.Location = New System.Drawing.Point(14, 268)
        Me.LabelUploadStartTimeCode.Name = "LabelUploadStartTimeCode"
        Me.LabelUploadStartTimeCode.Size = New System.Drawing.Size(65, 12)
        Me.LabelUploadStartTimeCode.TabIndex = 1
        Me.LabelUploadStartTimeCode.Text = "起始时码："
        '
        'CheckBoxEpisodeCheck
        '
        Me.CheckBoxEpisodeCheck.AutoSize = True
        Me.CheckBoxEpisodeCheck.Location = New System.Drawing.Point(12, 387)
        Me.CheckBoxEpisodeCheck.Name = "CheckBoxEpisodeCheck"
        Me.CheckBoxEpisodeCheck.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxEpisodeCheck.TabIndex = 10
        Me.CheckBoxEpisodeCheck.Text = "集数期数检查"
        Me.CheckBoxEpisodeCheck.UseVisualStyleBackColor = True
        '
        'CheckBoxImageCheck
        '
        Me.CheckBoxImageCheck.AutoSize = True
        Me.CheckBoxImageCheck.Location = New System.Drawing.Point(12, 362)
        Me.CheckBoxImageCheck.Name = "CheckBoxImageCheck"
        Me.CheckBoxImageCheck.Size = New System.Drawing.Size(72, 16)
        Me.CheckBoxImageCheck.TabIndex = 9
        Me.CheckBoxImageCheck.Text = "图像检查"
        Me.CheckBoxImageCheck.UseVisualStyleBackColor = True
        '
        'CheckBoxVolumeCheck
        '
        Me.CheckBoxVolumeCheck.AutoSize = True
        Me.CheckBoxVolumeCheck.Location = New System.Drawing.Point(12, 332)
        Me.CheckBoxVolumeCheck.Name = "CheckBoxVolumeCheck"
        Me.CheckBoxVolumeCheck.Size = New System.Drawing.Size(72, 16)
        Me.CheckBoxVolumeCheck.TabIndex = 8
        Me.CheckBoxVolumeCheck.Text = "音量检查"
        Me.CheckBoxVolumeCheck.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBoxCamera)
        Me.Panel2.Controls.Add(Me.PictureBoxScreenShotOfCamera)
        Me.Panel2.Controls.Add(Me.ButtonScreenShotOfCamera)
        Me.Panel2.Controls.Add(Me.ButtonStopUpload)
        Me.Panel2.Controls.Add(Me.ButtonFinishUpload)
        Me.Panel2.Controls.Add(Me.CheckBoxEpisodeCheck)
        Me.Panel2.Controls.Add(Me.CheckBoxVolumeCheck)
        Me.Panel2.Controls.Add(Me.CheckBoxImageCheck)
        Me.Panel2.Controls.Add(Me.TextBoxRemark)
        Me.Panel2.Location = New System.Drawing.Point(354, 173)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 447)
        Me.Panel2.TabIndex = 55
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ButtonGoBack)
        Me.Panel3.Controls.Add(Me.ButtonScreenShotOfDaYangUpload)
        Me.Panel3.Controls.Add(Me.PictureBoxScreenShotOfDaYangUpload)
        Me.Panel3.Location = New System.Drawing.Point(354, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 164)
        Me.Panel3.TabIndex = 56
        '
        'ButtonGoBack
        '
        Me.ButtonGoBack.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonGoBack.Location = New System.Drawing.Point(12, 104)
        Me.ButtonGoBack.Name = "ButtonGoBack"
        Me.ButtonGoBack.Size = New System.Drawing.Size(82, 41)
        Me.ButtonGoBack.TabIndex = 18
        Me.ButtonGoBack.Text = "返回"
        Me.ButtonGoBack.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        '
        'UpLoadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 622)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "UpLoadForm"
        Me.Text = "节目上载界面"
        CType(Me.PictureBoxScreenShotOfDaYangUpload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxScreenShotOfCamera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Labletapename As System.Windows.Forms.Label
    Friend WithEvents LableRecvStartTimeCode As System.Windows.Forms.Label
    Friend WithEvents LableRecvLength As System.Windows.Forms.Label
    Friend WithEvents TextBoxRemark As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxScreenShotOfDaYangUpload As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonFinishUpload As System.Windows.Forms.Button
    Friend WithEvents ButtonStopUpload As System.Windows.Forms.Button
    Friend WithEvents LableRecvHourOfStartTimeCode As System.Windows.Forms.Label
    Friend WithEvents LableRecvHourOfLength As System.Windows.Forms.Label
    Friend WithEvents ButtonScreenShotOfCamera As System.Windows.Forms.Button
    Friend WithEvents PictureBoxScreenShotOfCamera As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonStartUpload As System.Windows.Forms.Button
    Friend WithEvents PictureBoxCamera As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonScreenShotOfDaYangUpload As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ButtonGoBack As System.Windows.Forms.Button
    Friend WithEvents ButtonInquiry As System.Windows.Forms.Button
    Friend WithEvents TextBoxTapeName As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LableRecvFrameOfLength As System.Windows.Forms.Label
    Friend WithEvents LableRecvSecOfLength As System.Windows.Forms.Label
    Friend WithEvents LableRecvMinOfLength As System.Windows.Forms.Label
    Friend WithEvents LableRecvFrameOfStartTimeCode As System.Windows.Forms.Label
    Friend WithEvents LableRecvSecOfStartTimeCode As System.Windows.Forms.Label
    Friend WithEvents LableRecvMinOfStartTimeCode As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUploadEndTimeCodeFrame As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUploadEndTimeCodeSec As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUploadEndTimeCodeMin As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUploadEndTimeCodeHour As System.Windows.Forms.TextBox
    Friend WithEvents LabelUploadEndTimeCode As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUploadLenFrame As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUploadStartTimeCodeFrame As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUploadLenSec As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUploadStartTimeCodeSec As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUploadLenMin As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUploadStartTimeCodeMin As System.Windows.Forms.TextBox
    Friend WithEvents PB6 As System.Windows.Forms.PictureBox
    Friend WithEvents PB5 As System.Windows.Forms.PictureBox
    Friend WithEvents PB4 As System.Windows.Forms.PictureBox
    Friend WithEvents PB3 As System.Windows.Forms.PictureBox
    Friend WithEvents LableTimeInBcTime As System.Windows.Forms.Label
    Friend WithEvents TextBoxUploadLenHour As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUploadStartTimeCodeHour As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxSignalSource As System.Windows.Forms.ComboBox
    Friend WithEvents LableSignalSource As System.Windows.Forms.Label
    Friend WithEvents TextBoxUploadTime As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxEpisodeCheck As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxImageCheck As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxVolumeCheck As System.Windows.Forms.CheckBox
    Friend WithEvents LabelInBcTime As System.Windows.Forms.Label
    Friend WithEvents LabelUploadTime As System.Windows.Forms.Label
    Friend WithEvents LabelUploadLength As System.Windows.Forms.Label
    Friend WithEvents LabelUploadStartTimeCode As System.Windows.Forms.Label
    Friend WithEvents LableRecvFrameOfEndTimeCode As System.Windows.Forms.Label
    Friend WithEvents LableRecvSecOfEndTimeCode As System.Windows.Forms.Label
    Friend WithEvents LableRecvMinOfEndTimeCode As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents LableRecvHourOfEndTimeCode As System.Windows.Forms.Label
    Friend WithEvents LableRecvEndTimeCode As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents LabelUploader As System.Windows.Forms.Label
    Friend WithEvents TextBoxUploader As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelUploadChannel As System.Windows.Forms.Label
    Friend WithEvents ComboBoxUploadChannel As System.Windows.Forms.ComboBox
    Friend WithEvents LabelProgramType As System.Windows.Forms.Label
    Friend WithEvents TextBoxProgramType As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxTaskType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelTaskType As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
