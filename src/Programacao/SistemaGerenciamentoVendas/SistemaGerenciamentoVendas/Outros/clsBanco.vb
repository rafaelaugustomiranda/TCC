Imports System.Data.SqlClient
Public Class clsBanco
    Public con As New SqlConnection
    Public Function ConectaBanco() As Boolean
        Try
            If con.State <> ConnectionState.Open Then
                con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=locadoraWeb;Integrated Security=True"
                con.Open()
            Else
                con.Close()
                con.Open()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function DesconectaBanco() As Boolean
        Try
            con.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
