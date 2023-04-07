
Imports System.CodeDom.Compiler
Imports System.Runtime.Remoting.Contexts
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server

Public Class RS232ChangedArgs
    Public message As String
    Public status As String
    Public Sub New(message As String, status As String)
        Me.message = message
        Me.status = status
    End Sub
End Class
Public Class RS232CompletedArgs
    Public message As String
    Public status As String
    Public Sub New(message As String, status As String)
        Me.message = message
        Me.status = status
    End Sub
End Class
Public Class RS232
    Private WithEvents objSerial As System.IO.Ports.SerialPort
    Private context As Threading.SynchronizationContext = Threading.SynchronizationContext.Current
    Private _ReceiveDataEvents As Boolean = False
    Public Sub New(port As String)
        objSerial = New IO.Ports.SerialPort(port)
    End Sub

    Public Property ReceiveDataEvents As Boolean
        Get
            Return _ReceiveDataEvents
        End Get
        Set(value As Boolean)
            If value Then
                AddHandler objSerial.DataReceived, AddressOf objSerial_DataReceived
            Else
                RemoveHandler objSerial.DataReceived, AddressOf objSerial_DataReceived
            End If
            _ReceiveDataEvents = value
        End Set
    End Property
    Public Sub open()
        objSerial.BaudRate = 2000000
        objSerial.Handshake = IO.Ports.Handshake.None

        objSerial.ReadTimeout = 500
        objSerial.Open()
        objSerial.NewLine = vbCrLf


        objSerial.DtrEnable = True
    End Sub
    Public Sub close()
        objSerial.Close()
    End Sub

    Public Function read() As String
        Return objSerial.ReadLine()
    End Function
    Public Sub send(bytes() As Byte)
        Console.WriteLine("rs232 actual send Data: " & System.Text.Encoding.Unicode.GetString(bytes))
        objSerial.Write(bytes, 0, bytes.Length)
    End Sub

    Public Event RS232Changed As EventHandler(Of RS232ChangedArgs)
    Protected Overridable Sub OnIESChanged(ByVal e As RS232ChangedArgs)
        RaiseEvent RS232Changed(Me, e)
    End Sub
    Public Event RS232Completed As EventHandler(Of RS232CompletedArgs)
    Protected Overridable Sub OnIESCompleted(ByVal e As RS232CompletedArgs)
        RaiseEvent RS232Completed(Me, e)
    End Sub
    Private Sub sendRS232Changed(e As RS232ChangedArgs)
        If e.message <> "" Then
            If context Is Nothing Then
                OnIESChanged(e)
            Else
                ThreadExtensions.ScSend(context, New Action(Of RS232ChangedArgs)(AddressOf OnIESChanged), e)
            End If
        End If
    End Sub
    Private Sub sendRS232Completed(e As RS232CompletedArgs)
        If context Is Nothing Then
            OnIESCompleted(e)
        Else
            ThreadExtensions.ScSend(context, New Action(Of RS232CompletedArgs)(AddressOf OnIESCompleted), e)
        End If
    End Sub

    Private lineData As StringBuilder = New StringBuilder
    Private Sub objSerial_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) 'Handles objSerial.DataReceived
        lineData.Append(objSerial.ReadExisting)
        Dim splitString = System.Text.RegularExpressions.Regex.Split(lineData.ToString, vbCrLf)
        If splitString.Length > 1 Then
            For i As Integer = 0 To splitString.Length - 2
                Console.WriteLine("rs232 actual Data: " & splitString(i))
                sendRS232Changed(New RS232ChangedArgs(splitString(i), "connected"))
            Next
            lineData.Clear()
            lineData.Append(splitString(splitString.Length - 1))
        End If


    End Sub

    Private Sub objSerial_error(sender As Object, e As IO.Ports.SerialErrorReceivedEventArgs) Handles objSerial.ErrorReceived
        sendRS232Completed(New RS232CompletedArgs("unexpected error occurred", "disconnected"))
    End Sub
End Class

