<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNProducto
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
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.ButnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNif = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(171, 105)
        Me.TxtCantidad.MaxLength = 50
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(132, 20)
        Me.TxtCantidad.TabIndex = 53
        Me.TxtCantidad.Tag = "2"
        '
        'ButnCancelar
        '
        Me.ButnCancelar.Location = New System.Drawing.Point(228, 204)
        Me.ButnCancelar.Name = "ButnCancelar"
        Me.ButnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButnCancelar.TabIndex = 58
        Me.ButnCancelar.Text = "Cancelar"
        Me.ButnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(47, 204)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 57
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(171, 149)
        Me.TxtPrecio.MaxLength = 10
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(132, 20)
        Me.TxtPrecio.TabIndex = 54
        Me.TxtPrecio.Tag = "3"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(171, 57)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(132, 20)
        Me.TxtNombre.TabIndex = 52
        Me.TxtNombre.Tag = "1"
        '
        'LblNif
        '
        Me.LblNif.AutoSize = True
        Me.LblNif.Location = New System.Drawing.Point(44, 149)
        Me.LblNif.Name = "LblNif"
        Me.LblNif.Size = New System.Drawing.Size(40, 13)
        Me.LblNif.TabIndex = 62
        Me.LblNif.Text = "Precio:"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(44, 108)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.LblCantidad.TabIndex = 61
        Me.LblCantidad.Text = "Cantidad:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(44, 60)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 60
        Me.LblNombre.Text = "Nombre:"
        '
        'FormNProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 250)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.ButnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNif)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "FormNProducto"
        Me.Text = "FormNProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents ButnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNif As System.Windows.Forms.Label
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
End Class
