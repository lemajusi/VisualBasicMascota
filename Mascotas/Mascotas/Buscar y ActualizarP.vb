Public Class BuscaryActualizar
    Dim bool As Boolean = False
    Dim Persona As ClassPersona
    Dim logica As New LogicaPersona
    Dim cedula As Integer
    Dim telefono As Integer
    Dim item As Integer
    Public Sub BuscarP(ci As Integer)
        Try
            cedula = ci
            BANombreP.Text = ""
            BADireccionP.Text = ""
            Persona = logica.buscarPersona(cedula)
            If IsNothing(Persona) Then
            Else
                BANombreP.Text = Persona.nombre
                BADireccionP.Text = Persona.direccion
            End If
            BuscarT(Persona)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub BuscarT(Persona As ClassPersona)
        ListView2.Items.Clear()
        Persona.telefono = logica.buscarTelefonos(cedula)
        If IsNothing(Persona.telefono) Then
        Else
            For index As Integer = 0 To Persona.telefono.Count - 1
                ListView2.Items.Add(Persona.telefono(index))
            Next
        End If
        bool = False
    End Sub
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Dim btActualizar = Actualizar
        btActualizar.Enabled = False
        Try
            cedula = BACiP.Text
        Catch ex As Exception
            Throw ex
        End Try
        BuscarP(cedula)
    End Sub
    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Try
            Persona.cedula = BACiP.Text
            Persona.nombre = BANombreP.Text
            Persona.direccion = BADireccionP.Text
            logica.ActualizarPersona(Persona)
            For index As Integer = 0 To Persona.telefono.Count - 1
                If Persona.telefono(index) = -1 Then
                Else
                    logica.borrarTelefono(Persona.cedula, Persona.telefono(index))
                    logica.altaTelefono(Persona.cedula, Persona.telefono(index))
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Dim btActualizar = Actualizar
        btActualizar.Enabled = False
    End Sub
    Private Sub AddTelefono_Click(sender As Object, e As EventArgs) Handles BotonModificar.Click
        Try
            telefono = BATelefonoP.Text
            If bool = True Then
                If IsNothing(telefono) Then
                    Persona.telefono(item) = -1
                    ListView2.FocusedItem.Remove()
                Else
                    Persona.telefono(item) = telefono
                    ListView2.FocusedItem.Remove()
                    ListView2.Items.Add(Persona.telefono(item))
                End If
            End If
            If Persona.telefono.Contains(telefono) Then
                ListView2.Items.Add(telefono)
                Persona.telefono.Add(telefono)
                BATelefonoP.Text = ""
            Else
                BATelefonoP.Text = "Ya existe ese telefono"
            End If
        Catch ex As Exception
            Debug.WriteLine(ex)
            BATelefonoP.Text = "solo numeros"
        End Try
        Dim btActualizar = Actualizar
        btActualizar.Enabled = True
    End Sub

    Private Sub LVMouseClick(sender As Object, e As MouseEventArgs) Handles ListView2.MouseClick
        item = ListView2.FocusedItem.Index
        BATelefonoP.Text = Persona.telefono(item)
        bool = True
    End Sub

    Private Sub BANombreP_TextChanged(sender As Object, e As EventArgs) Handles BANombreP.TextChanged
        Dim btActualizar = Actualizar
        btActualizar.Enabled = True
    End Sub

    Private Sub BADireccionP_TextChanged(sender As Object, e As EventArgs) Handles BADireccionP.TextChanged
        Dim btActualizar = Actualizar
        btActualizar.Enabled = True
    End Sub

    Private Sub BACiP_TextChanged(sender As Object, e As EventArgs) Handles BACiP.TextChanged
        Dim btActualizar = Actualizar
        btActualizar.Enabled = True
    End Sub

    Private Sub BATelefonoP_TextChanged(sender As Object, e As EventArgs) Handles BATelefonoP.TextChanged
        Dim btActualizar = Actualizar
        btActualizar.Enabled = True
    End Sub
End Class