Imports Microsoft.VisualBasic

Public Module DomeUtilities
    Public Function IsPositive(number As Integer) As Boolean
        If number >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function SpinCW(userInput As Integer, maxSteps As Integer) As Integer
        Dim azimuth As Integer

        If userInput = maxSteps Then
            Return 0
        Else
            azimuth = userInput Mod maxSteps
        End If
        Return azimuth
    End Function

    Public Function SpinCCW(userInput As Integer, maxSteps As Integer) As Integer
        Dim azimuth As Integer = userInput Mod maxSteps
        Return azimuth
    End Function

    Public Function GetPointingQuarter(currentAzimuth As Integer, maxSteps As Integer) As Integer
        Dim pointingQuarter As Integer
        If 0 <= currentAzimuth < (maxSteps / 4) Then
            pointingQuarter = 0
        ElseIf (maxSteps / 4) <= currentAzimuth < (maxSteps / 2) Then
            pointingQuarter = 1
        ElseIf (maxSteps / 2) <= currentAzimuth < 3 * (maxSteps / 4) Then
            pointingQuarter = 2
        Else
            pointingQuarter = 3
        End If
    End Function

    Public Function SpinDirection(currentAzimuth As Integer, newAzimuth As Integer, maxSteps As Integer) As Integer
        Dim goCW As Integer
        Dim goCCW As Integer
        ' Spin Direction 0 = Left, 1 = Right, 3 = no move
        If currentAzimuth = newAzimuth Then
            Return 3
        End If
        If newAzimuth > currentAzimuth Then
            goCW = newAzimuth - currentAzimuth
            goCCW = (maxSteps - newAzimuth) + currentAzimuth
        Else
            goCW = (maxSteps - currentAzimuth) + newAzimuth
            goCCW = currentAzimuth - newAzimuth
        End If
        If goCW < goCCW Then
            Return 1
        Else
            Return 0
        End If

    End Function
End Module
