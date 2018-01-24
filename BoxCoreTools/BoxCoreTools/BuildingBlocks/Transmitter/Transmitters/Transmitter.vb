Public MustInherit Class Transmitter
  Inherits ConfigurableDevice

  <CustomDataAttribute(True, "Config")>
  Public Property Host As String

  <CustomDataAttribute(True, "Config")>
  Public Property Port As Integer

  Public Sub New()
    MyBase.Name = Me.GetType().Name
  End Sub

  Public MustOverride Sub Connect()
  Public MustOverride Sub Disconnect()
  Public MustOverride Sub SendData(data As String)
  Public MustOverride Sub SendData(data() As Byte)

  Public Overrides Function ToString() As String
    Return Me.Name & " <" & Me.GetType().Name & " port " & Me.Port & ">"
  End Function
End Class
