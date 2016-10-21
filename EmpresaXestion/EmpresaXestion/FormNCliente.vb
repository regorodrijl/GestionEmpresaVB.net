Public Class FormNCliente
    Private Sub ButnCancelar_Click(sender As Object, e As EventArgs) Handles ButnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtApellidos.Text = "" Or TxtNombre.Text = "" Or TxtNif.Text = "" Or TxtDireccion.Text = "" Or TxtTelefono.Text = "" Then
            MsgBox("Faltan datos", MsgBoxStyle.Exclamation, "No se puede guardar")
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub ClienteValidar(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNif.Validating
        If BuscarRegistro(Form1.DtsXestion, "cliente", "Nif", TxtNif.Text) <> -1 Then
            MsgBox("Este cliente ya existe", MsgBoxStyle.Information, "Cliente no Valido")
            e.Cancel = True
        End If
    End Sub

    Private Sub TxtCarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        Dim validos As String = "1234567890" + Chr(8)
        If Not validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    ''Funcion para buscar un registro en una tabla
    Public Function BuscarRegistro(DS As DataSet, AliasTabla As String, NombreCampo As String, Valor As String) As Integer
        Dim posicion As Integer
        DS.Tables(AliasTabla).DefaultView.Sort = NombreCampo
        posicion = DS.Tables(AliasTabla).DefaultView.Find(Valor)
        Return posicion
    End Function


End Class