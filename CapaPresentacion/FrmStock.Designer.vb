<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.TBTSesion = New System.Windows.Forms.ToolStripSplitButton()
        Me.TBTStkRes = New System.Windows.Forms.ToolStripButton()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewBusquedaRepuestos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelFechaSal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelFechaIng = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.TextBoxUbicacion = New System.Windows.Forms.TextBox()
        Me.BtnAgregarCantidad = New System.Windows.Forms.Button()
        Me.BtnAgregarUbicacion = New System.Windows.Forms.Button()
        Me.LabelCantidad = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelUbicacion = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.LabelMarca = New System.Windows.Forms.Label()
        Me.PictureBoxImagen = New System.Windows.Forms.PictureBox()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.BtnSalida = New System.Windows.Forms.Button()
        Me.BtnIngStock = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelIdStock = New System.Windows.Forms.Label()
        Me.LabelIdRepuesto = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewBusquedaRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator4, Me.TBTBtnInicio, Me.ToolStripSeparator1, Me.TBtnGestionUs, Me.ToolStripSeparator2, Me.TBTBtnGesRes, Me.ToolStripSeparator3, Me.LogoutBtn, Me.ToolStripSeparator5, Me.TBTSesion, Me.TBTStkRes})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(3, 4, 1, 4)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(918, 45)
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
        'TBTSesion
        '
        Me.TBTSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TBTSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBTSesion.Image = Global.CapaPresentacion.My.Resources.Resources.user
        Me.TBTSesion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBTSesion.Name = "TBTSesion"
        Me.TBTSesion.Size = New System.Drawing.Size(36, 34)
        Me.TBTSesion.Text = "Usuario en sesión"
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
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(132, 51)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(147, 20)
        Me.TextBoxBuscar.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Stock de repuestos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridViewBusquedaRepuestos)
        Me.GroupBox1.Controls.Add(Me.TextBoxBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 273)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda de repuestos"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(300, 51)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "BUSCAR"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Palabra clave:"
        '
        'DataGridViewBusquedaRepuestos
        '
        Me.DataGridViewBusquedaRepuestos.AllowUserToAddRows = False
        Me.DataGridViewBusquedaRepuestos.AllowUserToDeleteRows = False
        Me.DataGridViewBusquedaRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewBusquedaRepuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewBusquedaRepuestos.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.DataGridViewBusquedaRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewBusquedaRepuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBusquedaRepuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewBusquedaRepuestos.ColumnHeadersHeight = 30
        Me.DataGridViewBusquedaRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewBusquedaRepuestos.EnableHeadersVisualStyles = False
        Me.DataGridViewBusquedaRepuestos.GridColor = System.Drawing.Color.DimGray
        Me.DataGridViewBusquedaRepuestos.Location = New System.Drawing.Point(16, 92)
        Me.DataGridViewBusquedaRepuestos.Name = "DataGridViewBusquedaRepuestos"
        Me.DataGridViewBusquedaRepuestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewBusquedaRepuestos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewBusquedaRepuestos.RowHeadersVisible = False
        Me.DataGridViewBusquedaRepuestos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewBusquedaRepuestos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewBusquedaRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBusquedaRepuestos.Size = New System.Drawing.Size(407, 164)
        Me.DataGridViewBusquedaRepuestos.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelIdRepuesto)
        Me.GroupBox2.Controls.Add(Me.LabelIdStock)
        Me.GroupBox2.Controls.Add(Me.LabelFechaSal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LabelFechaIng)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBoxCantidad)
        Me.GroupBox2.Controls.Add(Me.TextBoxUbicacion)
        Me.GroupBox2.Controls.Add(Me.BtnAgregarCantidad)
        Me.GroupBox2.Controls.Add(Me.BtnAgregarUbicacion)
        Me.GroupBox2.Controls.Add(Me.LabelCantidad)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.LabelUbicacion)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LabelTipo)
        Me.GroupBox2.Controls.Add(Me.LabelMarca)
        Me.GroupBox2.Controls.Add(Me.PictureBoxImagen)
        Me.GroupBox2.Controls.Add(Me.LabelDescripcion)
        Me.GroupBox2.Controls.Add(Me.LabelNombre)
        Me.GroupBox2.Controls.Add(Me.BtnSalida)
        Me.GroupBox2.Controls.Add(Me.BtnIngStock)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GroupBox2.Location = New System.Drawing.Point(493, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 394)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stock de repuestos"
        '
        'LabelFechaSal
        '
        Me.LabelFechaSal.AutoSize = True
        Me.LabelFechaSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaSal.Location = New System.Drawing.Point(152, 291)
        Me.LabelFechaSal.Name = "LabelFechaSal"
        Me.LabelFechaSal.Size = New System.Drawing.Size(23, 15)
        Me.LabelFechaSal.TabIndex = 25
        Me.LabelFechaSal.Text = "NA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Fecha Última salida:"
        '
        'LabelFechaIng
        '
        Me.LabelFechaIng.AutoSize = True
        Me.LabelFechaIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaIng.Location = New System.Drawing.Point(152, 258)
        Me.LabelFechaIng.Name = "LabelFechaIng"
        Me.LabelFechaIng.Size = New System.Drawing.Size(23, 15)
        Me.LabelFechaIng.TabIndex = 23
        Me.LabelFechaIng.Text = "NA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Fecha Último Ingreso:"
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(231, 228)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(83, 21)
        Me.TextBoxCantidad.TabIndex = 21
        '
        'TextBoxUbicacion
        '
        Me.TextBoxUbicacion.Location = New System.Drawing.Point(231, 195)
        Me.TextBoxUbicacion.Name = "TextBoxUbicacion"
        Me.TextBoxUbicacion.Size = New System.Drawing.Size(83, 21)
        Me.TextBoxUbicacion.TabIndex = 20
        '
        'BtnAgregarCantidad
        '
        Me.BtnAgregarCantidad.BackColor = System.Drawing.Color.BlueViolet
        Me.BtnAgregarCantidad.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnAgregarCantidad.Location = New System.Drawing.Point(194, 227)
        Me.BtnAgregarCantidad.Name = "BtnAgregarCantidad"
        Me.BtnAgregarCantidad.Size = New System.Drawing.Size(31, 23)
        Me.BtnAgregarCantidad.TabIndex = 19
        Me.BtnAgregarCantidad.Text = "+"
        Me.BtnAgregarCantidad.UseVisualStyleBackColor = False
        '
        'BtnAgregarUbicacion
        '
        Me.BtnAgregarUbicacion.BackColor = System.Drawing.Color.BlueViolet
        Me.BtnAgregarUbicacion.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnAgregarUbicacion.Location = New System.Drawing.Point(194, 194)
        Me.BtnAgregarUbicacion.Name = "BtnAgregarUbicacion"
        Me.BtnAgregarUbicacion.Size = New System.Drawing.Size(31, 23)
        Me.BtnAgregarUbicacion.TabIndex = 18
        Me.BtnAgregarUbicacion.Text = "+"
        Me.BtnAgregarUbicacion.UseVisualStyleBackColor = False
        '
        'LabelCantidad
        '
        Me.LabelCantidad.AutoSize = True
        Me.LabelCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCantidad.Location = New System.Drawing.Point(99, 231)
        Me.LabelCantidad.Name = "LabelCantidad"
        Me.LabelCantidad.Size = New System.Drawing.Size(14, 15)
        Me.LabelCantidad.TabIndex = 17
        Me.LabelCantidad.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Cantidad:"
        '
        'LabelUbicacion
        '
        Me.LabelUbicacion.AutoSize = True
        Me.LabelUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUbicacion.Location = New System.Drawing.Point(99, 198)
        Me.LabelUbicacion.Name = "LabelUbicacion"
        Me.LabelUbicacion.Size = New System.Drawing.Size(23, 15)
        Me.LabelUbicacion.TabIndex = 15
        Me.LabelUbicacion.Text = "NA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Ubicación:"
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipo.Location = New System.Drawing.Point(99, 162)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(23, 15)
        Me.LabelTipo.TabIndex = 13
        Me.LabelTipo.Text = "NA"
        '
        'LabelMarca
        '
        Me.LabelMarca.AutoSize = True
        Me.LabelMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMarca.Location = New System.Drawing.Point(99, 129)
        Me.LabelMarca.Name = "LabelMarca"
        Me.LabelMarca.Size = New System.Drawing.Size(23, 15)
        Me.LabelMarca.TabIndex = 12
        Me.LabelMarca.Text = "NA"
        '
        'PictureBoxImagen
        '
        Me.PictureBoxImagen.Location = New System.Drawing.Point(254, 49)
        Me.PictureBoxImagen.Name = "PictureBoxImagen"
        Me.PictureBoxImagen.Size = New System.Drawing.Size(131, 126)
        Me.PictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImagen.TabIndex = 11
        Me.PictureBoxImagen.TabStop = False
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescripcion.Location = New System.Drawing.Point(99, 89)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(23, 15)
        Me.LabelDescripcion.TabIndex = 10
        Me.LabelDescripcion.Text = "NA"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(98, 49)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(23, 15)
        Me.LabelNombre.TabIndex = 9
        Me.LabelNombre.Text = "NA"
        '
        'BtnSalida
        '
        Me.BtnSalida.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnSalida.ForeColor = System.Drawing.Color.White
        Me.BtnSalida.Location = New System.Drawing.Point(220, 336)
        Me.BtnSalida.Name = "BtnSalida"
        Me.BtnSalida.Size = New System.Drawing.Size(131, 39)
        Me.BtnSalida.TabIndex = 7
        Me.BtnSalida.Text = "SALIDA"
        Me.BtnSalida.UseVisualStyleBackColor = False
        '
        'BtnIngStock
        '
        Me.BtnIngStock.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnIngStock.ForeColor = System.Drawing.Color.White
        Me.BtnIngStock.Location = New System.Drawing.Point(18, 336)
        Me.BtnIngStock.Name = "BtnIngStock"
        Me.BtnIngStock.Size = New System.Drawing.Size(131, 39)
        Me.BtnIngStock.TabIndex = 6
        Me.BtnIngStock.Text = "INGRESAR"
        Me.BtnIngStock.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tipo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Marca:"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nombre:"
        '
        'LabelIdStock
        '
        Me.LabelIdStock.AutoSize = True
        Me.LabelIdStock.Location = New System.Drawing.Point(251, 17)
        Me.LabelIdStock.Name = "LabelIdStock"
        Me.LabelIdStock.Size = New System.Drawing.Size(15, 15)
        Me.LabelIdStock.TabIndex = 26
        Me.LabelIdStock.Text = "0"
        '
        'LabelIdRepuesto
        '
        Me.LabelIdRepuesto.AutoSize = True
        Me.LabelIdRepuesto.Location = New System.Drawing.Point(152, 17)
        Me.LabelIdRepuesto.Name = "LabelIdRepuesto"
        Me.LabelIdRepuesto.Size = New System.Drawing.Size(15, 15)
        Me.LabelIdRepuesto.TabIndex = 27
        Me.LabelIdRepuesto.Text = "0"
        '
        'FrmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(918, 533)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmStock"
        Me.Text = "FrmStock"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewBusquedaRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxImagen, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TBTSesion As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents TBTStkRes As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewBusquedaRepuestos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalida As System.Windows.Forms.Button
    Friend WithEvents BtnIngStock As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents LabelDescripcion As System.Windows.Forms.Label
    Friend WithEvents PictureBoxImagen As System.Windows.Forms.PictureBox
    Friend WithEvents LabelTipo As System.Windows.Forms.Label
    Friend WithEvents LabelMarca As System.Windows.Forms.Label
    Friend WithEvents LabelUbicacion As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelCantidad As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnAgregarCantidad As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarUbicacion As System.Windows.Forms.Button
    Friend WithEvents TextBoxCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents LabelFechaSal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LabelFechaIng As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LabelIdStock As System.Windows.Forms.Label
    Friend WithEvents LabelIdRepuesto As System.Windows.Forms.Label
End Class
