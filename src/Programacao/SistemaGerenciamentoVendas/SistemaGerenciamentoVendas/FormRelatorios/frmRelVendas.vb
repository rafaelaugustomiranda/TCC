Public Class frmRelVendas
    Dim relatorioVendas As New relVendas
    Private Sub frmRelVendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)
        Me.VendedorTableAdapter1.Fill(Me.BancoDataSet1.Vendedor)
        Me.TipoPagamentoTableAdapter1.Fill(Me.BancoDataSet1.TipoPagamento)
        Me.FormaPagamentoTableAdapter1.Fill(Me.BancoDataSet1.FormaPagamento)

        Me.ItemEstoqueTableAdapter1.Fill(Me.BancoDataSet1.ItemEstoque)
        Me.ItensVendasTableAdapter1.Fill(Me.BancoDataSet1.ItensVendas)
        Me.VendasTableAdapter1.Fill(Me.BancoDataSet1.Vendas)
        relatorioVendas.SetDataSource(Me.BancoDataSet1)
        crvHistoricoVenda.ReportSource = relatorioVendas

        ClienteComboBox.Text = ""
    End Sub

    Private Sub crvHistoricoVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvHistoricoVenda.Load

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        Me.VendedorTableAdapter1.Fill(Me.BancoDataSet1.Vendedor)
        Me.TipoPagamentoTableAdapter1.Fill(Me.BancoDataSet1.TipoPagamento)
        Me.FormaPagamentoTableAdapter1.Fill(Me.BancoDataSet1.FormaPagamento)

        Me.ItemEstoqueTableAdapter1.Fill(Me.BancoDataSet1.ItemEstoque)
        Me.ItensVendasTableAdapter1.Fill(Me.BancoDataSet1.ItensVendas)
        Me.VendasTableAdapter1.FillByRelVendas(Me.BancoDataSet1.Vendas, CodigoCliente)
        Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)

        relatorioVendas.SetDataSource(Me.BancoDataSet1)
        crvHistoricoVenda.ReportSource = relatorioVendas
        ClienteComboBox.Text = ""
    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet1)

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)
        Me.VendedorTableAdapter1.Fill(Me.BancoDataSet1.Vendedor)
        Me.TipoPagamentoTableAdapter1.Fill(Me.BancoDataSet1.TipoPagamento)
        Me.FormaPagamentoTableAdapter1.Fill(Me.BancoDataSet1.FormaPagamento)

        Me.ItemEstoqueTableAdapter1.Fill(Me.BancoDataSet1.ItemEstoque)
        Me.ItensVendasTableAdapter1.Fill(Me.BancoDataSet1.ItensVendas)
        Me.VendasTableAdapter1.Fill(Me.BancoDataSet1.Vendas)
        relatorioVendas.SetDataSource(Me.BancoDataSet1)
        crvHistoricoVenda.ReportSource = relatorioVendas
    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet1)

    End Sub
    Private Sub ClienteComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteComboBox.TextChanged
        CodigoCliente = ClienteComboBox.SelectedValue
    End Sub
End Class