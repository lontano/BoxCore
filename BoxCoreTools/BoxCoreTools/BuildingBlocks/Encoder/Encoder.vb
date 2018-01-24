Public MustInherit Class Encoder
  Inherits ConfigurableDevice

#Region "Events"
  Public Event FrameEncoded(sender As Encoder, frameCodificationInfo As FrameCodificationInfo)
#End Region

#Region "CTL functions"
  Public MustOverride Function Run() As Integer
  Public MustOverride Function [Stop]() As Integer
#End Region

#Region "Raise event functions"
  Public Sub RaiseFrameEncodedEvent(frameCodificationInfo As FrameCodificationInfo)
    RaiseEvent FrameEncoded(Me, frameCodificationInfo)
  End Sub
#End Region
End Class
