<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TapeReceiveOld
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
        Me.LabelRemark = New System.Windows.Forms.Label
        Me.TextBoxRemark = New System.Windows.Forms.TextBox
        Me.LabelRecvTapeTime = New System.Windows.Forms.Label
        Me.TextBoxRecvTime = New System.Windows.Forms.TextBox
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
        Me.CheckBoxNoStartTime = New System.Windows.Forms.CheckBox
        Me.ComboBoxChannel = New System.Windows.Forms.ComboBox
        Me.LabelChannel = New System.Windows.Forms.Label
        Me.ListBoxTapeName = New System.Windows.Forms.ListBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LabelTapeName
        '
        Me.LabelTapeName.AutoSize = True
        Me.LabelTapeName.Location = New System.Drawing.Point(7, 30)
        Me.LabelTapeName.Name = "LabelTapeName"
        Me.LabelTapeName.Size = New System.Drawing.Size(53, 12)
        Me.LabelTapeName.TabIndex = 0
        Me.LabelTapeName.Text = "节目名称"
        '
        'LabelStartTimeCode
        '
        Me.LabelStartTimeCode.AutoSize = True
        Me.LabelStartTimeCode.Location = New System.Drawing.Point(5, 191)
        Me.LabelStartTimeCode.Name = "LabelStartTimeCode"
        Me.LabelStartTimeCode.Size = New System.Drawing.Size(53, 12)
        Me.LabelStartTimeCode.TabIndex = 1
        Me.LabelStartTimeCode.Text = "开始时码"
        '
        'LabelEndTimeCode
        '
        Me.LabelEndTimeCode.AutoSize = True
        Me.LabelEndTimeCode.Location = New System.Drawing.Point(5, 241)
        Me.LabelEndTimeCode.Name = "LabelEndTimeCode"
        Me.LabelEndTimeCode.Size = New System.Drawing.Size(53, 12)
        Me.LabelEndTimeCode.TabIndex = 2
        Me.LabelEndTimeCode.Text = "结束时码"
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Location = New System.Drawing.Point(66, 27)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(222, 21)
        Me.TextBoxTapeName.TabIndex = 0
        '
        'TextBoxStartTimeH
        '
        Me.TextBoxStartTimeH.Location = New System.Drawing.Point(66, 184)
        Me.TextBoxStartTimeH.MaxLength = 2
        Me.TextBoxStartTimeH.Name = "TextBoxStartTimeH"
        Me.TextBoxStartTimeH.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxStartTimeH.TabIndex = 2
        '
        'TextBoxSendPerson
        '
        Me.TextBoxSendPerson.Location = New System.Drawing.Point(66, 265)
        Me.TextBoxSendPerson.Name = "TextBoxSendPerson"
        Me.TextBoxSendPerson.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxSendPerson.TabIndex = 13
        '
        'TextBoxRecvPerson
        '
        Me.TextBoxRecvPerson.Location = New System.Drawing.Point(64, 298)
        Me.TextBoxRecvPerson.Name = "TextBoxRecvPerson"
        Me.TextBoxRecvPerson.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxRecvPerson.TabIndex = 14
        '
        'LabelSendPerson
        '
        Me.LabelSendPerson.AutoSize = True
        Me.LabelSendPerson.Location = New System.Drawing.Point(7, 268)
        Me.LabelSendPerson.Name = "LabelSendPerson"
        Me.LabelSendPerson.Size = New System.Drawing.Size(53, 12)
        Me.LabelSendPerson.TabIndex = 10
        Me.LabelSendPerson.Text = "送带人员"
        '
        'LabelRecvPerson
        '
        Me.LabelRecvPerson.AutoSize = True
        Me.LabelRecvPerson.Location = New System.Drawing.Point(5, 301)
        Me.LabelRecvPerson.Name = "LabelRecvPerson"
        Me.LabelRecvPerson.Size = New System.Drawing.Size(53, 12)
        Me.LabelRecvPerson.TabIndex = 11
        Me.LabelRecvPerson.Text = "收带人员"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(98, 347)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(66, 23)
        Me.ButtonOK.TabIndex = 15
        Me.ButtonOK.Text = "确认收带"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(186, 347)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(66, 23)
        Me.ButtonCancel.TabIndex = 16
        Me.ButtonCancel.Text = "取消"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'CheckBoxTape
        '
        Me.CheckBoxTape.AutoSize = True
        Me.CheckBoxTape.Location = New System.Drawing.Point(66, 160)
        Me.CheckBoxTape.Name = "CheckBoxTape"
        Me.CheckBoxTape.Size = New System.Drawing.Size(108, 16)
        Me.CheckBoxTape.TabIndex = 11
        Me.CheckBoxTape.Text = "带芯带盒一致性"
        Me.CheckBoxTape.UseVisualStyleBackColor = True
        '
        'LabelLength
        '
        Me.LabelLength.AutoSize = True
        Me.LabelLength.Location = New System.Drawing.Point(7, 214)
        Me.LabelLength.Name = "LabelLength"
        Me.LabelLength.Size = New System.Drawing.Size(53, 12)
        Me.LabelLength.TabIndex = 3
        Me.LabelLength.Text = "节目时长"
        '
        'LabelRemark
        '
        Me.LabelRemark.AutoSize = True
        Me.LabelRemark.Location = New System.Drawing.Point(211, 164)
        Me.LabelRemark.Name = "LabelRemark"
        Me.LabelRemark.Size = New System.Drawing.Size(53, 12)
        Me.LabelRemark.TabIndex = 15
        Me.LabelRemark.Text = "情况备注"
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Location = New System.Drawing.Point(174, 184)
        Me.TextBoxRemark.Multiline = True
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(118, 135)
        Me.TextBoxRemark.TabIndex = 12
        '
        'LabelRecvTapeTime
        '
        Me.LabelRecvTapeTime.AutoSize = True
        Me.LabelRecvTapeTime.Location = New System.Drawing.Point(5, 107)
        Me.LabelRecvTapeTime.Name = "LabelRecvTapeTime"
        Me.LabelRecvTapeTime.Size = New System.Drawing.Size(53, 12)
        Me.LabelRecvTapeTime.TabIndex = 17
        Me.LabelRecvTapeTime.Text = "送带时间"
        '
        'TextBoxRecvTime
        '
        Me.TextBoxRecvTime.Location = New System.Drawing.Point(66, 104)
        Me.TextBoxRecvTime.Name = "TextBoxRecvTime"
        Me.TextBoxRecvTime.ReadOnly = True
        Me.TextBoxRecvTime.Size = New System.Drawing.Size(222, 21)
        Me.TextBoxRecvTime.TabIndex = 19
        Me.TextBoxRecvTime.TabStop = False
        '
        'TextBoxStartTimeM
        '
        Me.TextBoxStartTimeM.Location = New System.Drawing.Point(93, 184)
        Me.TextBoxStartTimeM.MaxLength = 2
        Me.TextBoxStartTimeM.Name = "TextBoxStartTimeM"
        Me.TextBoxStartTimeM.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxStartTimeM.TabIndex = 3
        '
        'TextBoxStartTimeS
        '
        Me.TextBoxStartTimeS.Location = New System.Drawing.Point(120, 184)
        Me.TextBoxStartTimeS.MaxLength = 2
        Me.TextBoxStartTimeS.Name = "TextBoxStartTimeS"
        Me.TextBoxStartTimeS.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxStartTimeS.TabIndex = 4
        '
        'TextBoxStartTimeF
        '
        Me.TextBoxStartTimeF.Location = New System.Drawing.Point(147, 184)
        Me.TextBoxStartTimeF.MaxLength = 2
        Me.TextBoxStartTimeF.Name = "TextBoxStartTimeF"
        Me.TextBoxStartTimeF.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxStartTimeF.TabIndex = 5
        '
        'TextBoxEndTimeH
        '
        Me.TextBoxEndTimeH.Location = New System.Drawing.Point(66, 238)
        Me.TextBoxEndTimeH.MaxLength = 20
        Me.TextBoxEndTimeH.Name = "TextBoxEndTimeH"
        Me.TextBoxEndTimeH.ReadOnly = True
        Me.TextBoxEndTimeH.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxEndTimeH.TabIndex = 23
        Me.TextBoxEndTimeH.TabStop = False
        '
        'TextBoxEndTimeM
        '
        Me.TextBoxEndTimeM.Location = New System.Drawing.Point(92, 238)
        Me.TextBoxEndTimeM.MaxLength = 20
        Me.TextBoxEndTimeM.Name = "TextBoxEndTimeM"
        Me.TextBoxEndTimeM.ReadOnly = True
        Me.TextBoxEndTimeM.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxEndTimeM.TabIndex = 24
        Me.TextBoxEndTimeM.TabStop = False
        '
        'TextBoxEndTimeS
        '
        Me.TextBoxEndTimeS.Location = New System.Drawing.Point(119, 238)
        Me.TextBoxEndTimeS.MaxLength = 20
        Me.TextBoxEndTimeS.Name = "TextBoxEndTimeS"
        Me.TextBoxEndTimeS.ReadOnly = True
        Me.TextBoxEndTimeS.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxEndTimeS.TabIndex = 25
        Me.TextBoxEndTimeS.TabStop = False
        '
        'TextBoxEndTimeF
        '
        Me.TextBoxEndTimeF.Location = New System.Drawing.Point(146, 238)
        Me.TextBoxEndTimeF.MaxLength = 20
        Me.TextBoxEndTimeF.Name = "TextBoxEndTimeF"
        Me.TextBoxEndTimeF.ReadOnly = True
        Me.TextBoxEndTimeF.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxEndTimeF.TabIndex = 26
        Me.TextBoxEndTimeF.TabStop = False
        '
        'TextBoxLengthF
        '
        Me.TextBoxLengthF.Location = New System.Drawing.Point(146, 211)
        Me.TextBoxLengthF.MaxLength = 2
        Me.TextBoxLengthF.Name = "TextBoxLengthF"
        Me.TextBoxLengthF.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxLengthF.TabIndex = 10
        '
        'TextBoxLengthS
        '
        Me.TextBoxLengthS.Location = New System.Drawing.Point(119, 211)
        Me.TextBoxLengthS.MaxLength = 2
        Me.TextBoxLengthS.Name = "TextBoxLengthS"
        Me.TextBoxLengthS.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxLengthS.TabIndex = 9
        '
        'TextBoxLengthM
        '
        Me.TextBoxLengthM.Location = New System.Drawing.Point(92, 211)
        Me.TextBoxLengthM.MaxLength = 2
        Me.TextBoxLengthM.Name = "TextBoxLengthM"
        Me.TextBoxLengthM.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxLengthM.TabIndex = 8
        '
        'TextBoxLengthH
        '
        Me.TextBoxLengthH.Location = New System.Drawing.Point(66, 211)
        Me.TextBoxLengthH.MaxLength = 2
        Me.TextBoxLengthH.Name = "TextBoxLengthH"
        Me.TextBoxLengthH.Size = New System.Drawing.Size(21, 21)
        Me.TextBoxLengthH.TabIndex = 7
        '
        'CheckBoxNoStartTime
        '
        Me.CheckBoxNoStartTime.AutoSize = True
        Me.CheckBoxNoStartTime.Location = New System.Drawing.Point(7, 160)
        Me.CheckBoxNoStartTime.Name = "CheckBoxNoStartTime"
        Me.CheckBoxNoStartTime.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxNoStartTime.TabIndex = 6
        Me.CheckBoxNoStartTime.Text = "非编"
        Me.CheckBoxNoStartTime.UseVisualStyleBackColor = True
        '
        'ComboBoxChannel
        '
        Me.ComboBoxChannel.FormattingEnabled = True
        Me.ComboBoxChannel.Items.AddRange(New Object() {"新闻综合", "都市生活", "影视娱乐", "南宁公共"})
        Me.ComboBoxChannel.Location = New System.Drawing.Point(66, 76)
        Me.ComboBoxChannel.Name = "ComboBoxChannel"
        Me.ComboBoxChannel.Size = New System.Drawing.Size(222, 20)
        Me.ComboBoxChannel.TabIndex = 1
        '
        'LabelChannel
        '
        Me.LabelChannel.AutoSize = True
        Me.LabelChannel.Location = New System.Drawing.Point(7, 79)
        Me.LabelChannel.Name = "LabelChannel"
        Me.LabelChannel.Size = New System.Drawing.Size(53, 12)
        Me.LabelChannel.TabIndex = 33
        Me.LabelChannel.Text = "所属频道"
        '
        'ListBoxTapeName
        '
        Me.ListBoxTapeName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListBoxTapeName.FormattingEnabled = True
        Me.ListBoxTapeName.ItemHeight = 12
        Me.ListBoxTapeName.Location = New System.Drawing.Point(66, 48)
        Me.ListBoxTapeName.Name = "ListBoxTapeName"
        Me.ListBoxTapeName.Size = New System.Drawing.Size(222, 16)
        Me.ListBoxTapeName.TabIndex = 34
        Me.ListBoxTapeName.Visible = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(67, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(220, 20)
        Me.ComboBox1.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "媒介类型"
        '
        'tape_receive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 374)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBoxTapeName)
        Me.Controls.Add(Me.LabelChannel)
        Me.Controls.Add(Me.ComboBoxChannel)
        Me.Controls.Add(Me.CheckBoxNoStartTime)
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
        Me.Controls.Add(Me.TextBoxRecvTime)
        Me.Controls.Add(Me.LabelRecvTapeTime)
        Me.Controls.Add(Me.TextBoxRemark)
        Me.Controls.Add(Me.LabelRemark)
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
        Me.Name = "tape_receive"
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
    Friend WithEvents LabelRemark As System.Windows.Forms.Label
    Friend WithEvents TextBoxRemark As System.Windows.Forms.TextBox
    Friend WithEvents LabelRecvTapeTime As System.Windows.Forms.Label
    Friend WithEvents TextBoxRecvTime As System.Windows.Forms.TextBox
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
    Friend WithEvents CheckBoxNoStartTime As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxChannel As System.Windows.Forms.ComboBox
    Friend WithEvents LabelChannel As System.Windows.Forms.Label
    Friend WithEvents ListBoxTapeName As System.Windows.Forms.ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
