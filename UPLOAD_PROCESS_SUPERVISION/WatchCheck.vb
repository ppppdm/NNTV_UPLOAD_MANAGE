Imports System.data.SqlClient
Imports System.io

Public Class WatchCheck

    Private _materialId As Guid

    Private Sub WatchCheck_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        _materialId = QueryForm.MaterialId

        '从数据库中查询审核数据
        Const queryString = "select " & _
        "tape_name, " & _
        "length, " & _
        "check_point1_timecode, " & _
        "check_point2_timecode, " & _
        "check_point3_timecode, " & _
        "date_or_episode_check, " & _
        "sound_picture_sync, " & _
        "volume_check, " & _
        "check_point1_screenshot, " & _
        "check_point2_screenshot, " & _
        "check_point3_screenshot, " & _
        "episode_screenshot, " & _
        "check_person, " & _
        "check_time " & _
        "from checkup " & _
        "where " & _
        "material_id = @material_id"


        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)

        Dim com As SqlCommand = New SqlCommand(queryString, sqlconn)
        com.Parameters.Add(New SqlParameter("@material_id", _materialId))

        Try
            sqlconn.Open()
            Dim reader = com.ExecuteReader()
            If reader.read() Then
                TextBoxMaterialName.Text = reader("tape_name")
                LabelLength.Text = reader("length")
                LabelCheckPoint1.Text = reader("check_point1_timecode")
                LabelCheckPoint2.Text = reader("check_point2_timecode")
                LabelCheckPoint3.Text = reader("check_point3_timecode")
                LabelDateOrEpisode.Text = reader("date_or_episode_check")
                LabelSoundPicSync.Text = reader("sound_picture_sync")
                LabelVolume.Text = reader("volume_check")
                LabelChecker.Text = reader("check_person")
                LabelCheckTime.Text = reader("check_time")


                If Not TypeName(reader("check_point1_screenshot")) = "DBNull" Then
                    Dim buffer1() As Byte = reader("check_point1_screenshot")
                    Dim ms1 As MemoryStream = New MemoryStream()
                    ms1.Write(buffer1, 0, buffer1.Length)
                    PictureBoxCheckPoint1.Image = New Bitmap(ms1)
                End If

                If Not TypeName(reader("check_point2_screenshot")) = "DBNull" Then
                    Dim buffer1() As Byte = reader("check_point2_screenshot")
                    Dim ms1 As MemoryStream = New MemoryStream()
                    ms1.Write(buffer1, 0, buffer1.Length)
                    PictureBoxCheckPoint2.Image = New Bitmap(ms1)
                End If

                If Not TypeName(reader("check_point3_screenshot")) = "DBNull" Then
                    Dim buffer1() As Byte = reader("check_point3_screenshot")
                    Dim ms1 As MemoryStream = New MemoryStream()
                    ms1.Write(buffer1, 0, buffer1.Length)
                    PictureBoxCheckPoint3.Image = New Bitmap(ms1)
                End If

                If Not TypeName(reader("episode_screenshot")) = "DBNull" Then
                    Dim buffer1() As Byte = reader("episode_screenshot")
                    Dim ms1 As MemoryStream = New MemoryStream()
                    ms1.Write(buffer1, 0, buffer1.Length)
                    PictureBoxEpisode.Image = New Bitmap(ms1)
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub PictureBoxCheckPoint1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxCheckPoint1.MouseHover
        If Not PictureBoxCheckPoint1.Image Is Nothing Then
            PictrueBmp = PictureBoxCheckPoint1.Image
            PictrueLarge.Show()
        End If
    End Sub

    Private Sub PictureBoxCheckPoint2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxCheckPoint2.MouseHover
        If Not PictureBoxCheckPoint2.Image Is Nothing Then
            PictrueBmp = PictureBoxCheckPoint2.Image
            PictrueLarge.Show()
        End If
    End Sub

    Private Sub PictureBoxCheckPoint3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxCheckPoint3.MouseHover
        If Not PictureBoxCheckPoint3.Image Is Nothing Then
            PictrueBmp = PictureBoxCheckPoint3.Image
            PictrueLarge.Show()
        End If
    End Sub

    Private Sub PictureBoxEpisode_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxEpisode.MouseHover
        If Not PictureBoxEpisode.Image Is Nothing Then
            PictrueBmp = PictureBoxEpisode.Image
            PictrueLarge.Show()
        End If
    End Sub
End Class