<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Persona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Persona))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombrePR = New System.Windows.Forms.TextBox()
        Me.Registro = New System.Windows.Forms.Button()
        Me.DireccionPR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CiPR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TelefonoPR = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.oneMtelefonoR = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Telefonos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 27)
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
        'NombrePR
        '
        Me.NombrePR.Location = New System.Drawing.Point(33, 88)
        Me.NombrePR.Name = "NombrePR"
        Me.NombrePR.Size = New System.Drawing.Size(180, 20)
        Me.NombrePR.TabIndex = 7
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
        'DireccionPR
        '
        Me.DireccionPR.Location = New System.Drawing.Point(33, 127)
        Me.DireccionPR.Name = "DireccionPR"
        Me.DireccionPR.Size = New System.Drawing.Size(180, 20)
        Me.DireccionPR.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 13
        '
        'CiPR
        '
        Me.CiPR.Location = New System.Drawing.Point(33, 166)
        Me.CiPR.Name = "CiPR"
        Me.CiPR.Size = New System.Drawing.Size(180, 20)
        Me.CiPR.TabIndex = 18
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
        'TelefonoPR
        '
        Me.TelefonoPR.Location = New System.Drawing.Point(33, 205)
        Me.TelefonoPR.Name = "TelefonoPR"
        Me.TelefonoPR.Size = New System.Drawing.Size(180, 20)
        Me.TelefonoPR.TabIndex = 24
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
        'oneMtelefonoR
        '
        Me.oneMtelefonoR.Location = New System.Drawing.Point(219, 201)
        Me.oneMtelefonoR.Name = "oneMtelefonoR"
        Me.oneMtelefonoR.Size = New System.Drawing.Size(41, 27)
        Me.oneMtelefonoR.TabIndex = 27
        Me.oneMtelefonoR.Text = "+"
        Me.oneMtelefonoR.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Telefonos})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(266, 72)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(152, 190)
        Me.ListView1.TabIndex = 29
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Telefonos
        '
        Me.Telefonos.Text = "Telefonos"
        Me.Telefonos.Width = 146
        '
        'Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 291)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.oneMtelefonoR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TelefonoPR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CiPR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DireccionPR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Registro)
        Me.Controls.Add(Me.NombrePR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Persona"
        Me.Text = "Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NombrePR As TextBox
    Friend WithEvents Registro As Button
    Friend WithEvents DireccionPR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CiPR As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TelefonoPR As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents oneMtelefonoR As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Telefonos As ColumnHeader
End Class
