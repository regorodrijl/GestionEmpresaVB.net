
Module Funciones
    Public Function BuscarRegistro(DS As DataSet, AliasTabla As String, Campo As String, valor As Integer) As Integer
        Dim posicion As Integer
        DS.Tables(AliasTabla).DefaultView.Sort = Campo
        posicion = DS.Tables(AliasTabla).DefaultView.Find(valor)
        Return posicion
    End Function
    Public Function BuscarRegistro(DS As DataSet, AliasTabla As String, NombreCampo As String, Valor As String) As Integer
        Dim posicion As Integer
        DS.Tables(AliasTabla).DefaultView.Sort = NombreCampo
        posicion = DS.Tables(AliasTabla).DefaultView.Find(Valor)
        Return posicion
    End Function
    'Clase Producto para guardar los distintos productos que puede tener un pedido
    Public Class Producto
        Public nome As String
        Public idProducto As Integer
        Public cantidad As Integer
        Public importe As Decimal
        Public Sub New(idProducto As Integer, nome As String, cantidad As Integer, importe As Decimal)
            Me.nome = nome
            Me.idProducto = idProducto
            Me.cantidad = cantidad
            Me.importe = importe
        End Sub
    End Class
End Module
