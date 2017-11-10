Public Class frmRelEstoque
    Dim relatorioEstoqueMinimo As New relEstoqueMinimo
    Private Sub frmRelEstoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ItemEstoqueTableAdapter1.Fill(Me.BancoDataSet1.ItemEstoque)
        relatorioEstoqueMinimo.SetDataSource(Me.BancoDataSet1)
        crvEstoque.ReportSource = relatorioEstoqueMinimo
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Me.ItemEstoqueTableAdapter1.FillByEstoqueMinimo(Me.BancoDataSet1.ItemEstoque, CInt(txtCampo.Text))
        relatorioEstoqueMinimo.SetDataSource(Me.BancoDataSet1)
        crvEstoque.ReportSource = relatorioEstoqueMinimo
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Me.ItemEstoqueTableAdapter1.Fill(Me.BancoDataSet1.ItemEstoque)
        relatorioEstoqueMinimo.SetDataSource(Me.BancoDataSet1)
        crvEstoque.ReportSource = relatorioEstoqueMinimo
    End Sub
End Class