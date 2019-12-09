Public Class CEMarca
    'Atributos
    Private _idMarca As Integer
    Private _descripcion As String

    Public Property IdMarca As Integer
        Get
            Return _idMarca
        End Get
        Set(ByVal value As Integer)
            _idMarca = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
End Class
