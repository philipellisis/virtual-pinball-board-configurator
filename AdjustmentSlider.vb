Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class AdjustmentSlider


    Private _config As BoardConfiguration
    Private outputNumber As Byte
    Private outputOn As Boolean = False
    Private _delayRefresh As Boolean = False
    Private _board As BoardInterface
    Private _intensityValue As Byte = 0
    Private trd As Thread = New Thread(AddressOf delayRefresh)
    Private trdCount As Integer = 5
    Public Sub New(outputNumber As Byte, config As BoardConfiguration, board As BoardInterface)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For i As Integer = 0 To 255
            cbMilliseconds.Items.Add(i * 100)
        Next
        Me.outputNumber = outputNumber
        _config = config
        gbMain.Text = "Output #" & (outputNumber + 1).ToString

        tbMaxValue.Value = _config.maxOutputState(outputNumber)
        tbOffValue.Value = _config.turnOffState(outputNumber)

        If _config.toySpecialOption(outputNumber) = 0 Then
            cbCatagory.SelectedItem = "Normal"
        ElseIf _config.toySpecialOption(outputNumber) = 1 Then
            cbCatagory.SelectedItem = "Noisy"
        ElseIf _config.toySpecialOption(outputNumber) = 2 Then
            cbCatagory.SelectedItem = "Light Show Medium"
        ElseIf _config.toySpecialOption(outputNumber) = 3 Then
            cbCatagory.SelectedItem = "Light Show High"
        ElseIf _config.toySpecialOption(outputNumber) = 4 Then
            cbCatagory.SelectedItem = "Shared"
        End If
        If outputNumber > 9 Then
            cbCatagory.Items.Remove("Shared")
        End If
        If outputNumber > 3 And outputNumber < 15 Then
            tbMaxValue.Enabled = False
        End If
        cbCatagory.SelectedItem = _config.toySpecialOption(outputNumber)
        cbMilliseconds.SelectedItem = _config.maxOutputTime(outputNumber) * 100
        lblMinValue.Text = tbOffValue.Value
        lblMaxValue.Text = tbMaxValue.Value
        _board = board

    End Sub

    Private Sub tbMaxValue_Scroll(sender As Object, e As EventArgs) Handles tbMaxValue.Scroll
        _config.maxOutputState(outputNumber) = tbMaxValue.Value
        lblMaxValue.Text = tbMaxValue.Value

        _delayRefresh = True
        _intensityValue = tbMaxValue.Value
        'setButton(tbIntensity.Value)
        If trd.IsAlive = False Then
            Console.WriteLine("starting new thread")
            trd = New Thread(AddressOf delayRefresh)
            trd.IsBackground = True
            trd.Start()
        Else
            trdCount = 5
            Console.WriteLine("making thread last longer")
        End If
    End Sub
    Sub delayRefresh()
        Do Until trdCount = 0
            Thread.Sleep(100)
            trdCount -= 1
        Loop
        trdCount = 5
        Try
            _board.setOutputValue(outputNumber, _intensityValue)
        Catch ex As Exception

        End Try

        Thread.Sleep(500)
        _delayRefresh = False
    End Sub

    Private Sub tbOffValue_Scroll(sender As Object, e As EventArgs) Handles tbOffValue.Scroll
        _config.turnOffState(outputNumber) = tbOffValue.Value
        lblMinValue.Text = tbOffValue.Value
    End Sub

    Private Sub cbMilliseconds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMilliseconds.SelectedIndexChanged
        _config.maxOutputTime(outputNumber) = CInt(cbMilliseconds.SelectedItem) / 100
    End Sub

    Private Sub cbCatagory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCatagory.SelectedIndexChanged
        If cbCatagory.SelectedItem = "Normal" Then
            _config.toySpecialOption(outputNumber) = 0
        ElseIf cbCatagory.SelectedItem = "Noisy" Then
            _config.toySpecialOption(outputNumber) = 1
        ElseIf cbCatagory.SelectedItem = "Light Show Medium" Then
            _config.toySpecialOption(outputNumber) = 2
        ElseIf cbCatagory.SelectedItem = "Light Show High" Then
            _config.toySpecialOption(outputNumber) = 3
        ElseIf cbCatagory.SelectedItem = "Shared" Then
            _config.toySpecialOption(outputNumber) = 4
        End If
    End Sub

    Private Sub btnOnOff_Click(sender As Object, e As EventArgs) Handles btnOnOff.Click
        Try
            If outputOn = False Then
                _board.setOutputValue(outputNumber, tbMaxValue.Value)
            Else
                _board.setOutputValue(outputNumber, 0)
            End If
        Catch ex As Exception
            MessageBox.Show("error setting output value, check to ensure board is connected")
        End Try

    End Sub
    Public Sub setIntensityValue(val As Byte)
        If _delayRefresh = False Then
            setButton(val)
        End If
    End Sub
    Private Sub setButton(val As Integer)
        If val > 0 Then
            btnOnOff.Text = "On"
            btnOnOff.BackColor = Color.DarkGreen
            outputOn = True
        Else
            btnOnOff.Text = "Off"
            btnOnOff.BackColor = Color.Red
            outputOn = False
        End If
    End Sub

    Private Sub gbMain_Enter(sender As Object, e As EventArgs) Handles gbMain.Enter

    End Sub
End Class
