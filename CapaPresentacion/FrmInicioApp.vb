Imports CapaNegocio

Public Class FrmInicioApp

    Dim App As New CNAplicacion

    Private Sub FrmInicioApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 1
        Else
            App.CargarVistaRequerida(Me, FrmLogin)
        End If
    End Sub
End Class