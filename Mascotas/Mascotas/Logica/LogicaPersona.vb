Public Class LogicaPersona
    Public Sub altaPersona(personaUser As ClassPersona)
        Dim persistencia = New PersonaController
        persistencia.altaPersona(personaUser)
    End Sub
    Public Sub altaTelefono(personaUser As ClassPersona)
        Dim persistencia = New PersonaController
        persistencia.altaTelefono(personaUser)
    End Sub
    Public Function buscarPersona(ci As Integer) As ClassPersona
        Dim persistencia = New PersonaController
        Return persistencia.buscarPersona(ci)
    End Function
End Class