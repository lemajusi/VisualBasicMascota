Public Class Inicio
    Dim Control = 1
    'Persona'
    Private Sub CrearPersonaMenu_Click(sender As Object, e As EventArgs) Handles CrearPersonaMenu.Click
        RegistroPersona.ShowDialog()
    End Sub
    Private Sub BuscaryActualizarPersonaMenu_Click(sender As Object, e As EventArgs) Handles BuscaryActualizarPersonaMenu.Click
        BuscaryActualizar.ShowDialog()
    End Sub
    Private Sub BorrarPersonaMenu_Click(sender As Object, e As EventArgs)

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
    Private Sub BorrarMascotaMenu_Click(sender As Object, e As EventArgs)

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
    End Sub

    Private Sub NaranjaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NaranjaToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Orange
        RegistroPersona.BackColor = Drawing.Color.Orange
    End Sub

    Private Sub AmarilloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmarilloToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Yellow
        RegistroPersona.BackColor = Drawing.Color.Yellow
    End Sub

    Private Sub VioletaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletaToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.DarkViolet
        RegistroPersona.BackColor = Drawing.Color.DarkViolet
    End Sub

    Private Sub RojoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RojoToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.IndianRed
        RegistroPersona.BackColor = Drawing.Color.IndianRed
    End Sub
    Private Sub AzulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AzulToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Blue
        RegistroPersona.BackColor = Drawing.Color.Blue
    End Sub
    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.White
        RegistroPersona.BackColor = Drawing.Color.White
    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.DimGray
        RegistroPersona.BackColor = Drawing.Color.DimGray
    End Sub
End Class