Public Class MyToast
    Private ReadOnly _showTimeMilliSec As Integer
    Private _countMilliSec As Integer = 0

    Public Sub New(ByVal text As String, ByVal showTime As Integer)

        ' 此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        LabelText.Text = text
        _showTimeMilliSec = showTime

        '调整
        Dim textWidth = LabelText.Width
        Me.Width = textWidth + 200
        LabelText.Left = 100

    End Sub

    Public Overloads Shared Sub Show(ByVal text As String, ByVal showTimeMilliSec As Integer)
        Dim toast As MyToast = New MyToast(text, showTimeMilliSec)
        toast.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, _
                            ByVal e As EventArgs) Handles Timer1.Tick
        _countMilliSec += Timer1.Interval
        If _countMilliSec >= _showTimeMilliSec Then
            Me.Dispose()
        End If
    End Sub
End Class