<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelPagamentoVendas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crvPagamentoVendas = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ClienteTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
        Me.PagamentoVendaTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.PagamentoVendaTableAdapter
        Me.BancoDataSet1 = New SistemaGerenciamentoVendas.BancoDataSet
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crvPagamentoVendas
        '
        Me.crvPagamentoVendas.ActiveViewIndex = 0
        Me.crvPagamentoVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvPagamentoVendas.DisplayGroupTree = False
        Me.crvPagamentoVendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvPagamentoVendas.Location = New System.Drawing.Point(0, 0)
        Me.crvPagamentoVendas.Name = "crvPagamentoVendas"
        Me.crvPagamentoVendas.ReportSource = Me.reportDocument1
        Me.crvPagamentoVendas.Size = New System.Drawing.Size(884, 696)
        Me.crvPagamentoVendas.TabIndex = 0
        '
        'ClienteTableAdapter1
        '
        Me.ClienteTableAdapter1.ClearBeforeFill = True
        '
        'PagamentoVendaTableAdapter1
        '
        Me.PagamentoVendaTableAdapter1.ClearBeforeFill = True
        '
        'BancoDataSet1
        '
        Me.BancoDataSet1.DataSetName = "BancoDataSet"
        Me.BancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reportDocument1
        '
        Me.reportDocument1.FileName = "rassdk://D:\Faculdade\TCC\ProgramacaoVBNET\Programacao\SistemaGerenciamentoVendas" & _
            "\SistemaGerenciamentoVendas\Relatorios\relGraPagamentoVendas.rpt"
        '
        'frmRelPagamentoVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 696)
        Me.Controls.Add(Me.crvPagamentoVendas)
        Me.Name = "frmRelPagamentoVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de PagamentoVendas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvPagamentoVendas As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ClienteTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents PagamentoVendaTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.PagamentoVendaTableAdapter
    Friend WithEvents BancoDataSet1 As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
End Class
