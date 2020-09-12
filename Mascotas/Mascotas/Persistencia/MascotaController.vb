Public Class MascotaController
    Private conection_Npg = New Npgsql.NpgsqlConnection
    Private LofMascotas As New List(Of ClassMascota)
    Public Sub altaMascota(mascotaUser As ClassMascota)
        Try
            Dim conection = New Conextion
            conection_Npg = conection.AbrirConextion
            Dim CadenaDeComandos = "insert into mascota (ciP, nombre, añonacimiento) values (@ciP, @nombreM, @añoNac)"
            Dim cmd = New Npgsql.NpgsqlCommand(CadenaDeComandos)
            cmd.Connection = conection_Npg
            cmd.Parameters.Add("@ciP", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascotaUser.cedulaP
            cmd.Parameters.Add("@nombreM", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = mascotaUser.nombreM
            cmd.Parameters.Add("@añoNac", NpgsqlTypes.NpgsqlDbType.Integer).Value = mascotaUser.añoNacM
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Sub
    Public Function listarMascota(ci As Integer)
        Try
            Dim Conn As New Conextion
            conection_Npg = Conn.AbrirConextion
            Dim cadenaDeComandos = "select * from mascota where cip = @ci"
            Dim cmd = New Npgsql.NpgsqlCommand(cadenaDeComandos)
            cmd.Connection = conection_Npg
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            Dim Lector = cmd.ExecuteReader
            While Lector.Read()
                Dim Mascota = New ClassMascota
                Mascota.nombreM = Lector(1).ToString
                Mascota.añoNacM = Convert.ToInt32(Lector(2).ToString)
                LofMascotas.Add(Mascota)
            End While
            Return LofMascotas
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Function
End Class
