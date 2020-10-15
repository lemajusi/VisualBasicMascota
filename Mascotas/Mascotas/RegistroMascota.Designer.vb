<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroMascota
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroMascota))
        Me.AñoNacMas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NombreMas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Registro = New System.Windows.Forms.Button()
        Me.CedulaPer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Ok = New System.Windows.Forms.PictureBox()
        CType(Me.Ok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AñoNacMas
        '
        Me.AñoNacMas.Location = New System.Drawing.Point(33, 166)
        Me.AñoNacMas.Name = "AñoNacMas"
        Me.AñoNacMas.Size = New System.Drawing.Size(180, 20)
        Me.AñoNacMas.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Año de Nacimiento"
        '
        'NombreMas
        '
        Me.NombreMas.Location = New System.Drawing.Point(33, 88)
        Me.NombreMas.Name = "NombreMas"
        Me.NombreMas.Size = New System.Drawing.Size(180, 20)
        Me.NombreMas.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nombre de la Mascota"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 31)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Registro"
        '
        'Registro
        '
        Me.Registro.Location = New System.Drawing.Point(33, 241)
        Me.Registro.Name = "Registro"
        Me.Registro.Size = New System.Drawing.Size(75, 23)
        Me.Registro.TabIndex = 34
        Me.Registro.Text = "Registro"
        Me.Registro.UseVisualStyleBackColor = True
        '
        'CedulaPer
        '
        Me.CedulaPer.Location = New System.Drawing.Point(33, 127)
        Me.CedulaPer.Name = "CedulaPer"
        Me.CedulaPer.Size = New System.Drawing.Size(180, 20)
        Me.CedulaPer.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cedula del Dueño"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Tipo de Mascota"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Perro", "Gato", "Pez", "Conejo"})
        Me.ListBox1.Location = New System.Drawing.Point(33, 205)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(167, 30)
        Me.ListBox1.TabIndex = 39
        '
        'Ok
        '
        Me.Ok.Image = CType(resources.GetObject("Ok.Image"), System.Drawing.Image)
        Me.Ok.Location = New System.Drawing.Point(114, 241)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(23, 23)
        Me.Ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ok.TabIndex = 41
        Me.Ok.TabStop = False
        Me.Ok.Visible = False
        '
        'RegistroMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 297)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CedulaPer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Registro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AñoNacMas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NombreMas)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistroMascota"
        Me.Text = "Mascota"
        CType(Me.Ok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AñoNacMas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NombreMas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Registro As Button
    Friend WithEvents CedulaPer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Ok As PictureBox
End Class
