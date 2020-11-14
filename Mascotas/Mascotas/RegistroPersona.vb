Public Class RegistroPersona
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
            Dim logicat = New LogicaTelefono
            Dim persona As ClassPersona
            persona = logica.chequearCi(ci)
            If IsNothing(persona) Then
                MessageBox.Show("Fallo al crear")
            Else
                logica.altaPersona(newPersona)
                logicat.AltaTelefonos(persona)
                Ok.Visible = True
                NombreP.Text = ""
                DireccionP.Text = ""
                CiP.Text = ""
                ListView1.Clear()

                MessageBox.Show("Creado Correctamente")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub SetTel_Click(sender As Object, e As EventArgs) Handles SetTel.Click
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
    Private Sub DropTel_Click(sender As Object, e As EventArgs) Handles DropTel.Click
        Dim index = ListView1.FocusedItem.Index
        ListView1.FocusedItem.Remove()
        Ltelefono.RemoveAt(index)
    End Sub
    Private Sub Busqueda_Click(sender As Object, e As EventArgs) Handles Busqueda.Click
        Try
            Dim cedula As Integer
            cedula = CiP.Text
            Dim existe = False
            Dim Persona As New ClassPersona
            Dim logica As New LogicaPersona
            Dim logicat As New LogicaTelefono
            Persona = logica.buscarPersona(cedula)
            If IsNothing(Persona) Then
                MessageBox.Show("No existe este usuario")
            Else
                existe = True
                NombreP.Text = Persona.nombre
                DireccionP.Text = Persona.direccion
            End If
            If existe Then
                Persona.telefono = logicat.BuscarTelefono(Persona.cedula)
                If IsNothing(Persona.telefono) Then
                Else
                    For index As Integer = 0 To Persona.telefono.Count - 1
                        ListView1.Items.Add(Persona.telefono(index))
                    Next
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TelefonoP_Click(sender As Object, e As EventArgs) Handles TelefonoP.Click
        TelefonoP.Text = ""
        Ok.Visible = False
    End Sub

    Private Sub CiP_Click(sender As Object, e As EventArgs) Handles CiP.Click
        Ok.Visible = False
        NotOK.Visible = False
    End Sub

    Private Sub DireccionP_Click(sender As Object, e As EventArgs) Handles DireccionP.Click
        Ok.Visible = False
    End Sub

    Private Sub NombreP_Click(sender As Object, e As EventArgs) Handles NombreP.Click
        Ok.Visible = False
    End Sub
End Class
