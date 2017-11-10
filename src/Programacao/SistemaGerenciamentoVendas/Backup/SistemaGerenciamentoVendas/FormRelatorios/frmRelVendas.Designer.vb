<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelVendas
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelVendas))
        Me.crvHistoricoVenda = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet1 = New SistemaGerenciamentoVendas.BancoDataSet
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.ClienteTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
        Me.FormaPagamentoTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.FormaPagamentoTableAdapter
        Me.ItemEstoqueTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
        Me.ItensVendasTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItensVendasTableAdapter
        Me.VendasTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendasTableAdapter
        Me.VendedorTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendedorTableAdapter
        Me.TipoPagamentoTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TipoPagamentoTableAdapter
        Me.TableAdapterManager = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crvHistoricoVenda
        '
        Me.crvHistoricoVenda.ActiveViewIndex = 0
        Me.crvHistoricoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvHistoricoVenda.DisplayGroupTree = False
        Me.crvHistoricoVenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvHistoricoVenda.Location = New System.Drawing.Point(0, 0)
        Me.crvHistoricoVenda.Name = "crvHistoricoVenda"
        Me.crvHistoricoVenda.ReportSource = Me.reportDocument1
        Me.crvHistoricoVenda.ShowGroupTreeButton = False
        Me.crvHistoricoVenda.Size = New System.Drawing.Size(1185, 631)
        Me.crvHistoricoVenda.TabIndex = 0
        '
        'reportDocument1
        '
        Me.reportDocument1.FileName = "rassdk://D:\Faculdade\TCC\ProgramacaoVBNET\Programacao\SistemaGerenciamentoVendas" & _
            "\SistemaGerenciamentoVendas\Relatorios\relVendas.rpt"
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
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1185, 748)
        Me.SplitContainer1.SplitterDistance = 631
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.ClienteComboBox)
        Me.GroupBox1.Controls.Add(Me.btnLimpar)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(308, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 107)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por Cliente:"
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DataSource = Me.ClienteBindingSource
        Me.ClienteComboBox.DisplayMember = "Nome"
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(45, 46)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(300, 28)
        Me.ClienteComboBox.TabIndex = 17
        Me.ClienteComboBox.ValueMember = "CodigoCliente"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.BancoDataSet1
        '
        'BancoDataSet1
        '
        Me.BancoDataSet1.DataSetName = "BancoDataSet"
        Me.BancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpar.Location = New System.Drawing.Point(459, 31)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(109, 57)
        Me.btnLimpar.TabIndex = 17
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(351, 31)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(102, 57)
        Me.btnConsultar.TabIndex = 15
        Me.btnConsultar.Text = "Filtrar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'ClienteTableAdapter1
        '
        Me.ClienteTableAdapter1.ClearBeforeFill = True
        '
        'FormaPagamentoTableAdapter1
        '
        Me.FormaPagamentoTableAdapter1.ClearBeforeFill = True
        '
        'ItemEstoqueTableAdapter1
        '
        Me.ItemEstoqueTableAdapter1.ClearBeforeFill = True
        '
        'ItensVendasTableAdapter1
        '
        Me.ItensVendasTableAdapter1.ClearBeforeFill = True
        '
        'VendasTableAdapter1
        '
        Me.VendasTableAdapter1.ClearBeforeFill = True
        '
        'VendedorTableAdapter1
        '
        Me.VendedorTableAdapter1.ClearBeforeFill = True
        '
        'TipoPagamentoTableAdapter1
        '
        Me.TipoPagamentoTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CidadeTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter1
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Me.FormaPagamentoTableAdapter1
        Me.TableAdapterManager.GrupoTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoCompraTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoVendaTableAdapter = Nothing
        Me.TableAdapterManager.ItemEstoqueTableAdapter = Me.ItemEstoqueTableAdapter1
        Me.TableAdapterManager.ItensVendasTableAdapter = Me.ItensVendasTableAdapter1
        Me.TableAdapterManager.PagamentoVendaTableAdapter = Nothing
        Me.TableAdapterManager.TipoPagamentoTableAdapter = Me.TipoPagamentoTableAdapter1
        Me.TableAdapterManager.UpdateOrder = SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Me.VendasTableAdapter1
        Me.TableAdapterManager.VendedorTableAdapter = Me.VendedorTableAdapter1
        '
        'frmRelVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 748)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelVendas"
        Me.Text = "Relatório de Vendas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClienteTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents FormaPagamentoTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.FormaPagamentoTableAdapter
    Friend WithEvents ItemEstoqueTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
    Friend WithEvents ItensVendasTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItensVendasTableAdapter
    Friend WithEvents BancoDataSet1 As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents VendasTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendasTableAdapter
    Friend WithEvents VendedorTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendedorTableAdapter
    Friend WithEvents TipoPagamentoTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TipoPagamentoTableAdapter
    Friend WithEvents crvHistoricoVenda As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteComboBox As System.Windows.Forms.ComboBox
End Class
