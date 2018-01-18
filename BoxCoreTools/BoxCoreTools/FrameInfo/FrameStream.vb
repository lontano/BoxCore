Public Class FrameStream
  Public Property Frames As New Dictionary(Of Integer, FrameCompositeInfo)

  Private _frameInfoListLock As New Object

  Public Sub New()

  End Sub


  Public Function AddFrameInfo(frameInfo As FrameCompositeInfo) As Boolean
    Try
      If frameInfo Is Nothing Then Return False

      SyncLock _frameInfoListLock

        If Not Me.Frames.ContainsKey(frameInfo.FrameNumber) Then
          Me.Frames.Add(frameInfo.FrameNumber, frameInfo)
        Else
          Me.Frames(frameInfo.FrameNumber) = frameInfo
        End If
      End SyncLock
    Catch ex As Exception
      Debug.Print(ex.ToString)
    End Try
    Return True
  End Function

  Public Function RemoveFrameInfo(frameInfo As FrameCompositeInfo) As Boolean
    Try
      SyncLock _frameInfoListLock
        If Me.Frames.ContainsValue(frameInfo) Then
          Me.Frames.Remove(frameInfo.FrameNumber)
        End If
      End SyncLock
    Catch ex As Exception
    End Try
    Return True
  End Function

  Public Function RemoveFrameInfo(frameNumber As Integer) As Boolean
    Try
      SyncLock _frameInfoListLock
        If Me.Frames.ContainsKey(frameNumber) Then
          Me.Frames.Remove(frameNumber)
        End If
      End SyncLock
    Catch ex As Exception
    End Try
    Return True
  End Function

  Public Function GetFrameInfo(frameNumber As Integer) As FrameCompositeInfo
    Dim res As FrameCompositeInfo = Nothing
    Try
      If Me.Frames.ContainsKey(frameNumber) Then
        res = Me.Frames(frameNumber)
      End If
    Catch ex As Exception
    End Try
    Return res
  End Function
End Class
