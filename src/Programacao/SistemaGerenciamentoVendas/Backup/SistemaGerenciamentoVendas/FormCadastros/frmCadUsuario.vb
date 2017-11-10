Public Class frmCadUsuario

    Private Sub UsuariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmCadUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UsuariosTableAdapter.Fill(Me.BancoDataSet.Usuarios)
        CodigoUsuarioTextBox.ReadOnly = True
        UsuarioTextBox.ReadOnly = True
        SenhaTextBox.ReadOnly = True


    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Me.UsuariosBindingSource.AddNew()
        Me.UsuariosBindingNavigator.Enabled = False

        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False

        UsuarioTextBox.ReadOnly = False
        SenhaTextBox.ReadOnly = False

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If (UsuarioTextBox.Text = String.Empty) Then
            MessageBox.Show("Nome de Usuário em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UsuarioTextBox.Focus()
            Exit Sub
        ElseIf (SenhaTextBox.Text = String.Empty) Then
            MessageBox.Show("Senha em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SenhaTextBox.Focus()
            Exit Sub
        End If

        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)


        MessageBox.Show("Os Dados foram Salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.UsuariosBindingNavigator.Enabled = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        UsuarioTextBox.ReadOnly = True
        SenhaTextBox.ReadOnly = True


    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim resp As DialogResult
        If (Me.UsuariosBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Alterar o Registro: " + CodigoUsuarioTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.UsuariosBindingSource.CancelEdit()
                UsuarioTextBox.ReadOnly = True
                SenhaTextBox.ReadOnly = True
                Me.UsuariosBindingNavigator.Enabled = False
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        UsuarioTextBox.ReadOnly = False
        SenhaTextBox.ReadOnly = False

        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.UsuariosBindingSource.CancelEdit()
        Me.UsuariosBindingNavigator.Enabled = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True

        UsuarioTextBox.ReadOnly = True
        SenhaTextBox.ReadOnly = True
      
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim resp As DialogResult
        If (UsuariosBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Realmente excluir o registro: " + CodigoUsuarioTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.UsuariosBindingSource.RemoveCurrent()
                Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class