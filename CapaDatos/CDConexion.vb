Imports System
Imports System.Data
Imports System.Configuration
'Imports System.Data.SqlServerCe
Imports MySql.Data.MySqlClient


Public Class CDConexion

    Dim Conexion As MySqlConnection

    Public Function ConectarDB() As MySqlConnection
        Conexion = New MySqlConnection(ConfigurationManager.ConnectionStrings("MYSQLConnectionString").ConnectionString)
        Return Conexion
    End Function

End Class
