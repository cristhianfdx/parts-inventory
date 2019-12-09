'Imports System.Data.SqlServerCe
Imports MySql.Data.MySqlClient
Imports CapaEntidad
Imports CapaDatos

Public Class CDMarca

    Dim ObjConexion As New CDConexion
    Dim Conexion As MySqlConnection
    Dim Adaptador As MySqlDataAdapter
    Dim _DataSet As New DataSet
    Dim DatosTabla As DataTable

    Function ListarMarcas() As ArrayList
        Conexion = New MySqlConnection
        Dim Marcas As New ArrayList
        _DataSet.Tables.Clear()

        Try
            'generar la conexión
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("SELECT DESCRIPCION FROM MARCAS", Conexion)

            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Marcas")

            DatosTabla = _DataSet.Tables("Marcas")

            For Each item As DataRow In DatosTabla.Rows
                Marcas.Add(item("DESCRIPCION"))
            Next


        Catch ex As Exception
            MsgBox("Ha ocurrido un error al listar Marcas" & " " & ex.Message)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try

        Return Marcas

    End Function

    Function ListarMarcasConId(ByVal EntidadMarca As CEMarca) As ArrayList
        Conexion = New MySqlConnection
        Dim Marcas As New ArrayList
        _DataSet.Tables.Clear()

        Try
            'generar la conexión
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("SELECT ID_MARCA FROM MARCAS WHERE DESCRIPCION=@descripcion", Conexion)
            Adaptador.SelectCommand.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = EntidadMarca.Descripcion
            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Marcas")

            DatosTabla = _DataSet.Tables("Marcas")

            For Each item As DataRow In DatosTabla.Rows
                Marcas.Add(item("ID_MARCA"))
            Next


        Catch ex As Exception
            MsgBox("Ha ocurrido un error al listar Marcas" & " " & ex.Message)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try

        Return Marcas

    End Function

    Sub CrearMarca(ByVal EntidadMarca As CEMarca)
        Conexion = New MySqlConnection

        Try
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("INSERT INTO MARCAS(DESCRIPCION)" + " " +
                                             "VALUES(@descripcion)", Conexion)

            With Adaptador.SelectCommand.Parameters
                .Add("@descripcion", MySqlDbType.VarChar).Value = EntidadMarca.Descripcion
            End With

            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Marca de repuesto registrada", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception

            If ex.Message.Contains("Duplicate entry") Then
                MsgBox("La marca fue creada previamente", MsgBoxStyle.Exclamation, "¡Error!")
            Else
                MsgBox("Error al crear Marca de repuesto: " & ex.Message)
            End If

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub

End Class
