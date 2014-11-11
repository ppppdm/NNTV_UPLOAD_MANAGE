Imports System.Data.SqlClient
Public Class SendTapeInBatch

    Private _idList As ArrayList

    Private Sub SendTapeInBatch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        _idList = New ArrayList(QueryForm.IdLIst)

        setTapeInfo()

    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Dispose()
    End Sub

    Private Sub setTapeInfo()

        Dim whereStr As String = "where "
        Dim connection As New SqlConnection(ConnStr)
        Dim queryString As String = "select * from tape "
        Dim command As New SqlCommand(queryString, connection)
        Dim i As Integer

        For i = 0 To _idList.Count - 1
            whereStr += "id=" + _idList(i).Value.ToString + "or "
        Next


        Try
            connection.Open()
            Dim reader As SqlDataReader = Command.ExecuteReader()
            If (reader.Read()) Then
                TextBoxTapeName.Text = reader("tape_name")
            Else
                MsgBox("find tape error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub


End Class