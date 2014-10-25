Imports System.Windows.Forms
Imports System.Threading.thread

Public Class PictrueLarge

    Private Sub OK_Button_Click _
        (ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click _
        (ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Private Sub PictrueLarge_MouseLeave _
    '    (ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
    '    Sleep(1000)
    '    Me.Dispose()
    'End Sub


    Private Sub PictrueLarge_Load _
        (ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '将窗口位置居中
        Me.Left = (My.Computer.Screen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2

        PictureBox1.Image = PictrueBmp
    End Sub
End Class
