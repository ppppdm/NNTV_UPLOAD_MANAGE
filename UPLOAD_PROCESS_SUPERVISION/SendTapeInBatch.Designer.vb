<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendTapeInBatch
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
        Me.LabelTapeName = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxSendPerson = New System.Windows.Forms.TextBox
        Me.TextBoxRecvPerson = New System.Windows.Forms.TextBox
        Me.TextBoxSendTime = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBoxTapeName = New System.Windows.Forms.TextBox
        Me.TextBoxTapeNamePrefix = New System.Windows.Forms.TextBox
        Me.TextBoxTapeNameSuffix = New System.Windows.Forms.TextBox
        Me.CheckBoxTapeNamePrefix = New System.Windows.Forms.CheckBox
        Me.CheckBoxTapeNameSuffix = New System.Windows.Forms.CheckBox
        Me.ButtonOK = New System.Windows.Forms.Button
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.NumericUpDownHeadSuf = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownTailSuf = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDownTailPre = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownHeadPre = New System.Windows.Forms.NumericUpDown
        CType(Me.NumericUpDownHeadSuf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTailSuf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTailPre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHeadPre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTapeName
        '
        Me.LabelTapeName.AutoSize = True
        Me.LabelTapeName.Location = New System.Drawing.Point(12, 20)
        Me.LabelTapeName.Name = "LabelTapeName"
        Me.LabelTapeName.Size = New System.Drawing.Size(53, 12)
        Me.LabelTapeName.TabIndex = 0
        Me.LabelTapeName.Text = "节目名称"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(237, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "发带人"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "取带人"
        '
        'TextBoxSendPerson
        '
        Me.TextBoxSendPerson.Location = New System.Drawing.Point(302, 139)
        Me.TextBoxSendPerson.Name = "TextBoxSendPerson"
        Me.TextBoxSendPerson.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxSendPerson.TabIndex = 33
        '
        'TextBoxRecvPerson
        '
        Me.TextBoxRecvPerson.Location = New System.Drawing.Point(93, 139)
        Me.TextBoxRecvPerson.Name = "TextBoxRecvPerson"
        Me.TextBoxRecvPerson.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxRecvPerson.TabIndex = 32
        '
        'TextBoxSendTime
        '
        Me.TextBoxSendTime.Location = New System.Drawing.Point(93, 105)
        Me.TextBoxSendTime.Name = "TextBoxSendTime"
        Me.TextBoxSendTime.ReadOnly = True
        Me.TextBoxSendTime.Size = New System.Drawing.Size(148, 21)
        Me.TextBoxSendTime.TabIndex = 41
        Me.TextBoxSendTime.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "取带时间"
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Location = New System.Drawing.Point(93, 12)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTapeName.TabIndex = 42
        '
        'TextBoxTapeNamePrefix
        '
        Me.TextBoxTapeNamePrefix.Location = New System.Drawing.Point(93, 45)
        Me.TextBoxTapeNamePrefix.Name = "TextBoxTapeNamePrefix"
        Me.TextBoxTapeNamePrefix.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTapeNamePrefix.TabIndex = 45
        '
        'TextBoxTapeNameSuffix
        '
        Me.TextBoxTapeNameSuffix.Location = New System.Drawing.Point(93, 74)
        Me.TextBoxTapeNameSuffix.Name = "TextBoxTapeNameSuffix"
        Me.TextBoxTapeNameSuffix.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTapeNameSuffix.TabIndex = 46
        '
        'CheckBoxTapeNamePrefix
        '
        Me.CheckBoxTapeNamePrefix.AutoSize = True
        Me.CheckBoxTapeNamePrefix.Location = New System.Drawing.Point(14, 49)
        Me.CheckBoxTapeNamePrefix.Name = "CheckBoxTapeNamePrefix"
        Me.CheckBoxTapeNamePrefix.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxTapeNamePrefix.TabIndex = 47
        Me.CheckBoxTapeNamePrefix.Text = "前缀"
        Me.CheckBoxTapeNamePrefix.UseVisualStyleBackColor = True
        '
        'CheckBoxTapeNameSuffix
        '
        Me.CheckBoxTapeNameSuffix.AutoSize = True
        Me.CheckBoxTapeNameSuffix.Location = New System.Drawing.Point(14, 76)
        Me.CheckBoxTapeNameSuffix.Name = "CheckBoxTapeNameSuffix"
        Me.CheckBoxTapeNameSuffix.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxTapeNameSuffix.TabIndex = 48
        Me.CheckBoxTapeNameSuffix.Text = "后缀"
        Me.CheckBoxTapeNameSuffix.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(272, 181)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 49
        Me.ButtonOK.Text = "确定"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(365, 181)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 50
        Me.ButtonCancel.Text = "取消"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(214, 10)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearch.TabIndex = 51
        Me.ButtonSearch.Text = "查询"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'NumericUpDownHeadSuf
        '
        Me.NumericUpDownHeadSuf.Location = New System.Drawing.Point(219, 74)
        Me.NumericUpDownHeadSuf.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownHeadSuf.Name = "NumericUpDownHeadSuf"
        Me.NumericUpDownHeadSuf.Size = New System.Drawing.Size(64, 21)
        Me.NumericUpDownHeadSuf.TabIndex = 52
        '
        'NumericUpDownTailSuf
        '
        Me.NumericUpDownTailSuf.Location = New System.Drawing.Point(334, 74)
        Me.NumericUpDownTailSuf.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownTailSuf.Name = "NumericUpDownTailSuf"
        Me.NumericUpDownTailSuf.Size = New System.Drawing.Size(68, 21)
        Me.NumericUpDownTailSuf.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(300, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "至"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "至"
        '
        'NumericUpDownTailPre
        '
        Me.NumericUpDownTailPre.Location = New System.Drawing.Point(334, 44)
        Me.NumericUpDownTailPre.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownTailPre.Name = "NumericUpDownTailPre"
        Me.NumericUpDownTailPre.Size = New System.Drawing.Size(68, 21)
        Me.NumericUpDownTailPre.TabIndex = 56
        '
        'NumericUpDownHeadPre
        '
        Me.NumericUpDownHeadPre.Location = New System.Drawing.Point(219, 44)
        Me.NumericUpDownHeadPre.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDownHeadPre.Name = "NumericUpDownHeadPre"
        Me.NumericUpDownHeadPre.Size = New System.Drawing.Size(64, 21)
        Me.NumericUpDownHeadPre.TabIndex = 55
        '
        'SendTapeInBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 216)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDownTailPre)
        Me.Controls.Add(Me.NumericUpDownHeadPre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownTailSuf)
        Me.Controls.Add(Me.NumericUpDownHeadSuf)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.CheckBoxTapeNameSuffix)
        Me.Controls.Add(Me.CheckBoxTapeNamePrefix)
        Me.Controls.Add(Me.TextBoxTapeNameSuffix)
        Me.Controls.Add(Me.TextBoxTapeNamePrefix)
        Me.Controls.Add(Me.TextBoxTapeName)
        Me.Controls.Add(Me.TextBoxSendTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxSendPerson)
        Me.Controls.Add(Me.TextBoxRecvPerson)
        Me.Controls.Add(Me.LabelTapeName)
        Me.Name = "SendTapeInBatch"
        Me.Text = "SendTapeInBatch"
        CType(Me.NumericUpDownHeadSuf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTailSuf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTailPre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHeadPre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTapeName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSendPerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRecvPerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSendTime As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTapeName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTapeNamePrefix As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTapeNameSuffix As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxTapeNamePrefix As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTapeNameSuffix As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownHeadSuf As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownTailSuf As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownTailPre As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownHeadPre As System.Windows.Forms.NumericUpDown
End Class
