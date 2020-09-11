Public Class Inicio
    Private Sub CrearPersonaMenu_Click(sender As Object, e As EventArgs) Handles CrearPersonaMenu.Click
        Persona.ShowDialog()
    End Sub
    Private Sub BuscaryActualizarPersonaMenu_Click(sender As Object, e As EventArgs) Handles BuscaryActualizarPersonaMenu.Click
        BuscaryActualizar.ShowDialog()
    End Sub
    Private Sub BorrarPersonaMenu_Click(sender As Object, e As EventArgs) Handles BorrarPersonaMenu.Click

    End Sub

    Private Sub ListarPersonaMenu_Click(sender As Object, e As EventArgs) Handles ListarPersonaMenu.Click

    End Sub


    Private Sub CrearMascotaMenu_Click(sender As Object, e As EventArgs) Handles CrearMascotaMenu.Click
        Mascota.ShowDialog()
    End Sub

    Private Sub BuscaryActualizarMascotaMenu_Click(sender As Object, e As EventArgs) Handles BuscaryActualizarMascotaMenu.Click

    End Sub

    Private Sub BorrarMascotaMenu_Click(sender As Object, e As EventArgs) Handles BorrarMascotaMenu.Click

    End Sub

    Private Sub ListarMascotaMenu_Click(sender As Object, e As EventArgs) Handles ListarMascotaMenu.Click

    End Sub
    Private Sub cerrar_click(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class