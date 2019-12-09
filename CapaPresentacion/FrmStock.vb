Imports CapaNegocio
Imports CapaEntidad
Imports System.Text.RegularExpressions


Public Class FrmStock

    Dim App As New CNAplicacion
    Dim Repuestos As CNRepuestos
    Dim Stock As CNStock
    Dim EntidadStock As CEStock

    'Buscar repuesto

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim Parametro As String
        Repuestos = New CNRepuestos

        Parametro = TextBoxBuscar.Text
        If Parametro = "" Then
            MsgBox("Debe haber un párametro de búsqueda", MsgBoxStyle.Information, "!Campo obligatorio¡")
        Else
            If Repuestos.BuscarRepuestos(Parametro).Tables("Busqueda").Rows.Count <> 0 Then
                DataGridViewBusquedaRepuestos.DataSource = Repuestos.BuscarRepuestos(Parametro).Tables("Busqueda")
            Else
                MsgBox("No se encontraron coincidencias", MsgBoxStyle.Information, "!Hey¡")
                TextBoxBuscar.Text = ""
            End If
        End If

    End Sub

    Private Sub TextBoxBuscar_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxBuscar.KeyUp
        If TextBoxBuscar.Text = "" Then
            DataGridViewBusquedaRepuestos.DataSource = Nothing
            LimpiarCampos()
        End If
    End Sub


    Sub MostrarDatosFormulario(ByVal Dgv As DataGridViewRow)
        Stock = New CNStock
        Dim DatosStock As ArrayList

        LabelIdRepuesto.Text = Dgv.Cells(0).Value.ToString
        LabelNombre.Text = Dgv.Cells(1).Value.ToString
        LabelDescripcion.Text = Dgv.Cells(2).Value.ToString
        PictureBoxImagen.Image = Image.FromFile(Dgv.Cells(3).Value.ToString)
        LabelMarca.Text = Dgv.Cells(4).Value.ToString
        LabelTipo.Text = Dgv.Cells(5).Value.ToString

        DatosStock = Stock.ListarStock(Integer.Parse(LabelIdRepuesto.Text))

        If DatosStock.Count <> 0 Then
            LabelIdStock.Text = DatosStock.Item(0).ToString
            LabelCantidad.Text = DatosStock.Item(1).ToString
            LabelFechaIng.Text = DatosStock.Item(2).ToString
            LabelFechaSal.Text = DatosStock.Item(3).ToString
            LabelUbicacion.Text = DatosStock.Item(4).ToString
        Else
            LabelUbicacion.Text = "NA"
            LabelCantidad.Text = "0"
            LabelFechaIng.Text = "NA"
            LabelFechaSal.Text = "NA"
        End If


        BtnAgregarCantidad.Visible = True
        BtnAgregarUbicacion.Visible = True

    End Sub

    'Seleccionar Datos de la tabla
    Private Sub DataGridViewBusquedaRepuestos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewBusquedaRepuestos.CellClick
        Dim Dgv As DataGridViewRow = DataGridViewBusquedaRepuestos.Rows(e.RowIndex)
        MostrarDatosFormulario(Dgv)
    End Sub

    'Ingresar al Stock
    Private Sub BtnIngStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngStock.Click

        If LabelIdStock.Text = "0" Then

            If TextBoxCantidad.Text = "" Or TextBoxUbicacion.Text = "" Then
                MsgBox("Se deben ingresar valores: (Cantidad y ubicación)", MsgBoxStyle.Information, "Campos Obligatorios")
            Else
                IngresarNuevoAlStock()
            End If

        Else

            If TextBoxCantidad.Text = "" Then
                MsgBox("Se debe ingresar Cantidad", MsgBoxStyle.Information, "Campo Obligatorio")
            Else
                IngresarExistenteAlStock("INGRESO")
            End If

        End If

    End Sub


    Sub IngresarNuevoAlStock()
        Stock = New CNStock
        EntidadStock = New CEStock
        Dim ExpRegCant As Regex

        EntidadStock.Ubicacion = TextBoxUbicacion.Text.ToUpper
        EntidadStock.Cantidad = Integer.Parse(TextBoxCantidad.Text)
        EntidadStock.RepuestoId = Integer.Parse(LabelIdRepuesto.Text)

        'Formato Campo Cantidad
        ExpRegCant = New Regex("\d+")
        Dim MatchCant As Match = ExpRegCant.Match(TextBoxCantidad.Text)

        TextBoxUbicacion.Text.ToUpper()

        If MatchCant.Success Then
            If TextBoxUbicacion.Text = "NA" Then
                MsgBox(TextBoxUbicacion.Text + " " + "No es una ubicación válida", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Else
                Stock.IngresarStock(EntidadStock)
                LimpiarCampos()
            End If
           
        Else
            MsgBox("El formato del campo cantidad no es válido, debe ser númerico", MsgBoxStyle.Exclamation, "¡Advertencia!")
            TextBoxCantidad.Text = ""
            TextBoxCantidad.Focus()
        End If

    End Sub


    Sub IngresarExistenteAlStock(ByVal Operacion As String)
        Stock = New CNStock
        EntidadStock = New CEStock
        Dim ExpRegCant As Regex

        EntidadStock.IdStock = Integer.Parse(LabelIdStock.Text)

        If TextBoxUbicacion.Text = "" Then
            EntidadStock.Ubicacion = LabelUbicacion.Text
        Else
            EntidadStock.Ubicacion = TextBoxUbicacion.Text.ToUpper
        End If

        TextBoxUbicacion.Text.ToUpper()

        'Formato Campo Cantidad
        ExpRegCant = New Regex("\d+")
        Dim MatchCant As Match = ExpRegCant.Match(TextBoxCantidad.Text)

        If MatchCant.Success Then

            If TextBoxUbicacion.Text = "NA" Then
                MsgBox(TextBoxUbicacion.Text + " " + "No es una ubicación válida", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Else

                If Operacion = "INGRESO" Then
                    EntidadStock.Cantidad = Integer.Parse(TextBoxCantidad.Text) + Integer.Parse(LabelCantidad.Text)
                    Stock.ActualizarStock(EntidadStock, Operacion)
                ElseIf Operacion = "SALIDA" Then
                    If LabelCantidad.Text = "0" Then
                        MsgBox("No se pueden retirar más repuestos", MsgBoxStyle.Information, "Alerta")
                    Else
                        EntidadStock.Cantidad = (Integer.Parse(TextBoxCantidad.Text) - Integer.Parse(LabelCantidad.Text)) * -1
                        Stock.ActualizarStock(EntidadStock, Operacion)
                    End If

                End If

                LimpiarCampos()
            End If

        Else
            MsgBox("El formato del campo cantidad no es válido, debe ser númerico", MsgBoxStyle.Exclamation, "¡Advertencia!")
            TextBoxCantidad.Text = ""
            TextBoxCantidad.Focus()
        End If

    End Sub

    'Salida del Stock
    Private Sub BtnSalida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalida.Click
        If TextBoxCantidad.Text = "" And LabelIdStock.Text = "0" Then
            MsgBox("Se debe ingresar Cantidad", MsgBoxStyle.Information, "Campo Obligatorio")
        Else
            IngresarExistenteAlStock("SALIDA")
        End If
    End Sub


    'Agregar Ubicación    
    Private Sub BtnAgregarUbicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarUbicacion.Click
        TextBoxUbicacion.Visible = True
        TextBoxUbicacion.Text = LabelUbicacion.Text.ToUpper
        TextBoxUbicacion.Focus()
    End Sub

    'Agregar Cantidad
    Private Sub BtnAgregarCantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarCantidad.Click
        TextBoxCantidad.Visible = True
        TextBoxCantidad.Focus()
    End Sub

    'Otros eventos

    'Bóton de inicio
    Private Sub TBTBtnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTBtnInicio.Click
        App.CargarVistaRequerida(Me, FrmIndexAdmin)
    End Sub

    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        App.CerrarSesion(Me, FrmLogin)
    End Sub

    'Carga de datos de usuario en sesión
    Private Sub FrmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        App.CargarUsuarioEnSesion(TBTSesion)
        TextBoxCantidad.Visible = False
        TextBoxUbicacion.Visible = False
        BtnAgregarCantidad.Visible = False
        BtnAgregarUbicacion.Visible = False
    End Sub

    Private Sub TBtnGestionUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnGestionUs.Click
        App.CargarVistaRequerida(Me, FrmUsuarios)
    End Sub

    Private Sub TBTBtnGesRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTBtnGesRes.Click
        App.CargarVistaRequerida(Me, FrmRepuestos)
    End Sub

    Private Sub TBTStkRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTStkRes.Click
        Me.Show()
    End Sub

    'Limpiar Campos formulario
    Sub LimpiarCampos()
        LabelNombre.Text = "NA"
        LabelDescripcion.Text = "NA"
        LabelMarca.Text = "NA"
        LabelTipo.Text = "NA"
        LabelUbicacion.Text = "NA"
        LabelCantidad.Text = "0"
        LabelFechaIng.Text = "NA"
        LabelFechaSal.Text = "NA"
        PictureBoxImagen.Image = Nothing
        TextBoxUbicacion.Text = ""
        TextBoxCantidad.Text = ""
        TextBoxCantidad.Visible = False
        TextBoxUbicacion.Visible = False
        LabelIdRepuesto.Text = "0"
        LabelIdStock.Text = "0"
    End Sub

End Class