'Imports System.Data.SqlServerCe
Imports MySql.Data.MySqlClient
Imports CapaEntidad
Imports CapaDatos

Public Class CDTipoRepuesto
    Dim ObjConexion As New CDConexion
    Dim Conexion As MySqlConnection
    Dim Adaptador As MySqlDataAdapter
    Dim _DataSet As New DataSet
    Dim DatosTabla As DataTable

    Function ListarTiposRepuestos() As ArrayList
        Conexion = New MySqlConnection
        Dim Tipos As New ArrayList
        _DataSet.Tables.Clear()

        Try
            'generar la conexión
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("SELECT DESCRIPCION FROM TIPO_REPUESTOS", Conexion)

            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Tipos")

            DatosTabla = _DataSet.Tables("Tipos")

            For Each item As DataRow In DatosTabla.Rows
                Tipos.Add(item("DESCRIPCION"))
            Next


        Catch ex As Exception
            MsgBox("Ha ocurrido un error al listar Tipos" & " " & ex.Message)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try

        Return Tipos

    End Function
End Class
