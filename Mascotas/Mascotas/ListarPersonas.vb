﻿Public Class ListarPersonas
    Private LofPersonas As List(Of ClassPersona)
    Sub Listar()
        ListView1.Items.Clear()
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
    'botones'
    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        BLTelefono()
    End Sub
    Private Sub BorrarPersona_Click(sender As Object, e As EventArgs) Handles BorrarPersona.Click
        Try
            Dim LVindex = ListView1.FocusedItem.Index
            Dim logicat = New LogicaTelefono
            Dim logicap = New LogicaPersona
            Dim logicam = New LogicaMascota
            logicam.BajaMascotas(LofPersonas(LVindex).cedula)
            logicap.BorrarPersona(LofPersonas(LVindex).cedula)
            If IsNothing(LofPersonas(LVindex).telefono) Then
            Else
                logicat.BorrarTelefonos(LofPersonas(LVindex))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub BorrarTelefono_Click(sender As Object, e As EventArgs) Handles BorrarTelefono.Click
        Try
            Dim LV1index = ListView1.FocusedItem.Index
            Dim LV2index = ListView2.FocusedItem.Index
            Dim logica = New LogicaTelefono
            logica.borrarTelefono(LofPersonas(LV1index), LV2index)
        Catch ex As Exception
            Throw ex
        Finally
            BLTelefono()
        End Try
    End Sub
    Private Sub BLTelefono()
        Try
            Dim LVindex = ListView1.FocusedItem.Index
            Dim logica = New LogicaTelefono
            LofPersonas(LVindex).telefono = logica.buscarTelefono(LofPersonas(LVindex).cedula)
            ListView2.Items.Clear()
            For index As Integer = 0 To LofPersonas(LVindex).telefono.Count - 1
                ListView2.Items.Add(LofPersonas(LVindex).telefono(index))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Dim LVindex = ListView1.FocusedItem.Index
        BuscaryActualizar.BuscarPer(LofPersonas(LVindex).cedula)
        Me.Hide()
        BuscaryActualizar.ShowDialog()
    End Sub
    'load'
    Private Sub ListarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView2.Items.Clear()
    End Sub
End Class