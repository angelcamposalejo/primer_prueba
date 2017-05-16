Imports MySql.Data.MySqlClient

Public Class rutas
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=root; database=gestionoperaciones; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Private Sub rutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select * from rutas"
        Call mostrarLosDatos()
    End Sub
    Private Sub mostrarLosDatos()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            DataGridView1.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ruta As String = InputBox("Introduzca el nombre de la nueva ruta", " Nueva Ruta", "Ruta")
        sql = "insert into rutas(ruta)values('" + ruta.ToString + "')"
        Call insertarLosDatos()
        MsgBox("Nueva ruta capturada")
        sql = "select * from rutas"
        Call mostrarLosDatos()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Dim ruta As String = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        sql = "update rutas set ruta='" + ruta.ToString + "' where id='" + id.ToString + "'"
        Call insertarLosDatos()
        MsgBox("Ruta modificada")
        sql = "select * from rutas"
        Call mostrarLosDatos()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Dim ruta As String = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        sql = "delete from rutas where id='" + id.ToString + "'"
        Call insertarLosDatos()
        MsgBox("Ruta eliminada")
        sql = "select * from rutas"
        Call mostrarLosDatos()
    End Sub
End Class