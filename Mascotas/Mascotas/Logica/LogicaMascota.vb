Public Class LogicaMascota
    Public Sub altaMascota(mascotaUser As ClassMascota)
        Dim persistencia = New MascotaController
        persistencia.altaMascota(mascotaUser)
    End Sub
End Class
