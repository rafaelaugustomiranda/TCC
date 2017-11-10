Public Class frmConEstoque
    Private Sub frmConEstoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ItemEstoqueTableAdapter.FillByEstoqueMinimo(Me.BancoDataSet.ItemEstoque, 3)
        Label10.Text = ItemEstoqueDataGridView.RowCount
    End Sub

    Private Sub txtQtde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtde.TextChanged
        If txtQtde.Text = "" Then
            Me.ItemEstoqueTableAdapter.FillByEstoqueMinimo(Me.BancoDataSet.ItemEstoque, 3)
            Label10.Text = ItemEstoqueDataGridView.RowCount
        Else
            Me.ItemEstoqueTableAdapter.FillByEstoqueMinimo(Me.BancoDataSet.ItemEstoque, CInt(txtQtde.Text))
            Label10.Text = ItemEstoqueDataGridView.RowCount
        End If
    End Sub
End Class