Imports System.Data.SqlClient

Public Class frmPagamentoVendas
    Public Dia, Mes, Ano, Data As String
    Public CodigoVenda, NumeroParcela As Integer
    Public ValorPagar, Valor, Juros As Decimal
   
    Private Sub frmPagamentoVendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dia = Now.Day.ToString()
        Mes = Now.Month.ToString()
        Ano = Now.Year.ToString()
        Data = Dia + "/" + Mes + "/" + Ano

        Me.ClienteTableAdapter.Fill(Me.BancoDataSet.Cliente)
        ClienteComboBox.Text = ""
        lblCodigoCliente.Text = ""
    End Sub
    Private Sub btnProcurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurar.Click
        Me.PagamentoVendaTableAdapter.FillParcelasEmAberto(Me.BancoDataSet.PagamentoVenda, ClienteComboBox.SelectedValue, "Não")
        lblRegistros.Text = PagamentoVendaDataGridView.RowCount
        colorirGrigPagamento(PagamentoVendaDataGridView, Data, Me.BancoDataSet)

        If PagamentoVendaTableAdapter.SomatorioDosValoresPorCliente(ClienteComboBox.SelectedValue, "Não").HasValue = True Then
            lblDivida.Text = PagamentoVendaTableAdapter.SomatorioDosValoresPorCliente(ClienteComboBox.SelectedValue, "Não")
        Else
            lblDivida.Text = "0,00"
        End If

    End Sub

    Private Sub btnCalculaJuros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculaJuros.Click

        If CodigoVenda <> 0 And NumeroParcela <> 0 And Valor <> 0 Then

            Juros = ((Valor * 5) / 100)
            ValorPagar = (Juros + Valor)

            Me.PagamentoVendaTableAdapter.AtualizaJuros(ValorPagar, Juros, "Não", ClienteComboBox.SelectedValue, CodigoVenda, NumeroParcela, CDate(Data))
            Me.PagamentoVendaTableAdapter.FillParcelasEmAberto(Me.BancoDataSet.PagamentoVenda, ClienteComboBox.SelectedValue, "Não")
            colorirGrigPagamento(PagamentoVendaDataGridView, Data, Me.BancoDataSet)

        Else
            MessageBox.Show("Selecione a Parcela no Grid", "Calcular Juros", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If


    End Sub

    Private Sub PagamentoVendaDataGridView_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PagamentoVendaDataGridView.MouseClick
        Dim DataVencimento As Date
        CodigoVenda = PagamentoVendaDataGridView.CurrentRow.Cells(0).Value.ToString()
        NumeroParcela = PagamentoVendaDataGridView.CurrentRow.Cells(2).Value.ToString()
        Valor = PagamentoVendaDataGridView.CurrentRow.Cells(3).Value.ToString()
        DataVencimento = PagamentoVendaDataGridView.CurrentRow.Cells(6).Value.ToString()

        If DataVencimento > Data Then
            btnCalculaJuros.Enabled = False
        Else
            btnCalculaJuros.Enabled = True
        End If


    End Sub
    Private Sub btnEfetuarPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEfetuarPagamento.Click
        Dim DataDeHoje As Date = CDate(Data)
        Dim DataVencimento As Date = PagamentoVendaDataGridView.CurrentRow.Cells(6).Value.ToString()
        Dim DiferencaDosDias As Integer

        DiferencaDosDias = DateDiff(DateInterval.Day, DataDeHoje, DataVencimento)
        Me.PagamentoVendaTableAdapter.EfetuaPagamento(DataDeHoje, DiferencaDosDias, "Sim", CodigoVenda, ClienteComboBox.SelectedValue, NumeroParcela)
        Me.PagamentoVendaTableAdapter.FillParcelasEmAberto(Me.BancoDataSet.PagamentoVenda, ClienteComboBox.SelectedValue, "Não")
        Me.ClienteTableAdapter.AtulizaIndice(PagamentoVendaTableAdapter.MediaDiaPagamento(ClienteComboBox.SelectedValue), ClienteComboBox.SelectedValue)
        lblDivida.Text = PagamentoVendaTableAdapter.SomatorioDosValoresPorCliente(ClienteComboBox.SelectedValue, "Não")
        colorirGrigPagamento(PagamentoVendaDataGridView, Data, Me.BancoDataSet)
    End Sub

    Private Sub ClienteComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteComboBox.TextChanged
        lblCodigoCliente.Text = ClienteComboBox.SelectedValue
    End Sub
    Private Sub PagamentoVendaDataGridView_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PagamentoVendaDataGridView.ColumnHeaderMouseClick

    End Sub
End Class