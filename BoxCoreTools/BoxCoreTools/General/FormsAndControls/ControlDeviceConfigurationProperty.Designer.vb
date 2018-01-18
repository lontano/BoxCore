<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDeviceConfigurationProperty
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
    Me.TableLayoutPanelParameter = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelName = New System.Windows.Forms.Label()
    Me.PanelValue = New System.Windows.Forms.Panel()
    Me.TableLayoutPanelParameter.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanelParameter
    '
    Me.TableLayoutPanelParameter.ColumnCount = 2
    Me.TableLayoutPanelParameter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelParameter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelParameter.Controls.Add(Me.LabelName, 0, 0)
    Me.TableLayoutPanelParameter.Controls.Add(Me.PanelValue, 1, 0)
    Me.TableLayoutPanelParameter.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanelParameter.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanelParameter.Name = "TableLayoutPanelParameter"
    Me.TableLayoutPanelParameter.RowCount = 1
    Me.TableLayoutPanelParameter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanelParameter.Size = New System.Drawing.Size(742, 51)
    Me.TableLayoutPanelParameter.TabIndex = 0
    '
    'LabelName
    '
    Me.LabelName.AutoSize = True
    Me.LabelName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelName.Location = New System.Drawing.Point(3, 0)
    Me.LabelName.Name = "LabelName"
    Me.LabelName.Size = New System.Drawing.Size(365, 51)
    Me.LabelName.TabIndex = 0
    Me.LabelName.Text = "Param name"
    Me.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'PanelValue
    '
    Me.PanelValue.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PanelValue.Location = New System.Drawing.Point(374, 3)
    Me.PanelValue.Name = "PanelValue"
    Me.PanelValue.Size = New System.Drawing.Size(365, 45)
    Me.PanelValue.TabIndex = 1
    '
    'ControlDeviceConfigurationProperty
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanelParameter)
    Me.Name = "ControlDeviceConfigurationProperty"
    Me.Size = New System.Drawing.Size(742, 51)
    Me.TableLayoutPanelParameter.ResumeLayout(False)
    Me.TableLayoutPanelParameter.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TableLayoutPanelParameter As TableLayoutPanel
  Friend WithEvents LabelName As Label
  Friend WithEvents PanelValue As Panel
End Class
