Imports BoxCoreTools

Public Class WhiteBox
  Private WithEvents _collectorManage As New CollectorManager
  Public Property CollectorManager As CollectorManager
    Get
      Return _collectorManage
    End Get
    Set(value As CollectorManager)
      _collectorManage = value
    End Set
  End Property

  Private WithEvents _encoder As Encoder
  Public Property Encoder As Encoder
    Get
      Return _encoder
    End Get
    Set(value As Encoder)
      _encoder = value
    End Set
  End Property

  Private _txChainBridgeManager As New TransmitterManager
  Public Property TxChainBridgeManager As TransmitterManager
    Get
      Return _txChainBridgeManager
    End Get
    Set(value As TransmitterManager)
      _txChainBridgeManager = value
    End Set
  End Property

  Public Sub New()

  End Sub

#Region "Events"
  Private _payload As FramePayloadInfo
  'add data to current package
  Private Sub _collectorManage_DataArrived(ByRef sender As CollectorManager, ByRef senderCollector As Collector, data() As Byte, dataString As String) Handles _collectorManage.DataArrived
    Try
      If _payload Is Nothing Then _payload = New FramePayloadInfo
      Dim packet As New GSTools.Packet
      packet.SourceID = sender.ID
      packet.PacketBytes = data
      _payload.Packets.Add(packet)
    Catch ex As Exception
    End Try
  End Sub

  Private _frame As FrameCompositeInfo
  'get the data we already have, send it over the chainbridge
  Private Sub _encoder_FrameEncoded(sender As Encoder, frameCodificationInfo As FrameCodificationInfo) Handles _encoder.FrameEncoded
    Try
      If _frame Is Nothing Then
        _frame = New FrameCompositeInfo(frameCodificationInfo.FrameNumber)
        _frame.FrameCodificationInfo = frameCodificationInfo
        _frame.FramePayloadInfo = _payload
        'send frame
        _txChainBridgeManager.SenData(_frame)
      End If
    Catch ex As Exception

    End Try
  End Sub

#End Region
End Class
