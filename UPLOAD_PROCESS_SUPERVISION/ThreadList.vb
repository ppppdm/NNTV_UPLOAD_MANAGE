Imports System.Threading

Public Class ThreadList
    Inherits List(Of Thread)

    Declare Function GetExitCodeThread Lib "kernel32" Alias "GetExitCodeThread" (ByVal hThread As Long, ByVal lpExitCode As Long) As Long

    Public Sub PostThreadsQuitMessage()
        Dim em As Enumerator = Me.GetEnumerator()
        While em.MoveNext
            Dim t As Thread = em.Current
            If t.IsAlive() Then
                Dim bgThreadID As Long = GetCurrentThreadId()
                PostThreadMessage(bgThreadID, WM_QUIT, 0, 0)
            Else
                Me.Remove(t)
            End If
        End While

    End Sub

    Public Sub TerminalThreads()
        Dim em As Enumerator = Me.GetEnumerator()
        While em.MoveNext
            Dim t As Thread = em.Current
            If t.IsAlive() Then
                t.Abort()
            End If
            Me.Remove(t)
        End While
    End Sub

End Class
