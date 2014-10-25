<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.tabsetting = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ButtonTestDBConn = New System.Windows.Forms.Button
        Me.TextBoxDBName = New System.Windows.Forms.TextBox
        Me.TextBoxDBPawd = New System.Windows.Forms.TextBox
        Me.TextBoxDBUser = New System.Windows.Forms.TextBox
        Me.TextBoxDBAddr = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.ButtonTestFigurePrintConn = New System.Windows.Forms.Button
        Me.TextBoxFigurePrintIP = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.CheckBoxUseCamera = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.NumericUpDownHeadLen = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownMiddLen = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownTailLen = New System.Windows.Forms.NumericUpDown
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabsetting.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.NumericUpDownHeadLen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMiddLen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTailLen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(445, 348)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "确定"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "取消"
        '
        'tabsetting
        '
        Me.tabsetting.Controls.Add(Me.TabPage1)
        Me.tabsetting.Controls.Add(Me.TabPage2)
        Me.tabsetting.Controls.Add(Me.TabPage3)
        Me.tabsetting.Controls.Add(Me.TabPage4)
        Me.tabsetting.Controls.Add(Me.TabPage5)
        Me.tabsetting.Controls.Add(Me.TabPage6)
        Me.tabsetting.Location = New System.Drawing.Point(12, 12)
        Me.tabsetting.Name = "tabsetting"
        Me.tabsetting.SelectedIndex = 0
        Me.tabsetting.Size = New System.Drawing.Size(579, 330)
        Me.tabsetting.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonTestDBConn)
        Me.TabPage1.Controls.Add(Me.TextBoxDBName)
        Me.TabPage1.Controls.Add(Me.TextBoxDBPawd)
        Me.TabPage1.Controls.Add(Me.TextBoxDBUser)
        Me.TabPage1.Controls.Add(Me.TextBoxDBAddr)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(571, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "数据库设置"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonTestDBConn
        '
        Me.ButtonTestDBConn.Location = New System.Drawing.Point(424, 239)
        Me.ButtonTestDBConn.Name = "ButtonTestDBConn"
        Me.ButtonTestDBConn.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTestDBConn.TabIndex = 26
        Me.ButtonTestDBConn.Text = "测试连接"
        Me.ButtonTestDBConn.UseVisualStyleBackColor = True
        '
        'TextBoxDBName
        '
        Me.TextBoxDBName.Location = New System.Drawing.Point(129, 151)
        Me.TextBoxDBName.Name = "TextBoxDBName"
        Me.TextBoxDBName.Size = New System.Drawing.Size(370, 21)
        Me.TextBoxDBName.TabIndex = 25
        '
        'TextBoxDBPawd
        '
        Me.TextBoxDBPawd.Location = New System.Drawing.Point(129, 111)
        Me.TextBoxDBPawd.Name = "TextBoxDBPawd"
        Me.TextBoxDBPawd.Size = New System.Drawing.Size(370, 21)
        Me.TextBoxDBPawd.TabIndex = 24
        '
        'TextBoxDBUser
        '
        Me.TextBoxDBUser.Location = New System.Drawing.Point(129, 73)
        Me.TextBoxDBUser.Name = "TextBoxDBUser"
        Me.TextBoxDBUser.Size = New System.Drawing.Size(370, 21)
        Me.TextBoxDBUser.TabIndex = 23
        '
        'TextBoxDBAddr
        '
        Me.TextBoxDBAddr.Location = New System.Drawing.Point(129, 36)
        Me.TextBoxDBAddr.Name = "TextBoxDBAddr"
        Me.TextBoxDBAddr.Size = New System.Drawing.Size(370, 21)
        Me.TextBoxDBAddr.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "数据库名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "密码"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "用户名"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "数据库地址"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NumericUpDownTailLen)
        Me.TabPage2.Controls.Add(Me.NumericUpDownMiddLen)
        Me.TabPage2.Controls.Add(Me.NumericUpDownHeadLen)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 21)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(571, 305)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "审核点"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CheckBox10)
        Me.TabPage3.Controls.Add(Me.CheckBox11)
        Me.TabPage3.Controls.Add(Me.CheckBox9)
        Me.TabPage3.Controls.Add(Me.CheckBox8)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 21)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(571, 305)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "查询高级选项"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(40, 178)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(114, 16)
        Me.CheckBox10.TabIndex = 4
        Me.CheckBox10.Text = """日期,时间""选择"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(40, 142)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(108, 16)
        Me.CheckBox11.TabIndex = 3
        Me.CheckBox11.Text = """已审核""复选框"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(40, 105)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(108, 16)
        Me.CheckBox9.TabIndex = 2
        Me.CheckBox9.Text = """未审核""复选框"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(40, 69)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(108, 16)
        Me.CheckBox8.TabIndex = 1
        Me.CheckBox8.Text = """未采集""复选框"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 12)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "要启用的高级查询选项"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CheckBox5)
        Me.TabPage4.Controls.Add(Me.CheckBox6)
        Me.TabPage4.Controls.Add(Me.CheckBox7)
        Me.TabPage4.Controls.Add(Me.CheckBox4)
        Me.TabPage4.Controls.Add(Me.CheckBox3)
        Me.TabPage4.Controls.Add(Me.CheckBox2)
        Me.TabPage4.Controls.Add(Me.CheckBox1)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Location = New System.Drawing.Point(4, 21)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(571, 305)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "查询显示设置"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(31, 266)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox5.TabIndex = 7
        Me.CheckBox5.Text = "收带人"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(31, 230)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox6.TabIndex = 6
        Me.CheckBox6.Text = "发带人"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(31, 194)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox7.TabIndex = 5
        Me.CheckBox7.Text = "发带时间"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(31, 157)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox4.TabIndex = 4
        Me.CheckBox4.Text = "接带人"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(31, 123)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "送带人"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(31, 91)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "送带时间"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(31, 59)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "时长"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 12)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "选择查询要显示的列"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ButtonTestFigurePrintConn)
        Me.TabPage5.Controls.Add(Me.TextBoxFigurePrintIP)
        Me.TabPage5.Controls.Add(Me.Label11)
        Me.TabPage5.Location = New System.Drawing.Point(4, 21)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(571, 305)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "指纹机设置"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ButtonTestFigurePrintConn
        '
        Me.ButtonTestFigurePrintConn.Location = New System.Drawing.Point(97, 119)
        Me.ButtonTestFigurePrintConn.Name = "ButtonTestFigurePrintConn"
        Me.ButtonTestFigurePrintConn.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTestFigurePrintConn.TabIndex = 2
        Me.ButtonTestFigurePrintConn.Text = "测试连接"
        Me.ButtonTestFigurePrintConn.UseVisualStyleBackColor = True
        '
        'TextBoxFigurePrintIP
        '
        Me.TextBoxFigurePrintIP.Location = New System.Drawing.Point(97, 37)
        Me.TextBoxFigurePrintIP.Name = "TextBoxFigurePrintIP"
        Me.TextBoxFigurePrintIP.Size = New System.Drawing.Size(98, 21)
        Me.TextBoxFigurePrintIP.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 12)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "IP地址"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.CheckBoxUseCamera)
        Me.TabPage6.Location = New System.Drawing.Point(4, 21)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(571, 305)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "摄像头"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'CheckBoxUseCamera
        '
        Me.CheckBoxUseCamera.AutoSize = True
        Me.CheckBoxUseCamera.Location = New System.Drawing.Point(31, 30)
        Me.CheckBoxUseCamera.Name = "CheckBoxUseCamera"
        Me.CheckBoxUseCamera.Size = New System.Drawing.Size(84, 16)
        Me.CheckBoxUseCamera.TabIndex = 0
        Me.CheckBoxUseCamera.Text = "使用摄像头"
        Me.CheckBoxUseCamera.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 12)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "片头审核点时长（单位：秒）"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 12)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "片尾审核点时长（单位：秒）"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 12)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "片中审核点时长（单位：秒）"
        '
        'NumericUpDownHeadLen
        '
        Me.NumericUpDownHeadLen.Location = New System.Drawing.Point(190, 41)
        Me.NumericUpDownHeadLen.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDownHeadLen.Name = "NumericUpDownHeadLen"
        Me.NumericUpDownHeadLen.Size = New System.Drawing.Size(63, 21)
        Me.NumericUpDownHeadLen.TabIndex = 14
        '
        'NumericUpDownMiddLen
        '
        Me.NumericUpDownMiddLen.Location = New System.Drawing.Point(190, 73)
        Me.NumericUpDownMiddLen.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDownMiddLen.Name = "NumericUpDownMiddLen"
        Me.NumericUpDownMiddLen.Size = New System.Drawing.Size(63, 21)
        Me.NumericUpDownMiddLen.TabIndex = 15
        '
        'NumericUpDownTailLen
        '
        Me.NumericUpDownTailLen.Location = New System.Drawing.Point(190, 108)
        Me.NumericUpDownTailLen.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDownTailLen.Name = "NumericUpDownTailLen"
        Me.NumericUpDownTailLen.Size = New System.Drawing.Size(63, 21)
        Me.NumericUpDownTailLen.TabIndex = 16
        '
        'Setting
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(603, 386)
        Me.Controls.Add(Me.tabsetting)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Setting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "设置"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tabsetting.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.NumericUpDownHeadLen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMiddLen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTailLen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents tabsetting As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonTestDBConn As System.Windows.Forms.Button
    Friend WithEvents TextBoxDBName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDBPawd As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDBUser As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDBAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButtonTestFigurePrintConn As System.Windows.Forms.Button
    Friend WithEvents TextBoxFigurePrintIP As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBoxUseCamera As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownHeadLen As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownTailLen As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownMiddLen As System.Windows.Forms.NumericUpDown

End Class
