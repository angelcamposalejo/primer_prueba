Imports MySql.Data.MySqlClient

Public Class reportegeneral
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=root; database=gestionoperaciones; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    'variables de consulta
    Dim contadora As Double
    Dim contadorb As Double
    'variables del Ventas
    Dim ventas As Double
    'variables de caja
    Dim caja As Double
    'varianles de gastos de ventas
    Dim casetasa As Double
    Dim casetasb As Double
    Dim casetas As Double
    Dim devolucionesa As Double
    Dim devolucionesb As Double
    Dim devoluciones As Double
    Dim estacionamiento As Double
    Dim estacionamientoa As Double
    Dim estacionamientob As Double
    Dim extras As Double
    Dim extrasa As Double
    Dim extrasb As Double
    Dim gasolina As Double
    Dim gasolinaa As Double
    Dim gasolinab As Double
    Dim hospedaje As Double
    Dim hospedajea As Double
    Dim hospedajeb As Double
    Dim credito As Double
    Dim creditoa As Double
    Dim creditob As Double
    Dim viaticos As Double
    Dim viaticosa As Double
    Dim viaticosb As Double
    Dim gastosventa As Double
    'variables gastos de administracion
    Dim comida As Double
    Dim comidaa As Double
    Dim comidab As Double
    Dim comisiones As Double
    Dim comisionesa As Double
    Dim comisionesb As Double
    Dim limpieza As Double
    Dim limpiezaa As Double
    Dim limpiezab As Double
    Dim nomina As Double
    Dim nominaa As Double
    Dim nominab As Double
    Dim papeleria As Double
    Dim papeleriaa As Double
    Dim papeleariab As Double
    Dim prestamos As Double
    Dim prestamosa As Double
    Dim prestamosb As Double
    Dim renta As Double
    Dim rentaa As Double
    Dim rentab As Double
    Dim servicios As Double
    Dim serviciosa As Double
    Dim serviciosb As Double
    Dim viaticosoficina As Double
    Dim viaticosoficinaa As Double
    Dim viaticosoficinab As Double
    Dim gastosadmon As Double
    'variables gastos de operacion
    Dim equipos As Double
    Dim equiposa As Double
    Dim equiposb As Double
    Dim mantenimiento As Double
    Dim mantenimientoa As Double
    Dim mantenimientob As Double
    Dim cadenas As Double
    Dim cadenasa As Double
    Dim cadenasb As Double
    Dim pension As Double
    Dim pensioa As Double
    Dim pensionb As Double
    Dim publicidad As Double
    Dim publicidada As Double
    Dim publicidadb As Double
    Dim uniformes As Double
    Dim uniformesa As Double
    Dim uniformesb As Double
    Dim coches As Double
    Dim cochesa As Double
    Dim cochesb As Double
    Dim gastosoperacion As Double
    'DAVID
    Dim david As Double
    Dim davida As Double
    Dim davidb As Double
    'MARQUESADA
    Dim marquesada As Double
    Dim marquesadaa As Double
    Dim marquesadab As Double
    'BALANCE GENERAL
    Dim balance As Double

    Private Sub reportegeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy-MM-dd"

    End Sub
    Private Sub colorear()
        Dim myfont As Font
        myfont = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Rows(0).Cells(2).Style.Font = myfont
        'DataGridView1.Rows(0).Cells(2).Style.Font =
        If DataGridView1.Item(2, 0).Value < 0 Then
            DataGridView1.Rows(0).Cells(2).Style.ForeColor = Color.DarkRed
        Else
            DataGridView1.Rows(0).Cells(2).Style.ForeColor = Color.DarkBlue
        End If
    End Sub
    Private Sub seleccionarCantidad()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            contadora = dt.Rows(0).Item("sum(cargo)")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox(ex.Message)
            'MsgBox("Ruta sin vendedor asignado", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub
    Private Sub seleccionarCantidadb()
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            contadora = dt.Rows(0).Item("sum(abono)")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox(ex.Message)
            'MsgBox("Ruta sin vendedor asignado", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Sub
    Private Sub limpiar()
        'variables de consulta
        contadora = 0
        contadorb = 0
        'variables del Ventas
        ventas = 0
        'variables de caja
        caja = 0
        'varianles de gastos de ventas
        casetasa = 0
        Dim casetasb As Double
        Dim casetas As Double
        Dim devolucionesa As Double
        Dim devolucionesb As Double
        Dim devoluciones As Double
        Dim estacionamiento As Double
        Dim estacionamientoa As Double
        Dim estacionamientob As Double
        Dim extras As Double
        Dim extrasa As Double
        Dim extrasb As Double
        Dim gasolina As Double
        Dim gasolinaa As Double
        Dim gasolinab As Double
        Dim hospedaje As Double
        Dim hospedajea As Double
        Dim hospedajeb As Double
        Dim credito As Double
        Dim creditoa As Double
        Dim creditob As Double
        Dim viaticos As Double
        Dim viaticosa As Double
        Dim viaticosb As Double
        Dim gastosventa As Double
        'variables gastos de administracion
        Dim comida As Double
        Dim comidaa As Double
        Dim comidab As Double
        Dim comisiones As Double
        Dim comisionesa As Double
        Dim comisionesb As Double
        Dim limpieza As Double
        Dim limpiezaa As Double
        Dim limpiezab As Double
        Dim nomina As Double
        Dim nominaa As Double
        Dim nominab As Double
        Dim papeleria As Double
        Dim papeleriaa As Double
        Dim papeleariab As Double
        Dim prestamos As Double
        Dim prestamosa As Double
        Dim prestamosb As Double
        Dim renta As Double
        Dim rentaa As Double
        Dim rentab As Double
        Dim servicios As Double
        Dim serviciosa As Double
        Dim serviciosb As Double
        Dim viaticosoficina As Double
        Dim viaticosoficinaa As Double
        Dim viaticosoficinab As Double
        Dim gastosadmon As Double
        'variables gastos de operacion
        Dim equipos As Double
        Dim equiposa As Double
        Dim equiposb As Double
        Dim mantenimiento As Double
        Dim mantenimientoa As Double
        Dim mantenimientob As Double
        Dim cadenas As Double
        Dim cadenasa As Double
        Dim cadenasb As Double
        Dim pension As Double
        Dim pensioa As Double
        Dim pensionb As Double
        Dim publicidad As Double
        Dim publicidada As Double
        Dim publicidadb As Double
        Dim uniformes As Double
        Dim uniformesa As Double
        Dim uniformesb As Double
        Dim gastosoperacion As Double
        'DAVID
        Dim david As Double
        Dim davida As Double
        Dim davidb As Double
        'MARQUESADA
        Dim marquesada As Double
        Dim marquesadaa As Double
        'marquesadab
        'BALANCE GENERAL
        Dim balance As Double
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        Dim cadena As String = "DEL "
        cadena += DateTimePicker1.Text
        cadena += " AL "
        cadena += DateTimePicker2.Text
        DataGridView1.Rows.Add("REPORTE GENERAL", cadena, "", "")
        'CALCULAR CAJA
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Saldo Inicial' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        caja = contadora
        DataGridView1.Rows.Add("SALDO INICIAL", "", caja, "")
        'CALCULAR VENTAS
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Ventas' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        ventas = contadora
        DataGridView1.Rows.Add("VENTAS", "", ventas, "")
        'CALCULAR GASTOS DE VENTA
        DataGridView1.Rows.Add("GASTOS DE VENTA", "", "", "")
        'casetas
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Casetas' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        casetasa = contadora
        sql = "select sum(abono) from caja where categoria='Casetas' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        casetasb = contadora
        DataGridView1.Rows.Add("", "Casetas", casetasa, casetasb)
        casetas = casetasa - casetasb
        'devoluciones sobre venta
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Devoluciones sobre venta' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        devolucionesa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Devoluciones sobre venta' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        devolucionesb = contadora
        DataGridView1.Rows.Add("", "Devoluciones sobre venta", devolucionesa, devolucionesb)
        devoluciones = devolucionesa - devolucionesb
        'estacionamiento
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Estacionamiento' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        estacionamientoa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Estacionamiento' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        estacionamientob = contadora
        DataGridView1.Rows.Add("", "Estacionamiento", estacionamientoa, estacionamientob)
        estacionamiento = estacionamientoa - estacionamientob
        'extras
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Extras' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        extrasa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Extras' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        extrasb = contadora
        DataGridView1.Rows.Add("", "Extras", extrasa, extrasb)
        extras = extrasa - extrasb
        'gasolina rutas
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Gasolina Rutas' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        gasolinaa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Gasolina Rutas' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        gasolinab = contadora
        DataGridView1.Rows.Add("", "Gasolina Rutas", gasolinaa, gasolinab)
        gasolina = gasolinaa - gasolinab
        'hospedaje
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Hospedaje' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        hospedajea = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Hospedaje' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        hospedajeb = contadora
        DataGridView1.Rows.Add("", "Hospedaje", hospedajea, hospedajeb)
        hospedaje = hospedajea - hospedajeb
        'ventas a credito
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Ventas a Credito' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        creditoa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Ventas a Credito' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        creditob = contadora
        DataGridView1.Rows.Add("", "Ventas a Credito", creditoa, creditob)
        credito = creditoa - creditob
        'viaticos rutas
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Viaticos de Rutas' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        viaticosa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Viaticos de Rutas' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        viaticosb = contadora
        DataGridView1.Rows.Add("", "Viaticos de Rutas", viaticosa, viaticosb)
        viaticos = viaticosa - viaticosb
        'total gastos de venta
        gastosventa = casetas + devoluciones + estacionamiento + extras + gasolina + hospedaje + credito + viaticos
        DataGridView1.Rows.Add("", "TOTAL GASTOS DE VENTA", gastosventa, "")
        'GAST0S DE AMINISTRACION
        DataGridView1.Rows.Add("GASTOS DE ADMINISTRACION", "", "", "")
        'comida
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Comida' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        comidaa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Comida' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        comidab = contadora
        DataGridView1.Rows.Add("", "Comida", comidaa, comidab)
        comida = comidaa - comidab
        'comisiones portas
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Comisiones Portas y Venta Equipos' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        comisionesa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Comisiones Portas y Venta Equipos' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        comisionesb = contadora
        DataGridView1.Rows.Add("", "Comisiones Portas y Venta Equipos", comisionesa, comisionesb)
        comisiones = comisionesa - comisionesb
        'limpieza
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Limpieza' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        limpiezaa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Limpieza' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        limpiezab = contadora
        DataGridView1.Rows.Add("", "Limpieza", limpiezaa, limpiezab)
        limpieza = limpiezaa - limpiezab
        'nomina
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Nomina' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        nominaa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Nomina' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        nominab = contadora
        DataGridView1.Rows.Add("", "Nomina", nominaa, nominab)
        nomina = nominaa - nominab
        'papeleria
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Papeleria y Utiles' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        papeleriaa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Papeleria y Utiles' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        papeleariab = contadora
        DataGridView1.Rows.Add("", "Papeleria y Utiles", papeleriaa, papeleariab)
        papeleria = papeleriaa - papeleariab
        'prestamos
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Prestamos de Nomina' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        prestamosa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Prestamos de Nomina' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        prestamosb = contadora
        DataGridView1.Rows.Add("", "Prestamos de Nomina", prestamosa, prestamosb)
        prestamos = prestamosa - prestamosb
        'renta oficina
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Renta Oficina' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        rentaa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Renta Oficina' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        rentab = contadora
        DataGridView1.Rows.Add("", "Renta Oficina", rentaa, rentab)
        renta = rentaa - rentab
        'servicios
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Servicios' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        serviciosa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Servicios' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        serviciosb = contadora
        DataGridView1.Rows.Add("", "Servicios", rentaa, rentab)
        servicios = serviciosa - serviciosb
        'viaticos oficina
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Viaticos Oficina' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        viaticosoficinaa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Viaticos Oficina' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        viaticosoficinab = contadora
        DataGridView1.Rows.Add("", "Viaticos Oficina", viaticosoficinaa, viaticosoficinab)
        viaticosoficina = viaticosoficinaa - viaticosoficinab
        'total gastos de administracion
        gastosadmon = comida + comisiones + limpieza + nomina + papeleria + prestamos + renta + servicios + viaticosoficina
        DataGridView1.Rows.Add("", "TOTAL GASTOS DE ADMON", gastosadmon, "")
        'GASTOS DE OPERACION
        DataGridView1.Rows.Add("GASTOS DE OPERACION", "", "", "")
        'coches
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Coches' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        cochesa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Coches' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        cochesb = contadora
        DataGridView1.Rows.Add("", "Coches", cochesa, cochesb)
        coches = cochesa - cochesb
        'equipos
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Equipos' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        equiposa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Equipos' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        equiposb = contadora
        DataGridView1.Rows.Add("", "Equipos", equiposa, equiposb)
        equipos = equiposa - equiposb
        'mantenimiento
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Mantenimiento Automoviles' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        mantenimientoa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Mantenimiento Automoviles' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        mantenimientob = contadora
        DataGridView1.Rows.Add("", "Mantenimiento Automoviles", mantenimientoa, mantenimientob)
        mantenimiento = mantenimientoa - mantenimientob
        'cadenas
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Operaciones Cadenas' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        cadenasa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Operaciones Cadenas' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        cadenasb = contadora
        DataGridView1.Rows.Add("", "Operaciones Cadenas", cadenasa, cadenasb)
        cadenas = cadenasa - cadenasb
        'pension
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Pension Automoviles' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        pensioa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Pension Automoviles' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        pensionb = contadora
        DataGridView1.Rows.Add("", "Pension Automoviles", pensioa, pensionb)
        pension = pensioa - pensionb
        'publicidad
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Publicidad' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        publicidada = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Publicidad' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        publicidadb = contadora
        DataGridView1.Rows.Add("", "Publicidad", publicidada, publicidadb)
        publicidad = publicidada - publicidadb
        'uniformes
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Uniformes y Credenciales' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        uniformesa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Uniformes y Credenciales' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        uniformesb = contadora
        DataGridView1.Rows.Add("", "Uniformes y Credenciales", uniformesa, uniformesb)
        uniformes = uniformesa - uniformesb
        'total gastos de operacion
        gastosoperacion = equipos + mantenimiento + cadenas + pension + publicidad + uniformes + coches
        DataGridView1.Rows.Add("", "TOTAL GASTOS DE OPERACION", gastosoperacion, "")
        'DAVID
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='David' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        davida = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='David' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        davidb = contadora
        DataGridView1.Rows.Add("DAVID", "", davida, davidb)
        david = davida - davidb
        'total gastos david
        DataGridView1.Rows.Add("", "TOTAL", david, "")
        'MARQUESADA
        contadora = 0
        sql = "select sum(cargo) from caja where categoria='Marquesada' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidad()
        marquesadaa = contadora
        contadora = 0
        sql = "select sum(abono) from caja where categoria='Marquesada' and fecha between'" + DateTimePicker1.Text + "' and '" + DateTimePicker2.Text + "'"
        Call seleccionarCantidadb()
        marquesadab = contadora
        DataGridView1.Rows.Add("MARQUESDA", "", marquesadaa, marquesadab)
        marquesada = marquesadaa - marquesadab
        'total gastos david
        DataGridView1.Rows.Add("", "TOTAL", marquesada, "")
        'BALANCE GENERAL
        balance = caja + ventas + gastosadmon + gastosventa + gastosoperacion + david + marquesada
        DataGridView1.Rows.Add("", "BALANCE TOTAL", balance, "")
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