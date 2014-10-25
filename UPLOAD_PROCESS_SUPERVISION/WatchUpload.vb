﻿Imports System.Data.SqlClient
Imports System.IO

Public Class WatchUpload

    Private _tapeId As Guid = Nothing

    Private Sub WatchUpload_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        _tapeId = QueryForm.TapeId

        '从数据库中查询上载数据
        Const queryString = "select " & _
        "tape_name, " & _
        "program_type, " & _
        "start_timecode, " & _
        "in_bc_send_per, " & _
        "in_bc_recv_per, " & _
        "end_timecode, " & _
        "end_timecode, " & _
        "end_timecode, " & _
        "length " & _
        "from tape " & _
        "where " & _
        "id = @id"

        Const queryString2 = "select " & _
        "upload_time, " & _
        "upload_per, " & _
        "upload_pc, " & _
        "screenshot, " & _
        "camera " & _
        "from upload " & _
        "where " & _
        "tape_id = @tape_id " & _
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
                MsgBox("Find Tape Null")
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
                MsgBox("Find Tape Null")
            End If

            reader.close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try

    End Sub

    Private Sub PictureBoxScreenshot_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxScreenshot.MouseHover
        If Not PictureBoxScreenshot.Image Is Nothing Then
            PictrueBmp = PictureBoxScreenshot.Image
            PictrueLarge.Show()
        End If
    End Sub

    Private Sub PictureBoxCamera_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxCamera.MouseHover
        If Not PictureBoxCamera.Image Is Nothing Then
            PictrueBmp = PictureBoxCamera.Image
            PictrueLarge.Show()
        End If
    End Sub

End Class