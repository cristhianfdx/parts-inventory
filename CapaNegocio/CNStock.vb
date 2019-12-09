Imports CapaDatos
Imports CapaEntidad

Public Class CNStock

    Dim Stock As CDStock

    Function ListarStock(ByVal IdRepuesto As Integer) As ArrayList
        Stock = New CDStock
        Return Stock.ListarStock(IdRepuesto)
    End Function


    Sub IngresarStock(ByVal EntidadStock As CEStock)
        Stock = New CDStock
        Stock.IngresarStock(EntidadStock)
    End Sub


    Sub ActualizarStock(ByVal EntidadStock As CEStock, ByVal Operacion As String)
        Stock = New CDStock
        Stock.ActualizarStock(EntidadStock, Operacion)
    End Sub



End Class
