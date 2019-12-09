<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIndexAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnMenuStock = New System.Windows.Forms.Button()
        Me.BtnMenuUsuario = New System.Windows.Forms.Button()
        Me.BtnMenuRep = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(751, 45)
        Me.ToolStrip1.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Administración del Inventario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Administración de usuarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Administración de repuestos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(534, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Stock de Repuestos"
        '
        'BtnMenuStock
        '
        Me.BtnMenuStock.BackColor = System.Drawing.Color.White
        Me.BtnMenuStock.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.box
        Me.BtnMenuStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMenuStock.Location = New System.Drawing.Point(517, 163)
        Me.BtnMenuStock.Name = "BtnMenuStock"
        Me.BtnMenuStock.Size = New System.Drawing.Size(187, 150)
        Me.BtnMenuStock.TabIndex = 3
        Me.BtnMenuStock.UseVisualStyleBackColor = False
        '
        'BtnMenuUsuario
        '
        Me.BtnMenuUsuario.BackColor = System.Drawing.Color.White
        Me.BtnMenuUsuario.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.team
        Me.BtnMenuUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMenuUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.BtnMenuUsuario.Location = New System.Drawing.Point(67, 163)
        Me.BtnMenuUsuario.Name = "BtnMenuUsuario"
        Me.BtnMenuUsuario.Size = New System.Drawing.Size(187, 150)
        Me.BtnMenuUsuario.TabIndex = 1
        Me.BtnMenuUsuario.UseVisualStyleBackColor = False
        '
        'BtnMenuRep
        '
        Me.BtnMenuRep.BackColor = System.Drawing.Color.White
        Me.BtnMenuRep.BackgroundImage = Global.CapaPresentacion.My.Resources.Resources.toolbox
        Me.BtnMenuRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMenuRep.Location = New System.Drawing.Point(290, 163)
        Me.BtnMenuRep.Name = "BtnMenuRep"
        Me.BtnMenuRep.Size = New System.Drawing.Size(187, 150)
        Me.BtnMenuRep.TabIndex = 2
        Me.BtnMenuRep.UseVisualStyleBackColor = False
        '
        'FrmIndexAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(751, 475)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnMenuStock)
        Me.Controls.Add(Me.BtnMenuUsuario)
        Me.Controls.Add(Me.BtnMenuRep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmIndexAdmin"
        Me.Text = "Inventario de Repuestos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoutBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TBTSesion As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents BtnMenuUsuario As System.Windows.Forms.Button
    Friend WithEvents BtnMenuRep As System.Windows.Forms.Button
    Friend WithEvents BtnMenuStock As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBtnGestionUs As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBTBtnGesRes As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBTStkRes As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBTBtnInicio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
