Public Class BuscaryActualizar
    Dim Ltelefono = New List(Of Integer)
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try
            Dim cedula As Integer
            cedula = CiPByA.Text
            Dim Persona As New ClassPersona
            Dim Telefonos As ClassPersona
            Dim logica As New LogicaPersona
            Persona = logica.buscarPersona(cedula)
            If IsNothing(Persona) Then
            Else
                NombrePByA.Text = Persona.nombre
                DireccionPByA.Text = Persona.direccion
            End If
            ListView1.Items.Clear()
            Telefonos = logica.buscarTelefonos(cedula)
            Dim array(2) As String
            If IsNothing(Telefonos) Then
            Else
                For index As Integer = 0 To Telefonos.telefono.Count - 1
                    array(0) = Telefonos.telefono(index)
                    array(1) = Convert.ToString(index + 1)
                    Debug.WriteLine(array(1))
                    Dim item = New ListViewItem(array)
                    ListView1.Items.Add(item)
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub oneMtelefonoByA_Click(sender As Object, e As EventArgs) Handles oneMtelefonoByA.Click
        Dim telefono As Integer
        Try
            telefono = TelefonoPByA.Text
            ListView1.Items.Add(telefono)
            Ltelefono.add(telefono)
            TelefonoPByA.Text = ""
        Catch ex As Exception
            Debug.WriteLine(ex)
            TelefonoPByA.Text = "solo numeros"
        End Try
    End Sub
End Class