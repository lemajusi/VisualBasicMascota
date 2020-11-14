<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaryActualizarM
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CedulaPer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.AñoNacMas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NombreMas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BuscarM = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 31)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Buscar y Actualizar"
        '
        'CedulaPer
        '
        Me.CedulaPer.Enabled = False
        Me.CedulaPer.Location = New System.Drawing.Point(58, 137)
        Me.CedulaPer.Name = "CedulaPer"
        Me.CedulaPer.Size = New System.Drawing.Size(180, 20)
        Me.CedulaPer.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Cedula del Dueño"
        '
        'Actualizar
        '
        Me.Actualizar.Enabled = False
        Me.Actualizar.Location = New System.Drawing.Point(41, 213)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Actualizar.TabIndex = 46
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'AñoNacMas
        '
        Me.AñoNacMas.Location = New System.Drawing.Point(58, 176)
        Me.AñoNacMas.Name = "AñoNacMas"
        Me.AñoNacMas.Size = New System.Drawing.Size(180, 20)
        Me.AñoNacMas.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Año de Nacimiento"
        '
        'NombreMas
        '
        Me.NombreMas.Location = New System.Drawing.Point(58, 98)
        Me.NombreMas.Name = "NombreMas"
        Me.NombreMas.Size = New System.Drawing.Size(180, 20)
        Me.NombreMas.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Nombre de la Mascota"
        '
        'BuscarM
        '
        Me.BuscarM.Location = New System.Drawing.Point(182, 213)
        Me.BuscarM.Name = "BuscarM"
        Me.BuscarM.Size = New System.Drawing.Size(75, 23)
        Me.BuscarM.TabIndex = 52
        Me.BuscarM.Text = "Buscar"
        Me.BuscarM.UseVisualStyleBackColor = True
        '
        'BuscaryActualizarM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 271)
        Me.Controls.Add(Me.BuscarM)
        Me.Controls.Add(Me.CedulaPer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Actualizar)
        Me.Controls.Add(Me.AñoNacMas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NombreMas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BuscaryActualizarM"
        Me.Text = "Buscar y Actualizar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CedulaPer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Actualizar As Button
    Friend WithEvents AñoNacMas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NombreMas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BuscarM As Button
End Class
