Imports MySql.Data.MySqlClient

Public Class agregarArticulo
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=root; database=gestionoperaciones; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim categoria2 As String
    Dim descripcion2 As String
    Dim codigo2 As String

    Private Sub articuloNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select categoria from categoria"
        Call mostrarCategorias()
        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
    Private Sub mostrarCategorias()
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
        categoria2 = ComboBox1.Text
        descripcion2 = TextBox1.Text
        codigo2 = TextBox2.Text
        DataGridView1.Rows.Add(categoria2, codigo2, descripcion2)
        sql = "select categoria from categoria"
        Call mostrarCategorias()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cantidad As Integer = 0
        For Renglones As Integer = 0 To DataGridView1.RowCount - 2
            categoria2 = DataGridView1.Item(0, Renglones).Value
            codigo2 = DataGridView1.Item(1, Renglones).Value
            descripcion2 = DataGridView1.Item(2, Renglones).Value
            sql = "insert into articulos(categoria,descripcion,codigo)values('" + categoria2.ToString + "','" + descripcion2.ToString + "','" + codigo2.ToString + "')"
            MsgBox(sql)
            Call insertarLosDatos()
            sql = "insert into almacengeneral(tipo,descripcion,cantidad,codigo)values('" + categoria2.ToString + "','" + descripcion2.ToString + "'," + cantidad.ToString + ",'" + codigo2.ToString + "')"
            Call insertarLosDatos()
            MsgBox(sql)
        Next
        MsgBox("Se termino la captura", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        TextBox1.Text = ""
        DataGridView1.Rows.Clear()
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub insertarLosDatos()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            'MsgBox("Se registró correctamente", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
            MsgBox("Verifique que los datos sean correctos", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub
End Class