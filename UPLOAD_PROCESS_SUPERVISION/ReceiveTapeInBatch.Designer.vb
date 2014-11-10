<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveTapeInBatch
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxTapeName = New System.Windows.Forms.TextBox
        Me.NumericUpDownHead = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownTail = New System.Windows.Forms.NumericUpDown
        Me.LabelEpisode = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBoxMediaType = New System.Windows.Forms.ComboBox
        Me.ComboBoxProgramType = New System.Windows.Forms.ComboBox
        Me.LabelProgramType = New System.Windows.Forms.Label
        Me.LabelChannel = New System.Windows.Forms.Label
        Me.ComboBoxChannel = New System.Windows.Forms.ComboBox
        Me.TextBoxRemark = New System.Windows.Forms.TextBox
        Me.CheckBoxTape = New System.Windows.Forms.CheckBox
        Me.LabelRecvPerson = New System.Windows.Forms.Label
        Me.LabelSendPerson = New System.Windows.Forms.Label
        Me.TextBoxRecvPerson = New System.Windows.Forms.TextBox
        Me.TextBoxSendPerson = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBoxRecvTime = New System.Windows.Forms.TextBox
        Me.LabelRecvTapeTime = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        CType(Me.NumericUpDownHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "节目名称"
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Location = New System.Drawing.Point(70, 27)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(236, 21)
        Me.TextBoxTapeName.TabIndex = 1
        '
        'NumericUpDownHead
        '
        Me.NumericUpDownHead.Location = New System.Drawing.Point(70, 61)
        Me.NumericUpDownHead.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownHead.Name = "NumericUpDownHead"
        Me.NumericUpDownHead.Size = New System.Drawing.Size(55, 21)
        Me.NumericUpDownHead.TabIndex = 2
        Me.NumericUpDownHead.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDownTail
        '
        Me.NumericUpDownTail.Cursor = System.Windows.Forms.Cursors.Default
        Me.NumericUpDownTail.Location = New System.Drawing.Point(175, 61)
        Me.NumericUpDownTail.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDownTail.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownTail.Name = "NumericUpDownTail"
        Me.NumericUpDownTail.Size = New System.Drawing.Size(59, 21)
        Me.NumericUpDownTail.TabIndex = 3
        Me.NumericUpDownTail.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelEpisode
        '
        Me.LabelEpisode.AutoSize = True
        Me.LabelEpisode.Location = New System.Drawing.Point(11, 66)
        Me.LabelEpisode.Name = "LabelEpisode"
        Me.LabelEpisode.Size = New System.Drawing.Size(47, 12)
        Me.LabelEpisode.TabIndex = 4
        Me.LabelEpisode.Text = "集   数"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "至"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "媒介类型"
        '
        'ComboBoxMediaType
        '
        Me.ComboBoxMediaType.FormattingEnabled = True
        Me.ComboBoxMediaType.Items.AddRange(New Object() {"磁带", "蓝光", "DVD", "非编", "媒资"})
        Me.ComboBoxMediaType.Location = New System.Drawing.Point(69, 148)
        Me.ComboBoxMediaType.Name = "ComboBoxMediaType"
        Me.ComboBoxMediaType.Size = New System.Drawing.Size(237, 20)
        Me.ComboBoxMediaType.TabIndex = 13
        '
        'ComboBoxProgramType
        '
        Me.ComboBoxProgramType.FormattingEnabled = True
        Me.ComboBoxProgramType.Items.AddRange(New Object() {"日用广告", "新闻", "专题", "宣传片", "电视剧", "现场直播", "节目预告", "电影", "综艺节目", "电视购物", "探索", "歌曲", "青少", "法制", "生活服务", "广告包", "其他"})
        Me.ComboBoxProgramType.Location = New System.Drawing.Point(70, 96)
        Me.ComboBoxProgramType.Name = "ComboBoxProgramType"
        Me.ComboBoxProgramType.Size = New System.Drawing.Size(236, 20)
        Me.ComboBoxProgramType.TabIndex = 9
        '
        'LabelProgramType
        '
        Me.LabelProgramType.AutoSize = True
        Me.LabelProgramType.Location = New System.Drawing.Point(8, 99)
        Me.LabelProgramType.Name = "LabelProgramType"
        Me.LabelProgramType.Size = New System.Drawing.Size(53, 12)
        Me.LabelProgramType.TabIndex = 8
        Me.LabelProgramType.Text = "节目类型"
        '
        'LabelChannel
        '
        Me.LabelChannel.AutoSize = True
        Me.LabelChannel.Location = New System.Drawing.Point(8, 126)
        Me.LabelChannel.Name = "LabelChannel"
        Me.LabelChannel.Size = New System.Drawing.Size(53, 12)
        Me.LabelChannel.TabIndex = 10
        Me.LabelChannel.Text = "所属频道"
        '
        'ComboBoxChannel
        '
        Me.ComboBoxChannel.FormattingEnabled = True
        Me.ComboBoxChannel.Items.AddRange(New Object() {"新闻综合", "都市生活", "影视娱乐", "南宁公共"})
        Me.ComboBoxChannel.Location = New System.Drawing.Point(70, 122)
        Me.ComboBoxChannel.Name = "ComboBoxChannel"
        Me.ComboBoxChannel.Size = New System.Drawing.Size(236, 20)
        Me.ComboBoxChannel.TabIndex = 11
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Location = New System.Drawing.Point(128, 217)
        Me.TextBoxRemark.Multiline = True
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(178, 44)
        Me.TextBoxRemark.TabIndex = 33
        Me.TextBoxRemark.Text = "备注:批送带"
        '
        'CheckBoxTape
        '
        Me.CheckBoxTape.AutoSize = True
        Me.CheckBoxTape.Location = New System.Drawing.Point(12, 219)
        Me.CheckBoxTape.Name = "CheckBoxTape"
        Me.CheckBoxTape.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxTape.TabIndex = 32
        Me.CheckBoxTape.Text = "带芯带盒一致"
        Me.CheckBoxTape.UseVisualStyleBackColor = True
        '
        'LabelRecvPerson
        '
        Me.LabelRecvPerson.AutoSize = True
        Me.LabelRecvPerson.Location = New System.Drawing.Point(171, 280)
        Me.LabelRecvPerson.Name = "LabelRecvPerson"
        Me.LabelRecvPerson.Size = New System.Drawing.Size(53, 12)
        Me.LabelRecvPerson.TabIndex = 36
        Me.LabelRecvPerson.Text = "收带人员"
        '
        'LabelSendPerson
        '
        Me.LabelSendPerson.AutoSize = True
        Me.LabelSendPerson.Location = New System.Drawing.Point(10, 278)
        Me.LabelSendPerson.Name = "LabelSendPerson"
        Me.LabelSendPerson.Size = New System.Drawing.Size(53, 12)
        Me.LabelSendPerson.TabIndex = 34
        Me.LabelSendPerson.Text = "送带人员"
        '
        'TextBoxRecvPerson
        '
        Me.TextBoxRecvPerson.Location = New System.Drawing.Point(230, 274)
        Me.TextBoxRecvPerson.Name = "TextBoxRecvPerson"
        Me.TextBoxRecvPerson.Size = New System.Drawing.Size(76, 21)
        Me.TextBoxRecvPerson.TabIndex = 37
        '
        'TextBoxSendPerson
        '
        Me.TextBoxSendPerson.Location = New System.Drawing.Point(72, 274)
        Me.TextBoxSendPerson.Name = "TextBoxSendPerson"
        Me.TextBoxSendPerson.Size = New System.Drawing.Size(76, 21)
        Me.TextBoxSendPerson.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(230, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxRecvTime
        '
        Me.TextBoxRecvTime.Location = New System.Drawing.Point(69, 181)
        Me.TextBoxRecvTime.Name = "TextBoxRecvTime"
        Me.TextBoxRecvTime.ReadOnly = True
        Me.TextBoxRecvTime.Size = New System.Drawing.Size(156, 21)
        Me.TextBoxRecvTime.TabIndex = 41
        Me.TextBoxRecvTime.TabStop = False
        '
        'LabelRecvTapeTime
        '
        Me.LabelRecvTapeTime.AutoSize = True
        Me.LabelRecvTapeTime.Location = New System.Drawing.Point(5, 184)
        Me.LabelRecvTapeTime.Name = "LabelRecvTapeTime"
        Me.LabelRecvTapeTime.Size = New System.Drawing.Size(53, 12)
        Me.LabelRecvTapeTime.TabIndex = 40
        Me.LabelRecvTapeTime.Text = "送带时间"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ReceiveTapeInBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 366)
        Me.Controls.Add(Me.TextBoxRecvTime)
        Me.Controls.Add(Me.LabelRecvTapeTime)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxRemark)
        Me.Controls.Add(Me.CheckBoxTape)
        Me.Controls.Add(Me.LabelRecvPerson)
        Me.Controls.Add(Me.LabelSendPerson)
        Me.Controls.Add(Me.TextBoxRecvPerson)
        Me.Controls.Add(Me.TextBoxSendPerson)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxMediaType)
        Me.Controls.Add(Me.ComboBoxProgramType)
        Me.Controls.Add(Me.LabelProgramType)
        Me.Controls.Add(Me.LabelChannel)
        Me.Controls.Add(Me.ComboBoxChannel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelEpisode)
        Me.Controls.Add(Me.NumericUpDownTail)
        Me.Controls.Add(Me.NumericUpDownHead)
        Me.Controls.Add(Me.TextBoxTapeName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReceiveTapeInBatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "批送带"
        CType(Me.NumericUpDownHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTapeName As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDownHead As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownTail As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelEpisode As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMediaType As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxProgramType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelProgramType As System.Windows.Forms.Label
    Friend WithEvents LabelChannel As System.Windows.Forms.Label
    Friend WithEvents ComboBoxChannel As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxRemark As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxTape As System.Windows.Forms.CheckBox
    Friend WithEvents LabelRecvPerson As System.Windows.Forms.Label
    Friend WithEvents LabelSendPerson As System.Windows.Forms.Label
    Friend WithEvents TextBoxRecvPerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSendPerson As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBoxRecvTime As System.Windows.Forms.TextBox
    Friend WithEvents LabelRecvTapeTime As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
