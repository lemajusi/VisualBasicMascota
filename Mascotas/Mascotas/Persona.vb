Public Class Persona
    Dim Ltelefono = New List(Of Integer)
    Private Sub Registro_Click(sender As Object, e As EventArgs) Handles Registro.Click
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
            newPersona.telefono = Ltelefono
            'llamar logica'
            Dim logica = New LogicaPersona
            logica.altaPersona(newPersona)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CiP_TextChanged(sender As Object, e As EventArgs) Handles CiP.TextChanged

    End Sub

    Private Sub oneMtelefono_Click(sender As Object, e As EventArgs) Handles oneMtelefono.Click
        Dim telefono As Integer
        Try
            telefono = TelefonoP.Text
            ListView1.Items.Add(telefono)
            Ltelefono.add(telefono)
            TelefonoP.Text = ""
        Catch ex As Exception
            Debug.WriteLine(ex)
            TelefonoP.Text = "solo numeros"
        End Try
    End Sub

    Private Sub Busqueda_Click(sender As Object, e As EventArgs) Handles Busqueda.Click
        Try
            Dim cedula As Integer
            cedula = CiP.Text
            Dim Persona As New ClassPersona
            Dim Telefonos As List(Of ClassPersona)
            Dim logica As New LogicaPersona
            Persona = logica.buscarPersona(cedula)
            If IsNothing(Persona) Then
            Else
                NombreP.Text = Persona.nombre
                DireccionP.Text = Persona.direccion
            End If
            Telefonos = logica.buscarTelefonos(cedula)
            If IsNothing(Telefonos) Then
            Else
                For index As Integer = 0 To Telefonos.Count - 1
                    Debug.WriteLine(Telefonos(0).telefono)
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
