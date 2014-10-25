<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WatchUpload
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
        Me.LabelTapeName = New System.Windows.Forms.Label
        Me.TextBoxTapeName = New System.Windows.Forms.TextBox
        Me.Label = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelLengthText = New System.Windows.Forms.Label
        Me.LabelEndTimeCodeText = New System.Windows.Forms.Label
        Me.LabelStartTimeCodeText = New System.Windows.Forms.Label
        Me.LabelProgramTypeText = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LabelUploadMachineText = New System.Windows.Forms.Label
        Me.LabelUploaderText = New System.Windows.Forms.Label
        Me.LabelUploadTimeText = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PanelDYScreenShot = New System.Windows.Forms.Panel
        Me.PictureBoxScreenshot = New System.Windows.Forms.PictureBox
        Me.PanelCamera = New System.Windows.Forms.Panel
        Me.PictureBoxCamera = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.LabelInBcSendPer = New System.Windows.Forms.Label
        Me.Label1InBcSendDepartment = New System.Windows.Forms.Label
        Me.Label1InBcSendTelePhone = New System.Windows.Forms.Label
        Me.Label1InBcRecvPer = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelDYScreenShot.SuspendLayout()
        CType(Me.PictureBoxScreenshot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCamera.SuspendLayout()
        CType(Me.PictureBoxCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTapeName
        '
        Me.LabelTapeName.AutoSize = True
        Me.LabelTapeName.Location = New System.Drawing.Point(15, 32)
        Me.LabelTapeName.Name = "LabelTapeName"
        Me.LabelTapeName.Size = New System.Drawing.Size(53, 12)
        Me.LabelTapeName.TabIndex = 0
        Me.LabelTapeName.Text = "节目名称"
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Location = New System.Drawing.Point(74, 23)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTapeName.TabIndex = 1
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(15, 60)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(53, 12)
        Me.Label.TabIndex = 2
        Me.Label.Text = "节目类型"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "开始时码"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "终止时码"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "时长"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelLengthText)
        Me.GroupBox1.Controls.Add(Me.LabelEndTimeCodeText)
        Me.GroupBox1.Controls.Add(Me.LabelStartTimeCodeText)
        Me.GroupBox1.Controls.Add(Me.LabelProgramTypeText)
        Me.GroupBox1.Controls.Add(Me.LabelTapeName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxTapeName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 168)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "磁带信息"
        '
        'LabelLengthText
        '
        Me.LabelLengthText.AutoSize = True
        Me.LabelLengthText.Location = New System.Drawing.Point(75, 146)
        Me.LabelLengthText.Name = "LabelLengthText"
        Me.LabelLengthText.Size = New System.Drawing.Size(29, 12)
        Me.LabelLengthText.TabIndex = 9
        Me.LabelLengthText.Text = "暂无"
        '
        'LabelEndTimeCodeText
        '
        Me.LabelEndTimeCodeText.AutoSize = True
        Me.LabelEndTimeCodeText.Location = New System.Drawing.Point(75, 118)
        Me.LabelEndTimeCodeText.Name = "LabelEndTimeCodeText"
        Me.LabelEndTimeCodeText.Size = New System.Drawing.Size(29, 12)
        Me.LabelEndTimeCodeText.TabIndex = 8
        Me.LabelEndTimeCodeText.Text = "暂无"
        '
        'LabelStartTimeCodeText
        '
        Me.LabelStartTimeCodeText.AutoSize = True
        Me.LabelStartTimeCodeText.Location = New System.Drawing.Point(75, 91)
        Me.LabelStartTimeCodeText.Name = "LabelStartTimeCodeText"
        Me.LabelStartTimeCodeText.Size = New System.Drawing.Size(29, 12)
        Me.LabelStartTimeCodeText.TabIndex = 7
        Me.LabelStartTimeCodeText.Text = "暂无"
        '
        'LabelProgramTypeText
        '
        Me.LabelProgramTypeText.AutoSize = True
        Me.LabelProgramTypeText.Location = New System.Drawing.Point(75, 60)
        Me.LabelProgramTypeText.Name = "LabelProgramTypeText"
        Me.LabelProgramTypeText.Size = New System.Drawing.Size(29, 12)
        Me.LabelProgramTypeText.TabIndex = 6
        Me.LabelProgramTypeText.Text = "暂无"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelUploadMachineText)
        Me.GroupBox2.Controls.Add(Me.LabelUploaderText)
        Me.GroupBox2.Controls.Add(Me.LabelUploadTimeText)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 116)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "上载信息"
        '
        'LabelUploadMachineText
        '
        Me.LabelUploadMachineText.AutoSize = True
        Me.LabelUploadMachineText.Location = New System.Drawing.Point(74, 84)
        Me.LabelUploadMachineText.Name = "LabelUploadMachineText"
        Me.LabelUploadMachineText.Size = New System.Drawing.Size(29, 12)
        Me.LabelUploadMachineText.TabIndex = 12
        Me.LabelUploadMachineText.Text = "暂无"
        '
        'LabelUploaderText
        '
        Me.LabelUploaderText.AutoSize = True
        Me.LabelUploaderText.Location = New System.Drawing.Point(74, 56)
        Me.LabelUploaderText.Name = "LabelUploaderText"
        Me.LabelUploaderText.Size = New System.Drawing.Size(29, 12)
        Me.LabelUploaderText.TabIndex = 11
        Me.LabelUploaderText.Text = "暂无"
        '
        'LabelUploadTimeText
        '
        Me.LabelUploadTimeText.AutoSize = True
        Me.LabelUploadTimeText.Location = New System.Drawing.Point(74, 30)
        Me.LabelUploadTimeText.Name = "LabelUploadTimeText"
        Me.LabelUploadTimeText.Size = New System.Drawing.Size(29, 12)
        Me.LabelUploadTimeText.TabIndex = 10
        Me.LabelUploadTimeText.Text = "暂无"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "上载机器"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "上载人"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "上载时间"
        '
        'PanelDYScreenShot
        '
        Me.PanelDYScreenShot.Controls.Add(Me.PictureBoxScreenshot)
        Me.PanelDYScreenShot.Location = New System.Drawing.Point(244, 12)
        Me.PanelDYScreenShot.Name = "PanelDYScreenShot"
        Me.PanelDYScreenShot.Size = New System.Drawing.Size(251, 181)
        Me.PanelDYScreenShot.TabIndex = 8
        '
        'PictureBoxScreenshot
        '
        Me.PictureBoxScreenshot.Location = New System.Drawing.Point(3, 3)
        Me.PictureBoxScreenshot.Name = "PictureBoxScreenshot"
        Me.PictureBoxScreenshot.Size = New System.Drawing.Size(245, 178)
        Me.PictureBoxScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxScreenshot.TabIndex = 0
        Me.PictureBoxScreenshot.TabStop = False
        '
        'PanelCamera
        '
        Me.PanelCamera.Controls.Add(Me.PictureBoxCamera)
        Me.PanelCamera.Location = New System.Drawing.Point(244, 209)
        Me.PanelCamera.Name = "PanelCamera"
        Me.PanelCamera.Size = New System.Drawing.Size(251, 181)
        Me.PanelCamera.TabIndex = 9
        '
        'PictureBoxCamera
        '
        Me.PictureBoxCamera.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxCamera.Name = "PictureBoxCamera"
        Me.PictureBoxCamera.Size = New System.Drawing.Size(251, 181)
        Me.PictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCamera.TabIndex = 0
        Me.PictureBoxCamera.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1InBcRecvPer)
        Me.GroupBox3.Controls.Add(Me.Label1InBcSendTelePhone)
        Me.GroupBox3.Controls.Add(Me.Label1InBcSendDepartment)
        Me.GroupBox3.Controls.Add(Me.LabelInBcSendPer)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 308)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 134)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "交接人员信息"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "送带人"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 12)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "部 门"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 12)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "电 话"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "收带人"
        '
        'LabelInBcSendPer
        '
        Me.LabelInBcSendPer.AutoSize = True
        Me.LabelInBcSendPer.Location = New System.Drawing.Point(72, 21)
        Me.LabelInBcSendPer.Name = "LabelInBcSendPer"
        Me.LabelInBcSendPer.Size = New System.Drawing.Size(29, 12)
        Me.LabelInBcSendPer.TabIndex = 11
        Me.LabelInBcSendPer.Text = "暂无"
        '
        'Label1InBcSendDepartment
        '
        Me.Label1InBcSendDepartment.AutoSize = True
        Me.Label1InBcSendDepartment.Location = New System.Drawing.Point(72, 46)
        Me.Label1InBcSendDepartment.Name = "Label1InBcSendDepartment"
        Me.Label1InBcSendDepartment.Size = New System.Drawing.Size(29, 12)
        Me.Label1InBcSendDepartment.TabIndex = 12
        Me.Label1InBcSendDepartment.Text = "暂无"
        '
        'Label1InBcSendTelePhone
        '
        Me.Label1InBcSendTelePhone.AutoSize = True
        Me.Label1InBcSendTelePhone.Location = New System.Drawing.Point(72, 69)
        Me.Label1InBcSendTelePhone.Name = "Label1InBcSendTelePhone"
        Me.Label1InBcSendTelePhone.Size = New System.Drawing.Size(29, 12)
        Me.Label1InBcSendTelePhone.TabIndex = 13
        Me.Label1InBcSendTelePhone.Text = "暂无"
        '
        'Label1InBcRecvPer
        '
        Me.Label1InBcRecvPer.AutoSize = True
        Me.Label1InBcRecvPer.Location = New System.Drawing.Point(75, 103)
        Me.Label1InBcRecvPer.Name = "Label1InBcRecvPer"
        Me.Label1InBcRecvPer.Size = New System.Drawing.Size(29, 12)
        Me.Label1InBcRecvPer.TabIndex = 14
        Me.Label1InBcRecvPer.Text = "暂无"
        '
        'WatchUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 472)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PanelCamera)
        Me.Controls.Add(Me.PanelDYScreenShot)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "WatchUpload"
        Me.Text = "上载信息查看"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelDYScreenShot.ResumeLayout(False)
        CType(Me.PictureBoxScreenshot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCamera.ResumeLayout(False)
        CType(Me.PictureBoxCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelTapeName As System.Windows.Forms.Label
    Friend WithEvents TextBoxTapeName As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelProgramTypeText As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PanelDYScreenShot As System.Windows.Forms.Panel
    Friend WithEvents PanelCamera As System.Windows.Forms.Panel
    Friend WithEvents LabelLengthText As System.Windows.Forms.Label
    Friend WithEvents LabelEndTimeCodeText As System.Windows.Forms.Label
    Friend WithEvents LabelStartTimeCodeText As System.Windows.Forms.Label
    Friend WithEvents LabelUploadMachineText As System.Windows.Forms.Label
    Friend WithEvents LabelUploaderText As System.Windows.Forms.Label
    Friend WithEvents LabelUploadTimeText As System.Windows.Forms.Label
    Friend WithEvents PictureBoxScreenshot As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxCamera As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1InBcRecvPer As System.Windows.Forms.Label
    Friend WithEvents Label1InBcSendTelePhone As System.Windows.Forms.Label
    Friend WithEvents Label1InBcSendDepartment As System.Windows.Forms.Label
    Friend WithEvents LabelInBcSendPer As System.Windows.Forms.Label
End Class
