Imports System.Data.SqlClient

Public Class TapeRecOnlyRecv

    Private _tapeId As Guid = Nothing

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, _
                                   ByVal e As EventArgs) _
        Handles ButtonCancel.Click
        Dispose()
    End Sub

    Private Sub TapeRecOnlyRecv_Load(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles Me.Load
        '初始化_tapeId
        _tapeId = QueryForm.TapeId

        '设置tape信息
        If Not _tapeId = Nothing Then
            SetTapeInfo()
        End If
    End Sub

    Private Sub SetTapeInfo()
        Dim queryString As String = "select tape_name, " & "in_bc_time, " & _
                                    "start_timecode, " & "end_timecode, " & _
                                    "length, " & "program_type, " & "channel, " & _
                                    "identical, " & _
                                    "remark, " & "in_bc_send_per, " & "media_type " & _
                                    "from tape " & "where id='" & _
                                    _tapeId.ToString() & "'"

        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)
        Dim command As SqlCommand = New SqlCommand(queryString, sqlconn)
        Dim reader As SqlDataReader
        Dim inbcsttimecode As String
        Dim inbclengthcode As String
        Dim inbcendtimecode As String
        Dim arr() As String

        Try
            sqlconn.Open()
            reader = command.ExecuteReader()

            If (reader.Read()) Then
                TextBoxTapeName.Text = reader("tape_name")
                ComboBoxProgramType.Text = reader("program_type")
                ComboBoxChannel.Text = reader("channel")
                ComboBoxMediaType.Text = reader("media_type")
                TextBoxRecvTime.Text = reader("in_bc_time")
                TextBoxSendPerson.Text = reader("in_bc_send_per")
                TextBoxRemark.Text = reader("remark")
                CheckBoxTape.Checked = reader("identical")
                inbcsttimecode = reader("start_timecode")
                inbclengthcode = reader("length")
                inbcendtimecode = reader("end_timecode")

                '显示创建的起始时码
                arr = inbcsttimecode.Split(":")
                TextBoxStartTimeH.Text = arr(0)
                TextBoxStartTimeM.Text = arr(1)
                TextBoxStartTimeS.Text = arr(2)
                TextBoxStartTimeF.Text = arr(3)

                '显示创建的时长
                arr = inbclengthcode.Split(":")
                TextBoxLengthH.Text = arr(0)
                TextBoxLengthM.Text = arr(1)
                TextBoxLengthS.Text = arr(2)
                TextBoxLengthF.Text = arr(3)

                '显示创建的终止时码
                arr = inbcendtimecode.Split(":")
                TextBoxEndTimeH.Text = arr(0)
                TextBoxEndTimeM.Text = arr(1)
                TextBoxEndTimeS.Text = arr(2)
                TextBoxEndTimeF.Text = arr(3)
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As Object, _
                               ByVal e As EventArgs) _
                               Handles ButtonOK.Click
        Dim id = _tapeId
        Dim tapeName = TextBoxTapeName.Text
        Dim startTimecode = TextBoxStartTimeH.Text & ":" & _
                            TextBoxStartTimeM.Text & ":" & _
                            TextBoxStartTimeS.Text & ":" & _
                            TextBoxStartTimeF.Text
        Dim endTimecode = TextBoxEndTimeH.Text & ":" & TextBoxEndTimeM.Text & _
                          ":" & TextBoxEndTimeS.Text & ":" & _
                          TextBoxEndTimeF.Text
        Dim length = TextBoxLengthH.Text & ":" & TextBoxLengthM.Text & ":" & _
                     TextBoxLengthS.Text & ":" & TextBoxLengthF.Text
        Dim inBcTime = TextBoxRecvTime.Text
        Dim inBcSendPer = TextBoxSendPerson.Text
        Dim inBcRecvPer = TextBoxRecvPerson.Text
        Dim remark = TextBoxRemark.Text
        Dim identical = CheckBoxTape.Checked
        Dim channel = ComboBoxChannel.Text
        Dim programType = ComboBoxProgramType.Text
        Dim mediaType = ComboBoxMediaType.Text

        Dim connection As New SqlConnection(ConnStr)

        Dim paras() As SqlParameter = _
                {New SqlParameter("@id", id), _
                 New SqlParameter("@tape_name", tapeName), _
                 New SqlParameter("@start_timecode", startTimecode), _
                 New SqlParameter("@end_timecode", endTimecode), _
                 New SqlParameter("@length", length), _
                 New SqlParameter("@in_bc_send_per", inBcSendPer), _
                 New SqlParameter("@in_bc_recv_per", inBcRecvPer), _
                 New SqlParameter("@in_bc_time", inBcTime), _
                 New SqlParameter("@remark", remark), _
                 New SqlParameter("@tape_status", StatusNotUpload), _
                 New SqlParameter("@program_type", programType), _
                 New SqlParameter("@identical", identical), _
                 New SqlParameter("@media_type", mediaType), _
                 New SqlParameter("@channel", channel)}


        Const queryString As String = "update tape set( " & _
        "tape_name=@tape_name, " & _
        "start_timecode=@start_timecode, " & _
        "end_timecode=@end_timecode, " & _
        "length=@length, " & _
        "in_bc_send_per=@in_bc_send_per, " & _
        "in_bc_recv_per=@in_bc_recv_per, " & _
        "remark=@remark, " & _
        "tape_status=@tape_status, " & _
        "program_type=@program_type, " & _
        "identical=@identical, " & _
        "media_type=@media_type, " & _
        "channel=@channel )" & _
        "where " & _
        "id=@id"

        Dim command As New SqlCommand(queryString, connection)

        command.Parameters.AddRange(paras)

        Console.WriteLine(queryString)

        Try
            '打开数据库
            connection.Open()
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

        Dispose()
    End Sub

    '输入时码时调用函数验证输入、计算出点、切换输入焦点
    Private Sub TextBoxStartTimeH_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxStartTimeH.TextChanged
        TimeInputCheck(TextBoxStartTimeH, TextBoxStartTimeM, 99, False)
    End Sub

    Private Sub TextBoxStartTimeM_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxStartTimeM.TextChanged
        TimeInputCheck(TextBoxStartTimeM, TextBoxStartTimeS, 60, False)
    End Sub

    Private Sub TextBoxStartTimeS_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxStartTimeS.TextChanged
        TimeInputCheck(TextBoxStartTimeS, TextBoxStartTimeF, 60, False)
    End Sub

    Private Sub TextBoxStartTimeF_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxStartTimeF.TextChanged
        TimeInputCheck(TextBoxStartTimeF, TextBoxLengthH, 25, False)
    End Sub

    Private Sub TextBoxLengthH_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxLengthH.TextChanged
        TimeInputCheck(TextBoxLengthH, TextBoxLengthM, 99, True)
    End Sub

    Private Sub TextBoxLengthM_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxLengthM.TextChanged
        TimeInputCheck(TextBoxLengthM, TextBoxLengthS, 60, True)
    End Sub

    Private Sub TextBoxLengthS_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxLengthS.TextChanged
        TimeInputCheck(TextBoxLengthS, TextBoxLengthF, 60, True)
    End Sub

    Private Sub TextBoxLengthF_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxLengthF.TextChanged
        If IsNumeric(TextBoxLengthF.Text) Then
            CalcEndTime()
            If TextBoxLengthF.TextLength = 2 Then
                If _
                    CInt(TextBoxLengthF.Text) >= 25 Or _
                    CInt(TextBoxLengthF.Text) < 0 Then
                    TextBoxLengthF.Text = "00"
                    TextBoxLengthF.SelectAll()
                End If
            End If
        Else
            TextBoxLengthF.Text = "00"
            TextBoxLengthF.SelectAll()
        End If
    End Sub

    '计算出点
    Private Sub CalcEndTime()
        If _
            (ComboBoxMediaType.SelectedIndex <= 1) And _
            IsNumeric(TextBoxLengthF.Text) And IsNumeric(TextBoxLengthS.Text) And _
            IsNumeric(TextBoxLengthM.Text) And IsNumeric(TextBoxLengthH.Text) And _
            IsNumeric(TextBoxStartTimeF.Text) And _
            IsNumeric(TextBoxStartTimeS.Text) And _
            IsNumeric(TextBoxStartTimeM.Text) And _
            IsNumeric(TextBoxStartTimeH.Text) Then
            Dim endTimeH = 0, _
                endTimeM = 0, _
                endTimeS = 0, _
                endTimeF As Integer
            If _
                CInt( _
                    TextBoxLengthH.Text & TextBoxLengthM.Text & _
                    TextBoxLengthS.Text & TextBoxLengthF.Text) <> 0 Then
                endTimeF = CInt(TextBoxStartTimeF.Text) + _
                           CInt(TextBoxLengthF.Text) - 1 '帧相加
                If endTimeF > 24 Then '进位
                    endTimeS += 1
                    endTimeF -= 25
                ElseIf endTimeF < 0 Then '借位
                    endTimeS -= 1
                    endTimeF += 25
                End If
                endTimeS += CInt(TextBoxStartTimeS.Text) + _
                            CInt(TextBoxLengthS.Text)    '秒相加
                If endTimeS > 59 Then
                    endTimeM += 1
                    endTimeS -= 60
                ElseIf endTimeS < 0 Then
                    endTimeM -= 1
                    endTimeS += 60
                End If
                endTimeM += CInt(TextBoxStartTimeM.Text) + _
                            CInt(TextBoxLengthM.Text)    '分相加
                If endTimeM > 59 Then
                    endTimeH += 1
                    endTimeM -= 60
                ElseIf endTimeM < 0 Then
                    endTimeH -= 1
                    endTimeM += 60
                End If
                endTimeH += CInt(TextBoxStartTimeH.Text) + _
                            CInt(TextBoxLengthH.Text)    '时相加
                '输出，不足2位的补0
                TextBoxEndTimeF.Text = _
                    Microsoft.VisualBasic.Right("00" & endTimeF, 2) _
                '结果的左边补2个0后取右边2位
                TextBoxEndTimeS.Text = _
                    Microsoft.VisualBasic.Right("00" & endTimeS, 2)
                TextBoxEndTimeM.Text = _
                    Microsoft.VisualBasic.Right("00" & endTimeM, 2)
                TextBoxEndTimeH.Text = _
                    Microsoft.VisualBasic.Right("00" & endTimeH, 2)
            Else '时长为0,结束时码与开始时码相同
                TextBoxEndTimeF.Text = TextBoxStartTimeF.Text
                TextBoxEndTimeS.Text = TextBoxStartTimeS.Text
                TextBoxEndTimeM.Text = TextBoxStartTimeM.Text
                TextBoxEndTimeH.Text = TextBoxStartTimeH.Text
            End If
        End If
    End Sub

    '输入时码后计算出点，输入焦点跳到下一个框
    Private Sub TimeInputCheck(ByRef thisTextTox As TextBox, _
                               ByRef nextTextBox As TextBox, _
                               ByVal maxNum As Integer, _
                               ByVal isLength As Boolean)
        If IsNumeric(thisTextTox.Text) Then
            CalcEndTime()   '计算出点
            If thisTextTox.TextLength = 2 Then
                If _
                    CInt(thisTextTox.Text) <= maxNum And _
                    CInt(thisTextTox.Text) >= 0 Then
                    nextTextBox.Focus()
                    nextTextBox.SelectAll()
                Else
                    thisTextTox.Text = "00"   '输入错误，改回00
                    thisTextTox.Focus()
                End If
            End If
        ElseIf ComboBoxMediaType.SelectedIndex <= 1 Or isLength Then
            thisTextTox.Text = "00"
            thisTextTox.Focus()
        End If
    End Sub

    '点击时码输入框时全选内容
    Private Sub TextBoxStartTimeH_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxStartTimeH.Click
        TextBoxStartTimeH.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeM_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxStartTimeM.Click
        TextBoxStartTimeM.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeS_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxStartTimeS.Click
        TextBoxStartTimeS.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeF_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxStartTimeF.Click
        TextBoxStartTimeF.SelectAll()
    End Sub

    Private Sub TextBoxLengthH_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxLengthH.Click
        TextBoxLengthH.SelectAll()
    End Sub

    Private Sub TextBoxLengthM_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxLengthM.Click
        TextBoxLengthM.SelectAll()
    End Sub

    Private Sub TextBoxLengthS_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxLengthS.Click
        TextBoxLengthS.SelectAll()
    End Sub

    Private Sub TextBoxLengthF_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxLengthF.Click
        TextBoxLengthF.SelectAll()
    End Sub
End Class