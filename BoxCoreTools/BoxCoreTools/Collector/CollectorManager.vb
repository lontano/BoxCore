Public Class CollectorManager
  Inherits ConfigurableDevice

  Public Property Collectors As New Dictionary(Of String, Collector)

  Public Event DataArrived(ByRef sender As CollectorManager, ByRef senderCollector As Collector, data() As Byte, dataString As String)

  Private Sub InitCollectors()
    Try
      For Each pair As KeyValuePair(Of String, Collector) In Me.Collectors
        AddHandler pair.Value.DataArrived, AddressOf Me.Collector_DataArrived
        AddHandler pair.Value.Error, AddressOf Me.Collector_Error
      Next
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Collector_DataArrived(ByRef sender As Collector, data() As Byte, dataString As String)
    Try
      RaiseEvent DataArrived(Me, sender, data, dataString)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Collector_Error(ByRef sender As ConfigurableDevice, errorID As Integer, errorString As String)
  End Sub

  Public Sub ConnectAll()

  End Sub


End Class
