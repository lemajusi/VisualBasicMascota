Public Class RegistroMascota
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Registro.Click
        Dim nombreM = NombreMas.Text
        Dim añoNacM = AñoNacMas.Text
        Dim cedulaP = CedulaPer.Text

        Dim newMascota = New ClassMascota With {
            .nombreM = nombreM,
            .cedulaP = cedulaP,
            .añoNacM = añoNacM
        }
        'llamar logica'
        Dim logica = New LogicaMascota
        logica.AltaMascota(newMascota)
    End Sub
End Class