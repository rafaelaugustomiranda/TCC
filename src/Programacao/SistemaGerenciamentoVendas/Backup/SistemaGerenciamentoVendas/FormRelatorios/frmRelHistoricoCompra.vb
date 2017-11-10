Public Class frmRelHistoricoCompra
    Dim relatorioHistoricoCompra As New relGraHistoricoCompra
    Private Sub frmRelHistoricoCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.HistoricoCompraTableAdapter1.Fill(Me.BancoDataSet1.HistoricoCompra)
        Me.ItemEstoqueTableAdapter1.Fill(Me.BancoDataSet1.ItemEstoque)
        relatorioHistoricoCompra.SetDataSource(Me.BancoDataSet1)
        crvHistoricoCompra.ReportSource = relatorioHistoricoCompra

    End Sub

    Private Sub ItemEstoqueBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ItemEstoqueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet1)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Me.HistoricoCompraTableAdapter1.FillByRelItemEstoque(Me.BancoDataSet1.HistoricoCompra, CInt(ItemEstoqueComboBox.SelectedValue))
        Me.ItemEstoqueTableAdapter1.Fill(Me.BancoDataSet1.ItemEstoque)
        relatorioHistoricoCompra.SetDataSource(Me.BancoDataSet1)
        crvHistoricoCompra.ReportSource = relatorioHistoricoCompra

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Me.HistoricoCompraTableAdapter1.Fill(Me.BancoDataSet1.HistoricoCompra)
        Me.ItemEstoqueTableAdapter1.Fill(Me.BancoDataSet1.ItemEstoque)
        relatorioHistoricoCompra.SetDataSource(Me.BancoDataSet1)
        crvHistoricoCompra.ReportSource = relatorioHistoricoCompra
    End Sub
End Class