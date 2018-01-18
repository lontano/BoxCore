Public Class Form1
  Dim collectorManager As New CollectorManager

  Private WithEvents _whitebox As WhiteBox

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

  End Sub

  Private Sub NewWhiteboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWhiteboxToolStripMenuItem.Click
    _whitebox = New WhiteBox
  End Sub

  Private Sub LoadDefaultWhiteboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDefaultWhiteboxToolStripMenuItem.Click
    _whitebox = Newtonsoft.Json.JsonConvert.DeserializeObject(Of WhiteBox)(My.Settings.jsonWhiteBox)
  End Sub

  Private Sub SetAsDefaultWhiteboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetAsDefaultWhiteboxToolStripMenuItem.Click
    My.Settings.jsonWhiteBox = Newtonsoft.Json.JsonConvert.SerializeObject(_whitebox)
    My.Settings.Save()
  End Sub

  Private Sub AddNewCollectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCollectorToolStripMenuItem.Click

  End Sub

  Private Sub TCPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TCPToolStripMenuItem.Click
    Try
      Dim tcp As New Collector_TCP
      _whitebox.CollectorManager.AddCollector("tcp", tcp)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub UDPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UDPToolStripMenuItem.Click
    Try
      Dim udp As New Collector_UDP
      _whitebox.CollectorManager.AddCollector("udp", udp)
    Catch ex As Exception

    End Try
  End Sub
End Class
