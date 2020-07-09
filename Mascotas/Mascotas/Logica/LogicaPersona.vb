Public Class LogicaPersona
    Public Sub altaPersona(personaUser As ClassPersona)
        Dim persistencia = New PersonaController
        persistencia.altaPersona(personaUser)
    End Sub
End Class
