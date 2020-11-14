Public Class LogicaTelefono
    Public Sub AltaTelefonos(persona As ClassPersona)
        Dim persistencia = New TelefonoController
        For index As Integer = 0 To persona.telefono.Count() - 1
            persistencia.altaTelefono(persona.cedula, persona.telefono(index))
        Next
    End Sub
    Public Function BuscarTelefono(ci As Integer)
        Dim persistencia = New TelefonoController
        Return persistencia.buscarTelefonos(ci)
    End Function
    Public Sub BorrarTelefono(persona As ClassPersona, index As Integer)
        Dim persistencia = New TelefonoController
        persistencia.borrarTelefono(persona.cedula, persona.telefono(index))
    End Sub
    Public Sub BorrarTelefonos(persona As ClassPersona)
        Dim persistencia = New TelefonoController
        For index As Integer = 0 To persona.telefono.Count() - 1
            persistencia.borrarTelefono(persona.cedula, persona.telefono(index))
        Next
    End Sub
End Class
