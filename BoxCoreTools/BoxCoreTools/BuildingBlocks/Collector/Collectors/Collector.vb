Public MustInherit Class Collector
  Inherits ConfigurableDevice

  Public Event DataArrived(ByRef sender As Collector, data() As Byte, dataString As String)

  <CustomDataAttribute(True, "Config")>
  Public Property Port As Integer

  Public Sub New()
    MyBase.Name = Me.GetType().Name
  End Sub

  Public MustOverride Sub Connect()
  Public MustOverride Sub Disconnect()

  Public Overrides Function ToString() As String
    Return Me.Name & " <" & Me.GetType().Name & " port " & Me.Port & ">"
  End Function

End Class
