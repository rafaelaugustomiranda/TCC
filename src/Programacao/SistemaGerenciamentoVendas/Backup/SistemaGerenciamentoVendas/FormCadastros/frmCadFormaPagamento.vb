Public Class frmCadFormaPagamento

    Private Sub FormaPagamentoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub frmCadFormaPagamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        CodigoFormaPagamentoTextBox.ReadOnly = True
        FormaPagamentoTextBox.ReadOnly = True

        Me.FormaPagamentoTableAdapter.Fill(Me.BancoDataSet.FormaPagamento)

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False

        FormaPagamentoTextBox.ReadOnly = False

        FormaPagamentoBindingNavigator.Enabled = False
        Me.FormaPagamentoBindingSource.AddNew()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If (FormaPagamentoTextBox.Text = String.Empty) Then
            MessageBox.Show("Pagamento em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Validate()
        Me.FormaPagamentoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

        MessageBox.Show("Os Dados Foram Salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FormaPagamentoBindingNavigator.Enabled = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        FormaPagamentoTextBox.ReadOnly = True


    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim resp As DialogResult
        If (FormaPagamentoBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Alterar o Registro: " + CodigoFormaPagamentoTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.FormaPagamentoBindingSource.CancelEdit()

                FormaPagamentoTextBox.ReadOnly = False

                btnNovo.Enabled = False
                btnSalvar.Enabled = True
                btnAlterar.Enabled = False
                btnCancelar.Enabled = True
                btnExcluir.Enabled = False

                FormaPagamentoBindingNavigator.Enabled = False
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.FormaPagamentoBindingSource.CancelEdit()

        FormaPagamentoTextBox.ReadOnly = True
        FormaPagamentoBindingNavigator.Enabled = True
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim resp As DialogResult
        If (FormaPagamentoBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Realmente excluir o registro: " + CodigoFormaPagamentoTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.FormaPagamentoBindingSource.RemoveCurrent()
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

  
End Class