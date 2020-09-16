Public Class BuscaryActualizar
    Dim listTelefono As New List(Of Integer)
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try

            Dim cedula As Integer
            cedula = BACiP.Text
            Dim Persona As ClassPersona
            Dim logica As New LogicaPersona
            BANombreP.Text = ""
            BADireccionP.Text = ""
            Persona = logica.buscarPersona(cedula)
            If IsNothing(Persona) Then
            Else
                BANombreP.Text = Persona.nombre
                BADireccionP.Text = Persona.direccion
            End If
            ListView2.Items.Clear()
            Persona.telefono = logica.buscarTelefonos(cedula)
            If IsNothing(Persona.telefono) Then
            Else
                For index As Integer = 0 To Persona.telefono.Count - 1
                    ListView2.Items.Add(Persona.telefono(index))
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click

    End Sub

    Private Sub BotonModificar_Click(sender As Object, e As EventArgs) Handles BotonModificar.Click
        Dim telefono As Integer
        Try
            telefono = BATelefonoP.Text
            ListView2.Items.Add(telefono)
            listTelefono.Add(telefono)
            BATelefonoP.Text = ""
        Catch ex As Exception
            Debug.WriteLine(ex)
            BATelefonoP.Text = "solo numeros"
        End Try
    End Sub
End Class