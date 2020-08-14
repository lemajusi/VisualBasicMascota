Public Class Persona
    Dim Ltelefono = New List(Of Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim nombre As String
            Dim dir As String
            Dim ci As Integer

            nombre = NombreP.Text
            dir = DireccionP.Text
            ci = CiP.Text

            Dim newPersona = New ClassPersona()
            newPersona.cedula = ci
            newPersona.nombre = nombre
            newPersona.direccion = dir
            'llamar logica'
            Dim logica = New LogicaPersona
            logica.altaPersona(newPersona)
            logica.altaTelefono(newPersona)
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
            Else
                NombreP.Text = Persona.nombre
                DireccionP.Text = Persona.direccion
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub oneMtelefono_Click(sender As Object, e As EventArgs) Handles oneMtelefono.Click
        Dim telefono As Integer
        telefono = TelefonoP.Text
        ListView1.Items.Add(telefono)
        Ltelefono.add(telefono)
        TelefonoP.Text = ""
    End Sub
End Class
