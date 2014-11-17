Public Class TapeRecTapeAttribute

    Public Event ButtonCloseClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'Property pTextBoxLengthH() As TextBox
    '    Get
    '        Return Me.TextBoxLengthH
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxLengthH = value
    '    End Set
    'End Property

    'Property pTextBoxLengthM() As TextBox
    '    Get
    '        Return Me.TextBoxLengthM
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxLengthM = value
    '    End Set
    'End Property

    'Property pTextBoxLengthS() As TextBox
    '    Get
    '        Return Me.TextBoxLengthS
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxLengthS = value
    '    End Set
    'End Property

    'Property pTextBoxLengthF() As TextBox
    '    Get
    '        Return Me.TextBoxLengthF
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxLengthF = value
    '    End Set
    'End Property

    'Property pTextBoxStartTimeH() As TextBox
    '    Get
    '        Return Me.TextBoxStartTimeH
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxStartTimeH = value
    '    End Set
    'End Property

    'Property pTextBoxStartTimeM() As TextBox
    '    Get
    '        Return Me.TextBoxStartTimeM
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxStartTimeM = value
    '    End Set
    'End Property

    'Property pTextBoxStartTimeS() As TextBox
    '    Get
    '        Return Me.TextBoxStartTimeS
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxStartTimeS = value
    '    End Set
    'End Property

    'Property pTextBoxStartTimeF() As TextBox
    '    Get
    '        Return Me.TextBoxStartTimeF
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxStartTimeF = value
    '    End Set
    'End Property

    'Property pTextBoxEndTimeH() As TextBox
    '    Get
    '        Return Me.TextBoxEndTimeH
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxEndTimeH = value
    '    End Set
    'End Property

    'Property pTextBoxEndTimeM() As TextBox
    '    Get
    '        Return Me.TextBoxEndTimeM
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxEndTimeM = value
    '    End Set
    'End Property

    'Property pTextBoxEndTimeS() As TextBox
    '    Get
    '        Return Me.TextBoxEndTimeS
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxEndTimeS = value
    '    End Set
    'End Property

    'Property pTextBoxEndTimeF() As TextBox
    '    Get
    '        Return Me.TextBoxEndTimeF
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxEndTimeF = value
    '    End Set
    'End Property

    'Property pButtonClose() As Button
    '    Get
    '        Return Me.ButtonClose
    '    End Get
    '    Set(ByVal value As Button)
    '        Me.ButtonClose = value
    '    End Set
    'End Property

    'Property pTextBoxTapeName() As TextBox
    '    Get
    '        Return Me.TextBoxTapeName
    '    End Get
    '    Set(ByVal value As TextBox)
    '        Me.TextBoxTapeName = value
    '    End Set
    'End Property

    'Property pComboBoxProgramType() As ComboBox
    '    Get
    '        Return Me.ComboBoxProgramType
    '    End Get
    '    Set(ByVal value As ComboBox)
    '        Me.ComboBoxProgramType = value
    '    End Set
    'End Property

    'Property pComboBoxChannel() As ComboBox
    '    Get
    '        Return Me.ComboBoxChannel
    '    End Get
    '    Set(ByVal value As ComboBox)
    '        Me.ComboBoxChannel = value
    '    End Set
    'End Property

    'Property pComboBoxMediaType() As ComboBox
    '    Get
    '        Return Me.ComboBoxMediaType
    '    End Get
    '    Set(ByVal value As ComboBox)
    '        Me.ComboBoxMediaType = value
    '    End Set
    'End Property

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Dispose()
        RaiseEvent ButtonCloseClick(Me, e)
    End Sub

    Private Sub TapeRecTapeAttribute_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ComboBoxMediaType.SelectedIndex = 0

        SetStartTimeZero()
        SetLengthZero()
    End Sub

    Private Sub SetLengthZero() '时长设为0
        TextBoxLengthH.Text = "00"
        TextBoxLengthM.Text = "00"
        TextBoxLengthS.Text = "00"
        TextBoxLengthF.Text = "00"
    End Sub

    Private Sub SetStartTimeZero() '开始时码设为0
        TextBoxStartTimeH.Text = "00"
        TextBoxStartTimeM.Text = "00"
        TextBoxStartTimeS.Text = "00"
        TextBoxStartTimeF.Text = "00"
    End Sub

    '输入时码时调用函数验证输入、计算出点、切换输入焦点
    Private Sub TextBoxStartTimeH_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) Handles TextBoxStartTimeH.TextChanged

        TimeInputCheck(TextBoxStartTimeH, TextBoxStartTimeM, 99, False)
    End Sub

    Private Sub TextBoxStartTimeM_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) Handles TextBoxStartTimeM.TextChanged

        TimeInputCheck(TextBoxStartTimeM, TextBoxStartTimeS, 60, False)
    End Sub

    Private Sub TextBoxStartTimeS_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) Handles TextBoxStartTimeS.TextChanged

        TimeInputCheck(TextBoxStartTimeS, TextBoxStartTimeF, 60, False)
    End Sub

    Private Sub TextBoxStartTimeF_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) Handles TextBoxStartTimeF.TextChanged

        TimeInputCheck(TextBoxStartTimeF, TextBoxLengthH, 25, False)
    End Sub

    Private Sub TextBoxLengthH_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) Handles TextBoxLengthH.TextChanged

        TimeInputCheck(TextBoxLengthH, TextBoxLengthM, 99, True)
    End Sub

    Private Sub TextBoxLengthM_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) Handles TextBoxLengthM.TextChanged

        TimeInputCheck(TextBoxLengthM, TextBoxLengthS, 60, True)
    End Sub

    Private Sub TextBoxLengthS_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) Handles TextBoxLengthS.TextChanged

        TimeInputCheck(TextBoxLengthS, TextBoxLengthF, 60, True)
    End Sub

    Private Sub TextBoxLengthF_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) Handles TextBoxLengthF.TextChanged

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
                                        ByVal e As EventArgs) Handles TextBoxStartTimeH.Click

        TextBoxStartTimeH.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeM_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) Handles TextBoxStartTimeM.Click

        TextBoxStartTimeM.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeS_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) Handles TextBoxStartTimeS.Click

        TextBoxStartTimeS.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeF_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) Handles TextBoxStartTimeF.Click

        TextBoxStartTimeF.SelectAll()
    End Sub

    Private Sub TextBoxLengthH_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) Handles TextBoxLengthH.Click

        TextBoxLengthH.SelectAll()
    End Sub

    Private Sub TextBoxLengthM_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) Handles TextBoxLengthM.Click

        TextBoxLengthM.SelectAll()
    End Sub

    Private Sub TextBoxLengthS_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) Handles TextBoxLengthS.Click

        TextBoxLengthS.SelectAll()
    End Sub

    Private Sub TextBoxLengthF_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) Handles TextBoxLengthF.Click

        TextBoxLengthF.SelectAll()
    End Sub

    Private Sub ComboBoxMediaType_SelectedIndexChanged( _
                                                       ByVal sender As _
                                                          Object, _
                                                       ByVal e As _
                                                          EventArgs)

        If ComboBoxMediaType.SelectedIndex > 1 Then '非编上载
            TextBoxStartTimeH.Text = ""
            TextBoxStartTimeM.Text = ""
            TextBoxStartTimeS.Text = ""
            TextBoxStartTimeF.Text = ""
            TextBoxEndTimeH.Text = ""
            TextBoxEndTimeM.Text = ""
            TextBoxEndTimeS.Text = ""
            TextBoxEndTimeF.Text = ""
            TextBoxStartTimeH.ReadOnly = True
            TextBoxStartTimeM.ReadOnly = True
            TextBoxStartTimeS.ReadOnly = True
            TextBoxStartTimeF.ReadOnly = True
        Else '磁带采集
            TextBoxStartTimeH.Text = "00"
            TextBoxStartTimeM.Text = "00"
            TextBoxStartTimeS.Text = "00"
            TextBoxStartTimeF.Text = "00"
            CalcEndTime()
            TextBoxStartTimeH.ReadOnly = False
            TextBoxStartTimeM.ReadOnly = False
            TextBoxStartTimeS.ReadOnly = False
            TextBoxStartTimeF.ReadOnly = False
        End If

        ComboBoxMediaType.Focus()
    End Sub
End Class
