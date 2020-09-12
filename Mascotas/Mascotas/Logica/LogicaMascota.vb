Public Class LogicaMascota
    Public Sub altaMascota(mascotaUser As ClassMascota)
        Dim persistencia = New MascotaController
        persistencia.altaMascota(mascotaUser)
    End Sub
    Public Function listarMascotas(ci As Integer)
        Dim persistencia = New MascotaController
        Return persistencia.listarMascota(ci)
    End Function
End Class
