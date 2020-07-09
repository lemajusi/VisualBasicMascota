Public Class Persona
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim nombre As String
            Dim dir As String
            Dim ci As String
            Dim tel As String

            nombre = NombreP.Text
            dir = DireccionP.Text
            ci = CiP.Text
            tel = TelefonoP.Text

            Dim newPersona = New ClassPersona()
            newPersona.cedula = ci
            newPersona.nombre = nombre
            newPersona.direccion = dir
            newPersona.telefono = tel
            'llamar logica'
            Dim logica = New LogicaPersona
            logica.altaPersona(newPersona)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
