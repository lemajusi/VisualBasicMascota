<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscaryActualizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscaryActualizar))
        Me.Ok = New System.Windows.Forms.PictureBox()
        Me.NotOK = New System.Windows.Forms.PictureBox()
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListVTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BATelefonoP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BACiP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BADireccionP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.BANombreP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BotonModificar = New System.Windows.Forms.PictureBox()
        CType(Me.Ok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotonModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ok
        '
        Me.Ok.Image = CType(resources.GetObject("Ok.Image"), System.Drawing.Image)
        Me.Ok.Location = New System.Drawing.Point(229, 254)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(23, 23)
        Me.Ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ok.TabIndex = 50
        Me.Ok.TabStop = False
        Me.Ok.Visible = False
        '
        'NotOK
        '
        Me.NotOK.Image = CType(resources.GetObject("NotOK.Image"), System.Drawing.Image)
        Me.NotOK.Location = New System.Drawing.Point(229, 180)
        Me.NotOK.Name = "NotOK"
        Me.NotOK.Size = New System.Drawing.Size(20, 20)
        Me.NotOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NotOK.TabIndex = 49
        Me.NotOK.TabStop = False
        Me.NotOK.Visible = False
        '
        'Actualizar
        '
        Me.Actualizar.Location = New System.Drawing.Point(148, 254)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Actualizar.TabIndex = 48
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Telefonos"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ListVTelefono})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(278, 102)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(159, 139)
        Me.ListView2.TabIndex = 46
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.List
        '
        'ListVTelefono
        '
        Me.ListVTelefono.Text = "Telefono"
        Me.ListVTelefono.Width = 142
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Direccion"
        '
        'BATelefonoP
        '
        Me.BATelefonoP.Location = New System.Drawing.Point(43, 219)
        Me.BATelefonoP.Name = "BATelefonoP"
        Me.BATelefonoP.Size = New System.Drawing.Size(180, 20)
        Me.BATelefonoP.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Telefono"
        '
        'BACiP
        '
        Me.BACiP.Location = New System.Drawing.Point(43, 180)
        Me.BACiP.Name = "BACiP"
        Me.BACiP.Size = New System.Drawing.Size(180, 20)
        Me.BACiP.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "CI"
        '
        'BADireccionP
        '
        Me.BADireccionP.Location = New System.Drawing.Point(43, 141)
        Me.BADireccionP.Name = "BADireccionP"
        Me.BADireccionP.Size = New System.Drawing.Size(180, 20)
        Me.BADireccionP.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 39
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(43, 253)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 38
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'BANombreP
        '
        Me.BANombreP.Location = New System.Drawing.Point(43, 102)
        Me.BANombreP.Name = "BANombreP"
        Me.BANombreP.Size = New System.Drawing.Size(180, 20)
        Me.BANombreP.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 31)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Buscar y Actualizar"
        '
        'BotonModificar
        '
        Me.BotonModificar.Image = CType(resources.GetObject("BotonModificar.Image"), System.Drawing.Image)
        Me.BotonModificar.Location = New System.Drawing.Point(242, 219)
        Me.BotonModificar.Name = "BotonModificar"
        Me.BotonModificar.Size = New System.Drawing.Size(19, 19)
        Me.BotonModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BotonModificar.TabIndex = 52
        Me.BotonModificar.TabStop = False
        '
        'BuscaryActualizar
        '
        Me.AcceptButton = Me.Actualizar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(471, 316)
        Me.Controls.Add(Me.BotonModificar)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.NotOK)
        Me.Controls.Add(Me.Actualizar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BATelefonoP)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BACiP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BADireccionP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.BANombreP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(487, 355)
        Me.MinimumSize = New System.Drawing.Size(487, 355)
        Me.Name = "BuscaryActualizar"
        Me.Text = "Buscar y Acutualizar"
        CType(Me.Ok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotonModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ok As PictureBox
    Friend WithEvents NotOK As PictureBox
    Friend WithEvents Actualizar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListVTelefono As ColumnHeader
    Friend WithEvents Label10 As Label
    Friend WithEvents BATelefonoP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BACiP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BADireccionP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Buscar As Button
    Friend WithEvents BANombreP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BotonModificar As PictureBox
End Class
