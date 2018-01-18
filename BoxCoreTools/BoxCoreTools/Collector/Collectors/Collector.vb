Public MustInherit Class Collector
  Inherits ConfigurableDevice

  Public Event DataArrived(ByRef sender As Collector, data() As Byte, dataString As String)

  <CustomDataAttribute(True, "Config")>
  Public Property Port As Integer

  Public Sub New()
    MyBase.Name = Me.GetType().Name
    MyBase.ID = "0"
  End Sub

  Public MustOverride Sub Connect()
  Public MustOverride Sub Disconnect()

End Class
