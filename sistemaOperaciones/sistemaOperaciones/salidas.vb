Imports MySql.Data.MySqlClient

Public Class salidas
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=root; database=gestionoperaciones; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim cantidadExistente As Integer
    Dim rutaC As String
    Dim tipoC As String
    Dim descripcionC As String
    Dim cantidadC As Integer
    Dim auxiliar As Integer = 0
    Dim codigoC As String
    Private Sub salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        sql = "select ruta from rutas"
        Call rutas()
        sql = "select categoria from categoria"
        Call Categoria()
        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox3.AutoCompleteSource = AutoCompleteSource.ListItems
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
            ComboBox1.DisplayMember = "ruta"
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    Private Sub Categoria()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ComboBox2.DataSource = dt
            ComboBox2.DisplayMember = "categoria"
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        sql = "select descripcion from almacengeneral where tipo='" + ComboBox2.Text.ToString + "'"
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
            ComboBox3.DataSource = dt
            ComboBox3.DisplayMember = "descripcion"
            conexion.Close()
        Catch ex As Exception
            ComboBox2.DisplayMember = ""
            conexion.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        tipoC = ComboBox2.Text
        descripcionC = ComboBox3.Text
        cantidadC = TextBox1.Text
        sql = "select codigo from almacengeneral where descripcion='" + descripcionC.ToString + "'"
        Call seleccionarCodigo()
        DataGridView1.Rows.Add(codigoC, tipoC, descripcionC, cantidadC)
        TextBox1.Text = ""
    End Sub
    Private Sub seleccionarCodigo()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            codigoC = dt.Rows(0).Item("codigo")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Ruta sin vendedor asignado", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rutaC = ComboBox1.Text
        For Renglones As Integer = 0 To DataGridView1.RowCount - 2
            codigoC = DataGridView1.Item(0, Renglones).Value
            tipoC = DataGridView1.Item(1, Renglones).Value
            descripcionC = DataGridView1.Item(2, Renglones).Value
            cantidadC = DataGridView1.Item(3, Renglones).Value
            sql = "Select cantidad from almacenrutas where codigo='" + codigoC.ToString + "' and ruta='" + rutaC.ToString + "'"
            Call seleccionarCantidad()
            If auxiliar = 0 Then
                cantidadExistente = cantidadExistente + cantidadC
                sql = "update almacenrutas set cantidad=" + cantidadExistente.ToString + " where codigo='" + codigoC.ToString + "' and ruta='" + rutaC.ToString + "'"
                Call insertarLosDatos()
                'MsgBox("actualizo")
            Else
                sql = "select codigo from almacengeneral where descripcion='" + descripcionC.ToString + "'"
                Call seleccionarCodigo()
                sql = "insert into almacenrutas(ruta,tipo,descripcion,cantidad,codigo)values('" + rutaC.ToString + "','" + tipoC.ToString + "','" + descripcionC.ToString + "','" + cantidadC.ToString + "','" + codigoC + "')"
                Call insertarLosDatos()
                'MsgBox("inserto")
            End If
            sql = "Select cantidad from almacengeneral where codigo='" + codigoC.ToString + "'"
            Call seleccionarCantidad()
            cantidadExistente = cantidadExistente - cantidadC
            sql = "update almacengeneral set cantidad=" + cantidadExistente.ToString + " where codigo='" + codigoC.ToString + "'"
            Call insertarLosDatos()
            Dim llegadas As Integer = 0
            Dim salidas As Integer = cantidadC
            Dim concepto As String = rutaC
            sql = "insert into movimientosalmacen(concepto,descripcion,llegadas,salidas,fecha)values('" + concepto.ToString + "','" + descripcionC.ToString + "','" + llegadas.ToString + "','" + salidas.ToString + "','" + DateTimePicker1.Text + "')"
            Call insertarLosDatos()
            'MsgBox(cantidadExistente)

        Next
        MsgBox("Salida Registrada")
        DataGridView1.Rows.Clear()
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
            auxiliar = 0
            conexion.Close()
        Catch ex As Exception
            auxiliar = 1
            conexion.Close()
            'MsgBox("Ruta sin vendedor asignado", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub
End Class