Imports Newtonsoft.Json

Public MustInherit Class ConfigurableDevice
#Region "Properties"
  Public Property ID As String = "0"
  Public Property Name As String = Me.GetType().Name

  Public Enum eDeviceState
    Idle
    Enabled
    [Error]
  End Enum
  Public Property State As eDeviceState = eDeviceState.Idle

  Public Property LastErrorID As Integer = 0
  Public Property LastErrorString As String = ""

  <JsonIgnore()>
  Public Property Stats As New RealTimeStats()
#End Region

#Region "Events"
  Public Event StateChanged(ByRef sender As ConfigurableDevice, newState As eDeviceState)
  Public Event [Error](ByRef sender As ConfigurableDevice, errorID As Integer, errorString As String)
  Public Event StatChanged(ByRef sender As ConfigurableDevice, stat As RealTimeStat)
#End Region

#Region "Constructors"
  Public Sub New()

  End Sub

  Public Sub New(id As String)
    Me.ID = id
  End Sub
#End Region

#Region "Functions"
  Public Function SetStatValue(statId As String, value As Double) As RealTimeStat
    Dim stat As RealTimeStat = Nothing
    Try
      stat = Me.Stats.SetValue(statId, value)
      RaiseEvent StatChanged(Me, stat)
    Catch ex As Exception
    End Try
    Return stat
  End Function

  Public Sub SetState(newState As eDeviceState)
    Try
      Me.State = newState
      RaiseEvent StateChanged(Me, newState)
    Catch ex As Exception
    End Try
  End Sub
#End Region

End Class
