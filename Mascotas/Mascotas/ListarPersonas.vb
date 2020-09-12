Public Class ListarPersonas
    Private LofPersonas As List(Of ClassPersona)
    Private LofTelefonos As List(Of Integer)
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
            LofTelefonos = logica.buscarTelefonos(LofPersonas(LVindex).cedula)
            ListView2.Items.Clear()
            For index As Integer = 0 To LofTelefonos.Count - 1
                ListView2.Items.Add(LofTelefonos(index))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BorrarPersona_Click(sender As Object, e As EventArgs) Handles BorrarPersona.Click
        Try
            Dim LVindex = ListView1.FocusedItem.Index
            Dim logica = New LogicaPersona
            logica.borrarPersona(LofPersonas(LVindex).cedula)
            If IsNothing(LofTelefonos) Then
            Else
                For index As Integer = 0 To LofTelefonos.Count - 1
                    logica.borrarTelefono(LofPersonas(LVindex).cedula, LofTelefonos(index))
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub BorrarTelefono_Click(sender As Object, e As EventArgs) Handles BorrarTelefono.Click
        Try
            Dim LV1index = ListView1.FocusedItem.Index
            Dim LV2index = ListView2.FocusedItem.Index
            Dim logica = New LogicaPersona
            logica.borrarTelefono(LofPersonas(LV1index).cedula, LofTelefonos(LV2index))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class