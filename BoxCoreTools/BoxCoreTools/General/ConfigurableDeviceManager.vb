Public Class ConfigurableDeviceManager
  Inherits ConfigurableDevice

  Public Property Devices As New Dictionary(Of String, ConfigurableDevice)

  Public Sub AddDevice(key As String, collector As ConfigurableDevice)
    Try
      If Not Me.Devices.ContainsKey(key) Then
        Me.Devices.Add(key, collector)
      End If
    Catch ex As Exception

    End Try
  End Sub

  Public Sub RemoveDevice(key As String)
    Try
      If Me.Devices.ContainsKey(key) Then
        Me.Devices(key).Dispose()
        Me.Devices.Remove(key)
      End If
    Catch ex As Exception

    End Try
  End Sub

  Public Function GetDevice(key As String) As ConfigurableDevice
    If Me.Devices.ContainsKey(key) Then
      Return Me.Devices(key)
    Else
      Return Nothing
    End If
  End Function
End Class
