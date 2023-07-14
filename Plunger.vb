Public Class Plunger
    Private WithEvents _board As BoardInterface
    Private _config As BoardConfiguration
    Private maxValue As UShort = 0
    Private minvalue As UShort = 1024
    Private tempRestingValue As UShort = 0
    Private restingValue As UShort = 0
    Private restingCount As UShort = 0
    Public Sub New(board As BoardInterface, config As BoardConfiguration)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
        _config = config
    End Sub
    Private Sub Plunger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _board.enableAdminFunction(ADMIN.PLUNGER)
        Catch ex As Exception
            MessageBox.Show("Error entering plunger mode. Ensure board is connected")
        End Try

        If _config.buttonOption = 1 Or _config.buttonOption = 3 Then
            cbPushOnMax.Checked = True
        End If
        If _config.buttonOption >= 2 Then
            cbPushOnMin.Checked = True
        End If
    End Sub

    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles _board.BoardChanged
        Try
            If e.type = MESSAGE_TYPE.PLUNGER Then
                pbPlunger.Value = e.plunger + 1
                pbPlunger.Value = e.plunger
                If maxValue < e.plunger Then
                    maxValue = e.plunger
                    lblMaxValue.Text = e.plunger.ToString
                End If
                If minvalue > e.plunger Then
                    minvalue = e.plunger
                    lblMinValue.Text = e.plunger.ToString
                End If
                If tempRestingValue > e.plunger - 2 And tempRestingValue < e.plunger + 2 Then
                    restingCount += 1
                Else
                    tempRestingValue = e.plunger
                    restingCount = 0
                End If

                If restingCount > 50 Then
                    lblRestingPoint.Text = e.plunger.ToString
                    restingValue = e.plunger
                End If
            End If
            If e.type = MESSAGE_TYPE.RESPONSE Then
                MessageBox.Show(e.message)
            End If
        Catch ex As Exception

        End Try



    End Sub
    Private Sub Outputs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            _board.enableAdminFunction(ADMIN.OFF)
        Catch ex As Exception
            MessageBox.Show("Error exiting admin mode. Check to ensure board is connected")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim buttonOption As Byte = 0
            If cbPushOnMax.Checked And cbPushOnMin.Checked Then
                buttonOption = 3
            ElseIf cbPushOnMax.Checked Then
                buttonOption = 1
            ElseIf cbPushOnMin.Checked Then
                buttonOption = 2
            End If
            _board.setPlungerMinMax(maxValue, minvalue, restingValue, buttonOption)
            _config.plungerMax = maxValue
            _config.plungerMin = minvalue
            _config.plungerMid = restingValue
            _config.buttonOption = buttonOption
        Catch ex As Exception
            MessageBox.Show("Error while saving plunger values, check to ensure board is connected")
        End Try


    End Sub
End Class