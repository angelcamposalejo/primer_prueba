Imports MySql.Data.MySqlClient

Public Class salidasCaja
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=root; database=gestionoperaciones; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim concepto As String
    Dim ventaTotal As Double
    Dim cargo As Double
    Dim abono As Double
    Dim saldo As Double
    Private Sub salidasCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        sql = "select categoria from conceptos"
        Call rutas()
        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
    Private Sub rutas()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "categoria"
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        concepto = ""
        concepto += TextBox1.Text
        'concepto += rutaC
        cargo = 0
        abono = TextBox2.Text
        Dim categoria As String = ComboBox1.Text
        sql = "insert into caja(concepto,cargo,abono,fecha,categoria)values('" + concepto.ToString + "','" + cargo.ToString + "','" + abono.ToString + "','" + DateTimePicker1.Text + "','" + categoria.ToString + "')"
        'MsgBox(sql)
        Call insertarLosDatos()
        sql = "select cargo from caja where id=1"
        Call seleccionarSaldo()
        saldo = saldo - abono
        sql = "update caja set cargo='" + saldo.ToString + "' where id=1"
        Call insertarLosDatos()
        MsgBox("Captura terminada")
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub seleccionarSaldo()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            saldo = dt.Rows(0).Item("cargo")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Ruta sin vendedor asignado", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub
    Private Sub insertarLosDatos()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            'MsgBox("Se registró correctamente", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        Catch ex As Exception
            conexion.Close()
            MsgBox("Verifique que los datos sean correctos", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub
End Class