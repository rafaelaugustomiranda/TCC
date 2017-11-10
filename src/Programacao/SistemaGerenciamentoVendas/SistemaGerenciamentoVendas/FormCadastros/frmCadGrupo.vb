Public Class frmCadGrupo

    Private Sub GrupoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GrupoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

    End Sub

    Private Sub frmCadGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        CodigoGrupoTextBox.ReadOnly = True
        GrupoTextBox.ReadOnly = True

        Me.GrupoTableAdapter.Fill(Me.BancoDataSet.Grupo)

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False

        CodigoGrupoTextBox.ReadOnly = False
        GrupoTextBox.ReadOnly = False

        GrupoBindingNavigator.Enabled = False
        Me.GrupoBindingSource.AddNew()
        
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If (CodigoGrupoTextBox.Text = String.Empty) Then
            MessageBox.Show("Codigo em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If (GrupoTextBox.Text = String.Empty) Then
            MessageBox.Show("Grupo em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Validate()
        Me.GrupoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
        MessageBox.Show("Os Dados Foram Salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        GrupoBindingNavigator.Enabled = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        CodigoGrupoTextBox.ReadOnly = True
        GrupoTextBox.ReadOnly = True

    End Sub

    Private Sub GrupoBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GrupoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

    End Sub
    Private Sub GrupoBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GrupoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim resp As DialogResult
        If (GrupoBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Alterar o Registro: " + CodigoGrupoTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.GrupoBindingSource.CancelEdit()
                CodigoGrupoTextBox.ReadOnly = False
                GrupoTextBox.ReadOnly = False


                btnNovo.Enabled = False
                btnSalvar.Enabled = True
                btnAlterar.Enabled = False
                btnCancelar.Enabled = True
                btnExcluir.Enabled = False
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.GrupoBindingSource.CancelEdit()
        Me.GrupoBindingNavigator.Enabled = True
        CodigoGrupoTextBox.ReadOnly = True
        GrupoTextBox.ReadOnly = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

       
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim resp As DialogResult
        If (GrupoBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Realmente excluir o registro: " + CodigoGrupoTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.GrupoBindingSource.RemoveCurrent()
                TableAdapterManager.UpdateAll(Me.BancoDataSet)
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class