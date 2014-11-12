Public Class UserControl1

    Public LabelText As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        MessageBox.Show("Are you sure ?")
        Dispose()
    End Sub
End Class
