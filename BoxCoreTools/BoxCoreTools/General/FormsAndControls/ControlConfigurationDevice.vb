Public Class ControlConfigurationDevice
  Private _device As ConfigurableDevice = Nothing
  Public Property Device As ConfigurableDevice
    Get
      Return _device
    End Get
    Set(value As ConfigurableDevice)
      _device = value
      ShowDevice()
    End Set
  End Property

  Private Sub ShowDevice()
    If Not _device Is Nothing Then
      Me.LabelName.Text = _device.ToString
      Me.LabelType.Text = _device.TypeString
      ButtonConfig.Enabled = True
    Else
      Me.LabelName.Text = ""
      Me.LabelType.Text = ""
      ButtonConfig.Enabled = False
    End If
  End Sub

  Private Sub ButtonConfig_Click(sender As Object, e As EventArgs) Handles ButtonConfig.Click
    If Not _device Is Nothing Then
      If _device.ShowConfigDialog(Me) = DialogResult.OK Then
        Me.ShowDevice()
      End If
    End If
  End Sub
End Class
