Public Class MyToast

    Private _showTimeMilliSec As Integer
    Private _countMilliSec As Integer = 0

    Public Sub New(ByVal text As String, ByVal showTime As Integer)

        ' �˵����� Windows ���������������ġ�
        InitializeComponent()
        ' �� InitializeComponent() ����֮������κγ�ʼ����
        LabelText.Text = text
        _showTimeMilliSec = showTime

        '����
        Dim textWidth = LabelText.Width
        Me.Width = textWidth + 200
        LabelText.Left = 100


        Me.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _countMilliSec += Timer1.Interval
        If _countMilliSec >= _showTimeMilliSec Then
            Me.Dispose()
        End If
    End Sub
End Class