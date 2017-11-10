<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelHistoricoVenda
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.HistoricoVendaTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoVendaTableAdapter
        Me.BancoDataSet1 = New SistemaGerenciamentoVendas.BancoDataSet
        Me.crvHistoricoVenda = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.ItemEstoqueTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.crvHistoricoVenda)
        Me.SplitContainer1.Size = New System.Drawing.Size(1145, 770)
        Me.SplitContainer1.SplitterDistance = 678
        Me.SplitContainer1.TabIndex = 0
        '
        'HistoricoVendaTableAdapter1
        '
        Me.HistoricoVendaTableAdapter1.ClearBeforeFill = True
        '
        'BancoDataSet1
        '
        Me.BancoDataSet1.DataSetName = "BancoDataSet"
        Me.BancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'crvHistoricoVenda
        '
        Me.crvHistoricoVenda.ActiveViewIndex = 0
        Me.crvHistoricoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvHistoricoVenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvHistoricoVenda.Location = New System.Drawing.Point(0, 0)
        Me.crvHistoricoVenda.Name = "crvHistoricoVenda"
        Me.crvHistoricoVenda.ReportSource = Me.reportDocument1
        Me.crvHistoricoVenda.Size = New System.Drawing.Size(1145, 678)
        Me.crvHistoricoVenda.TabIndex = 0
        '
        'reportDocument1
        '
        Me.reportDocument1.FileName = "rassdk://D:\Faculdade\TCC\ProgramacaoVBNET\Programacao\SistemaGerenciamentoVendas" & _
            "\SistemaGerenciamentoVendas\Relatorios\relGraHistoricoVenda.rpt"
        '
        'ItemEstoqueTableAdapter1
        '
        Me.ItemEstoqueTableAdapter1.ClearBeforeFill = True
        '
        'frmRelHistoricoVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 770)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmRelHistoricoVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Relatório de Histórico de Vendas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents crvHistoricoVenda As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents HistoricoVendaTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoVendaTableAdapter
    Friend WithEvents BancoDataSet1 As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents ItemEstoqueTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
End Class
