Public Class Inicio
    Private Sub CrearPersonaMenu_Click(sender As Object, e As EventArgs) Handles CrearPersonaMenu.Click
        Persona.ShowDialog()
    End Sub
    Private Sub CrearMascotaMenu_Click(sender As Object, e As EventArgs) Handles CrearMascotaMenu.Click
        Mascota.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ActualizarMascotaMenu_Click(sender As Object, e As EventArgs) Handles ActualizarMascotaMenu.Click

    End Sub
End Class