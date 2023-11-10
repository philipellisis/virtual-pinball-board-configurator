Imports System.IO
Imports CSDControllerTool.My
Imports CSDControllerTool.My.Resources
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class MainWindow
    Private configWindow As Configuration
    Private AccelerometerWindow As Accelerometer
    Private PlungerWindow As Plunger
    Private ButtonsWindow As Buttons
    Private OutputsWindow As Outputs

    Private version As Integer() = {1, 11, 0}
    'Private WithEvents arduino As RS232
    Private Board As BoardInterface
    Private config As BoardConfiguration
    Private connected As Boolean
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbComPort.Items.Add("Auto")
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cbComPort.Items.Add(sp)
        Next
        cbComPort.SelectedItem = "Auto"
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If connected Then
            Board.disconnect()
            btnConnect.Text = "Connect"
            btnUpdateFirmware.Enabled = True
            cbComPort.Enabled = True
            gbMenu.Enabled = False
            connected = False
        Else
            Try
                If cbSimulation.Checked = True Then
                    Board = New DummyBoard
                Else
                    Board = New CSDBoard
                End If
                Board.connect(cbComPort.SelectedItem)
                gbMenu.Enabled = True
                connected = True
                btnConnect.Text = "Disconnect"
                btnUpdateFirmware.Enabled = False
                cbComPort.Enabled = False
                AddHandler Board.BoardChanged, AddressOf Board_BoardChanged
                Board.enableAdminFunction(ADMIN.SEND_CONFIG)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub btnOutputs_Click(sender As Object, e As EventArgs) Handles btnOutputs.Click
        RemoveHandler Board.BoardChanged, AddressOf Board_BoardChanged

        OutputsWindow = New Outputs(Board)

        OutputsWindow.ShowDialog()
        AddHandler Board.BoardChanged, AddressOf Board_BoardChanged
    End Sub

    Private Sub btnInputs_Click(sender As Object, e As EventArgs) Handles btnInputs.Click
        RemoveHandler Board.BoardChanged, AddressOf Board_BoardChanged

        ButtonsWindow = New Buttons(Board, config)

        ButtonsWindow.ShowDialog()
        AddHandler Board.BoardChanged, AddressOf Board_BoardChanged
    End Sub

    Private Sub btnPlunger_Click(sender As Object, e As EventArgs) Handles btnPlunger.Click
        RemoveHandler Board.BoardChanged, AddressOf Board_BoardChanged

        PlungerWindow = New Plunger(Board, config)

        PlungerWindow.ShowDialog()
        AddHandler Board.BoardChanged, AddressOf Board_BoardChanged
    End Sub
    Private Sub Board_BoardChanged(sender As Object, e As BoardChangedArgs)
        If e.type = MESSAGE_TYPE.CONFIG Then
            config = e.config
            If config.accelerometer = False Then
                btnAccel.Enabled = False
            Else
                btnAccel.Enabled = True
            End If
            Board.enableAdminFunction(ADMIN.GET_VERSION)
        End If
        If e.type = MESSAGE_TYPE.VERSION Then
            If e.version(0) < version(0) Then
                MessageBox.Show("PinOne board is behind UI on major version, please disconnect and update firmware before continuing.")
            End If
            If e.version(1) < version(1) Then
                MessageBox.Show("PinOne board is behind on UI in minor version, Some features might not work properly. It is recommended to disconnect and update firmware before continuing.")
            End If
            If e.version(2) < version(2) Then
                MessageBox.Show("PinOne board is behind on UI in a bug fix version, it is recommended to disconnect and update firmware before continuing to ensure all features work properly.")
            End If
            If e.version(0) > version(0) Then
                MessageBox.Show("PinOne board is ahead UI on major version, please disconnect and install the latest config tool from www.clevelandsoftwaredesign.com")
            End If
            If e.version(1) > version(1) Then
                MessageBox.Show("PinOne board is ahead on UI in minor version, Some features might not work properly. It is recommended to disconnect and install the latest config tool from www.clevelandsoftwaredesign.com")
            End If
            If e.version(2) > version(2) Then
                MessageBox.Show("PinOne board is ahead on UI in a bug fix version, it is recommended to disconnect and update the config tool from www.clevelandsoftwaredesign.com before continuing to ensure all features work properly.")
            End If
        End If

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        RemoveHandler Board.BoardChanged, AddressOf Board_BoardChanged

        configWindow = New Configuration(Board, config)

        configWindow.ShowDialog()
        AddHandler Board.BoardChanged, AddressOf Board_BoardChanged
    End Sub

    Dim output As Boolean
    Private Sub btnAccel_Click(sender As Object, e As EventArgs) Handles btnAccel.Click
        RemoveHandler Board.BoardChanged, AddressOf Board_BoardChanged

        AccelerometerWindow = New Accelerometer(Board, config)


        AccelerometerWindow.ShowDialog()
        AddHandler Board.BoardChanged, AddressOf Board_BoardChanged

    End Sub

    Private Sub btnUpdateFirmware_Click(sender As Object, e As EventArgs) Handles btnUpdateFirmware.Click
        'AVRResources.avrdude

        If MessageBox.Show("Ensure you only have one CSD board connected before proceeding to install or you have the correct COM port selected, this will install the latest firmware. Click OK to continue", "Warning", MessageBoxButtons.OKCancel,
            Nothing, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
        Else
            Exit Sub
        End If
        Try
            Using output As Stream = File.OpenWrite(System.IO.Path.Combine(Application.StartupPath(), "avrdude.exe"))
                output.Write(AVRResources.avrdude, 0, AVRResources.avrdude.Length)
            End Using
            Using output As Stream = File.OpenWrite(System.IO.Path.Combine(Application.StartupPath(), "avrdude.conf"))
                output.Write(AVRResources.avrdude_conf, 0, AVRResources.avrdude_conf.Length)
            End Using
            Using output As Stream = File.OpenWrite(System.IO.Path.Combine(Application.StartupPath(), "joystick.ino.hex"))
                output.Write(AVRResources.PinOne_ino, 0, AVRResources.PinOne_ino.Length)
            End Using

            If cbSimulation.Checked = True Then
                Board = New DummyBoard
            Else
                Board = New CSDBoard
            End If
            Dim port As String = Board.setBootloader(cbComPort.SelectedItem)
            If port = "MULTIPLE" Then
                MessageBox.Show("Ensure that the PinOne is the only COM PORT device plugged into the computer before installing new firmware")
                Exit Sub
            End If
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "avrdude.exe"
            pHelp.Arguments = "-CC:avrdude.conf -v -patmega32u4 -cavr109 -P" & port & " -b57600 -D -Uflash:w:joystick.ino.hex:i"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim configFileLocation As String = System.IO.Path.Combine(Application.StartupPath(), "PinOneSettings.xml")
        Try
            Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(BoardConfiguration))
            Dim file As New System.IO.StreamWriter(configFileLocation)
            writer.Serialize(file, config)
            file.Close()
            MessageBox.Show("Successfully saved configuration file in " & configFileLocation)
        Catch ex As Exception
            MessageBox.Show("error saving PinOne configuration file. Ensure you have write access to the location and try again")
        End Try


    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        Dim configFileLocation As String = System.IO.Path.Combine(Application.StartupPath(), "PinOneSettings.xml")
        If File.Exists(configFileLocation) Then
            Try

                Dim xmldoc As New XmlDocument
                xmldoc.Load(configFileLocation)
                Dim allText As String = xmldoc.InnerXml

                Using currentStringReader As New StringReader(allText)
                    Dim xml As New XmlSerializer(GetType(BoardConfiguration))
                    Dim board As BoardConfiguration = TryCast(xml.Deserialize(currentStringReader), BoardConfiguration)
                    config.copyValues(board)
                End Using
                MessageBox.Show("Successfully retrieved configuration file in " & configFileLocation & vbNewLine & "Configuration will not be saved to PinOne until you click the 'upload config' button in the settings screen")
            Catch ex As Exception
                MessageBox.Show("error saving PinOne configuration file. Ensure the file exists and try again")
            End Try
        Else
            MessageBox.Show("No configuration file found at " & configFileLocation)
        End If


    End Sub

End Class
