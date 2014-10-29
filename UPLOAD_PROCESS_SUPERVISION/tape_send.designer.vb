<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TapeSend
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
        Me.TextBoxSendTime = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.ButtonOK = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxSendPerson = New System.Windows.Forms.TextBox
        Me.TextBoxRecvPerson = New System.Windows.Forms.TextBox
        Me.TextBoxTapeName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.SuspendLayout()
        '
        'TextBoxSendTime
        '
        Me.TextBoxSendTime.Location = New System.Drawing.Point(113, 73)
        Me.TextBoxSendTime.Name = "TextBoxSendTime"
        Me.TextBoxSendTime.ReadOnly = True
        Me.TextBoxSendTime.Size = New System.Drawing.Size(148, 21)
        Me.TextBoxSendTime.TabIndex = 39
        Me.TextBoxSendTime.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "取带时间"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(368, 171)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "取消"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(272, 171)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 2
        Me.ButtonOK.Text = "确认发带"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(281, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "发带人"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "取带人"
        '
        'TextBoxSendPerson
        '
        Me.TextBoxSendPerson.Location = New System.Drawing.Point(346, 122)
        Me.TextBoxSendPerson.Name = "TextBoxSendPerson"
        Me.TextBoxSendPerson.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxSendPerson.TabIndex = 1
        '
        'TextBoxRecvPerson
        '
        Me.TextBoxRecvPerson.Location = New System.Drawing.Point(113, 122)
        Me.TextBoxRecvPerson.Name = "TextBoxRecvPerson"
        Me.TextBoxRecvPerson.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxRecvPerson.TabIndex = 0
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Location = New System.Drawing.Point(113, 25)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(222, 21)
        Me.TextBoxTapeName.TabIndex = 24
        Me.TextBoxTapeName.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "磁带名"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'TapeSend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 219)
        Me.Controls.Add(Me.TextBoxSendTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxSendPerson)
        Me.Controls.Add(Me.TextBoxRecvPerson)
        Me.Controls.Add(Me.TextBoxTapeName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TapeSend"
        Me.Text = "发带"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxSendTime As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSendPerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRecvPerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTapeName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
