Public Class Inicio
    Dim Control = 1
    'Persona'
    Private Sub CrearPersonaMenu_Click(sender As Object, e As EventArgs) Handles CrearPersonaMenu.Click
        RegistroPersona.ShowDialog()
    End Sub
    Private Sub BuscaryActualizarPersonaMenu_Click(sender As Object, e As EventArgs) Handles BuscaryActualizarPersonaMenu.Click
        BuscaryActualizar.ShowDialog()
    End Sub
    Private Sub ListarPersonaMenu_Click(sender As Object, e As EventArgs) Handles ListarPersonaMenu.Click
        ListarPersonas.listar()
        ListarPersonas.ShowDialog()
    End Sub
    'Mascota'
    Private Sub CrearMascotaMenu_Click(sender As Object, e As EventArgs) Handles CrearMascotaMenu.Click
        RegistroMascota.ShowDialog()
    End Sub
    Private Sub BuscaryActualizarMascotaMenu_Click(sender As Object, e As EventArgs) Handles BuscaryActualizarMascotaMenu.Click
        BuscaryActualizarM.ShowDialog()
    End Sub
    Private Sub ListarMascotaMenu_Click(sender As Object, e As EventArgs) Handles ListarMascotaMenu.Click

    End Sub
    'Help'
    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click

    End Sub
    Private Sub MascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MascotaToolStripMenuItem.Click

    End Sub

    'Control De Ventana'
    Private Sub Cerrar_click(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    'Vista'
    Private Sub VerdeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerdeToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Green
        RegistroPersona.BackColor = Drawing.Color.Green
        RegistroMascota.BackColor = Drawing.Color.Green
        BuscaryActualizar.BackColor = Drawing.Color.Green
        BuscaryActualizarM.BackColor = Drawing.Color.Green
        ListarPersonas.BackColor = Drawing.Color.Green
    End Sub

    Private Sub NaranjaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NaranjaToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Orange
        RegistroPersona.BackColor = Drawing.Color.Orange
        RegistroMascota.BackColor = Drawing.Color.Orange
        BuscaryActualizar.BackColor = Drawing.Color.Orange
        BuscaryActualizarM.BackColor = Drawing.Color.Orange
        ListarPersonas.BackColor = Drawing.Color.Orange
    End Sub

    Private Sub AmarilloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmarilloToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Yellow
        RegistroPersona.BackColor = Drawing.Color.Yellow
        RegistroMascota.BackColor = Drawing.Color.Yellow
        BuscaryActualizar.BackColor = Drawing.Color.Yellow
        BuscaryActualizarM.BackColor = Drawing.Color.Yellow
        ListarPersonas.BackColor = Drawing.Color.Yellow
    End Sub

    Private Sub VioletaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletaToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.DarkViolet
        RegistroPersona.BackColor = Drawing.Color.DarkViolet
        RegistroMascota.BackColor = Drawing.Color.DarkViolet
        BuscaryActualizar.BackColor = Drawing.Color.DarkViolet
        BuscaryActualizarM.BackColor = Drawing.Color.DarkViolet
        ListarPersonas.BackColor = Drawing.Color.DarkViolet
    End Sub

    Private Sub RojoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RojoToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.IndianRed
        RegistroPersona.BackColor = Drawing.Color.IndianRed
        RegistroMascota.BackColor = Drawing.Color.IndianRed
        BuscaryActualizar.BackColor = Drawing.Color.IndianRed
        BuscaryActualizarM.BackColor = Drawing.Color.IndianRed
        ListarPersonas.BackColor = Drawing.Color.IndianRed
    End Sub
    Private Sub AzulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AzulToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Blue
        RegistroPersona.BackColor = Drawing.Color.Blue
        RegistroMascota.BackColor = Drawing.Color.Blue
        BuscaryActualizar.BackColor = Drawing.Color.Blue
        BuscaryActualizarM.BackColor = Drawing.Color.Blue
        ListarPersonas.BackColor = Drawing.Color.Blue
    End Sub
    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.White
        RegistroPersona.BackColor = Drawing.Color.White
        RegistroMascota.BackColor = Drawing.Color.White
        BuscaryActualizar.BackColor = Drawing.Color.White
        BuscaryActualizarM.BackColor = Drawing.Color.White
        ListarPersonas.BackColor = Drawing.Color.White
    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.DimGray
        RegistroPersona.BackColor = Drawing.Color.DimGray
        RegistroMascota.BackColor = Drawing.Color.DimGray
        BuscaryActualizar.BackColor = Drawing.Color.DimGray
        BuscaryActualizarM.BackColor = Drawing.Color.DimGray
        ListarPersonas.BackColor = Drawing.Color.DimGray
    End Sub

    Private Sub CIDePersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CIDePersonaToolStripMenuItem.Click
        CIDePersonaToolStripMenuItem.Text = ""
    End Sub

    Private Sub CIDePersonaToolStripMenuItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CIDePersonaToolStripMenuItem.KeyPress
        Try
            Dim key = Convert.ToChar(Keys.Enter)
            If e.KeyChar = key Then
                Dim cip = CIDePersonaToolStripMenuItem.Text
                If IsNothing(cip) Then
                Else
                    Lista_Mascotas.Listar(cip)
                    Lista_Mascotas.ShowDialog()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class