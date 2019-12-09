Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports MySql.Data.MySqlClient
Imports CapaDatos
Imports CapaEntidad

Public Class CDUsuario

    Dim ObjConexion As New CDConexion
    Dim Conexion As MySqlConnection
    Dim Adaptador As MySqlDataAdapter
    Dim _DataSet As New DataSet
    Dim DatosTabla As DataTable


    Function ListarUsuarios() As DataSet

        Conexion = New MySqlConnection
        _DataSet.Tables.Clear()
        DatosTabla = New DataTable

        Try
            'generar la conexión
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("SELECT US.ID_USUARIO AS ID, US.NOMBRE, US.APELLIDO," + " " +
                                             "US.CEDULA, US.CONTRASENA, ROL.DESCRIPCION AS ROL" + " " +
                                              "FROM USUARIOS US JOIN ROLES ROL" + " " +
                                              "ON US.ROL_ID = ROL.ID_ROL", Conexion)

            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Usuarios")

            DatosTabla = _DataSet.Tables("Usuarios")

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al listar usuarios" & " " & ex.Message)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try

        Return _DataSet

    End Function


    Sub RegistroUsuario(ByVal EntidadUsuario As CEUsuario)

        Conexion = New MySqlConnection

        Try
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("INSERT INTO USUARIOS(NOMBRE, APELLIDO, CEDULA, CONTRASENA)" + " " +
                                             "VALUES(@nombre, @apellido, @cedula, @contraseña)", Conexion)

            With Adaptador.SelectCommand.Parameters
                .Add("@nombre", MySqlDbType.VarChar).Value = EntidadUsuario.Nombre
                .Add("@apellido", MySqlDbType.VarChar).Value = EntidadUsuario.Apellido
                .Add("@cedula", MySqlDbType.Int32).Value = EntidadUsuario.Cedula
                .Add("@contraseña", MySqlDbType.VarChar).Value = CodificarContraseña(1, EntidadUsuario.Contraseña)
            End With

            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Usuario registrado", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception
            If ex.Message.Contains("Duplicate entry") Then
                MsgBox("El número de cédula ya se encuentra registrado", MsgBoxStyle.Critical, "¡Error!")
            Else
                MsgBox("Error al crear usuario: " & ex.Message)
            End If

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub

    Sub ActualizarUsuario(ByVal EntidadUsuario As CEUsuario)
        Conexion = New MySqlConnection
        Try
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("UPDATE USUARIOS" + " " +
                                             "SET NOMBRE=@nombre, APELLIDO=@apellido, CEDULA=@cedula, CONTRASENA=@contraseña" +
                                             " " + "WHERE ID_USUARIO=@id", Conexion)

            With Adaptador.SelectCommand.Parameters
                .Add("@id", MySqlDbType.Int32).Value = EntidadUsuario.IdUsuario
                .Add("@nombre", MySqlDbType.VarChar).Value = EntidadUsuario.Nombre
                .Add("@apellido", MySqlDbType.VarChar).Value = EntidadUsuario.Apellido
                .Add("@cedula", MySqlDbType.Int32).Value = EntidadUsuario.Cedula
                .Add("@contraseña", MySqlDbType.VarChar).Value = CodificarContraseña(1, EntidadUsuario.Contraseña)
            End With

            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Usuario actualizado", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception
            MsgBox("Error al actualizar el usuario: " + ex.Message, MsgBoxStyle.Critical, "¡Error!")
        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub

    Sub EliminarUsuario(ByVal EntidadUsuario As CEUsuario)
        Conexion = New MySqlConnection

        Try
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("DELETE FROM USUARIOS WHERE ID_USUARIO=@id", Conexion)
            Adaptador.SelectCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = EntidadUsuario.IdUsuario
            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Usuario eliminado", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception
            MsgBox("Error al eliminar usuario: " + ex.Message, MsgBoxStyle.Critical, "¡Error!")
        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub


    Function LoginUsuarios(ByVal EntidadUsuario As CEUsuario) As ArrayList

        Conexion = New MySqlConnection
        _DataSet.Tables.Clear()
        DatosTabla = New DataTable
        Dim DatosUsuario As New ArrayList

        Try

            'generar la conexión
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            'configurar adaptador con la sentencia SQL a ejecutar            
            Adaptador = New MySqlDataAdapter("SELECT US.ID_USUARIO, US.NOMBRE, US.APELLIDO," + " " +
                                             "US.CEDULA, US.CONTRASENA, ROL.DESCRIPCION" + " " +
                                              "FROM USUARIOS US JOIN ROLES ROL" + " " +
                                              "ON US.ROL_ID = ROL.ID_ROL" + " " +
                                              "WHERE CEDULA=@cedula AND CONTRASENA=@contraseña", Conexion)

            With Adaptador.SelectCommand.Parameters
                .Add("@cedula", MySqlDbType.Int32).Value = EntidadUsuario.Cedula
                .Add("@contraseña", MySqlDbType.VarChar).Value = CodificarContraseña(1, EntidadUsuario.Contraseña)
            End With

            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Usuario")

            DatosTabla = _DataSet.Tables("Usuario")

            For Each item As DataRow In DatosTabla.Rows
                DatosUsuario.Add(item("ID_USUARIO"))
                DatosUsuario.Add(item("NOMBRE"))
                DatosUsuario.Add(item("APELLIDO"))
                DatosUsuario.Add(item("CEDULA"))
                DatosUsuario.Add(CodificarContraseña(2, item("CONTRASENA")))
                DatosUsuario.Add(item("DESCRIPCION"))
            Next


        Catch ex As Exception
            MsgBox("Error al hacer login: " & ex.Message)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try

        Return DatosUsuario

    End Function

    'Encriptar y Desencripttar Contraseñas 
    Function CodificarContraseña(ByVal Opcion As Byte, ByVal Contraseña As String) As String
        Dim TextoPlano() As Byte
        Dim Keys() As Byte = Encoding.ASCII.GetBytes("eeaataxz")
        Dim MemData As New MemoryStream
        Dim Transforma As ICryptoTransform

        Dim Des As New DESCryptoServiceProvider
        Des.Mode = CipherMode.CBC

        If Opcion = 1 Then
            TextoPlano = Encoding.ASCII.GetBytes(Contraseña)
        Else
            TextoPlano = Convert.FromBase64String(Contraseña)
        End If

        If Opcion = 1 Then
            Transforma = Des.CreateEncryptor(Keys, Encoding.ASCII.GetBytes("eeaataxz"))
        Else
            Transforma = Des.CreateDecryptor(Keys, Encoding.ASCII.GetBytes("eeaataxz"))
        End If

        Dim EncStream As New CryptoStream(MemData, Transforma, CryptoStreamMode.Write)
        EncStream.Write(TextoPlano, 0, TextoPlano.Length)
        EncStream.FlushFinalBlock()
        EncStream.Close()

        If Opcion = 1 Then
            Contraseña = Convert.ToBase64String(MemData.ToArray)
        Else
            Contraseña = Encoding.ASCII.GetString(MemData.ToArray)
        End If

        Return Contraseña

    End Function


End Class
