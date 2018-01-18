<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlConfigurableDeviceManager
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
    Me.PanelControls = New System.Windows.Forms.Panel()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.ButtonConfig = New System.Windows.Forms.Button()
    Me.LabelName = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'PanelControls
    '
    Me.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TableLayoutPanel1.SetColumnSpan(Me.PanelControls, 2)
    Me.PanelControls.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelControls.Location = New System.Drawing.Point(3, 38)
    Me.PanelControls.Name = "PanelControls"
    Me.PanelControls.Size = New System.Drawing.Size(1107, 327)
    Me.PanelControls.TabIndex = 0
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.PanelControls, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.ButtonConfig, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.LabelName, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 3
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(1113, 398)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'ButtonConfig
    '
    Me.ButtonConfig.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonConfig.Location = New System.Drawing.Point(1066, 3)
    Me.ButtonConfig.Name = "ButtonConfig"
    Me.ButtonConfig.Size = New System.Drawing.Size(44, 29)
    Me.ButtonConfig.TabIndex = 1
    Me.ButtonConfig.Text = "..."
    Me.ButtonConfig.UseVisualStyleBackColor = True
    '
    'LabelName
    '
    Me.LabelName.AutoSize = True
    Me.LabelName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelName.Location = New System.Drawing.Point(3, 0)
    Me.LabelName.Name = "LabelName"
    Me.LabelName.Size = New System.Drawing.Size(1057, 35)
    Me.LabelName.TabIndex = 2
    Me.LabelName.Text = "Name"
    Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ControlConfigurableDeviceManager
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "ControlConfigurableDeviceManager"
    Me.Size = New System.Drawing.Size(1113, 398)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents PanelControls As Panel
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents ButtonConfig As Button
  Friend WithEvents LabelName As Label
End Class
