Public Class frmHistoricoVendas
    Private Sub frmHistoricoVendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet.ItemEstoque)
        Me.HistoricoVendaTableAdapter1.Fill(Me.BancoDataSet.HistoricoVenda)
        ItemEstoqueComboBox.Text = ""
        Label10.Text = HistoricoVendaDataGridView.RowCount - 1
        Dim Width As Integer = 532
        Dim Height As Integer = 541
    End Sub
    Private Sub btnFiltroCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltroCompra.Click
        If (txtDataInicioCompra.Text = "") And (txtDataFimCompra.Text = "") Then
            MessageBox.Show("Preencha as duas Datas", "Atenção", MessageBoxButtons.OK)
        Else
            Me.HistoricoVendaTableAdapter1.FillByPeriodo(Me.BancoDataSet.HistoricoVenda, CDate(txtDataInicioCompra.Text), CDate(txtDataFimCompra.Text))
        End If
        Label10.Text = HistoricoVendaDataGridView.RowCount - 1
    End Sub

    Private Sub btnLimpaFiltroCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpaFiltroCompra.Click
        Me.HistoricoVendaTableAdapter1.Fill(Me.BancoDataSet.HistoricoVenda)
        removeFiltro(HistoricoVendaBindingSource)
        txtDataInicioCompra.Text = ""
        txtDataFimCompra.Text = ""

        ItemEstoqueComboBox.Text = ""
        lblnItem.Text = ""
        Label10.Text = HistoricoVendaDataGridView.RowCount - 1
    End Sub

    Private Sub ItemEstoqueComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemEstoqueComboBox.TextChanged
        If ItemEstoqueComboBox.Text <> "" Then
            lblnItem.Text = ItemEstoqueComboBox.SelectedValue.ToString()
            HistoricoVendaBindingSource.Filter = "CodigoItemEstoque = " + ItemEstoqueComboBox.SelectedValue.ToString()
        End If
        Label10.Text = HistoricoVendaDataGridView.RowCount - 1
    End Sub

  
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim formHistoricoVendas As New frmHistoricoVendas
        If Width = 532 And Height = 541 Then
            formHistoricoVendas.Size = New System.Drawing.Size(854, 541)
            Width = 854
            Height = 541
        ElseIf Width = 854 And Height = 541 Then
            formHistoricoVendas.Size = New System.Drawing.Size(532, 541)
            Width = 532
            Height = 541
        End If
    End Sub
End Class