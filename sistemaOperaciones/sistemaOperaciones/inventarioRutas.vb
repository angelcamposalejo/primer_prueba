Imports MySql.Data.MySqlClient

Public Class inventarioRutas
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=root; database=gestionoperaciones; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Private Sub inventarioRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select ruta,tipo,descripcion,cantidad from almacenrutas"
        Call mostrarLosDatos()
        sql = "select ruta from rutas"
        Call mostrarRutas()
        ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
    Private Sub mostrarRutas()
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
        sql = "select ruta,tipo,descripcion,cantidad from almacenrutas where ruta='" + ComboBox1.Text + "'"
        Call mostrarLosDatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "select ruta,tipo,descripcion,cantidad from almacenrutas"
        Call mostrarLosDatos()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Archivo Excel | *.xlsx"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Exportar_Excel(DataGridView1, SaveFileDialog1.FileName)
        End If
    End Sub
    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)
        Dim xlApp As Object = CreateObject("Excel.Application")
        'crear una nueva hoja de calculo 
        Dim xlWB As Object = xlApp.WorkBooks.add
        Dim xlWS As Object = xlWB.WorkSheets(1)

        'exportamos los caracteres de las columnas
        For c As Integer = 0 To DataGridView1.Columns.Count - 1
            xlWS.cells(1, c + 1).value = DataGridView1.Columns(c).HeaderText
        Next

        'exportamos las cabeceras de columnas
        For r As Integer = 0 To DataGridView1.RowCount - 1
            For c As Integer = 0 To DataGridView1.Columns.Count - 1
                xlWS.cells(r + 2, c + 1).value = DataGridView1.Item(c, r).Value
            Next
        Next

        'guardamos la hoja de calculo en la ruta especificada 
        xlWB.saveas(pth)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing

        MsgBox("Archivo guardado")
    End Sub
End Class