Imports CapaDatos
Imports CapaEntidad

Public Class CNUsuarios

    Dim Usuario As CDUsuario
    Dim App As CNAplicacion

    'Petición y envio de Datos a la Capa Datos    

    'CRUD------
    'Listar Usuarios
    Function ListarUsuarios() As DataSet
        Usuario = New CDUsuario
        Return Usuario.ListarUsuarios
    End Function

    'Crear usuarios
    Sub RegistroUsuario(ByVal EntidadUsuario As CEUsuario)
        Usuario = New CDUsuario
        Usuario.RegistroUsuario(EntidadUsuario)
    End Sub

    'Editar Usuario
    Sub ActualizarUsuario(ByVal EntidadUsuario As CEUsuario)
        Usuario = New CDUsuario
        Usuario.ActualizarUsuario(EntidadUsuario)
    End Sub


    'Eliminar Usuario
    Sub EliminarUsuario(ByVal EntidadUsuario As CEUsuario)
        Usuario = New CDUsuario
        Usuario.EliminarUsuario(EntidadUsuario)
    End Sub

    'Login
    Function LoginUsuarios(ByVal EntidadUsuario As CEUsuario) As ArrayList
        Usuario = New CDUsuario
        Return Usuario.LoginUsuarios(EntidadUsuario)
    End Function
    

    'Encriptacion de Contraseñas
    Function CodificarContraseña(ByVal Opcion As String, ByVal Contraseña As String) As String
        Usuario = New CDUsuario
        Return Usuario.CodificarContraseña(Opcion, Contraseña)
    End Function

    
End Class
