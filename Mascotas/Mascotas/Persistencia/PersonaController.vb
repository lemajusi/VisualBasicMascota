Public Class PersonaController
    Private Dim conection_Npg = New Npgsql.NpgsqlConnection
    Private ListaTelefonos = New List(Of Integer)
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
            For index As Integer = -1 + 1 To personaUser.telefono.Count() - 1
                altaTelefono(personaUser.cedula, personaUser.telefono(index))
            Next
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Sub
    Sub altaTelefono(cedula As Integer, telefono As Integer)
        Try
            Dim Conn = New Conextion
            conection_Npg = Conn.AbrirConextion
            Dim CadenaDeComandos = "insert into Telefono (cip,telefono) values (@ciP,@telefono);"
            Dim cmd = New Npgsql.NpgsqlCommand(CadenaDeComandos)
            cmd.Connection = conection_Npg
            cmd.Parameters.Add("@ciP", NpgsqlTypes.NpgsqlDbType.Integer).Value = cedula
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefono
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
            Dim cedula As Integer
            Dim a As Boolean
            If Lector.Read() Then
                cedula = Convert.ToInt32(Lector(0).ToString)
            End If
            If cedula = ci Then
                a = False
                Return a
            Else
                a = True
                Return a
            End If
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
    Function buscarTelefonos(ci As Integer)
        Try
            Dim Conn As New Conextion
            conection_Npg = Conn.AbrirConextion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conection_Npg

            Dim cadenaDeComandos = "select * from telefono where cip = @ci"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader
            Dim x As Integer
            While Lector.Read()
                x = Convert.ToInt32(Lector(1).ToString)
                ListaTelefonos.Add(x)
            End While
            If IsNothing(ListaTelefonos) Then
                Return ListaTelefonos
            Else
                Return ListaTelefonos
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
    Sub borrarTelefono(ci As Integer, telefono As Integer)
        Try
            Dim Conn = New Conextion
            conection_Npg = Conn.AbrirConextion
            Dim cadenaDeComandos = "delete from telefono where cip = @ci and telefono = @telefono"
            Dim cmd = New Npgsql.NpgsqlCommand(cadenaDeComandos)
            cmd.Connection = conection_Npg
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefono
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conection_Npg.close
        End Try
    End Sub
End Class
