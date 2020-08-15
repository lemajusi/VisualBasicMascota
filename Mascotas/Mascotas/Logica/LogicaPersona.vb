Public Class LogicaPersona
    Public Sub altaPersona(personaUser As ClassPersona)
        Dim persistencia = New PersonaController
        persistencia.altaPersona(personaUser)
    End Sub

    Public Function buscarPersona(ci As Integer) As ClassPersona
        Dim persistencia = New PersonaController
        Return persistencia.buscarPersona(ci)
    End Function
    Public Function buscarTelefonos(ci As Integer) As List(Of Integer)
        Dim persistencia = New PersonaController
        Return persistencia.buscarTelefonos(ci)
    End Function
End Class