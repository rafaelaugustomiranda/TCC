Imports System.Data.SqlClient

Public Class frmCadCliente
    Public DiaHoje, MesHoje, AnoHoje As String
    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

    End Sub

    Private Sub frmCadCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CidadeTableAdapter.Fill(Me.BancoDataSet.Cidade)
        Me.ClienteTableAdapter.Fill(Me.BancoDataSet.Cliente)

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        CodigoClienteTextBox.ReadOnly = True
        NomeTextBox.ReadOnly = True
        EnderecoTextBox.ReadOnly = True
        BairroTextBox.ReadOnly = True
        ComplementoTextBox.ReadOnly = True
        CidadeComboBox.Enabled = False
        CEPTextBox.ReadOnly = True : CEPTextBox.Text = ""
        UFTextBox.ReadOnly = True : UFTextBox.Text = ""
        RGMaskedTextBox.ReadOnly = True
        CPFMaskedTextBox.ReadOnly = True
        TelefoneMaskedTextBox.ReadOnly = True
        FaxMaskedTextBox.ReadOnly = True
        ValorMaiorCompraTextBox.ReadOnly = True
        TitulosAbertoSPCTextBox.ReadOnly = True
        IndicePontualidadeTextBox.ReadOnly = True
        DataCadastroTextBox.ReadOnly = True
        DataUltimaCompraTextBox.ReadOnly = True
        DataNascimentoTextBox.ReadOnly = True
        ObsTextBox.ReadOnly = True
    
      
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim resp As DialogResult
        If (ClienteBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Realmente excluir o registro: " + CodigoClienteTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.ClienteBindingSource.RemoveCurrent()
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Me.ClienteBindingSource.AddNew()
        Me.ClienteBindingNavigator.Enabled = False

        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False


        NomeTextBox.ReadOnly = False
        EnderecoTextBox.ReadOnly = False
        BairroTextBox.ReadOnly = False
        ComplementoTextBox.ReadOnly = False
        CidadeComboBox.Enabled = True
        CEPTextBox.ReadOnly = False : CEPTextBox.Text = ""
        UFTextBox.ReadOnly = False : UFTextBox.Text = ""
        RGMaskedTextBox.ReadOnly = False
        CPFMaskedTextBox.ReadOnly = False
        TelefoneMaskedTextBox.ReadOnly = False
        FaxMaskedTextBox.ReadOnly = False
        TitulosAbertoSPCTextBox.ReadOnly = False
        IndicePontualidadeTextBox.ReadOnly = False
        DataCadastroTextBox.ReadOnly = False
        DataNascimentoTextBox.ReadOnly = False
        ObsTextBox.ReadOnly = False

        DiaHoje = Now.Day.ToString()
        MesHoje = Now.Month.ToString()
        AnoHoje = Now.Year.ToString()
        DataCadastroTextBox.Text = DiaHoje + "/" + MesHoje + "/" + AnoHoje

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If (NomeTextBox.Text = String.Empty) Then
            MessageBox.Show("Nome em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NomeTextBox.Focus()
            Exit Sub
        ElseIf (EnderecoTextBox.Text = String.Empty) Then
            MessageBox.Show("Endereço em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            EnderecoTextBox.Focus()
            Exit Sub
        ElseIf (BairroTextBox.Text = String.Empty) Then
            MessageBox.Show("Bairro em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BairroTextBox.Focus()
            Exit Sub
        ElseIf (CidadeComboBox.Text = String.Empty) Then
            MessageBox.Show("Cidade em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)        
            Exit Sub
        ElseIf (DataNascimentoTextBox.Text = String.Empty) Then
            MessageBox.Show("Data de Nascimento em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
        MessageBox.Show("Os Dados foram Salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.ClienteBindingNavigator.Enabled = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        NomeTextBox.ReadOnly = True
        EnderecoTextBox.ReadOnly = True
        BairroTextBox.ReadOnly = True
        ComplementoTextBox.ReadOnly = True
        CidadeComboBox.Enabled = False
        CEPTextBox.ReadOnly = True
        UFTextBox.ReadOnly = True
        RGMaskedTextBox.ReadOnly = True
        CPFMaskedTextBox.ReadOnly = True
        TelefoneMaskedTextBox.ReadOnly = True
        FaxMaskedTextBox.ReadOnly = True
        TitulosAbertoSPCTextBox.ReadOnly = True
        IndicePontualidadeTextBox.ReadOnly = True
        DataCadastroTextBox.ReadOnly = True
        DataNascimentoTextBox.ReadOnly = True
        ObsTextBox.ReadOnly = False

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.ClienteBindingSource.CancelEdit()
        Me.ClienteBindingNavigator.Enabled = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        NomeTextBox.ReadOnly = True
        EnderecoTextBox.ReadOnly = True
        BairroTextBox.ReadOnly = True
        ComplementoTextBox.ReadOnly = True
        CidadeComboBox.Enabled = True
        CEPTextBox.ReadOnly = True
        UFTextBox.ReadOnly = True
        RGMaskedTextBox.ReadOnly = True
        CPFMaskedTextBox.ReadOnly = True
        TelefoneMaskedTextBox.ReadOnly = True
        FaxMaskedTextBox.ReadOnly = True
        TitulosAbertoSPCTextBox.ReadOnly = True
        IndicePontualidadeTextBox.ReadOnly = True
        DataCadastroTextBox.ReadOnly = True
        DataNascimentoTextBox.ReadOnly = True
        ObsTextBox.ReadOnly = False



    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim resp As DialogResult
        If (Me.ClienteBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Alterar o Registro: " + CodigoClienteTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.ClienteBindingSource.CancelEdit()


                NomeTextBox.ReadOnly = False
                EnderecoTextBox.ReadOnly = False
                BairroTextBox.ReadOnly = False
                ComplementoTextBox.ReadOnly = False
                CidadeComboBox.Enabled = True
                CEPTextBox.ReadOnly = False
                UFTextBox.ReadOnly = False
                RGMaskedTextBox.ReadOnly = False
                CPFMaskedTextBox.ReadOnly = False
                TelefoneMaskedTextBox.ReadOnly = False
                FaxMaskedTextBox.ReadOnly = False
                TitulosAbertoSPCTextBox.ReadOnly = False
                IndicePontualidadeTextBox.ReadOnly = False
                DataCadastroTextBox.ReadOnly = False
                DataNascimentoTextBox.ReadOnly = False
                ObsTextBox.ReadOnly = False

                Me.ClienteBindingNavigator.Enabled = False
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False
    End Sub
    Private Sub CidadeComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CidadeComboBox.TextChanged
        Dim sql As String = "Select CEP, UF from Cidade Where Cidade = @Cidade"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)
        Dim reader As SqlDataReader

        Comando.Parameters.Clear()
        If (CidadeComboBox.Text <> "") Then
            Comando.Parameters.AddWithValue("@Cidade", CidadeComboBox.Text)
            Conexao.Open()

            reader = Comando.ExecuteReader()
            reader.Read()

            CEPTextBox.Text = reader(0).ToString()
            UFTextBox.Text = reader(1).ToString()
            reader.Close()
            Conexao.Close()
        End If
    End Sub

    Private Sub btnHistoricoVendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistoricoVendas.Click
        If CodigoClienteTextBox.Text <> "" Then
            CodigoCliente = CodigoClienteTextBox.Text
            My.Forms.frmHistoricoVendaCliente.ShowDialog()
            CodigoCliente = Nothing
        Else
            Exit Sub
        End If

    End Sub

    Private Sub frmCadCliente_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Desaparece(Me)
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
      
    End Sub
End Class