<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TapeReceive
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
        Me.LabelStartTimeCode = New System.Windows.Forms.Label
        Me.LabelEndTimeCode = New System.Windows.Forms.Label
        Me.TextBoxTapeName = New System.Windows.Forms.TextBox
        Me.TextBoxStartTimeH = New System.Windows.Forms.TextBox
        Me.TextBoxSendPerson = New System.Windows.Forms.TextBox
        Me.TextBoxRecvPerson = New System.Windows.Forms.TextBox
        Me.LabelSendPerson = New System.Windows.Forms.Label
        Me.LabelRecvPerson = New System.Windows.Forms.Label
        Me.ButtonOK = New System.Windows.Forms.Button
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.CheckBoxTape = New System.Windows.Forms.CheckBox
        Me.LabelLength = New System.Windows.Forms.Label
        Me.TextBoxRemark = New System.Windows.Forms.TextBox
        Me.TextBoxStartTimeM = New System.Windows.Forms.TextBox
        Me.TextBoxStartTimeS = New System.Windows.Forms.TextBox
        Me.TextBoxStartTimeF = New System.Windows.Forms.TextBox
        Me.TextBoxEndTimeH = New System.Windows.Forms.TextBox
        Me.TextBoxEndTimeM = New System.Windows.Forms.TextBox
        Me.TextBoxEndTimeS = New System.Windows.Forms.TextBox
        Me.TextBoxEndTimeF = New System.Windows.Forms.TextBox
        Me.TextBoxLengthF = New System.Windows.Forms.TextBox
        Me.TextBoxLengthS = New System.Windows.Forms.TextBox
        Me.TextBoxLengthM = New System.Windows.Forms.TextBox
        Me.TextBoxLengthH = New System.Windows.Forms.TextBox
        Me.ComboBoxChannel = New System.Windows.Forms.ComboBox
        Me.LabelChannel = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.LabelProgramType = New System.Windows.Forms.Label
        Me.ComboBoxProgramType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxMediaType = New System.Windows.Forms.ComboBox
        Me.TextBoxRecvTime = New System.Windows.Forms.TextBox
        Me.LabelRecvTapeTime = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListBoxTapeName = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'LabelTapeName
        '
        Me.LabelTapeName.AutoSize = True
        Me.LabelTapeName.Location = New System.Drawing.Point(26, 23)
        Me.LabelTapeName.Name = "LabelTapeName"
        Me.LabelTapeName.Size = New System.Drawing.Size(53, 12)
        Me.LabelTapeName.TabIndex = 0
        Me.LabelTapeName.Text = "节目名称"
        '
        'LabelStartTimeCode
        '
        Me.LabelStartTimeCode.AutoSize = True
        Me.LabelStartTimeCode.Location = New System.Drawing.Point(24, 136)
        Me.LabelStartTimeCode.Name = "LabelStartTimeCode"
        Me.LabelStartTimeCode.Size = New System.Drawing.Size(53, 12)
        Me.LabelStartTimeCode.TabIndex = 8
        Me.LabelStartTimeCode.Text = "开始时码"
        '
        'LabelEndTimeCode
        '
        Me.LabelEndTimeCode.AutoSize = True
        Me.LabelEndTimeCode.Location = New System.Drawing.Point(23, 190)
        Me.LabelEndTimeCode.Name = "LabelEndTimeCode"
        Me.LabelEndTimeCode.Size = New System.Drawing.Size(53, 12)
        Me.LabelEndTimeCode.TabIndex = 19
        Me.LabelEndTimeCode.Text = "结束时码"
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Location = New System.Drawing.Point(88, 19)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(232, 21)
        Me.TextBoxTapeName.TabIndex = 1
        '
        'TextBoxStartTimeH
        '
        Me.TextBoxStartTimeH.Location = New System.Drawing.Point(89, 129)
        Me.TextBoxStartTimeH.MaxLength = 2
        Me.TextBoxStartTimeH.Name = "TextBoxStartTimeH"
        Me.TextBoxStartTimeH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeH.TabIndex = 9
        '
        'TextBoxSendPerson
        '
        Me.TextBoxSendPerson.Location = New System.Drawing.Point(86, 312)
        Me.TextBoxSendPerson.Name = "TextBoxSendPerson"
        Me.TextBoxSendPerson.Size = New System.Drawing.Size(76, 21)
        Me.TextBoxSendPerson.TabIndex = 29
        '
        'TextBoxRecvPerson
        '
        Me.TextBoxRecvPerson.Location = New System.Drawing.Point(244, 312)
        Me.TextBoxRecvPerson.Name = "TextBoxRecvPerson"
        Me.TextBoxRecvPerson.Size = New System.Drawing.Size(76, 21)
        Me.TextBoxRecvPerson.TabIndex = 31
        '
        'LabelSendPerson
        '
        Me.LabelSendPerson.AutoSize = True
        Me.LabelSendPerson.Location = New System.Drawing.Point(24, 316)
        Me.LabelSendPerson.Name = "LabelSendPerson"
        Me.LabelSendPerson.Size = New System.Drawing.Size(53, 12)
        Me.LabelSendPerson.TabIndex = 28
        Me.LabelSendPerson.Text = "送带人员"
        '
        'LabelRecvPerson
        '
        Me.LabelRecvPerson.AutoSize = True
        Me.LabelRecvPerson.Location = New System.Drawing.Point(185, 318)
        Me.LabelRecvPerson.Name = "LabelRecvPerson"
        Me.LabelRecvPerson.Size = New System.Drawing.Size(53, 12)
        Me.LabelRecvPerson.TabIndex = 30
        Me.LabelRecvPerson.Text = "收带人员"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(168, 349)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 32
        Me.ButtonOK.Text = "确认收带"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(259, 349)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 33
        Me.ButtonCancel.Text = "取消"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'CheckBoxTape
        '
        Me.CheckBoxTape.AutoSize = True
        Me.CheckBoxTape.Location = New System.Drawing.Point(26, 257)
        Me.CheckBoxTape.Name = "CheckBoxTape"
        Me.CheckBoxTape.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxTape.TabIndex = 26
        Me.CheckBoxTape.Text = "带芯带盒一致"
        Me.CheckBoxTape.UseVisualStyleBackColor = True
        '
        'LabelLength
        '
        Me.LabelLength.AutoSize = True
        Me.LabelLength.Location = New System.Drawing.Point(24, 162)
        Me.LabelLength.Name = "LabelLength"
        Me.LabelLength.Size = New System.Drawing.Size(53, 12)
        Me.LabelLength.TabIndex = 13
        Me.LabelLength.Text = "节目时长"
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Location = New System.Drawing.Point(142, 255)
        Me.TextBoxRemark.Multiline = True
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(178, 44)
        Me.TextBoxRemark.TabIndex = 27
        Me.TextBoxRemark.Text = "备注:"
        '
        'TextBoxStartTimeM
        '
        Me.TextBoxStartTimeM.Location = New System.Drawing.Point(116, 129)
        Me.TextBoxStartTimeM.MaxLength = 2
        Me.TextBoxStartTimeM.Name = "TextBoxStartTimeM"
        Me.TextBoxStartTimeM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeM.TabIndex = 10
        '
        'TextBoxStartTimeS
        '
        Me.TextBoxStartTimeS.Location = New System.Drawing.Point(143, 129)
        Me.TextBoxStartTimeS.MaxLength = 2
        Me.TextBoxStartTimeS.Name = "TextBoxStartTimeS"
        Me.TextBoxStartTimeS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeS.TabIndex = 11
        '
        'TextBoxStartTimeF
        '
        Me.TextBoxStartTimeF.Location = New System.Drawing.Point(170, 129)
        Me.TextBoxStartTimeF.MaxLength = 2
        Me.TextBoxStartTimeF.Name = "TextBoxStartTimeF"
        Me.TextBoxStartTimeF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeF.TabIndex = 12
        '
        'TextBoxEndTimeH
        '
        Me.TextBoxEndTimeH.Location = New System.Drawing.Point(89, 183)
        Me.TextBoxEndTimeH.MaxLength = 20
        Me.TextBoxEndTimeH.Name = "TextBoxEndTimeH"
        Me.TextBoxEndTimeH.ReadOnly = True
        Me.TextBoxEndTimeH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeH.TabIndex = 20
        Me.TextBoxEndTimeH.TabStop = False
        '
        'TextBoxEndTimeM
        '
        Me.TextBoxEndTimeM.Location = New System.Drawing.Point(115, 183)
        Me.TextBoxEndTimeM.MaxLength = 20
        Me.TextBoxEndTimeM.Name = "TextBoxEndTimeM"
        Me.TextBoxEndTimeM.ReadOnly = True
        Me.TextBoxEndTimeM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeM.TabIndex = 21
        Me.TextBoxEndTimeM.TabStop = False
        '
        'TextBoxEndTimeS
        '
        Me.TextBoxEndTimeS.Location = New System.Drawing.Point(142, 183)
        Me.TextBoxEndTimeS.MaxLength = 20
        Me.TextBoxEndTimeS.Name = "TextBoxEndTimeS"
        Me.TextBoxEndTimeS.ReadOnly = True
        Me.TextBoxEndTimeS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeS.TabIndex = 22
        Me.TextBoxEndTimeS.TabStop = False
        '
        'TextBoxEndTimeF
        '
        Me.TextBoxEndTimeF.Location = New System.Drawing.Point(169, 183)
        Me.TextBoxEndTimeF.MaxLength = 20
        Me.TextBoxEndTimeF.Name = "TextBoxEndTimeF"
        Me.TextBoxEndTimeF.ReadOnly = True
        Me.TextBoxEndTimeF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeF.TabIndex = 23
        Me.TextBoxEndTimeF.TabStop = False
        '
        'TextBoxLengthF
        '
        Me.TextBoxLengthF.Location = New System.Drawing.Point(169, 156)
        Me.TextBoxLengthF.MaxLength = 2
        Me.TextBoxLengthF.Name = "TextBoxLengthF"
        Me.TextBoxLengthF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthF.TabIndex = 17
        '
        'TextBoxLengthS
        '
        Me.TextBoxLengthS.Location = New System.Drawing.Point(142, 156)
        Me.TextBoxLengthS.MaxLength = 2
        Me.TextBoxLengthS.Name = "TextBoxLengthS"
        Me.TextBoxLengthS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthS.TabIndex = 16
        '
        'TextBoxLengthM
        '
        Me.TextBoxLengthM.Location = New System.Drawing.Point(115, 156)
        Me.TextBoxLengthM.MaxLength = 2
        Me.TextBoxLengthM.Name = "TextBoxLengthM"
        Me.TextBoxLengthM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthM.TabIndex = 15
        '
        'TextBoxLengthH
        '
        Me.TextBoxLengthH.Location = New System.Drawing.Point(89, 156)
        Me.TextBoxLengthH.MaxLength = 2
        Me.TextBoxLengthH.Name = "TextBoxLengthH"
        Me.TextBoxLengthH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthH.TabIndex = 14
        '
        'ComboBoxChannel
        '
        Me.ComboBoxChannel.FormattingEnabled = True
        Me.ComboBoxChannel.Items.AddRange(New Object() {"新闻综合", "都市生活", "影视娱乐", "南宁公共"})
        Me.ComboBoxChannel.Location = New System.Drawing.Point(88, 73)
        Me.ComboBoxChannel.Name = "ComboBoxChannel"
        Me.ComboBoxChannel.Size = New System.Drawing.Size(232, 20)
        Me.ComboBoxChannel.TabIndex = 5
        '
        'LabelChannel
        '
        Me.LabelChannel.AutoSize = True
        Me.LabelChannel.Location = New System.Drawing.Point(26, 77)
        Me.LabelChannel.Name = "LabelChannel"
        Me.LabelChannel.Size = New System.Drawing.Size(53, 12)
        Me.LabelChannel.TabIndex = 4
        Me.LabelChannel.Text = "所属频道"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'LabelProgramType
        '
        Me.LabelProgramType.AutoSize = True
        Me.LabelProgramType.Location = New System.Drawing.Point(26, 50)
        Me.LabelProgramType.Name = "LabelProgramType"
        Me.LabelProgramType.Size = New System.Drawing.Size(53, 12)
        Me.LabelProgramType.TabIndex = 2
        Me.LabelProgramType.Text = "节目类型"
        '
        'ComboBoxProgramType
        '
        Me.ComboBoxProgramType.FormattingEnabled = True
        Me.ComboBoxProgramType.Items.AddRange(New Object() {"日用广告", "新闻", "专题", "宣传片", "电视剧", "现场直播", "节目预告", "电影", "综艺节目", "电视购物", "探索", "歌曲", "青少", "法制", "生活服务", "广告包", "其他"})
        Me.ComboBoxProgramType.Location = New System.Drawing.Point(88, 47)
        Me.ComboBoxProgramType.Name = "ComboBoxProgramType"
        Me.ComboBoxProgramType.Size = New System.Drawing.Size(232, 20)
        Me.ComboBoxProgramType.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "媒介类型"
        '
        'ComboBoxMediaType
        '
        Me.ComboBoxMediaType.FormattingEnabled = True
        Me.ComboBoxMediaType.Items.AddRange(New Object() {"磁带", "蓝光", "DVD", "非编", "媒资"})
        Me.ComboBoxMediaType.Location = New System.Drawing.Point(87, 99)
        Me.ComboBoxMediaType.Name = "ComboBoxMediaType"
        Me.ComboBoxMediaType.Size = New System.Drawing.Size(233, 20)
        Me.ComboBoxMediaType.TabIndex = 7
        '
        'TextBoxRecvTime
        '
        Me.TextBoxRecvTime.Location = New System.Drawing.Point(87, 219)
        Me.TextBoxRecvTime.Name = "TextBoxRecvTime"
        Me.TextBoxRecvTime.ReadOnly = True
        Me.TextBoxRecvTime.Size = New System.Drawing.Size(156, 21)
        Me.TextBoxRecvTime.TabIndex = 25
        Me.TextBoxRecvTime.TabStop = False
        '
        'LabelRecvTapeTime
        '
        Me.LabelRecvTapeTime.AutoSize = True
        Me.LabelRecvTapeTime.Location = New System.Drawing.Point(23, 222)
        Me.LabelRecvTapeTime.Name = "LabelRecvTapeTime"
        Me.LabelRecvTapeTime.Size = New System.Drawing.Size(53, 12)
        Me.LabelRecvTapeTime.TabIndex = 24
        Me.LabelRecvTapeTime.Text = "送带时间"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 12)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "(* 这里是节目时长）"
        '
        'ListBoxTapeName
        '
        Me.ListBoxTapeName.FormattingEnabled = True
        Me.ListBoxTapeName.ItemHeight = 12
        Me.ListBoxTapeName.Location = New System.Drawing.Point(89, 40)
        Me.ListBoxTapeName.Name = "ListBoxTapeName"
        Me.ListBoxTapeName.Size = New System.Drawing.Size(231, 16)
        Me.ListBoxTapeName.TabIndex = 34
        Me.ListBoxTapeName.Visible = False
        '
        'TapeReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 384)
        Me.Controls.Add(Me.ListBoxTapeName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxRecvTime)
        Me.Controls.Add(Me.LabelRecvTapeTime)
        Me.Controls.Add(Me.Label1)
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
        Me.Controls.Add(Me.TextBoxRemark)
        Me.Controls.Add(Me.CheckBoxTape)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.LabelRecvPerson)
        Me.Controls.Add(Me.LabelSendPerson)
        Me.Controls.Add(Me.TextBoxRecvPerson)
        Me.Controls.Add(Me.TextBoxSendPerson)
        Me.Controls.Add(Me.TextBoxStartTimeH)
        Me.Controls.Add(Me.TextBoxTapeName)
        Me.Controls.Add(Me.LabelLength)
        Me.Controls.Add(Me.LabelEndTimeCode)
        Me.Controls.Add(Me.LabelStartTimeCode)
        Me.Controls.Add(Me.LabelTapeName)
        Me.MinimumSize = New System.Drawing.Size(354, 418)
        Me.Name = "TapeReceive"
        Me.Text = "送带"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTapeName As System.Windows.Forms.Label
    Friend WithEvents LabelStartTimeCode As System.Windows.Forms.Label
    Friend WithEvents LabelEndTimeCode As System.Windows.Forms.Label
    Friend WithEvents TextBoxTapeName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStartTimeH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSendPerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRecvPerson As System.Windows.Forms.TextBox
    Friend WithEvents LabelSendPerson As System.Windows.Forms.Label
    Friend WithEvents LabelRecvPerson As System.Windows.Forms.Label
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents CheckBoxTape As System.Windows.Forms.CheckBox
    Friend WithEvents LabelLength As System.Windows.Forms.Label
    Friend WithEvents TextBoxRemark As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStartTimeM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStartTimeS As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStartTimeF As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndTimeH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndTimeM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndTimeS As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndTimeF As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLengthF As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLengthS As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLengthM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLengthH As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxChannel As System.Windows.Forms.ComboBox
    Friend WithEvents LabelChannel As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelProgramType As System.Windows.Forms.Label
    Friend WithEvents ComboBoxProgramType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMediaType As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxRecvTime As System.Windows.Forms.TextBox
    Friend WithEvents LabelRecvTapeTime As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBoxTapeName As System.Windows.Forms.ListBox
End Class
