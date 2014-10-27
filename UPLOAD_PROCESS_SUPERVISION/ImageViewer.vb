Public Class ImageViewer

    Public PictrueBmpList As List(Of System.Drawing.Image) = New List(Of System.Drawing.Image)()
    Private count As Integer = 0
    Private _movePanel As Boolean = False
    Private _downX, _downY As Integer

    Private Sub ImageViewer_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        PictrueBmpList.Clear()
    End Sub


    Private Sub ImageViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If PictrueBmpList.Count = 0 Then
            PictrueBmpList.Add(UploadProcessSupervision.My.Resources.Resources.car)
        End If

        Panel1.BackgroundImage = PictrueBmpList.Item(count)

        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.BackgroundImage = Nothing
        Button2.BackgroundImage = Nothing
        Button3.BackgroundImage = Nothing
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        count += 1
        If count = PictrueBmpList.Count Then
            count = 0
        End If
        Panel1.BackgroundImage = PictrueBmpList.Item(count)

    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.BackgroundImage = UploadProcessSupervision.My.Resources.Resources.right
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackgroundImage = Nothing
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = UploadProcessSupervision.My.Resources.Resources.close2
        Button1.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = Nothing
        Button1.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        count -= 1
        If count < 0 Then
            count = PictrueBmpList.Count - 1
        End If
        Panel1.BackgroundImage = PictrueBmpList.Item(count)
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackgroundImage = UploadProcessSupervision.My.Resources.Resources.left
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = Nothing
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        _downX = e.Location.X
        _downY = e.Location.Y

    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Forms.MouseButtons.Left Then
            Panel1.Left += e.Location.X - _downX
            Panel1.Top += e.Location.Y - _downY
        End If
    End Sub

    Private Sub Panel1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseWheel
        Dim scale As Double = 1
        If Panel1.Height + e.Delta > 0 Then
            scale = Panel1.Width / Panel1.Height

            Panel1.Width += e.Delta * scale
            Panel1.Height += e.Delta
            Panel1.Left -= e.Delta * scale / 2
            Panel1.Top -= e.Delta / 2
            Console.WriteLine("scale {0}", scale)
            Console.WriteLine("delata {0}", e.Delta)
            Console.WriteLine("Width {0}", Panel1.Width)
            Console.WriteLine("Height {0}", Panel1.Height)
            Console.WriteLine("Left {0}", Panel1.Left)
            Console.WriteLine("Top {0}", Panel1.Top)
        Else

        End If
    End Sub


End Class