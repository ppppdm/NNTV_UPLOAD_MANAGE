Imports System.ComponentModel

Public Class AccessControlQuery
    Public Class AccessControlResult
        Public Name As String
        Public CheckTime As Date
    End Class

    Private _result As AccessControlResult

    Private _worker As BackgroundWorker

    Private _bgThreadID As Integer

    Public Sub EndAccessControl()
        Console.WriteLine("_bgThreadID {0}", _bgThreadID)
        PostThreadMessage(_bgThreadID, WM_QUIT, 0, 0)
    End Sub

    Public Sub StartAccessControl(ByVal worker As BackgroundWorker)

        _worker = worker
        _result = New AccessControlResult

        ' Get current thread ID
        ' For when cancel the thread by post quit message with this ID
        Dim bgThreadID As Long = GetCurrentThreadId()
        _bgThreadID = bgThreadID
        Console.WriteLine("_bgThreadID {0}", _bgThreadID)

        Dim axCZKEM1 As New CZKEM
        Dim ip As String = FigurePrintIP
        Dim ipPort As String = FigurePrintPort
        Dim iMachineNumber As Integer
        Dim idwErrorCode As Integer

        If axCZKEM1.Connect_Net(ip, Convert.ToInt32(ipPort)) Then
            iMachineNumber = 1 _
            'In fact,when you are using the tcp/ip communication, _
            'this parameter will be ignored, _
            'that is any integer will all right.Here we use 1.
            If axCZKEM1.RegEvent(iMachineNumber, 65535) = True Then _
                'Here you can register the realtime events that _
                'you want to be triggered(the parameters 65535 means registering all)
                AddHandler axCZKEM1.OnAttTransactionEx, _
                    AddressOf AxCZKEM1_OnAttTransactionEx

                Application.Run()

                Console.WriteLine("the zk background loop exit")

                axCZKEM1.Disconnect()
                RemoveHandler axCZKEM1.OnAttTransactionEx, _
                    AddressOf AxCZKEM1_OnAttTransactionEx

            End If
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Unable to connect the device,ErrorCode=" & idwErrorCode, _
                   MsgBoxStyle.Exclamation, _
                   "Error")
        End If
    End Sub

#Region "RealTime Events"

    'If your fingerprint(or your card) passes the verification,this event will be triggered
    Private Sub AxCZKEM1_OnAttTransactionEx(ByVal sEnrollNumber As String, _
                                            ByVal iIsInValid As Integer, _
                                            ByVal iAttState As Integer, _
                                            ByVal iVerifyMethod As Integer, _
                                            ByVal iYear As Integer, _
                                            ByVal iMonth As Integer, _
                                            ByVal iDay As Integer, _
                                            ByVal iHour As Integer, _
                                            ByVal iMinute As Integer, _
                                            ByVal iSecond As Integer, _
                                            ByVal iWorkCode As Integer)
        Console.WriteLine( _
            "RTEvent OnAttTrasactionEx Has been Triggered,Verified OK")
        Console.WriteLine("...UserID:" & sEnrollNumber)
        Console.WriteLine("...isInvalid:" & iIsInValid.ToString())
        Console.WriteLine("...attState:" & iAttState.ToString())
        Console.WriteLine("...VerifyMethod:" & iVerifyMethod.ToString())
        Console.WriteLine("...Workcode:" & iWorkCode.ToString()) _
        'the difference between the event OnAttTransaction and OnAttTransactionEx
        Console.WriteLine( _
            "...Time:" & iYear.ToString() & "-" & iMonth.ToString() & "-" & _
            iDay.ToString() & " " & iHour.ToString() & ":" & iMinute.ToString() & _
            ":" & iSecond.ToString())

        _result.Name = sEnrollNumber.ToString()
        _result.CheckTime = _
            Convert.ToDateTime( _
                iYear.ToString() & "-" & iMonth.ToString() & "-" & _
                iDay.ToString() & " " & iHour.ToString() & ":" & _
                iMinute.ToString() & ":" & iSecond.ToString())

        _worker.ReportProgress(0, _result)
    End Sub

#End Region
End Class
