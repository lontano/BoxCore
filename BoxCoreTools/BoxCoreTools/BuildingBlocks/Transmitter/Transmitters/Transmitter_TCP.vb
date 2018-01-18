Public Class Transmitter_TCP
  Inherits Transmitter

  Public Overrides Sub Connect()
    Throw New NotImplementedException()
  End Sub

  Public Overrides Sub Disconnect()
    Throw New NotImplementedException()
  End Sub

  Public Overrides Sub SendData(data() As Byte)
    Throw New NotImplementedException()
  End Sub

  Public Overrides Sub SendData(data As String)
    Throw New NotImplementedException()
  End Sub
End Class
