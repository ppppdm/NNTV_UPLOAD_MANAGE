<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TapeRecTapeAttribute
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBoxMediaType = New System.Windows.Forms.ComboBox
        Me.ComboBoxProgramType = New System.Windows.Forms.ComboBox
        Me.LabelProgramType = New System.Windows.Forms.Label
        Me.LabelChannel = New System.Windows.Forms.Label
        Me.ComboBoxChannel = New System.Windows.Forms.ComboBox
        Me.TextBoxLengthF = New System.Windows.Forms.TextBox
        Me.TextBoxLengthS = New System.Windows.Forms.TextBox
        Me.TextBoxLengthM = New System.Windows.Forms.TextBox
        Me.TextBoxLengthH = New System.Windows.Forms.TextBox
        Me.TextBoxEndTimeF = New System.Windows.Forms.TextBox
        Me.TextBoxEndTimeS = New System.Windows.Forms.TextBox
        Me.TextBoxEndTimeM = New System.Windows.Forms.TextBox
        Me.TextBoxEndTimeH = New System.Windows.Forms.TextBox
        Me.TextBoxStartTimeF = New System.Windows.Forms.TextBox
        Me.TextBoxStartTimeS = New System.Windows.Forms.TextBox
        Me.TextBoxStartTimeM = New System.Windows.Forms.TextBox
        Me.TextBoxStartTimeH = New System.Windows.Forms.TextBox
        Me.LabelLength = New System.Windows.Forms.Label
        Me.LabelEndTimeCode = New System.Windows.Forms.Label
        Me.LabelStartTimeCode = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxTapeName = New System.Windows.Forms.TextBox
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "媒介类型"
        '
        'ComboBoxMediaType
        '
        Me.ComboBoxMediaType.FormattingEnabled = True
        Me.ComboBoxMediaType.Items.AddRange(New Object() {"磁带", "蓝光", "DVD", "非编", "媒资"})
        Me.ComboBoxMediaType.Location = New System.Drawing.Point(63, 86)
        Me.ComboBoxMediaType.Name = "ComboBoxMediaType"
        Me.ComboBoxMediaType.Size = New System.Drawing.Size(164, 20)
        Me.ComboBoxMediaType.TabIndex = 65
        '
        'ComboBoxProgramType
        '
        Me.ComboBoxProgramType.FormattingEnabled = True
        Me.ComboBoxProgramType.Items.AddRange(New Object() {"日用广告", "新闻", "专题", "宣传片", "电视剧", "现场直播", "节目预告", "电影", "综艺节目", "电视购物", "探索", "歌曲", "青少", "法制", "生活服务", "广告包", "其他"})
        Me.ComboBoxProgramType.Location = New System.Drawing.Point(64, 34)
        Me.ComboBoxProgramType.Name = "ComboBoxProgramType"
        Me.ComboBoxProgramType.Size = New System.Drawing.Size(163, 20)
        Me.ComboBoxProgramType.TabIndex = 61
        '
        'LabelProgramType
        '
        Me.LabelProgramType.AutoSize = True
        Me.LabelProgramType.Location = New System.Drawing.Point(2, 37)
        Me.LabelProgramType.Name = "LabelProgramType"
        Me.LabelProgramType.Size = New System.Drawing.Size(53, 12)
        Me.LabelProgramType.TabIndex = 60
        Me.LabelProgramType.Text = "节目类型"
        '
        'LabelChannel
        '
        Me.LabelChannel.AutoSize = True
        Me.LabelChannel.Location = New System.Drawing.Point(2, 64)
        Me.LabelChannel.Name = "LabelChannel"
        Me.LabelChannel.Size = New System.Drawing.Size(53, 12)
        Me.LabelChannel.TabIndex = 62
        Me.LabelChannel.Text = "所属频道"
        '
        'ComboBoxChannel
        '
        Me.ComboBoxChannel.FormattingEnabled = True
        Me.ComboBoxChannel.Items.AddRange(New Object() {"新闻综合", "都市生活", "影视娱乐", "南宁公共"})
        Me.ComboBoxChannel.Location = New System.Drawing.Point(64, 60)
        Me.ComboBoxChannel.Name = "ComboBoxChannel"
        Me.ComboBoxChannel.Size = New System.Drawing.Size(163, 20)
        Me.ComboBoxChannel.TabIndex = 63
        '
        'TextBoxLengthF
        '
        Me.TextBoxLengthF.Location = New System.Drawing.Point(148, 143)
        Me.TextBoxLengthF.MaxLength = 2
        Me.TextBoxLengthF.Name = "TextBoxLengthF"
        Me.TextBoxLengthF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthF.TabIndex = 75
        '
        'TextBoxLengthS
        '
        Me.TextBoxLengthS.Location = New System.Drawing.Point(121, 143)
        Me.TextBoxLengthS.MaxLength = 2
        Me.TextBoxLengthS.Name = "TextBoxLengthS"
        Me.TextBoxLengthS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthS.TabIndex = 74
        '
        'TextBoxLengthM
        '
        Me.TextBoxLengthM.Location = New System.Drawing.Point(94, 143)
        Me.TextBoxLengthM.MaxLength = 2
        Me.TextBoxLengthM.Name = "TextBoxLengthM"
        Me.TextBoxLengthM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthM.TabIndex = 73
        '
        'TextBoxLengthH
        '
        Me.TextBoxLengthH.Location = New System.Drawing.Point(68, 143)
        Me.TextBoxLengthH.MaxLength = 2
        Me.TextBoxLengthH.Name = "TextBoxLengthH"
        Me.TextBoxLengthH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthH.TabIndex = 72
        '
        'TextBoxEndTimeF
        '
        Me.TextBoxEndTimeF.Location = New System.Drawing.Point(148, 170)
        Me.TextBoxEndTimeF.MaxLength = 20
        Me.TextBoxEndTimeF.Name = "TextBoxEndTimeF"
        Me.TextBoxEndTimeF.ReadOnly = True
        Me.TextBoxEndTimeF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeF.TabIndex = 80
        Me.TextBoxEndTimeF.TabStop = False
        '
        'TextBoxEndTimeS
        '
        Me.TextBoxEndTimeS.Location = New System.Drawing.Point(121, 170)
        Me.TextBoxEndTimeS.MaxLength = 20
        Me.TextBoxEndTimeS.Name = "TextBoxEndTimeS"
        Me.TextBoxEndTimeS.ReadOnly = True
        Me.TextBoxEndTimeS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeS.TabIndex = 79
        Me.TextBoxEndTimeS.TabStop = False
        '
        'TextBoxEndTimeM
        '
        Me.TextBoxEndTimeM.Location = New System.Drawing.Point(94, 170)
        Me.TextBoxEndTimeM.MaxLength = 20
        Me.TextBoxEndTimeM.Name = "TextBoxEndTimeM"
        Me.TextBoxEndTimeM.ReadOnly = True
        Me.TextBoxEndTimeM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeM.TabIndex = 78
        Me.TextBoxEndTimeM.TabStop = False
        '
        'TextBoxEndTimeH
        '
        Me.TextBoxEndTimeH.Location = New System.Drawing.Point(68, 170)
        Me.TextBoxEndTimeH.MaxLength = 20
        Me.TextBoxEndTimeH.Name = "TextBoxEndTimeH"
        Me.TextBoxEndTimeH.ReadOnly = True
        Me.TextBoxEndTimeH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeH.TabIndex = 77
        Me.TextBoxEndTimeH.TabStop = False
        '
        'TextBoxStartTimeF
        '
        Me.TextBoxStartTimeF.Location = New System.Drawing.Point(149, 116)
        Me.TextBoxStartTimeF.MaxLength = 2
        Me.TextBoxStartTimeF.Name = "TextBoxStartTimeF"
        Me.TextBoxStartTimeF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeF.TabIndex = 70
        '
        'TextBoxStartTimeS
        '
        Me.TextBoxStartTimeS.Location = New System.Drawing.Point(122, 116)
        Me.TextBoxStartTimeS.MaxLength = 2
        Me.TextBoxStartTimeS.Name = "TextBoxStartTimeS"
        Me.TextBoxStartTimeS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeS.TabIndex = 69
        '
        'TextBoxStartTimeM
        '
        Me.TextBoxStartTimeM.Location = New System.Drawing.Point(95, 116)
        Me.TextBoxStartTimeM.MaxLength = 2
        Me.TextBoxStartTimeM.Name = "TextBoxStartTimeM"
        Me.TextBoxStartTimeM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeM.TabIndex = 68
        '
        'TextBoxStartTimeH
        '
        Me.TextBoxStartTimeH.Location = New System.Drawing.Point(68, 116)
        Me.TextBoxStartTimeH.MaxLength = 2
        Me.TextBoxStartTimeH.Name = "TextBoxStartTimeH"
        Me.TextBoxStartTimeH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeH.TabIndex = 67
        '
        'LabelLength
        '
        Me.LabelLength.AutoSize = True
        Me.LabelLength.Location = New System.Drawing.Point(3, 149)
        Me.LabelLength.Name = "LabelLength"
        Me.LabelLength.Size = New System.Drawing.Size(53, 12)
        Me.LabelLength.TabIndex = 71
        Me.LabelLength.Text = "节目时长"
        '
        'LabelEndTimeCode
        '
        Me.LabelEndTimeCode.AutoSize = True
        Me.LabelEndTimeCode.Location = New System.Drawing.Point(2, 177)
        Me.LabelEndTimeCode.Name = "LabelEndTimeCode"
        Me.LabelEndTimeCode.Size = New System.Drawing.Size(53, 12)
        Me.LabelEndTimeCode.TabIndex = 76
        Me.LabelEndTimeCode.Text = "结束时码"
        '
        'LabelStartTimeCode
        '
        Me.LabelStartTimeCode.AutoSize = True
        Me.LabelStartTimeCode.Location = New System.Drawing.Point(3, 123)
        Me.LabelStartTimeCode.Name = "LabelStartTimeCode"
        Me.LabelStartTimeCode.Size = New System.Drawing.Size(53, 12)
        Me.LabelStartTimeCode.TabIndex = 66
        Me.LabelStartTimeCode.Text = "开始时码"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "节目名称"
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Location = New System.Drawing.Point(66, 5)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(161, 21)
        Me.TextBoxTapeName.TabIndex = 58
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.BackgroundImage = Global.UploadProcessSupervision.My.Resources.Resources.mini_red_close
        Me.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Location = New System.Drawing.Point(227, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(20, 20)
        Me.ButtonClose.TabIndex = 57
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'TapeRecTapeAttribute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxMediaType)
        Me.Controls.Add(Me.ComboBoxProgramType)
        Me.Controls.Add(Me.LabelProgramType)
        Me.Controls.Add(Me.LabelChannel)
        Me.Controls.Add(Me.ComboBoxChannel)
        Me.Controls.Add(Me.TextBoxLengthF)
        Me.Controls.Add(Me.TextBoxLengthS)
        Me.Controls.Add(Me.TextBoxLengthM)
        Me.Controls.Add(Me.TextBoxLengthH)
        Me.Controls.Add(Me.TextBoxEndTimeF)
        Me.Controls.Add(Me.TextBoxEndTimeS)
        Me.Controls.Add(Me.TextBoxEndTimeM)
        Me.Controls.Add(Me.TextBoxEndTimeH)
        Me.Controls.Add(Me.TextBoxStartTimeF)
        Me.Controls.Add(Me.TextBoxStartTimeS)
        Me.Controls.Add(Me.TextBoxStartTimeM)
        Me.Controls.Add(Me.TextBoxStartTimeH)
        Me.Controls.Add(Me.LabelLength)
        Me.Controls.Add(Me.LabelEndTimeCode)
        Me.Controls.Add(Me.LabelStartTimeCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxTapeName)
        Me.Controls.Add(Me.ButtonClose)
        Me.Name = "TapeRecTapeAttribute"
        Me.Size = New System.Drawing.Size(246, 196)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMediaType As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxProgramType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelProgramType As System.Windows.Forms.Label
    Friend WithEvents LabelChannel As System.Windows.Forms.Label
    Friend WithEvents ComboBoxChannel As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxLengthF As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLengthS As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLengthM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLengthH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndTimeF As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndTimeS As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndTimeM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndTimeH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStartTimeF As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStartTimeS As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStartTimeM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStartTimeH As System.Windows.Forms.TextBox
    Friend WithEvents LabelLength As System.Windows.Forms.Label
    Friend WithEvents LabelEndTimeCode As System.Windows.Forms.Label
    Friend WithEvents LabelStartTimeCode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTapeName As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button

End Class
