<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
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
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.WhiteboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.NewWhiteboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.LoadDefaultWhiteboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.SetAsDefaultWhiteboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.CollectorManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.AddNewCollectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TCPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.UDPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(226, 342)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(139, 84)
    Me.Button1.TabIndex = 0
    Me.Button1.Text = "Button1"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(526, 342)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(118, 75)
    Me.Button2.TabIndex = 1
    Me.Button2.Text = "Button2"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'MenuStrip1
    '
    Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WhiteboxToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(1362, 33)
    Me.MenuStrip1.TabIndex = 2
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
    Me.FileToolStripMenuItem.Text = "File"
    '
    'WhiteboxToolStripMenuItem
    '
    Me.WhiteboxToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWhiteboxToolStripMenuItem, Me.LoadDefaultWhiteboxToolStripMenuItem, Me.SetAsDefaultWhiteboxToolStripMenuItem, Me.ToolStripMenuItem1, Me.CollectorManagerToolStripMenuItem})
    Me.WhiteboxToolStripMenuItem.Name = "WhiteboxToolStripMenuItem"
    Me.WhiteboxToolStripMenuItem.Size = New System.Drawing.Size(100, 29)
    Me.WhiteboxToolStripMenuItem.Text = "Whitebox"
    '
    'NewWhiteboxToolStripMenuItem
    '
    Me.NewWhiteboxToolStripMenuItem.Name = "NewWhiteboxToolStripMenuItem"
    Me.NewWhiteboxToolStripMenuItem.Size = New System.Drawing.Size(280, 30)
    Me.NewWhiteboxToolStripMenuItem.Text = "New whitebox..."
    '
    'LoadDefaultWhiteboxToolStripMenuItem
    '
    Me.LoadDefaultWhiteboxToolStripMenuItem.Name = "LoadDefaultWhiteboxToolStripMenuItem"
    Me.LoadDefaultWhiteboxToolStripMenuItem.Size = New System.Drawing.Size(280, 30)
    Me.LoadDefaultWhiteboxToolStripMenuItem.Text = "Load default whitebox"
    '
    'SetAsDefaultWhiteboxToolStripMenuItem
    '
    Me.SetAsDefaultWhiteboxToolStripMenuItem.Name = "SetAsDefaultWhiteboxToolStripMenuItem"
    Me.SetAsDefaultWhiteboxToolStripMenuItem.Size = New System.Drawing.Size(280, 30)
    Me.SetAsDefaultWhiteboxToolStripMenuItem.Text = "Set as default whitebox"
    '
    'CollectorManagerToolStripMenuItem
    '
    Me.CollectorManagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCollectorToolStripMenuItem})
    Me.CollectorManagerToolStripMenuItem.Name = "CollectorManagerToolStripMenuItem"
    Me.CollectorManagerToolStripMenuItem.Size = New System.Drawing.Size(280, 30)
    Me.CollectorManagerToolStripMenuItem.Text = "Collector manager"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(277, 6)
    '
    'AddNewCollectorToolStripMenuItem
    '
    Me.AddNewCollectorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TCPToolStripMenuItem, Me.UDPToolStripMenuItem})
    Me.AddNewCollectorToolStripMenuItem.Name = "AddNewCollectorToolStripMenuItem"
    Me.AddNewCollectorToolStripMenuItem.Size = New System.Drawing.Size(251, 30)
    Me.AddNewCollectorToolStripMenuItem.Text = "Add new collector..."
    '
    'TCPToolStripMenuItem
    '
    Me.TCPToolStripMenuItem.Name = "TCPToolStripMenuItem"
    Me.TCPToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
    Me.TCPToolStripMenuItem.Text = "TCP"
    '
    'UDPToolStripMenuItem
    '
    Me.UDPToolStripMenuItem.Name = "UDPToolStripMenuItem"
    Me.UDPToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
    Me.UDPToolStripMenuItem.Text = "UDP"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1362, 793)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Button1 As Button
  Friend WithEvents Button2 As Button
  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents WhiteboxToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents NewWhiteboxToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents LoadDefaultWhiteboxToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents SetAsDefaultWhiteboxToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
  Friend WithEvents CollectorManagerToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents AddNewCollectorToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents TCPToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents UDPToolStripMenuItem As ToolStripMenuItem
End Class
