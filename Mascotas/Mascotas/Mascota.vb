Public Class Mascota
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombreM As String
        Dim añoNacM As Integer
        Dim cedulaP As Integer

        nombreM = NombreMas.Text
        añoNacM = AñoNacMas.Text
        cedulaP = CedulaPer.Text

        Dim newMascota = New ClassMascota()
        newMascota.nombreM = nombreM
        newMascota.cedulaP = cedulaP
        newMascota.añoNacM = añoNacM
        'llamar logica'
        Dim logica = New LogicaMascota
        logica.altaMascota(newMascota)
    End Sub

    Private Sub Mascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class