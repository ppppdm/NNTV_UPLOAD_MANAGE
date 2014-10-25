<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPerson
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
        Me.TextBoxPersonName = New System.Windows.Forms.TextBox
        Me.LabelName = New System.Windows.Forms.Label
        Me.LabelDepartment = New System.Windows.Forms.Label
        Me.TextBoxDepartment = New System.Windows.Forms.TextBox
        Me.LabelPhone = New System.Windows.Forms.Label
        Me.TextBoxPhone = New System.Windows.Forms.TextBox
        Me.LabelID = New System.Windows.Forms.Label
        Me.TextBoxID = New System.Windows.Forms.TextBox
        Me.CheckBoxInBcSendPerson = New System.Windows.Forms.CheckBox
        Me.CheckBoxInBcRecvPerson = New System.Windows.Forms.CheckBox
        Me.CheckBoxOutBcRecvPerson = New System.Windows.Forms.CheckBox
        Me.CheckBoxOutBcSendPerson = New System.Windows.Forms.CheckBox
        Me.CheckBoxUpload = New System.Windows.Forms.CheckBox
        Me.CheckBoxCheckup = New System.Windows.Forms.CheckBox
        Me.CheckBoxEdit = New System.Windows.Forms.CheckBox
        Me.CheckBoxAdmin = New System.Windows.Forms.CheckBox
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.GroupBoxPersonManage = New System.Windows.Forms.GroupBox
        Me.ButtonRegister = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxRegPassword = New System.Windows.Forms.TextBox
        Me.GroupBoxLogin = New System.Windows.Forms.GroupBox
        Me.ButtonLogin = New System.Windows.Forms.Button
        Me.TextBoxPassword = New System.Windows.Forms.TextBox
        Me.TextBoxAccount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.GroupBoxPersonManage.SuspendLayout()
        Me.GroupBoxLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxPersonName
        '
        Me.TextBoxPersonName.Location = New System.Drawing.Point(39, 15)
        Me.TextBoxPersonName.Name = "TextBoxPersonName"
        Me.TextBoxPersonName.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxPersonName.TabIndex = 4
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(4, 18)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(29, 12)
        Me.LabelName.TabIndex = 5
        Me.LabelName.Text = "姓名"
        '
        'LabelDepartment
        '
        Me.LabelDepartment.AutoSize = True
        Me.LabelDepartment.Location = New System.Drawing.Point(4, 98)
        Me.LabelDepartment.Name = "LabelDepartment"
        Me.LabelDepartment.Size = New System.Drawing.Size(29, 12)
        Me.LabelDepartment.TabIndex = 7
        Me.LabelDepartment.Text = "部门"
        '
        'TextBoxDepartment
        '
        Me.TextBoxDepartment.Location = New System.Drawing.Point(39, 95)
        Me.TextBoxDepartment.Name = "TextBoxDepartment"
        Me.TextBoxDepartment.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxDepartment.TabIndex = 6
        '
        'LabelPhone
        '
        Me.LabelPhone.AutoSize = True
        Me.LabelPhone.Location = New System.Drawing.Point(4, 131)
        Me.LabelPhone.Name = "LabelPhone"
        Me.LabelPhone.Size = New System.Drawing.Size(29, 12)
        Me.LabelPhone.TabIndex = 9
        Me.LabelPhone.Text = "电话"
        '
        'TextBoxPhone
        '
        Me.TextBoxPhone.Location = New System.Drawing.Point(39, 122)
        Me.TextBoxPhone.Name = "TextBoxPhone"
        Me.TextBoxPhone.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxPhone.TabIndex = 8
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(4, 72)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(17, 12)
        Me.LabelID.TabIndex = 10
        Me.LabelID.Text = "ID"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(39, 68)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxID.TabIndex = 11
        '
        'CheckBoxInBcSendPerson
        '
        Me.CheckBoxInBcSendPerson.AutoSize = True
        Me.CheckBoxInBcSendPerson.Location = New System.Drawing.Point(172, 14)
        Me.CheckBoxInBcSendPerson.Name = "CheckBoxInBcSendPerson"
        Me.CheckBoxInBcSendPerson.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxInBcSendPerson.TabIndex = 12
        Me.CheckBoxInBcSendPerson.Text = "送带"
        Me.CheckBoxInBcSendPerson.UseVisualStyleBackColor = True
        '
        'CheckBoxInBcRecvPerson
        '
        Me.CheckBoxInBcRecvPerson.AutoSize = True
        Me.CheckBoxInBcRecvPerson.Location = New System.Drawing.Point(172, 49)
        Me.CheckBoxInBcRecvPerson.Name = "CheckBoxInBcRecvPerson"
        Me.CheckBoxInBcRecvPerson.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxInBcRecvPerson.TabIndex = 13
        Me.CheckBoxInBcRecvPerson.Text = "收带"
        Me.CheckBoxInBcRecvPerson.UseVisualStyleBackColor = True
        '
        'CheckBoxOutBcRecvPerson
        '
        Me.CheckBoxOutBcRecvPerson.AutoSize = True
        Me.CheckBoxOutBcRecvPerson.Location = New System.Drawing.Point(172, 85)
        Me.CheckBoxOutBcRecvPerson.Name = "CheckBoxOutBcRecvPerson"
        Me.CheckBoxOutBcRecvPerson.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxOutBcRecvPerson.TabIndex = 14
        Me.CheckBoxOutBcRecvPerson.Text = "取带"
        Me.CheckBoxOutBcRecvPerson.UseVisualStyleBackColor = True
        '
        'CheckBoxOutBcSendPerson
        '
        Me.CheckBoxOutBcSendPerson.AutoSize = True
        Me.CheckBoxOutBcSendPerson.Location = New System.Drawing.Point(172, 124)
        Me.CheckBoxOutBcSendPerson.Name = "CheckBoxOutBcSendPerson"
        Me.CheckBoxOutBcSendPerson.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxOutBcSendPerson.TabIndex = 15
        Me.CheckBoxOutBcSendPerson.Text = "发带"
        Me.CheckBoxOutBcSendPerson.UseVisualStyleBackColor = True
        '
        'CheckBoxUpload
        '
        Me.CheckBoxUpload.AutoSize = True
        Me.CheckBoxUpload.Location = New System.Drawing.Point(252, 14)
        Me.CheckBoxUpload.Name = "CheckBoxUpload"
        Me.CheckBoxUpload.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxUpload.TabIndex = 16
        Me.CheckBoxUpload.Text = "上载"
        Me.CheckBoxUpload.UseVisualStyleBackColor = True
        '
        'CheckBoxCheckup
        '
        Me.CheckBoxCheckup.AutoSize = True
        Me.CheckBoxCheckup.Location = New System.Drawing.Point(252, 49)
        Me.CheckBoxCheckup.Name = "CheckBoxCheckup"
        Me.CheckBoxCheckup.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxCheckup.TabIndex = 17
        Me.CheckBoxCheckup.Text = "审核"
        Me.CheckBoxCheckup.UseVisualStyleBackColor = True
        '
        'CheckBoxEdit
        '
        Me.CheckBoxEdit.AutoSize = True
        Me.CheckBoxEdit.Location = New System.Drawing.Point(252, 85)
        Me.CheckBoxEdit.Name = "CheckBoxEdit"
        Me.CheckBoxEdit.Size = New System.Drawing.Size(48, 16)
        Me.CheckBoxEdit.TabIndex = 18
        Me.CheckBoxEdit.Text = "编辑"
        Me.CheckBoxEdit.UseVisualStyleBackColor = True
        '
        'CheckBoxAdmin
        '
        Me.CheckBoxAdmin.AutoSize = True
        Me.CheckBoxAdmin.Location = New System.Drawing.Point(252, 124)
        Me.CheckBoxAdmin.Name = "CheckBoxAdmin"
        Me.CheckBoxAdmin.Size = New System.Drawing.Size(60, 16)
        Me.CheckBoxAdmin.TabIndex = 19
        Me.CheckBoxAdmin.Text = "管理员"
        Me.CheckBoxAdmin.UseVisualStyleBackColor = True
        '
        'ButtonQuery
        '
        Me.ButtonQuery.Location = New System.Drawing.Point(338, 87)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuery.TabIndex = 20
        Me.ButtonQuery.Text = "查询"
        Me.ButtonQuery.UseVisualStyleBackColor = True
        '
        'GroupBoxPersonManage
        '
        Me.GroupBoxPersonManage.Controls.Add(Me.ButtonRegister)
        Me.GroupBoxPersonManage.Controls.Add(Me.Label3)
        Me.GroupBoxPersonManage.Controls.Add(Me.TextBoxRegPassword)
        Me.GroupBoxPersonManage.Controls.Add(Me.CheckBoxCheckup)
        Me.GroupBoxPersonManage.Controls.Add(Me.TextBoxPersonName)
        Me.GroupBoxPersonManage.Controls.Add(Me.LabelName)
        Me.GroupBoxPersonManage.Controls.Add(Me.ButtonQuery)
        Me.GroupBoxPersonManage.Controls.Add(Me.TextBoxDepartment)
        Me.GroupBoxPersonManage.Controls.Add(Me.CheckBoxAdmin)
        Me.GroupBoxPersonManage.Controls.Add(Me.LabelDepartment)
        Me.GroupBoxPersonManage.Controls.Add(Me.CheckBoxEdit)
        Me.GroupBoxPersonManage.Controls.Add(Me.TextBoxPhone)
        Me.GroupBoxPersonManage.Controls.Add(Me.LabelPhone)
        Me.GroupBoxPersonManage.Controls.Add(Me.CheckBoxUpload)
        Me.GroupBoxPersonManage.Controls.Add(Me.LabelID)
        Me.GroupBoxPersonManage.Controls.Add(Me.CheckBoxOutBcSendPerson)
        Me.GroupBoxPersonManage.Controls.Add(Me.TextBoxID)
        Me.GroupBoxPersonManage.Controls.Add(Me.CheckBoxOutBcRecvPerson)
        Me.GroupBoxPersonManage.Controls.Add(Me.CheckBoxInBcSendPerson)
        Me.GroupBoxPersonManage.Controls.Add(Me.CheckBoxInBcRecvPerson)
        Me.GroupBoxPersonManage.Location = New System.Drawing.Point(13, 84)
        Me.GroupBoxPersonManage.Name = "GroupBoxPersonManage"
        Me.GroupBoxPersonManage.Size = New System.Drawing.Size(419, 178)
        Me.GroupBoxPersonManage.TabIndex = 21
        Me.GroupBoxPersonManage.TabStop = False
        Me.GroupBoxPersonManage.Text = "注册/查询"
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(338, 120)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegister.TabIndex = 23
        Me.ButtonRegister.Text = "注册"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "密码"
        '
        'TextBoxRegPassword
        '
        Me.TextBoxRegPassword.Location = New System.Drawing.Point(39, 42)
        Me.TextBoxRegPassword.Name = "TextBoxRegPassword"
        Me.TextBoxRegPassword.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxRegPassword.TabIndex = 21
        '
        'GroupBoxLogin
        '
        Me.GroupBoxLogin.Controls.Add(Me.ButtonLogin)
        Me.GroupBoxLogin.Controls.Add(Me.TextBoxPassword)
        Me.GroupBoxLogin.Controls.Add(Me.TextBoxAccount)
        Me.GroupBoxLogin.Controls.Add(Me.Label2)
        Me.GroupBoxLogin.Controls.Add(Me.Label1)
        Me.GroupBoxLogin.Location = New System.Drawing.Point(13, 24)
        Me.GroupBoxLogin.Name = "GroupBoxLogin"
        Me.GroupBoxLogin.Size = New System.Drawing.Size(419, 54)
        Me.GroupBoxLogin.TabIndex = 22
        Me.GroupBoxLogin.TabStop = False
        Me.GroupBoxLogin.Text = "登录"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(338, 20)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "登录"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(193, 20)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(107, 21)
        Me.TextBoxPassword.TabIndex = 3
        '
        'TextBoxAccount
        '
        Me.TextBoxAccount.Location = New System.Drawing.Point(42, 20)
        Me.TextBoxAccount.Name = "TextBoxAccount"
        Me.TextBoxAccount.Size = New System.Drawing.Size(97, 21)
        Me.TextBoxAccount.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "密码"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "帐号"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'AddPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 274)
        Me.Controls.Add(Me.GroupBoxLogin)
        Me.Controls.Add(Me.GroupBoxPersonManage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddPerson"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "工作人员管理"
        Me.GroupBoxPersonManage.ResumeLayout(False)
        Me.GroupBoxPersonManage.PerformLayout()
        Me.GroupBoxLogin.ResumeLayout(False)
        Me.GroupBoxLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxPersonName As System.Windows.Forms.TextBox
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents LabelDepartment As System.Windows.Forms.Label
    Friend WithEvents TextBoxDepartment As System.Windows.Forms.TextBox
    Friend WithEvents LabelPhone As System.Windows.Forms.Label
    Friend WithEvents TextBoxPhone As System.Windows.Forms.TextBox
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxInBcSendPerson As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxInBcRecvPerson As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOutBcRecvPerson As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOutBcSendPerson As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxUpload As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCheckup As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxEdit As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents GroupBoxPersonManage As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxLogin As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRegPassword As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonRegister As System.Windows.Forms.Button

End Class
