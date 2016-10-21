<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNComponente
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
        Me.TxtFabricante = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNif = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(142, 95)
        Me.TxtCantidad.MaxLength = 50
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(132, 20)
        Me.TxtCantidad.TabIndex = 64
        Me.TxtCantidad.Tag = "2"
        '
        'ButnCancelar
        '
        Me.ButnCancelar.Location = New System.Drawing.Point(199, 194)
        Me.ButnCancelar.Name = "ButnCancelar"
        Me.ButnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButnCancelar.TabIndex = 67
        Me.ButnCancelar.Text = "Cancelar"
        Me.ButnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(18, 194)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 66
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtFabricante
        '
        Me.TxtFabricante.Location = New System.Drawing.Point(142, 139)
        Me.TxtFabricante.MaxLength = 10
        Me.TxtFabricante.Name = "TxtFabricante"
        Me.TxtFabricante.Size = New System.Drawing.Size(132, 20)
        Me.TxtFabricante.TabIndex = 65
        Me.TxtFabricante.Tag = "3"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(142, 47)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(132, 20)
        Me.TxtNombre.TabIndex = 63
        Me.TxtNombre.Tag = "1"
        '
        'LblNif
        '
        Me.LblNif.AutoSize = True
        Me.LblNif.Location = New System.Drawing.Point(15, 139)
        Me.LblNif.Name = "LblNif"
        Me.LblNif.Size = New System.Drawing.Size(60, 13)
        Me.LblNif.TabIndex = 70
        Me.LblNif.Text = "Fabricante:"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(15, 98)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.LblCantidad.TabIndex = 69
        Me.LblCantidad.Text = "Cantidad:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(15, 50)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 68
        Me.LblNombre.Text = "Nombre:"
        '
        'FormNComponente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 264)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.ButnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtFabricante)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNif)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "FormNComponente"
        Me.Text = "FormNComponente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents ButnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtFabricante As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNif As System.Windows.Forms.Label
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
End Class
