Public Class Persona
    Dim Ltelefono = New List(Of Integer)
    Private Sub Registro_Click(sender As Object, e As EventArgs) Handles Registro.Click
        Try
            Dim nombre As String
            Dim dir As String
            Dim ci As Integer

            nombre = NombrePR.Text
            dir = DireccionPR.Text
            ci = CiPR.Text


            Dim newPersona = New ClassPersona()
            newPersona.cedula = ci
            newPersona.nombre = nombre
            newPersona.direccion = dir
            newPersona.telefono = Ltelefono
            'llamar logica'
            Dim logica = New LogicaPersona
            logica.altaPersona(newPersona)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub oneMtelefonoR_Click(sender As Object, e As EventArgs) Handles oneMtelefonoR.Click
        Dim telefono As Integer
        Try
            telefono = TelefonoPR.Text
            ListView1.Items.Add(telefono)
            Ltelefono.add(telefono)
            TelefonoPR.Text = ""
        Catch ex As Exception
            Debug.WriteLine(ex)
            TelefonoPR.Text = "solo numeros"
        End Try
    End Sub
End Class
