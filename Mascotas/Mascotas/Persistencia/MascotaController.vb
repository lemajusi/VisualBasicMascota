Public Class MascotaController
    Dim conection_Npg = New Npgsql.NpgsqlConnection
    Public Sub altaMascota(mascotaUser As ClassMascota)
        Try
            Dim conection = New Conextion
            conection_Npg = conection.AbrirConextion
            Dim CadenaDeComandos = "insert into mascota (ciP, nombreM, añoNac) values (@ciP, @nombreM, @añoNac)"
            Dim cmd = New Npgsql.NpgsqlCommand(CadenaDeComandos)
            cmd.Connection = conection_Npg
            cmd.Parameters.Add("@ciP", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascotaUser.cedulaP
            cmd.Parameters.Add("@nombreM", NpgsqlTypes.NpgsqlDbType.Varchar).Value = mascotaUser.nombreM
            cmd.Parameters.Add("@añoNac", NpgsqlTypes.NpgsqlDbType.Varchar).Value = mascotaUser.añoNacM
            Dim resultado As Integer = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Sub
End Class
