Imports CapaDatos
Imports CapaEntidad


Public Class CNMarcas

    Dim Marca As CDMarca

    Function ListarMarcas() As ArrayList
        Marca = New CDMarca
        Return Marca.ListarMarcas
    End Function


    Sub RegistrarMarca(ByVal EntidadMarca As CEMarca)
        Marca = New CDMarca
        Marca.CrearMarca(EntidadMarca)
    End Sub

    Function ListarMarcaId(ByVal EntidadMarca As CEMarca) As ArrayList
        Marca = New CDMarca
        Return Marca.ListarMarcasConId(EntidadMarca)
    End Function

End Class
