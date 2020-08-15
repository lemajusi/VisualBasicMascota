Public Class ClassPersona
    Private nombreCP As String
    Private direccionCP As String
    Private telefonoCP As List(Of Integer)
    Private cedulaCP As Integer


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
    Public Property telefono As List(Of Integer)
        Get
            Return telefonoCP
        End Get
        Set(value As List(Of Integer))
            telefonoCP = value
        End Set
    End Property
    Public Property cedula As Integer
        Get
            Return cedulaCP
        End Get
        Set(value As Integer)
            cedulaCP = value
        End Set
    End Property

    Public Sub CrearPersona(NombreCP As String, DireccionCP As String, TelefonoCP As List(Of Integer), CedulaCP As Integer)
        NombreCP = Me.nombreCP
        DireccionCP = Me.direccionCP
        TelefonoCP = Me.telefonoCP
        CedulaCP = Me.cedulaCP
    End Sub
End Class
