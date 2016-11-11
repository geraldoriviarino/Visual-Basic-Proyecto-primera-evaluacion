Public Class Producto
    'Nombre del producto
    Private nombre As String

    'Precio del producto
    Private precio As Single

    'Función equals que compara el nombre de un producto con el que llama al método
    'con el fin de saber si son iguales por medio del nombre.
    'Devuelve true si los nombres coinciden, o false de lo contrario.
    Function coincideNombre(ByVal producto As Producto) As Boolean
        If producto.nombre = nombre Then
            Return True
        Else
            Return False
        End If
    End Function

    'Aún por planificar. Método encargado de llamar al método modificarPrecio de la clase AccesoDatos
    'que accederá al fichero para actualizarlo. 

    Sub modificarPrecio()
        Dim acceso As New AccesoDatos
        acceso.modificarPrecio(Me)    'Me es el equivalente al this de Java

    End Sub
End Class
