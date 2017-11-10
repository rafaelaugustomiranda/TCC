Imports System.Data.SqlClient
Public Class Soma
    Public StringConexao As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Banco;Integrated Security=True"
    Public Function SomaItem(ByVal CodigoVenda As Integer) As Decimal
        Dim Somatorio As Decimal
        Dim sql As String = "Select Valor from ItensVendas Where CodigoVenda = @CodigoVenda"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)
        Dim reader As SqlDataReader

        Conexao.Open()
        Comando.Parameters.AddWithValue("@CodigoVenda", CodigoVenda)
        reader = Comando.ExecuteReader()
        While reader.Read()
            Somatorio = Somatorio + reader(0)
        End While
        reader.Close()
        Conexao.Close()
        Conexao.Dispose()
        Return Somatorio
    End Function
End Class
