Public Class BuscaryActualizarM
    Private MeMascota = New ClassMascota
    Private Sub MeLoad(sender As Object, e As EventArgs) Handles Me.Load
        NombreMas.Enabled = False
        AñoNacMas.Enabled = False
    End Sub
    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim año = AñoNacMas.Text
        Dim nombre = NombreMas.Text
        Dim logica = New LogicaMascota
        logica.
    End Sub
    Public Sub SetMascota(ci As Integer, mascota As ClassMascota)
        MeMascota = mascota
        CedulaPer.Text = ci
        If mascota.nombreM <> "" Then
            NombreMas.Enabled = True
            AñoNacMas.Enabled = True
            NombreMas.Text = mascota.nombreM
            AñoNacMas.Text = mascota.añoNacM
        End If
    End Sub
End Class