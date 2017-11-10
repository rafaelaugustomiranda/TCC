Public Class frmRelHistoricoVenda
    Dim relatorioHistoricoVenda As New relGraHistoricoVenda
    Private Sub frmRelHistoricoVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.HistoricoVendaTableAdapter1.Fill(Me.BancoDataSet1.HistoricoVenda)
        Me.ItemEstoqueTableAdapter1.Fill(Me.BancoDataSet1.ItemEstoque)
        relatorioHistoricoVenda.SetDataSource(Me.BancoDataSet1)
        crvHistoricoVenda.ReportSource = relatorioHistoricoVenda
    End Sub


End Class