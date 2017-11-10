Public Class Form1
    Dim relatorioClientes As New relClientes
    Dim relatorioEstoqueMinimo As New relEstoqueMinimo
    Dim relatorioHistoricoCompra As New relGraHistoricoCompra
    Dim relatorioHistoricoVenda As New relGraHistoricoVenda
    Dim relatorioGraPagamentoVenda As New relGraPagamentoVendas
    Dim relatorioVendas As New relVendas

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet.ItemEstoque)
        SplitContainer1.SplitterDistance = 257
        TabControl1.Enabled = False
        TreeView1.ExpandAll()
    End Sub
    
  Private Sub ItemEstoqueBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ItemEstoqueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
    End Sub
    Private Sub btnConsultarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCliente.Click
        If (cbCampos.Text = "Codigo") Then
            Me.ClienteTableAdapter1.FillByRelCodigoNome(Me.BancoDataSet1.Cliente, txtParametroCliente.Text, Nothing)
            Me.CidadeTableAdapter1.Fill(Me.BancoDataSet1.Cidade)
        ElseIf (cbCampos.Text = "Nome") Then
            Me.ClienteTableAdapter1.FillByRelCodigoNome(Me.BancoDataSet1.Cliente, Nothing, txtParametroCliente.Text)
            Me.CidadeTableAdapter1.Fill(Me.BancoDataSet1.Cidade)
        End If
        relatorioClientes.SetDataSource(Me.BancoDataSet1)
        crv.ReportSource = relatorioClientes
    End Sub
   

    Private Sub btnConsultarEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarEstoque.Click
        Me.ItemEstoqueTableAdapter.FillByEstoqueMinimo(Me.BancoDataSet1.ItemEstoque, CInt(txtParametroEstoque.Text))
        relatorioEstoqueMinimo.SetDataSource(Me.BancoDataSet1)
        crv.ReportSource = relatorioEstoqueMinimo
    End Sub
   
    Private Sub btnConsultarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCompra.Click
        Me.HistoricoCompraTableAdapter.FillByRelItemEstoque(Me.BancoDataSet1.HistoricoCompra, CInt(ItemEstoqueComboBox.SelectedValue))
        Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet1.ItemEstoque)
        relatorioHistoricoCompra.SetDataSource(Me.BancoDataSet1)
        crv.ReportSource = relatorioHistoricoCompra
    End Sub
    Private Sub btnConsultarVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarVenda.Click
        Me.HistoricoVendaTableAdapter.FillByRelItemEstoque(Me.BancoDataSet1.HistoricoVenda, CInt(ItemEstoqueComboBox.SelectedValue))
        Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet1.ItemEstoque)
        relatorioHistoricoVenda.SetDataSource(Me.BancoDataSet1)
        crv.ReportSource = relatorioHistoricoVenda
    End Sub
    Private Sub btnConsultarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarPago.Click
        If rbSim.Checked = True Then
            Me.PagamentoVendaTableAdapter1.FillByPagamento(Me.BancoDataSet1.PagamentoVenda, "Sim")
        Else
            Me.PagamentoVendaTableAdapter1.FillByPagamento(Me.BancoDataSet1.PagamentoVenda, "Não")
        End If
        Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)
        relatorioGraPagamentoVenda.SetDataSource(Me.BancoDataSet1)
        crv.ReportSource = relatorioGraPagamentoVenda
    End Sub
    Private Sub btnVendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendas.Click
        Me.VendedorTableAdapter.Fill(Me.BancoDataSet1.Vendedor)
        Me.TipoPagamentoTableAdapter.Fill(Me.BancoDataSet1.TipoPagamento)
        Me.FormaPagamentoTableAdapter.Fill(Me.BancoDataSet1.FormaPagamento)

        Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet1.ItemEstoque)
        Me.ItensVendasTableAdapter.Fill(Me.BancoDataSet1.ItensVendas)
        Me.VendasTableAdapter.FillByRelVendas(Me.BancoDataSet1.Vendas, CodigoCliente)
        Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)

        relatorioVendas.SetDataSource(Me.BancoDataSet1)
        crv.ReportSource = relatorioVendas
    End Sub
    Private Sub btnLimparCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparCliente.Click
        CarregaRelatorio("Cliente")
    End Sub
    Private Sub btnLimparEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparEstoque.Click
        CarregaRelatorio("Estoque Minimo")
    End Sub
    Private Sub btnLimparCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparCompra.Click
        CarregaRelatorio("Histórico de Compra")
    End Sub
    Private Sub btnLimparVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparVenda.Click
        CarregaRelatorio("Histórico de Venda")
    End Sub
    Private Sub btnLimparPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparPago.Click
        CarregaRelatorio("Pagamento da Venda")
    End Sub
    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        CarregaRelatorio("Vendas")
    End Sub
    Public Sub CarregaRelatorio(ByVal relatorio As String)
        TabControl1.Enabled = True
        Select Case relatorio
            Case "Cliente"
                TabControl1.SelectTab(0)

                Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)
                Me.CidadeTableAdapter1.Fill(Me.BancoDataSet1.Cidade)
                relatorioClientes.SetDataSource(Me.BancoDataSet1)
                crv.ReportSource = relatorioClientes

            Case "Estoque Minimo"
                TabControl1.SelectTab(1)
                Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet1.ItemEstoque)
                relatorioEstoqueMinimo.SetDataSource(Me.BancoDataSet1)
                crv.ReportSource = relatorioEstoqueMinimo

            Case "Histórico de Compra"
                TabControl1.SelectTab(2)
                Me.HistoricoCompraTableAdapter.Fill(Me.BancoDataSet1.HistoricoCompra)
                Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet1.ItemEstoque)
                relatorioHistoricoCompra.SetDataSource(Me.BancoDataSet1)
                crv.ReportSource = relatorioHistoricoCompra

            Case "Histórico de Venda"
                TabControl1.SelectTab(3)
                Me.HistoricoVendaTableAdapter.Fill(Me.BancoDataSet1.HistoricoVenda)
                Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet1.ItemEstoque)
                relatorioHistoricoVenda.SetDataSource(Me.BancoDataSet1)
                crv.ReportSource = relatorioHistoricoVenda

            Case "Pagamento da Venda"
                TabControl1.SelectTab(4)
                Me.PagamentoVendaTableAdapter1.Fill(Me.BancoDataSet1.PagamentoVenda)
                Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)
                relatorioGraPagamentoVenda.SetDataSource(Me.BancoDataSet1)
                crv.ReportSource = relatorioGraPagamentoVenda

            Case "Vendas"
                TabControl1.SelectTab(5)

                Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)
                Me.VendedorTableAdapter.Fill(Me.BancoDataSet1.Vendedor)
                Me.TipoPagamentoTableAdapter.Fill(Me.BancoDataSet1.TipoPagamento)
                Me.FormaPagamentoTableAdapter.Fill(Me.BancoDataSet1.FormaPagamento)

                Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet1.ItemEstoque)
                Me.ItensVendasTableAdapter.Fill(Me.BancoDataSet1.ItensVendas)
                Me.VendasTableAdapter.Fill(Me.BancoDataSet1.Vendas)
                relatorioVendas.SetDataSource(Me.BancoDataSet1)
                crv.ReportSource = relatorioVendas

        End Select
    End Sub
    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        Select Case e.Node.Text
            Case "Cliente"
                CarregaRelatorio(e.Node.Text)
            Case "Estoque Minimo"
                CarregaRelatorio(e.Node.Text)
            Case "Histórico de Compra"
                CarregaRelatorio(e.Node.Text)
            Case "Histórico de Venda"
                CarregaRelatorio(e.Node.Text)
            Case "Pagamento da Venda"
                CarregaRelatorio(e.Node.Text)
            Case "Vendas"
                CarregaRelatorio(e.Node.Text)
        End Select
    End Sub
    
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ClienteComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteComboBox.TextChanged
        CodigoCliente = ClienteComboBox.SelectedValue
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub
End Class