<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaryActualizar
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
        Me.Telefonos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Seleccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.oneMtelefonoByA = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TelefonoPByA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CiPByA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DireccionPByA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.NombrePByA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Telefonos, Me.Seleccion})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(278, 82)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(152, 190)
        Me.ListView1.TabIndex = 43
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Telefonos
        '
        Me.Telefonos.Text = "Telefonos"
        Me.Telefonos.Width = 88
        '
        'Seleccion
        '
        Me.Seleccion.Text = "Selección"
        '
        'oneMtelefonoByA
        '
        Me.oneMtelefonoByA.Location = New System.Drawing.Point(231, 237)
        Me.oneMtelefonoByA.Name = "oneMtelefonoByA"
        Me.oneMtelefonoByA.Size = New System.Drawing.Size(41, 27)
        Me.oneMtelefonoByA.TabIndex = 42
        Me.oneMtelefonoByA.Text = "->"
        Me.oneMtelefonoByA.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Direccion"
        '
        'TelefonoPByA
        '
        Me.TelefonoPByA.Location = New System.Drawing.Point(45, 241)
        Me.TelefonoPByA.Name = "TelefonoPByA"
        Me.TelefonoPByA.Size = New System.Drawing.Size(180, 20)
        Me.TelefonoPByA.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Telefono"
        '
        'CiPByA
        '
        Me.CiPByA.Location = New System.Drawing.Point(45, 176)
        Me.CiPByA.Name = "CiPByA"
        Me.CiPByA.Size = New System.Drawing.Size(180, 20)
        Me.CiPByA.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "CI(No se puede actualizar)"
        '
        'DireccionPByA
        '
        Me.DireccionPByA.Location = New System.Drawing.Point(45, 137)
        Me.DireccionPByA.Name = "DireccionPByA"
        Me.DireccionPByA.Size = New System.Drawing.Size(180, 20)
        Me.DireccionPByA.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 35
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(45, 267)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 34
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'NombrePByA
        '
        Me.NombrePByA.Location = New System.Drawing.Point(45, 98)
        Me.NombrePByA.Name = "NombrePByA"
        Me.NombrePByA.Size = New System.Drawing.Size(180, 20)
        Me.NombrePByA.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 31)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Buscar y Actualizar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(102, 202)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(30, 20)
        Me.TextBox1.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Selección"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Selección es solo para actualizar"
        '
        'BuscaryActualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 302)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.oneMtelefonoByA)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TelefonoPByA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CiPByA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DireccionPByA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.NombrePByA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BuscaryActualizar"
        Me.Text = "Buscar y Actualizar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents oneMtelefonoByA As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TelefonoPByA As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CiPByA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DireccionPByA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Buscar As Button
    Friend WithEvents NombrePByA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Telefonos As ColumnHeader
    Friend WithEvents Seleccion As ColumnHeader
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
