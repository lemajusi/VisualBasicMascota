Public Class LogicaPersona
    Public Sub altaPersona(personaUser As ClassPersona)
        Dim persistencia = New PersonaController
        persistencia.altaPersona(personaUser)
    End Sub
    Public Function chequearCi(ci As Integer)
        Dim persistencia = New PersonaController
        Return persistencia.chequearCI(ci)
    End Function
    Public Function buscarPersona(ci As Integer)
        Dim persistencia = New PersonaController
        Return persistencia.buscarPersona(ci)
    End Function
    Public Function buscarTelefonos(ci As Integer)
        Dim persistencia = New PersonaController
        Return persistencia.buscarTelefonos(ci)
    End Function
    Public Function TodasLasPersonas()
        Dim persistencia = New PersonaController
        Return persistencia.TodasLasPersonas
    End Function
    Public Sub borrarPersona(ci As Integer)
        Dim persistencia = New PersonaController
        persistencia.borrarPersona(ci)
    End Sub
    Public Sub borrarTelefono(ci As Integer, telefono As Integer)
        Dim persistencia = New PersonaController
        persistencia.borrarTelefono(ci, telefono)
    End Sub
End Class