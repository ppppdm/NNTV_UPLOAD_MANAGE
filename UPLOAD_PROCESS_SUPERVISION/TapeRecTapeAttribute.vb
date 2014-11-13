Public Class TapeRecTapeAttribute

    Public Event ButtonCloseClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        MessageBox.Show("Are you sure ?")
        Dispose()
        RaiseEvent ButtonCloseClick(sender, e)
    End Sub
End Class
