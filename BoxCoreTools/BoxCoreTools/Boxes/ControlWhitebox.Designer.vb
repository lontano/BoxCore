<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlWhitebox
  Inherits System.Windows.Forms.UserControl

  'UserControl reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.TableLayoutPanelWhiteBox = New System.Windows.Forms.TableLayoutPanel()
    Me.ControlConfigurableDeviceManagerChainBridgeTx = New BoxCoreTools.ControlConfigurableDeviceManager()
    Me.ControlConfigurableDeviceManagerDataCollector = New BoxCoreTools.ControlConfigurableDeviceManager()
    Me.ControlEncoder = New BoxCoreTools.ControlEncoder()
    Me.TableLayoutPanelWhiteBox.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelWhiteBox
    '
    Me.TableLayoutPanelWhiteBox.ColumnCount = 3
    Me.TableLayoutPanelWhiteBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanelWhiteBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
    Me.TableLayoutPanelWhiteBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
    Me.TableLayoutPanelWhiteBox.Controls.Add(Me.ControlConfigurableDeviceManagerChainBridgeTx, 2, 0)
    Me.TableLayoutPanelWhiteBox.Controls.Add(Me.ControlConfigurableDeviceManagerDataCollector, 0, 0)
    Me.TableLayoutPanelWhiteBox.Controls.Add(Me.ControlEncoder, 1, 0)
    Me.TableLayoutPanelWhiteBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelWhiteBox.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelWhiteBox.Name = "TableLayoutPanelWhiteBox"
    Me.TableLayoutPanelWhiteBox.RowCount = 2
    Me.TableLayoutPanelWhiteBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelWhiteBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
    Me.TableLayoutPanelWhiteBox.Size = New System.Drawing.Size(1433, 780)
    Me.TableLayoutPanelWhiteBox.TabIndex = 5
    '
    'ControlConfigurableDeviceManagerChainBridgeTx
    '
    Me.ControlConfigurableDeviceManagerChainBridgeTx.Device = Nothing
    Me.ControlConfigurableDeviceManagerChainBridgeTx.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ControlConfigurableDeviceManagerChainBridgeTx.Location = New System.Drawing.Point(957, 3)
    Me.ControlConfigurableDeviceManagerChainBridgeTx.Name = "ControlConfigurableDeviceManagerChainBridgeTx"
    Me.ControlConfigurableDeviceManagerChainBridgeTx.Size = New System.Drawing.Size(473, 474)
    Me.ControlConfigurableDeviceManagerChainBridgeTx.TabIndex = 4
    '
    'ControlConfigurableDeviceManagerDataCollector
    '
    Me.ControlConfigurableDeviceManagerDataCollector.Device = Nothing
    Me.ControlConfigurableDeviceManagerDataCollector.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ControlConfigurableDeviceManagerDataCollector.Location = New System.Drawing.Point(3, 3)
    Me.ControlConfigurableDeviceManagerDataCollector.Name = "ControlConfigurableDeviceManagerDataCollector"
    Me.ControlConfigurableDeviceManagerDataCollector.Size = New System.Drawing.Size(471, 474)
    Me.ControlConfigurableDeviceManagerDataCollector.TabIndex = 3
    '
    'ControlEncoder
    '
    Me.ControlEncoder.Encoder = Nothing
    Me.ControlEncoder.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ControlEncoder.Location = New System.Drawing.Point(480, 3)
    Me.ControlEncoder.Name = "ControlEncoder"
    Me.ControlEncoder.Size = New System.Drawing.Size(471, 474)
    Me.ControlEncoder.TabIndex = 5
    '
    'ControlWhitebox
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelWhiteBox)
    Me.Name = "ControlWhitebox"
    Me.Size = New System.Drawing.Size(1433, 780)
    Me.TableLayoutPanelWhiteBox.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelWhiteBox As TableLayoutPanel
  Friend WithEvents ControlConfigurableDeviceManagerChainBridgeTx As ControlConfigurableDeviceManager
  Friend WithEvents ControlConfigurableDeviceManagerDataCollector As ControlConfigurableDeviceManager
  Friend WithEvents ControlEncoder As ControlEncoder
End Class
