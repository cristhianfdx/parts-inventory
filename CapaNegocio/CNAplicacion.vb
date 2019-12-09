Imports CapaNegocio
Imports CapaEntidad

Public Class CNAplicacion


    'Peticiones para cargar vistas

    Sub CargarVistaRequerida(ByVal FormularioCerrar, ByVal FormularioCargar)
        FormularioCargar.Show()
        FormularioCerrar.Close()
    End Sub

    Sub CerrarSesion(ByVal FormularioCerrar, ByVal FormularioCargar)
        If MsgBox("¿Desea cerrar sesión?", vbYesNo + vbExclamation, "Advertencia") = vbYes Then
            CargarVistaRequerida(FormularioCerrar, FormularioCargar)
        End If
    End Sub

    Public Sub CargarUsuarioEnSesion(ByVal Elemento)
        Elemento.DropDownItems.Add(String.Format("Nombre : {0} {1}", Environment.GetEnvironmentVariable("NombreSesion"), Environment.GetEnvironmentVariable("ApellidoSesion")))
        Elemento.DropDownItems.Add(String.Format("Tipo usuario: {0}", Environment.GetEnvironmentVariable("RolSesion")))
    End Sub


End Class
