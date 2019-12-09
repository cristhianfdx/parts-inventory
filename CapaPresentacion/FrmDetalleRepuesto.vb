Imports System.Drawing

Public Class FrmDetalleRepuesto

    Friend Datos(6) As Object

    Private Sub FrmDetalleRepuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelNombre.Text = Datos(1)
        LabelDescripcion.Text = Datos(2)
        Me.PictureBoxImagen.Image = Image.FromFile(Datos(3))
        LabelMarca.Text = Datos(4)
        LabelTipo.Text = Datos(5)
    End Sub

    
End Class