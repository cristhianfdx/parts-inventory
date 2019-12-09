'Imports System.Data.SqlServerCe
Imports MySql.Data.MySqlClient
Imports CapaEntidad
Imports CapaDatos

Public Class CDRepuestos

    Dim ObjConexion As New CDConexion
    Dim Conexion As MySqlConnection
    Dim Adaptador As MySqlDataAdapter
    Dim _DataSet As New DataSet
    Dim DatosTabla As DataTable

    Function ListarRepuestos() As DataSet
        Conexion = New MySqlConnection
        _DataSet.Tables.Clear()

        Try
            'generar la conexión
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("SELECT REP.ID_REPUESTO, REP.NOMBRE, REP.DESCRIPCION," +
                                             " " + "REP.IMAGEN, M.DESCRIPCION AS MARCA," +
                                             " " + "TIP.DESCRIPCION AS TIPO, REP.MARCA_ID" +
                                             " " + "FROM REPUESTOS REP JOIN MARCAS M ON REP.MARCA_ID=M.ID_MARCA" +
                                             " " + "JOIN TIPO_REPUESTOS TIP ON REP.TIPO_ID=TIP.ID_TIPO", Conexion)

            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Repuestos")

            DatosTabla = _DataSet.Tables("Repuestos")

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al listar Repuestos" & " " & ex.Message)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try

        Return _DataSet


    End Function


    Sub CrearRepuesto(ByVal EntidadRepuesto As CERepuesto)
        Conexion = New MySqlConnection

        Try
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("INSERT INTO REPUESTOS(NOMBRE, DESCRIPCION, IMAGEN, MARCA_ID, USUARIO_ID, TIPO_ID)" + " " +
                                             "VALUES(@nombre, @descripcion, @imagen, @marca, @usuario, @tipo)", Conexion)

            With Adaptador.SelectCommand.Parameters
                .Add("@nombre", MySqlDbType.VarChar).Value = EntidadRepuesto.Nombre
                .Add("@descripcion", MySqlDbType.VarChar).Value = EntidadRepuesto.Descripcion
                .Add("@imagen", MySqlDbType.VarChar).Value = EntidadRepuesto.Imagen
                .Add("@marca", MySqlDbType.Int32).Value = EntidadRepuesto.MarcaId
                .Add("@usuario", MySqlDbType.Int32).Value = EntidadRepuesto.UsuarioId
                .Add("@tipo", MySqlDbType.Int32).Value = EntidadRepuesto.TipoId
            End With

            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Repuesto registrado", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception
            MsgBox("Error al crear repuesto: " & ex.Message)
        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub

    Sub ActualizarRepuesto(ByVal EntidadRepuesto As CERepuesto)
        Conexion = New MySqlConnection
        Try
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("UPDATE REPUESTOS" + " " +
                                             "SET NOMBRE=@nombre, DESCRIPCION=@descripcion, IMAGEN=@imagen, MARCA_ID=@marca, USUARIO_ID=@usuario, TIPO_ID=@tipo" +
                                             " " + "WHERE ID_REPUESTO=@id", Conexion)

            With Adaptador.SelectCommand.Parameters
                .Add("@id", MySqlDbType.Int32).Value = EntidadRepuesto.IdRepuesto
                .Add("@nombre", MySqlDbType.VarChar).Value = EntidadRepuesto.Nombre
                .Add("@descripcion", MySqlDbType.VarChar).Value = EntidadRepuesto.Descripcion
                .Add("@imagen", MySqlDbType.VarChar).Value = EntidadRepuesto.Imagen
                .Add("@marca", MySqlDbType.Int32).Value = EntidadRepuesto.MarcaId
                .Add("@usuario", MySqlDbType.Int32).Value = EntidadRepuesto.UsuarioId
                .Add("@tipo", MySqlDbType.Int32).Value = EntidadRepuesto.TipoId
            End With

            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Repuesto actualizado", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception
            MsgBox("Error al actualizar el repuesto: " + ex.Message, MsgBoxStyle.Critical, "¡Error!")
        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub

    Sub EliminarUsuario(ByVal EntidadRepuesto As CERepuesto)
        Conexion = New MySqlConnection

        Try
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("DELETE FROM REPUESTOS WHERE ID_REPUESTO=@id", Conexion)
            Adaptador.SelectCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = EntidadRepuesto.IdRepuesto
            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Repuesto eliminado", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception
            MsgBox("Error al eliminar repuesto: " + ex.Message, MsgBoxStyle.Critical, "¡Error!")
        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub


    Function BuscarRepuestos(ByVal Parametro As String) As DataSet

        Conexion = New MySqlConnection
        _DataSet.Tables.Clear()

        Try
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("SELECT REP.ID_REPUESTO, REP.NOMBRE, REP.DESCRIPCION, REP.IMAGEN, M.DESCRIPCION AS MARCA, TIP.DESCRIPCION AS TIPO" +
                                             " " + "FROM REPUESTOS REP JOIN MARCAS M ON MARCA_ID=ID_MARCA" +
                                             " " + "JOIN TIPO_REPUESTOS TIP ON TIPO_ID=ID_TIPO" +
                                             " " + "WHERE REP.NOMBRE LIKE '" + Parametro + "%' OR REP.DESCRIPCION LIKE '" + Parametro + "%'" +
                                             " " + "OR M.DESCRIPCION LIKE '" + Parametro + "%' OR TIP.DESCRIPCION LIKE '" + Parametro + "%'", Conexion)
            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Busqueda")
            DatosTabla = _DataSet.Tables("Busqueda")

        Catch ex As Exception
            MsgBox("El repuesto no existe: " + ex.Message, MsgBoxStyle.Information, "¡No encontrado!")
        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try

        Return _DataSet
    End Function


End Class
