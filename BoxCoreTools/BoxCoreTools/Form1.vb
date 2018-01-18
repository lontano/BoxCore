Imports Newtonsoft.Json

Public Class Form1
  Dim collectorManager As New CollectorManager

  Private WithEvents _whitebox As WhiteBox

  Private _jsonSettings As JsonSerializerSettings = New JsonSerializerSettings With {.TypeNameHandling = TypeNameHandling.All}

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
      _whitebox = Newtonsoft.Json.JsonConvert.DeserializeObject(Of WhiteBox)(My.Settings.jsonWhiteBox, _jsonSettings)
      Me.ControlWhitebox.Whitebox = _whitebox
    Catch ex As Exception
      MsgBox(ex.ToString)
    End Try
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Try

    Catch ex As Exception

    End Try
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

  End Sub

  Private Sub NewWhiteboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWhiteboxToolStripMenuItem.Click
    Try
      _whitebox = New WhiteBox
      Me.ControlWhitebox.Whitebox = _whitebox
    Catch ex As Exception
      MsgBox(ex.ToString)
    End Try
  End Sub

  Private Sub LoadDefaultWhiteboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDefaultWhiteboxToolStripMenuItem.Click
    Try
      _whitebox = Newtonsoft.Json.JsonConvert.DeserializeObject(Of WhiteBox)(My.Settings.jsonWhiteBox, _jsonSettings)
      Me.ControlWhitebox.Whitebox = _whitebox
    Catch ex As Exception
      MsgBox(ex.ToString)
    End Try
  End Sub

  Private Sub SetAsDefaultWhiteboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetAsDefaultWhiteboxToolStripMenuItem.Click
    My.Settings.jsonWhiteBox = Newtonsoft.Json.JsonConvert.SerializeObject(_whitebox, _jsonSettings)
    My.Settings.Save()
  End Sub

  Private Sub AddNewCollectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCollectorToolStripMenuItem.Click

  End Sub

  Private Sub TCPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TCPToolStripMenuItem.Click
    Try
      Dim tcp As New Collector_TCP
      _whitebox.CollectorManager.AddDevice(tcp.ID, tcp)
      tcp.ShowConfigDialog(Me)
      Me.ControlWhitebox.UpdateWhitebox()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub UDPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UDPToolStripMenuItem.Click
    Try
      Dim udp As New Collector_UDP
      _whitebox.CollectorManager.AddDevice(udp.ID, udp)
      udp.ShowConfigDialog(Me)
      Me.ControlWhitebox.UpdateWhitebox()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub TCPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TCPToolStripMenuItem1.Click
    Try
      Dim tcp As New Transmitter_TCP
      _whitebox.TxChainBridgeManager.AddDevice(tcp.ID, tcp)
      tcp.ShowConfigDialog(Me)
      Me.ControlWhitebox.UpdateWhitebox()
    Catch ex As Exception

    End Try
  End Sub

  Private Sub UDPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UDPToolStripMenuItem1.Click
    Try
      Dim udp As New Transmitter_UDP
      _whitebox.TxChainBridgeManager.AddDevice(udp.ID, udp)
      udp.ShowConfigDialog(Me)
      Me.ControlWhitebox.UpdateWhitebox()
    Catch ex As Exception

    End Try
  End Sub
End Class
