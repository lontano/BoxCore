Public Class CollectorManager
  Inherits ConfigurableDeviceManager

  Public Event DataArrived(ByRef sender As CollectorManager, ByRef senderCollector As Collector, data() As Byte, dataString As String)


  Private Sub Collector_DataArrived(ByRef sender As Collector, data() As Byte, dataString As String)
    Try
      RaiseEvent DataArrived(Me, sender, data, dataString)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Collector_Error(ByRef sender As ConfigurableDevice, errorID As Integer, errorString As String)
  End Sub

  Private Sub InitCollectors()
    Try
      For Each pair As KeyValuePair(Of String, ConfigurableDevice) In Me.Devices
        Dim collector As Collector = CType(pair.Value, Collector)
        AddHandler collector.DataArrived, AddressOf Me.Collector_DataArrived
        AddHandler collector.Error, AddressOf Me.Collector_Error
      Next
    Catch ex As Exception
    End Try
  End Sub

  Public Sub ConnectAll()

  End Sub

  Public Sub DisconnectAll()

  End Sub
End Class
