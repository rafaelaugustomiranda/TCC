Public Class frmRelPagamentoVendas

    Private Sub frmRelPagamentoVendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim relatorioGraPagamentoVenda As New relGraPagamentoVendas
        Me.PagamentoVendaTableAdapter1.Fill(Me.BancoDataSet1.PagamentoVenda)
        Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)
        relatorioGraPagamentoVenda.SetDataSource(Me.BancoDataSet1)
        crvPagamentoVendas.ReportSource = relatorioGraPagamentoVenda
    End Sub
End Class