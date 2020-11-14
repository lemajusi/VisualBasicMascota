Public Class LogicaPersona
    'persona'
    Public Sub AltaPersona(personaUser As ClassPersona)
        Dim persistencia = New PersonaController
        persistencia.altaPersona(personaUser)
    End Sub
    Public Function ChequearCi(ci As Integer)
        Dim persistencia = New PersonaController
        Return persistencia.chequearCI(ci)
    End Function
    Public Function BuscarPersona(ci As Integer)
        Dim persistencia = New PersonaController
        Return persistencia.buscarPersona(ci)
    End Function
    Public Function TodasLasPersonas()
        Dim persistencia = New PersonaController
        Return persistencia.TodasLasPersonas
    End Function
    Public Sub BorrarPersona(ci As Integer)
        Dim persistencia = New PersonaController
        persistencia.borrarPersona(ci)
    End Sub
    Public Sub ActualizarPersona(persona As ClassPersona)
        Dim persistencia = New PersonaController
        persistencia.actualizarPersona(persona)
    End Sub
End Class