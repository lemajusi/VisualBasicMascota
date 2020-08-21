Public Class Inicio
    Private Sub CrearPersonaMenu_Click(sender As Object, e As EventArgs) Handles CrearPersonaMenu.Click
        Persona.ShowDialog()
    End Sub
    Private Sub CrearMascotaMenu_Click(sender As Object, e As EventArgs) Handles CrearMascotaMenu.Click
        Mascota.ShowDialog()
    End Sub

    Private Sub BuscaryActualizarM_Click(sender As Object, e As EventArgs) Handles BuscaryActualizarM.Click

    End Sub

    Private Sub BuscaryActualizarP_Click(sender As Object, e As EventArgs) Handles BuscaryActualizarP.Click
        BuscaryActualizar.ShowDialog()
    End Sub
End Class