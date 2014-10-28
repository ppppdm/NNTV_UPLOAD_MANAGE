Public Class MVCUnit

    Public Value As Boolean
    Public ViewName As String
    Public FileName As String

    Public Sub New(ByVal v As Boolean, ByVal vn As String, ByVal fn As String)
        Value = v
        ViewName = vn
        FileName = fn
    End Sub

    Public Overrides Function toString() As String
        Return Value.ToString
    End Function

End Class
