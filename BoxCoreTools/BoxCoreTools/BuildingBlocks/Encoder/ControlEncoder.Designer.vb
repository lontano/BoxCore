<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlEncoder
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
    Me.TableLayoutPanelEncoder = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelName = New System.Windows.Forms.Label()
    Me.ButtonConfig = New System.Windows.Forms.Button()
    Me.LabelState = New System.Windows.Forms.Label()
    Me.TableLayoutPanelControl = New System.Windows.Forms.TableLayoutPanel()
    Me.ButtonRun = New System.Windows.Forms.Button()
    Me.ButtonStop = New System.Windows.Forms.Button()
    Me.TableLayoutPanelEncoder.SuspendLayout()
    Me.TableLayoutPanelControl.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelEncoder
    '
    Me.TableLayoutPanelEncoder.ColumnCount = 2
    Me.TableLayoutPanelEncoder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelEncoder.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanelEncoder.Controls.Add(Me.LabelName, 0, 0)
    Me.TableLayoutPanelEncoder.Controls.Add(Me.ButtonConfig, 1, 0)
    Me.TableLayoutPanelEncoder.Controls.Add(Me.LabelState, 0, 3)
    Me.TableLayoutPanelEncoder.Controls.Add(Me.TableLayoutPanelControl, 0, 2)
    Me.TableLayoutPanelEncoder.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelEncoder.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelEncoder.Name = "TableLayoutPanelEncoder"
    Me.TableLayoutPanelEncoder.RowCount = 4
    Me.TableLayoutPanelEncoder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelEncoder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelEncoder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanelEncoder.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanelEncoder.Size = New System.Drawing.Size(873, 212)
    Me.TableLayoutPanelEncoder.TabIndex = 0
    '
    'LabelName
    '
    Me.LabelName.AutoSize = True
    Me.LabelName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelName.Location = New System.Drawing.Point(3, 0)
    Me.LabelName.Name = "LabelName"
    Me.LabelName.Size = New System.Drawing.Size(817, 35)
    Me.LabelName.TabIndex = 0
    Me.LabelName.Text = "Encoder name"
    Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ButtonConfig
    '
    Me.ButtonConfig.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonConfig.Location = New System.Drawing.Point(826, 3)
    Me.ButtonConfig.Name = "ButtonConfig"
    Me.ButtonConfig.Size = New System.Drawing.Size(44, 29)
    Me.ButtonConfig.TabIndex = 1
    Me.ButtonConfig.Text = "..."
    Me.ButtonConfig.UseVisualStyleBackColor = True
    '
    'LabelState
    '
    Me.LabelState.AutoSize = True
    Me.LabelState.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelState.Location = New System.Drawing.Point(3, 177)
    Me.LabelState.Name = "LabelState"
    Me.LabelState.Size = New System.Drawing.Size(817, 35)
    Me.LabelState.TabIndex = 2
    Me.LabelState.Text = "State"
    Me.LabelState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TableLayoutPanelControl
    '
    Me.TableLayoutPanelControl.ColumnCount = 3
    Me.TableLayoutPanelControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
    Me.TableLayoutPanelControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
    Me.TableLayoutPanelControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelControl.Controls.Add(Me.ButtonRun, 0, 0)
    Me.TableLayoutPanelControl.Controls.Add(Me.ButtonStop, 1, 0)
    Me.TableLayoutPanelControl.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelControl.Location = New System.Drawing.Point(3, 130)
    Me.TableLayoutPanelControl.Name = "TableLayoutPanelControl"
    Me.TableLayoutPanelControl.RowCount = 1
    Me.TableLayoutPanelControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanelControl.Size = New System.Drawing.Size(817, 44)
    Me.TableLayoutPanelControl.TabIndex = 3
    '
    'ButtonRun
    '
    Me.ButtonRun.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonRun.Location = New System.Drawing.Point(3, 3)
    Me.ButtonRun.Name = "ButtonRun"
    Me.ButtonRun.Size = New System.Drawing.Size(144, 38)
    Me.ButtonRun.TabIndex = 0
    Me.ButtonRun.Text = "Run"
    Me.ButtonRun.UseVisualStyleBackColor = True
    '
    'ButtonStop
    '
    Me.ButtonStop.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonStop.Location = New System.Drawing.Point(153, 3)
    Me.ButtonStop.Name = "ButtonStop"
    Me.ButtonStop.Size = New System.Drawing.Size(144, 38)
    Me.ButtonStop.TabIndex = 1
    Me.ButtonStop.Text = "Stop"
    Me.ButtonStop.UseVisualStyleBackColor = True
    '
    'ControlEncoder
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelEncoder)
    Me.Name = "ControlEncoder"
    Me.Size = New System.Drawing.Size(873, 212)
    Me.TableLayoutPanelEncoder.ResumeLayout(False)
    Me.TableLayoutPanelEncoder.PerformLayout()
    Me.TableLayoutPanelControl.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelEncoder As TableLayoutPanel
  Friend WithEvents LabelName As Label
  Friend WithEvents ButtonConfig As Button
  Friend WithEvents LabelState As Label
  Friend WithEvents TableLayoutPanelControl As TableLayoutPanel
  Friend WithEvents ButtonRun As Button
  Friend WithEvents ButtonStop As Button
End Class
