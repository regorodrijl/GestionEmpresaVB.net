Imports MySql.Data.MySqlClient
Public Class Form1
    Public conexion As MySqlConnection
    Public DtaXestion As MySqlDataAdapter
    Dim Cb As MySqlCommandBuilder

    Public DtsXestion As New DataSet
    Public DtsXestionProducto As New DataSet
    Public DtsXestionPedido As New DataSet
    Public DtsXestionProveedor As New DataSet
    Public DtsXestionLinea As New DataSet

    Dim FrmNCliente As FormNCliente
    Dim FrmPedido As FormRealPedido
    Dim frmNProd As FormNProducto
    Dim FrmProveedor As FormNProveedor

    Dim filaProd As DataRow
    Dim filaPed As DataRow
    Dim filaCliente As DataRow
    Dim filaProv As DataRow
    Dim filaLineaPedido As DataRow

    Public arrayProductos As ArrayList


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'para la conexion
        Try
            Dim txtServer As String = "127.0.0.1"           '"dbalumnos" 
            Dim txtUsuario As String = "root"               '"A11JoseLuisRR"
            Dim txtContrasena As String = ""
            Dim txtPuerto As String = "3306"                '"3312"
            Dim txtBaseDatosName As String = "a11joseluisrr"  '   "A11JoseLuisRR"
            conexion = New MySqlConnection("Server=" & txtServer & ";" & _
                                           "Uid=" & txtUsuario & ";" & _
                                           "Pwd=" & txtContrasena & ";" & _
                                           "Port=" & txtPuerto & ";" & _
                                           "Database=" & txtBaseDatosName & ";")
            'MsgBox(conexion.State)
            'conexion.Open()
            'MsgBox(conexion.State)
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        ' conexion.Open()


        DtaXestion = New MySqlDataAdapter("select * from cliente order by idCliente;", conexion)
        DtaXestion.Fill(DtsXestion, "cliente")
        DtgCliente.DataSource = DtsXestion.Tables("cliente")

        DtaXestion = New MySqlDataAdapter("select * from producto order by idProducto;", conexion)
        DtaXestion.Fill(DtsXestionProducto, "producto")
        'DtgCliente.DataSource = DtsXestion.Tables("producto")

        'DtaXestion = New MySqlDataAdapter("select * from Pedido p , Cliente c where p.Cliente_idCliente = c.idCliente; ", conexion)
       

        'DtaXestion = New MySqlDataAdapter("select * from pedido where idCliente=;", conexion)
        '  DtaXestion.Fill(DtsXestionPedido, "pedido")
        ' DtgPedido.DataSource = DtsXestionPedido.Tables("pedido")
        '
        ' 'muestra solo los pedidos del cliente seleccionado
        DtaXestion = New MySqlDataAdapter("select * from pedido ORDER BY idPedido;", conexion)
        DtaXestion.Fill(DtsXestionPedido, "pedido")




        Cb = New MySqlCommandBuilder(DtaXestion)

        'conexion.Close()
    End Sub

    Private Sub Salir(sender As Object, e As EventArgs) Handles TsSalir.Click
        Me.Close()
        End
    End Sub
    Private Sub nuevoCliente(sender As Object, e As EventArgs) Handles TsNuevoCliente.Click
        FrmNCliente = New FormNCliente

        If FrmNCliente.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        DtaXestion = New MySqlDataAdapter("select * from cliente order by idCliente;", conexion)
        DtsXestion.Tables("cliente").Clear()
        DtaXestion.Fill(DtsXestion, "cliente")
        Dim CbCliente As New MySqlCommandBuilder(DtaXestion)


        filaCliente = DtsXestion.Tables("cliente").NewRow
        With FrmNCliente

            filaCliente("nombre") = .TxtNombre.Text
            filaCliente("apellidos") = .TxtApellidos.Text
            filaCliente("nif") = .TxtNif.Text
            filaCliente("telefono") = .TxtTelefono.Text
            filaCliente("direccion") = .TxtDireccion.Text

        End With
        DtsXestion.Tables("cliente").Rows.Add(filaCliente)

        DtaXestion.Update(DtsXestion, "cliente")
        DtsXestion.AcceptChanges()

        DtaXestion = New MySqlDataAdapter("select * from cliente order by idCliente;", conexion)
        DtsXestion.Clear()
        DtaXestion.Fill(DtsXestion, "cliente")


    End Sub
    Private Sub TsNuevoPoducto_Click(sender As Object, e As EventArgs) Handles TsNuevoPoducto.Click
        frmNProd = New FormNProducto

        If frmNProd.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        DtaXestion = New MySqlDataAdapter("select * from producto order by idProducto;", conexion)
        DtsXestionProducto.Tables("producto").Clear()
        DtaXestion.Fill(DtsXestionProducto, "producto")
        Cb = New MySqlCommandBuilder(DtaXestion)
        filaProd = DtsXestionProducto.Tables("producto").NewRow
        With frmNProd
            filaProd("nombre") = .TxtNombre.Text
            filaProd("cantidad") = CInt(.TxtCantidad.Text)
            filaProd("precio") = CDec(.TxtPrecio.Text)
        End With
        DtsXestionProducto.Tables("producto").Rows.Add(filaProd)

        DtaXestion.Update(DtsXestionProducto, "producto")
        DtsXestionProducto.AcceptChanges()

        DtaXestion = New MySqlDataAdapter("select * from producto order by idProducto;", conexion)
        DtsXestionProducto.Clear()
        DtaXestion.Fill(DtsXestionProducto, "producto")

    End Sub
    Private Sub Real_Pedido_Click(sender As Object, e As EventArgs) Handles BtnPedido.Click, TsNuevoPedido.Click
        FrmPedido = New FormRealPedido
        If FrmPedido.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If

        DtaXestion = New MySqlDataAdapter("select * from pedido ORDER BY idPedido;", conexion)
        DtsXestionPedido.Tables("pedido").Clear()
        DtaXestion.Fill(DtsXestionPedido, "pedido")
        Cb = New MySqlCommandBuilder(DtaXestion)

        filaPed = DtsXestionPedido.Tables("pedido").NewRow
        With FrmPedido

            filaPed("Cliente_idCliente") = .CmbCliente.SelectedValue
            filaPed("fecha") = .DdtpFecha.Value
            filaPed("estado") = .TextBoxEstado.Text
            filaPed("precio") = CDec(.TxtTotal.Text)
        End With
        DtsXestionPedido.Tables("pedido").Rows.Add(filaPed)
        DtaXestion.Update(DtsXestionPedido, "pedido")
        DtsXestionPedido.AcceptChanges()

        DtaXestion = New MySqlDataAdapter("select * from pedido ORDER BY idPedido;", conexion)
        DtsXestionPedido.Tables("pedido").Rows.Clear()
        DtaXestion.Fill(DtsXestionPedido, "pedido")


        'generamos ahora la linea de pedido por cada producto.
        'llenar Linea preparacion BD y CB
        DtaXestion = New MySqlDataAdapter("Select * from linea_pedido ORDER BY idLinea_Pedido", conexion)

        DtaXestion.Fill(DtsXestionLinea, "LineaPedido")

        Cb = New MySqlCommandBuilder(DtaXestion)

        'Para saber el ultimo pedido que se acaba de rellenar
        Dim contador As Integer
        contador = DtsXestionPedido.Tables("Pedido").Rows.Count

        'Recorremos el array para asignar cada producto a una linea
        For Each item As Producto In arrayProductos
            'llena la linea
            filaLineaPedido = DtsXestionLinea.Tables("LineaPedido").NewRow
            With FrmPedido
                filaLineaPedido("Pedido_idPedido") = DtsXestionPedido.Tables("pedido").Rows(contador - 1).Item(0)
                filaLineaPedido("Producto_idProducto") = item.idProducto
                filaLineaPedido("cantidad") = item.cantidad
                filaLineaPedido("estado") = .TextBoxEstado.Text
                filaLineaPedido("fecha") = .DdtpFecha.Value
                filaLineaPedido("Pedido_fecha") = .DdtpFecha.Value
            End With
            DtsXestionLinea.Tables("LineaPedido").Rows.Add(filaLineaPedido)
        Next

        'actualizar BD
        DtaXestion.Update(DtsXestionLinea, "LineaPedido")
        DtsXestion.AcceptChanges()






    End Sub

    'Public Function igualValor(dt As DataTable, nomCampo As String, valorAComprobar As String)
    '    Dim igual As Boolean = True
    '    Dim f As DataRow
    '    For Each f In dt.Rows
    '        If f(nomCampo) <> valorAComprobar Then
    '            igual = False
    '            Exit For
    '        End If
    '    Next
    '    Return igual
    'End Function

  
    Private Sub TsNuevoProveedor_Click(sender As Object, e As EventArgs) Handles TsNuevoProveedor.Click
        FrmProveedor = New FormNProveedor

        If FrmProveedor.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If


        DtaXestion = New MySqlDataAdapter("select * from proveedor ORDER BY idproveedor;", conexion)
        DtaXestion.Fill(DtsXestionProveedor, "proveedor")
        DtsXestionProveedor.Tables("proveedor").Rows.Clear()

        Cb = New MySqlCommandBuilder(DtaXestion)

        filaProv = DtsXestionProveedor.Tables("proveedor").NewRow
        With FrmProveedor
            filaProv("nombre") = .TxtNombre.Text
            filaProv("nif") = .TxtNif.Text
        End With
        DtsXestionProveedor.Tables("proveedor").Rows.Add(filaProv)
        DtaXestion.Update(DtsXestionProveedor, "proveedor")
        DtsXestionProveedor.AcceptChanges()

        DtaXestion = New MySqlDataAdapter("select * from proveedor ORDER BY idproveedor;", conexion)
        DtsXestionProveedor.Tables("proveedor").Rows.Clear()
        DtaXestion.Fill(DtsXestionProveedor, "proveedor")
    End Sub
End Class
