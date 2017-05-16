Imports MySql.Data.MySqlClient

Public Class entradas
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=root; database=gestionoperaciones; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim cantidadExistente As Integer
    Dim codigo2 As String


    Private Sub entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        sql = "select categoria from categoria"
        Call Categoria()

        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
    Private Sub Categoria()
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        sql = "select descripcion from almacengeneral where tipo='" + ComboBox1.Text.ToString + "'"
        Call descripcion1()
    End Sub
    Private Sub descripcion1()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ComboBox2.DataSource = dt
            ComboBox2.DisplayMember = "descripcion"
            conexion.Close()
        Catch ex As Exception
            ComboBox2.DisplayMember = ""
            conexion.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim categoria As String = ComboBox1.Text
        Dim cantidad As Integer = TextBox1.Text
        Dim descripcion As String = ComboBox2.Text
        sql = "select codigo from almacengeneral where descripcion='" + descripcion.ToString + "'"
        Call seleccionarCodigo()

        DataGridView1.Rows.Add(codigo2, descripcion, cantidad)
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Renglones As Integer = 0 To DataGridView1.RowCount - 2
            Dim codigo As String = DataGridView1.Item(0, Renglones).Value
            Dim descripcion As String = DataGridView1.Item(1, Renglones).Value
            Dim cantidad As Integer = DataGridView1.Item(2, Renglones).Value
            sql = "Select cantidad from almacengeneral where descripcion='" + descripcion.ToString + "'"
            Call seleccionarCantidad()
            cantidadExistente = cantidadExistente + cantidad
            sql = "update almacengeneral set cantidad=" + cantidadExistente.ToString + " where codigo='" + codigo.ToString + "'"
            Call insertarLosDatos()
            Dim salidas As Integer = 0
            Dim concepto As String = "ALMACEN GENERAL"
            sql = "insert into movimientosalmacen(concepto,descripcion,llegadas,salidas,fecha)values('" + concepto.ToString + "','" + descripcion.ToString + "','" + cantidad.ToString + "','" + salidas.ToString + "','" + DateTimePicker1.Text + "')"
            Call insertarLosDatos()
        Next
        DataGridView1.Rows.Clear()
        MsgBox("Se termino la captura")
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
    Private Sub seleccionarCantidad()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            cantidadExistente = dt.Rows(0).Item("cantidad")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Ruta sin vendedor asignado", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub
    Private Sub seleccionarCodigo()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            codigo2 = dt.Rows(0).Item("codigo")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Ruta sin vendedor asignado", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub
End Class