Public Class Collector_UDP
  Inherits Collector

  <CustomDataAttribute(True, "Config")>
  Public Property IsBroadcast As Boolean = False

  Public Overrides Sub Connect()
    Throw New NotImplementedException()
  End Sub

  Public Overrides Sub Disconnect()
    Throw New NotImplementedException()
  End Sub
End Class
