Imports CapaNegocio
Imports CapaEntidad
Imports System.Text.RegularExpressions

Public Class FrmRepuestos

    Dim Repuesto As CNRepuestos
    Dim Marca As CNMarcas
    Dim Tipo As CNTipoRepuestos
    Dim App As New CNAplicacion
    Dim EntidadRepuesto As New CERepuesto
    Dim RepuestoSeleccionado(6) As String

    'Carga de datos de usuario en sesión
    Private Sub FrmRepuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        App.CargarUsuarioEnSesion(TBTSesion2)
        ListarRepuesto()
        CargarMarcas()
        CargarTipos()
    End Sub

    Sub ListarRepuesto()
        Repuesto = New CNRepuestos
        DataGridViewRepuestos.DataSource = Repuesto.ListarRepuestos.Tables("Repuestos")
    End Sub

    'Crear Repuesto
    Sub EnviarRepuesto()
        Dim Nombre, Descripcion, Imagen As String
        Dim Valido As Boolean

        Valido = False

        Nombre = TextBoxNombre.Text
        Descripcion = TextBoxDescripcion.Text
        Imagen = TextBoxImg.Text

        'Validaciones de campos
        Dim ExpRegNombre = New Regex("^[a-zA-Z][a-zA-Z]*")

        'Formato Campos Texto
        Dim MatchCampoNombre As Match = ExpRegNombre.Match(Nombre)

        If String.IsNullOrEmpty(Nombre) Or String.IsNullOrEmpty(Descripcion) Or String.IsNullOrEmpty(Imagen) Or ComboBoxMarca.SelectedIndex = 0 Or ComboBoxTipo.SelectedIndex = 0 Then
            MsgBox("Todos los campos son obligatorios", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        ElseIf Not MatchCampoNombre.Success Then
            MsgBox("El formato del campo nombre no es válido", MsgBoxStyle.Exclamation, "¡Advertencia!")
            Valido = False
        Else
            Valido = True
        End If

        If Valido Then
            EntidadRepuesto.Nombre = Nombre.ToUpper
            EntidadRepuesto.Descripcion = Descripcion.ToUpper
            EntidadRepuesto.Imagen = Imagen
            EntidadRepuesto.MarcaId = Integer.Parse(LabelMarca.Text)
            EntidadRepuesto.TipoId = Integer.Parse(LabelTipo.Text)
            EntidadRepuesto.UsuarioId = Integer.Parse(Environment.GetEnvironmentVariable("IdSesion"))


            If BtnRegRepuesto.Text.Equals("REGISTRAR") Then
                Repuesto.CrearRepuesto(EntidadRepuesto)
            Else
                EntidadRepuesto.IdRepuesto = Integer.Parse(RepuestoSeleccionado(0))
                Repuesto.ActualizarRepuesto(EntidadRepuesto)
                GroupBox1.Text = "Registrar Repuesto"
                BtnRegRepuesto.Text = "REGISTRAR"
                Erase RepuestoSeleccionado
            End If

            TextBoxNombre.Text = ""
            TextBoxDescripcion.Text = ""
            TextBoxImg.Text = ""
            ComboBoxMarca.SelectedIndex = 0
            ComboBoxTipo.SelectedIndex = 0
            LabelMarca.Text = "0"
            LabelTipo.Text = "0"
            ListarRepuesto()

        End If

    End Sub

    Private Sub BtnRegRepuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegRepuesto.Click
        EnviarRepuesto()
    End Sub

    'Editar repuesto
    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        Try
            If Not String.IsNullOrEmpty(RepuestoSeleccionado(0)) Then
                GroupBox1.Text = "Editar Repuesto"
                BtnRegRepuesto.Text = "ACTUALIZAR"
                TextBoxNombre.Text = RepuestoSeleccionado(1)
                TextBoxDescripcion.Text = RepuestoSeleccionado(2)
                TextBoxImg.Text = RepuestoSeleccionado(3)
                ComboBoxMarca.Text = RepuestoSeleccionado(4)
                ComboBoxTipo.Text = RepuestoSeleccionado(5)
                LabelMarca.Text = RepuestoSeleccionado(6)
            Else
                MsgBox("Debe seleccionar un repuesto primero", MsgBoxStyle.Exclamation, "Alerta")
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar un repuesto primero", MsgBoxStyle.Exclamation, "Alerta")
        End Try

    End Sub

    'Eliminar Repuesto
    Sub EliminarUsuario(ByVal Id As Integer)
        Repuesto = New CNRepuestos
        EntidadRepuesto.IdRepuesto = Id
        Repuesto.EliminarRepuesto(EntidadRepuesto)
        ListarRepuesto()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Try
            If Not String.IsNullOrEmpty(RepuestoSeleccionado(0)) Then
                If MsgBox("¿Desea eliminar el usuario " + RepuestoSeleccionado(1) + "?", vbYesNo + vbExclamation, "Advertencia") = vbYes Then
                    EliminarUsuario(Integer.Parse(RepuestoSeleccionado(0)))
                    Erase RepuestoSeleccionado
                End If
            Else
                MsgBox("Debe seleccionar un repuesto primero", MsgBoxStyle.Exclamation, "Alerta")
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar un repuesto primero", MsgBoxStyle.Exclamation, "Alerta")
        End Try

    End Sub

    'Cargar ComboBox Marcas
    Sub CargarMarcas()
        Marca = New CNMarcas

        ComboBoxMarca.Items.Add("Seleccione marca")
        ComboBoxMarca.SelectedIndex = 0

        For i As Integer = 0 To Marca.ListarMarcas.Count - 1
            ComboBoxMarca.Items.Add(Marca.ListarMarcas.Item(i))
        Next

    End Sub

    'Agregar Nueva Marca
    Private Sub ButtonAgregarMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregarMarca.Click
        FrmNuevaMarca.Show()
    End Sub

    'Cargar Imagen
    Private Sub ButtonCargarImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCargarImg.Click
        RutaImagen.Title = "Carga una imagen"
        RutaImagen.ShowDialog()
        TextBoxImg.Text = RutaImagen.FileName
    End Sub

    'Cargar ComboBox Tipo
    Sub CargarTipos()
        Tipo = New CNTipoRepuestos
        ComboBoxTipo.Items.Add("Seleccione tipo")
        ComboBoxTipo.SelectedIndex = 0

        For i As Integer = 0 To Tipo.ListarTipoRepuestos.Count - 1
            ComboBoxTipo.Items.Add(Tipo.ListarTipoRepuestos.Item(i))
        Next
    End Sub

    'Guardar id de los ComboBox
    Private Sub ComboBoxMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMarca.SelectedIndexChanged
        Marca = New CNMarcas
        Dim EntidadMarca As New CEMarca
        Dim Marcas As New ArrayList

        EntidadMarca.Descripcion = ComboBoxMarca.Text
        Marcas = Marca.ListarMarcaId(EntidadMarca)

        If Not ComboBoxMarca.Text.Equals("Seleccione marca") Then
            LabelMarca.Text = Marcas.Item(0).ToString
        End If


    End Sub

    Private Sub ComboBoxTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipo.SelectedIndexChanged
        LabelTipo.Text = ComboBoxTipo.SelectedIndex.ToString
    End Sub

    Private Sub DataGridViewRepuestos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewRepuestos.CellClick
        Dim dgv As DataGridViewRow = DataGridViewRepuestos.Rows(e.RowIndex)
        Seleccionado(dgv)
    End Sub

    'Guardar repuesto seleccionado
    Sub Seleccionado(ByVal Datos As DataGridViewRow)
        ReDim RepuestoSeleccionado(6)
        For i As Integer = 0 To Datos.Cells.Count - 1
            RepuestoSeleccionado(i) = Datos.Cells(i).Value.ToString
        Next

    End Sub


    'Otros eventos

    'Bóton de inicio
    Private Sub TBTBtnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTBtnInicio.Click
        App.CargarVistaRequerida(Me, FrmIndexAdmin)
    End Sub

    'Botón cerrar sesión
    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        App.CerrarSesion(Me, FrmLogin)
    End Sub

    'Cargar Administraciòn de usuarios
    Private Sub TBtnGestionUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnGestionUs.Click
        App.CargarVistaRequerida(Me, FrmUsuarios)
    End Sub

    'Detalle del repuesto
    Private Sub BtnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetalle.Click
        Try
            If Not String.IsNullOrEmpty(RepuestoSeleccionado(0)) Then
                FrmDetalleRepuesto.Datos = RepuestoSeleccionado
                FrmDetalleRepuesto.Show()
            Else
                MsgBox("Debe seleccionar un repuesto primero", MsgBoxStyle.Exclamation, "Alerta")
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar un repuesto primero", MsgBoxStyle.Exclamation, "Alerta")
        End Try
        
    End Sub
    
    
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        GroupBox1.Text = "Registrar Repuesto"
        BtnRegRepuesto.Text = "REGISTRAR"
        TextBoxNombre.Text = ""
        TextBoxDescripcion.Text = ""
        TextBoxImg.Text = ""
        ComboBoxMarca.SelectedIndex = 0
        ComboBoxTipo.SelectedIndex = 0
        LabelMarca.Text = "0"
        LabelTipo.Text = "0"
        Erase RepuestoSeleccionado
    End Sub

    Private Sub TBTStkRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBTStkRes.Click
        App.CargarVistaRequerida(Me, FrmStock)
    End Sub
End Class