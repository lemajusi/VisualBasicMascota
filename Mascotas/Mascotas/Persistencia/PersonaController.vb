Public Class PersonaController
    Dim conection_Npg = New Npgsql.NpgsqlConnection
    Sub New()

    End Sub
    Public Sub altaPersona(personaUser As ClassPersona)
        Try
            Dim conection = New Conextion
            Dim cmd = New Npgsql.NpgsqlCommand
            conection_Npg = conection.AbrirConextion
            cmd.Connection = conection_Npg
            Dim CadenaDeComandos = "insert into persona (ci, nombre, direccion) values (@ci, @nombre, @direccion, @telefono)"
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.cedula
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 500).Value = personaUser.nombre
            cmd.Parameters.Add("@dirreccion", NpgsqlTypes.NpgsqlDbType.Varchar, 500).Value = personaUser.direccion
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Varchar, )

            Dim resultado As Integer = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Sub
End Class
