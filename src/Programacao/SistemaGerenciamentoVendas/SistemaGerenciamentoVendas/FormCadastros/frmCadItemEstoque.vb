Imports System.Data.SqlClient
Public Class frmCadItemEstoque
    Dim visivelC As Boolean
    Dim Dia, Mes, Ano, Data As String
    Dim botaoNovo, botaoAlterar As Boolean

    Private Sub ItemEstoqueBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ItemEstoqueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

    End Sub

    Private Sub frmEstoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GrupoTableAdapter.Fill(Me.BancoDataSet.Grupo)
        Me.ItemEstoqueTableAdapter.Fill(Me.BancoDataSet.ItemEstoque)
        visivelC = False

        CodigoItemEstoqueTextBox.ReadOnly = True
        DescricaoTextBox.ReadOnly = True
        DetalheTextBox.ReadOnly = True
        UnidadeTextBox.ReadOnly = True
        GrupoComboBox.Enabled = False
        EstoqueDisponivelTextBox.ReadOnly = True
        PrecoVendaTextBox.ReadOnly = True
        CustoReposicaoTextBox.ReadOnly = True
        DataUltimaCompraTextBox.ReadOnly = True
        DataUltimaVendaTextBox.ReadOnly = True
        VendasMesTextBox.ReadOnly = True

        btnCalendarioCompra.Enabled = False
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True
    End Sub

    Private Sub btnCalendarioCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalendarioCompra.Click
        If visivelC = False Then
            CalendarioCompra.Visible = True
            visivelC = True
        Else
            CalendarioCompra.Visible = False
            visivelC = False
        End If
    End Sub

    Private Sub CalendarioCompra_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles CalendarioCompra.DateChanged
        Dia = CalendarioCompra.SelectionStart.Day
        Mes = CalendarioCompra.SelectionStart.Month
        Ano = CalendarioCompra.SelectionStart.Year
        Data = Dia + "/" + Mes + "/" + Ano

        DataUltimaCompraTextBox.Text = Data
        CalendarioCompra.Visible = False
        visivelC = False
        Dia = "" : Mes = "" : Ano = "" : Data = ""
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Me.ItemEstoqueBindingSource.AddNew()
        Me.ItemEstoqueBindingNavigator.Enabled = False

        btnCalendarioCompra.Enabled = True
        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False

        CodigoItemEstoqueTextBox.ReadOnly = False
        DescricaoTextBox.ReadOnly = False
        DetalheTextBox.ReadOnly = False
        UnidadeTextBox.ReadOnly = False
        GrupoComboBox.Enabled = True
        EstoqueDisponivelTextBox.ReadOnly = False
        PrecoVendaTextBox.ReadOnly = False
        CustoReposicaoTextBox.ReadOnly = False
        DataUltimaCompraTextBox.ReadOnly = False

        botaoNovo = True
        botaoAlterar = False
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If (CodigoItemEstoqueTextBox.Text = String.Empty) Then
            MessageBox.Show("Codigo em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CodigoItemEstoqueTextBox.Focus()
            Exit Sub
        ElseIf (CodigoItemEstoqueTextBox.Text.Count < 5) Then
            MessageBox.Show("Codigo com menos de 5 digitos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CodigoItemEstoqueTextBox.Focus()
            Exit Sub
        ElseIf (DescricaoTextBox.Text = String.Empty) Then
            MessageBox.Show("Descrição em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DescricaoTextBox.Focus()
            Exit Sub
        ElseIf (GrupoComboBox.Text = String.Empty) Then
            MessageBox.Show("Grupo em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf (EstoqueDisponivelTextBox.Text = String.Empty) Then
            MessageBox.Show("Estoque em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            EstoqueDisponivelTextBox.Focus()
            Exit Sub
        ElseIf (PrecoVendaTextBox.Text = String.Empty) Then
            MessageBox.Show("Preço de Venda em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PrecoVendaTextBox.Focus()
            Exit Sub
        ElseIf (DataUltimaCompraTextBox.Text = String.Empty) Then
            MessageBox.Show("Data da Ultima Compra em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataUltimaCompraTextBox.Focus()
            Exit Sub
        ElseIf (CustoReposicaoTextBox.Text = String.Empty) Then
            MessageBox.Show("Custo de Reposição em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataUltimaCompraTextBox.Focus()
            Exit Sub

        End If
       
        If botaoAlterar = True Then
            botaoAlterar = False
            AtualizaHistoricoCompra()
        End If
        Me.Validate()
        Me.ItemEstoqueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
        MessageBox.Show("Os Dados foram Salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.ItemEstoqueBindingNavigator.Enabled = True

        If botaoNovo = True Then
            botaoNovo = False
            botaoAlterar = False
            InsereHistoricoCompra()
        End If

        btnCalendarioCompra.Enabled = False
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        CodigoItemEstoqueTextBox.ReadOnly = True
        DescricaoTextBox.ReadOnly = True
        DetalheTextBox.ReadOnly = True
        UnidadeTextBox.ReadOnly = True
        GrupoComboBox.Enabled = False
        EstoqueDisponivelTextBox.ReadOnly = True
        PrecoVendaTextBox.ReadOnly = True
        CustoReposicaoTextBox.ReadOnly = True
        DataUltimaCompraTextBox.ReadOnly = True


    End Sub

   
    Private Sub GrupoComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoComboBox.TextChanged
        Dim sql As String = "Select * from Grupo Where Grupo = @Grupo"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)
        Dim reader As SqlDataReader

        Comando.Parameters.Clear()
        If (GrupoComboBox.Text <> "") Then
            Comando.Parameters.AddWithValue("@Grupo", GrupoComboBox.Text)
            Conexao.Open()

            reader = Comando.ExecuteReader()
            reader.Read()

            CodigoItemEstoqueTextBox.Text = reader(0).ToString()

            reader.Close()
            Conexao.Close()
        End If
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim resp As DialogResult
        If (GrupoBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Alterar o Registro: " + CodigoItemEstoqueTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.ItemEstoqueBindingSource.CancelEdit()
                CodigoItemEstoqueTextBox.ReadOnly = False
                DescricaoTextBox.ReadOnly = False
                DetalheTextBox.ReadOnly = False
                UnidadeTextBox.ReadOnly = False
                GrupoComboBox.Enabled = False
                EstoqueDisponivelTextBox.ReadOnly = False
                PrecoVendaTextBox.ReadOnly = False
                CustoReposicaoTextBox.ReadOnly = False
                DataUltimaCompraTextBox.ReadOnly = False

                btnNovo.Enabled = False
                btnSalvar.Enabled = True
                btnAlterar.Enabled = False
                btnCancelar.Enabled = True
                btnExcluir.Enabled = False
                btnCalendarioCompra.Enabled = True
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        botaoNovo = False
        botaoAlterar = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.ItemEstoqueBindingSource.CancelEdit()

        CodigoItemEstoqueTextBox.ReadOnly = True
        DescricaoTextBox.ReadOnly = True
        DetalheTextBox.ReadOnly = True
        UnidadeTextBox.ReadOnly = True
        GrupoComboBox.Enabled = True
        EstoqueDisponivelTextBox.ReadOnly = True
        PrecoVendaTextBox.ReadOnly = True
        CustoReposicaoTextBox.ReadOnly = True
        DataUltimaCompraTextBox.ReadOnly = True
        ItemEstoqueBindingNavigator.Enabled = True
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True
        botaoNovo = False
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim resp As DialogResult
        If (ItemEstoqueBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Realmente excluir o registro: " + CodigoItemEstoqueTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.ItemEstoqueBindingSource.RemoveCurrent()
                Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub InsereHistoricoCompra()
        Dim data, Dia, Mes, Ano As String

        Dia = CalendarioCompra.SelectionStart.Day.ToString()
        Mes = CalendarioCompra.SelectionStart.Month.ToString()
        Ano = CalendarioCompra.SelectionStart.Year.ToString()

        data = Dia + "/" + Mes + "/" + Ano
        Me.HistoricoCompraTableAdapter1.Insert(CInt(CodigoItemEstoqueTextBox.Text), CInt(EstoqueDisponivelTextBox.Text), CDec(CustoReposicaoTextBox.Text), CDate(data))
    End Sub

    Public Sub AtualizaHistoricoCompra()
        Dim data, Dia, Mes, Ano As String

        Dia = CalendarioCompra.SelectionStart.Day.ToString()
        Mes = CalendarioCompra.SelectionStart.Month.ToString()
        Ano = CalendarioCompra.SelectionStart.Year.ToString()

        data = Dia + "/" + Mes + "/" + Ano



        Dim sql As String = "Select EstoqueDisponivel from ItemEstoque Where CodigoItemEstoque = @CodigoItemEstoque"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)
        Dim reader As SqlDataReader

        Comando.Parameters.Clear()
        Comando.Parameters.AddWithValue("@CodigoItemEstoque", CodigoItemEstoqueTextBox.Text)
        Conexao.Open()

        reader = Comando.ExecuteReader()
        reader.Read()
        Me.HistoricoCompraTableAdapter1.Insert(CInt(CodigoItemEstoqueTextBox.Text), CInt(EstoqueDisponivelTextBox.Text) - reader(0), CDec(CustoReposicaoTextBox.Text), CDate(data))
        reader.Close()
        Conexao.Close()

    End Sub
End Class