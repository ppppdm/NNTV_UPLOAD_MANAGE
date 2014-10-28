Imports System.Data.SqlClient

Public Class Setting
    Private _dbReset = False
    Private _figurePrintRest = False

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles OK_Button.Click
        '重置DNS变量
        If _dbReset = True Then
            DbServer = TextBoxDBAddr.Text
            DbUser = TextBoxDBUser.Text
            DbPawd = TextBoxDBPawd.Text
            DbDbNamme = TextBoxDBName.Text

            ConnStr = "Server=" & DbServer & ";Database=" & DbDbNamme & _
                      ";User ID=" & DbUser & ";Password=" & DbPawd & ";"
        End If

        '重新设置指纹机相关变量
        If _figurePrintRest = True Then
            FigurePrintIP = TextBoxFigurePrintIP.Text
        End If

        '重新设置摄像头使用
        UseCamera = CheckBoxUseCamera.Checked

        '重新设置审核点时长
        CheckHeadLen = NumericUpDownHeadLen.Value
        CheckMiddLen = NumericUpDownMiddLen.Value
        CheckTailLen = NumericUpDownTailLen.Value

        '重新设置高级查询条件
        AdvancedOptions.AoNotUpload.Value = CheckBoxNotUpload.Checked
        AdvancedOptions.AoNotCheckUp.Value = CheckBoxNotCheckup.Checked
        AdvancedOptions.AoHadCheckUp.Value = CheckBoxHadCheckup.Checked


        '将以上变量写入到配置文件工具
        CFUtil.Write("DB", "Server", DbServer)
        CFUtil.Write("DB", "Database", DbDbNamme)
        CFUtil.Write("DB", "User", DbUser)
        CFUtil.Write("DB", "PassWord", DbPawd)

        CFUtil.Write("FigurePrint", "IP", FigurePrintIP)

        CFUtil.Write("Camera", "IsUse", UseCamera.ToString)

        CFUtil.Write("Check", "HeadLen", CheckHeadLen.ToString)
        CFUtil.Write("Check", "MiddLen", CheckMiddLen.ToString)
        CFUtil.Write("Check", "TailLen", CheckTailLen.ToString)

        CFUtil.Write("QueryAdvancedOptions", "NotUpload", AdvancedOptions.AoNotUpload.Value.ToString)
        CFUtil.Write("QueryAdvancedOptions", "NotCheckUp", AdvancedOptions.AoNotCheckUp.Value.ToString)
        CFUtil.Write("QueryAdvancedOptions", "HadCheckUp", AdvancedOptions.AoHadCheckUp.Value.ToString)

        '刷新数据到配置文件中
        CFUtil.FlushToFile()

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, _
                                    ByVal e As EventArgs) _
        Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Setting_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load

        '各setting的值已经在QueryForm.Loaded中的函数InitGlobalVariables()初始化

        '初始化数据库设置页面
        TextBoxDBAddr.Text = DbServer
        TextBoxDBUser.Text = DbUser
        TextBoxDBPawd.Text = DbPawd
        TextBoxDBName.Text = DbDbNamme

        '初始化审核点设置页面
        NumericUpDownHeadLen.Value = CheckHeadLen
        NumericUpDownMiddLen.Value = CheckMiddLen
        NumericUpDownTailLen.Value = CheckTailLen

        '初始化查询高级选项
        CheckBoxNotUpload.Checked = AdvancedOptions.AoNotUpload.Value
        CheckBoxNotCheckup.Checked = AdvancedOptions.AoNotCheckUp.Value
        CheckBoxHadCheckup.Checked = AdvancedOptions.AoHadCheckUp.Value


        '初始化显示查询设置


        '初始化指纹机设置
        TextBoxFigurePrintIP.Text = FigurePrintIP

        '初始化摄像头设置
        CheckBoxUseCamera.Checked = UseCamera

        '将确定按钮enable设置为false
        OK_Button.Enabled = False
    End Sub

    Private Sub ButtonTestDBConn_Click(ByVal sender As Object, _
                                       ByVal e As EventArgs) _
        Handles ButtonTestDBConn.Click
        ConnStr = "Server=" & TextBoxDBAddr.Text & ";Database=" & _
                  TextBoxDBName.Text & ";User ID=" & TextBoxDBUser.Text & _
                  ";Password=" & TextBoxDBPawd.Text & ";"
        Dim connection As New SqlConnection(ConnStr)

        Try
            '打开数据库
            connection.Open()
            MsgBox("连接数据库成功")
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "DB Error")
        End Try
    End Sub

    Private Sub ButtonTestFigurePrintConn_Click(ByVal sender As Object, _
                                                ByVal e As EventArgs) _
        Handles ButtonTestFigurePrintConn.Click
        Dim axCZKEM1 As New CZKEM
        Dim ip = TextBoxFigurePrintIP.Text
        Dim ipPort = FigurePrintPort
        If axCZKEM1.Connect_Net(ip, Convert.ToInt32(ipPort)) Then
            MsgBox("连接指纹机成功")
        Else
            MsgBox("连接指纹机失败")
        End If

        axCZKEM1.Disconnect()
    End Sub

    Private Sub TextBoxDBAddr_TextChanged(ByVal sender As Object, _
                                          ByVal e As EventArgs) _
        Handles TextBoxDBAddr.TextChanged
        OK_Button.Enabled = True
        _dbReset = True
    End Sub

    Private Sub TextBoxDBName_TextChanged(ByVal sender As Object, _
                                          ByVal e As EventArgs) _
        Handles TextBoxDBName.TextChanged
        OK_Button.Enabled = True
        _dbReset = True
    End Sub

    Private Sub TextBoxDBPawd_TextChanged(ByVal sender As Object, _
                                          ByVal e As EventArgs) _
        Handles TextBoxDBPawd.TextChanged
        OK_Button.Enabled = True
        _dbReset = True
    End Sub

    Private Sub TextBoxDBUser_TextChanged(ByVal sender As Object, _
                                          ByVal e As EventArgs) _
        Handles TextBoxDBUser.TextChanged
        OK_Button.Enabled = True
        _dbReset = True
    End Sub

    Private Sub TextBoxFigurePrintIP_TextChanged(ByVal sender As Object, _
                                                 ByVal e As EventArgs) _
        Handles TextBoxFigurePrintIP.TextChanged
        OK_Button.Enabled = True
        _figurePrintRest = True
    End Sub

    Private Sub CheckBoxUseCamera_CheckedChanged(ByVal sender As Object, _
                                                 ByVal e As EventArgs) _
        Handles CheckBoxUseCamera.CheckedChanged
        OK_Button.Enabled = True
    End Sub

    Private Sub NumericUpDownHeadLen_ValueChanged(ByVal sender As Object, _
                                                  ByVal e As EventArgs) _
        Handles NumericUpDownHeadLen.ValueChanged
        OK_Button.Enabled = True
    End Sub

    Private Sub NumericUpDownMiddLen_ValueChanged(ByVal sender As Object, _
                                                  ByVal e As EventArgs) _
        Handles NumericUpDownMiddLen.ValueChanged
        OK_Button.Enabled = True
    End Sub

    Private Sub NumericUpDownTailLen_ValueChanged(ByVal sender As Object, _
                                                  ByVal e As EventArgs) _
        Handles NumericUpDownTailLen.ValueChanged
        OK_Button.Enabled = True
    End Sub

    Private Sub CheckBoxNotUpload_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxNotUpload.CheckedChanged
        OK_Button.Enabled = True
    End Sub

    Private Sub CheckBoxNotCheckup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxNotCheckup.CheckedChanged
        OK_Button.Enabled = True
    End Sub

    Private Sub CheckBoxHadCheckup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxHadCheckup.CheckedChanged
        OK_Button.Enabled = True
    End Sub
End Class
