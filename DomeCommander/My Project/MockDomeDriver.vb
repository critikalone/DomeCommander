Imports Microsoft.VisualBasic

Public Module MockDomeController1
    ' Mock status variables
    Private _slotPosition As Integer = 0
    Private _currentActivity As String = "Idle"
    Private _domeAzimuth As Integer = 0
    Private _domeTemperature As Double = 22.0
    Private _slotPower As Boolean = False

    ' Mock weather variables
    Private _weatherConditions As String = "Clear"
    Private _temperature As Double = 20.0
    Private _humidity As Double = 50.0
    Private _dewPoint As Double = 10.0

    ' Mock system alerts
    Private _systemAlerts As List(Of String) = New List(Of String) From {
        "No alerts"
    }

    ' Status updates
    Public Function GetSlotPosition() As Integer
        Return _slotPosition
    End Function

    Public Function GetCurrentActivity() As String
        Return _currentActivity
    End Function

    Public Function GetDomeAzimuth() As Integer
        Return _domeAzimuth
    End Function

    Public Function GetDomeTemperature() As Double
        Return _domeTemperature
    End Function

    Public Function GetSlotPower() As Boolean
        Return _slotPower
    End Function

    ' Dome control features
    Public Sub GoToAzimuth(value As Integer)
        _currentActivity = "Moving to azimuth " & value
        _domeAzimuth = value
        _currentActivity = "Idle"
    End Sub

    Public Sub StopDome()
        _currentActivity = "Stopped"
    End Sub

    Public Sub ParkDome()
        _currentActivity = "Parking"
        _domeAzimuth = 0
        _currentActivity = "Idle"
    End Sub

    Public Sub TurnDomeRight(steps As Integer)
        _currentActivity = "Turning right by " & steps
        _domeAzimuth = (_domeAzimuth + steps) Mod 360
        _currentActivity = "Idle"
    End Sub

    Public Sub TurnDomeLeft(steps As Integer)
        _currentActivity = "Turning left by " & steps
        _domeAzimuth = (_domeAzimuth - steps + 360) Mod 360
        _currentActivity = "Idle"
    End Sub

    Public Sub OpenSlot()
        _currentActivity = "Opening slot"
        _slotPosition = 100
        _currentActivity = "Idle"
    End Sub

    Public Sub CloseSlot()
        _currentActivity = "Closing slot"
        _slotPosition = 0
        _currentActivity = "Idle"
    End Sub

    Public Sub OpenDomePartial(value As Integer)
        _currentActivity = "Opening dome partially to " & value
        _slotPosition = value
        _currentActivity = "Idle"
    End Sub

    Public Sub GoHome()
        _currentActivity = "Going home"
        _domeAzimuth = 0
        _currentActivity = "Idle"
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
        _systemAlerts.Add(alert)
    End Sub

    Public Sub ClearSystemAlerts()
        _systemAlerts.Clear()
        _systemAlerts.Add("No alerts")
    End Sub
End Module