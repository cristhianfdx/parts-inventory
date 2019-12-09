Imports CapaNegocio

Public Class FrmIndexAdmin

    Dim UsuarioEventos As New CNUsuarios
    Dim App As New CNAplicacion

    'Gestión Usuarios

    Private Sub BtnMenuUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuUsuario.Click
        App.CargarVistaRequerida(Me, FrmUsuarios)
    End Sub

    Private Sub TBtnGestionUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnGestionUs.Click
        App.CargarVistaRequerida(Me, FrmUsuarios)
    End Sub

    'Gestión Repuestos

    Private Sub BtnMenuRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuRep.Click
        App.CargarVistaRequerida(Me, FrmRepuestos)
    End Sub

    'Gestión Stock

    Private Sub BtnMenuStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuStock.Click
        App.CargarVistaRequerida(Me, FrmStock)
    End Sub

    'Otros eventos

    'Bóton de inicio
    Private Sub TBTBtnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTBtnInicio.Click
        Me.Show()
    End Sub

    'Botón cerrar sesión
    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        App.CerrarSesion(Me, FrmLogin)
    End Sub

    'Carga de datos de usuario en sesión
    Private Sub FrmIndexAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        App.CargarUsuarioEnSesion(TBTSesion)
    End Sub

    Private Sub TBTBtnGesRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTBtnGesRes.Click
        App.CargarVistaRequerida(Me, FrmRepuestos)
    End Sub

    Private Sub TBTStkRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTStkRes.Click
        App.CargarVistaRequerida(Me, FrmStock)
    End Sub
End Class