Imports CapaDatos
Imports CapaEntidad

Public Class CNTipoRepuestos
    Dim Tipo As CDTipoRepuesto

    Function ListarTipoRepuestos() As ArrayList
        Tipo = New CDTipoRepuesto
        Return Tipo.ListarTiposRepuestos
    End Function
End Class
