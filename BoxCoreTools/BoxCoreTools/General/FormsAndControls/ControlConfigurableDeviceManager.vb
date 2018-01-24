Public Class ControlConfigurableDeviceManager
  Private _deviceManager As ConfigurableDeviceManager = Nothing
  Public Property Device As ConfigurableDeviceManager
    Get
      Return _deviceManager
    End Get
    Set(value As ConfigurableDeviceManager)
      _deviceManager = value
      ShowDeviceManager()
    End Set
  End Property

  Public Sub ShowDeviceManager()
    If Not _deviceManager Is Nothing Then
      Me.LabelName.Text = _deviceManager.ToString
      ButtonConfig.Enabled = True

      Dim ctlHeight As Integer = 25
      Dim index As Integer = 0

      Me.PanelControls.Controls.Clear()

      For Each pair As KeyValuePair(Of String, ConfigurableDevice) In _deviceManager.Devices
        Dim ctl = New ControlConfigurationDevice
        ctl.Device = pair.Value

        Me.PanelControls.Controls.Add(ctl)
        ctl.Top = index * ctlHeight
        ctl.Height = ctlHeight
        ctl.Width = Me.PanelControls.ClientSize.Width
        index += 1
      Next

    Else
      Me.LabelName.Text = ""
      ButtonConfig.Enabled = False
      Me.PanelControls.Controls.Clear()
    End If
  End Sub

  Private Sub ButtonConfig_Click(sender As Object, e As EventArgs) Handles ButtonConfig.Click
    If _deviceManager.ShowConfigDialog(Me) = DialogResult.OK Then
      ShowDeviceManager()
    End If
  End Sub
End Class
