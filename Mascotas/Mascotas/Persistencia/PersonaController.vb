Public Class PersonaController
    Dim conection_Npg = New Npgsql.NpgsqlConnection
    Public Sub altaPersona(personaUser As ClassPersona)
        Try
            Dim conection = New Conextion
            conection_Npg = conection.AbrirConextion
            Dim CadenaDeComandos = "insert into persona (ci, nombre, direccion) values (@ci, @nombre, @direccion, @telefono)"
            Dim cmd = New Npgsql.NpgsqlCommand(CadenaDeComandos)
            cmd.Connection = conection_Npg
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.cedula
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 500).Value = personaUser.nombre
            cmd.Parameters.Add("@dirreccion", NpgsqlTypes.NpgsqlDbType.Varchar, 500).Value = personaUser.direccion
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Varchar, 500).Value = personaUser.telefono
            Dim resultado As Integer = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Sub
End Class
