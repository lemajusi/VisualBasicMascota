Public Class ClassMascota
    Private NombreCM As String
    Private AñoNacCM As Integer
    Private CedulaPCM As Integer
    Private TipoCM As String

    Public Property nombreM As String
        Get
            Return NombreCM
        End Get
        Set(value As String)
            NombreCM = value
        End Set
    End Property
    Public Property añoNacM As Integer
        Get
            Return AñoNacCM
        End Get
        Set(value As Integer)
            AñoNacCM = value
        End Set
    End Property
    Public Property cedulaP As Integer
        Get
            Return CedulaPCM
        End Get
        Set(value As Integer)
            CedulaPCM = value
        End Set
    End Property
    Public Property TipoM As String
        Get
            Return TipoCM
        End Get
        Set(value As String)
            TipoCM = value
        End Set
    End Property
    Public Sub CrearMascota(NombreCM As String, AñoNacCM As Integer, cedulaPCM As Integer, TipoCM As String)
        Me.NombreCM = NombreCM
        Me.AñoNacCM = AñoNacCM
        Me.CedulaPCM = cedulaPCM
        Me.TipoCM = TipoCM
    End Sub
End Class
