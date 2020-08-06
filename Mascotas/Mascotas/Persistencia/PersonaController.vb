Public Class PersonaController
    Dim conection_Npg = New Npgsql.NpgsqlConnection
    Public Sub altaPersona(personaUser As ClassPersona)
        Try
            Dim conection = New Conextion
            conection_Npg = conection.AbrirConextion
            Dim CadenaDeComandos = "insert into persona (ci, nombre, direccion) values (@ci, @nombre, @direccion)"
            Dim cmd = New Npgsql.NpgsqlCommand(CadenaDeComandos)
            cmd.Connection = conection_Npg
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.cedula
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaUser.nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaUser.direccion
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Sub
    Public Sub altaTelefono(personaUser As ClassPersona)
        Try
            Dim conection = New Conextion
            conection_Npg = conection.AbrirConextion
            Dim CadenaDeComandos = "insert into Telefono (cip,telefono) values (@ciP,@telefono);"
            Dim cmd = New Npgsql.NpgsqlCommand(CadenaDeComandos)
            cmd.Connection = conection_Npg
            cmd.Parameters.Add("@ciP", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.cedula
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.telefono
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Sub
    Public Function buscarPersona(ci As Integer) As ClassPersona
        Try
            Dim Persona As New ClassPersona
            Dim ClaseSnl As New Conextion
            conection_Npg = ClaseSnl.AbrirConextion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection_Npg

            Dim cadenaDeComandos = "select * from persona where ci = @ci"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            If Lector.HasRows Then
                Lector.Read()
                Persona.cedula = Convert.ToInt32(Lector(0).ToString)
                Persona.nombre = Lector(1).ToString
                Persona.direccion = Lector(2).ToString
            End If
            If Persona.nombre = "" And Persona.direccion = "" Then
            Else
                Return Persona
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Function
End Class
