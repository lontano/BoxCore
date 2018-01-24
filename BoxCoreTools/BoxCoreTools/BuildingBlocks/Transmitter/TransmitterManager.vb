Public Class TransmitterManager
  Inherits ConfigurableDeviceManager

  Private Sub InitCollectors()
    Try
      For Each pair As KeyValuePair(Of String, ConfigurableDevice) In Me.Devices
        Dim transmitter As Transmitter = CType(pair.Value, Transmitter)
      Next
    Catch ex As Exception
    End Try
  End Sub

  Public Sub ConnectAll()

  End Sub

  Public Sub DisconnectAll()

  End Sub

  Public Sub SendData(data As String)

  End Sub

  Public Sub SenData(data() As Byte)

  End Sub

  Public Sub SendData(data As String, transmitterID As String)

  End Sub

  Public Sub SendData(data() As Byte, transmitterID As String)

  End Sub


End Class
