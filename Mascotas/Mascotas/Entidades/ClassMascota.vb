Public Class ClassMascota
    Private NombreCM As String
    Private AñoNacCM As String
    Private CedulaPCM As Integer
    Public Property nombreM As String
        Get
            Return NombreCM
        End Get
        Set(value As String)
            NombreCM = value
        End Set
    End Property
    Public Property añoNacM As String
        Get
            Return AñoNacCM
        End Get
        Set(value As String)
            AñoNacCM = value
        End Set
    End Property
    Public Property cedulaP As String
        Get
            Return CedulaPCM
        End Get
        Set(value As String)
            CedulaPCM = value
        End Set
    End Property
    Public Sub CrearMascota(NombreCM As String, AñoNacCM As String, cedulaPCM As Integer)
        NombreCM = Me.NombreCM
        AñoNacCM = Me.AñoNacCM
        cedulaPCM = Me.CedulaPCM
    End Sub
End Class
