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

    Private Sub CiP_TextChanged(sender As Object, e As EventArgs) Handles CiP.TextChanged
        Try
            Dim cedula As Integer
            cedula = CiP.Text
            Dim Persona As New ClassPersona
            Dim logica As New LogicaPersona
            Persona = logica.buscarPersona(cedula)
            If IsNothing(Persona) Then
                NombreP.Text = "no hay nada tarado"
            Else
                NombreP.Text = Persona.nombre
                DireccionP.Text = Persona.direccion
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
