Public Class Inicio
    Private Sub CrearPersonaMenu_Click(sender As Object, e As EventArgs) Handles CrearPersonaMenu.Click
        Persona.ShowDialog()
    End Sub
    Private Sub CrearMascotaMenu_Click(sender As Object, e As EventArgs) Handles CrearMascotaMenu.Click
        Mascota.ShowDialog()
    End Sub
End Class