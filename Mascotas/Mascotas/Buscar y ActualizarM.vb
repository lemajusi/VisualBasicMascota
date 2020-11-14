Public Class BuscaryActualizarM
    Public MeMascota = New ClassMascota
    Public Persona = New ClassPersona
    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim año = AñoNacMas.Text
        Dim nombre = NombreMas.Text
        Dim logica = New LogicaMascota
        logica.UpdateMascota(Persona.cedula, nombre, año)
    End Sub
    Public Sub SetMascota(ci As Integer, mascota As ClassMascota)
        MeMascota = mascota
        Persona.cedula = ci
        CedulaPer.Text = ci
        If mascota.nombreM <> "" Then
            NombreMas.Enabled = True
            AñoNacMas.Enabled = True
            NombreMas.Text = mascota.nombreM
            AñoNacMas.Text = mascota.añoNacM
        End If
    End Sub
End Class