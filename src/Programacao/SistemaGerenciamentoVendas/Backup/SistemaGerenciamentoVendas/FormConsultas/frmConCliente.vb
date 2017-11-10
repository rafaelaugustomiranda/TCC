Public Class frmConCliente

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BancoDataSet)

    End Sub

    Private Sub frmConCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClienteTableAdapter.Fill(Me.BancoDataSet.Cliente)
        Label10.Text = ClienteDataGridView.RowCount

    End Sub
    Private Sub txtCampo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampo.TextChanged
        If rbNome.Checked = True Then
            If (txtCampo.Text <> String.Empty) Then
                ClienteBindingSource.Filter = "Nome like '%" + txtCampo.Text + "%'"
                Label10.Text = ClienteDataGridView.RowCount
            Else
                removeFiltro(ClienteBindingSource)
                Label10.Text = ClienteDataGridView.RowCount
            End If
        End If
        If rbCodigo.Checked = True Then
            If (txtCampo.Text <> String.Empty) Then
                ClienteBindingSource.Filter = "CodigoCliente = " + txtCampo.Text
                Label10.Text = ClienteDataGridView.RowCount
            Else
                removeFiltro(ClienteBindingSource)
                Label10.Text = ClienteDataGridView.RowCount
            End If
        End If
    End Sub

    Private Sub ClienteDataGridView_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ClienteDataGridView.MouseDoubleClick
        Dim itemFound As Integer = ClienteBindingSource.Find("Nome", ClienteDataGridView.CurrentRow.Cells(1).Value.ToString())
        My.Forms.frmCadCliente.Show()
        My.Forms.frmCadCliente.ClienteBindingSource.Position = itemFound
    End Sub

End Class