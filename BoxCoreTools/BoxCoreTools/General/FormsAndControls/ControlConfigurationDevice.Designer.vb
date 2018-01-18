<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlConfigurationDevice
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
    Me.TableLayoutPanelAll = New System.Windows.Forms.TableLayoutPanel()
    Me.CheckBoxEnabled = New System.Windows.Forms.CheckBox()
    Me.LabelName = New System.Windows.Forms.Label()
    Me.ButtonConfig = New System.Windows.Forms.Button()
    Me.LabelType = New System.Windows.Forms.Label()
    Me.TableLayoutPanelAll.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelAll
    '
    Me.TableLayoutPanelAll.ColumnCount = 4
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
    Me.TableLayoutPanelAll.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanelAll.Controls.Add(Me.CheckBoxEnabled, 0, 0)
    Me.TableLayoutPanelAll.Controls.Add(Me.LabelName, 1, 0)
    Me.TableLayoutPanelAll.Controls.Add(Me.ButtonConfig, 3, 0)
    Me.TableLayoutPanelAll.Controls.Add(Me.LabelType, 2, 0)
    Me.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelAll.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelAll.Name = "TableLayoutPanelAll"
    Me.TableLayoutPanelAll.RowCount = 1
    Me.TableLayoutPanelAll.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanelAll.Size = New System.Drawing.Size(850, 52)
    Me.TableLayoutPanelAll.TabIndex = 0
    '
    'CheckBoxEnabled
    '
    Me.CheckBoxEnabled.AutoSize = True
    Me.CheckBoxEnabled.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckBoxEnabled.Location = New System.Drawing.Point(3, 3)
    Me.CheckBoxEnabled.Name = "CheckBoxEnabled"
    Me.CheckBoxEnabled.Size = New System.Drawing.Size(94, 46)
    Me.CheckBoxEnabled.TabIndex = 0
    Me.CheckBoxEnabled.Text = "Enabled"
    Me.CheckBoxEnabled.UseVisualStyleBackColor = True
    '
    'LabelName
    '
    Me.LabelName.AutoSize = True
    Me.LabelName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelName.Location = New System.Drawing.Point(103, 0)
    Me.LabelName.Name = "LabelName"
    Me.LabelName.Size = New System.Drawing.Size(594, 52)
    Me.LabelName.TabIndex = 1
    Me.LabelName.Text = "Label this is it"
    Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ButtonConfig
    '
    Me.ButtonConfig.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ButtonConfig.Location = New System.Drawing.Point(803, 3)
    Me.ButtonConfig.Name = "ButtonConfig"
    Me.ButtonConfig.Size = New System.Drawing.Size(44, 46)
    Me.ButtonConfig.TabIndex = 2
    Me.ButtonConfig.Text = "..."
    Me.ButtonConfig.UseVisualStyleBackColor = True
    '
    'LabelType
    '
    Me.LabelType.AutoSize = True
    Me.LabelType.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelType.Location = New System.Drawing.Point(703, 0)
    Me.LabelType.Name = "LabelType"
    Me.LabelType.Size = New System.Drawing.Size(94, 52)
    Me.LabelType.TabIndex = 3
    Me.LabelType.Text = "Type"
    Me.LabelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ControlConfigurationDevice
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelAll)
    Me.Name = "ControlConfigurationDevice"
    Me.Size = New System.Drawing.Size(850, 52)
    Me.TableLayoutPanelAll.ResumeLayout(False)
    Me.TableLayoutPanelAll.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelAll As TableLayoutPanel
  Friend WithEvents CheckBoxEnabled As CheckBox
  Friend WithEvents LabelName As Label
  Friend WithEvents ButtonConfig As Button
  Friend WithEvents LabelType As Label
End Class
