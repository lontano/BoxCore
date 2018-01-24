Imports BoxCoreTools

Public Class ControlEncoder
  Private WithEvents _encoder As Encoder = Nothing
  Public Property Encoder As Encoder
    Get
      Return _encoder
    End Get
    Set(value As Encoder)
      _encoder = value
      ShowEncoder()
    End Set
  End Property

  Public Sub ShowEncoder()
    Try
      If Not _encoder Is Nothing Then
        Me.LabelName.Text = _encoder.ToString
      Else
        Me.LabelName.Text = ""
      End If
    Catch ex As Exception

    End Try
  End Sub
  Private Sub ButtonConfig_Click(sender As Object, e As EventArgs) Handles ButtonConfig.Click
    If Not _encoder Is Nothing Then
      If _encoder.ShowConfigDialog(Me) = DialogResult.OK Then
        Me.ShowEncoder()
      End If
    End If
  End Sub

  Private Sub _encoder_FrameEncoded(sender As Encoder, frameCodificationInfo As FrameCodificationInfo) Handles _encoder.FrameEncoded
    Me.LabelState.Text = frameCodificationInfo.FrameNumber
  End Sub

  Private Sub ButtonRun_Click(sender As Object, e As EventArgs) Handles ButtonRun.Click
    If Not _encoder Is Nothing Then
      _encoder.Run()
    End If
  End Sub

  Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
    If Not _encoder Is Nothing Then
      _encoder.Stop()
    End If
  End Sub
End Class
