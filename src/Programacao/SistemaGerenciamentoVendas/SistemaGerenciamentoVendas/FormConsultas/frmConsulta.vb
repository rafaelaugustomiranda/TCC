Public Class frmConsulta

    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorio.Click
        If rbClientes.Checked = True Then
            Dim formCliente As New frmConCliente
            formCliente.MdiParent = My.Forms.frmMenu
            formCliente.Show()
        ElseIf rbEstoque.Checked = True Then
            Dim formEstoque As New frmConEstoque
            formEstoque.MdiParent = My.Forms.frmMenu
            formEstoque.Show()
        ElseIf rbContas.Checked = True Then
            Dim formContas As New frmContasReceber
            formContas.MdiParent = My.Forms.frmMenu
            formContas.Show()
        ElseIf rbHistCompra.Checked = True Then
            Dim formHistCompra As New frmHistoricoCompras
            formHistCompra.MdiParent = My.Forms.frmMenu
            formHistCompra.Show()
        ElseIf rbHistVendas.Checked = True Then
            Dim formHistVendas As New frmHistoricoVendas
            formHistVendas.MdiParent = My.Forms.frmMenu
            formHistVendas.Show()
        End If
    End Sub
End Class