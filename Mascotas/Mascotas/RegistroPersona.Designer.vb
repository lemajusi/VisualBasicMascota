<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroPersona))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombreP = New System.Windows.Forms.TextBox()
        Me.Registro = New System.Windows.Forms.Button()
        Me.DireccionP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CiP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TelefonoP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Busqueda = New System.Windows.Forms.Button()
        Me.NotOK = New System.Windows.Forms.PictureBox()
        Me.Ok = New System.Windows.Forms.PictureBox()
        Me.SetTel = New System.Windows.Forms.PictureBox()
        Me.DropTel = New System.Windows.Forms.PictureBox()
        CType(Me.NotOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetTel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropTel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'NombreP
        '
        Me.NombreP.Location = New System.Drawing.Point(33, 88)
        Me.NombreP.Name = "NombreP"
        Me.NombreP.Size = New System.Drawing.Size(180, 20)
        Me.NombreP.TabIndex = 7
        '
        'Registro
        '
        Me.Registro.Location = New System.Drawing.Point(33, 239)
        Me.Registro.Name = "Registro"
        Me.Registro.Size = New System.Drawing.Size(75, 23)
        Me.Registro.TabIndex = 12
        Me.Registro.Text = "Registro"
        Me.Registro.UseVisualStyleBackColor = True
        '
        'DireccionP
        '
        Me.DireccionP.Location = New System.Drawing.Point(33, 127)
        Me.DireccionP.Name = "DireccionP"
        Me.DireccionP.Size = New System.Drawing.Size(180, 20)
        Me.DireccionP.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 13
        '
        'CiP
        '
        Me.CiP.Location = New System.Drawing.Point(33, 166)
        Me.CiP.Name = "CiP"
        Me.CiP.Size = New System.Drawing.Size(180, 20)
        Me.CiP.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CI"
        '
        'TelefonoP
        '
        Me.TelefonoP.Location = New System.Drawing.Point(33, 205)
        Me.TelefonoP.Name = "TelefonoP"
        Me.TelefonoP.Size = New System.Drawing.Size(180, 20)
        Me.TelefonoP.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Telefono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Direccion"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(268, 88)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(152, 137)
        Me.ListView1.TabIndex = 29
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Telefonos"
        '
        'Busqueda
        '
        Me.Busqueda.Location = New System.Drawing.Point(138, 240)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(75, 23)
        Me.Busqueda.TabIndex = 31
        Me.Busqueda.Text = "Buscar"
        Me.Busqueda.UseVisualStyleBackColor = True
        '
        'NotOK
        '
        Me.NotOK.Image = CType(resources.GetObject("NotOK.Image"), System.Drawing.Image)
        Me.NotOK.Location = New System.Drawing.Point(219, 166)
        Me.NotOK.Name = "NotOK"
        Me.NotOK.Size = New System.Drawing.Size(20, 20)
        Me.NotOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NotOK.TabIndex = 32
        Me.NotOK.TabStop = False
        Me.NotOK.Visible = False
        '
        'Ok
        '
        Me.Ok.Image = CType(resources.GetObject("Ok.Image"), System.Drawing.Image)
        Me.Ok.Location = New System.Drawing.Point(112, 240)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(20, 20)
        Me.Ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ok.TabIndex = 33
        Me.Ok.TabStop = False
        Me.Ok.Visible = False
        '
        'SetTel
        '
        Me.SetTel.Image = CType(resources.GetObject("SetTel.Image"), System.Drawing.Image)
        Me.SetTel.Location = New System.Drawing.Point(232, 205)
        Me.SetTel.Name = "SetTel"
        Me.SetTel.Size = New System.Drawing.Size(20, 20)
        Me.SetTel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SetTel.TabIndex = 34
        Me.SetTel.TabStop = False
        '
        'DropTel
        '
        Me.DropTel.Image = CType(resources.GetObject("DropTel.Image"), System.Drawing.Image)
        Me.DropTel.Location = New System.Drawing.Point(272, 231)
        Me.DropTel.Name = "DropTel"
        Me.DropTel.Size = New System.Drawing.Size(20, 20)
        Me.DropTel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DropTel.TabIndex = 35
        Me.DropTel.TabStop = False
        '
        'RegistroPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 291)
        Me.Controls.Add(Me.DropTel)
        Me.Controls.Add(Me.SetTel)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.NotOK)
        Me.Controls.Add(Me.Busqueda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TelefonoP)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CiP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DireccionP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Registro)
        Me.Controls.Add(Me.NombreP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(469, 330)
        Me.MinimumSize = New System.Drawing.Size(469, 330)
        Me.Name = "RegistroPersona"
        Me.Text = "Persona"
        CType(Me.NotOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetTel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropTel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NombreP As TextBox
    Friend WithEvents Registro As Button
    Friend WithEvents DireccionP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CiP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TelefonoP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents Busqueda As Button
    Friend WithEvents NotOK As PictureBox
    Friend WithEvents Ok As PictureBox
    Friend WithEvents SetTel As PictureBox
    Friend WithEvents DropTel As PictureBox
End Class
