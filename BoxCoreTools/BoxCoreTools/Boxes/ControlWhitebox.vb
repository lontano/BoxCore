Public Class ControlWhitebox
  Private _whitebox As WhiteBox
  Public Property Whitebox As WhiteBox
    Get
      Return _whitebox
    End Get
    Set(value As WhiteBox)
      _whitebox = value
      UpdateWhitebox()

    End Set
  End Property

  Public Sub UpdateWhitebox()
    Try
      If Not _whitebox Is Nothing Then
        Me.ControlConfigurableDeviceManagerDataCollector.Device = _whitebox.CollectorManager
        Me.ControlConfigurableDeviceManagerChainBridgeTx.Device = _whitebox.TxChainBridgeManager
        Me.ControlEncoder.Encoder = _whitebox.Encoder
      Else
        Me.ControlConfigurableDeviceManagerDataCollector.Device = Nothing
        Me.ControlConfigurableDeviceManagerChainBridgeTx.Device = Nothing
        Me.ControlEncoder.Encoder = Nothing
      End If
    Catch ex As Exception

    End Try
  End Sub

End Class
