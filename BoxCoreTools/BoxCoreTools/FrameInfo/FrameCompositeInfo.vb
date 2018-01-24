Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Xml.Serialization
Imports System.Drawing
Imports GSTools
Imports System.Reflection

<Serializable()> Public Class FrameCompositeInfo
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

  Private _clockMs As Integer = 0
  Public Property ClockMs() As Integer
    Get
      Return _clockMs
    End Get
    Set(ByVal value As Integer)
      _clockMs = value
    End Set
  End Property

  Private _frameCodificationInfo As New FrameCodificationInfo
  Public Property FrameCodificationInfo As FrameCodificationInfo
    Get
      Return _frameCodificationInfo
    End Get
    Set(value As FrameCodificationInfo)
      _frameCodificationInfo = value
      If Not _frameCodificationInfo Is Nothing Then
        _frameCodificationInfo.FrameNumber = _frameNumber
      End If
    End Set
  End Property

  Private _framePayloadInfo As New FramePayloadInfo
  Public Property FramePayloadInfo As FramePayloadInfo
    Get
      Return _framePayloadInfo
    End Get
    Set(value As FramePayloadInfo)
      _framePayloadInfo = value
      If Not _frameCodificationInfo Is Nothing Then
        _frameCodificationInfo.FrameNumber = _frameNumber
      End If
    End Set
  End Property
#End Region

#Region "Constructor"
  Public Sub New()
  End Sub

  Public Sub New(frameNumber As Integer)
    _frameNumber = frameNumber
    If Not _frameCodificationInfo Is Nothing Then _frameCodificationInfo.FrameNumber = _frameNumber
    If Not _framePayloadInfo Is Nothing Then _framePayloadInfo.FrameNumber = _frameNumber
  End Sub
#End Region

  Public Overrides Function ToString() As String
    Return "FramePayloadInfo " & Me.FrameNumber & " " & Me.UID.ToString
  End Function
End Class
