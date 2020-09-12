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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.LVCi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.Telefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.NombreMascota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AñoNacimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LVCi, Me.LVNombre, Me.LVDireccion})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(45, 122)
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
        Me.Label1.Location = New System.Drawing.Point(214, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lista de Personas"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Telefono})
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(417, 122)
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
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NombreMascota, Me.AñoNacimiento})
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(544, 122)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(244, 175)
        Me.ListView3.TabIndex = 3
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'NombreMascota
        '
        Me.NombreMascota.Text = "Nombre"
        Me.NombreMascota.Width = 94
        '
        'AñoNacimiento
        '
        Me.AñoNacimiento.Text = "Año de Nacimiento"
        Me.AñoNacimiento.Width = 148
        '
        'ListarPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 350)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "ListarPersonas"
        Me.Text = "Lista de Personas"
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
    Friend WithEvents ListView3 As ListView
    Friend WithEvents NombreMascota As ColumnHeader
    Friend WithEvents AñoNacimiento As ColumnHeader
End Class
