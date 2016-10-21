Public Class FormNProducto

    Private Sub ButnCancelar_Click(sender As Object, e As EventArgs) Handles ButnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtCantidad.Text = "" Or TxtNombre.Text = "" Or TxtPrecio.Text = "" Then
            MsgBox("Faltan datos", MsgBoxStyle.Exclamation, "No se puede guardar")
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub TxtCarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        Dim validos As String = "1234567890" + Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress
        Dim validos As String = "1234567890.," + Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = "." Then
            e.KeyChar = CChar(",")
        End If

    End Sub
End Class