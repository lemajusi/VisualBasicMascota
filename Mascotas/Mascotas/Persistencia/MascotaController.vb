Public Class MascotaController
    Dim conection_Npg = New Npgsql.NpgsqlConnection
    Public Sub altaMascota()
        Dim conection = New Conextion
        Dim cmd = New Npgsql.NpgsqlCommand
        conection_Npg = conection.AbrirConextion
        cmd.Connection = conection_Npg
        Dim CadenaDeComandos = "insert into mascota (ci, nombre, direccion) values (@ci, @nombre, @direccion, @telefono)"

    End Sub
End Class
