Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Xml.Serialization
Imports System.Drawing
Imports GSTools
Imports System.Reflection

<Serializable()> Public Class FramePayloadInfo
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

  Private _packets As New List(Of Packet)
  Public Property Packets As List(Of Packet)
    Get
      Return _packets
    End Get
    Set(value As List(Of Packet))
      _packets = value
    End Set
  End Property
#End Region

#Region "Constructor"
  Public Sub New()
  End Sub

#End Region

  Public Overrides Function ToString() As String
    Return "FramePayloadInfo " & Me.FrameNumber & " " & Me.UID.ToString
  End Function
End Class
