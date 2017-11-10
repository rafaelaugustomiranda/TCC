Imports System.Data.SqlClient
Public Class frmRelClientes
    Dim relatorioClientes As New relClientes
    Private Sub frmrelClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)
        Me.CidadeTableAdapter1.Fill(Me.BancoDataSet1.Cidade)
        relatorioClientes.SetDataSource(Me.BancoDataSet1)
        crvClientes.ReportSource = relatorioClientes
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim formRelCliente As New frmRelClientes
        If (rbCodigo.Checked = True) And (txtCampo.Text <> "") Then
            Me.ClienteTableAdapter1.FillByRelCodigoNome(Me.BancoDataSet1.Cliente, txtCampo.Text, Nothing)
            Me.CidadeTableAdapter1.Fill(Me.BancoDataSet1.Cidade)
        ElseIf (rbNome.Checked = True) And (txtCampo.Text <> "") Then
            Me.ClienteTableAdapter1.FillByRelCodigoNome(Me.BancoDataSet1.Cliente, Nothing, txtCampo.Text)
            Me.CidadeTableAdapter1.Fill(Me.BancoDataSet1.Cidade)
        End If
        relatorioClientes.SetDataSource(Me.BancoDataSet1)
        crvClientes.ReportSource = relatorioClientes

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Me.ClienteTableAdapter1.Fill(Me.BancoDataSet1.Cliente)
        Me.CidadeTableAdapter1.Fill(Me.BancoDataSet1.Cidade)
        relatorioClientes.SetDataSource(Me.BancoDataSet1)
        crvClientes.ReportSource = relatorioClientes
    End Sub
End Class