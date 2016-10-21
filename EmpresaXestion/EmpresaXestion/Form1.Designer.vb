<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TsEmpresa = New System.Windows.Forms.ToolStrip()
        Me.TsNuevo = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TsNuevoCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsNuevoPedido = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsNuevoPoducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsNuevoProveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsModificar = New System.Windows.Forms.ToolStripButton()
        Me.TsBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DtgCliente = New System.Windows.Forms.DataGridView()
        Me.Clientes = New System.Windows.Forms.Label()
        Me.BtnPedido = New System.Windows.Forms.Button()
        Me.Pedidos = New System.Windows.Forms.Label()
        Me.DtgPedido = New System.Windows.Forms.DataGridView()
        Me.TsEmpresa.SuspendLayout()
        CType(Me.DtgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TsEmpresa
        '
        Me.TsEmpresa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevo, Me.TsModificar, Me.TsBorrar, Me.ToolStripSeparator1, Me.TsSalir, Me.ToolStripButton1})
        Me.TsEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.TsEmpresa.Name = "TsEmpresa"
        Me.TsEmpresa.Size = New System.Drawing.Size(684, 25)
        Me.TsEmpresa.TabIndex = 20
        Me.TsEmpresa.Text = "ToolStrip1"
        '
        'TsNuevo
        '
        Me.TsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsNuevo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevoCliente, Me.TsNuevoPedido, Me.TsNuevoPoducto, Me.TsNuevoProveedor})
        Me.TsNuevo.Image = CType(resources.GetObject("TsNuevo.Image"), System.Drawing.Image)
        Me.TsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsNuevo.Name = "TsNuevo"
        Me.TsNuevo.Size = New System.Drawing.Size(29, 22)
        Me.TsNuevo.Text = "ToolStripDropDownButton1"
        '
        'TsNuevoCliente
        '
        Me.TsNuevoCliente.Name = "TsNuevoCliente"
        Me.TsNuevoCliente.Size = New System.Drawing.Size(166, 22)
        Me.TsNuevoCliente.Text = "Nuevo Cliente"
        '
        'TsNuevoPedido
        '
        Me.TsNuevoPedido.Name = "TsNuevoPedido"
        Me.TsNuevoPedido.Size = New System.Drawing.Size(166, 22)
        Me.TsNuevoPedido.Text = "Nuevo Pedido"
        '
        'TsNuevoPoducto
        '
        Me.TsNuevoPoducto.Name = "TsNuevoPoducto"
        Me.TsNuevoPoducto.Size = New System.Drawing.Size(166, 22)
        Me.TsNuevoPoducto.Text = "Nuevo Poducto"
        '
        'TsNuevoProveedor
        '
        Me.TsNuevoProveedor.Name = "TsNuevoProveedor"
        Me.TsNuevoProveedor.Size = New System.Drawing.Size(166, 22)
        Me.TsNuevoProveedor.Text = "Nuevo Proveedor"
        '
        'TsModificar
        '
        Me.TsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsModificar.Image = CType(resources.GetObject("TsModificar.Image"), System.Drawing.Image)
        Me.TsModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsModificar.Name = "TsModificar"
        Me.TsModificar.Size = New System.Drawing.Size(23, 22)
        Me.TsModificar.Text = "Modificar Datos del vehículo"
        '
        'TsBorrar
        '
        Me.TsBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsBorrar.Image = CType(resources.GetObject("TsBorrar.Image"), System.Drawing.Image)
        Me.TsBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsBorrar.Name = "TsBorrar"
        Me.TsBorrar.Size = New System.Drawing.Size(23, 22)
        Me.TsBorrar.Text = "Borrar el vehículo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TsSalir
        '
        Me.TsSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsSalir.Image = CType(resources.GetObject("TsSalir.Image"), System.Drawing.Image)
        Me.TsSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsSalir.Name = "TsSalir"
        Me.TsSalir.Size = New System.Drawing.Size(23, 22)
        Me.TsSalir.Text = "Salir de la Aplicación"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Imprimir"
        '
        'DtgCliente
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        Me.DtgCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCliente.Location = New System.Drawing.Point(36, 65)
        Me.DtgCliente.Name = "DtgCliente"
        Me.DtgCliente.ReadOnly = True
        Me.DtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgCliente.Size = New System.Drawing.Size(636, 120)
        Me.DtgCliente.TabIndex = 21
        '
        'Clientes
        '
        Me.Clientes.AutoSize = True
        Me.Clientes.Location = New System.Drawing.Point(33, 37)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Size = New System.Drawing.Size(47, 13)
        Me.Clientes.TabIndex = 22
        Me.Clientes.Text = "Clientes:"
        '
        'BtnPedido
        '
        Me.BtnPedido.Location = New System.Drawing.Point(36, 410)
        Me.BtnPedido.Name = "BtnPedido"
        Me.BtnPedido.Size = New System.Drawing.Size(147, 23)
        Me.BtnPedido.TabIndex = 25
        Me.BtnPedido.Text = "Realizar Pedido"
        Me.BtnPedido.UseVisualStyleBackColor = True
        '
        'Pedidos
        '
        Me.Pedidos.AutoSize = True
        Me.Pedidos.Location = New System.Drawing.Point(33, 208)
        Me.Pedidos.Name = "Pedidos"
        Me.Pedidos.Size = New System.Drawing.Size(48, 13)
        Me.Pedidos.TabIndex = 27
        Me.Pedidos.Text = "Pedidos:"
        '
        'DtgPedido
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        Me.DtgPedido.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPedido.Location = New System.Drawing.Point(36, 239)
        Me.DtgPedido.Name = "DtgPedido"
        Me.DtgPedido.ReadOnly = True
        Me.DtgPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgPedido.Size = New System.Drawing.Size(567, 141)
        Me.DtgPedido.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 445)
        Me.Controls.Add(Me.Pedidos)
        Me.Controls.Add(Me.DtgPedido)
        Me.Controls.Add(Me.BtnPedido)
        Me.Controls.Add(Me.Clientes)
        Me.Controls.Add(Me.DtgCliente)
        Me.Controls.Add(Me.TsEmpresa)
        Me.Name = "Form1"
        Me.Text = "Empresa"
        Me.TsEmpresa.ResumeLayout(False)
        Me.TsEmpresa.PerformLayout()
        CType(Me.DtgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TsEmpresa As System.Windows.Forms.ToolStrip
    Friend WithEvents TsModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsNuevo As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TsNuevoCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsNuevoPedido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsNuevoPoducto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsNuevoProveedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DtgCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Clientes As System.Windows.Forms.Label
    Friend WithEvents BtnPedido As System.Windows.Forms.Button
    Friend WithEvents Pedidos As System.Windows.Forms.Label
    Friend WithEvents DtgPedido As System.Windows.Forms.DataGridView

End Class
