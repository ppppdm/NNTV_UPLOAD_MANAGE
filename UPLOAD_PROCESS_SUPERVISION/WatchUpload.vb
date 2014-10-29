Imports System.Data.SqlClient
Imports System.IO

Public Class WatchUpload
    Private _tapeId As Guid = Nothing

    Private Sub WatchUpload_Load(ByVal sender As Object, _
                                 ByVal e As EventArgs) Handles Me.Load

        _tapeId = QueryForm.TapeId

        '从数据库中查询上载数据
        Const queryString = "select " & "tape_name, " & "program_type, " & _
                            "start_timecode, " & "in_bc_send_per, " & _
                            "in_bc_recv_per, " & "end_timecode, " & _
                            "end_timecode, " & "end_timecode, " & "length " & _
                            "from tape " & "where " & "id = @id"

        Const queryString2 = "select " & "upload_time, " & "upload_per, " & _
                             "upload_pc, " & "screenshot, " & "camera " & _
                             "from upload " & "where " & "tape_id = @tape_id " & _
                             "and upload_status = 2 " & _
                             "order by upload_time desc "

        Dim sqlconn As SqlConnection = New SqlConnection(ConnStr)

        Dim com As SqlCommand = New SqlCommand(queryString, sqlconn)
        com.Parameters.Add(New SqlParameter("@id", _tapeId))

        Dim com2 As SqlCommand = New SqlCommand(queryString2, sqlconn)
        com2.Parameters.Add(New SqlParameter("@tape_id", _tapeId))

        Try
            sqlconn.Open()
            Dim reader = com.ExecuteReader()
            If (reader.read()) Then
                TextBoxTapeName.Text = reader("tape_name")
                LabelProgramTypeText.Text = reader("program_type")
                LabelStartTimeCodeText.Text = reader("start_timecode")
                LabelEndTimeCodeText.Text = reader("end_timecode")
                LabelLengthText.Text = reader("length")
            Else
                MsgBox("没有找到磁带信息")
            End If

            reader.close()

            reader = com2.ExecuteReader()
            If (reader.read()) Then
                LabelUploadTimeText.Text = reader("upload_time")
                LabelUploaderText.Text = reader("upload_per")
                LabelUploadMachineText.Text = reader("upload_pc")


                If Not TypeName(reader("screenshot")) = "DBNull" Then
                    Dim buffer1() As Byte = reader("screenshot")
                    Dim ms1 As MemoryStream = New MemoryStream()
                    ms1.Write(buffer1, 0, buffer1.Length)
                    PictureBoxScreenshot.Image = New Bitmap(ms1)
                End If

                'Dim fs As FileStream = New FileStream("watch_upload.bmp", FileMode.Create)
                'fs.Write(buffer, 0, buffer.Length)
                'fs.Close()

                If Not TypeName(reader("camera")) = "DBNull" Then
                    Dim buffer2() As Byte = reader("camera")
                    Dim ms2 As MemoryStream = New MemoryStream()
                    ms2.Write(buffer2, 0, buffer2.Length)
                    PictureBoxCamera.Image = New Bitmap(ms2)
                End If


            Else
                MsgBox("没有找到对于信息，可能是还没有上载")
            End If

            reader.close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub PictureBoxScreenshot_MouseDoubleClick(ByVal sender As Object, _
                                                      ByVal e As  _
                                                         MouseEventArgs) _
        Handles PictureBoxScreenshot.MouseDoubleClick
        If Not PictureBoxScreenshot.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBoxScreenshot.Image)
        End If
        If Not PictureBoxCamera.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBoxCamera.Image)
        End If
        ImageViewer.Show()
    End Sub

    Private Sub PictureBoxCamera_MouseDoubleClick(ByVal sender As Object, _
                                                  ByVal e As  _
                                                     MouseEventArgs) _
        Handles PictureBoxCamera.MouseDoubleClick
        If Not PictureBoxScreenshot.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBoxScreenshot.Image)
        End If
        If Not PictureBoxCamera.Image Is Nothing Then
            ImageViewer.PictrueBmpList.Add(PictureBoxCamera.Image)
        End If
        ImageViewer.Show()
    End Sub
End Class