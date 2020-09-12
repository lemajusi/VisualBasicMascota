Public Class ListarPersonas
    Private LofPersonas As List(Of ClassPersona)
    Sub listar()
        Try
            Dim logica As New LogicaPersona
            LofPersonas = logica.TodasLasPersonas
            Dim array(3) As String
            For index As Integer = 0 To LofPersonas.Count - 1
                array(0) = LofPersonas(index).cedula
                array(1) = LofPersonas(index).nombre
                array(2) = LofPersonas(index).direccion
                Dim item = New ListViewItem(array)
                ListView1.Items.Add(item)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'listviem1.itemcheck anda solo con checkbox'
    'que inporta este anda bien de bien'
    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        Try
            Dim LVindex = ListView1.FocusedItem.Index
            Dim logica = New LogicaPersona
            Dim Persona As New ClassPersona
            Persona = logica.buscarTelefonos(LofPersonas(LVindex).cedula)
            ListView2.Items.Clear()

            For index As Integer = 0 To Persona.telefono.Count - 1
                ListView2.Items.Add(Persona.telefono(index))
            Next
        Catch ex As Exception

        End Try

    End Sub
End Class