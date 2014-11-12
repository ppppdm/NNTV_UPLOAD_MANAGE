<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 重写 Dispose，以清理组件列表。
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
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.SuspendLayout()
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(240, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(34, 23)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "x"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(77, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 21)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "节目名称"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "媒介类型"
        '
        'ComboBoxMediaType
        '
        Me.ComboBoxMediaType.FormattingEnabled = True
        Me.ComboBoxMediaType.Items.AddRange(New Object() {"磁带", "蓝光", "DVD", "非编", "媒资"})
        Me.ComboBoxMediaType.Location = New System.Drawing.Point(74, 109)
        Me.ComboBoxMediaType.Name = "ComboBoxMediaType"
        Me.ComboBoxMediaType.Size = New System.Drawing.Size(164, 20)
        Me.ComboBoxMediaType.TabIndex = 40
        '
        'ComboBoxProgramType
        '
        Me.ComboBoxProgramType.FormattingEnabled = True
        Me.ComboBoxProgramType.Items.AddRange(New Object() {"日用广告", "新闻", "专题", "宣传片", "电视剧", "现场直播", "节目预告", "电影", "综艺节目", "电视购物", "探索", "歌曲", "青少", "法制", "生活服务", "广告包", "其他"})
        Me.ComboBoxProgramType.Location = New System.Drawing.Point(75, 57)
        Me.ComboBoxProgramType.Name = "ComboBoxProgramType"
        Me.ComboBoxProgramType.Size = New System.Drawing.Size(163, 20)
        Me.ComboBoxProgramType.TabIndex = 36
        '
        'LabelProgramType
        '
        Me.LabelProgramType.AutoSize = True
        Me.LabelProgramType.Location = New System.Drawing.Point(13, 60)
        Me.LabelProgramType.Name = "LabelProgramType"
        Me.LabelProgramType.Size = New System.Drawing.Size(53, 12)
        Me.LabelProgramType.TabIndex = 35
        Me.LabelProgramType.Text = "节目类型"
        '
        'LabelChannel
        '
        Me.LabelChannel.AutoSize = True
        Me.LabelChannel.Location = New System.Drawing.Point(13, 87)
        Me.LabelChannel.Name = "LabelChannel"
        Me.LabelChannel.Size = New System.Drawing.Size(53, 12)
        Me.LabelChannel.TabIndex = 37
        Me.LabelChannel.Text = "所属频道"
        '
        'ComboBoxChannel
        '
        Me.ComboBoxChannel.FormattingEnabled = True
        Me.ComboBoxChannel.Items.AddRange(New Object() {"新闻综合", "都市生活", "影视娱乐", "南宁公共"})
        Me.ComboBoxChannel.Location = New System.Drawing.Point(75, 83)
        Me.ComboBoxChannel.Name = "ComboBoxChannel"
        Me.ComboBoxChannel.Size = New System.Drawing.Size(163, 20)
        Me.ComboBoxChannel.TabIndex = 38
        '
        'TextBoxLengthF
        '
        Me.TextBoxLengthF.Location = New System.Drawing.Point(156, 166)
        Me.TextBoxLengthF.MaxLength = 2
        Me.TextBoxLengthF.Name = "TextBoxLengthF"
        Me.TextBoxLengthF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthF.TabIndex = 50
        '
        'TextBoxLengthS
        '
        Me.TextBoxLengthS.Location = New System.Drawing.Point(129, 166)
        Me.TextBoxLengthS.MaxLength = 2
        Me.TextBoxLengthS.Name = "TextBoxLengthS"
        Me.TextBoxLengthS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthS.TabIndex = 49
        '
        'TextBoxLengthM
        '
        Me.TextBoxLengthM.Location = New System.Drawing.Point(102, 166)
        Me.TextBoxLengthM.MaxLength = 2
        Me.TextBoxLengthM.Name = "TextBoxLengthM"
        Me.TextBoxLengthM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthM.TabIndex = 48
        '
        'TextBoxLengthH
        '
        Me.TextBoxLengthH.Location = New System.Drawing.Point(76, 166)
        Me.TextBoxLengthH.MaxLength = 2
        Me.TextBoxLengthH.Name = "TextBoxLengthH"
        Me.TextBoxLengthH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthH.TabIndex = 47
        '
        'TextBoxEndTimeF
        '
        Me.TextBoxEndTimeF.Location = New System.Drawing.Point(156, 193)
        Me.TextBoxEndTimeF.MaxLength = 20
        Me.TextBoxEndTimeF.Name = "TextBoxEndTimeF"
        Me.TextBoxEndTimeF.ReadOnly = True
        Me.TextBoxEndTimeF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeF.TabIndex = 56
        Me.TextBoxEndTimeF.TabStop = False
        '
        'TextBoxEndTimeS
        '
        Me.TextBoxEndTimeS.Location = New System.Drawing.Point(129, 193)
        Me.TextBoxEndTimeS.MaxLength = 20
        Me.TextBoxEndTimeS.Name = "TextBoxEndTimeS"
        Me.TextBoxEndTimeS.ReadOnly = True
        Me.TextBoxEndTimeS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeS.TabIndex = 55
        Me.TextBoxEndTimeS.TabStop = False
        '
        'TextBoxEndTimeM
        '
        Me.TextBoxEndTimeM.Location = New System.Drawing.Point(102, 193)
        Me.TextBoxEndTimeM.MaxLength = 20
        Me.TextBoxEndTimeM.Name = "TextBoxEndTimeM"
        Me.TextBoxEndTimeM.ReadOnly = True
        Me.TextBoxEndTimeM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeM.TabIndex = 54
        Me.TextBoxEndTimeM.TabStop = False
        '
        'TextBoxEndTimeH
        '
        Me.TextBoxEndTimeH.Location = New System.Drawing.Point(76, 193)
        Me.TextBoxEndTimeH.MaxLength = 20
        Me.TextBoxEndTimeH.Name = "TextBoxEndTimeH"
        Me.TextBoxEndTimeH.ReadOnly = True
        Me.TextBoxEndTimeH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeH.TabIndex = 53
        Me.TextBoxEndTimeH.TabStop = False
        '
        'TextBoxStartTimeF
        '
        Me.TextBoxStartTimeF.Location = New System.Drawing.Point(157, 139)
        Me.TextBoxStartTimeF.MaxLength = 2
        Me.TextBoxStartTimeF.Name = "TextBoxStartTimeF"
        Me.TextBoxStartTimeF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeF.TabIndex = 45
        '
        'TextBoxStartTimeS
        '
        Me.TextBoxStartTimeS.Location = New System.Drawing.Point(130, 139)
        Me.TextBoxStartTimeS.MaxLength = 2
        Me.TextBoxStartTimeS.Name = "TextBoxStartTimeS"
        Me.TextBoxStartTimeS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeS.TabIndex = 44
        '
        'TextBoxStartTimeM
        '
        Me.TextBoxStartTimeM.Location = New System.Drawing.Point(103, 139)
        Me.TextBoxStartTimeM.MaxLength = 2
        Me.TextBoxStartTimeM.Name = "TextBoxStartTimeM"
        Me.TextBoxStartTimeM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeM.TabIndex = 43
        '
        'TextBoxStartTimeH
        '
        Me.TextBoxStartTimeH.Location = New System.Drawing.Point(76, 139)
        Me.TextBoxStartTimeH.MaxLength = 2
        Me.TextBoxStartTimeH.Name = "TextBoxStartTimeH"
        Me.TextBoxStartTimeH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeH.TabIndex = 42
        '
        'LabelLength
        '
        Me.LabelLength.AutoSize = True
        Me.LabelLength.Location = New System.Drawing.Point(11, 172)
        Me.LabelLength.Name = "LabelLength"
        Me.LabelLength.Size = New System.Drawing.Size(53, 12)
        Me.LabelLength.TabIndex = 46
        Me.LabelLength.Text = "节目时长"
        '
        'LabelEndTimeCode
        '
        Me.LabelEndTimeCode.AutoSize = True
        Me.LabelEndTimeCode.Location = New System.Drawing.Point(10, 200)
        Me.LabelEndTimeCode.Name = "LabelEndTimeCode"
        Me.LabelEndTimeCode.Size = New System.Drawing.Size(53, 12)
        Me.LabelEndTimeCode.TabIndex = 52
        Me.LabelEndTimeCode.Text = "结束时码"
        '
        'LabelStartTimeCode
        '
        Me.LabelStartTimeCode.AutoSize = True
        Me.LabelStartTimeCode.Location = New System.Drawing.Point(11, 146)
        Me.LabelStartTimeCode.Name = "LabelStartTimeCode"
        Me.LabelStartTimeCode.Size = New System.Drawing.Size(53, 12)
        Me.LabelStartTimeCode.TabIndex = 41
        Me.LabelStartTimeCode.Text = "开始时码"
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(274, 230)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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

End Class
