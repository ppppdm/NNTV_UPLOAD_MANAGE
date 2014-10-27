Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class FixTimeCode

    Private _tapeId As Guid = Nothing

    Private _workAcq As AccessControlQuery

    Private Sub FixTimeCode_Disposed(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles Me.Disposed
        '结束指纹后台进程
        EndThread()
    End Sub

    Private Sub FixTimeCode_Load(ByVal sender As Object, _
                                 ByVal e As EventArgs) Handles Me.Load

        If Not QueryForm.TapeId = Nothing Then
            _tapeId = QueryForm.TapeId

            setTapeInfo()
        End If

        '启动指纹后台进程
        StartThread()
    End Sub

    Private Sub SetTapeInfo()
        Const queryString As String = "select " & "tape_name, " & _
                                      "start_timecode, " & "length " & _
                                      "from tape " & "where " & "id = @id"
        Dim conn As SqlConnection = New SqlConnection(ConnStr)
        Dim com As SqlCommand = New SqlCommand(queryString, conn)
        com.Parameters.Add(New SqlParameter("id", _tapeId))

        Try
            conn.Open()
            Dim reader As SqlDataReader = com.ExecuteReader()
            If reader.Read() Then
                Dim arr() As String
                Dim startTimeCode As String = reader("start_timecode")
                Dim length As String = reader("length")

                TextBoxTapeName.Text = reader("tape_name")
                TextBoxOldStartTimeCode.Text = startTimeCode
                TextBoxOldLength.Text = length

                arr = startTimeCode.Split(":")
                TextBoxNewStartTimeH.Text = arr(0)
                TextBoxNewStartTimeM.Text = arr(1)
                TextBoxNewStartTimeS.Text = arr(2)
                TextBoxNewStartTimeF.Text = arr(3)

                arr = length.Split(":")
                TextBoxNewLengthH.Text = arr(0)
                TextBoxNewLengthM.Text = arr(1)
                TextBoxNewLengthS.Text = arr(2)
                TextBoxNewLengthF.Text = arr(3)
            Else
                MsgBox("not found tape!")
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As Object, _
                                   ByVal e As EventArgs) _
        Handles ButtonCancel.Click
        Me.Dispose()
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As Object, _
                               ByVal e As EventArgs) _
        Handles ButtonOK.Click
        If Not _tapeId = Nothing Then
            Dim tapeName = TextBoxTapeName.Text
            Dim newStartTimecode = TextBoxNewStartTimeH.Text & ":" & _
                                   TextBoxNewStartTimeM.Text & ":" & _
                                   TextBoxNewStartTimeS.Text & ":" & _
                                   TextBoxNewStartTimeF.Text
            Dim newLength = TextBoxNewLengthH.Text & ":" & _
                            TextBoxNewLengthM.Text & ":" & _
                            TextBoxNewLengthS.Text & ":" & _
                            TextBoxNewLengthF.Text

            Dim oldStartTimeCode = TextBoxOldStartTimeCode.Text
            Dim oldLength = TextBoxOldLength.Text
            Dim fixPerson = TextBoxFixTimeCodePerson.Text

            Dim conn As New SqlConnection(ConnStr)
            Const queryS1 As String = "insert into fix_timecode (" & "tape_id, " & _
                                      "tape_name, " & "new_start_timecode, " & _
                                      "new_length, " & "old_start_timecode, " & _
                                      "old_length, " & "fix_time, " & _
                                      "fix_person) " & "values (" & "@tape_id, " & _
                                      "@tape_name, " & "@new_start_timecode, " & _
                                      "@new_length, " & "@old_start_timecode, " & _
                                      "@old_length, " & "@fix_time, " & _
                                      "@fix_person) "

            Dim params1() As SqlParameter = _
                    {New SqlParameter("@tape_id", _tapeId), _
                     New SqlParameter("@tape_name", tapeName), _
                     New SqlParameter("@new_start_timecode", newStartTimecode), _
                     New SqlParameter("@new_length", newLength), _
                     New SqlParameter("@old_start_timecode", oldStartTimeCode), _
                     New SqlParameter("@old_length", oldLength), _
                     New SqlParameter("@fix_time", Now()), _
                     New SqlParameter("@fix_person", fixPerson)}

            Const queryS2 As String = "update tape set " & _
                                      "start_timecode = @new_start_timecode, " & _
                                      "length = @new_length " & "where " & _
                                      "id = @tape_id"

            Dim params2() As SqlParameter = _
                    {New SqlParameter("@tape_id", _tapeId), _
                     New SqlParameter("@new_start_timecode", newStartTimecode), _
                     New SqlParameter("@new_length", newLength)}

            Dim com1 As SqlCommand = New SqlCommand(queryS1, conn)
            com1.Parameters.AddRange(params1)

            Dim com2 As SqlCommand = New SqlCommand(queryS2, conn)
            com2.Parameters.AddRange(params2)

            Try
                conn.Open()
                com1.ExecuteNonQuery()
                com2.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
        Me.Dispose()
    End Sub

    Private Sub TextBoxStartTimeH_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxNewStartTimeH.TextChanged
        TimeInputCheck(TextBoxNewStartTimeH, TextBoxNewStartTimeM, 99, False)
    End Sub

    Private Sub TextBoxStartTimeM_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxNewStartTimeM.TextChanged

        TimeInputCheck(TextBoxNewStartTimeM, TextBoxNewStartTimeS, 60, False)
    End Sub

    Private Sub TextBoxStartTimeS_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxNewStartTimeS.TextChanged

        TimeInputCheck(TextBoxNewStartTimeS, TextBoxNewStartTimeF, 60, False)
    End Sub

    Private Sub TextBoxStartTimeF_TextChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) _
        Handles TextBoxNewStartTimeF.TextChanged

        TimeInputCheck(TextBoxNewStartTimeF, TextBoxNewLengthH, 25, False)
    End Sub

    Private Sub TextBoxLengthH_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxNewLengthH.TextChanged

        TimeInputCheck(TextBoxNewLengthH, TextBoxNewLengthM, 99, True)
    End Sub

    Private Sub TextBoxLengthM_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxNewLengthM.TextChanged

        TimeInputCheck(TextBoxNewLengthM, TextBoxNewLengthS, 60, True)
    End Sub

    Private Sub TextBoxLengthS_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxNewLengthS.TextChanged

        TimeInputCheck(TextBoxNewLengthS, TextBoxNewLengthF, 60, True)
    End Sub

    Private Sub TextBoxLengthF_TextChanged(ByVal sender As Object, _
                                           ByVal e As EventArgs) _
        Handles TextBoxNewLengthF.TextChanged

        If IsNumeric(TextBoxNewLengthF.Text) Then
            If TextBoxNewLengthF.TextLength = 2 Then
                If _
                    CInt(TextBoxNewLengthF.Text) >= 25 Or _
                    CInt(TextBoxNewLengthF.Text) < 0 Then
                    TextBoxNewLengthF.Text = "00"
                    TextBoxNewLengthF.SelectAll()
                End If
            End If
        Else
            TextBoxNewLengthF.Text = "00"
            TextBoxNewLengthF.SelectAll()
        End If
    End Sub

    '输入时码后计算出点，输入焦点跳到下一个框
    Private Sub TimeInputCheck(ByRef thisTextTox As TextBox, _
                               ByRef nextTextBox As TextBox, _
                               ByVal maxNum As Integer, _
                               ByVal isLength As Boolean)
        If IsNumeric(thisTextTox.Text) Then
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
        Else
            thisTextTox.Text = "00"   '非数字，改回00
            thisTextTox.Focus()
        End If
    End Sub

    '点击时码输入框时全选内容
    Private Sub TextBoxStartTimeH_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxNewStartTimeH.Click

        TextBoxNewStartTimeH.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeM_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxNewStartTimeM.Click

        TextBoxNewStartTimeM.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeS_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxNewStartTimeS.Click

        TextBoxNewStartTimeS.SelectAll()
    End Sub

    Private Sub TextBoxStartTimeF_Click(ByVal sender As Object, _
                                        ByVal e As EventArgs) _
        Handles TextBoxNewStartTimeF.Click

        TextBoxNewStartTimeF.SelectAll()
    End Sub

    Private Sub TextBoxLengthH_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxNewLengthH.Click

        TextBoxNewLengthH.SelectAll()
    End Sub

    Private Sub TextBoxLengthM_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxNewLengthM.Click

        TextBoxNewLengthM.SelectAll()
    End Sub

    Private Sub TextBoxLengthS_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxNewLengthS.Click

        TextBoxNewLengthS.SelectAll()
    End Sub

    Private Sub TextBoxLengthF_Click(ByVal sender As Object, _
                                     ByVal e As EventArgs) _
        Handles TextBoxNewLengthF.Click

        TextBoxNewLengthF.SelectAll()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, _
                                                  ByVal e As  _
                                                     ProgressChangedEventArgs) _
        Handles BackgroundWorker1.ProgressChanged

        ' This event handler is called after the background thread
        ' reads a line from the source file.
        ' This method runs on the main thread.

        Dim result As AccessControlQuery.AccessControlResult = CType(e.UserState,  _
                                                                     AccessControlQuery.AccessControlResult)

        '查询数据库 根据name获取信息
        Dim connStr As String = "Server=" & DbServer & ";Database=" & DbDbNamme & _
                                ";User ID=" & DbUser & ";Password=" & DbPawd & _
                                ";"
        Dim connection As New SqlConnection(connStr)
        Const queryString As String = _
                  "select name, department from person where id = @id"
        Dim command As New SqlCommand(queryString, connection)
        Dim pname As String
        Dim department As String

        command.Parameters.Add(New SqlParameter("@id", result.Name))

        Try
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read Then
                pname = reader("name")
                department = reader("department")

                If department = "播出部" Then
                    TextBoxFixTimeCodePerson.Text = pname
                Else
                    MsgBox("不是播出部人员!")
                End If

            Else
                MsgBox("数据库无此信息,请手动输入")
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, _
                                         ByVal e As DoWorkEventArgs) _
        Handles BackgroundWorker1.DoWork

        ' This event handler is where the actual work is done.
        ' This method runs on the background thread.

        ' Get the BackgroundWorker object that raised this event.
        Dim worker As BackgroundWorker
        worker = CType(sender, BackgroundWorker)

        ' Get the Works object and call the main method.
        Dim workAcq As AccessControlQuery = CType(e.Argument, AccessControlQuery)
        workAcq.StartAccessControl(worker)
    End Sub

    '载入界面时调用此方法调用后台线程
    Sub StartThread()
        ' This method runs on the main thread.

        ' Initialize the object that the background worker calls.
        _workAcq = New AccessControlQuery

        ' Start the asynchronous operation.
        BackgroundWorker1.RunWorkerAsync(_workAcq)
    End Sub

    '销毁界面前调用此方法调用后台线程
    Sub EndThread()
        _workAcq.EndAccessControl()
    End Sub
End Class