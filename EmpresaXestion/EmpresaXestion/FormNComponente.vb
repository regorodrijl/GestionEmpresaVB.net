Public Class FormNComponente
    Private Sub ButnCancelar_Click(sender As Object, e As EventArgs) Handles ButnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtNombre.Text = "" Or TxtCantidad.Text = "" Then
            MsgBox("Faltan datos", MsgBoxStyle.Exclamation, "No se puede guardar")
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class

