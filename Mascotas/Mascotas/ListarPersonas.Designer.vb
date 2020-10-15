<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarPersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListarPersonas))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.LVCi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.Telefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BorrarPersona = New System.Windows.Forms.Button()
        Me.BorrarTelefono = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LVCi, Me.LVNombre, Me.LVDireccion})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(30, 94)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(366, 175)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'LVCi
        '
        Me.LVCi.Text = "CI"
        Me.LVCi.Width = 77
        '
        'LVNombre
        '
        Me.LVNombre.Text = "Nombre"
        Me.LVNombre.Width = 109
        '
        'LVDireccion
        '
        Me.LVDireccion.Text = "Direccion"
        Me.LVDireccion.Width = 159
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lista de Personas"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Telefono})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(402, 94)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(121, 175)
        Me.ListView2.TabIndex = 2
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'Telefono
        '
        Me.Telefono.Text = "Telefonos"
        Me.Telefono.Width = 117
        '
        'BorrarPersona
        '
        Me.BorrarPersona.Location = New System.Drawing.Point(30, 275)
        Me.BorrarPersona.Name = "BorrarPersona"
        Me.BorrarPersona.Size = New System.Drawing.Size(114, 29)
        Me.BorrarPersona.TabIndex = 3
        Me.BorrarPersona.Text = "Borrar Persona"
        Me.BorrarPersona.UseVisualStyleBackColor = True
        '
        'BorrarTelefono
        '
        Me.BorrarTelefono.Location = New System.Drawing.Point(529, 94)
        Me.BorrarTelefono.Name = "BorrarTelefono"
        Me.BorrarTelefono.Size = New System.Drawing.Size(113, 28)
        Me.BorrarTelefono.TabIndex = 4
        Me.BorrarTelefono.Text = "Borrar Telefono"
        Me.BorrarTelefono.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(528, 275)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(114, 29)
        Me.Modificar.TabIndex = 5
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(532, 167)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(109, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(618, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(529, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 28)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Agregar Telefono"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListarPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 350)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.BorrarTelefono)
        Me.Controls.Add(Me.BorrarPersona)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "ListarPersonas"
        Me.Text = "Lista de Personas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents LVCi As ColumnHeader
    Friend WithEvents LVNombre As ColumnHeader
    Private WithEvents LVDireccion As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Telefono As ColumnHeader
    Friend WithEvents BorrarPersona As Button
    Friend WithEvents BorrarTelefono As Button
    Friend WithEvents Modificar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
