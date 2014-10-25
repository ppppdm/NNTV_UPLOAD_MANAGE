<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FixTimeCode
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBoxFixTimeCodePerson = New System.Windows.Forms.TextBox
        Me.TextBoxTapeName = New System.Windows.Forms.TextBox
        Me.TextBoxOldStartTimeCode = New System.Windows.Forms.TextBox
        Me.TextBoxOldLength = New System.Windows.Forms.TextBox
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.ButtonOK = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxNewLengthF = New System.Windows.Forms.TextBox
        Me.TextBoxNewLengthS = New System.Windows.Forms.TextBox
        Me.TextBoxNewLengthM = New System.Windows.Forms.TextBox
        Me.TextBoxNewLengthH = New System.Windows.Forms.TextBox
        Me.TextBoxNewStartTimeF = New System.Windows.Forms.TextBox
        Me.TextBoxNewStartTimeS = New System.Windows.Forms.TextBox
        Me.TextBoxNewStartTimeM = New System.Windows.Forms.TextBox
        Me.TextBoxNewStartTimeH = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "节目名称"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "开始时码"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "节目时长"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "修改人员"
        '
        'TextBoxFixTimeCodePerson
        '
        Me.TextBoxFixTimeCodePerson.Location = New System.Drawing.Point(84, 218)
        Me.TextBoxFixTimeCodePerson.Name = "TextBoxFixTimeCodePerson"
        Me.TextBoxFixTimeCodePerson.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxFixTimeCodePerson.TabIndex = 6
        '
        'TextBoxTapeName
        '
        Me.TextBoxTapeName.Enabled = False
        Me.TextBoxTapeName.Location = New System.Drawing.Point(84, 18)
        Me.TextBoxTapeName.Name = "TextBoxTapeName"
        Me.TextBoxTapeName.Size = New System.Drawing.Size(141, 21)
        Me.TextBoxTapeName.TabIndex = 7
        '
        'TextBoxOldStartTimeCode
        '
        Me.TextBoxOldStartTimeCode.Enabled = False
        Me.TextBoxOldStartTimeCode.Location = New System.Drawing.Point(84, 50)
        Me.TextBoxOldStartTimeCode.Name = "TextBoxOldStartTimeCode"
        Me.TextBoxOldStartTimeCode.Size = New System.Drawing.Size(141, 21)
        Me.TextBoxOldStartTimeCode.TabIndex = 8
        '
        'TextBoxOldLength
        '
        Me.TextBoxOldLength.Enabled = False
        Me.TextBoxOldLength.Location = New System.Drawing.Point(84, 80)
        Me.TextBoxOldLength.Name = "TextBoxOldLength"
        Me.TextBoxOldLength.Size = New System.Drawing.Size(141, 21)
        Me.TextBoxOldLength.TabIndex = 9
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(180, 270)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 12
        Me.ButtonCancel.Text = "取消"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(98, 270)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 13
        Me.ButtonOK.Text = "确认"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "新节目时长"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "新开始时码"
        '
        'TextBoxNewLengthF
        '
        Me.TextBoxNewLengthF.Location = New System.Drawing.Point(165, 157)
        Me.TextBoxNewLengthF.MaxLength = 2
        Me.TextBoxNewLengthF.Name = "TextBoxNewLengthF"
        Me.TextBoxNewLengthF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxNewLengthF.TabIndex = 47
        '
        'TextBoxNewLengthS
        '
        Me.TextBoxNewLengthS.Location = New System.Drawing.Point(138, 157)
        Me.TextBoxNewLengthS.MaxLength = 2
        Me.TextBoxNewLengthS.Name = "TextBoxNewLengthS"
        Me.TextBoxNewLengthS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxNewLengthS.TabIndex = 46
        '
        'TextBoxNewLengthM
        '
        Me.TextBoxNewLengthM.Location = New System.Drawing.Point(111, 157)
        Me.TextBoxNewLengthM.MaxLength = 2
        Me.TextBoxNewLengthM.Name = "TextBoxNewLengthM"
        Me.TextBoxNewLengthM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxNewLengthM.TabIndex = 45
        '
        'TextBoxNewLengthH
        '
        Me.TextBoxNewLengthH.Location = New System.Drawing.Point(85, 157)
        Me.TextBoxNewLengthH.MaxLength = 2
        Me.TextBoxNewLengthH.Name = "TextBoxNewLengthH"
        Me.TextBoxNewLengthH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxNewLengthH.TabIndex = 44
        '
        'TextBoxNewStartTimeF
        '
        Me.TextBoxNewStartTimeF.Location = New System.Drawing.Point(166, 130)
        Me.TextBoxNewStartTimeF.MaxLength = 2
        Me.TextBoxNewStartTimeF.Name = "TextBoxNewStartTimeF"
        Me.TextBoxNewStartTimeF.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxNewStartTimeF.TabIndex = 43
        '
        'TextBoxNewStartTimeS
        '
        Me.TextBoxNewStartTimeS.Location = New System.Drawing.Point(139, 130)
        Me.TextBoxNewStartTimeS.MaxLength = 2
        Me.TextBoxNewStartTimeS.Name = "TextBoxNewStartTimeS"
        Me.TextBoxNewStartTimeS.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxNewStartTimeS.TabIndex = 42
        '
        'TextBoxNewStartTimeM
        '
        Me.TextBoxNewStartTimeM.Location = New System.Drawing.Point(112, 130)
        Me.TextBoxNewStartTimeM.MaxLength = 2
        Me.TextBoxNewStartTimeM.Name = "TextBoxNewStartTimeM"
        Me.TextBoxNewStartTimeM.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxNewStartTimeM.TabIndex = 41
        '
        'TextBoxNewStartTimeH
        '
        Me.TextBoxNewStartTimeH.Location = New System.Drawing.Point(85, 130)
        Me.TextBoxNewStartTimeH.MaxLength = 2
        Me.TextBoxNewStartTimeH.Name = "TextBoxNewStartTimeH"
        Me.TextBoxNewStartTimeH.Size = New System.Drawing.Size(20, 21)
        Me.TextBoxNewStartTimeH.TabIndex = 40
        '
        'FixTimeCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 322)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxNewLengthF)
        Me.Controls.Add(Me.TextBoxNewLengthS)
        Me.Controls.Add(Me.TextBoxNewLengthM)
        Me.Controls.Add(Me.TextBoxNewLengthH)
        Me.Controls.Add(Me.TextBoxNewStartTimeF)
        Me.Controls.Add(Me.TextBoxNewStartTimeS)
        Me.Controls.Add(Me.TextBoxNewStartTimeM)
        Me.Controls.Add(Me.TextBoxNewStartTimeH)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.TextBoxOldLength)
        Me.Controls.Add(Me.TextBoxOldStartTimeCode)
        Me.Controls.Add(Me.TextBoxTapeName)
        Me.Controls.Add(Me.TextBoxFixTimeCodePerson)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FixTimeCode"
        Me.Text = "带子时码修改"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFixTimeCodePerson As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTapeName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOldStartTimeCode As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOldLength As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNewLengthF As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewLengthS As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewLengthM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewLengthH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewStartTimeF As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewStartTimeS As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewStartTimeM As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNewStartTimeH As System.Windows.Forms.TextBox
End Class
