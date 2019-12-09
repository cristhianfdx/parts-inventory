Imports MySql.Data.MySqlClient
Imports CapaDatos
Imports CapaEntidad

Public Class CDStock

    Dim ObjConexion As New CDConexion
    Dim Conexion As MySqlConnection
    Dim Adaptador As MySqlDataAdapter
    Dim _DataSet As New DataSet
    Dim DatosTabla As DataTable

    Function ListarStock(ByVal IdRepuesto As Integer) As ArrayList
        Conexion = New MySqlConnection
        _DataSet.Tables.Clear()
        DatosTabla = New DataTable
        Dim DatosStock As New ArrayList

        Try
            'generar la conexión
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            'configurar adaptador con la sentencia SQL a ejecutar            
            Adaptador = New MySqlDataAdapter("SELECT ID_STOCK, CANTIDAD, FECHA_INGRESO," + " " +
                                             "FECHA_SALIDA, UBICACION" + " " +
                                              "FROM STOCK_REPUESTOS WHERE REPUESTO_ID=@Id", Conexion)
            Adaptador.SelectCommand.Parameters.Add("@Id", MySqlDbType.Int32).Value = IdRepuesto

            'LLenar adaptador con los datos que trae la consulta
            Adaptador.Fill(_DataSet, "Stock")

            DatosTabla = _DataSet.Tables("Stock")

            For Each item As DataRow In DatosTabla.Rows
                DatosStock.Add(item("ID_STOCK"))
                DatosStock.Add(item("CANTIDAD"))
                DatosStock.Add(item("FECHA_INGRESO"))
                DatosStock.Add(item("FECHA_SALIDA"))
                DatosStock.Add(item("UBICACION"))
            Next

        Catch ex As Exception
            MsgBox("Error al listar Stock: " & ex.Message)

        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try

        Return DatosStock

    End Function


    Sub IngresarStock(ByVal EntidadStock As CEStock)
        Conexion = New MySqlConnection

        Try
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()
            Adaptador = New MySqlDataAdapter("INSERT INTO STOCK_REPUESTOS(CANTIDAD, FECHA_INGRESO, UBICACION, REPUESTO_ID)" + " " +
                                             "VALUES(@cantidad, NOW(), @ubicacion, @repuesto)", Conexion)

            With Adaptador.SelectCommand.Parameters
                .Add("@cantidad", MySqlDbType.Int32).Value = EntidadStock.Cantidad
                .Add("@ubicacion", MySqlDbType.VarChar).Value = EntidadStock.Ubicacion
                .Add("@repuesto", MySqlDbType.Int32).Value = EntidadStock.RepuestoId
            End With

            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Repuesto ingresado al stock", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception
            MsgBox("Error al ingresar repuesto al stock: " & ex.Message)
        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub


    Sub ActualizarStock(ByVal EntidadStock As CEStock, ByVal Operacion As String)
        Conexion = New MySqlConnection
        Dim Consulta As String
        Consulta = ""
        Try
            Conexion = ObjConexion.ConectarDB
            Conexion.Open()

            If Operacion = "INGRESO" Then
                Consulta = "UPDATE STOCK_REPUESTOS" + " " +
                            "SET CANTIDAD=@cantidad, FECHA_INGRESO=NOW(), UBICACION=@ubicacion" +
                            " " + "WHERE ID_STOCK=@id"
            ElseIf Operacion = "SALIDA" Then
                Consulta = "UPDATE STOCK_REPUESTOS" + " " +
                            "SET CANTIDAD=@cantidad, FECHA_SALIDA=NOW(), UBICACION=@ubicacion" +
                            " " + "WHERE ID_STOCK=@id"
            End If

            Adaptador = New MySqlDataAdapter(Consulta, Conexion)

            With Adaptador.SelectCommand.Parameters
                .Add("@id", MySqlDbType.Int32).Value = EntidadStock.IdStock
                .Add("@cantidad", MySqlDbType.Int32).Value = EntidadStock.Cantidad
                .Add("@ubicacion", MySqlDbType.VarChar).Value = EntidadStock.Ubicacion
            End With

            Adaptador.SelectCommand.ExecuteNonQuery()

            MsgBox("Stock actualizado", MsgBoxStyle.Information, "¡Operación éxitosa!")

        Catch ex As Exception
            MsgBox("Error al actualizar el stock: " + ex.Message, MsgBoxStyle.Critical, "¡Error!")
        Finally
            'Liberar Recursos
            Conexion.Dispose()
            Adaptador.Dispose()
            Conexion.Close()
        End Try
    End Sub



End Class
