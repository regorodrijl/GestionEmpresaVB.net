Imports MySql.Data.MySqlClient
Public Class FormRealPedido
    Dim DtgCliente = Form1.DtgCliente
    Dim DtsXestion = Form1.DtsXestion
    Dim DtsXestionProducto = Form1.DtsXestionProducto
    Dim DtaXestion = Form1.DtaXestion
    Dim conexion = Form1.conexion
    Public array As New ArrayList
    Private Sub ButnCancelar_Click(sender As Object, e As EventArgs) Handles ButnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtProdSelec.Text = "" Or TxtTotal.Text = "" Then
            MsgBox("Faltan datos", MsgBoxStyle.Exclamation, "No se puede guardar")
            Exit Sub
        End If
        'Al aceptar pasamos el array con productos al principal
        Form1.arrayProductos = array
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub FormRealPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DtgCliente.DataSource = DtsXestion.Tables("cliente")

        TxtNombre.DataBindings.Add("Text", DtsXestion.Tables("cliente"), "nombre")
        TxtApellido.DataBindings.Add("Text", DtsXestion.Tables("cliente"), "apellidos")
        TxtTelefono.DataBindings.Add("Text", DtsXestion.Tables("cliente"), "telefono")
        TxtNif.DataBindings.Add("Text", DtsXestion.Tables("cliente"), "nif")
        TxtDireccion.DataBindings.Add("Text", DtsXestion.Tables("cliente"), "direccion")

        'enlazar combobox
        CmbCliente.DataSource = DtsXestion.Tables("cliente")
        CmbCliente.DisplayMember = "nombre"
        CmbCliente.ValueMember() = "idCliente"
        CmbProductos.DataSource = DtsXestionProducto.Tables("producto")
        CmbProductos.DisplayMember = "nombre"
        CmbProductos.ValueMember() = "idProducto"
        'CmbProductos.SelectedIndex = 0
        'Registrado,Montado,Servido
        TextBoxEstado.Text = "Registrado"
        TxtProdSelec.Text += "Producto " & " Cantidad" & "  Precio"
        Dim CbCliente As New MySqlCommandBuilder(DtaXestion)

    End Sub

    Private Sub TxtTotal_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtTotal.KeyPress
        Dim validos As String = "1234567890.," + Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = "." Then
            e.KeyChar = CChar(",")
        End If

    End Sub
    Private Sub TxtCarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        Dim validos As String = "1234567890" + Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Dim importeTotal As Decimal = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim importe As Decimal

        Try
            importe = CDec(DtsXestionProducto.tables("producto").Rows(BuscarRegistro(DtsXestionProducto, "producto", "idProducto", CInt(CmbProductos.SelectedValue))).Item("precio")) * CInt(TxtCantidad.Text)
            TxtPrecioTot.Text = CStr(importe)
            importeTotal += importe
        Catch ex As System.InvalidCastException
            MsgBox("Introduce una cantidad ", MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
        'añadimos prodductos al array
        Dim producto As New Producto(CInt(CmbProductos.SelectedValue), CmbProductos.Text, CInt(TxtCantidad.Text), importe)
        array.Add(producto)
        'añadir el producto a textbox configurado
        ' con System.Environment.NewLine hacemo un salto de linea, tambien tiene scroll en textview
        TxtProdSelec.ScrollBars = ScrollBars.Vertical
        TxtProdSelec.Text += System.Environment.NewLine & CmbProductos.Text & "      " & TxtCantidad.Text & "       " & importe & " €"
        TxtTotal.Text = CStr(importeTotal)
    End Sub
End Class