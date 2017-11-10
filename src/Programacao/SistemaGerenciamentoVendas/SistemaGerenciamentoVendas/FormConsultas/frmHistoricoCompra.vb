Public Class frmHistoricoCompras
    Private Sub frmHistoricoCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet.ItemEstoque)
        Me.HistoricoCompraTableAdapter.Fill(Me.BancoDataSet.HistoricoCompra)
        lblQtdeRegistro.Text = HistoricoCompraDataGridView.RowCount
        Dim Width As Integer = 544
        Dim Height As Integer = 482

    End Sub
    Private Sub ItemEstoqueComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemEstoqueComboBox.TextChanged
        If ItemEstoqueComboBox.Text <> "" Then
            lblItem.Text = ItemEstoqueComboBox.SelectedValue.ToString()
            Me.HistoricoCompraBindingSource.Filter = "CodigoItemEstoque = " + ItemEstoqueComboBox.SelectedValue.ToString()
            lblQtdeRegistro.Text = HistoricoCompraDataGridView.RowCount
        End If
        If Me.HistoricoCompraTableAdapter.SomaValor(ItemEstoqueComboBox.SelectedValue).HasValue = Nothing Then
            lblValorTotal.Text = ""
        Else
            lblValorTotal.Text = Me.HistoricoCompraTableAdapter.SomaValor(ItemEstoqueComboBox.SelectedValue)
        End If
    End Sub

  

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        If (txtDataInicio.Text = "") And (txtDataFim.Text = "") Then
            MessageBox.Show("Preencha as duas Datas", "Atenção", MessageBoxButtons.OK)
        Else
            Me.HistoricoCompraTableAdapter.FillByPeriodo(Me.BancoDataSet.HistoricoCompra, CDate(txtDataInicio.Text), CDate(txtDataFim.Text))
        End If
        lblQtdeRegistro.Text = HistoricoCompraDataGridView.RowCount
        If Me.HistoricoCompraTableAdapter.SomaValor(ItemEstoqueComboBox.SelectedValue).HasValue = Nothing Then
            lblValorTotal.Text = ""
        Else
            lblValorTotal.Text = Me.HistoricoCompraTableAdapter.SomaValor(ItemEstoqueComboBox.SelectedValue)
        End If
    End Sub

    Private Sub btnLimpaFiltroCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpaFiltroCompra.Click
        Me.HistoricoCompraTableAdapter.Fill(Me.BancoDataSet.HistoricoCompra)
        removeFiltro(HistoricoCompraBindingSource)
        txtDataInicio.Text = ""
        txtDataFim.Text = ""
        lblItem.Text = ""
        lblQtdeRegistro.Text = HistoricoCompraDataGridView.RowCount
      
    End Sub

    Private Sub btnFiltroCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltroCompra.Click
        Dim formHistoricoCompra As New frmHistoricoCompras
        If Width = 544 And Height = 482 Then
            formHistoricoCompra.Size = New System.Drawing.Size(874, 482)
            Width = 874
            Height = 482
        ElseIf Width = 874 And Height = 482 Then
            formHistoricoCompra.Size = New System.Drawing.Size(544, 482)
            Width = 544
            Height = 482
        End If

    End Sub
End Class