Public Class PersonaController
    Private conection_Npg = New Npgsql.NpgsqlConnection
    Sub altaPersona(personaUser As ClassPersona)
        Try
            Dim Conn = New Conextion
            conection_Npg = Conn.AbrirConextion
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

    Function chequearCI(ci As Integer)
        Try
            Dim Conn As New Conextion
            Dim cmd = New Npgsql.NpgsqlCommand
            conection_Npg = Conn.AbrirConextion
            cmd.Connection = conection_Npg

            Dim cadenadecomandos = "select * from persona where ci = @ci"

            cmd.CommandText = cadenadecomandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            Dim persona As New ClassPersona
            If Lector.Read() Then
                persona.cedula = Convert.ToInt32(Lector(0).ToString)
                persona.nombre = Lector(1).ToString
            End If
            Return persona
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Function
    Function buscarPersona(ci As Integer)
        Try
            Dim Persona As New ClassPersona
            Dim Conn As New Conextion
            conection_Npg = Conn.AbrirConextion
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
                Return Persona
            Else
                Return Persona
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Function

    Function TodasLasPersonas() As List(Of ClassPersona)
        Try
            Dim array As New List(Of ClassPersona)
            Dim Conn As New Conextion
            conection_Npg = Conn.AbrirConextion
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = conection_Npg
            Dim cadenaDeComandos = "select * from persona"
            cmd.CommandText = cadenaDeComandos
            Dim Lector = cmd.ExecuteReader
            While Lector.Read
                Dim Persona = New ClassPersona
                Persona.cedula = Convert.ToInt32(Lector(0).ToString)
                Persona.nombre = Lector(1).ToString
                Persona.direccion = Lector(2).ToString
                array.Add(Persona)
            End While
            Return array
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Function
    Sub borrarPersona(ci As Integer)
        Try
            Dim Persona As New ClassPersona
            Dim Conn = New Conextion
            conection_Npg = Conn.AbrirConextion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection_Npg
            Persona.cedula = ci
            Dim cadenaDeComandos = "delete from persona where ci = @ci"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = Persona.cedula
            Dim Lector = cmd.ExecuteReader
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Sub

    Sub actualizarPersona(Persona As ClassPersona)
        Try
            Dim Conn = New Conextion
            conection_Npg = Conn.AbrirConextion
            Dim cadenaDeComandos = "update persona set nombre=@nombre,direccion=@direccion where ci=@ci"
            Dim cmd = New Npgsql.NpgsqlCommand(cadenaDeComandos)

            cmd.Connection = conection_Npg
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Persona.nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Persona.direccion
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = Persona.cedula
            cmd.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Sub
End Class
