Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=root; database=gestionoperaciones; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim cantidadExistente As String
    Dim acceso As String
    Dim activo As Integer = 1
    Private Sub ArtículoNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtículoNuevoToolStripMenuItem.Click
        agregarArticulo.Visible = True
    End Sub

    Private Sub EntradasAAlmacénToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasAAlmacénToolStripMenuItem.Click
        entradas.Visible = True
    End Sub

    Private Sub SalidasDeAlmacénToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasDeAlmacénToolStripMenuItem.Click
        salidas.Visible = True
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click
        inventarioGeneral.Visible = True
    End Sub

    Private Sub RutasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RutasToolStripMenuItem1.Click
        inventarioRutas.Visible = True
    End Sub

    Private Sub RegistrarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVentaToolStripMenuItem.Click
        registrarVenta.Visible = True
    End Sub

    Private Sub MovimientoDeAlmacénToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoDeAlmacénToolStripMenuItem.Click
        movimientoAlmacen.Visible = True
    End Sub

    Private Sub VisualizarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarVentasToolStripMenuItem.Click
        visualizarVentas.Visible = True
    End Sub

    Private Sub EntradasACajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasACajaToolStripMenuItem.Click
        entradasCaja.Visible = True
    End Sub

    Private Sub SalidasDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasDeCajaToolStripMenuItem.Click
        salidasCaja.Visible = True
    End Sub

    Private Sub ReporteDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCajaToolStripMenuItem.Click
        reporteCaja.Visible = True
    End Sub

    Private Sub MovimientosDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosDeCajaToolStripMenuItem.Click
        movimientosCaja.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        TextBox1.Visible = False
        Button1.Visible = False
        MenuStrip1.Enabled = False
        Dim cadena As String = "Saldo "
        sql = "select cargo from caja where id=1"
        Call seleccionarCantidad()
        cadena += cantidadExistente
        Label1.Text = cadena
    End Sub
    Private Sub seleccionarCantidad()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            cantidadExistente = dt.Rows(0).Item("cargo")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Ruta sin vendedor asignado", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x As String = TextBox1.Text

        sql = "select acceso from acceso where id=1"
        Call seleccionarAcceso()
        If acceso = x Then
            MsgBox("Acceso correcto")
            Label2.Visible = False
            Button1.Visible = False
            TextBox1.Text = ""
            TextBox1.Visible = False
            MenuStrip1.Enabled = True

        Else
            MsgBox("Contraseña incorrecta intente de nuevo")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Visible = True
        Button1.Visible = True
        TextBox1.Visible = True
    End Sub
    Private Sub seleccionarAcceso()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            acceso = dt.Rows(0).Item("acceso")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Ruta sin vendedor asignado", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If activo = 0 Then
            Dim cadena As String = "Saldo "
            sql = "select cargo from caja where id=1"
            Call seleccionarCantidad()
            cadena += cantidadExistente
            Label1.Text = cadena
            activo = activo + 1
        End If
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        activo = 0
    End Sub

    Private Sub RUTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RUTASToolStripMenuItem.Click
        rutas.Visible = True
    End Sub

    Private Sub BLOQUEARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BLOQUEARToolStripMenuItem.Click
        MenuStrip1.Enabled = False
    End Sub

    Private Sub ReporteGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteGeneralToolStripMenuItem.Click
        reportegeneral.Visible = True
    End Sub

    Private Sub CAJAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CAJAToolStripMenuItem.Click

    End Sub
End Class
