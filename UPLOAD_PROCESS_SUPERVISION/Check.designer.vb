<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Check
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
        Me.LabelMaterialName = New System.Windows.Forms.Label
        Me.LabelStartTimeCode = New System.Windows.Forms.Label
        Me.LabelLength = New System.Windows.Forms.Label
        Me.LableCheckPointHead = New System.Windows.Forms.Label
        Me.LableCheckPointMid = New System.Windows.Forms.Label
        Me.LableCheckPointTail = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.ButtonScreenShotHead = New System.Windows.Forms.Button
        Me.ButtonScreenShotMid = New System.Windows.Forms.Button
        Me.ButtonScreenShotTail = New System.Windows.Forms.Button
        Me.LabelChecker = New System.Windows.Forms.Label
        Me.ButtonStartCheck = New System.Windows.Forms.Button
        Me.ButtonFinishCheck = New System.Windows.Forms.Button
        Me.TextBoxCheckPointHead = New System.Windows.Forms.TextBox
        Me.TextBoxCheckPointMid = New System.Windows.Forms.TextBox
        Me.TextBoxCheckPointTail = New System.Windows.Forms.TextBox
        Me.TextBoxLength = New System.Windows.Forms.TextBox
        Me.TextBoxRemark = New System.Windows.Forms.TextBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.ButtonScreenShotDate = New System.Windows.Forms.Button
        Me.ButtonCancelCheck = New System.Windows.Forms.Button
        Me.TextBoxStartTimeCode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBoxChecker = New System.Windows.Forms.TextBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.LabelPMaterialName = New System.Windows.Forms.TextBox
        Me.CheckBoxNameCheck = New System.Windows.Forms.CheckBox
        Me.CheckBoxLenCheck = New System.Windows.Forms.CheckBox
        Me.CheckBoxDateEpisodeCheck = New System.Windows.Forms.CheckBox
        Me.CheckBoxSoundPicSyncCheck = New System.Windows.Forms.CheckBox
        Me.CheckBoxVolumeCheck = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMaterialName
        '
        Me.LabelMaterialName.AutoSize = True
        Me.LabelMaterialName.Location = New System.Drawing.Point(14, 47)
        Me.LabelMaterialName.Name = "LabelMaterialName"
        Me.LabelMaterialName.Size = New System.Drawing.Size(65, 12)
        Me.LabelMaterialName.TabIndex = 0
        Me.LabelMaterialName.Text = "节目名称："
        '
        'LabelStartTimeCode
        '
        Me.LabelStartTimeCode.AutoSize = True
        Me.LabelStartTimeCode.Location = New System.Drawing.Point(14, 73)
        Me.LabelStartTimeCode.Name = "LabelStartTimeCode"
        Me.LabelStartTimeCode.Size = New System.Drawing.Size(65, 12)
        Me.LabelStartTimeCode.TabIndex = 1
        Me.LabelStartTimeCode.Text = "起始时码："
        '
        'LabelLength
        '
        Me.LabelLength.AutoSize = True
        Me.LabelLength.Location = New System.Drawing.Point(14, 98)
        Me.LabelLength.Name = "LabelLength"
        Me.LabelLength.Size = New System.Drawing.Size(65, 12)
        Me.LabelLength.TabIndex = 2
        Me.LabelLength.Text = "节目长度："
        '
        'LableCheckPointHead
        '
        Me.LableCheckPointHead.AutoSize = True
        Me.LableCheckPointHead.Location = New System.Drawing.Point(11, 158)
        Me.LableCheckPointHead.Name = "LableCheckPointHead"
        Me.LableCheckPointHead.Size = New System.Drawing.Size(65, 12)
        Me.LableCheckPointHead.TabIndex = 3
        Me.LableCheckPointHead.Text = "片头时长："
        '
        'LableCheckPointMid
        '
        Me.LableCheckPointMid.AutoSize = True
        Me.LableCheckPointMid.Location = New System.Drawing.Point(13, 191)
        Me.LableCheckPointMid.Name = "LableCheckPointMid"
        Me.LableCheckPointMid.Size = New System.Drawing.Size(65, 12)
        Me.LableCheckPointMid.TabIndex = 4
        Me.LableCheckPointMid.Text = "片中时长："
        '
        'LableCheckPointTail
        '
        Me.LableCheckPointTail.AutoSize = True
        Me.LableCheckPointTail.Location = New System.Drawing.Point(10, 220)
        Me.LableCheckPointTail.Name = "LableCheckPointTail"
        Me.LableCheckPointTail.Size = New System.Drawing.Size(65, 12)
        Me.LableCheckPointTail.TabIndex = 5
        Me.LableCheckPointTail.Text = "片尾时长："
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(10, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(10, 167)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(235, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(10, 323)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(235, 158)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'ButtonScreenShotHead
        '
        Me.ButtonScreenShotHead.Location = New System.Drawing.Point(272, 31)
        Me.ButtonScreenShotHead.Name = "ButtonScreenShotHead"
        Me.ButtonScreenShotHead.Size = New System.Drawing.Size(72, 23)
        Me.ButtonScreenShotHead.TabIndex = 8
        Me.ButtonScreenShotHead.Text = "片头截图"
        Me.ButtonScreenShotHead.UseVisualStyleBackColor = True
        '
        'ButtonScreenShotMid
        '
        Me.ButtonScreenShotMid.Location = New System.Drawing.Point(272, 65)
        Me.ButtonScreenShotMid.Name = "ButtonScreenShotMid"
        Me.ButtonScreenShotMid.Size = New System.Drawing.Size(70, 23)
        Me.ButtonScreenShotMid.TabIndex = 8
        Me.ButtonScreenShotMid.Text = "片中截图"
        Me.ButtonScreenShotMid.UseVisualStyleBackColor = True
        '
        'ButtonScreenShotTail
        '
        Me.ButtonScreenShotTail.Location = New System.Drawing.Point(272, 101)
        Me.ButtonScreenShotTail.Name = "ButtonScreenShotTail"
        Me.ButtonScreenShotTail.Size = New System.Drawing.Size(72, 23)
        Me.ButtonScreenShotTail.TabIndex = 8
        Me.ButtonScreenShotTail.Text = "片尾截图"
        Me.ButtonScreenShotTail.UseVisualStyleBackColor = True
        '
        'LabelChecker
        '
        Me.LabelChecker.AutoSize = True
        Me.LabelChecker.Location = New System.Drawing.Point(270, 442)
        Me.LabelChecker.Name = "LabelChecker"
        Me.LabelChecker.Size = New System.Drawing.Size(65, 12)
        Me.LabelChecker.TabIndex = 9
        Me.LabelChecker.Text = "审核人员："
        '
        'ButtonStartCheck
        '
        Me.ButtonStartCheck.Location = New System.Drawing.Point(229, 215)
        Me.ButtonStartCheck.Name = "ButtonStartCheck"
        Me.ButtonStartCheck.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStartCheck.TabIndex = 10
        Me.ButtonStartCheck.Text = "开始审核"
        Me.ButtonStartCheck.UseVisualStyleBackColor = True
        '
        'ButtonFinishCheck
        '
        Me.ButtonFinishCheck.Location = New System.Drawing.Point(348, 487)
        Me.ButtonFinishCheck.Name = "ButtonFinishCheck"
        Me.ButtonFinishCheck.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFinishCheck.TabIndex = 10
        Me.ButtonFinishCheck.Text = "审核完成"
        Me.ButtonFinishCheck.UseVisualStyleBackColor = True
        '
        'TextBoxCheckPointHead
        '
        Me.TextBoxCheckPointHead.Location = New System.Drawing.Point(87, 152)
        Me.TextBoxCheckPointHead.Name = "TextBoxCheckPointHead"
        Me.TextBoxCheckPointHead.Size = New System.Drawing.Size(122, 21)
        Me.TextBoxCheckPointHead.TabIndex = 12
        '
        'TextBoxCheckPointMid
        '
        Me.TextBoxCheckPointMid.Location = New System.Drawing.Point(87, 183)
        Me.TextBoxCheckPointMid.Name = "TextBoxCheckPointMid"
        Me.TextBoxCheckPointMid.Size = New System.Drawing.Size(122, 21)
        Me.TextBoxCheckPointMid.TabIndex = 12
        '
        'TextBoxCheckPointTail
        '
        Me.TextBoxCheckPointTail.Location = New System.Drawing.Point(87, 214)
        Me.TextBoxCheckPointTail.Name = "TextBoxCheckPointTail"
        Me.TextBoxCheckPointTail.Size = New System.Drawing.Size(122, 21)
        Me.TextBoxCheckPointTail.TabIndex = 12
        '
        'TextBoxLength
        '
        Me.TextBoxLength.Location = New System.Drawing.Point(90, 97)
        Me.TextBoxLength.Name = "TextBoxLength"
        Me.TextBoxLength.Size = New System.Drawing.Size(122, 21)
        Me.TextBoxLength.TabIndex = 15
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Location = New System.Drawing.Point(272, 305)
        Me.TextBoxRemark.Multiline = True
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(136, 94)
        Me.TextBoxRemark.TabIndex = 20
        Me.TextBoxRemark.Text = "备注:"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(10, 487)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(235, 158)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'ButtonScreenShotDate
        '
        Me.ButtonScreenShotDate.Location = New System.Drawing.Point(272, 138)
        Me.ButtonScreenShotDate.Name = "ButtonScreenShotDate"
        Me.ButtonScreenShotDate.Size = New System.Drawing.Size(70, 23)
        Me.ButtonScreenShotDate.TabIndex = 8
        Me.ButtonScreenShotDate.Text = "落幅截图"
        Me.ButtonScreenShotDate.UseVisualStyleBackColor = True
        '
        'ButtonCancelCheck
        '
        Me.ButtonCancelCheck.Location = New System.Drawing.Point(267, 487)
        Me.ButtonCancelCheck.Name = "ButtonCancelCheck"
        Me.ButtonCancelCheck.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelCheck.TabIndex = 23
        Me.ButtonCancelCheck.Text = "取消审核"
        Me.ButtonCancelCheck.UseVisualStyleBackColor = True
        '
        'TextBoxStartTimeCode
        '
        Me.TextBoxStartTimeCode.Location = New System.Drawing.Point(90, 70)
        Me.TextBoxStartTimeCode.Name = "TextBoxStartTimeCode"
        Me.TextBoxStartTimeCode.Size = New System.Drawing.Size(122, 21)
        Me.TextBoxStartTimeCode.TabIndex = 24
        Me.TextBoxStartTimeCode.Text = "00:00:00:00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(143, 409)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 12)
        Me.Label9.TabIndex = 25
        '
        'TextBoxChecker
        '
        Me.TextBoxChecker.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxChecker.Location = New System.Drawing.Point(341, 438)
        Me.TextBoxChecker.Name = "TextBoxChecker"
        Me.TextBoxChecker.Size = New System.Drawing.Size(74, 21)
        Me.TextBoxChecker.TabIndex = 26
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'LabelPMaterialName
        '
        Me.LabelPMaterialName.Location = New System.Drawing.Point(90, 45)
        Me.LabelPMaterialName.Name = "LabelPMaterialName"
        Me.LabelPMaterialName.Size = New System.Drawing.Size(122, 21)
        Me.LabelPMaterialName.TabIndex = 28
        '
        'CheckBoxNameCheck
        '
        Me.CheckBoxNameCheck.AutoSize = True
        Me.CheckBoxNameCheck.Location = New System.Drawing.Point(217, 44)
        Me.CheckBoxNameCheck.Name = "CheckBoxNameCheck"
        Me.CheckBoxNameCheck.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxNameCheck.TabIndex = 6
        Me.CheckBoxNameCheck.Text = "核对节目名称"
        Me.CheckBoxNameCheck.UseVisualStyleBackColor = True
        '
        'CheckBoxLenCheck
        '
        Me.CheckBoxLenCheck.AutoSize = True
        Me.CheckBoxLenCheck.Location = New System.Drawing.Point(217, 98)
        Me.CheckBoxLenCheck.Name = "CheckBoxLenCheck"
        Me.CheckBoxLenCheck.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxLenCheck.TabIndex = 6
        Me.CheckBoxLenCheck.Text = "核对节目长度"
        Me.CheckBoxLenCheck.UseVisualStyleBackColor = True
        '
        'CheckBoxDateEpisodeCheck
        '
        Me.CheckBoxDateEpisodeCheck.AutoSize = True
        Me.CheckBoxDateEpisodeCheck.Location = New System.Drawing.Point(272, 213)
        Me.CheckBoxDateEpisodeCheck.Name = "CheckBoxDateEpisodeCheck"
        Me.CheckBoxDateEpisodeCheck.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxDateEpisodeCheck.TabIndex = 18
        Me.CheckBoxDateEpisodeCheck.Text = "核对日期集数"
        Me.CheckBoxDateEpisodeCheck.UseVisualStyleBackColor = True
        '
        'CheckBoxSoundPicSyncCheck
        '
        Me.CheckBoxSoundPicSyncCheck.AutoSize = True
        Me.CheckBoxSoundPicSyncCheck.Location = New System.Drawing.Point(272, 241)
        Me.CheckBoxSoundPicSyncCheck.Name = "CheckBoxSoundPicSyncCheck"
        Me.CheckBoxSoundPicSyncCheck.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxSoundPicSyncCheck.TabIndex = 19
        Me.CheckBoxSoundPicSyncCheck.Text = "核对声画同步"
        Me.CheckBoxSoundPicSyncCheck.UseVisualStyleBackColor = True
        '
        'CheckBoxVolumeCheck
        '
        Me.CheckBoxVolumeCheck.AutoSize = True
        Me.CheckBoxVolumeCheck.Location = New System.Drawing.Point(272, 269)
        Me.CheckBoxVolumeCheck.Name = "CheckBoxVolumeCheck"
        Me.CheckBoxVolumeCheck.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxVolumeCheck.TabIndex = 19
        Me.CheckBoxVolumeCheck.Text = "核对音量大小"
        Me.CheckBoxVolumeCheck.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonStartCheck)
        Me.GroupBox1.Controls.Add(Me.CheckBoxLenCheck)
        Me.GroupBox1.Controls.Add(Me.TextBoxCheckPointTail)
        Me.GroupBox1.Controls.Add(Me.CheckBoxNameCheck)
        Me.GroupBox1.Controls.Add(Me.TextBoxCheckPointMid)
        Me.GroupBox1.Controls.Add(Me.TextBoxCheckPointHead)
        Me.GroupBox1.Controls.Add(Me.LableCheckPointHead)
        Me.GroupBox1.Controls.Add(Me.LableCheckPointTail)
        Me.GroupBox1.Controls.Add(Me.LableCheckPointMid)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 258)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "审核参数"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxChecker)
        Me.GroupBox2.Controls.Add(Me.LabelChecker)
        Me.GroupBox2.Controls.Add(Me.TextBoxRemark)
        Me.GroupBox2.Controls.Add(Me.ButtonCancelCheck)
        Me.GroupBox2.Controls.Add(Me.ButtonScreenShotDate)
        Me.GroupBox2.Controls.Add(Me.ButtonFinishCheck)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.ButtonScreenShotTail)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBoxVolumeCheck)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSoundPicSyncCheck)
        Me.GroupBox2.Controls.Add(Me.ButtonScreenShotMid)
        Me.GroupBox2.Controls.Add(Me.CheckBoxDateEpisodeCheck)
        Me.GroupBox2.Controls.Add(Me.ButtonScreenShotHead)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 653)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "截图取证"
        '
        'Timer1
        '
        '
        'Check
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(777, 670)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LabelPMaterialName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxStartTimeCode)
        Me.Controls.Add(Me.TextBoxLength)
        Me.Controls.Add(Me.LabelLength)
        Me.Controls.Add(Me.LabelStartTimeCode)
        Me.Controls.Add(Me.LabelMaterialName)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Check"
        Me.Text = "审核"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelMaterialName As System.Windows.Forms.Label
    Friend WithEvents LabelStartTimeCode As System.Windows.Forms.Label
    Friend WithEvents LabelLength As System.Windows.Forms.Label
    Friend WithEvents LableCheckPointHead As System.Windows.Forms.Label
    Friend WithEvents LableCheckPointMid As System.Windows.Forms.Label
    Friend WithEvents LableCheckPointTail As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonScreenShotHead As System.Windows.Forms.Button
    Friend WithEvents ButtonScreenShotMid As System.Windows.Forms.Button
    Friend WithEvents ButtonScreenShotTail As System.Windows.Forms.Button
    Friend WithEvents LabelChecker As System.Windows.Forms.Label
    Friend WithEvents ButtonStartCheck As System.Windows.Forms.Button
    Friend WithEvents ButtonFinishCheck As System.Windows.Forms.Button
    Friend WithEvents TextBoxCheckPointHead As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCheckPointMid As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCheckPointTail As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLength As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRemark As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonScreenShotDate As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelCheck As System.Windows.Forms.Button
    Friend WithEvents TextBoxStartTimeCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxChecker As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelPMaterialName As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxNameCheck As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxLenCheck As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDateEpisodeCheck As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSoundPicSyncCheck As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxVolumeCheck As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
