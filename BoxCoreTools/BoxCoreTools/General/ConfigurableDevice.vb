Imports System.Xml.Serialization
Imports Newtonsoft.Json

Public MustInherit Class ConfigurableDevice
  Implements IDisposable

#Region "Properties"
  Public Property ID As String = Guid.NewGuid.ToString()

  <CustomDataAttribute(True, "ID")>
  Public Property Name As String = Me.GetType().Name

  Public ReadOnly Property TypeString() As String
    Get
      Return Me.GetType().Name()
    End Get
  End Property

  Public Enum eDeviceState
    Idle
    Enabled
    [Error]
  End Enum

  <JsonIgnore()> <XmlIgnoreAttribute()>
  Public Property State As eDeviceState = eDeviceState.Idle

  Public Property Enabled As Boolean = False

  <JsonIgnore()> <XmlIgnoreAttribute()>
  Public Property LastErrorID As Integer = 0

  <JsonIgnore()> <XmlIgnoreAttribute()>
  Public Property LastErrorString As String = ""

  <JsonIgnore()> <XmlIgnoreAttribute()>
  Public Property Stats As New RealTimeStats()
#End Region

#Region "Events"
  Public Event StateChanged(ByRef sender As ConfigurableDevice, newState As eDeviceState)
  Public Event [Error](ByRef sender As ConfigurableDevice, errorID As Integer, errorString As String)
  Public Event StatChanged(ByRef sender As ConfigurableDevice, stat As RealTimeStat)
#End Region

#Region "Constructors"
  Public Sub New()

  End Sub

  Public Sub New(id As String)
    Me.ID = id
  End Sub
#End Region

#Region "Functions"
  Public Function SetStatValue(statId As String, value As Double) As RealTimeStat
    Dim stat As RealTimeStat = Nothing
    Try
      stat = Me.Stats.SetValue(statId, value)
      RaiseEvent StatChanged(Me, stat)
    Catch ex As Exception
    End Try
    Return stat
  End Function

  Public Sub SetState(newState As eDeviceState)
    Try
      Me.State = newState
      RaiseEvent StateChanged(Me, newState)
    Catch ex As Exception
    End Try
  End Sub

  Public Function ShowConfigDialog(owner As IWin32Window) As DialogResult
    Dim res As DialogResult = DialogResult.None
    Try
      Dim dlg As New dlgControlDeviceConfiguration()
      dlg.ConfigurableDevice = Me
      res = dlg.ShowDialog(owner)
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Overrides Function ToString() As String
    Return Me.Name & " (" & Me.GetType().Name & ")"
  End Function

#Region "IDisposable Support"
  Private disposedValue As Boolean ' Para detectar llamadas redundantes

  ' IDisposable
  Protected Overridable Sub Dispose(disposing As Boolean)
    If Not disposedValue Then
      If disposing Then
        ' TODO: elimine el estado administrado (objetos administrados).
      End If

      ' TODO: libere los recursos no administrados (objetos no administrados) y reemplace Finalize() a continuación.
      ' TODO: configure los campos grandes en nulos.
    End If
    disposedValue = True
  End Sub

  ' TODO: reemplace Finalize() solo si el anterior Dispose(disposing As Boolean) tiene código para liberar recursos no administrados.
  'Protected Overrides Sub Finalize()
  '    ' No cambie este código. Coloque el código de limpieza en el anterior Dispose(disposing As Boolean).
  '    Dispose(False)
  '    MyBase.Finalize()
  'End Sub

  ' Visual Basic agrega este código para implementar correctamente el patrón descartable.
  Public Sub Dispose() Implements IDisposable.Dispose
    ' No cambie este código. Coloque el código de limpieza en el anterior Dispose(disposing As Boolean).
    Dispose(True)
    ' TODO: quite la marca de comentario de la siguiente línea si Finalize() se ha reemplazado antes.
    ' GC.SuppressFinalize(Me)
  End Sub
#End Region
#End Region

End Class
