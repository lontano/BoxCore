Public Class CustomDataAttribute : Inherits Attribute
  Private _section As String
  Property IsConfiguration As Boolean = False

  Public Sub New(isConfiguration As Boolean, ByVal section As String)
    Me.IsConfiguration = isConfiguration
    Me.Section = section
  End Sub

  Property Section() As String
    Get
      Return _section
    End Get
    Set(ByVal value As String)
      Me._section = value
    End Set
  End Property

End Class
