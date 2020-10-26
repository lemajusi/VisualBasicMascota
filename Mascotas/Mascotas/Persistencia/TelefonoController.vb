Public Class TelefonoController
    Private conection_Npg = New Npgsql.NpgsqlConnection
    Private ListaTelefonos = New List(Of Integer)
    Public Sub altaTelefono(cedula As Integer, telefono As Integer)
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
            ConexionClose()
        End Try
    End Sub
    Public Function buscarTelefonos(ci As Integer)
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
            ConexionClose()
        End Try
    End Function
    Public Sub borrarTelefono(ci As Integer, telefono As Integer)
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
            ConexionClose()
        End Try
    End Sub

    Private Sub ConexionClose()
        conection_Npg.close
    End Sub

    Public Sub borrarTelefonos()

    End Sub
End Class
