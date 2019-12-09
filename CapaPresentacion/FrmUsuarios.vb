Imports System.Text.RegularExpressions
Imports CapaNegocio
Imports CapaEntidad

Public Class FrmUsuarios

    Dim Usuario As CNUsuarios
    Dim App As New CNAplicacion
    Dim EntidadUsuario As New CEUsuario
    Dim UsuarioSeleccionado(5) As String

    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        App.CargarUsuarioEnSesion(TBTSesion1)
        ListarUsuarios()
    End Sub

    'Listar Usuarios
    Sub ListarUsuarios()
        Usuario = New CNUsuarios
        DataGridViewUsuarios.DataSource = Usuario.ListarUsuarios.Tables("Usuarios")
    End Sub

    'Crear
    Sub EnviarUsuario()
        Usuario = New CNUsuarios
        Dim Nombre, Apellido, Cedula, Contraseña, RepetirContraseña As String
        Dim Valido As Boolean
        Dim ExpRegNom, ExpRegCed, ExpRegContra As Regex

        Valido = False

        Nombre = TextBoxNombre.Text
        Apellido = TextBoxApellido.Text
        Cedula = TextBoxCedula.Text
        Contraseña = TextBoxContraseña.Text
        RepetirContraseña = TextBoxReContraseña.Text

        'Validaciones de campos

        'Formato Campos Nombre y Apellido
        ExpRegNom = New Regex("^[a-zA-Z][a-zA-Z]*")
        Dim MatchNom As Match = ExpRegNom.Match(Nombre)
        Dim MatchApe As Match = ExpRegNom.Match(Apellido)

        'Formato Campo Cédula
        ExpRegCed = New Regex("\d+")
        Dim MatchCed As Match = ExpRegCed.Match(Cedula)

        'Formato Campo Contraseña
        ExpRegContra = New Regex("^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$")
        Dim MatchContra As Match = ExpRegContra.Match(Contraseña)

        If String.IsNullOrEmpty(Nombre) Or String.IsNullOrEmpty(Apellido) Or String.IsNullOrEmpty(Cedula) Or String.IsNullOrEmpty(Contraseña) Or String.IsNullOrEmpty(RepetirContraseña) Then
            MsgBox("Todos los campos son obligatorios", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not MatchNom.Success Then
            MsgBox("El formato del campo nombre no es válido", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not MatchApe.Success Then
            MsgBox("El formato del campo apellido no es válido", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not MatchCed.Success Then
            MsgBox("El formato del campo cédula no es válido, debe ser númerico", MsgBoxStyle.Exclamation, "¡Advertencia!")
            TextBoxCedula.Text = ""
            Valido = False
        ElseIf Not Cedula.Length >= 6 Or Not Cedula.Length <= 12 Then
            MsgBox("El campo cédula, debe tener entre 6 y 12 dígitos", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not MatchContra.Success Then
            MsgBox("La contraseña debe tener entre 8 y 16 caracteres, al menos un número, al menos una minúscula y al menos una mayúscula. " +
            "Puede tener otros símbolos.", MsgBoxStyle.Exclamation, "!Advertencia!")
            TextBoxContraseña.Text = ""
            TextBoxReContraseña.Text = ""
            Valido = False
        ElseIf Not RepetirContraseña.Equals(Contraseña) Then
            MsgBox("El campo repetir contraseña de coincidir con el campo contraseña", MsgBoxStyle.Exclamation, "¡Advertencia!")
            TextBoxReContraseña.Text = ""
            Valido = False
        Else
            Valido = True
        End If

        'Envio de datos

        If Valido Then
            EntidadUsuario.Nombre = Nombre.ToUpper
            EntidadUsuario.Apellido = Apellido.ToUpper
            EntidadUsuario.Cedula = Integer.Parse(Cedula)
            EntidadUsuario.Contraseña = Contraseña

            If BtnRegUsuario.Text.Equals("REGISTRAR") Then
                Usuario.RegistroUsuario(EntidadUsuario)
            Else
                EntidadUsuario.IdUsuario = Integer.Parse(UsuarioSeleccionado(0))
                Usuario.ActualizarUsuario(EntidadUsuario)
                GroupBox1.Text = "Registrar usuario"
                BtnRegUsuario.Text = "REGISTRAR"
                Erase UsuarioSeleccionado
            End If


            TextBoxNombre.Text = ""
            TextBoxApellido.Text = ""
            TextBoxCedula.Text = ""
            TextBoxContraseña.Text = ""
            TextBoxReContraseña.Text = ""
            ListarUsuarios()

        End If

    End Sub

    'Eliminar Usuario
    Sub EliminarUsuario(ByVal Id As Integer)
        Usuario = New CNUsuarios
        EntidadUsuario.IdUsuario = Id
        Usuario.EliminarUsuario(EntidadUsuario)
        ListarUsuarios()
    End Sub

    'Botón de registrar
    Private Sub BtnRegUsuario_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegUsuario.Click
        EnviarUsuario()
    End Sub

    'Botón de editar
    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        Try
            If Not String.IsNullOrEmpty(UsuarioSeleccionado(0)) Then
                GroupBox1.Text = "Editar usuario"
                BtnRegUsuario.Text = "ACTUALIZAR"
                TextBoxNombre.Text = UsuarioSeleccionado(1)
                TextBoxApellido.Text = UsuarioSeleccionado(2)
                TextBoxCedula.Text = UsuarioSeleccionado(3)
                TextBoxContraseña.Text = Usuario.CodificarContraseña(2, UsuarioSeleccionado(4))
                TextBoxReContraseña.Text = TextBoxContraseña.Text
            Else
                MsgBox("Debe seleccionar un usuario primero", MsgBoxStyle.Exclamation, "Alerta")
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar un usuario primero", MsgBoxStyle.Exclamation, "Alerta")
        End Try
    End Sub

    'Botón de eliminar
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Try
            If Not String.IsNullOrEmpty(UsuarioSeleccionado(0)) Then
                If Not UsuarioSeleccionado(5).Equals("ADMIN") Then
                    If MsgBox("¿Desea eliminar el usuario " + UsuarioSeleccionado(1) + "?", vbYesNo + vbExclamation, "Advertencia") = vbYes Then
                        EliminarUsuario(Integer.Parse(UsuarioSeleccionado(0)))
                        Erase UsuarioSeleccionado
                    End If
                Else
                    MsgBox("No se puede eliminar el administrador", MsgBoxStyle.Exclamation, "Alerta")
                End If
            Else
                MsgBox("Debe seleccionar un usuario primero", MsgBoxStyle.Exclamation, "Alerta")
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar un usuario primero", MsgBoxStyle.Exclamation, "Alerta")
        End Try
        
    End Sub

    'Al seleccionar una fila de la tabla
    Private Sub DataGridViewUsuarios_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewUsuarios.CellClick
        Dim dgv As DataGridViewRow = DataGridViewUsuarios.Rows(e.RowIndex)
        Seleccionado(dgv)
    End Sub

    'Guardar Usuario seleccionado
    Sub Seleccionado(ByVal Datos As DataGridViewRow)
        ReDim UsuarioSeleccionado(5)
        For i As Integer = 0 To Datos.Cells.Count - 1
            UsuarioSeleccionado(i) = Datos.Cells(i).Value.ToString
        Next
    End Sub

    'Otros eventos------

    'Botón de inicio
    Private Sub TBTBtnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTBtnInicio.Click
        Usuario = New CNUsuarios
        App.CargarVistaRequerida(Me, FrmIndexAdmin)
    End Sub

    'Botón cerrar sesión
    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        Usuario = New CNUsuarios
        App.CerrarSesion(Me, FrmLogin)
    End Sub

    'Botón cancelar
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        GroupBox1.Text = "Registrar usuario"
        BtnRegUsuario.Text = "REGISTRAR"
        TextBoxNombre.Text = ""
        TextBoxApellido.Text = ""
        TextBoxCedula.Text = ""
        TextBoxContraseña.Text = ""
        TextBoxReContraseña.Text = ""
        Erase UsuarioSeleccionado
    End Sub

    Private Sub TBTBtnGesRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTBtnGesRes.Click
        App.CargarVistaRequerida(Me, FrmRepuestos)
    End Sub

    Private Sub TBTStkRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTStkRes.Click
        App.CargarVistaRequerida(Me, FrmStock)
    End Sub
End Class
