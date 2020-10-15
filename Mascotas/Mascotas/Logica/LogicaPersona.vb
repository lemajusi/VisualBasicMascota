Public Class LogicaPersona
    'persona'
    Public Sub altaPersona(personaUser As ClassPersona)
        Dim persistencia = New PersonaController
        persistencia.altaPersona(personaUser)
        Me.altaTelefono(personaUser)
    End Sub
    Public Function chequearCi(ci As Integer)
        Dim persistencia = New PersonaController
        Return persistencia.chequearCI(ci)
    End Function
    Public Function buscarPersona(ci As Integer)
        Dim persistencia = New PersonaController
        Return persistencia.buscarPersona(ci)
    End Function
    Public Function TodasLasPersonas()
        Dim persistencia = New PersonaController
        Return persistencia.TodasLasPersonas
    End Function
    Public Sub borrarPersona(ci As Integer)
        Dim persistencia = New PersonaController
        persistencia.borrarPersona(ci)
    End Sub
    Public Sub ActualizarPersona(persona As ClassPersona)
        Dim persistencia = New PersonaController
        persistencia.actualizarPersona(persona)
    End Sub
    'telefonos'
    Public Sub altaTelefono(persona As ClassPersona)
        Dim persistencia = New TelefonoController
        For index As Integer = 0 To persona.telefono.Count() - 1
            persistencia.altaTelefono(persona.cedula, persona.telefono(index))
        Next
    End Sub
    Public Function buscarTelefono(ci As Integer)
        Dim persistencia = New TelefonoController
        Return persistencia.buscarTelefonos(ci)
    End Function
    Public Sub borrarTelefono(persona As ClassPersona, index As Integer)
        Dim persistencia = New TelefonoController
        persistencia.borrarTelefono(persona.cedula, persona.telefono(index))
    End Sub
    Public Sub borrarTelefonos(persona As ClassPersona)
        Dim persistencia = New TelefonoController
        For index As Integer = 0 To persona.telefono.Count() - 1
            persistencia.borrarTelefono(persona.cedula, persona.telefono(index))
        Next
    End Sub
End Class