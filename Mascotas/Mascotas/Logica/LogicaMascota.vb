Public Class LogicaMascota
    Public Sub AltaMascota(mascotaUser As ClassMascota)
        Dim persistencia = New MascotaController
        persistencia.altaMascota(mascotaUser)
    End Sub
    Public Function ListarMascotas(ci As Integer)
        Dim persistencia = New MascotaController
        Return persistencia.listarMascota(ci)
    End Function
    Public Sub BajaMascotas(ci As Integer)
        Dim persistencia = New MascotaController
        persistencia.BajaMascotas(ci)
    End Sub
    Public Function BuscarMascota(ci As Integer, nombre As String)
        Dim persistencia = New MascotaController
        Return persistencia.BuscarMascota(ci, nombre)
    End Function
    Public Sub UpdateMascota(ci As Integer, nombre As String, añoNac As Integer)
        Dim persistencia = New MascotaController
        persistencia.UpdateMascota(ci, nombre, añoNac)
    End Sub
End Class
