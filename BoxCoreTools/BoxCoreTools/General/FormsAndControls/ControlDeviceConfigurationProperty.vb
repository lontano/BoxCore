Public Class ControlDeviceConfigurationProperty
  Private _checkBox As CheckBox = Nothing
  Private _textBox As TextBox = Nothing
  Private _numbericUpDown As NumericUpDown = Nothing

  Public Sub SetValue(name As String, ByRef value As Boolean)
    Try
      Me.LabelName.Text = name
      If _checkBox Is Nothing Then
        Me.PanelValue.Controls.Clear()
        _checkBox = New CheckBox
        _checkBox.Text = ""
        Me.PanelValue.Controls.Add(_checkBox)
        _checkBox.Dock = DockStyle.Fill
      End If
      _checkBox.Checked = value
    Catch ex As Exception
    End Try
  End Sub

  Public Sub SetValue(name As String, ByRef value As String)
    Try
      Me.LabelName.Text = name
      If _textBox Is Nothing Then
        Me.PanelValue.Controls.Clear()
        _textBox = New TextBox
        Me.PanelValue.Controls.Add(_textBox)
        _textBox.Dock = DockStyle.Fill
      End If
      _textBox.Text = value
    Catch ex As Exception
    End Try
  End Sub

  Public Sub SetValue(name As String, ByRef value As Integer)
    Try
      Me.LabelName.Text = name
      If _numbericUpDown Is Nothing Then
        Me.PanelValue.Controls.Clear()
        _numbericUpDown = New NumericUpDown
        Me.PanelValue.Controls.Add(_numbericUpDown)
        _numbericUpDown.Dock = DockStyle.Fill
        _numbericUpDown.Minimum = Integer.MinValue
        _numbericUpDown.Maximum = Integer.MaxValue
        _numbericUpDown.DecimalPlaces = 0
      End If
      _numbericUpDown.Value = value
    Catch ex As Exception
    End Try
  End Sub

  Public Sub SetValue(name As String, ByRef value As Double)
    Try
      Me.LabelName.Text = name
      If _numbericUpDown Is Nothing Then
        Me.PanelValue.Controls.Clear()
        _numbericUpDown = New NumericUpDown
        Me.PanelValue.Controls.Add(_numbericUpDown)
        _numbericUpDown.Dock = DockStyle.Fill
        _numbericUpDown.Minimum = Integer.MinValue
        _numbericUpDown.Maximum = Integer.MaxValue
        _numbericUpDown.DecimalPlaces = 2
      End If
      _numbericUpDown.Value = value
    Catch ex As Exception
    End Try
  End Sub

  Public Sub GetValue(ByRef value As Boolean)
    If Not _checkBox Is Nothing Then
      value = _checkBox.Checked
    Else
      value = False
    End If
  End Sub

  Public Sub GetValue(ByRef value As String)
    If Not _textBox Is Nothing Then
      value = _textBox.Text
    Else
      value = ""
    End If
  End Sub

  Public Sub GetValue(ByRef value As Integer)
    If Not _numbericUpDown Is Nothing Then
      value = _numbericUpDown.Value
    Else
      value = False
    End If
  End Sub

  Public Sub GetValue(ByRef value As Double)
    If Not _numbericUpDown Is Nothing Then
      value = _numbericUpDown.Value
    Else
      value = False
    End If
  End Sub
End Class
