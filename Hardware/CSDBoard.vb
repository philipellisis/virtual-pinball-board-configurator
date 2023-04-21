Imports System.Runtime.Remoting.Contexts

Public Class CSDBoard
    Implements BoardInterface
    Private WithEvents CSDConnection As RS232
    Private context As Threading.SynchronizationContext = Threading.SynchronizationContext.Current
    Public Sub setOutputValue(output As Integer, value As Integer) Implements BoardInterface.setOutputValue
        CSDConnection.send({0, 252, output, value, 0, 0, 0, 0, 0})
    End Sub

    Public Sub enableAdminFunction(admin As ADMIN) Implements BoardInterface.enableAdminFunction
        CSDConnection.send({0, 250, admin, 0, 0, 0, 0, 0, 0})
    End Sub

    Public Sub setPlungerMinMax(max As UShort, min As UShort, mid As UShort) Implements BoardInterface.setPlungerMinMax
        Dim result As Byte() = BitConverter.GetBytes(max)
        Dim result1 As Byte() = BitConverter.GetBytes(min)
        Dim result2 As Byte() = BitConverter.GetBytes(mid)
        enableAdminFunction(ADMIN.SET_PLUNGER)
        Threading.Thread.Sleep(100)
        CSDConnection.send({result(1), result(0), result1(1), result1(0), result2(1), result2(0)})
    End Sub

    Public Sub setConfig(config As BoardConfiguration) Implements BoardInterface.setConfig
        enableAdminFunction(ADMIN.GET_CONFIG)
        Threading.Thread.Sleep(100)
        CSDConnection.send(config.toConfigBytes(config))
    End Sub

    Public Function saveConfigToEeprom() Implements BoardInterface.saveConfigToEeprom
        enableAdminFunction(ADMIN.SAVE_CONFIG)
    End Function

    Public Sub connect() Implements BoardInterface.connect
        For Each sp As String In My.Computer.Ports.SerialPortNames

            CSDConnection = New RS232(sp)
            Try
                CSDConnection.open()
                enableAdminFunction(ADMIN.CONNECT)
                'CSDConnection.send({0, 251, 0, 0, 0, 0, 0, 0, 0})
                Do While True
                    Dim result As String = CSDConnection.read()
                    If result = "DEBUG,CSD Board Connected" Then
                        CSDConnection.ReceiveDataEvents = True
                        Return
                    End If
                Loop

            Catch ex As Exception
                CSDConnection.close()
            End Try
        Next
        Throw New Exception("Unable to connect to any board")
    End Sub

    Private Sub OnBoardChanged(ByVal e As BoardChangedArgs)
        RaiseEvent BoardChanged(Me, e)
    End Sub
    Private Sub OnBoardDisconnected(ByVal e As BoardCompletedArgs)
        RaiseEvent BoardDisconnected(Me, e)
    End Sub
    Private Sub sendBoardChanged(e As BoardChangedArgs)
        If context Is Nothing Then
            OnBoardChanged(e)
        Else
            ThreadExtensions.ScSend(context, New Action(Of BoardChangedArgs)(AddressOf OnBoardChanged), e)
        End If
    End Sub

    Public Event BoardChanged As EventHandler(Of BoardChangedArgs) Implements BoardInterface.BoardChanged
    Public Event BoardDisconnected As EventHandler(Of BoardCompletedArgs) Implements BoardInterface.BoardDisconnected

    Private Sub sendBoardDisconnected(e As BoardCompletedArgs)
        If context Is Nothing Then
            OnBoardDisconnected(e)
        Else
            ThreadExtensions.ScSend(context, New Action(Of BoardCompletedArgs)(AddressOf OnBoardDisconnected), e)
        End If
    End Sub

    Private incomingMessage As String
    Private Sub CSDConnection_RS232Changed(sender As Object, e As RS232ChangedArgs) Handles CSDConnection.RS232Changed
        Dim message = Split(e.message, ",")
        If message.Length = 0 Then
            sendBoardChanged(New BoardChangedArgs(e.message, MESSAGE_TYPE.DEBUG))
            Return
        End If
        Dim newMessage = e.message.Replace(message(0) & ",", "")
        Select Case message(0)
            Case "DEBUG"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.DEBUG))
            Case "OUTPUTS"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.OUTPUTS))
            Case "BUTTONS"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.BUTTONS))
            Case "CONFIG"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.CONFIG))
            Case "PLUNGER"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.PLUNGER))
            Case "ACCEL"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.ACCEL))
            Case "RESPONSE"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.RESPONSE))
            Case Else
                sendBoardChanged(New BoardChangedArgs(e.message, MESSAGE_TYPE.DEBUG))
        End Select

    End Sub
End Class
