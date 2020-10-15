<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_Mascotas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_Mascotas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LVMascotas = New System.Windows.Forms.ListView()
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ANacimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVPersona = New System.Windows.Forms.ListView()
        Me.CIPer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombrePer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de Mascotas"
        '
        'LVMascotas
        '
        Me.LVMascotas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.ANacimiento, Me.Tipo})
        Me.LVMascotas.FullRowSelect = True
        Me.LVMascotas.GridLines = True
        Me.LVMascotas.HideSelection = False
        Me.LVMascotas.Location = New System.Drawing.Point(44, 124)
        Me.LVMascotas.Name = "LVMascotas"
        Me.LVMascotas.Size = New System.Drawing.Size(321, 108)
        Me.LVMascotas.TabIndex = 1
        Me.LVMascotas.UseCompatibleStateImageBehavior = False
        Me.LVMascotas.View = System.Windows.Forms.View.Details
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 80
        '
        'ANacimiento
        '
        Me.ANacimiento.Text = "ANacimiento"
        Me.ANacimiento.Width = 111
        '
        'Tipo
        '
        Me.Tipo.Text = "Tipo"
        Me.Tipo.Width = 115
        '
        'LVPersona
        '
        Me.LVPersona.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CIPer, Me.NombrePer})
        Me.LVPersona.FullRowSelect = True
        Me.LVPersona.GridLines = True
        Me.LVPersona.HideSelection = False
        Me.LVPersona.Location = New System.Drawing.Point(44, 72)
        Me.LVPersona.Name = "LVPersona"
        Me.LVPersona.Size = New System.Drawing.Size(282, 46)
        Me.LVPersona.TabIndex = 2
        Me.LVPersona.UseCompatibleStateImageBehavior = False
        Me.LVPersona.View = System.Windows.Forms.View.Details
        '
        'CIPer
        '
        Me.CIPer.DisplayIndex = 1
        Me.CIPer.Text = "Cédula"
        Me.CIPer.Width = 103
        '
        'NombrePer
        '
        Me.NombrePer.DisplayIndex = 0
        Me.NombrePer.Text = "NombreP"
        Me.NombrePer.Width = 134
        '
        'Lista_Mascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 270)
        Me.Controls.Add(Me.LVPersona)
        Me.Controls.Add(Me.LVMascotas)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lista_Mascotas"
        Me.Text = "Lista_Mascotas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LVMascotas As ListView
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents ANacimiento As ColumnHeader
    Friend WithEvents Tipo As ColumnHeader
    Friend WithEvents LVPersona As ListView
    Friend WithEvents NombrePer As ColumnHeader
    Friend WithEvents CIPer As ColumnHeader
End Class
