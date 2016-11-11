Public Class Usuario
    'Nombre del usuario
    Private nombre As String

    'Clave de acceso del usuario en cuestión.
    Private contrasenya As String

    'Rol del usuario. Admin o camarero
    'Pendiente pensar el tipo del dato.
    Private rol As Integer


    'Función que llama a la función validarPermiso(Usuario) de la clase AccesoDatos
    'para verificar que el usuario tiene permisos para inicar sesión.
    'Devuelve true si el inicio de sesión ha sido exitoso, de lo contrario, devuelve false.
    Function iniciarSesion() As Boolean
        Dim acceso As New AccesoDatos
        If acceso.validarPermiso(Me) Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
