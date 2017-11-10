Public Class frmRelatorios

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorio.Click
        If Rel1.Checked = True Then
            Dim formRelClientes As New frmRelClientes
            formRelClientes.MdiParent = My.Forms.frmMenu
            formRelClientes.Show()
        ElseIf Rel2.Checked = True Then
            Dim formRelHistoricoCompras As New frmRelHistoricoCompra
            formRelHistoricoCompras.MdiParent = My.Forms.frmMenu
            formRelHistoricoCompras.Show()
        ElseIf Rel3.Checked = True Then
            Dim formRelHistoricoVenda As New frmRelHistoricoVenda
            formRelHistoricoVenda.MdiParent = My.Forms.frmMenu
            formRelHistoricoVenda.Show()
        ElseIf rel4.Checked = True Then
            Dim formRelVendas As New frmRelVendas
            formRelVendas.MdiParent = My.Forms.frmMenu
            formRelVendas.Show()
        ElseIf rel5.Checked = True Then
            Dim formRelPagamentoVendas As New frmRelPagamentoVendas
            formRelPagamentoVendas.MdiParent = My.Forms.frmMenu
            formRelPagamentoVendas.Show()
        ElseIf rel6.Checked = True Then
            Dim formRelEstoque As New frmRelEstoque
            formRelEstoque.MdiParent = My.Forms.frmMenu
            formRelEstoque.Show()
        End If
    End Sub

    Private Sub frmRelatorios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BancoDataSet.Grupo' table. You can move, or remove it, as needed.
        Me.GrupoTableAdapter.Fill(Me.BancoDataSet.Grupo)

    End Sub
End Class