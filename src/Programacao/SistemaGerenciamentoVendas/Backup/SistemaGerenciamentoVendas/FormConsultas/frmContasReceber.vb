Public Class frmContasReceber

    Private Sub frmContasReceber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '===============================Receber Total======================================================
        lblTotal.Text = PagamentoVendaTableAdapter1.SomatorioDosValoresTotal()
        '===============================Recebido Total=====================================================
        If PagamentoVendaTableAdapter1.SomatorioDosValoresRecebido().HasValue <> Nothing Then
            lblRecebido.Text = PagamentoVendaTableAdapter1.SomatorioDosValoresRecebido()
        End If
        '===============================Receber Hoje=======================================================
        Dim data As String = Now.Day.ToString() + "/" + Now.Month.ToString() + "/" + Now.Year.ToString()
        lblReceberHoje.Text = PagamentoVendaTableAdapter1.SomatorioDosValoresReceberHoje(CDate(data))

    End Sub

    Private Sub lblRecebido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRecebido.Click

    End Sub
End Class