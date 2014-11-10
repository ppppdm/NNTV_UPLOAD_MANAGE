Public Class SendTapeInBatch

    Private Sub SendTapeInBatch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If CheckBoxTapeNamePrefix.Checked = True Then
            TextBoxTapeNamePrefix.Enabled = True
        Else
            TextBoxTapeNamePrefix.Enabled = False
        End If

        If CheckBoxTapeNameSuffix.Checked = True Then
            TextBoxTapeNameSuffix.Enabled = True
        Else
            TextBoxTapeNameSuffix.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxTapeNamePrefix_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTapeNamePrefix.CheckedChanged
        If CheckBoxTapeNamePrefix.Checked = True Then
            TextBoxTapeNamePrefix.Enabled = True
        Else
            TextBoxTapeNamePrefix.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxTapeNameSuffix_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTapeNameSuffix.CheckedChanged
        If CheckBoxTapeNameSuffix.Checked = True Then
            TextBoxTapeNameSuffix.Enabled = True
        Else
            TextBoxTapeNameSuffix.Enabled = False
        End If
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Dispose()
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click

    End Sub

    Private Function InterpertExpression(ByVal exp As String) As String
        ' 表达式符号包括"," "-" "*" "?"
        ' "," 逗号表示分隔多个
        ' "-" 表示从符号前的值到符号后的值,要求符号前的值小于符号后的值
        ' "*" 表示配备一个到多个字符
        ' "?" 表示匹配一个字符

        Return ""
    End Function

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownHeadSuf.ValueChanged


    End Sub
End Class