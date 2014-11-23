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
        Me.TextBoxSendPerson = New System.Windows.Forms.TextBox
        Me.TextBoxRecvPerson = New System.Windows.Forms.TextBox
        Me.LabelSendPerson = New System.Windows.Forms.Label
        Me.LabelRecvPerson = New System.Windows.Forms.Label
        Me.ButtonOK = New System.Windows.Forms.Button
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.CheckBoxTape = New System.Windows.Forms.CheckBox
        Me.TextBoxRemark = New System.Windows.Forms.TextBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.TextBoxRecvTime = New System.Windows.Forms.TextBox
        Me.LabelRecvTapeTime = New System.Windows.Forms.Label
        Me.ListBoxTapeName = New System.Windows.Forms.ListBox
        Me.ButtonAdd = New System.Windows.Forms.Button
        Me.PanelSearchResult = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PanelSearchResult.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxSendPerson
        '
        Me.TextBoxSendPerson.Location = New System.Drawing.Point(63, 97)
        Me.TextBoxSendPerson.Name = "TextBoxSendPerson"
        Me.TextBoxSendPerson.Size = New System.Drawing.Size(67, 21)
        Me.TextBoxSendPerson.TabIndex = 29
        '
        'TextBoxRecvPerson
        '
        Me.TextBoxRecvPerson.Location = New System.Drawing.Point(199, 97)
        Me.TextBoxRecvPerson.Name = "TextBoxRecvPerson"
        Me.TextBoxRecvPerson.Size = New System.Drawing.Size(76, 21)
        Me.TextBoxRecvPerson.TabIndex = 31
        '
        'LabelSendPerson
        '
        Me.LabelSendPerson.AutoSize = True
        Me.LabelSendPerson.Location = New System.Drawing.Point(4, 101)
        Me.LabelSendPerson.Name = "LabelSendPerson"
        Me.LabelSendPerson.Size = New System.Drawing.Size(53, 12)
        Me.LabelSendPerson.TabIndex = 28
        Me.LabelSendPerson.Text = "送带人员"
        '
        'LabelRecvPerson
        '
        Me.LabelRecvPerson.AutoSize = True
        Me.LabelRecvPerson.Location = New System.Drawing.Point(140, 101)
        Me.LabelRecvPerson.Name = "LabelRecvPerson"
        Me.LabelRecvPerson.Size = New System.Drawing.Size(53, 12)
        Me.LabelRecvPerson.TabIndex = 30
        Me.LabelRecvPerson.Text = "收带人员"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(118, 130)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 32
        Me.ButtonOK.Text = "确认收带"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(200, 130)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 33
        Me.ButtonCancel.Text = "取消"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'CheckBoxTape
        '
        Me.CheckBoxTape.AutoSize = True
        Me.CheckBoxTape.Location = New System.Drawing.Point(6, 42)
        Me.CheckBoxTape.Name = "CheckBoxTape"
        Me.CheckBoxTape.Size = New System.Drawing.Size(96, 16)
        Me.CheckBoxTape.TabIndex = 26
        Me.CheckBoxTape.Text = "带芯带盒一致"
        Me.CheckBoxTape.UseVisualStyleBackColor = True
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Location = New System.Drawing.Point(108, 40)
        Me.TextBoxRemark.Multiline = True
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(167, 44)
        Me.TextBoxRemark.TabIndex = 27
        Me.TextBoxRemark.Text = "备注:"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'TextBoxRecvTime
        '
        Me.TextBoxRecvTime.Location = New System.Drawing.Point(67, 4)
        Me.TextBoxRecvTime.Name = "TextBoxRecvTime"
        Me.TextBoxRecvTime.ReadOnly = True
        Me.TextBoxRecvTime.Size = New System.Drawing.Size(156, 21)
        Me.TextBoxRecvTime.TabIndex = 25
        Me.TextBoxRecvTime.TabStop = False
        '
        'LabelRecvTapeTime
        '
        Me.LabelRecvTapeTime.AutoSize = True
        Me.LabelRecvTapeTime.Location = New System.Drawing.Point(3, 7)
        Me.LabelRecvTapeTime.Name = "LabelRecvTapeTime"
        Me.LabelRecvTapeTime.Size = New System.Drawing.Size(53, 12)
        Me.LabelRecvTapeTime.TabIndex = 24
        Me.LabelRecvTapeTime.Text = "送带时间"
        '
        'ListBoxTapeName
        '
        Me.ListBoxTapeName.FormattingEnabled = True
        Me.ListBoxTapeName.ItemHeight = 12
        Me.ListBoxTapeName.Location = New System.Drawing.Point(3, 3)
        Me.ListBoxTapeName.Name = "ListBoxTapeName"
        Me.ListBoxTapeName.Size = New System.Drawing.Size(162, 16)
        Me.ListBoxTapeName.TabIndex = 34
        Me.ListBoxTapeName.Visible = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAdd.BackgroundImage = Global.UploadProcessSupervision.My.Resources.Resources.add2
        Me.ButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAdd.FlatAppearance.BorderSize = 0
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdd.Location = New System.Drawing.Point(185, 12)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(26, 28)
        Me.ButtonAdd.TabIndex = 35
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'PanelSearchResult
        '
        Me.PanelSearchResult.Controls.Add(Me.ListBoxTapeName)
        Me.PanelSearchResult.Location = New System.Drawing.Point(12, 12)
        Me.PanelSearchResult.Name = "PanelSearchResult"
        Me.PanelSearchResult.Size = New System.Drawing.Size(167, 386)
        Me.PanelSearchResult.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxRemark)
        Me.Panel1.Controls.Add(Me.TextBoxSendPerson)
        Me.Panel1.Controls.Add(Me.TextBoxRecvPerson)
        Me.Panel1.Controls.Add(Me.TextBoxRecvTime)
        Me.Panel1.Controls.Add(Me.LabelSendPerson)
        Me.Panel1.Controls.Add(Me.LabelRecvTapeTime)
        Me.Panel1.Controls.Add(Me.LabelRecvPerson)
        Me.Panel1.Controls.Add(Me.ButtonOK)
        Me.Panel1.Controls.Add(Me.CheckBoxTape)
        Me.Panel1.Controls.Add(Me.ButtonCancel)
        Me.Panel1.Location = New System.Drawing.Point(185, 238)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 160)
        Me.Panel1.TabIndex = 37
        '
        'TapeReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 421)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSearchResult)
        Me.Controls.Add(Me.ButtonAdd)
        Me.MinimumSize = New System.Drawing.Size(354, 418)
        Me.Name = "TapeReceive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "送带"
        Me.PanelSearchResult.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxSendPerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRecvPerson As System.Windows.Forms.TextBox
    Friend WithEvents LabelSendPerson As System.Windows.Forms.Label
    Friend WithEvents LabelRecvPerson As System.Windows.Forms.Label
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents CheckBoxTape As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxRemark As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBoxRecvTime As System.Windows.Forms.TextBox
    Friend WithEvents LabelRecvTapeTime As System.Windows.Forms.Label
    Friend WithEvents ListBoxTapeName As System.Windows.Forms.ListBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents PanelSearchResult As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
