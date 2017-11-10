Public Class frmCadTipoPagamento

    Private Sub TipoPagamentoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub frmCadTipoPagamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TipoPagamentoTableAdapter.Fill(Me.BancoDataSet.TipoPagamento)
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        CodigoTipoPagamentoTextBox.ReadOnly = True
        TipoPagamentoTextBox.ReadOnly = True

        Me.TipoPagamentoTableAdapter.Fill(Me.BancoDataSet.TipoPagamento)
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        


        If (TipoPagamentoTextBox.Text = String.Empty) Then
            MessageBox.Show("Pagamento em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Validate()
        Me.TipoPagamentoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

        MessageBox.Show("Os Dados Foram Salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TipoPagamentoBindingNavigator.Enabled = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        TipoPagamentoTextBox.ReadOnly = True
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False

        TipoPagamentoTextBox.ReadOnly = False

        TipoPagamentoBindingNavigator.Enabled = False
        Me.TipoPagamentoBindingSource.AddNew()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim resp As DialogResult
        If (TipoPagamentoBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Alterar o Registro: " + CodigoTipoPagamentoTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.TipoPagamentoBindingSource.CancelEdit()

                TipoPagamentoTextBox.ReadOnly = False

                btnNovo.Enabled = False
                btnSalvar.Enabled = True
                btnAlterar.Enabled = False
                btnCancelar.Enabled = True
                btnExcluir.Enabled = False

                TipoPagamentoBindingNavigator.Enabled = False
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.TipoPagamentoBindingSource.CancelEdit()

        TipoPagamentoTextBox.ReadOnly = True
        TipoPagamentoBindingNavigator.Enabled = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim resp As DialogResult
        If (TipoPagamentoBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Realmente excluir o registro: " + CodigoTipoPagamentoTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.TipoPagamentoBindingSource.RemoveCurrent()
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class