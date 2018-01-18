Public Class RealTimeStats
  Public Property Stats As New Dictionary(Of String, RealTimeStat)
  Public Property MaxStoredValues As Integer = 100

  Public Function SetValue(id As String, value As Double) As RealTimeStat
    Dim rts As RealTimeStat = Nothing
    Try
      If Me.Stats.ContainsKey(id) Then
        rts = Me.Stats(id)
      Else
        rts = New RealTimeStat()
        rts.ID = id
        Me.Stats.Add(id, rts)
      End If
      If Not rts Is Nothing Then
        rts.AddValue(value, MaxStoredValues)
      End If
    Catch ex As Exception
    End Try
    Return rts
  End Function
End Class
