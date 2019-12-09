Imports CapaDatos
Imports CapaEntidad


Public Class CNRepuestos

    Dim Repuesto As CDRepuestos

    Function ListarRepuestos() As DataSet
        Repuesto = New CDRepuestos
        Return Repuesto.ListarRepuestos
    End Function


    Sub CrearRepuesto(ByVal EntidadRepuesto As CERepuesto)
        Repuesto = New CDRepuestos
        Repuesto.CrearRepuesto(EntidadRepuesto)
    End Sub

    Sub ActualizarRepuesto(ByVal EntidadRepuesto As CERepuesto)
        Repuesto = New CDRepuestos
        Repuesto.ActualizarRepuesto(EntidadRepuesto)
    End Sub

    Sub EliminarRepuesto(ByVal EntidadRepuesto As CERepuesto)
        Repuesto = New CDRepuestos
        Repuesto.EliminarUsuario(EntidadRepuesto)
    End Sub

    Function BuscarRepuestos(ByVal Parametro As String) As DataSet
        Repuesto = New CDRepuestos
        Return Repuesto.BuscarRepuestos(Parametro)
    End Function


End Class
