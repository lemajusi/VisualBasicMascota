Public Class MascotaController
    Private conection_Npg = New Npgsql.NpgsqlConnection
    Private LofMascotas As New List(Of ClassMascota)
    Public Sub AltaMascota(mascotaUser As ClassMascota)
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
            ConnEnd()
        End Try
    End Sub
    Public Function ListarMascota(ci As Integer)
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
            ConnEnd()
        End Try
    End Function
    Public Sub BajaMascotas(ci As Integer)
        Try
            Dim Conn = New Conextion
            conection_Npg = Conn.AbrirConextion
            Dim cadenaDeComandos = "delete * from mascota where cip = @ci"
            Dim cmd = New Npgsql.NpgsqlCommand(cadenaDeComandos)
            cmd.Connection = conection_Npg
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            ConnEnd()
        End Try
    End Sub
    Public Function BuscarMascota(ci As Integer, nombre As String)
        Dim Mascota As New ClassMascota
        Try
            Dim Conn As New Conextion
            conection_Npg = Conn.AbrirConextion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection_Npg

            Dim cadenaDeComandos = "select * from mascota where cip = @ci and nombre = @nombre"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = ci

            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            If Lector.HasRows Then
                Lector.Read()
                Mascota.nombreM = Lector(1).ToString
                Mascota.añoNacM = Convert.ToInt32(Lector(2).ToString)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            ConnEnd()
        End Try
        Return Mascota
    End Function

    Public Function UpdateMascota(ci As Integer, nombre As String, añonac As Integer)
        Dim Mascota As New ClassMascota
        Try
            Dim Conn As New Conextion
            conection_Npg = Conn.AbrirConextion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection_Npg

            Dim cadenaDeComandos = "Update mascota set nombre=@nombre añonacimiento= @añonac where cip= @ci"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = nombre
            cmd.Parameters.Add("@añonac", NpgsqlTypes.NpgsqlDbType.Integer).Value = añonac
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            ConnEnd()
        End Try
        Return Mascota
    End Function

    Private Sub ConnEnd()
        conection_Npg.close
    End Sub
End Class
