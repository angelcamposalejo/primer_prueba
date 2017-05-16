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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RUTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALMACENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículoNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasAAlmacénToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidasDeAlmacénToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RutasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoDeAlmacénToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CAJAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasACajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidasDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BLOQUEARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RUTASToolStripMenuItem, Me.ALMACENToolStripMenuItem, Me.VENTASToolStripMenuItem, Me.CAJAToolStripMenuItem, Me.BLOQUEARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(890, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RUTASToolStripMenuItem
        '
        Me.RUTASToolStripMenuItem.Name = "RUTASToolStripMenuItem"
        Me.RUTASToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.RUTASToolStripMenuItem.Text = "RUTAS"
        '
        'ALMACENToolStripMenuItem
        '
        Me.ALMACENToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtículoNuevoToolStripMenuItem, Me.EntradasAAlmacénToolStripMenuItem, Me.SalidasDeAlmacénToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.MovimientoDeAlmacénToolStripMenuItem})
        Me.ALMACENToolStripMenuItem.Name = "ALMACENToolStripMenuItem"
        Me.ALMACENToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ALMACENToolStripMenuItem.Text = "ALMACEN"
        '
        'ArtículoNuevoToolStripMenuItem
        '
        Me.ArtículoNuevoToolStripMenuItem.Name = "ArtículoNuevoToolStripMenuItem"
        Me.ArtículoNuevoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ArtículoNuevoToolStripMenuItem.Text = "Artículo Nuevo"
        '
        'EntradasAAlmacénToolStripMenuItem
        '
        Me.EntradasAAlmacénToolStripMenuItem.Name = "EntradasAAlmacénToolStripMenuItem"
        Me.EntradasAAlmacénToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.EntradasAAlmacénToolStripMenuItem.Text = "Entradas a Almacén"
        '
        'SalidasDeAlmacénToolStripMenuItem
        '
        Me.SalidasDeAlmacénToolStripMenuItem.Name = "SalidasDeAlmacénToolStripMenuItem"
        Me.SalidasDeAlmacénToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SalidasDeAlmacénToolStripMenuItem.Text = "Salidas de Almacén"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem, Me.RutasToolStripMenuItem1})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'RutasToolStripMenuItem1
        '
        Me.RutasToolStripMenuItem1.Name = "RutasToolStripMenuItem1"
        Me.RutasToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.RutasToolStripMenuItem1.Text = "Rutas"
        '
        'MovimientoDeAlmacénToolStripMenuItem
        '
        Me.MovimientoDeAlmacénToolStripMenuItem.Name = "MovimientoDeAlmacénToolStripMenuItem"
        Me.MovimientoDeAlmacénToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.MovimientoDeAlmacénToolStripMenuItem.Text = "Movimiento de Almacén"
        '
        'VENTASToolStripMenuItem
        '
        Me.VENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarVentaToolStripMenuItem, Me.VisualizarVentasToolStripMenuItem})
        Me.VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem"
        Me.VENTASToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.VENTASToolStripMenuItem.Text = "VENTAS"
        '
        'RegistrarVentaToolStripMenuItem
        '
        Me.RegistrarVentaToolStripMenuItem.Name = "RegistrarVentaToolStripMenuItem"
        Me.RegistrarVentaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RegistrarVentaToolStripMenuItem.Text = "Registrar Venta"
        '
        'VisualizarVentasToolStripMenuItem
        '
        Me.VisualizarVentasToolStripMenuItem.Name = "VisualizarVentasToolStripMenuItem"
        Me.VisualizarVentasToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.VisualizarVentasToolStripMenuItem.Text = "Visualizar Ventas"
        '
        'CAJAToolStripMenuItem
        '
        Me.CAJAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradasACajaToolStripMenuItem, Me.SalidasDeCajaToolStripMenuItem, Me.ReporteDeCajaToolStripMenuItem, Me.MovimientosDeCajaToolStripMenuItem, Me.ReporteGeneralToolStripMenuItem})
        Me.CAJAToolStripMenuItem.Name = "CAJAToolStripMenuItem"
        Me.CAJAToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.CAJAToolStripMenuItem.Text = "CAJA"
        '
        'EntradasACajaToolStripMenuItem
        '
        Me.EntradasACajaToolStripMenuItem.Name = "EntradasACajaToolStripMenuItem"
        Me.EntradasACajaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.EntradasACajaToolStripMenuItem.Text = "Entradas a Caja"
        '
        'SalidasDeCajaToolStripMenuItem
        '
        Me.SalidasDeCajaToolStripMenuItem.Name = "SalidasDeCajaToolStripMenuItem"
        Me.SalidasDeCajaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SalidasDeCajaToolStripMenuItem.Text = "Salidas de Caja"
        '
        'ReporteDeCajaToolStripMenuItem
        '
        Me.ReporteDeCajaToolStripMenuItem.Name = "ReporteDeCajaToolStripMenuItem"
        Me.ReporteDeCajaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ReporteDeCajaToolStripMenuItem.Text = "Reporte de Caja"
        '
        'MovimientosDeCajaToolStripMenuItem
        '
        Me.MovimientosDeCajaToolStripMenuItem.Name = "MovimientosDeCajaToolStripMenuItem"
        Me.MovimientosDeCajaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.MovimientosDeCajaToolStripMenuItem.Text = "Movimientos de Caja"
        '
        'ReporteGeneralToolStripMenuItem
        '
        Me.ReporteGeneralToolStripMenuItem.Name = "ReporteGeneralToolStripMenuItem"
        Me.ReporteGeneralToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ReporteGeneralToolStripMenuItem.Text = "Reporte General"
        '
        'BLOQUEARToolStripMenuItem
        '
        Me.BLOQUEARToolStripMenuItem.Name = "BLOQUEARToolStripMenuItem"
        Me.BLOQUEARToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.BLOQUEARToolStripMenuItem.Text = "BLOQUEAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 73)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Saldo"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(716, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(703, 378)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(637, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Introduce la contraseña"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(605, 443)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(273, 86)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Acceso"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 541)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software de Operaciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RUTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ALMACENToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículoNuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasAAlmacénToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidasDeAlmacénToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RutasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CAJAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientoDeAlmacénToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasACajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidasDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BLOQUEARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteGeneralToolStripMenuItem As ToolStripMenuItem
End Class
