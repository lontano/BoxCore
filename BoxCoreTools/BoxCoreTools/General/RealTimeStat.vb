Public Class RealTimeStat
  Public Property ID As String = "BaseRealTimeStat"
  Public Property Name As String = "Base Real Time Stat"
  Public Property Value As Double = 0

  Public Property Values As New List(Of Double)

  Public Sub New()

  End Sub

  Public Sub AddValue(newValue As Double)
    Me.Values.Add(newValue)
    Me.Value = newValue
  End Sub

  Public Sub AddValue(newValue As Double, maxItems As Integer)
    Me.AddValue(newValue)
    Try
      If maxItems > 0 Then
        While Me.Values.Count > maxItems
          Me.Values.RemoveAt(0)
        End While
      End If
    Catch ex As Exception

    End Try
  End Sub
End Class
