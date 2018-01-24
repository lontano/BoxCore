
Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Xml.Serialization
Imports System.Drawing
Imports System.Reflection
Imports GSTools

Public Class FrameCodificationInfo
#Region "Properties"
  Private _uiD As Guid = Guid.NewGuid
  Public Property UID() As Guid
    Get
      Return _uiD
    End Get
    Set(ByVal value As Guid)
      _uiD = value
    End Set
  End Property

  Private _frameNumber As Integer = 0
  Public Property FrameNumber() As Integer
    Get
      Return _frameNumber
    End Get
    Set(ByVal value As Integer)
      _frameNumber = value
    End Set
  End Property

  Private _patchRectangle As New Rectangle(0, 0, 0, 0)
  Public Property PatchRectangle() As Rectangle
    Get
      Return _patchRectangle
    End Get
    Set(ByVal value As Rectangle)
      _patchRectangle = value
    End Set
  End Property

  Private _patchByteArray As Byte() = Nothing
  Public Property PatchByteArray As Byte()
    Get
      Return _patchByteArray
    End Get
    Set(value As Byte())
      _patchByteArray = value
    End Set
  End Property

  Private _patchImage As Bitmap = New Bitmap(1, 1)
  <XmlIgnore()> Public Property PatchImage() As Bitmap
    Get
      Return _patchImage
    End Get
    Set(ByVal value As Bitmap)
      _patchImage = value
    End Set
  End Property

  <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
  <XmlElement("PatchImage")>
  Public Property PatchImageSerialized() As Byte()
    Get
      ' serialize
      If PatchImage Is Nothing Then
        Return Nothing
      End If
      If _patchByteArray Is Nothing Then
        Dim ms As New MemoryStream()
        Try
          PatchImage.Save(ms, ImageFormat.Bmp)
          _patchByteArray = ms.ToArray()
        Catch ex As Exception
          Debug.Print(ex.ToString)
        End Try
      End If
      Return _patchByteArray

    End Get
    Set(ByVal value As Byte())
      Try
        ' deserialize
        If value Is Nothing Then
          PatchImage = Nothing
          _patchByteArray = Nothing
        Else
          _patchByteArray = value
          Using ms As New MemoryStream(_patchByteArray)
            PatchImage = New Bitmap(ms, True)
            Dim auxBmp As New Bitmap(ms, True)
            'PatchImage = New Bitmap(auxBmp.Width, auxBmp.Height)
            'Using g As Graphics = Graphics.FromImage(PatchImage)
            '  g.DrawImageUnscaled(auxBmp, 0, 0)
            '  g.Dispose()
            'End Using
          End Using
        End If
      Catch ex As Exception
        Debug.Print("Error serializing image" & ex.ToString)
      End Try

    End Set
  End Property

  Private _opticCodeInfo As OpticCodeInfo
  Public Property OpticCodeInfo() As OpticCodeInfo
    Get
      Return _opticCodeInfo
    End Get
    Set(ByVal value As OpticCodeInfo)
      _opticCodeInfo = value
    End Set
  End Property

  Private _clockMs As Integer = 0
  Public Property ClockMs() As Integer
    Get
      Return _clockMs
    End Get
    Set(ByVal value As Integer)
      _clockMs = value
    End Set
  End Property
#End Region

#Region "Constructor"
  Public Sub New()
  End Sub

  Public Sub New(frameNumber)
    _frameNumber = frameNumber
  End Sub
#End Region

  Public Overrides Function ToString() As String
    Return "FrameCodificationInfo " & Me.FrameNumber & " " & Me.UID.ToString
  End Function
End Class
