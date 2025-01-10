Imports System.Reflection
Imports System.Reflection.Metadata
Imports System.Threading.Channels

Public Class Form1
    Private _turning As Boolean = False
    Private _stopLoop As Boolean = False
    Private _newAzimuth As Integer = 0
    Private _smallDelay As Integer = 5000
    Private _bigDelay As Integer = 10000

    Private Sub Load_Radio_Button_Positions()
        If MockDomeController.GetSlotPosition() = 100 Then
            RadioDomeControlOpenFull.Checked = True
        ElseIf MockDomeController.GetSlotPosition() = 0 Then
            RadioDomeControlClosed.Checked = True
        Else
            RadioDomeControlOpenPart.Checked = True
        End If
    End Sub

    Private Sub updateSlotPosition()
        If MockDomeController.GetSlotPosition() = 0 Then
            lblStatusSlotPosition.Text = "Closed"
        ElseIf MockDomeController.GetSlotPosition() = 100 Then
            lblStatusSlotPosition.Text = "Open"
        Else
            lblStatusSlotPosition.Text = "Partially Open"
        End If
    End Sub
    Private Sub Load_Status()

        lblStatusCondition.Text = MockDomeController.GetCurrentActivity()
        lblStatusAz.Text = MockDomeController.GetDomeAzimuth()
        lblStatusDomeTemp.Text = MockDomeController.GetDomeTemperature()
        lblStatusSlotPower.Text = MockDomeController.GetSlotPower()
    End Sub

    Private Sub Load_Weather()
        lblWxCondition.Text = MockDomeController.GetWeatherConditions()
        lblWxTemp.Text = MockDomeController.GetTemperature()
        lblWxHumidity.Text = MockDomeController.GetHumidity()
        lblWxDewPoint.Text = MockDomeController.GetDewPoint()
    End Sub

    Private Sub Load_Alerts()
        For Each alert As String In MockDomeController.GetSystemAlerts()
            ListAlerts.Items.Add(alert)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateSlotPosition()
        Load_Status()
        Load_Radio_Button_Positions()
        Load_Weather()
        Load_Alerts()
    End Sub

    Private Sub txtDomeControlAz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDomeControlAz.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDomeControlAz_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDomeControlAz.Validating
        Dim currentAzimuth As Integer = MockDomeController.GetDomeAzimuth
        Dim maxSteps As Integer = MockDomeController.GetTurningSteps()
        Dim userInput As Integer
        Dim newAzimuth As Integer
        If Integer.TryParse(txtDomeControlAz.Text, userInput) Then
            If DomeUtilities.IsPositive(userInput) = True Then
                ' Do something positive
                If userInput >= maxSteps Then
                    newAzimuth = DomeUtilities.SpinCW(userInput, maxSteps)
                End If
            Else
                ' Do something negative
                If -1 * userInput >= maxSteps Then
                    newAzimuth = DomeUtilities.SpinCCW(userInput, maxSteps)
                End If
            End If
            _newAzimuth = newAzimuth
        Else
            MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Async Sub btnDomeControlGo_Click(sender As Object, e As EventArgs) Handles BtnDomeControlGo.Click
        Dim SpinDirection As Integer
        Dim currentAz As Integer = MockDomeController.GetDomeAzimuth()
        Dim azimuth As Integer

        If String.IsNullOrWhiteSpace(txtDomeControlAz.Text) Then
            MessageBox.Show("The azimuth field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDomeControlAz.Focus()
            Return
        End If

        If Integer.TryParse(txtDomeControlAz.Text, azimuth) Then
            ' Spin Direction 0 = Left and 1 = Right
            SpinDirection = DomeUtilities.SpinDirection(MockDomeController.GetDomeAzimuth(), Int(txtDomeControlAz.Text), MockDomeController.GetTurningSteps())
            MockDomeController.SetAzimuth(azimuth)
            MockDomeController.SetCurrentActivity("Turning to Position")
            Load_Status()

            While Not currentAz = azimuth
                If _stopLoop = True Then
                    MockDomeController.SetAzimuth(currentAz)
                    MockDomeController.SetCurrentActivity("Idle")
                    Load_Status()
                    _stopLoop = False
                    Return
                End If
                If SpinDirection = 1 Then
                    If currentAz = MockDomeController.GetTurningSteps() - 1 Then
                        currentAz = 0
                    Else
                        currentAz = currentAz + 1
                        RotateImageBasedOnLabel(currentAz)
                        Await Task.Delay(10)
                        MockDomeController.SetAzimuth(currentAz)
                        Load_Status()
                    End If
                ElseIf SpinDirection = 0 Then
                    If currentAz = 0 Then
                        currentAz = MockDomeController.GetTurningSteps() - 1
                    Else
                        currentAz = currentAz - 1
                        RotateImageBasedOnLabel(currentAz)
                        Await Task.Delay(10)
                        MockDomeController.SetAzimuth(currentAz)
                        Load_Status()
                    End If
                End If
            End While
            MockDomeController.SetCurrentActivity("Idle")
            Load_Status()


        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDomeControlOpenFull.CheckedChanged

    End Sub

    Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnDomeControlChangeSlotPos.Click
        '0 = slot position closed, 100 = slot position open
        If RadioDomeControlOpenFull.Checked = True AndAlso Not MockDomeController.GetSlotPosition() = 100 Then 'Open Slot

            MockDomeController.SetCurrentActivity("Opening Dome")
            Load_Status()
            MockDomeController.OpenSlot()
            Await Task.Delay(_smallDelay)
            updateSlotPosition()
            MockDomeController.SetCurrentActivity("Idle")
            Load_Status()
        ElseIf RadioDomeControlClosed.Checked = True AndAlso Not MockDomeController.GetSlotPosition() = 0 Then 'Close slot
            MockDomeController.SetCurrentActivity("Closing Dome")
            Load_Status()
            MockDomeController.CloseSlot()
            Await Task.Delay(_smallDelay)
            MockDomeController.SetCurrentActivity("Idle")
            Load_Status()
        Else 'Partially open slot
            If MockDomeController.GetSlotPosition() = 0 Then
                MockDomeController.SetCurrentActivity("Opening Dome Partially")
                Load_Status()
                MockDomeController.OpenDomePartial(50)
                Await Task.Delay(_smallDelay)
                updateSlotPosition()
                MockDomeController.SetCurrentActivity("Idle")
                Load_Status()
            ElseIf MockDomeController.GetSlotPosition() = 100 Then
                MockDomeController.SetCurrentActivity("Closing Dome Partially")
                Load_Status()
                MockDomeController.CloseDomePartial(50)
                Await Task.Delay(_smallDelay)
                updateSlotPosition()
                MockDomeController.SetCurrentActivity("Idle")
                Load_Status()
            End If
        End If
    End Sub

    Private Sub BtnDomeControlStop_Click(sender As Object, e As EventArgs) Handles BtnDomeControlStop.Click
        _stopLoop = True
    End Sub

    Private Sub BtnDomeControlRightTurn_Click(sender As Object, e As EventArgs) Handles BtnDomeControlRightTurn.Click
        Dim currentPos As Integer = Int(lblStatusAz.Text)
        Dim rollOver As Integer = 0
        If lblStatusCondition.Text = "Moving to new position" Then
            Return
        End If
        If currentPos + 5 > 359 Then
            rollOver = (currentPos + 4) - 359
            currentPos = rollOver
            MockDomeController.SetAzimuth(currentPos)
        Else
            MockDomeController.SetAzimuth(currentPos + 5)
        End If
        lblStatusAz.Text = MockDomeController.GetDomeAzimuth()
        Dim angle As Integer = Integer.Parse(lblStatusAz.Text)
        RotateImageBasedOnLabel(angle)
    End Sub

    Private Sub BtnDomeControlLeftTurn_Click(sender As Object, e As EventArgs) Handles BtnDomeControlLeftTurn.Click
        Dim currentPos As Integer = Int(lblStatusAz.Text)
        Dim rollOver As Integer = 0
        If lblStatusCondition.Text = "Moving to new position" Then
            Return
        End If
        If currentPos - 5 < 0 Then
            rollOver = (currentPos - 4) + 359
            currentPos = rollOver
            MockDomeController.SetAzimuth(currentPos)
        Else
            MockDomeController.SetAzimuth(currentPos - 5)
        End If
        lblStatusAz.Text = MockDomeController.GetDomeAzimuth()
        Dim angle As Integer = Integer.Parse(lblStatusAz.Text)
        RotateImageBasedOnLabel(angle)
    End Sub

    Private Sub RotateImageBasedOnLabel(angle As Integer) 'Draws the rotated image given an angle
        Try
            If angle < 0 OrElse angle > MockDomeController.GetTurningSteps - 1 Then
                MessageBox.Show("Rotation angle must be between 0 and 359!.", "Invalid Angle", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim originalImage As Image = Image.FromFile("dome.png")
            Dim rotatedImage As New Bitmap(originalImage.Width, originalImage.Height)
            rotatedImage.SetResolution(originalImage.HorizontalResolution, originalImage.VerticalResolution)

            Using g As Graphics = Graphics.FromImage(rotatedImage)
                g.TranslateTransform(CSng(originalImage.Width) / 2, CSng(originalImage.Height) / 2)
                g.RotateTransform(angle)
                g.TranslateTransform(-CSng(originalImage.Width) / 2, -CSng(originalImage.Height) / 2)
                g.DrawImage(originalImage, New Point(0, 0))
            End Using
            DomeGraphic.Image = rotatedImage

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RotateGraphicsLoop2(newAngle As Integer, currentAngle As Integer, direction As Integer)
        Dim delta As Integer = 0
        If direction = 0 Then 'Go left
            If newAngle > currentAngle Then 'We are crossing zero
                delta = (DomeCommander.GetTurningSteps() - newAngle) + currentAngle
            Else 'No need to treat the delta special
                delta = newAngle - currentAngle
            End If
        ElseIf direction = 1 Then 'Go right
            If newAngle < currentAngle Then 'We are crossing zero
                delta = (DomeCommander.GetTurningSteps() - currentAngle) + newAngle
            Else 'No need to treat the delta special
                delta = newAngle - currentAngle
            End If
        Else
            Return
        End If

        Dim pointer As Integer = currentAngle
        For i As Integer = 1 To delta + 1
            'Check for Stop condition and Return if required
            lblStatusAz.Text = pointer
            If direction = 0 Then 'Go left again
                If pointer = 1 Then
                    pointer = DomeCommander.GetTurningSteps() - 1
                Else
                    pointer = pointer - 1
                End If
            ElseIf direction = 1 Then 'Go right again
                If pointer = DomeCommander.GetTurningSteps() - 1 Then
                    pointer = 0
                Else
                    pointer = pointer + 1
                End If
            End If
            i = i + 1

            DomeCommander.SetAzimuth(pointer)
            RotateImageBasedOnLabel(pointer)
            Load_Status()
        Next
    End Sub

    Private Async Sub RotateGraphicLoop(value As Integer, angle As Integer) 'Changes the Angle and calls the draw function
        While True
            _turning = True
            If value > angle Then

                For i As Integer = angle To value
                    lblStatusAz.Text = angle.ToString()
                    angle = angle + 1
                    RotateImageBasedOnLabel(angle)
                    Await Task.Delay(30)
                    If _stopLoop = True Then
                        _stopLoop = False
                        _turning = False
                        Return
                    End If
                Next
                lblStatusCondition.Text = MockDomeController.GetCurrentActivity()
                lblStatusAz.Text = MockDomeController.GetDomeAzimuth()
                Return
            ElseIf angle > value Then
                For i As Integer = angle To 358
                    lblStatusAz.Text = angle.ToString()
                    angle = angle + 1
                    RotateImageBasedOnLabel(angle)
                    Await Task.Delay(30)
                    If _stopLoop = True Then
                        _stopLoop = False
                        _turning = False
                        Return
                    End If
                Next
                angle = 0
            Else
                angle = 0
                lblStatusAz.Text = angle.ToString
            End If
        End While
        lblStatusCondition.Text = MockDomeController.GetCurrentActivity()
        lblStatusAz.Text = MockDomeController.GetDomeAzimuth()
    End Sub

    Private Async Sub BtnDomeControlPark_Click(sender As Object, e As EventArgs) Handles BtnDomeControlPark.Click
        Dim currentAz As Integer = MockDomeController.GetDomeAzimuth()
        MockDomeController.SetCurrentActivity("Parking")
        Load_Status()
        'Load_Status()
        While Not currentAz = 0
            If _stopLoop = True Then
                MockDomeController.SetAzimuth(currentAz)
                MockDomeController.SetCurrentActivity("Idle")
                Load_Status()
                _stopLoop = False
                Return
            End If
            If currentAz >= MockDomeController.GetTurningSteps() / 2 Then
                RotateImageBasedOnLabel(currentAz)
                currentAz = currentAz + 1
                If currentAz = 360 Then
                    currentAz = 0
                End If
                Await Task.Delay(10)
                MockDomeController.SetAzimuth(currentAz)
                Load_Status()
            Else
                RotateImageBasedOnLabel(currentAz)
                currentAz = currentAz - 1
                Await Task.Delay(10)
                MockDomeController.SetAzimuth(currentAz)
                Load_Status()
            End If
        End While
        MockDomeController.SetCurrentActivity("Closing Dome")
        Load_Status()
        Await Task.Delay(1000)
        MockDomeController.CloseSlot()
        MockDomeController.SetCurrentActivity("Idle")
        updateSlotPosition()
        Load_Status()
    End Sub

    Private Async Sub BtnDomeControlOpen_Click(sender As Object, e As EventArgs) Handles BtnDomeControlOpen.Click
        MockDomeController.SetCurrentActivity("Opening Dome")
        Load_Status()
        MockDomeController.OpenSlot()
        Await Task.Delay(_smallDelay)
        updateSlotPosition()
        MockDomeController.SetCurrentActivity("Idle")
        Load_Status()
    End Sub

    Private Async Sub BtnDomeControlClose_Click(sender As Object, e As EventArgs) Handles BtnDomeControlClose.Click
        MockDomeController.SetCurrentActivity("Closing Dome")
        Load_Status()
        MockDomeController.CloseSlot()
        Await Task.Delay(_smallDelay)
        MockDomeController.SetCurrentActivity("Idle")
        Load_Status()
    End Sub

    Private Sub PicDomeControlStop_Click(sender As Object, e As EventArgs) Handles PicDomeControlStop.Click
        _stopLoop = True
    End Sub

    Private Async Sub PicDomeControlHome_Click(sender As Object, e As EventArgs) Handles PicDomeControlHome.Click
        Dim currentAz As Integer = MockDomeController.GetDomeAzimuth()
        MockDomeController.SetCurrentActivity("Going Home")
        Load_Status()
        'Load_Status()
        While Not currentAz = 0
            If _stopLoop = True Then
                MockDomeController.SetAzimuth(currentAz)
                MockDomeController.SetCurrentActivity("Idle")
                Load_Status()
                _stopLoop = False
                Return
            End If
            If currentAz >= MockDomeController.GetTurningSteps() / 2 Then
                RotateImageBasedOnLabel(currentAz)
                currentAz = currentAz + 1
                If currentAz = 360 Then
                    currentAz = 0
                End If
                Await Task.Delay(10)
                MockDomeController.SetAzimuth(currentAz)
                Load_Status()
            Else
                RotateImageBasedOnLabel(currentAz)
                currentAz = currentAz - 1
                Await Task.Delay(10)
                MockDomeController.SetAzimuth(currentAz)
                Load_Status()
            End If
        End While
        MockDomeController.SetCurrentActivity("Idle")
        updateSlotPosition()
        Load_Status()
    End Sub
End Class
