Imports Microsoft.VisualBasic

Public Module MockDomeController
    ' Mock dome variables
    Private _domeTurningSteps As Integer = 360
    Private _domeTurningInterval As Integer = 1

    ' Mock status variables
    Private _slotPosition As Integer = 0
    Private _currentActivity As String = "Idle"
    Private _domeAzimuth As Integer = 0
    Private _domeTemperature As Double = 22.0
    Private _slotPower As String = "11.9Vdc"

    ' Mock weather variables
    Private _weatherConditions As String = "Clear"
    Private _temperature As Double = 20.0
    Private _humidity As Double = 50.0
    Private _dewPoint As Double = 10.0

    ' Mock system alerts
    Private _systemAlerts As List(Of String) = New List(Of String) From {
        "No alerts"
    }
    ' Mock dome information
    Public Function GetTurningSteps() As Integer
        Return _domeTurningSteps
    End Function

    Public Function GetTurningInterval() As Integer
        Return _domeTurningInterval
    End Function

    ' Status updates
    Public Function GetSlotPosition() As Integer
        If _slotPosition = 0 Then
            Return 0
        ElseIf _slotPosition = 100 Then
            Return 100
        Else
            Return 50
        End If
    End Function

    Public Function GetCurrentActivity() As String
        Return _currentActivity
    End Function

    Public Function SetCurrentActivity(activity As String)
        _currentActivity = activity
    End Function

    Public Function GetDomeAzimuth() As Integer
        Return _domeAzimuth
    End Function

    Public Function GetDomeTemperature() As Double
        Return _domeTemperature
    End Function

    Public Function GetSlotPower() As String
        Return _slotPower
    End Function

    ' Dome control features
    Public Sub SetAzimuth(value As Integer)
        _domeAzimuth = value
    End Sub

    Public Sub StopDome()
        _currentActivity = "Stopped"
    End Sub

    Public Async Sub ParkDome()
        _domeAzimuth = 0
    End Sub

    Public Async Sub OpenSlot()
        _slotPosition = 100
    End Sub

    Public Async Sub CloseSlot()
        _slotPosition = 0
    End Sub

    Public Async Sub OpenDomePartial(value As Integer)
        _slotPosition = value
    End Sub

    Public Async Sub CloseDomePartial(value As Integer)
        _slotPosition = value
    End Sub

    Public Async Sub GoHome()
        _domeAzimuth = 0
    End Sub

    ' Weather conditions
    Public Function GetWeatherConditions() As String
        Return _weatherConditions
    End Function

    Public Function GetTemperature() As Double
        Return _temperature
    End Function

    Public Function GetHumidity() As Double
        Return _humidity
    End Function

    Public Function GetDewPoint() As Double
        Return _dewPoint
    End Function

    ' Update weather conditions (for simulation purposes)
    Public Sub UpdateWeather(conditions As String, temperature As Double, humidity As Double, dewPoint As Double)
        _weatherConditions = conditions
        _temperature = temperature
        _humidity = humidity
        _dewPoint = dewPoint
    End Sub

    ' System alerts
    Public Function GetSystemAlerts() As List(Of String)
        Return _systemAlerts
    End Function

    Public Sub AddSystemAlert(alert As String)
        _systemAlerts.Remove("No alerts")
        _systemAlerts.Add(alert)
    End Sub

    Public Sub ClearSystemAlerts()
        _systemAlerts.Clear()
        _systemAlerts.Add("No alerts")
    End Sub
End Module