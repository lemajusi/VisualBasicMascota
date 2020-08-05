Public Class Conextion
    Public Function AbrirConextion() As Npgsql.NpgsqlConnection
        Dim conexion_pg As Npgsql.NpgsqlConnection
        Try
            conexion_pg = New Npgsql.NpgsqlConnection()
            Dim CadenaDeConexion As String
            CadenaDeConexion = "server=127.0.0.1;port=5432;user id='postgres';password='root';Database=Veterinaria"

            conexion_pg.ConnectionString = CadenaDeConexion
            conexion_pg.Open()

        Catch ex As Exception
            Throw ex
        End Try
        Return conexion_pg
    End Function
End Class
