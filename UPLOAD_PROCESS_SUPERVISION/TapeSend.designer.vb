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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxTapeName = New System.Windows.Forms.TextBox
        Me.TextBoxStartTime = New System.Windows.Forms.TextBox
        Me.TextBoxEndTime = New System.Windows.Forms.TextBox
        Me.TextBoxLength = New System.Windows.Forms.TextBox
        Me.TextBoxSendPerson = New System.Windows.Forms.TextBox
        Me.TextBoxRecvPerson = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.CheckBoxTape = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxRemark = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ButtonGetTime = New System.Windows.Forms.Button
        Me.TextBoxSendTime = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "磁带名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "开始时码"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "结束时码"
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Location = New System.Drawing.Point(119, 23)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(222, 21)
        Me.TextBoxTapeName.TabIndex = 4
        '
        'TextBoxStartTime
        '
        Me.TextBoxStartTime.Location = New System.Drawing.Point(119, 53)
        Me.TextBoxStartTime.Name = "TextBoxStartTime"
        Me.TextBoxStartTime.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxStartTime.TabIndex = 5
        '
        'TextBoxEndTime
        '
        Me.TextBoxEndTime.Location = New System.Drawing.Point(119, 87)
        Me.TextBoxEndTime.Name = "TextBoxEndTime"
        Me.TextBoxEndTime.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxEndTime.TabIndex = 6
        '
        'TextBoxLength
        '
        Me.TextBoxLength.Location = New System.Drawing.Point(119, 119)
        Me.TextBoxLength.Name = "TextBoxLength"
        Me.TextBoxLength.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxLength.TabIndex = 7
        '
        'TextBoxSendPerson
        '
        Me.TextBoxSendPerson.Location = New System.Drawing.Point(119, 293)
        Me.TextBoxSendPerson.Name = "TextBoxSendPerson"
        Me.TextBoxSendPerson.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxSendPerson.TabIndex = 8
        '
        'TextBoxRecvPerson
        '
        Me.TextBoxRecvPerson.Location = New System.Drawing.Point(364, 293)
        Me.TextBoxRecvPerson.Name = "TextBoxRecvPerson"
        Me.TextBoxRecvPerson.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxRecvPerson.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "送带人"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(264, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "收带人"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "确认收带"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(406, 341)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 13
        Me.Cancel_Button.Text = "取消"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'CheckBoxTape
        '
        Me.CheckBoxTape.AutoSize = True
        Me.CheckBoxTape.Location = New System.Drawing.Point(32, 259)
        Me.CheckBoxTape.Name = "CheckBoxTape"
        Me.CheckBoxTape.Size = New System.Drawing.Size(120, 16)
        Me.CheckBoxTape.TabIndex = 14
        Me.CheckBoxTape.Text = "带芯带盒是否一致"
        Me.CheckBoxTape.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "时长"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "备注"
        '
        'TextBoxRemark
        '
        Me.TextBoxRemark.Location = New System.Drawing.Point(119, 155)
        Me.TextBoxRemark.Multiline = True
        Me.TextBoxRemark.Name = "TextBoxRemark"
        Me.TextBoxRemark.Size = New System.Drawing.Size(222, 50)
        Me.TextBoxRemark.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "送带时间"
        '
        'ButtonGetTime
        '
        Me.ButtonGetTime.Location = New System.Drawing.Point(286, 216)
        Me.ButtonGetTime.Name = "ButtonGetTime"
        Me.ButtonGetTime.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGetTime.TabIndex = 18
        Me.ButtonGetTime.Text = "获取时间"
        Me.ButtonGetTime.UseVisualStyleBackColor = True
        '
        'TextBoxSendTime
        '
        Me.TextBoxSendTime.Location = New System.Drawing.Point(119, 218)
        Me.TextBoxSendTime.Name = "TextBoxSendTime"
        Me.TextBoxSendTime.Size = New System.Drawing.Size(148, 21)
        Me.TextBoxSendTime.TabIndex = 19
        '
        'tape_send
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 385)
        Me.Controls.Add(Me.TextBoxSendTime)
        Me.Controls.Add(Me.ButtonGetTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxRemark)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBoxTape)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxRecvPerson)
        Me.Controls.Add(Me.TextBoxSendPerson)
        Me.Controls.Add(Me.TextBoxLength)
        Me.Controls.Add(Me.TextBoxEndTime)
        Me.Controls.Add(Me.TextBoxStartTime)
        Me.Controls.Add(Me.TextBoxTapeName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TapeSend"
        Me.Text = "送带"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTapeName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStartTime As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEndTime As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLength As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSendPerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRecvPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents CheckBoxTape As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonGetTime As System.Windows.Forms.Button
    Friend WithEvents TextBoxSendTime As System.Windows.Forms.TextBox
End Class
