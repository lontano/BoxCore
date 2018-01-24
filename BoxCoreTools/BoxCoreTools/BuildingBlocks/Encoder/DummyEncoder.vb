Public Class DummyEncoder
  Inherits Encoder

  Private WithEvents _timer As New Timer
  Private _lastFrameCount As Integer = 0

  Private Sub _timer_Tick(sender As Object, e As EventArgs) Handles _timer.Tick
    Me.RaiseFrameEncodedEvent(New FrameCodificationInfo(_lastFrameCount))
    _lastFrameCount += 1
  End Sub

  Public Overrides Function Run() As Integer
    _timer.Interval = 20
    _timer.Enabled = True
    Return 0
  End Function

  Public Overrides Function [Stop]() As Integer
    _timer.Enabled = False
    Return 0
  End Function
End Class
