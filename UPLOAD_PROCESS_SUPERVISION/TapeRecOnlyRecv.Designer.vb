<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TapeRecOnlyRecv
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxRecvTime = New System.Windows.Forms.TextBox
        Me.LabelRecvTapeTime = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.TextBoxRemark = New System.Windows.Forms.TextBox
        Me.CheckBoxTape = New System.Windows.Forms.CheckBox
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.ButtonOK = New System.Windows.Forms.Button
        Me.LabelRecvPerson = New System.Windows.Forms.Label
        Me.LabelSendPerson = New System.Windows.Forms.Label
        Me.TextBoxRecvPerson = New System.Windows.Forms.TextBox
        Me.TextBoxSendPerson = New System.Windows.Forms.TextBox
        Me.TextBoxStartTimeH = New System.Windows.Forms.TextBox
        Me.TextBoxTapeName = New System.Windows.Forms.TextBox
        Me.LabelLength = New System.Windows.Forms.Label
        Me.LabelEndTimeCode = New System.Windows.Forms.Label
        Me.LabelStartTimeCode = New System.Windows.Forms.Label
        Me.LabelTapeName = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 12)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "(* 这里是节目时长）"
        '
        'TextBoxRecvTime
        '
        Me.TextBoxRecvTime.Location = New System.Drawing.Point(78, 213)
        Me.TextBoxRecvTime.Name = "TextBoxRecvTime"
        Me.TextBoxRecvTime.ReadOnly = True
        Me.TextBoxRecvTime.Size = New System.Drawing.Size(156, 21)
        Me.TextBoxRecvTime.TabIndex = 59
        Me.TextBoxRecvTime.TabStop = False
        '
        'LabelRecvTapeTime
        '
        Me.LabelRecvTapeTime.AutoSize = True
        Me.LabelRecvTapeTime.Location = New System.Drawing.Point(14, 216)
        Me.LabelRecvTapeTime.Name = "LabelRecvTapeTime"
        Me.LabelRecvTapeTime.Size = New System.Drawing.Size(53, 12)
        Me.LabelRecvTapeTime.TabIndex = 58
        Me.LabelRecvTapeTime.Text = "送带时间"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "媒介类型"
        '
        'ComboBoxMediaType
        '
        Me.ComboBoxMediaType.FormattingEnabled = True
        Me.ComboBoxMediaType.Items.AddRange(New Object() {"磁带", "蓝光", "DVD", "非编", "媒资"})
        Me.ComboBoxMediaType.Location = New System.Drawing.Point(78, 93)
        Me.ComboBoxMediaType.Name = "ComboBoxMediaType"
        Me.ComboBoxMediaType.Size = New System.Drawing.Size(233, 20)
        Me.ComboBoxMediaType.TabIndex = 41
        '
        'ComboBoxProgramType
        '
        Me.ComboBoxProgramType.FormattingEnabled = True
        Me.ComboBoxProgramType.Items.AddRange(New Object() {"日用广告", "新闻", "专题", "宣传片", "电视剧", "现场直播", "节目预告", "电影", "综艺节目", "电视购物", "探索", "歌曲", "青少", "法制", "生活服务", "广告包", "其他"})
        Me.ComboBoxProgramType.Location = New System.Drawing.Point(79, 41)
        Me.ComboBoxProgramType.Name = "ComboBoxProgramType"
        Me.ComboBoxProgramType.Size = New System.Drawing.Size(232, 20)
        Me.ComboBoxProgramType.TabIndex = 37
        '
        'LabelProgramType
        '
        Me.LabelProgramType.AutoSize = True
        Me.LabelProgramType.Location = New System.Drawing.Point(17, 44)
        Me.LabelProgramType.Name = "LabelProgramType"
        Me.LabelProgramType.Size = New System.Drawing.Size(53, 12)
        Me.LabelProgramType.TabIndex = 36
        Me.LabelProgramType.Text = "节目类型"
        '
        'LabelChannel
        '
        Me.LabelChannel.AutoSize = True
        Me.LabelChannel.Location = New System.Drawing.Point(17, 71)
        Me.LabelChannel.Name = "LabelChannel"
        Me.LabelChannel.Size = New System.Drawing.Size(53, 12)
        Me.LabelChannel.TabIndex = 38
        Me.LabelChannel.Text = "所属频道"
        '
        'ComboBoxChannel
        '
        Me.ComboBoxChannel.FormattingEnabled = True
        Me.ComboBoxChannel.Items.AddRange(New Object() {"新闻综合", "都市生活", "影视娱乐", "南宁公共"})
        Me.ComboBoxChannel.Location = New System.Drawing.Point(79, 67)
        Me.ComboBoxChannel.Name = "ComboBoxChannel"
        Me.ComboBoxChannel.Size = New System.Drawing.Size(232, 20)
        Me.ComboBoxChannel.TabIndex = 39
        '
        'TextBoxLengthF
        '
        Me.TextBoxLengthF.Location = New System.Drawing.Point(160, 150)
        Me.TextBoxLengthF.MaxLength = 2
        Me.TextBoxLengthF.Name = "TextBoxLengthF"
        Me.TextBoxLengthF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthF.TabIndex = 51
        '
        'TextBoxLengthS
        '
        Me.TextBoxLengthS.Location = New System.Drawing.Point(133, 150)
        Me.TextBoxLengthS.MaxLength = 2
        Me.TextBoxLengthS.Name = "TextBoxLengthS"
        Me.TextBoxLengthS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthS.TabIndex = 50
        '
        'TextBoxLengthM
        '
        Me.TextBoxLengthM.Location = New System.Drawing.Point(106, 150)
        Me.TextBoxLengthM.MaxLength = 2
        Me.TextBoxLengthM.Name = "TextBoxLengthM"
        Me.TextBoxLengthM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthM.TabIndex = 49
        '
        'TextBoxLengthH
        '
        Me.TextBoxLengthH.Location = New System.Drawing.Point(80, 150)
        Me.TextBoxLengthH.MaxLength = 2
        Me.TextBoxLengthH.Name = "TextBoxLengthH"
        Me.TextBoxLengthH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxLengthH.TabIndex = 48
        '
        'TextBoxEndTimeF
        '
        Me.TextBoxEndTimeF.Location = New System.Drawing.Point(160, 177)
        Me.TextBoxEndTimeF.MaxLength = 20
        Me.TextBoxEndTimeF.Name = "TextBoxEndTimeF"
        Me.TextBoxEndTimeF.ReadOnly = True
        Me.TextBoxEndTimeF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeF.TabIndex = 57
        Me.TextBoxEndTimeF.TabStop = False
        '
        'TextBoxEndTimeS
        '
        Me.TextBoxEndTimeS.Location = New System.Drawing.Point(133, 177)
        Me.TextBoxEndTimeS.MaxLength = 20
        Me.TextBoxEndTimeS.Name = "TextBoxEndTimeS"
        Me.TextBoxEndTimeS.ReadOnly = True
        Me.TextBoxEndTimeS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeS.TabIndex = 56
        Me.TextBoxEndTimeS.TabStop = False
        '
        'TextBoxEndTimeM
        '
        Me.TextBoxEndTimeM.Location = New System.Drawing.Point(106, 177)
        Me.TextBoxEndTimeM.MaxLength = 20
        Me.TextBoxEndTimeM.Name = "TextBoxEndTimeM"
        Me.TextBoxEndTimeM.ReadOnly = True
        Me.TextBoxEndTimeM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeM.TabIndex = 55
        Me.TextBoxEndTimeM.TabStop = False
        '
        'TextBoxEndTimeH
        '
        Me.TextBoxEndTimeH.Location = New System.Drawing.Point(80, 177)
        Me.TextBoxEndTimeH.MaxLength = 20
        Me.TextBoxEndTimeH.Name = "TextBoxEndTimeH"
        Me.TextBoxEndTimeH.ReadOnly = True
        Me.TextBoxEndTimeH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxEndTimeH.TabIndex = 54
        Me.TextBoxEndTimeH.TabStop = False
        '
        'TextBoxStartTimeF
        '
        Me.TextBoxStartTimeF.Location = New System.Drawing.Point(161, 123)
        Me.TextBoxStartTimeF.MaxLength = 2
        Me.TextBoxStartTimeF.Name = "TextBoxStartTimeF"
        Me.TextBoxStartTimeF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeF.TabIndex = 46
        '
        'TextBoxStartTimeS
        '
        Me.TextBoxStartTimeS.Location = New System.Drawing.Point(134, 123)
        Me.TextBoxStartTimeS.MaxLength = 2
        Me.TextBoxStartTimeS.Name = "TextBoxStartTimeS"
        Me.TextBoxStartTimeS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeS.TabIndex = 45
        '
        'TextBoxStartTimeM
        '
        Me.TextBoxStartTimeM.Location = New System.Drawing.Point(107, 123)
        Me.TextBoxStartTimeM.MaxLength = 2
        Me.TextBoxStartTimeM.Name = "TextBoxStartTimeM"
        Me.TextBoxStartTimeM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeM.TabIndex = 44
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Location = New System.Drawing.Point(133, 249)
        Me.TextBoxRemark.Multiline = True
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(178, 44)
        Me.TextBoxRemark.TabIndex = 61
        Me.TextBoxRemark.Text = "备注:"
        '
        'CheckBoxTape
        '
        Me.CheckBoxTape.AutoSize = True
        Me.CheckBoxTape.Location = New System.Drawing.Point(17, 251)
        Me.CheckBoxTape.Name = "CheckBoxTape"
        Me.CheckBoxTape.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxTape.TabIndex = 60
        Me.CheckBoxTape.Text = "带芯带盒一致"
        Me.CheckBoxTape.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(250, 343)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 67
        Me.ButtonCancel.Text = "取消"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(159, 343)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 66
        Me.ButtonOK.Text = "确认收带"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'LabelRecvPerson
        '
        Me.LabelRecvPerson.AutoSize = True
        Me.LabelRecvPerson.Location = New System.Drawing.Point(176, 312)
        Me.LabelRecvPerson.Name = "LabelRecvPerson"
        Me.LabelRecvPerson.Size = New System.Drawing.Size(53, 12)
        Me.LabelRecvPerson.TabIndex = 64
        Me.LabelRecvPerson.Text = "收带人员"
        '
        'LabelSendPerson
        '
        Me.LabelSendPerson.AutoSize = True
        Me.LabelSendPerson.Location = New System.Drawing.Point(15, 310)
        Me.LabelSendPerson.Name = "LabelSendPerson"
        Me.LabelSendPerson.Size = New System.Drawing.Size(53, 12)
        Me.LabelSendPerson.TabIndex = 62
        Me.LabelSendPerson.Text = "送带人员"
        '
        'TextBoxRecvPerson
        '
        Me.TextBoxRecvPerson.Location = New System.Drawing.Point(235, 306)
        Me.TextBoxRecvPerson.Name = "TextBoxRecvPerson"
        Me.TextBoxRecvPerson.Size = New System.Drawing.Size(76, 21)
        Me.TextBoxRecvPerson.TabIndex = 65
        '
        'TextBoxSendPerson
        '
        Me.TextBoxSendPerson.Enabled = False
        Me.TextBoxSendPerson.Location = New System.Drawing.Point(77, 306)
        Me.TextBoxSendPerson.Name = "TextBoxSendPerson"
        Me.TextBoxSendPerson.Size = New System.Drawing.Size(76, 21)
        Me.TextBoxSendPerson.TabIndex = 63
        '
        'TextBoxStartTimeH
        '
        Me.TextBoxStartTimeH.Location = New System.Drawing.Point(80, 123)
        Me.TextBoxStartTimeH.MaxLength = 2
        Me.TextBoxStartTimeH.Name = "TextBoxStartTimeH"
        Me.TextBoxStartTimeH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxStartTimeH.TabIndex = 43
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Enabled = False
        Me.TextBoxTapeName.Location = New System.Drawing.Point(79, 13)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(232, 21)
        Me.TextBoxTapeName.TabIndex = 35
        '
        'LabelLength
        '
        Me.LabelLength.AutoSize = True
        Me.LabelLength.Location = New System.Drawing.Point(15, 156)
        Me.LabelLength.Name = "LabelLength"
        Me.LabelLength.Size = New System.Drawing.Size(53, 12)
        Me.LabelLength.TabIndex = 47
        Me.LabelLength.Text = "节目时长"
        '
        'LabelEndTimeCode
        '
        Me.LabelEndTimeCode.AutoSize = True
        Me.LabelEndTimeCode.Location = New System.Drawing.Point(14, 184)
        Me.LabelEndTimeCode.Name = "LabelEndTimeCode"
        Me.LabelEndTimeCode.Size = New System.Drawing.Size(53, 12)
        Me.LabelEndTimeCode.TabIndex = 53
        Me.LabelEndTimeCode.Text = "结束时码"
        '
        'LabelStartTimeCode
        '
        Me.LabelStartTimeCode.AutoSize = True
        Me.LabelStartTimeCode.Location = New System.Drawing.Point(15, 130)
        Me.LabelStartTimeCode.Name = "LabelStartTimeCode"
        Me.LabelStartTimeCode.Size = New System.Drawing.Size(53, 12)
        Me.LabelStartTimeCode.TabIndex = 42
        Me.LabelStartTimeCode.Text = "开始时码"
        '
        'LabelTapeName
        '
        Me.LabelTapeName.AutoSize = True
        Me.LabelTapeName.Location = New System.Drawing.Point(17, 17)
        Me.LabelTapeName.Name = "LabelTapeName"
        Me.LabelTapeName.Size = New System.Drawing.Size(53, 12)
        Me.LabelTapeName.TabIndex = 34
        Me.LabelTapeName.Text = "节目名称"
        '
        'TapeRecOnlyRecv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 384)
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
        Me.MaximumSize = New System.Drawing.Size(354, 418)
        Me.MinimumSize = New System.Drawing.Size(354, 418)
        Me.Name = "TapeRecOnlyRecv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "收带确认"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRecvTime As System.Windows.Forms.TextBox
    Friend WithEvents LabelRecvTapeTime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents TextBoxRemark As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxTape As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents LabelRecvPerson As System.Windows.Forms.Label
    Friend WithEvents LabelSendPerson As System.Windows.Forms.Label
    Friend WithEvents TextBoxRecvPerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSendPerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStartTimeH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTapeName As System.Windows.Forms.TextBox
    Friend WithEvents LabelLength As System.Windows.Forms.Label
    Friend WithEvents LabelEndTimeCode As System.Windows.Forms.Label
    Friend WithEvents LabelStartTimeCode As System.Windows.Forms.Label
    Friend WithEvents LabelTapeName As System.Windows.Forms.Label
End Class
