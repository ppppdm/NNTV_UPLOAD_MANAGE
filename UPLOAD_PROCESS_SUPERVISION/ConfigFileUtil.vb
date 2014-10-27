Imports System.IO
Imports System.Collections.Generic
Imports System.Text.RegularExpressions

Public Class ConfigFileUtil
    Private ReadOnly _fs As FileStream
    Private ReadOnly _fr As StreamReader
    Private ReadOnly _fw As StreamWriter
    Private ReadOnly _buffer As New Dictionary(Of String, Dictionary(Of String, String))

    Private Const DefalutFilePath As String = "Test.txt"


    Public Sub New()
        Try
            _fs = File.Open(DefalutFilePath, FileMode.OpenOrCreate)
            _fr = New StreamReader(_fs)
            _fw = New StreamWriter(_fs)
            LoadFile()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub New(ByVal path As String)
        Try
            _fs = File.Open(path, FileMode.OpenOrCreate)
            _fr = New StreamReader(_fs)
            _fw = New StreamWriter(_fs)
            LoadFile()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function Read(ByVal head As String, ByVal keyword As String) _
        As String
        Try
            If _buffer.ContainsKey(head) Then
                Dim dic As Dictionary(Of String, String) = _buffer.Item(head)
                If dic.ContainsKey(keyword) Then
                    Return dic.Item(keyword)
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Write(ByVal head As String, _
                          ByVal keyword As String, _
                          ByVal value As String) As Boolean
        Try
            If _buffer.ContainsKey(head) Then
                Dim dic As Dictionary(Of String, String) = _buffer.Item(head)
                If dic.ContainsKey(keyword) Then
                    dic.Item(keyword) = value
                    Return True
                Else
                    dic.Add(keyword, value)
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub FlushToFile()
        _fs.Seek(0, SeekOrigin.Begin)
        _fs.SetLength(0)

        Dim iter _
                As  _
                Dictionary(Of String, Dictionary(Of String, String)).Enumerator _
                = _buffer.GetEnumerator()
        While iter.MoveNext
            Dim head As String = iter.Current().Key
            Dim keypair As Dictionary(Of String, String) = iter.Current.Value

            _fw.WriteLine("[" + head + "]")

            Dim innerIter As Dictionary(Of String, String).Enumerator = _
                    keypair.GetEnumerator()
            While innerIter.MoveNext
                Dim key As String = innerIter.Current().Key
                Dim value As String = innerIter.Current().Value
                _fw.WriteLine(key + vbTab + "=" + vbTab + value)
            End While

            _fw.WriteLine()
            _fw.Flush()
        End While
    End Sub

    Public Sub Close()

        FlushToFile()

        '_fr.Close()
        _fw.Close()
        _fs.Close()
    End Sub


    Private Sub LoadFile()
        _buffer.Clear()

        Dim headRegex As New Regex("^\[\S+\]") ', RegexOptions.IgnoreCase)
        Dim keyRegex As New Regex("\S+[ \t]*=[ \t]*\S+") _
        ', RegexOptions.IgnoreCase)
        Dim head As String = ""
        Dim key As String
        Dim value As String
        Dim lineNum As Integer = 1

        While Not _fr.EndOfStream
            Dim ss As String = _fr.ReadLine()
            'Console.Write(ss)


            Dim headmatch As String = headRegex.Match(ss).Value
            Dim keymatch As String = keyRegex.Match(ss).Value
            If Not headmatch = "" Then
                Console.WriteLine("got HEAD at line({0}): " + headmatch, _
                                  lineNum)
                head = headmatch.Trim("[", "]")
                AddHeadToBuffer(head)
            ElseIf Not keymatch = "" Then
                Console.WriteLine("got KEY  at line({0}): " + keymatch, lineNum)
                Dim pair As String() = keymatch.Split("=")
                key = pair(0).Trim()
                value = pair(1).Trim()
                AddKeyToBuffer(head, key, value)
            Else
                'got nothing or error
            End If

            lineNum += 1
        End While
    End Sub

    Private Sub AddHeadToBuffer(ByVal head As String)
        Try
            Dim newKeyDic As New Dictionary(Of String, String)()
            _buffer.Add(head, newKeyDic)
        Catch ex As ArgumentException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub AddKeyToBuffer(ByVal head As String, _
                               ByVal key As String, _
                               ByVal value As String)
        If _buffer.ContainsKey(head) Then
            Dim dic As Dictionary(Of String, String) = _buffer.Item(head)
            dic.Add(key, value)
        End If
    End Sub
End Class
