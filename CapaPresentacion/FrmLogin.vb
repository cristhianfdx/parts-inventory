Imports CapaNegocio
Imports CapaEntidad

Public Class FrmLogin

    Dim Usuario As New CNUsuarios
    Dim DatosUsuario As New ArrayList
    Dim EntidadUsuario As New CEUsuario
    Dim App As New CNAplicacion
    Dim Nombre, Apellido, Rol As String
    Dim Id As Integer


    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Login()
    End Sub

    Sub Login()
        Dim Cedula As Integer
        Dim Contraseña As String

        Cedula = TxtUsuario.Text
        Contraseña = TxtContraseña.Text
        EntidadUsuario.Cedula = Integer.Parse(Cedula)
        EntidadUsuario.Contraseña = Contraseña

        Try
            DatosUsuario = Usuario.LoginUsuarios(EntidadUsuario)

            If DatosUsuario.Count <> 0 Then

                Id = DatosUsuario.Item(0)
                Nombre = DatosUsuario.Item(1)
                Apellido = DatosUsuario.Item(2)
                Rol = DatosUsuario.Item(5)

                Environment.SetEnvironmentVariable("IdSesion", Id)
                Environment.SetEnvironmentVariable("NombreSesion", Nombre)
                Environment.SetEnvironmentVariable("ApellidoSesion", Apellido)
                Environment.SetEnvironmentVariable("RolSesion", Rol)


                If Cedula.Equals(DatosUsuario.Item(3)) And Contraseña.Equals(DatosUsuario.Item(4)) Then

                    'Limpiar Campos del formulario
                    TxtUsuario.Text = ""
                    TxtContraseña.Text = ""
                    Me.Hide()
                    MsgBox("¡Hola" & " " & " " & DatosUsuario.Item(1) & " " & DatosUsuario.Item(2) & "!", MsgBoxStyle.OkOnly, "Inicio de sesión exitoso")

                    'Mostrar el formulario correspondiente al Rol de usuario que inicia sesión
                    If Rol = "ADMIN" Then
                        FrmIndexAdmin.Show()
                        Me.Close()
                    Else
                        FrmIndexBasico.Show()
                        Me.Close()
                    End If
                Else
                    MsgBox("El usuario existe pero la contraseña esta errada", MsgBoxStyle.Exclamation, "Alerta")
                    TxtContraseña.Text = ""
                End If
            Else
                MsgBox("Credenciales incorrectas", MsgBoxStyle.Exclamation, "Alerta")
                TxtUsuario.Text = ""
                TxtContraseña.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al hacer Login: " + ex.Message, MsgBoxStyle.Exclamation, "Alerta")
        End Try

    End Sub
    
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Nombre = ""
        Apellido = ""
        Rol = ""
        Id = 0
    End Sub
End Class