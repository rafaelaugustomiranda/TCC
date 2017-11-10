Imports System.Data.SqlClient
Public Class frmVendas
    Dim botaoNovo As Boolean
    Public Dia, DiaHoje, Mes, MesHoje, Ano, AnoHoje, Data As String
    Private Sub VendasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VendasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
    End Sub
    Private Sub frmVendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TipoPagamentoTableAdapter.Fill(Me.BancoDataSet.TipoPagamento)
        Me.ClienteTableAdapter.Fill(Me.BancoDataSet.Cliente)
        Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet.ItemEstoque)
        Me.FormaPagamentoTableAdapter.Fill(Me.BancoDataSet.FormaPagamento)
        Me.VendedorTableAdapter.Fill(Me.BancoDataSet.Vendedor)
        Me.VendasTableAdapter.Fill(Me.BancoDataSet.Vendas)

        Valor1ParcelaTextBox1.ReadOnly = True : Data1ParcelaTextBox.ReadOnly = True
        Valor2ParcelaTextBox1.ReadOnly = True : Data2ParcelaTextBox.ReadOnly = True
        Valor3ParcelaTextBox1.ReadOnly = True : Data3ParcelaTextBox.ReadOnly = True
        Valor4ParcelaTextBox1.ReadOnly = True : Data4ParcelaTextBox.ReadOnly = True
        Valor5ParcelaTextBox1.ReadOnly = True : Data5ParcelaTextBox.ReadOnly = True
        Valor6ParcelaTextBox1.ReadOnly = True : Data6ParcelaTextBox.ReadOnly = True


        ClienteComboBox.Enabled = False
        VendedorComboBox.Enabled = False
        FormaPagamentoComboBox.Enabled = False
        TipoPagamentoComboBox.Enabled = False
        cboQuantidade.Enabled = False
        VendasBindingNavigator.Enabled = True
        CodigoVendaTextBox1.ReadOnly = True
        DataVendaTextBox1.ReadOnly = True
        ValorDescontoTextBox.ReadOnly = True
        ValorEntradaTextBox1.ReadOnly = True


        btnNovo.Enabled = True
        btnItens.Enabled = False
        btnEfetuarVenda.Enabled = False
        btnCancelar.Enabled = True

        GBDesconto.Enabled = False
        GBEntrada.Enabled = False
    End Sub
    Private Sub VendasBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VendasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        botaoNovo = True
        VendedorComboBox.Enabled = True
        ClienteComboBox.Enabled = True
        FormaPagamentoComboBox.Enabled = False
        TipoPagamentoComboBox.Enabled = False
        DataVendaTextBox1.ReadOnly = True
        ValorDescontoTextBox.ReadOnly = True
        ValorEntradaTextBox1.ReadOnly = True
        VendasBindingNavigator.Enabled = False
        cboQuantidade.Enabled = False
        btnNovo.Enabled = False
        btnItens.Enabled = True
        btnEfetuarVenda.Enabled = False
        btnCancelar.Enabled = False

        lblCodigo.Text = ""
        lblEndereco.Text = ""
        lblTelefone.Text = ""



        Me.VendasBindingSource.AddNew()

        DiaHoje = Now.Day.ToString()
        MesHoje = Now.Month.ToString()
        AnoHoje = Now.Year.ToString()
        DataVendaTextBox1.Text = DiaHoje + "/" + MesHoje + "/" + AnoHoje


    End Sub

    Private Sub btnItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItens.Click
        '===========================Salva o Codigo da Venda ========================================
        Me.Validate()
        Me.VendasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
        '===========================================================================================
        CodigoVenda = CInt(CodigoVendaTextBox1.Text)
        DataVenda = DataVendaTextBox1.Text
        My.Forms.frmItensVendas.ShowDialog()
        '================Pega a Somatoria da Propriedade no Itens de Vendas =======================
        ValorCompraLabel2.Text = My.Forms.frmItensVendas.PropriedadeSoma
        ClienteComboBox.Enabled = True
        VendedorComboBox.Enabled = True
        FormaPagamentoComboBox.Enabled = True
        TipoPagamentoComboBox.Enabled = True
        DataVendaTextBox1.ReadOnly = False
        ValorDescontoTextBox.ReadOnly = False
        ValorEntradaTextBox1.ReadOnly = False
        VendasBindingNavigator.Enabled = False
        btnNovo.Enabled = False
        btnItens.Enabled = True
        btnEfetuarVenda.Enabled = True
        btnCancelar.Enabled = False

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        '===========================Deleta a Itens de Venda========================================
        Dim sql As String = "Delete from ItensVendas Where CodigoVenda = @CodigoVenda"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)

        Comando.Parameters.Clear()
        Comando.Parameters.AddWithValue("@CodigoVenda", CodigoVendaTextBox1.Text)
        Conexao.Open()

        Comando.ExecuteNonQuery()

        Conexao.Close()
        ' DeletaItensVenda(CodigoVendaTextBox1.Text)
        '===========================Deleta a Venda=================================================
        If (VendasBindingSource.Count > 0) Then
            Me.Validate()
            Me.VendasBindingSource.EndEdit()
            Me.VendasBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
        Else
            Exit Sub
        End If
        lblCodigo.Text = ""
        lblEndereco.Text = ""
        lblTelefone.Text = ""

    End Sub

    Private Sub btnEfetuarVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEfetuarVenda.Click
        '================================== VALIDA OS CAMPOS ============================================================
        If VendedorComboBox.Text = "" Then
            MessageBox.Show("Por Favor Escolha um Vendedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If FormaPagamentoComboBox.Text = "" Then
            MessageBox.Show("Por Favor Escolha a Forma de Pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If TipoPagamentoComboBox.Text = "" Then
            MessageBox.Show("Por Favor Escolha o Tipo de Pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ClienteComboBox.Text = "" Then
            MessageBox.Show("Por Favor Escolha um Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' ======================== SE O PAGAMENTO FOR A PRAZO ============================================================
        ' ================ INSERE OS VALORES NA TABELA PAGAMENTO VENDAS ==================================================
        If TipoPagamentoComboBox.Text = "Á Prazo" Then
            Dim Parcela(0 To 5) As String
            Dim Data(0 To 5) As String
            Dim CodigoCliente As Integer
            Parcela(0) = Valor1ParcelaTextBox1.Text : Data(0) = Data1ParcelaTextBox.Text
            Parcela(1) = Valor2ParcelaTextBox1.Text : Data(1) = Data2ParcelaTextBox.Text
            Parcela(2) = Valor3ParcelaTextBox1.Text : Data(2) = Data3ParcelaTextBox.Text
            Parcela(3) = Valor4ParcelaTextBox1.Text : Data(3) = Data4ParcelaTextBox.Text
            Parcela(4) = Valor5ParcelaTextBox1.Text : Data(4) = Data5ParcelaTextBox.Text
            Parcela(5) = Valor6ParcelaTextBox1.Text : Data(5) = Data6ParcelaTextBox.Text
            CodigoCliente = CInt(ClienteComboBox.SelectedValue)

            For index = 0 To CInt(cboQuantidade.Text) - 1
                InserePagamentoVendas(CodigoVenda, CodigoCliente, index + 1, Parcela(index), Data(index))
            Next
        End If
        '================================= ATUALIZA O ESTOQUE ===========================================================
        AtualizaEstoque(Me.BancoDataSet, DiaHoje, MesHoje, AnoHoje)
        '=================== ATUALIZA A ULTIMA DATA DA COMPRA NA TABELA CLIENTES===========================================================
        Me.ClienteTableAdapter.AtualizaUltimaDataCompra(CDate(DataVendaTextBox1.Text), CInt(ClienteComboBox.SelectedValue)) 
        If ValorCompraLabel2.Text <> String.Empty Then
            Me.ClienteTableAdapter.AtualizaValorMaior(CDec(ValorCompraLabel2.Text), CInt(ClienteComboBox.SelectedValue), CDec(ValorCompraLabel2.Text))
        ElseIf ValorLiquidoLabel2.Text <> String.Empty Then
            Me.ClienteTableAdapter.AtualizaValorMaior(CDec(ValorLiquidoLabel2.Text), CInt(ClienteComboBox.SelectedValue), CDec(ValorLiquidoLabel2.Text))
        End If

        '===================================== SALVA A VENDA=============================================================
        Me.Validate()
        Me.VendasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)


        Data1ParcelaTextBox.ReadOnly = True : Valor1ParcelaTextBox1.ReadOnly = True
        Data2ParcelaTextBox.ReadOnly = True : Valor1ParcelaTextBox1.ReadOnly = True
        Data3ParcelaTextBox.ReadOnly = True : Valor1ParcelaTextBox1.ReadOnly = True
        Data4ParcelaTextBox.ReadOnly = True : Valor1ParcelaTextBox1.ReadOnly = True
        Data5ParcelaTextBox.ReadOnly = True : Valor1ParcelaTextBox1.ReadOnly = True
        Data6ParcelaTextBox.ReadOnly = True : Valor1ParcelaTextBox1.ReadOnly = True

        ClienteComboBox.Enabled = False
        VendedorComboBox.Enabled = False
        FormaPagamentoComboBox.Enabled = False
        TipoPagamentoComboBox.Enabled = False
        cboQuantidade.Enabled = True

        DataVendaTextBox1.ReadOnly = True
        ValorDescontoTextBox.ReadOnly = True
        ValorEntradaTextBox1.ReadOnly = True


        btnNovo.Enabled = True
        btnItens.Enabled = False
        btnEfetuarVenda.Enabled = False
        btnCancelar.Enabled = True
        VendasBindingNavigator.Enabled = True
        botaoNovo = False
    End Sub

    Private Sub ValorDescontoTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorDescontoTextBox.Leave
        If ValorDescontoTextBox.Text <> String.Empty Then
            ValorLiquidoLabel2.Text = CDec(ValorCompraLabel2.Text) - CDec(ValorDescontoTextBox.Text)
        End If
    End Sub


    Private Sub cboQuantidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboQuantidade.TextChanged
        Dia = DiaHoje
        Mes = MesHoje
        Ano = AnoHoje

        Select Case Mes
            Case "1", "2", "3", "4", "5", "6"
                Select Case cboQuantidade.Text
                    Case "0"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                    Case "1"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                    Case "2"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                    Case "3"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                    Case "4"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 4).ToString() + "/" + Ano.ToString()
                    Case "5"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 4).ToString() + "/" + Ano.ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 5).ToString() + "/" + Ano.ToString()
                    Case "6"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 4).ToString() + "/" + Ano.ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 5).ToString() + "/" + Ano.ToString()
                        Data6ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 6).ToString() + "/" + Ano.ToString()
                End Select

            Case "7"
                Select Case cboQuantidade.Text
                    Case "1"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                    Case "2"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                    Case "3"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                    Case "4"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 4).ToString() + "/" + Ano.ToString()
                    Case "5"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 4).ToString() + "/" + Ano.ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 5).ToString() + "/" + Ano.ToString()
                    Case "6"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 4).ToString() + "/" + Ano.ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 5).ToString() + "/" + Ano.ToString()
                        Data6ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                End Select
            Case "8"
                Select Case cboQuantidade.Text
                    Case "1"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                    Case "2"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                    Case "3"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                    Case "4"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 4).ToString() + "/" + Ano.ToString()
                    Case "5"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 4).ToString() + "/" + Ano.ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1)
                    Case "6"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 4).ToString() + "/" + Ano.ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data6ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                End Select

            Case "9"
                Select Case cboQuantidade.Text
                    Case "1"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString + "/" + Ano.ToString
                    Case "2"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString + "/" + Ano.ToString
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString + "/" + Ano.ToString
                    Case "3"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString + "/" + Ano.ToString
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString + "/" + Ano.ToString
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString + "/" + Ano.ToString
                    Case "4"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString + "/" + Ano.ToString
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString + "/" + Ano.ToString
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString + "/" + Ano.ToString
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString
                    Case "5"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString + "/" + Ano.ToString
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString + "/" + Ano.ToString
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString + "/" + Ano.ToString
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString
                    Case "6"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 3).ToString() + "/" + Ano.ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                        Data6ParcelaTextBox.Text = Dia.ToString() + "/" + "03" + "/" + (Ano + 1).ToString()
                End Select

            Case "10"
                Select Case cboQuantidade.Text
                    Case "1"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                    Case "2"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                    Case "3"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                    Case "4"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                    Case "5"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + "03" + "/" + (Ano + 1).ToString()
                    Case "6"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 2).ToString() + "/" + Ano.ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + "03" + "/" + (Ano + 1).ToString()
                        Data6ParcelaTextBox.Text = Dia.ToString() + "/" + "04" + "/" + (Ano + 1).ToString()
                End Select

            Case "11"
                Select Case cboQuantidade.Text
                    Case "1"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                    Case "2"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                    Case "3"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                    Case "4"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "03" + "/" + (Ano + 1).ToString()
                    Case "5"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "03" + "/" + (Ano + 1).ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + "04" + "/" + (Ano + 1).ToString()
                    Case "6"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + (Mes + 1).ToString() + "/" + Ano.ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "03" + "/" + (Ano + 1).ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + "04" + "/" + (Ano + 1).ToString()
                        Data6ParcelaTextBox.Text = Dia.ToString() + "/" + "05" + "/" + (Ano + 1).ToString()
                End Select

            Case "12"
                Select Case cboQuantidade.Text
                    Case "1"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                    Case "2"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                    Case "3"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "03" + "/" + (Ano + 1).ToString()
                    Case "4"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "03" + "/" + (Ano + 1).ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "04" + "/" + (Ano + 1).ToString()
                    Case "5"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "03" + "/" + (Ano + 1).ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "04" + "/" + (Ano + 1).ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + "05" + "/" + (Ano + 1).ToString()
                    Case "6"
                        LiberaLimpaDivideCampos(cboQuantidade.Text)
                        Data1ParcelaTextBox.Text = Dia.ToString() + "/" + "01" + "/" + (Ano + 1).ToString()
                        Data2ParcelaTextBox.Text = Dia.ToString() + "/" + "02" + "/" + (Ano + 1).ToString()
                        Data3ParcelaTextBox.Text = Dia.ToString() + "/" + "03" + "/" + (Ano + 1).ToString()
                        Data4ParcelaTextBox.Text = Dia.ToString() + "/" + "04" + "/" + (Ano + 1).ToString()
                        Data5ParcelaTextBox.Text = Dia.ToString() + "/" + "05" + "/" + (Ano + 1).ToString()
                        Data6ParcelaTextBox.Text = Dia.ToString() + "/" + "06" + "/" + (Ano + 1).ToString()
                End Select

        End Select
    End Sub
    Private Sub frmVendas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If botaoNovo = True Then

            '===========================Deleta a Itens de Venda========================================
            Dim sql As String = "Delete from ItensVendas Where CodigoVenda = @CodigoVenda"
            Dim Conexao As New SqlConnection(StringConexao)
            Dim Comando As New SqlCommand(sql, Conexao)

            Comando.Parameters.Clear()
            Comando.Parameters.AddWithValue("@CodigoVenda", CodigoVendaTextBox1.Text)
            Conexao.Open()

            Comando.ExecuteNonQuery()

            Conexao.Close()

            '===========================Deleta a Venda=================================================
            If (VendasBindingSource.Count > 0) Then
                Me.VendasBindingSource.RemoveCurrent()
                Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
            Else
                Exit Sub
            End If
            MessageBox.Show("Cancelando a Venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            botaoNovo = False
        End If
    End Sub

    Private Sub ClienteComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteComboBox.TextChanged
        Dim sql As String = "Select CodigoCliente, Endereco, Telefone from Cliente Where CodigoCliente = @CodigoCliente"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)
        Dim reader As SqlDataReader

        Comando.Parameters.Clear()
        If ClienteComboBox.SelectedValue = Nothing Then
            Exit Sub
        End If
        Comando.Parameters.AddWithValue("@CodigoCliente", ClienteComboBox.SelectedValue)
        Conexao.Open()

        reader = Comando.ExecuteReader()
        reader.Read()

        lblCodigo.Text = reader(0).ToString()
        lblEndereco.Text = reader(1).ToString()
        lblTelefone.Text = reader(2).ToString()
        reader.Close()
        Conexao.Close()
    End Sub


    Private Sub ValorEntradaTextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValorEntradaTextBox1.Leave
        If ValorEntradaTextBox1.Text <> String.Empty And ValorCompraLabel2.Text <> String.Empty Then
            ValorLiquidoLabel2.Text = CDec(ValorCompraLabel2.Text) - CDec(ValorEntradaTextBox1.Text)
        End If
    End Sub
    Private Sub TipoPagamentoComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoPagamentoComboBox.TextChanged
        If TipoPagamentoComboBox.Text = "Á Vista" Then

            GBDesconto.Enabled = True
            GBEntrada.Enabled = False
            ValorEntradaTextBox1.Text = ""
            cboQuantidade.Enabled = False
        ElseIf TipoPagamentoComboBox.Text = "Á Prazo" Then

            GBEntrada.Enabled = True
            GBDesconto.Enabled = False
            ValorDescontoTextBox.Text = ""
            cboQuantidade.Enabled = True
        End If

    End Sub
    Private Sub LiberaLimpaDivideCampos(ByVal qtde As String)
        Select Case qtde
            Case "0"
                Valor1ParcelaTextBox1.ReadOnly = True : Data1ParcelaTextBox.ReadOnly = True : Valor1ParcelaTextBox1.Text = "" : Data1ParcelaTextBox.Text = ""
                Valor2ParcelaTextBox1.ReadOnly = True : Data2ParcelaTextBox.ReadOnly = True : Valor2ParcelaTextBox1.Text = "" : Data2ParcelaTextBox.Text = ""
                Valor3ParcelaTextBox1.ReadOnly = True : Data3ParcelaTextBox.ReadOnly = True : Valor3ParcelaTextBox1.Text = "" : Data3ParcelaTextBox.Text = ""
                Valor4ParcelaTextBox1.ReadOnly = True : Data4ParcelaTextBox.ReadOnly = True : Valor4ParcelaTextBox1.Text = "" : Data4ParcelaTextBox.Text = ""
                Valor5ParcelaTextBox1.ReadOnly = True : Data5ParcelaTextBox.ReadOnly = True : Valor5ParcelaTextBox1.Text = "" : Data5ParcelaTextBox.Text = ""
                Valor6ParcelaTextBox1.ReadOnly = True : Data6ParcelaTextBox.ReadOnly = True : Valor6ParcelaTextBox1.Text = "" : Data5ParcelaTextBox.Text = ""

            Case "1"
                If ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text <> "" Then
                    Valor1ParcelaTextBox1.Text = ValorLiquidoLabel2.Text
                ElseIf ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text = "" Then
                    Valor1ParcelaTextBox1.Text = ValorCompraLabel2.Text
                End If
                Valor1ParcelaTextBox1.ReadOnly = False : Data1ParcelaTextBox.ReadOnly = False
                Valor2ParcelaTextBox1.ReadOnly = True : Data2ParcelaTextBox.ReadOnly = True : Valor2ParcelaTextBox1.Text = "" : Data2ParcelaTextBox.Text = ""
                Valor3ParcelaTextBox1.ReadOnly = True : Data3ParcelaTextBox.ReadOnly = True : Valor3ParcelaTextBox1.Text = "" : Data3ParcelaTextBox.Text = ""
                Valor4ParcelaTextBox1.ReadOnly = True : Data4ParcelaTextBox.ReadOnly = True : Valor4ParcelaTextBox1.Text = "" : Data4ParcelaTextBox.Text = ""
                Valor5ParcelaTextBox1.ReadOnly = True : Data5ParcelaTextBox.ReadOnly = True : Valor5ParcelaTextBox1.Text = "" : Data5ParcelaTextBox.Text = ""
                Valor6ParcelaTextBox1.ReadOnly = True : Data6ParcelaTextBox.ReadOnly = True : Valor6ParcelaTextBox1.Text = "" : Data6ParcelaTextBox.Text = ""
            Case "2"
                If ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text <> "" Then
                    Valor1ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 2
                    Valor2ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 2
                ElseIf ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text = "" Then
                    Valor1ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 2
                    Valor2ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 2
                End If
                Valor1ParcelaTextBox1.ReadOnly = False : Data1ParcelaTextBox.ReadOnly = False
                Valor2ParcelaTextBox1.ReadOnly = False : Data2ParcelaTextBox.ReadOnly = False
                Valor3ParcelaTextBox1.ReadOnly = True : Data3ParcelaTextBox.ReadOnly = True : Valor3ParcelaTextBox1.Text = "" : Data3ParcelaTextBox.Text = ""
                Valor4ParcelaTextBox1.ReadOnly = True : Data4ParcelaTextBox.ReadOnly = True : Valor4ParcelaTextBox1.Text = "" : Data4ParcelaTextBox.Text = ""
                Valor5ParcelaTextBox1.ReadOnly = True : Data5ParcelaTextBox.ReadOnly = True : Valor5ParcelaTextBox1.Text = "" : Data5ParcelaTextBox.Text = ""
                Valor6ParcelaTextBox1.ReadOnly = True : Data6ParcelaTextBox.ReadOnly = True : Valor6ParcelaTextBox1.Text = "" : Data6ParcelaTextBox.Text = ""
            Case "3"
                If ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text <> "" Then
                    Valor1ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 3
                    Valor2ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 3
                    Valor3ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 3
                ElseIf ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text = "" Then
                    Valor1ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 3
                    Valor2ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 3
                    Valor3ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 3
                End If
                Valor1ParcelaTextBox1.ReadOnly = False : Data1ParcelaTextBox.ReadOnly = False
                Valor2ParcelaTextBox1.ReadOnly = False : Data2ParcelaTextBox.ReadOnly = False
                Valor3ParcelaTextBox1.ReadOnly = False : Data3ParcelaTextBox.ReadOnly = False
                Valor4ParcelaTextBox1.ReadOnly = True : Data4ParcelaTextBox.ReadOnly = True : Valor4ParcelaTextBox1.Text = "" : Data4ParcelaTextBox.Text = ""
                Valor5ParcelaTextBox1.ReadOnly = True : Data5ParcelaTextBox.ReadOnly = True : Valor5ParcelaTextBox1.Text = "" : Data5ParcelaTextBox.Text = ""
                Valor6ParcelaTextBox1.ReadOnly = True : Data6ParcelaTextBox.ReadOnly = True : Valor6ParcelaTextBox1.Text = "" : Data6ParcelaTextBox.Text = ""

            Case "4"
                If ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text <> "" Then
                    Valor1ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 4
                    Valor2ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 4
                    Valor3ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 4
                    Valor4ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 4
                ElseIf ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text = "" Then
                    Valor1ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 4
                    Valor2ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 4
                    Valor3ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 4
                    Valor4ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 4
                End If
                Valor1ParcelaTextBox1.ReadOnly = False : Data1ParcelaTextBox.ReadOnly = False
                Valor2ParcelaTextBox1.ReadOnly = False : Data2ParcelaTextBox.ReadOnly = False
                Valor3ParcelaTextBox1.ReadOnly = False : Data3ParcelaTextBox.ReadOnly = False
                Valor4ParcelaTextBox1.ReadOnly = False : Data4ParcelaTextBox.ReadOnly = False
                Valor5ParcelaTextBox1.ReadOnly = True : Data5ParcelaTextBox.ReadOnly = True : Valor5ParcelaTextBox1.Text = "" : Data5ParcelaTextBox.Text = ""
                Valor6ParcelaTextBox1.ReadOnly = True : Data6ParcelaTextBox.ReadOnly = True : Valor6ParcelaTextBox1.Text = "" : Data6ParcelaTextBox.Text = ""

            Case "5"
                If ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text <> "" Then
                    Valor1ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 5
                    Valor2ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 5
                    Valor3ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 5
                    Valor4ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 5
                    Valor5ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 5
                ElseIf ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text = "" Then
                    Valor1ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 5
                    Valor2ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 5
                    Valor3ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 5
                    Valor4ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 5
                    Valor5ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 5
                End If
                Valor1ParcelaTextBox1.ReadOnly = False : Data1ParcelaTextBox.ReadOnly = False
                Valor2ParcelaTextBox1.ReadOnly = False : Data2ParcelaTextBox.ReadOnly = False
                Valor3ParcelaTextBox1.ReadOnly = False : Data3ParcelaTextBox.ReadOnly = False
                Valor4ParcelaTextBox1.ReadOnly = False : Data4ParcelaTextBox.ReadOnly = False
                Valor5ParcelaTextBox1.ReadOnly = False : Data5ParcelaTextBox.ReadOnly = False
                Valor6ParcelaTextBox1.ReadOnly = True : Data6ParcelaTextBox.ReadOnly = True : Valor6ParcelaTextBox1.Text = "" : Data6ParcelaTextBox.Text = ""

            Case "6"
                If ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text <> "" Then
                    Valor1ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 6
                    Valor2ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 6
                    Valor3ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 6
                    Valor4ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 6
                    Valor5ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 6
                    Valor6ParcelaTextBox1.Text = CDec(ValorLiquidoLabel2.Text) / 6
                ElseIf ValorCompraLabel2.Text <> "" And ValorEntradaTextBox1.Text = "" Then
                    Valor1ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 6
                    Valor2ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 6
                    Valor3ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 6
                    Valor4ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 6
                    Valor5ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 6
                    Valor6ParcelaTextBox1.Text = CDec(ValorCompraLabel2.Text) / 6
                End If
                Valor1ParcelaTextBox1.ReadOnly = False : Data1ParcelaTextBox.ReadOnly = False
                Valor2ParcelaTextBox1.ReadOnly = False : Data2ParcelaTextBox.ReadOnly = False
                Valor3ParcelaTextBox1.ReadOnly = False : Data3ParcelaTextBox.ReadOnly = False
                Valor4ParcelaTextBox1.ReadOnly = False : Data4ParcelaTextBox.ReadOnly = False
                Valor5ParcelaTextBox1.ReadOnly = False : Data5ParcelaTextBox.ReadOnly = False
                Valor6ParcelaTextBox1.ReadOnly = False : Data6ParcelaTextBox.ReadOnly = False
        End Select
    End Sub
End Class

