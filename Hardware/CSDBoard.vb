Imports System.Runtime.Remoting.Contexts
Imports System.Threading

Public Class CSDBoard
    Implements BoardInterface
    Private WithEvents CSDConnection As RS232
    Private context As Threading.SynchronizationContext = Threading.SynchronizationContext.Current
    Public Sub setOutputValue(output As Integer, value As Integer) Implements BoardInterface.setOutputValue
        Threading.Thread.Sleep(100)
        CSDConnection.send({0, 252, output, value, 0, 0, 0, 0, 0})
    End Sub

    Public Sub setButtonValue(button As Integer) Implements BoardInterface.setButtonValue
        Threading.Thread.Sleep(100)
        CSDConnection.send({0, 253, button, 0, 0, 0, 0, 0, 0})
    End Sub

    Public Sub enableAdminFunction(admin As ADMIN) Implements BoardInterface.enableAdminFunction
        Threading.Thread.Sleep(100)
        CSDConnection.send({0, 250, admin, 0, 0, 0, 0, 0, 0})
    End Sub

    Public Sub setPlungerMinMax(max As UShort, min As UShort, mid As UShort, buttonOption As Byte, plungerAverageRead As Byte, plungerLaunchButton As Byte) Implements BoardInterface.setPlungerMinMax
        Dim result As Byte() = BitConverter.GetBytes(max)
        Dim result1 As Byte() = BitConverter.GetBytes(min)
        Dim result2 As Byte() = BitConverter.GetBytes(mid)
        enableAdminFunction(ADMIN.SET_PLUNGER)
        Threading.Thread.Sleep(100)
        CSDConnection.send({result(1), result(0), result1(1), result1(0), result2(1), result2(0), buttonOption, plungerAverageRead, plungerLaunchButton})
    End Sub

    Public Sub setAccelerometerValues(multiplier As Byte, deadZone As UShort, orientation As Byte, tilt As UShort, max As UShort, tiltButton As Byte) Implements BoardInterface.setAccelerometerValues
        Dim result1 As Byte() = BitConverter.GetBytes(deadZone)
        Dim result2 As Byte() = BitConverter.GetBytes(tilt)
        Dim result3 As Byte() = BitConverter.GetBytes(max)
        enableAdminFunction(ADMIN.SET_ACCEL)
        Threading.Thread.Sleep(100)
        CSDConnection.send({multiplier, result1(1), result1(0), orientation, result2(1), result2(0), result3(1), result3(0), tiltButton})
    End Sub

    Public Sub setConfig(config As BoardConfiguration) Implements BoardInterface.setConfig
        enableAdminFunction(ADMIN.GET_CONFIG)
        Threading.Thread.Sleep(100)
        CSDConnection.send(config.toConfigBytes(config))
    End Sub

    Public Function saveConfigToEeprom() Implements BoardInterface.saveConfigToEeprom
        Threading.Thread.Sleep(100)
        enableAdminFunction(ADMIN.SAVE_CONFIG)
    End Function

    Public Sub connect(port As String) Implements BoardInterface.connect
        If port = "Auto" Then
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
        Else
            CSDConnection = New RS232(port)
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
        End If

        Throw New Exception("Unable to connect to any board")
    End Sub
    Public Sub disconnect() Implements BoardInterface.disconnect
        Try
            CSDConnection.close()
        Catch ex As Exception

        End Try
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
            Case "DEBUG", "D"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.DEBUG))
            Case "OUTPUTS", "O"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.OUTPUTS))
            Case "BUTTONS", "B"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.BUTTONS))
            Case "CONFIG", "C"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.CONFIG))
            Case "PLUNGER", "P"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.PLUNGER))
            Case "ACCEL", "A"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.ACCEL))
            Case "VERSION", "V"
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.VERSION))
            Case "RESPONSE", "R"
                If newMessage = "S" Then
                    newMessage = "Save Config Success"
                ElseIf newMessage = "E" Then
                    newMessage = "Error while saving config"
                End If
                sendBoardChanged(New BoardChangedArgs(newMessage, MESSAGE_TYPE.RESPONSE))
            Case Else
                sendBoardChanged(New BoardChangedArgs(e.message, MESSAGE_TYPE.DEBUG))
        End Select

    End Sub
    Public Sub sendRaw(value() As Byte) Implements BoardInterface.sendRaw
        CSDConnection.send(value)
    End Sub

    Public Function setBootloader(port As String) As String Implements BoardInterface.setBootloader
        Dim currentPorts As New Dictionary(Of String, String)

        For Each sp As String In My.Computer.Ports.SerialPortNames
            If Not currentPorts.ContainsKey(sp) Then
                currentPorts.Add(sp, sp)
            End If
        Next
        If currentPorts.Count > 1 And port = "Auto" Then
            Return "MULTIPLE"
        End If
        If port = "Auto" Then
            CSDConnection = New RS232(currentPorts.First().Key)
        Else
            CSDConnection = New RS232(port)
        End If

        Try
            CSDConnection.open1200()
            Thread.Sleep(700)
            CSDConnection.close()
            Thread.Sleep(700)
            Dim sps = My.Computer.Ports.SerialPortNames
            For Each spBoot As String In My.Computer.Ports.SerialPortNames
                If Not currentPorts.ContainsKey(spBoot) Then
                    Return spBoot
                End If
            Next
        Catch ex As Exception
            CSDConnection.close()
            Return currentPorts.First().Key
        End Try

        Throw New Exception("Unable to connect to any board")
    End Function
End Class
