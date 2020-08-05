Public Class Persona
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim nombre As String
            Dim dir As String
            Dim ci As Integer
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
            Throw ex
        End Try
    End Sub
End Class
