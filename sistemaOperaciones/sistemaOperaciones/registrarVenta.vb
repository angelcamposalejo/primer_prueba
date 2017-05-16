Imports MySql.Data.MySqlClient

Public Class registrarVenta
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=root; database=gestionoperaciones; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    'VARIABLES para la base de datos
    Dim rutaC As String
    Dim codigoC As String
    Dim categoriaC As String
    Dim descripcionC As String
    Dim precioUC As Double
    Dim cantidadC As Integer
    Dim totalC As String
    Dim comisionC As String
    Dim clienteC As String
    Dim totalVenta As Double = 0
    Dim cantidadExistente As Integer
    Dim auxiliar As Integer
    Dim concepto As String
    Dim cargo As Double
    Dim abono As Double
    Dim saldo As Double



    Private Sub registrarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        sql = "select ruta from rutas"
        Call rutas()
        sql = "select categoria from categoria"
        Call CategoriaM()
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
    Private Sub CategoriaM()
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

        rutaC = ComboBox1.Text
        categoriaC = ComboBox2.Text
        descripcionC = ComboBox3.Text
        sql = "select codigo from almacengeneral where descripcion='" + descripcionC.ToString + "'"
        Call seleccionarCodigo()
        precioUC = TextBox2.Text
        cantidadC = TextBox3.Text
        totalC = precioUC * cantidadC
        clienteC = TextBox1.Text
        If RadioButton1.Checked = True Then
            comisionC = "CON COMISION"
        Else
            If RadioButton2.Checked = True Then
                comisionC = "REGALADO"
            Else
                If RadioButton3.Checked = True Then
                    comisionC = "CAMBIO"
                Else
                    comisionC = "SIN COMISION"
                End If
            End If
        End If
        totalVenta = totalVenta + totalC
        DataGridView1.Rows.Add(codigoC, categoriaC, descripcionC, cantidadC, precioUC, totalC, comisionC, clienteC)
        Dim salida As String = "TOTAL= "
        salida += totalVenta.ToString
        Label8.Text = salida.ToString
        TextBox2.Text = ""
        TextBox3.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
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
        totalVenta = 0
        For Renglones As Integer = 0 To DataGridView1.RowCount - 2
            codigoC = DataGridView1.Item(0, Renglones).Value
            categoriaC = DataGridView1.Item(1, Renglones).Value
            descripcionC = DataGridView1.Item(2, Renglones).Value
            precioUC = DataGridView1.Item(4, Renglones).Value
            cantidadC = DataGridView1.Item(3, Renglones).Value
            totalC = DataGridView1.Item(5, Renglones).Value
            comisionC = DataGridView1.Item(6, Renglones).Value
            clienteC = DataGridView1.Item(7, Renglones).Value
            totalVenta = totalVenta + totalC
            'ACTUALIZAR LA CANTIDAD EN ALMACEN RUTAS
            sql = "Select cantidad from almacenrutas where codigo='" + codigoC.ToString + "' and ruta='" + rutaC.ToString + "'"
            Call seleccionarCantidad()
            cantidadExistente = cantidadExistente - cantidadC
            sql = "update almacenrutas set cantidad=" + cantidadExistente.ToString + " where codigo='" + codigoC.ToString + "' and ruta='" + rutaC.ToString + "'"
            Call insertarLosDatos()
            'REGISTRAR EL MOVIMIENTO DE VENTA
            sql = "insert into ventas(ruta,tipo,descripcion,preciounitario,cantidad,total,fecha,comision,cliente)values('" + rutaC.ToString + "','" + categoriaC.ToString + "','" + descripcionC.ToString + "','" + precioUC.ToString + "'," + cantidadC.ToString + ",'" + totalC.ToString + "','" + DateTimePicker1.Text + "','" + comisionC.ToString + "','" + clienteC.ToString + "')"
            Call insertarLosDatos()
        Next
        'actualizar caja
        concepto = ""
        concepto += "Ventas "
        concepto += rutaC
        cargo = totalVenta
        abono = 0
        Dim categoria As String = "Ventas"
        sql = "insert into caja(concepto,cargo,abono,fecha,categoria)values('" + concepto.ToString + "','" + cargo.ToString + "','" + abono.ToString + "','" + DateTimePicker1.Text + "','" + categoria.ToString + "')"
        'MsgBox(sql)
        Call insertarLosDatos()
        sql = "select cargo from caja where id=1"
        Call seleccionarSaldo()
        saldo = saldo + cargo
        sql = "update caja set cargo='" + saldo.ToString + "' where id=1"
        Call insertarLosDatos()
        'venta finalzada
        MsgBox("Venta Registrada")
        DataGridView1.Rows.Clear()
        TextBox1.Text = ""
        Label8.Text = "TOTAL"
        totalVenta = 0
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