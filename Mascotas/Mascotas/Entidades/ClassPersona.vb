Public Class ClassPersona
    Private nombreCP As String
    Private direccionCP As String
    Private telefonoCP As String
    Private cedulaCP As String


    Public Property nombre As String
        Get
            Return nombreCP
        End Get
        Set(value As String)
            nombreCP = value
        End Set
    End Property
    Public Property direccion As String
        Get
            Return direccionCP
        End Get
        Set(value As String)
            direccionCP = value
        End Set
    End Property
    Public Property telefono As String
        Get
            Return telefonoCP
        End Get
        Set(value As String)
            telefonoCP = value
        End Set
    End Property
    Public Property cedula As String
        Get
            Return cedulaCP
        End Get
        Set(value As String)
            cedulaCP = value
        End Set
    End Property

    Public Sub CrearPersona(NombreCP As String, DireccionCP As String, TelefonoCP As String, CedulaCP As String)
        NombreCP = Me.nombreCP
        DireccionCP = Me.direccionCP
        TelefonoCP = Me.telefonoCP
        CedulaCP = Me.cedulaCP
    End Sub
End Class
