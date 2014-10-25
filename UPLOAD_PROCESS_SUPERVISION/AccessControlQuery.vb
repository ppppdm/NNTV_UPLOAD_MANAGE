Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Threading
Imports System.Net.sockets

Public Class AccessControlQuery
    Public Class AccessControlResult
        Public Name As String
        Public CheckTime As Date
    End Class

    Private result As New AccessControlResult

    Private _worker As BackgroundWorker

    Private _bgThreadID As Integer

    Public Sub EndAccessControl()
        Console.WriteLine("_bgThreadID {0}", _bgThreadID)
        PostThreadMessage(_bgThreadID, WM_QUIT, 0, 0)
    End Sub

    Public Sub StartAccessControl(ByVal worker As BackgroundWorker)

        _worker = worker

        ' Get current thread ID
        ' For when cancel the thread by post quit message with this ID
        Dim bgThreadID As Long = GetCurrentThreadId()
        _bgThreadID = bgThreadID
        Console.WriteLine("_bgThreadID {0}", _bgThreadID)

        Dim axCZKEM1 As New zkemkeeper.CZKEM
        Dim IP As String = FigurePrintIP
        Dim IPPort As String = FigurePrintPort
        Dim iMachineNumber As Integer
        Dim idwErrorCode As Integer

        If axCZKEM1.Connect_Net(IP, Convert.ToInt32(IPPort)) Then
            iMachineNumber = 1 'In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
            If axCZKEM1.RegEvent(iMachineNumber, 65535) = True Then 'Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                'AddHandler axCZKEM1.OnAttTransaction, AddressOf AxCZKEM1_OnAttTransaction
                AddHandler axCZKEM1.OnAttTransactionEx, AddressOf AxCZKEM1_OnAttTransactionEx

                Application.Run()

                Console.WriteLine("the zk background loop exit")

                axCZKEM1.Disconnect()
                'RemoveHandler axCZKEM1.OnAttTransaction, AddressOf AxCZKEM1_OnAttTransaction
                RemoveHandler axCZKEM1.OnAttTransactionEx, AddressOf AxCZKEM1_OnAttTransactionEx

            End If
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Unable to connect the device,ErrorCode=" & idwErrorCode, MsgBoxStyle.Exclamation, "Error")
        End If



    End Sub

#Region "RealTime Events"

    'If your fingerprint(or your card) passes the verification,this event will be triggered
    'Private Sub AxCZKEM1_OnAttTransaction(ByVal iEnrollNumber As Integer, ByVal iIsInValid As Integer, ByVal iAttState As Integer, ByVal iVerifyMethod As Integer, _
    '                  ByVal iYear As Integer, ByVal iMonth As Integer, ByVal iDay As Integer, ByVal iHour As Integer, ByVal iMinute As Integer, ByVal iSecond As Integer)
    '    Console.WriteLine("RTEvent OnAttTrasaction Has been Triggered,Verified OK")
    '    Console.WriteLine("...UserID:" & iEnrollNumber.ToString())
    '    Console.WriteLine("...isInvalid:" & iIsInValid.ToString())
    '    Console.WriteLine("...attState:" & iAttState.ToString())
    '    Console.WriteLine("...VerifyMethod:" & iVerifyMethod.ToString())
    '    Console.WriteLine("...Time:" & iYear.ToString() & "-" & iMonth.ToString() & "-" & iDay.ToString() & " " & iHour.ToString() & ":" & iMinute.ToString() & ":" & iSecond.ToString())

    '    result.Name = iEnrollNumber.ToString()
    '    result.CheckTime = Convert.ToDateTime(iYear.ToString() & "-" & iMonth.ToString() & "-" & iDay.ToString() & " " & iHour.ToString() & ":" & iMinute.ToString() & ":" & iSecond.ToString())

    'End Sub

    'If your fingerprint(or your card) passes the verification,this event will be triggered
    Private Sub AxCZKEM1_OnAttTransactionEx(ByVal sEnrollNumber As String, ByVal iIsInValid As Integer, ByVal iAttState As Integer, ByVal iVerifyMethod As Integer, _
                      ByVal iYear As Integer, ByVal iMonth As Integer, ByVal iDay As Integer, ByVal iHour As Integer, ByVal iMinute As Integer, ByVal iSecond As Integer, ByVal iWorkCode As Integer)
        Console.WriteLine("RTEvent OnAttTrasactionEx Has been Triggered,Verified OK")
        Console.WriteLine("...UserID:" & sEnrollNumber)
        Console.WriteLine("...isInvalid:" & iIsInValid.ToString())
        Console.WriteLine("...attState:" & iAttState.ToString())
        Console.WriteLine("...VerifyMethod:" & iVerifyMethod.ToString())
        Console.WriteLine("...Workcode:" & iWorkCode.ToString()) 'the difference between the event OnAttTransaction and OnAttTransactionEx
        Console.WriteLine("...Time:" & iYear.ToString() & "-" & iMonth.ToString() & "-" & iDay.ToString() & " " & iHour.ToString() & ":" & iMinute.ToString() & ":" & iSecond.ToString())

        result.Name = sEnrollNumber.ToString()
        result.CheckTime = Convert.ToDateTime(iYear.ToString() & "-" & iMonth.ToString() & "-" & iDay.ToString() & " " & iHour.ToString() & ":" & iMinute.ToString() & ":" & iSecond.ToString())

        _worker.ReportProgress(0, result)
    End Sub

#End Region
End Class
