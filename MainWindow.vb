Imports System.IO
Imports CSDControllerTool.My
Imports CSDControllerTool.My.Resources
Imports System.Windows.Forms

Public Class MainWindow
    'Private WithEvents arduino As RS232
    Private WithEvents Board As BoardInterface
    Private config As BoardConfiguration
    Private connected As Boolean
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If connected Then
            Board.disconnect()
            btnConnect.Text = "Connect"
            btnUpdateFirmware.Enabled = True
            gbMenu.Enabled = False
            connected = False
        Else
            Try
                If cbSimulation.Checked = True Then
                    Board = New DummyBoard
                Else
                    Board = New CSDBoard
                End If
                Board.connect()
                gbMenu.Enabled = True
                connected = True
                btnConnect.Text = "Disconnect"
                btnUpdateFirmware.Enabled = False
                Board.enableAdminFunction(ADMIN.SEND_CONFIG)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub btnOutputs_Click(sender As Object, e As EventArgs) Handles btnOutputs.Click
        Dim outputs As New Outputs(Board)
        outputs.ShowDialog()
    End Sub

    Private Sub btnInputs_Click(sender As Object, e As EventArgs) Handles btnInputs.Click
        Dim buttons As New Buttons(Board)
        buttons.ShowDialog()
    End Sub

    Private Sub btnPlunger_Click(sender As Object, e As EventArgs) Handles btnPlunger.Click
        Dim plunger As New Plunger(Board, config)
        plunger.ShowDialog()
    End Sub
    Private Sub Board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles Board.BoardChanged
        If e.type = MESSAGE_TYPE.CONFIG Then
            config = e.config
        End If

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim configMenu As New Configuration(Board, config)
        configMenu.ShowDialog()
    End Sub

    Dim output As Boolean
    Private Sub btnAccel_Click(sender As Object, e As EventArgs) Handles btnAccel.Click
        Dim accelerometer As New Accelerometer(Board, config)
        accelerometer.ShowDialog()

    End Sub

    Private Sub btnUpdateFirmware_Click(sender As Object, e As EventArgs) Handles btnUpdateFirmware.Click
        'AVRResources.avrdude
        If MessageBox.Show("Ensure you only have one CSD board connected before proceeding to install, this will erase all memory from the device and install the latest firmware. Click OK to continue", "Warning", MessageBoxButtons.OKCancel,
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
            Dim port As String = Board.setBootloader()
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
End Class
