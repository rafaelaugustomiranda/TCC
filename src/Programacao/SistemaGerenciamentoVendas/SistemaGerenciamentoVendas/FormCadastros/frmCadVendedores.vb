Public Class frmCadVendedores
    Dim visivelA As Boolean
    Dim visivelD As Boolean
    Dim Dia, Mes, Ano, Data As String
    Private Sub VendedorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VendedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

    End Sub

    Private Sub frmCadVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BancoDataSet.Vendedor' table. You can move, or remove it, as needed.
        Me.VendedorTableAdapter.Fill(Me.BancoDataSet.Vendedor)

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True
        btnCalendarioAdmissao.Enabled = False
        btnCalendarioDemissao.Enabled = False

        CodigoVendedorTextBox.ReadOnly = True
        VendedorTextBox.ReadOnly = True
        DataAdmissaoTextBox.ReadOnly = True
        DataDemissaoTextBox.ReadOnly = True

        visivelA = False
        visivelD = False
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnAlterar.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False
        btnCalendarioAdmissao.Enabled = True
        btnCalendarioAdmissao.Enabled = True

        CodigoVendedorTextBox.ReadOnly = False
        VendedorTextBox.ReadOnly = False
        DataAdmissaoTextBox.ReadOnly = False
        DataDemissaoTextBox.ReadOnly = False

        Me.VendedorBindingSource.AddNew()
        VendedorBindingNavigator.Enabled = False

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If (VendedorTextBox.Text = String.Empty) Then
            MessageBox.Show("Vendedor em Branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.Validate()
        Me.VendedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)
        MessageBox.Show("Os Dados Foram Salvo com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        VendedorBindingNavigator.Enabled = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True
        btnCalendarioAdmissao.Enabled = False
        btnCalendarioAdmissao.Enabled = False

        CodigoVendedorTextBox.ReadOnly = True
        VendedorTextBox.ReadOnly = True
        DataAdmissaoTextBox.ReadOnly = True
        DataDemissaoTextBox.ReadOnly = True

    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim resp As DialogResult
        If (VendedorBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Alterar o Registro: " + CodigoVendedorTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.VendedorBindingSource.CancelEdit()

                CodigoVendedorTextBox.ReadOnly = False
                VendedorTextBox.ReadOnly = False
                DataAdmissaoTextBox.ReadOnly = False
                DataDemissaoTextBox.ReadOnly = False
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
        btnCalendarioAdmissao.Enabled = True
        btnCalendarioAdmissao.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.VendedorBindingSource.CancelEdit()

        CodigoVendedorTextBox.ReadOnly = True
        VendedorTextBox.ReadOnly = True
        DataAdmissaoTextBox.ReadOnly = True
        DataDemissaoTextBox.ReadOnly = True

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnAlterar.Enabled = True
        btnCancelar.Enabled = False
        btnExcluir.Enabled = True
        btnCalendarioAdmissao.Enabled = False
        btnCalendarioAdmissao.Enabled = False
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim resp As DialogResult
        If (VendedorBindingSource.Count > 0) Then
            resp = MessageBox.Show("Deseja Realmente excluir o registro: " + CodigoVendedorTextBox.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (resp = System.Windows.Forms.DialogResult.Yes) Then
                Me.VendedorBindingSource.RemoveCurrent()
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("Não Existe Registro para ser Excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCalendarioAdmissao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalendarioAdmissao.Click
        If visivelA = False Then
            Calendario1.Visible = True


            visivelA = True
        Else
            Calendario1.Visible = False
            visivelA = False
        End If
    End Sub

    Private Sub Calendario1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario1.DateChanged

        Dia = Calendario1.SelectionStart.Day
        Mes = Calendario1.SelectionStart.Month
        Ano = Calendario1.SelectionStart.Year
        Data = Dia + "/" + Mes + "/" + Ano

        DataAdmissaoTextBox.Text = Data
        Calendario1.Visible = False
        visivelA = False
        Dia = "" : Mes = "" : Ano = "" : Data = ""
    End Sub

    Private Sub btnCalendarioDemissao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalendarioDemissao.Click
        If visivelD = False Then
            Calendario2.Visible = True
            visivelD = True
        Else
            Calendario2.Visible = False
            visivelD = False
        End If
    End Sub

    Private Sub Calendario2_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario2.DateChanged
        Dia = Calendario2.SelectionStart.Day
        Mes = Calendario2.SelectionStart.Month
        Ano = Calendario2.SelectionStart.Year
        Data = Dia + "/" + Mes + "/" + Ano

        DataDemissaoTextBox.Text = Data
        Calendario2.Visible = False
        visivelD = False
        Dia = "" : Mes = "" : Ano = "" : Data = ""
    End Sub
End Class