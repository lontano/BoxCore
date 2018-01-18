Imports System.Reflection
Imports System.Windows.Forms

Public Class dlgControlDeviceConfiguration
  Private _configurableDevice As ConfigurableDevice
  Public Property ConfigurableDevice As ConfigurableDevice
    Get
      Return _configurableDevice
    End Get
    Set(value As ConfigurableDevice)
      _configurableDevice = value
      ShowProperties()
    End Set
  End Property


  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If Apply Then
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    End If

  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub dlgControlDeviceConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ShowProperties()
  End Sub

  Private _controls As New Dictionary(Of String, ControlDeviceConfigurationProperty)

  Private Sub ShowProperties()
    Try
      _controls.Clear()
      Me.PanelControls.Controls.Clear()
      Me.PanelControls.BackColor = Color.Gray
      Me.PanelControls.BorderStyle = BorderStyle.FixedSingle

      Dim ctlHeight As Integer = 25
      Dim index As Integer = 0

      If Not _configurableDevice Is Nothing Then
        Dim info() As PropertyInfo = _configurableDevice.GetType().GetProperties()

        For Each prop As PropertyInfo In info
          Dim bAdd As Boolean = False

          For Each attrib As CustomDataAttribute In prop.GetCustomAttributes(Of CustomDataAttribute)(False)
            bAdd = bAdd Or attrib.IsConfiguration
          Next

          If bAdd Then
              Dim ctl = New ControlDeviceConfigurationProperty
              Dim value As Object = prop.GetValue(_configurableDevice)
              Try
                ctl.SetValue(prop.Name, value)
                _controls.Add(prop.Name, ctl)
                Me.PanelControls.Controls.Add(ctl)
                ctl.Top = index * ctlHeight
                ctl.Height = ctlHeight
                ctl.Width = Me.PanelControls.ClientSize.Width
                index += 1
              Catch ex As Exception
              End Try
            End If
          Next
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private Function Apply() As Boolean
    Dim res As Boolean = False
    Try
      If Not _configurableDevice Is Nothing Then
        Dim info() As PropertyInfo = _configurableDevice.GetType().GetProperties()

        For Each prop As PropertyInfo In info
          If _controls.ContainsKey(prop.Name) Then
            Dim ctl As ControlDeviceConfigurationProperty = _controls(prop.Name)
            Dim value As Object = prop.GetValue(_configurableDevice)
            ctl.GetValue(value)
            prop.SetValue(_configurableDevice, value)
          End If
        Next
      End If
      res = True
    Catch ex As Exception

    End Try
    Return res
  End Function
End Class
