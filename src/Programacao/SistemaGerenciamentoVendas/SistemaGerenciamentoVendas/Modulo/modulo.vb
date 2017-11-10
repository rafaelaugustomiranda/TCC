Imports System.Data.SqlClient
Module modulo
    Public CodigoCliente, CodigoVenda As Integer
    Public Nome, Endereco, RG, CPF, Telefone As String
    Public StringConexao As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Banco;Integrated Security=True"
    Public DataVenda As Date
    '==================VARIAVEIS PARA OS RELATORIOS==========================
    Public tipoRel, nomeRel As String
    Public codigoRel As Integer
    Public estoqueMinimoRel As Integer
    Public dataInicioRel, dataFimRel As String
    Public codigoItemRel As Integer
    Public usuario As String
    Public Sub removeFiltro(ByVal bs As BindingSource)
        bs.RemoveFilter()
    End Sub
    Public Sub InserePagamentoVendas(ByVal CodigoVenda, ByVal CodigoCliente, ByVal NumeroDaParcela, ByVal Parcela, ByVal Data)
        Dim sql As String = "Insert into PagamentoVenda(CodigoVenda, CodigoCliente, NumerodaParcela, Valor, DataDoPagamento, Pago)Values(@CodigoVenda, @CodigoCliente, @NumerodaParcela, @Valor, @Data, @Pago)"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)

        Comando.Parameters.Clear()
        Conexao.Open()
        Comando.Parameters.Clear()
        Comando.Parameters.AddWithValue("@CodigoVenda", CodigoVenda)
        Comando.Parameters.AddWithValue("@CodigoCliente", CodigoCliente)
        Comando.Parameters.AddWithValue("@NumerodaParcela", NumeroDaParcela)
        Comando.Parameters.AddWithValue("@Valor", CDec(Parcela))
        Comando.Parameters.AddWithValue("@Data", CDate(Data))
        Comando.Parameters.AddWithValue("@Pago", "Não")
        Comando.ExecuteNonQuery()
        Conexao.Close()

    End Sub

    Public Sub AtualizaEstoque(ByVal BancoDataSet As DataSet, ByVal dia As String, ByVal mes As String, ByVal ano As String)
        '========================= FAZ UMA BUSCA NA TABELA DE================================================
        '==================ITENS DE VENDA DE ACORDO COM O CODIGO=============================================
        Dim ItemEstoqueRow() As Data.DataRow
        Dim sql As String = "Select CodigoItemEstoque, Quantidade From ItensVendas Where CodigoVenda = @CodigoVenda"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)
        Dim reader As SqlDataReader


        Conexao.Open()
        Comando.Parameters.AddWithValue("@CodigoVenda", CodigoVenda)
        reader = Comando.ExecuteReader()
        While reader.Read()

            '==================== AQUI DA BAIXA NO ESTOQUE =================================================================
            '=================== E INSERE A DATA DA ULTIMA VENDA ===========================================================
            ItemEstoqueRow = BancoDataSet.Tables("ItemEstoque").Select("CodigoItemEstoque = '" + reader(0).ToString() + "'")
            ItemEstoqueRow(0)("EstoqueDisponivel") = ItemEstoqueRow(0)("EstoqueDisponivel") - reader(1).ToString()
            ItemEstoqueRow(0)("VendasMes") = ItemEstoqueRow(0)("VendasMes") + reader(1).ToString()
            ItemEstoqueRow(0)("DataUltimaVenda") = dia + "/" + mes + "/" + ano

        End While

        reader.Close()
        Conexao.Close()
    End Sub
  Public Function QtdePermitidaVenda(ByVal BancoDataSet As DataSet, ByVal CodigoItemEstoque As Integer, ByVal Quantidade As Integer) As Boolean

        Dim ItemEstoqueRow() As Data.DataRow

        ItemEstoqueRow = BancoDataSet.Tables("ItemEstoque").Select("CodigoItemEstoque = '" + CodigoItemEstoque.ToString() + "'")
        If Quantidade > ItemEstoqueRow(0)("EstoqueDisponivel") Then
            MessageBox.Show("Quantidade Indisponivel no Momento" + vbNewLine + "Quantidade em estoque = " + ItemEstoqueRow(0)("EstoqueDisponivel").ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            QtdePermitidaVenda = True
        End If

    End Function
    Public Sub colorirGrigPagamento(ByVal Grid As DataGridView, ByVal data As String, ByVal Dataset As DataSet)
        Dim estiloCelula As New DataGridViewCellStyle()

        estiloCelula.BackColor = Color.Red
        estiloCelula.ForeColor = Color.White
        estiloCelula.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)

        For c As Integer = 0 To 9
            For r As Integer = 0 To Grid.Rows.Count - 1
                If CDate(Dataset.Tables("PagamentoVenda").Rows(r).Item("DataDoPagamento").ToString()) < data Then
                    Grid.Item(c, r).Style = estiloCelula
                End If
            Next r
        Next c
    End Sub
    Public Sub DeletaItensVenda(ByVal CodigoVenda As Integer)
        Dim sql As String = "Delete from ItensVendas Where CodigoVenda = @CodigoVenda"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)

        Comando.Parameters.Clear()
        Comando.Parameters.AddWithValue("@CodigoVenda", CodigoVenda)
        Conexao.Open()

        Comando.ExecuteNonQuery()

        Conexao.Close()
    End Sub
End Module
