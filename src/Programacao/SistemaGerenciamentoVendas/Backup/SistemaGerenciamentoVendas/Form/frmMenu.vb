Imports System.Windows.Forms.Screen
Public Class frmMenu

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        Dim formCadCliente As New frmCadCliente
        formCadCliente.MdiParent = Me
        formCadCliente.Show()
    End Sub

    Private Sub btnCidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCidades.Click
        Dim formCadCidade As New frmCadCidade
        formCadCidade.MdiParent = Me
        formCadCidade.Show()
    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    'Dim Dia, Mes, Ano, Hora, Minuto, Segundo As String

    'Dia = DateTime.Today.Day
    'Mes = DateTime.Today.Month
    'Ano = DateTime.Today.Year

    'Hora = DateTime.Now.TimeOfDay.Hours
    'Minuto = DateTime.Now.TimeOfDay.Minutes
    'Segundo = DateTime.Now.TimeOfDay.Seconds

    'If Dia.Count = 1 Then
    '    Dia = "0" + Dia
    'End If
    'If Mes.Count = 1 Then
    '    Mes = "0" + Mes
    'End If
    'If Hora.Count = 1 Then
    '    Hora = "0" + Hora
    'End If
    'If Minuto.Count = 1 Then
    '    Minuto = "0" + Minuto
    'End If
    'If Segundo.Count = 1 Then
    '    Segundo = "0" + Segundo
    'End If

    'ToolStripStatusLabel6.Text = Dia + "/" + Mes + "/" + Ano
    'ToolStripStatusLabel4.Text = Hora + ":" + Minuto + ":" + Segundo
    'End Sub
    Public Sub New()
        InitializeComponent()

    End Sub
    Private Sub btnVendedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendedores.Click
        Dim formVendedores As New frmCadVendedores
        formVendedores.MdiParent = Me
        formVendedores.Show()
    End Sub

    Private Sub btnGrupos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupos.Click
        Dim formGrupos As New frmCadGrupo
        formGrupos.MdiParent = Me
        formGrupos.Show()
    End Sub
    Private Sub btnEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstoque.Click

        Dim formCadItemEstoque As New frmCadItemEstoque

        formCadItemEstoque.MdiParent = Me
        formCadItemEstoque.Show()
    End Sub
    Private Sub btnVendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendas.Click
        Dim formVendas As New frmVendas
        formVendas.MdiParent = Me
        formVendas.Show()
    End Sub
    Private Sub btnFormaPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormaPagamento.Click
        Dim formFormaPagamento As New frmCadFormaPagamento
        formFormaPagamento.MdiParent = Me
        formFormaPagamento.Show()
    End Sub

    Private Sub btnConCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim formConCliente As New frmConCliente
        formConCliente.MdiParent = Me
        formConCliente.Show()
    End Sub

    Private Sub btnPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagamento.Click
        Dim formPagamentoVendas As New frmPagamentoVendas
        formPagamentoVendas.MdiParent = Me
        formPagamentoVendas.Show()
    End Sub

    Private Sub btnTipoPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipoPagamento.Click
        Dim formTipoPagamento As New frmCadTipoPagamento
        formTipoPagamento.MdiParent = Me
        formTipoPagamento.Show()
    End Sub

    Private Sub btnConEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim formConEstoque As New frmConEstoque
        formConEstoque.MdiParent = Me
        formConEstoque.Show()
    End Sub
    Private Sub btnHistoricoCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim formHistoricoCompra As New frmHistoricoCompras
        formHistoricoCompra.MdiParent = Me
        formHistoricoCompra.Show()
    End Sub
    Private Sub btnHistoricoVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim formHistoricoVendas As New frmHistoricoVendas
        formHistoricoVendas.MdiParent = Me
        formHistoricoVendas.Show()
    End Sub

    Private Sub btnContasReceber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim formContasReceber As New frmContasReceber
        formContasReceber.MdiParent = Me
        formContasReceber.Show()
    End Sub
    Private Sub btnRelatorios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatorios.Click
        'Dim formRelatorios As New frmRelatorios
        'formRelatorios.MdiParent = Me
        'formRelatorios.Show()
        Dim form As New Form1
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub btnSobre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSobre.Click
        Dim formSobre As New frmSobre
        formSobre.MdiParent = Me
        formSobre.Show()
    End Sub

    Private Sub btnSeguranca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguranca.Click
        Dim formUsuario As New frmCadUsuario
        formUsuario.MdiParent = Me
        formUsuario.Show()
    End Sub
    Private Sub btnVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub btnHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub btnCascata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCascata.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = usuario

    End Sub

    Private Sub RibbonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton1.Click
        Dim formConsulta As New frmConsulta
        formConsulta.MdiParent = Me
        formConsulta.Show()
    End Sub

    Private Sub frmMenu_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
