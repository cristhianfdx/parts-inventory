Public Class CERepuesto

    'Atributos'
    Private _idRepuesto As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _imagen As String
    Private _marcaId As Integer
    Private _usuarioId As Integer
    Private _stockId As Integer
    Private _tipoId As Integer

    'Getters y Setters'

    Public Property IdRepuesto As Integer
        Get
            Return _idRepuesto
        End Get
        Set(ByVal value As Integer)
            _idRepuesto = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
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

    Public Property Imagen As String
        Get
            Return _imagen
        End Get
        Set(ByVal value As String)
            _imagen = value
        End Set
    End Property

    Public Property MarcaId As Integer
        Get
            Return _marcaId
        End Get
        Set(ByVal value As Integer)
            _marcaId = value
        End Set
    End Property

    Public Property UsuarioId As Integer
        Get
            Return _usuarioId
        End Get
        Set(ByVal value As Integer)
            _usuarioId = value
        End Set
    End Property

    Public Property StockId As Integer
        Get
            Return _stockId
        End Get
        Set(ByVal value As Integer)
            _stockId = value
        End Set
    End Property

    Public Property TipoId As Integer
        Get
            Return _tipoId
        End Get
        Set(ByVal value As Integer)
            _tipoId = value
        End Set
    End Property

End Class
