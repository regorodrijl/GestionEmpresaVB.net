Public Class FormNProveedor

    Private Sub ButnCancelar_Click(sender As Object, e As EventArgs) Handles ButnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtNombre.Text = "" Or TxtNif.Text = "" Then
            MsgBox("Faltan datos", MsgBoxStyle.Exclamation, "No se puede guardar")
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnAsociar_Click(sender As Object, e As EventArgs) Handles BtnAsociar.Click
        'DlgAbrir.Filter = "*.jpg"
        If DlgAbrir.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim partes As String()
            partes = DlgAbrir.FileName.Split("\")
            Dim npartes As Integer
            npartes = partes.Length
            LblNombreArchivo.Text = partes(npartes - 1)
        End If
    End Sub

End Class