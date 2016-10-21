<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRealPedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Productos = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.ButnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtNif = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblNif = New System.Windows.Forms.Label()
        Me.Lblapellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.CmbProductos = New System.Windows.Forms.ComboBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.DdtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxEstado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtPrecioTot = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtProdSelec = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Productos
        '
        Me.Productos.AutoSize = True
        Me.Productos.Location = New System.Drawing.Point(34, 182)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(58, 13)
        Me.Productos.TabIndex = 26
        Me.Productos.Text = "Productos:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(61, 30)
        Me.TxtNombre.MaxLength = 11
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(132, 20)
        Me.TxtNombre.TabIndex = 65
        '
        'ButnCancelar
        '
        Me.ButnCancelar.Location = New System.Drawing.Point(579, 392)
        Me.ButnCancelar.Name = "ButnCancelar"
        Me.ButnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButnCancelar.TabIndex = 59
        Me.ButnCancelar.Text = "Cancelar"
        Me.ButnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(37, 391)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 58
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtNif
        '
        Me.TxtNif.Location = New System.Drawing.Point(61, 61)
        Me.TxtNif.MaxLength = 25
        Me.TxtNif.Name = "TxtNif"
        Me.TxtNif.ReadOnly = True
        Me.TxtNif.Size = New System.Drawing.Size(132, 20)
        Me.TxtNif.TabIndex = 55
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(266, 30)
        Me.TxtApellido.MaxLength = 5
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.ReadOnly = True
        Me.TxtApellido.Size = New System.Drawing.Size(132, 20)
        Me.TxtApellido.TabIndex = 54
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(266, 61)
        Me.TxtDireccion.MaxLength = 50
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(337, 20)
        Me.TxtDireccion.TabIndex = 57
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(471, 30)
        Me.TxtTelefono.MaxLength = 50
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.ReadOnly = True
        Me.TxtTelefono.Size = New System.Drawing.Size(132, 20)
        Me.TxtTelefono.TabIndex = 56
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(413, 37)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.LblTelefono.TabIndex = 64
        Me.LblTelefono.Text = "Teléfono:"
        '
        'LblNif
        '
        Me.LblNif.AutoSize = True
        Me.LblNif.Location = New System.Drawing.Point(32, 68)
        Me.LblNif.Name = "LblNif"
        Me.LblNif.Size = New System.Drawing.Size(23, 13)
        Me.LblNif.TabIndex = 63
        Me.LblNif.Text = "Nif:"
        '
        'Lblapellido
        '
        Me.Lblapellido.AutoSize = True
        Me.Lblapellido.Location = New System.Drawing.Point(208, 37)
        Me.Lblapellido.Name = "Lblapellido"
        Me.Lblapellido.Size = New System.Drawing.Size(52, 13)
        Me.Lblapellido.TabIndex = 62
        Me.Lblapellido.Text = "Apellidos:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(8, 37)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 61
        Me.LblNombre.Text = "Nombre:"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(205, 68)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.LblDireccion.TabIndex = 60
        Me.LblDireccion.Text = "Dirección:"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(343, 397)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(34, 13)
        Me.LblTotal.TabIndex = 66
        Me.LblTotal.Text = "Total:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 43)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Cliente"
        '
        'CmbCliente
        '
        Me.CmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(10, 19)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(121, 21)
        Me.CmbCliente.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Productos Seleccionados:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(383, 394)
        Me.TxtTotal.MaxLength = 11
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(41, 20)
        Me.TxtTotal.TabIndex = 71
        '
        'CmbProductos
        '
        Me.CmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProductos.FormattingEnabled = True
        Me.CmbProductos.Location = New System.Drawing.Point(96, 179)
        Me.CmbProductos.Name = "CmbProductos"
        Me.CmbProductos.Size = New System.Drawing.Size(121, 21)
        Me.CmbProductos.TabIndex = 19
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(237, 182)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 72
        Me.lblCantidad.Text = "Cantidad:"
        '
        'DdtpFecha
        '
        Me.DdtpFecha.Location = New System.Drawing.Point(96, 219)
        Me.DdtpFecha.Name = "DdtpFecha"
        Me.DdtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.DdtpFecha.TabIndex = 77
        '
        'TextBoxEstado
        '
        Me.TextBoxEstado.Location = New System.Drawing.Point(497, 179)
        Me.TextBoxEstado.Name = "TextBoxEstado"
        Me.TextBoxEstado.ReadOnly = True
        Me.TextBoxEstado.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEstado.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Fecha:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.TxtNif)
        Me.GroupBox2.Controls.Add(Me.TxtApellido)
        Me.GroupBox2.Controls.Add(Me.TxtDireccion)
        Me.GroupBox2.Controls.Add(Me.TxtTelefono)
        Me.GroupBox2.Controls.Add(Me.LblTelefono)
        Me.GroupBox2.Controls.Add(Me.LblNif)
        Me.GroupBox2.Controls.Add(Me.Lblapellido)
        Me.GroupBox2.Controls.Add(Me.LblNombre)
        Me.GroupBox2.Controls.Add(Me.LblDireccion)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 103)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Cliente"
        '
        'TxtPrecioTot
        '
        Me.TxtPrecioTot.Enabled = False
        Me.TxtPrecioTot.Location = New System.Drawing.Point(348, 222)
        Me.TxtPrecioTot.MaxLength = 10
        Me.TxtPrecioTot.Name = "TxtPrecioTot"
        Me.TxtPrecioTot.Size = New System.Drawing.Size(76, 20)
        Me.TxtPrecioTot.TabIndex = 79
        Me.TxtPrecioTot.Tag = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Precio:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(522, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TxtCantidad.Location = New System.Drawing.Point(295, 179)
        Me.TxtCantidad.MaxLength = 10
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(140, 20)
        Me.TxtCantidad.TabIndex = 82
        Me.TxtCantidad.Tag = "3"
        '
        'TxtProdSelec
        '
        Me.TxtProdSelec.Location = New System.Drawing.Point(183, 282)
        Me.TxtProdSelec.Multiline = True
        Me.TxtProdSelec.Name = "TxtProdSelec"
        Me.TxtProdSelec.ReadOnly = True
        Me.TxtProdSelec.Size = New System.Drawing.Size(241, 91)
        Me.TxtProdSelec.TabIndex = 83
        '
        'FormRealPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 444)
        Me.Controls.Add(Me.TxtProdSelec)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtPrecioTot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DdtpFecha)
        Me.Controls.Add(Me.TextBoxEstado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.CmbProductos)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.ButnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Productos)
        Me.Name = "FormRealPedido"
        Me.Text = "FormRealPedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Productos As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents ButnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtNif As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents LblNif As System.Windows.Forms.Label
    Friend WithEvents Lblapellido As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents CmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents DdtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPrecioTot As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TxtProdSelec As System.Windows.Forms.TextBox
End Class
