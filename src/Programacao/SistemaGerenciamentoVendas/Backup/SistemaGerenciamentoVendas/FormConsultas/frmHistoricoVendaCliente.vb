Imports System.Data.SqlClient
Public Class frmHistoricoVendaCliente
    Private Sub frmHistoricoVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If CodigoCliente <> Nothing Then
            Me.VendasTableAdapter.FillByVendas(Me.BancoDataSet.Vendas, CodigoCliente)
            lblCodigo.Text = CodigoCliente
        End If

        'BancoDataSet.EnforceConstraints = True

    End Sub
    Private Sub lblCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCodigo.TextChanged
        Dim sql As String = "Select CodigoCliente, Nome from Cliente Where CodigoCliente = @CodigoCliente"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)
        Dim reader As SqlDataReader

        Comando.Parameters.Clear()

        Comando.Parameters.AddWithValue("@CodigoCliente", CodigoCliente)
        Conexao.Open()

        reader = Comando.ExecuteReader()
        reader.Read()

        lblNome.Text = reader(1).ToString()
        reader.Close()
        Conexao.Close()

    End Sub

    Private Sub CodigoVendaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoVendaTextBox.TextChanged
        If CodigoVendaTextBox.Text <> "" Then
            Me.ItensVendasTableAdapter.FillByItensVendas(Me.BancoDataSet.ItensVendas, CodigoVendaTextBox.Text)
        End If
    End Sub
End Class