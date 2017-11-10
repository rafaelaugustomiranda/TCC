Public Class frmCadCidade

    Private Sub frmCadCidade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BancoDataSet.Cidade' table. You can move, or remove it, as needed.
        Me.CidadeTableAdapter.Fill(Me.BancoDataSet.Cidade)
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        CodigoCidadeTextBox.ReadOnly = True
        CidadeTextBox.ReadOnly = True
        CEPMaskedTextBox.ReadOnly = True
        UFTextBox.ReadOnly = True
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False

        CidadeTextBox.ReadOnly = False
        CEPMaskedTextBox.ReadOnly = False
        UFTextBox.ReadOnly = False
        Me.CidadeBindingSource.AddNew()
        CidadeBindingNavigator.Enabled = False
        
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        If (CidadeTextBox.Text = String.Empty) Then
            MessageBox.Show("Cidade em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CidadeTextBox.Focus()
            Exit Sub
        ElseIf (CEPMaskedTextBox.Text = String.Empty) Then
            MessageBox.Show("CEP da Cidade em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CEPMaskedTextBox.Focus()
            Exit Sub
        ElseIf (UFTextBox.Text = String.Empty) Then
            MessageBox.Show("UF da Cidade em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UFTextBox.Focus()
            Exit Sub
        End If

        Me.Validate()
        Me.CidadeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
        MessageBox.Show("Os Dados Foram Salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        CidadeBindingNavigator.Enabled = True
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        CidadeTextBox.ReadOnly = True
        CEPMaskedTextBox.ReadOnly = True
        UFTextBox.ReadOnly = True

       
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click

        Dim resp As DialogResult
        If (CidadeBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Alterar o Registro: " + CodigoCidadeTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.CidadeBindingSource.CancelEdit()
                CidadeTextBox.ReadOnly = False
                CEPMaskedTextBox.ReadOnly = False
                UFTextBox.ReadOnly = False
                CidadeBindingNavigator.Enabled = False
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
      
        Me.CidadeBindingSource.CancelEdit()

        CidadeTextBox.ReadOnly = True
        CEPMaskedTextBox.ReadOnly = True
        UFTextBox.ReadOnly = True
        CidadeBindingNavigator.Enabled = True
       
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Dim resp As DialogResult
        If (CidadeBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Realmente excluir o registro: " + CodigoCidadeTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.CidadeBindingSource.RemoveCurrent()
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

   
    Private Sub UFTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UFTextBox.Leave
        UFTextBox.Text = UCase(UFTextBox.Text)
    End Sub
End Class