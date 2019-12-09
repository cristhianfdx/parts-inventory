<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepuestos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBTBtnInicio = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBtnGestionUs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBTBtnGesRes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBTSesion2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.TBTStkRes = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewRepuestos = New System.Windows.Forms.DataGridView()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.LabelMarca = New System.Windows.Forms.Label()
        Me.TextBoxImg = New System.Windows.Forms.TextBox()
        Me.ButtonAgregarMarca = New System.Windows.Forms.Button()
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox()
        Me.ButtonCargarImg = New System.Windows.Forms.Button()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnRegRepuesto = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RutaImagen = New System.Windows.Forms.OpenFileDialog()
        Me.BtnDetalle = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridViewRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator4, Me.TBTBtnInicio, Me.ToolStripSeparator1, Me.TBtnGestionUs, Me.ToolStripSeparator2, Me.TBTBtnGesRes, Me.ToolStripSeparator3, Me.LogoutBtn, Me.ToolStripSeparator5, Me.TBTSesion2, Me.TBTStkRes})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(3, 4, 1, 4)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(893, 45)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolBar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(71, 34)
        Me.ToolStripLabel1.Text = "Inventario"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'TBTBtnInicio
        '
        Me.TBTBtnInicio.BackColor = System.Drawing.Color.MidnightBlue
        Me.TBTBtnInicio.ForeColor = System.Drawing.Color.White
        Me.TBTBtnInicio.Image = Global.CapaPresentacion.My.Resources.Resources.home_icon_silhouette
        Me.TBTBtnInicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBTBtnInicio.Margin = New System.Windows.Forms.Padding(3, 1, 2, 2)
        Me.TBTBtnInicio.Name = "TBTBtnInicio"
        Me.TBTBtnInicio.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TBTBtnInicio.Size = New System.Drawing.Size(62, 34)
        Me.TBTBtnInicio.Text = "Inicio"
        Me.TBTBtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'TBtnGestionUs
        '
        Me.TBtnGestionUs.BackColor = System.Drawing.Color.MidnightBlue
        Me.TBtnGestionUs.ForeColor = System.Drawing.Color.White
        Me.TBtnGestionUs.Image = Global.CapaPresentacion.My.Resources.Resources.multiple_users_silhouette
        Me.TBtnGestionUs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBtnGestionUs.Margin = New System.Windows.Forms.Padding(3, 1, 2, 2)
        Me.TBtnGestionUs.Name = "TBtnGestionUs"
        Me.TBtnGestionUs.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TBtnGestionUs.Size = New System.Drawing.Size(136, 34)
        Me.TBtnGestionUs.Text = "Gestión de usuarios"
        Me.TBtnGestionUs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'TBTBtnGesRes
        '
        Me.TBTBtnGesRes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TBTBtnGesRes.Image = Global.CapaPresentacion.My.Resources.Resources.screwdriver_and_wrench_crossed
        Me.TBTBtnGesRes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBTBtnGesRes.Margin = New System.Windows.Forms.Padding(3, 1, 2, 2)
        Me.TBTBtnGesRes.Name = "TBTBtnGesRes"
        Me.TBTBtnGesRes.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TBTBtnGesRes.Size = New System.Drawing.Size(143, 34)
        Me.TBTBtnGesRes.Text = "Gestión de repuestos"
        Me.TBTBtnGesRes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LogoutBtn.AutoSize = False
        Me.LogoutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LogoutBtn.Image = Global.CapaPresentacion.My.Resources.Resources.logout
        Me.LogoutBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LogoutBtn.Margin = New System.Windows.Forms.Padding(3, 1, 6, 2)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LogoutBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LogoutBtn.Size = New System.Drawing.Size(35, 34)
        Me.LogoutBtn.Text = "Cerrar sesión"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 37)
        '
        'TBTSesion2
        '
        Me.TBTSesion2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TBTSesion2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBTSesion2.Image = Global.CapaPresentacion.My.Resources.Resources.user
        Me.TBTSesion2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBTSesion2.Name = "TBTSesion2"
        Me.TBTSesion2.Size = New System.Drawing.Size(36, 34)
        Me.TBTSesion2.Text = "Usuario en sesión"
        '
        'TBTStkRes
        '
        Me.TBTStkRes.ForeColor = System.Drawing.Color.White
        Me.TBTStkRes.Image = Global.CapaPresentacion.My.Resources.Resources.worker_loading_boxes
        Me.TBTStkRes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBTStkRes.Margin = New System.Windows.Forms.Padding(3, 1, 2, 2)
        Me.TBTStkRes.Name = "TBTStkRes"
        Me.TBTStkRes.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TBTStkRes.Size = New System.Drawing.Size(135, 34)
        Me.TBTStkRes.Text = "Stock de Repuestos"
        Me.TBTStkRes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Listado de repuestos"
        '
        'DataGridViewRepuestos
        '
        Me.DataGridViewRepuestos.AllowUserToAddRows = False
        Me.DataGridViewRepuestos.AllowUserToDeleteRows = False
        Me.DataGridViewRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewRepuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewRepuestos.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DataGridViewRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewRepuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRepuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewRepuestos.ColumnHeadersHeight = 30
        Me.DataGridViewRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewRepuestos.EnableHeadersVisualStyles = False
        Me.DataGridViewRepuestos.GridColor = System.Drawing.Color.DimGray
        Me.DataGridViewRepuestos.Location = New System.Drawing.Point(22, 123)
        Me.DataGridViewRepuestos.Name = "DataGridViewRepuestos"
        Me.DataGridViewRepuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRepuestos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewRepuestos.RowHeadersVisible = False
        Me.DataGridViewRepuestos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewRepuestos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewRepuestos.Size = New System.Drawing.Size(406, 251)
        Me.DataGridViewRepuestos.TabIndex = 3
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(125, 389)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(94, 33)
        Me.BtnEliminar.TabIndex = 11
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Location = New System.Drawing.Point(25, 389)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(94, 33)
        Me.BtnEditar.TabIndex = 10
        Me.BtnEditar.Text = "EDITAR"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelTipo)
        Me.GroupBox1.Controls.Add(Me.LabelMarca)
        Me.GroupBox1.Controls.Add(Me.TextBoxImg)
        Me.GroupBox1.Controls.Add(Me.ButtonAgregarMarca)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMarca)
        Me.GroupBox1.Controls.Add(Me.ButtonCargarImg)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTipo)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnRegRepuesto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GroupBox1.Location = New System.Drawing.Point(507, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 305)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Repuestos"
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.Location = New System.Drawing.Point(83, 215)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(15, 15)
        Me.LabelTipo.TabIndex = 15
        Me.LabelTipo.Text = "0"
        Me.LabelTipo.Visible = False
        '
        'LabelMarca
        '
        Me.LabelMarca.AutoSize = True
        Me.LabelMarca.Location = New System.Drawing.Point(83, 171)
        Me.LabelMarca.Name = "LabelMarca"
        Me.LabelMarca.Size = New System.Drawing.Size(15, 15)
        Me.LabelMarca.TabIndex = 14
        Me.LabelMarca.Text = "0"
        Me.LabelMarca.Visible = False
        '
        'TextBoxImg
        '
        Me.TextBoxImg.Location = New System.Drawing.Point(237, 126)
        Me.TextBoxImg.Name = "TextBoxImg"
        Me.TextBoxImg.Size = New System.Drawing.Size(114, 21)
        Me.TextBoxImg.TabIndex = 13
        '
        'ButtonAgregarMarca
        '
        Me.ButtonAgregarMarca.BackColor = System.Drawing.Color.BlueViolet
        Me.ButtonAgregarMarca.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ButtonAgregarMarca.Location = New System.Drawing.Point(320, 167)
        Me.ButtonAgregarMarca.Name = "ButtonAgregarMarca"
        Me.ButtonAgregarMarca.Size = New System.Drawing.Size(31, 23)
        Me.ButtonAgregarMarca.TabIndex = 12
        Me.ButtonAgregarMarca.Text = "+"
        Me.ButtonAgregarMarca.UseVisualStyleBackColor = False
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.FormattingEnabled = True
        Me.ComboBoxMarca.Location = New System.Drawing.Point(140, 168)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(174, 23)
        Me.ComboBoxMarca.TabIndex = 11
        '
        'ButtonCargarImg
        '
        Me.ButtonCargarImg.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonCargarImg.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ButtonCargarImg.Location = New System.Drawing.Point(140, 126)
        Me.ButtonCargarImg.Name = "ButtonCargarImg"
        Me.ButtonCargarImg.Size = New System.Drawing.Size(91, 23)
        Me.ButtonCargarImg.TabIndex = 10
        Me.ButtonCargarImg.Text = "CARGAR"
        Me.ButtonCargarImg.UseVisualStyleBackColor = False
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Location = New System.Drawing.Point(140, 212)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(211, 23)
        Me.ComboBoxTipo.TabIndex = 9
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(220, 253)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(131, 39)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnRegRepuesto
        '
        Me.BtnRegRepuesto.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnRegRepuesto.ForeColor = System.Drawing.Color.White
        Me.BtnRegRepuesto.Location = New System.Drawing.Point(18, 253)
        Me.BtnRegRepuesto.Name = "BtnRegRepuesto"
        Me.BtnRegRepuesto.Size = New System.Drawing.Size(131, 39)
        Me.BtnRegRepuesto.TabIndex = 6
        Me.BtnRegRepuesto.Text = "REGISTRAR"
        Me.BtnRegRepuesto.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tipo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Marca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Imagen:"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(140, 86)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(211, 21)
        Me.TextBoxDescripcion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(140, 46)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(211, 21)
        Me.TextBoxNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'RutaImagen
        '
        Me.RutaImagen.FileName = "RutaImagen"
        '
        'BtnDetalle
        '
        Me.BtnDetalle.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnDetalle.ForeColor = System.Drawing.Color.White
        Me.BtnDetalle.Location = New System.Drawing.Point(225, 389)
        Me.BtnDetalle.Name = "BtnDetalle"
        Me.BtnDetalle.Size = New System.Drawing.Size(94, 33)
        Me.BtnDetalle.TabIndex = 13
        Me.BtnDetalle.Text = "DETALLE"
        Me.BtnDetalle.UseVisualStyleBackColor = False
        '
        'FrmRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(893, 462)
        Me.Controls.Add(Me.BtnDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewRepuestos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmRepuestos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridViewRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBTBtnInicio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBtnGestionUs As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBTBtnGesRes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoutBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBTSesion2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents TBTStkRes As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewRepuestos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnRegRepuesto As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonCargarImg As System.Windows.Forms.Button
    Friend WithEvents ComboBoxMarca As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAgregarMarca As System.Windows.Forms.Button
    Friend WithEvents RutaImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBoxImg As System.Windows.Forms.TextBox
    Friend WithEvents BtnDetalle As System.Windows.Forms.Button
    Friend WithEvents LabelTipo As System.Windows.Forms.Label
    Friend WithEvents LabelMarca As System.Windows.Forms.Label
End Class
