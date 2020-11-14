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
        Me.MascotaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearMascotaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMascotaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CIDePersonaToolStripMenuItem = New System.Windows.Forms.ToolStripTextBox()
        Me.PersonaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearPersonaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscaryActualizarPersonaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarPersonaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VistaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NaranjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmarilloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VioletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RojoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AzulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MascotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TamañoDeFuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PequeñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedianoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorFondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NpgsqlCommand1 = New Npgsql.NpgsqlCommand()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 410)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MascotaMenu
        '
        Me.MascotaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearMascotaMenu, Me.ListarMascotaMenu})
        Me.MascotaMenu.Name = "MascotaMenu"
        Me.MascotaMenu.Size = New System.Drawing.Size(64, 20)
        Me.MascotaMenu.Text = "Mascota"
        '
        'CrearMascotaMenu
        '
        Me.CrearMascotaMenu.Name = "CrearMascotaMenu"
        Me.CrearMascotaMenu.Size = New System.Drawing.Size(180, 22)
        Me.CrearMascotaMenu.Text = "Registro"
        '
        'ListarMascotaMenu
        '
        Me.ListarMascotaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CIDePersonaToolStripMenuItem})
        Me.ListarMascotaMenu.Name = "ListarMascotaMenu"
        Me.ListarMascotaMenu.Size = New System.Drawing.Size(180, 22)
        Me.ListarMascotaMenu.Text = "Listar y Borrar"
        '
        'CIDePersonaToolStripMenuItem
        '
        Me.CIDePersonaToolStripMenuItem.Name = "CIDePersonaToolStripMenuItem"
        Me.CIDePersonaToolStripMenuItem.Size = New System.Drawing.Size(180, 23)
        Me.CIDePersonaToolStripMenuItem.Text = "CI de Persona"
        '
        'PersonaMenu
        '
        Me.PersonaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearPersonaMenu, Me.BuscaryActualizarPersonaMenu, Me.ListarPersonaMenu})
        Me.PersonaMenu.Name = "PersonaMenu"
        Me.PersonaMenu.Size = New System.Drawing.Size(61, 20)
        Me.PersonaMenu.Text = "Persona"
        '
        'CrearPersonaMenu
        '
        Me.CrearPersonaMenu.Name = "CrearPersonaMenu"
        Me.CrearPersonaMenu.Size = New System.Drawing.Size(180, 22)
        Me.CrearPersonaMenu.Text = "Registro"
        '
        'BuscaryActualizarPersonaMenu
        '
        Me.BuscaryActualizarPersonaMenu.Name = "BuscaryActualizarPersonaMenu"
        Me.BuscaryActualizarPersonaMenu.Size = New System.Drawing.Size(180, 22)
        Me.BuscaryActualizarPersonaMenu.Text = "Buscar y Actualizar"
        '
        'ListarPersonaMenu
        '
        Me.ListarPersonaMenu.Name = "ListarPersonaMenu"
        Me.ListarPersonaMenu.Size = New System.Drawing.Size(180, 22)
        Me.ListarPersonaMenu.Text = "Listar y Borrar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MascotaMenu, Me.PersonaMenu, Me.VistaMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(383, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VistaMenu
        '
        Me.VistaMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColoresToolStripMenuItem})
        Me.VistaMenu.Name = "VistaMenu"
        Me.VistaMenu.Size = New System.Drawing.Size(44, 20)
        Me.VistaMenu.Text = "Vista"
        '
        'ColoresToolStripMenuItem
        '
        Me.ColoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerdeToolStripMenuItem, Me.NaranjaToolStripMenuItem, Me.AmarilloToolStripMenuItem, Me.VioletaToolStripMenuItem, Me.RojoToolStripMenuItem, Me.AzulToolStripMenuItem, Me.WhiteToolStripMenuItem, Me.DarkToolStripMenuItem})
        Me.ColoresToolStripMenuItem.Name = "ColoresToolStripMenuItem"
        Me.ColoresToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ColoresToolStripMenuItem.Text = "Colores"
        '
        'VerdeToolStripMenuItem
        '
        Me.VerdeToolStripMenuItem.Name = "VerdeToolStripMenuItem"
        Me.VerdeToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.VerdeToolStripMenuItem.Text = "Verde"
        '
        'NaranjaToolStripMenuItem
        '
        Me.NaranjaToolStripMenuItem.Name = "NaranjaToolStripMenuItem"
        Me.NaranjaToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.NaranjaToolStripMenuItem.Text = "Naranja"
        '
        'AmarilloToolStripMenuItem
        '
        Me.AmarilloToolStripMenuItem.Name = "AmarilloToolStripMenuItem"
        Me.AmarilloToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AmarilloToolStripMenuItem.Text = "Amarillo"
        '
        'VioletaToolStripMenuItem
        '
        Me.VioletaToolStripMenuItem.Name = "VioletaToolStripMenuItem"
        Me.VioletaToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.VioletaToolStripMenuItem.Text = "Violeta"
        '
        'RojoToolStripMenuItem
        '
        Me.RojoToolStripMenuItem.Name = "RojoToolStripMenuItem"
        Me.RojoToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RojoToolStripMenuItem.Text = "Rojo"
        '
        'AzulToolStripMenuItem
        '
        Me.AzulToolStripMenuItem.Name = "AzulToolStripMenuItem"
        Me.AzulToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AzulToolStripMenuItem.Text = "Azul"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'DarkToolStripMenuItem
        '
        Me.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem"
        Me.DarkToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DarkToolStripMenuItem.Text = "Dark"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'PersonaToolStripMenuItem
        '
        Me.PersonaToolStripMenuItem.Name = "PersonaToolStripMenuItem"
        Me.PersonaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PersonaToolStripMenuItem.Text = "Sobre Persona"
        '
        'MascotaToolStripMenuItem
        '
        Me.MascotaToolStripMenuItem.Name = "MascotaToolStripMenuItem"
        Me.MascotaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MascotaToolStripMenuItem.Text = "Sobre Mascota"
        '
        'TamañoDeFuenteToolStripMenuItem
        '
        Me.TamañoDeFuenteToolStripMenuItem.Name = "TamañoDeFuenteToolStripMenuItem"
        Me.TamañoDeFuenteToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TamañoDeFuenteToolStripMenuItem.Text = "Tamaño de Fuente"
        '
        'PequeñoToolStripMenuItem
        '
        Me.PequeñoToolStripMenuItem.Name = "PequeñoToolStripMenuItem"
        Me.PequeñoToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.PequeñoToolStripMenuItem.Text = "Pequeño"
        '
        'MedianoToolStripMenuItem
        '
        Me.MedianoToolStripMenuItem.Name = "MedianoToolStripMenuItem"
        Me.MedianoToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.MedianoToolStripMenuItem.Text = "Mediano"
        '
        'GrandeToolStripMenuItem
        '
        Me.GrandeToolStripMenuItem.Name = "GrandeToolStripMenuItem"
        Me.GrandeToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.GrandeToolStripMenuItem.Text = "Grande"
        '
        'ColorFondoToolStripMenuItem
        '
        Me.ColorFondoToolStripMenuItem.Name = "ColorFondoToolStripMenuItem"
        Me.ColorFondoToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ColorFondoToolStripMenuItem.Text = "Color Fondo"
        '
        'NpgsqlCommand1
        '
        Me.NpgsqlCommand1.AllResultTypesAreUnknown = False
        Me.NpgsqlCommand1.Transaction = Nothing
        Me.NpgsqlCommand1.UnknownResultTypeList = Nothing
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(383, 410)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(399, 449)
        Me.MinimumSize = New System.Drawing.Size(399, 449)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MascotaMenu As ToolStripMenuItem
    Friend WithEvents CrearMascotaMenu As ToolStripMenuItem
    Friend WithEvents PersonaMenu As ToolStripMenuItem
    Friend WithEvents CrearPersonaMenu As ToolStripMenuItem
    Friend WithEvents BuscaryActualizarPersonaMenu As ToolStripMenuItem
    Friend WithEvents ListarPersonaMenu As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VistaMenu As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MascotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TamañoDeFuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PequeñoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedianoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrandeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorFondoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerdeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NaranjaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmarilloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VioletaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RojoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AzulToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarMascotaMenu As ToolStripMenuItem
    Friend WithEvents CIDePersonaToolStripMenuItem As ToolStripTextBox
    Friend WithEvents NpgsqlCommand1 As Npgsql.NpgsqlCommand
End Class
