<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MascotaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearMascotaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarMascotaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarMascotaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMascotaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearPersonaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarPersonaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarPersonaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarPersonaMenu = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 375)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MascotaMenu, Me.PersonaMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(383, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MascotaMenu
        '
        Me.MascotaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearMascotaMenu, Me.ActualizarMascotaMenu, Me.BorrarMascotaMenu, Me.ListarMascotaMenu})
        Me.MascotaMenu.Name = "MascotaMenu"
        Me.MascotaMenu.Size = New System.Drawing.Size(64, 20)
        Me.MascotaMenu.Text = "Mascota"
        '
        'CrearMascotaMenu
        '
        Me.CrearMascotaMenu.Name = "CrearMascotaMenu"
        Me.CrearMascotaMenu.Size = New System.Drawing.Size(126, 22)
        Me.CrearMascotaMenu.Text = "Crear"
        '
        'ActualizarMascotaMenu
        '
        Me.ActualizarMascotaMenu.Name = "ActualizarMascotaMenu"
        Me.ActualizarMascotaMenu.Size = New System.Drawing.Size(180, 22)

        '
        'BorrarMascotaMenu
        '
        Me.BorrarMascotaMenu.Name = "BorrarMascotaMenu"
        Me.BorrarMascotaMenu.Size = New System.Drawing.Size(126, 22)
        Me.BorrarMascotaMenu.Text = "Borrar"
        '
        'ListarMascotaMenu
        '
        Me.ListarMascotaMenu.Name = "ListarMascotaMenu"
        Me.ListarMascotaMenu.Size = New System.Drawing.Size(126, 22)
        Me.ListarMascotaMenu.Text = "Listar"
        '
        'PersonaMenu
        '
        Me.PersonaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearPersonaMenu, Me.ActualizarPersonaMenu, Me.BorrarPersonaMenu, Me.ListarPersonaMenu})
        Me.PersonaMenu.Name = "PersonaMenu"
        Me.PersonaMenu.Size = New System.Drawing.Size(61, 20)
        Me.PersonaMenu.Text = "Persona"
        '
        'CrearPersonaMenu
        '
        Me.CrearPersonaMenu.Name = "CrearPersonaMenu"

        Me.CrearPersonaMenu.Text = "Crear"
        '
        'ActualizarPersonaMenu
        '
        Me.ActualizarPersonaMenu.Name = "ActualizarPersonaMenu"

        Me.ActualizarPersonaMenu.Text = "Actualizar"
        '
        'BorrarPersonaMenu
        '
        Me.BorrarPersonaMenu.Name = "BorrarPersonaMenu"

        Me.BorrarPersonaMenu.Text = "Borrar"
        '
        'ListarPersonaMenu
        '
        Me.ListarPersonaMenu.Name = "ListarPersonaMenu"

        Me.ListarPersonaMenu.Text = "Listar"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 402)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MascotaMenu As ToolStripMenuItem
    Friend WithEvents PersonaMenu As ToolStripMenuItem
    Friend WithEvents CrearMascotaMenu As ToolStripMenuItem
    Friend WithEvents ActualizarMascotaMenu As ToolStripMenuItem
    Friend WithEvents BorrarMascotaMenu As ToolStripMenuItem
    Friend WithEvents CrearPersonaMenu As ToolStripMenuItem
    Friend WithEvents ActualizarPersonaMenu As ToolStripMenuItem
    Friend WithEvents BorrarPersonaMenu As ToolStripMenuItem
    Friend WithEvents ListarMascotaMenu As ToolStripMenuItem
    Friend WithEvents ListarPersonaMenu As ToolStripMenuItem
End Class
