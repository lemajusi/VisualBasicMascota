Public Class Inicio
    Private Sub MascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MascotaToolStripMenuItem.Click
        Mascota.ShowDialog()
    End Sub
    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        Persona.ShowDialog()
    End Sub
End Class