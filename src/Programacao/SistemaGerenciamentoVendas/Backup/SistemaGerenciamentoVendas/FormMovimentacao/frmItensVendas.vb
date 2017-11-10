Imports System.Data.SqlClient
Public Class frmItensVendas
    Private _somatoria As Decimal

    Property PropriedadeSoma() As Decimal
        Get
            Return _somatoria
        End Get
        Set(ByVal value As Decimal)
            _somatoria = value
        End Set
    End Property

    Private Sub frmItensVendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VendasTableAdapter.Fill(Me.BancoDataSet.Vendas)
        Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet.ItemEstoque)
        Me.ItensVendasTableAdapter.Fill(Me.BancoDataSet.ItensVendas)
        Dim formItensVendas As New frmItensVendas
        CodigoVendaTextBox.Text = CodigoVenda

        QuantidadeTextBox.ReadOnly = True
        lblProduto.Text = ""
        lblTotal.Text = ""

        Dim Width As Integer = 595
        Dim Height As Integer = 505

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click
        Dim formItensVendas As New frmItensVendas
        If Width = 595 And Height = 505 Then
            formItensVendas.Size = New System.Drawing.Size(941, 505)
            Width = 941
            Height = 505
        ElseIf Width = 941 And Height = 505 Then
            formItensVendas.Size = New System.Drawing.Size(595, 505)
            Width = 595
            Height = 505
        End If

    End Sub

    Private Sub ItemEstoqueDataGridView_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ItemEstoqueDataGridView.MouseDoubleClick
        QuantidadeTextBox.ReadOnly = False
        Me.ItensVendasBindingSource.AddNew()
        CodigoItemEstoqueTextBox.Text = ItemEstoqueDataGridView.CurrentRow.Cells(0).Value.ToString()
        lblProduto.Text = ItemEstoqueDataGridView.CurrentRow.Cells(1).Value.ToString()
        ValorItemLabel2.Text = CDec(ItemEstoqueDataGridView.CurrentRow.Cells(2).Value.ToString())
        CodigoVendaTextBox.Text = CodigoVenda
        ItemEstoqueDataGridView.Enabled = False

    End Sub

    Private Sub QuantidadeTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantidadeTextBox.Leave
        If QuantidadeTextBox.Text <> String.Empty Then
            ValorLabel2.Text = CDec(ValorItemLabel2.Text) * QuantidadeTextBox.Text
        End If
    End Sub

    
    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        If lblProduto.Text = "" Then
            MessageBox.Show("Por Favor Escolha um Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If QuantidadeTextBox.Text = "" Then
            MessageBox.Show("Por Favor Escolha a Quantidade a ser Vendida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Validate()
        Me.ItensVendasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
        Me.HistoricoVendaTableAdapter1.Insert(CInt(CodigoItemEstoqueTextBox.Text), CInt(QuantidadeTextBox.Text), CDec(ValorLabel2.Text), CDate(DataVenda))
        ItemEstoqueDataGridView.Enabled = True
        '========================================Faz a Soma==============================
        Dim clsSoma As New Soma
        lblTotal.Text = clsSoma.SomaItem(CodigoVenda)



    End Sub
    Private Sub txtCampo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampo.TextChanged
        If (txtCampo.Text <> String.Empty) Then
            ItemEstoqueBindingSource.Filter = "Descricao like '%" + txtCampo.Text + "%'"
        Else
            removeFiltro(ItemEstoqueBindingSource)
        End If
    End Sub
    Private Sub CodigoVendaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoVendaTextBox.TextChanged
        ItensVendasBindingSource.Filter = "CodigoVenda = " + CodigoVendaTextBox.Text
    End Sub
    Private Sub frmItensVendas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        Dim clsSoma As New Soma
        PropriedadeSoma = clsSoma.SomaItem(CodigoVenda)
        Me.Validate()
        Me.ItensVendasBindingSource.EndEdit()
    End Sub

    Private Sub CodigoItemEstoqueTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoItemEstoqueTextBox.TextChanged
        Dim sql As String = "Select Descricao from ItemEstoque Where CodigoItemEstoque = @CodigoItemEstoque"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)
        Dim reader As SqlDataReader

        Comando.Parameters.Clear()
        Comando.Parameters.AddWithValue("@CodigoItemEstoque", CodigoItemEstoqueTextBox.Text)
        Conexao.Open()

        reader = Comando.ExecuteReader()
        reader.Read()

        lblProduto.Text = reader(0).ToString()
        reader.Close()
        Conexao.Close()
        Conexao.Dispose()
    End Sub


    
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If (ItensVendasBindingSource.Count > 0) Then
            Me.ItensVendasBindingSource.RemoveCurrent()
            Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
        Else
            Exit Sub
        End If
        ItemEstoqueDataGridView.Enabled = True
    End Sub

    Private Sub QuantidadeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantidadeTextBox.TextChanged
        '========================NÃO DEIXA VENDER MAIS DO QUE TEM NO ESTOQUE=========================================
        If QtdePermitidaVenda(Me.BancoDataSet, CodigoItemEstoqueTextBox.Text, QuantidadeTextBox.Text) = True Then
            Exit Sub
        End If
        If QuantidadeTextBox.Text <> String.Empty Then
            ValorLabel2.Text = CDec(ValorItemLabel2.Text) * CInt(QuantidadeTextBox.Text)
        End If
    End Sub
End Class