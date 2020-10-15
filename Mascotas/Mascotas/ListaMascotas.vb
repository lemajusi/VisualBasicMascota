Public Class Lista_Mascotas
    Dim lisMascotas As New List(Of ClassMascota)
    Dim persona As New ClassPersona
    Public Sub Listar(ci As Integer)
        LVMascotas.Items.Clear()
        LVPersona.Items.Clear()
        Dim logica As New LogicaMascota
        lisMascotas = logica.listarMascotas(ci)
        Dim mascotasarray(3) As String
        Dim personaarray(2) As String
        For index As Integer = 0 To lisMascotas.Count - 1
            mascotasarray(0) = lisMascotas(index).nombreM
            mascotasarray(1) = lisMascotas(index).añoNacM
            mascotasarray(2) = lisMascotas(index).TipoM
            Dim item = New ListViewItem(mascotasarray)
            LVMascotas.Items.Add(item)
        Next
        Dim logicaP As New LogicaPersona
        persona = logicaP.chequearCi(ci)
        If IsNothing(persona.cedula) Then
        Else
            personaarray(0) = persona.cedula
            personaarray(1) = persona.nombre
            Dim item = New ListViewItem(personaarray)
            LVPersona.Items.Add(item)
        End If

    End Sub
End Class