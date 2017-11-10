<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelHistoricoCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelHistoricoCompra))
        Me.HistoricoCompraTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoCompraTableAdapter
        Me.crvHistoricoCompra = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.BancoDataSet1 = New SistemaGerenciamentoVendas.BancoDataSet
        Me.ItemEstoqueTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ItemEstoqueComboBox = New System.Windows.Forms.ComboBox
        Me.ItemEstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.TableAdapterManager = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ItemEstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HistoricoCompraTableAdapter1
        '
        Me.HistoricoCompraTableAdapter1.ClearBeforeFill = True
        '
        'crvHistoricoCompra
        '
        Me.crvHistoricoCompra.ActiveViewIndex = 0
        Me.crvHistoricoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvHistoricoCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvHistoricoCompra.Location = New System.Drawing.Point(0, 0)
        Me.crvHistoricoCompra.Name = "crvHistoricoCompra"
        Me.crvHistoricoCompra.ReportSource = Me.reportDocument1
        Me.crvHistoricoCompra.Size = New System.Drawing.Size(1156, 649)
        Me.crvHistoricoCompra.TabIndex = 0
        '
        'reportDocument1
        '
        Me.reportDocument1.FileName = "rassdk://D:\Faculdade\TCC\ProgramacaoVBNET\Programacao\SistemaGerenciamentoVendas" & _
            "\SistemaGerenciamentoVendas\Relatorios\relGraHistoricoCompra.rpt"
        '
        'BancoDataSet1
        '
        Me.BancoDataSet1.DataSetName = "BancoDataSet"
        Me.BancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemEstoqueTableAdapter1
        '
        Me.ItemEstoqueTableAdapter1.ClearBeforeFill = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.crvHistoricoCompra)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1156, 777)
        Me.SplitContainer1.SplitterDistance = 649
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ItemEstoqueComboBox)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(310, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 94)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar:"
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpar.Location = New System.Drawing.Point(524, 25)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(107, 54)
        Me.btnLimpar.TabIndex = 4
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item de Estoque"
        '
        'ItemEstoqueComboBox
        '
        Me.ItemEstoqueComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ItemEstoqueComboBox.DataSource = Me.ItemEstoqueBindingSource
        Me.ItemEstoqueComboBox.DisplayMember = "Descricao"
        Me.ItemEstoqueComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemEstoqueComboBox.FormattingEnabled = True
        Me.ItemEstoqueComboBox.Location = New System.Drawing.Point(4, 49)
        Me.ItemEstoqueComboBox.Name = "ItemEstoqueComboBox"
        Me.ItemEstoqueComboBox.Size = New System.Drawing.Size(394, 28)
        Me.ItemEstoqueComboBox.TabIndex = 2
        Me.ItemEstoqueComboBox.ValueMember = "CodigoItemEstoque"
        '
        'ItemEstoqueBindingSource
        '
        Me.ItemEstoqueBindingSource.DataMember = "ItemEstoque"
        Me.ItemEstoqueBindingSource.DataSource = Me.BancoDataSet1
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(414, 25)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(104, 54)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Filtrar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CidadeTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.GrupoTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoCompraTableAdapter = Me.HistoricoCompraTableAdapter1
        Me.TableAdapterManager.HistoricoVendaTableAdapter = Nothing
        Me.TableAdapterManager.ItemEstoqueTableAdapter = Me.ItemEstoqueTableAdapter1
        Me.TableAdapterManager.ItensVendasTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoVendaTableAdapter = Nothing
        Me.TableAdapterManager.TipoPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        '
        'frmRelHistoricoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 777)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelHistoricoCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Histórico de Compra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ItemEstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HistoricoCompraTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoCompraTableAdapter
    Friend WithEvents crvHistoricoCompra As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BancoDataSet1 As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents ItemEstoqueTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents ItemEstoqueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemEstoqueComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
End Class
