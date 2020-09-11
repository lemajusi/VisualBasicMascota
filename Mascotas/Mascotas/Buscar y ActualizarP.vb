Public Class BuscaryActualizar
    Dim listTelefono As New List(Of Integer)
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Try

            Dim cedula As Integer
            cedula = BACiP.Text
            Dim Persona As New ClassPersona
            Dim Telefonos As ClassPersona
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
            Telefonos = logica.buscarTelefonos(cedula)
            Dim array(2) As String
            If IsNothing(Telefonos) Then
            Else
                For index As Integer = 0 To Telefonos.telefono.Count - 1
                    array(0) = Convert.ToString(index + 1)
                    array(1) = Telefonos.telefono(index)
                    Debug.WriteLine(array(1))
                    Dim item = New ListViewItem(array)
                    ListView2.Items.Add(item)
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

    Private Sub Modificar1Telefono_Click(sender As Object, e As EventArgs) Handles Modificar1Telefono.Click
        Telefono.Text = "gola"
    End Sub
End Class