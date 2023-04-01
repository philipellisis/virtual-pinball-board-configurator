
Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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
        objSerial.NewLine = vbCr


        objSerial.DtrEnable = True
    End Sub

    Public Function read() As String
        Return objSerial.ReadLine()
    End Function
    Public Sub send(bytes() As Byte)
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
        If context Is Nothing Then
            OnIESChanged(e)
        Else
            ThreadExtensions.ScSend(context, New Action(Of RS232ChangedArgs)(AddressOf OnIESChanged), e)
        End If
    End Sub
    Private Sub sendRS232Completed(e As RS232CompletedArgs)
        If context Is Nothing Then
            OnIESCompleted(e)
        Else
            ThreadExtensions.ScSend(context, New Action(Of RS232CompletedArgs)(AddressOf OnIESCompleted), e)
        End If
    End Sub
    Private Sub objSerial_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) 'Handles objSerial.DataReceived
        sendRS232Changed(New RS232ChangedArgs(objSerial.ReadExisting, "connected"))
    End Sub

    Private Sub objSerial_error(sender As Object, e As IO.Ports.SerialErrorReceivedEventArgs) Handles objSerial.ErrorReceived
        sendRS232Completed(New RS232CompletedArgs("unexpected error occurred", "disconnected"))
    End Sub
End Class

