<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNProveedor
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
        Me.ButnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtNif = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNif = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnAsociar = New System.Windows.Forms.Button()
        Me.DlgAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.LblNombreArchivo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButnCancelar
        '
        Me.ButnCancelar.Location = New System.Drawing.Point(214, 154)
        Me.ButnCancelar.Name = "ButnCancelar"
        Me.ButnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButnCancelar.TabIndex = 67
        Me.ButnCancelar.Text = "Cancelar"
        Me.ButnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(33, 154)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 66
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtNif
        '
        Me.TxtNif.Location = New System.Drawing.Point(83, 99)
        Me.TxtNif.MaxLength = 10
        Me.TxtNif.Name = "TxtNif"
        Me.TxtNif.Size = New System.Drawing.Size(132, 20)
        Me.TxtNif.TabIndex = 65
        Me.TxtNif.Tag = "3"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(83, 73)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(132, 20)
        Me.TxtNombre.TabIndex = 63
        Me.TxtNombre.Tag = "1"
        '
        'LblNif
        '
        Me.LblNif.AutoSize = True
        Me.LblNif.Location = New System.Drawing.Point(30, 99)
        Me.LblNif.Name = "LblNif"
        Me.LblNif.Size = New System.Drawing.Size(27, 13)
        Me.LblNif.TabIndex = 70
        Me.LblNif.Text = "NIF:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(30, 76)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(47, 13)
        Me.LblNombre.TabIndex = 68
        Me.LblNombre.Text = "Nombre:"
        '
        'BtnAsociar
        '
        Me.BtnAsociar.Location = New System.Drawing.Point(103, 29)
        Me.BtnAsociar.Name = "BtnAsociar"
        Me.BtnAsociar.Size = New System.Drawing.Size(112, 23)
        Me.BtnAsociar.TabIndex = 72
        Me.BtnAsociar.Text = "Asociar Foto"
        Me.BtnAsociar.UseVisualStyleBackColor = True
        '
        'DlgAbrir
        '
        Me.DlgAbrir.FileName = "OpenFileDialog1"
        '
        'LblNombreArchivo
        '
        Me.LblNombreArchivo.AutoSize = True
        Me.LblNombreArchivo.Location = New System.Drawing.Point(80, 29)
        Me.LblNombreArchivo.Name = "LblNombreArchivo"
        Me.LblNombreArchivo.Size = New System.Drawing.Size(0, 13)
        Me.LblNombreArchivo.TabIndex = 73
        Me.LblNombreArchivo.Visible = False
        '
        'FormNProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 221)
        Me.Controls.Add(Me.LblNombreArchivo)
        Me.Controls.Add(Me.BtnAsociar)
        Me.Controls.Add(Me.ButnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtNif)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNif)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "FormNProveedor"
        Me.Text = "FormNProveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtNif As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNif As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents BtnAsociar As System.Windows.Forms.Button
    Friend WithEvents DlgAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LblNombreArchivo As System.Windows.Forms.Label
End Class
