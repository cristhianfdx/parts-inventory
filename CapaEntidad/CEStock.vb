
Public Class CEStock

    Private _IdStock As Integer
    Private _Cantidad As Integer
    Private _FechaIng As Date
    Private _FechaSal As Date
    Private _Ubicacion As String
    Private _RepuestoId As Integer

    Public Property IdStock As Integer
        Get
            Return _IdStock
        End Get
        Set(ByVal value As Integer)
            _IdStock = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property FechaIngreso As Date
        Get
            Return _FechaIng
        End Get
        Set(ByVal value As Date)
            _FechaIng = value
        End Set
    End Property

    Public Property FechaSalida As Date
        Get
            Return _FechaSal
        End Get
        Set(ByVal value As Date)
            _FechaSal = value
        End Set
    End Property

    Public Property Ubicacion As String
        Get
            Return _Ubicacion
        End Get
        Set(ByVal value As String)
            _Ubicacion = value
        End Set
    End Property

    Public Property RepuestoId As Integer
        Get
            Return _RepuestoId
        End Get
        Set(ByVal value As Integer)
            _RepuestoId = value
        End Set
    End Property

End Class
