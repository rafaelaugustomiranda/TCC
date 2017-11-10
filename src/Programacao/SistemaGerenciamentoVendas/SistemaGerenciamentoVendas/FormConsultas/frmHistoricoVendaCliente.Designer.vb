<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoricoVendaCliente
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
        Dim CodigoVendaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoricoVendaCliente))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BancoDataSet = New SistemaGerenciamentoVendas.BancoDataSet
        Me.TableAdapterManager = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
        Me.ItensVendasTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItensVendasTableAdapter
        Me.VendasTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendasTableAdapter
        Me.VendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasDataGridView = New System.Windows.Forms.DataGridView
        Me.CodigoVendaTextBox = New System.Windows.Forms.TextBox
        Me.lblCliente = New System.Windows.Forms.Label
        Me.lblNome = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ItensVendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CodigoVendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoTipoPagamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFormaPagamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataVendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorDescontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorLiquidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtdeParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor1ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Data1ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor2ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Data2ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor3ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Data3ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor4ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Data4ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor5ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Data5ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor6ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Data6ParcelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoVendaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoItemEstoqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QuantidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CodigoVendaLabel = New System.Windows.Forms.Label
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItensVendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoVendaLabel
        '
        CodigoVendaLabel.AutoSize = True
        CodigoVendaLabel.Location = New System.Drawing.Point(721, 216)
        CodigoVendaLabel.Name = "CodigoVendaLabel"
        CodigoVendaLabel.Size = New System.Drawing.Size(77, 13)
        CodigoVendaLabel.TabIndex = 7
        CodigoVendaLabel.Text = "Codigo Venda:"
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "BancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CidadeTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.GrupoTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoCompraTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoVendaTableAdapter = Nothing
        Me.TableAdapterManager.ItemEstoqueTableAdapter = Nothing
        Me.TableAdapterManager.ItensVendasTableAdapter = Me.ItensVendasTableAdapter
        Me.TableAdapterManager.PagamentoVendaTableAdapter = Nothing
        Me.TableAdapterManager.TipoPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Me.VendasTableAdapter
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        '
        'ItensVendasTableAdapter
        '
        Me.ItensVendasTableAdapter.ClearBeforeFill = True
        '
        'VendasTableAdapter
        '
        Me.VendasTableAdapter.ClearBeforeFill = True
        '
        'VendasBindingSource
        '
        Me.VendasBindingSource.DataMember = "Vendas"
        Me.VendasBindingSource.DataSource = Me.BancoDataSet
        '
        'VendasDataGridView
        '
        Me.VendasDataGridView.AllowUserToAddRows = False
        Me.VendasDataGridView.AllowUserToDeleteRows = False
        Me.VendasDataGridView.AllowUserToResizeColumns = False
        Me.VendasDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VendasDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.VendasDataGridView.AutoGenerateColumns = False
        Me.VendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VendasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoVendaDataGridViewTextBoxColumn, Me.CodigoClienteDataGridViewTextBoxColumn, Me.CodigoVendedorDataGridViewTextBoxColumn, Me.CodigoTipoPagamentoDataGridViewTextBoxColumn, Me.CodigoFormaPagamentoDataGridViewTextBoxColumn, Me.DataVendaDataGridViewTextBoxColumn, Me.ValorCompraDataGridViewTextBoxColumn, Me.ValorEntradaDataGridViewTextBoxColumn, Me.ValorDescontoDataGridViewTextBoxColumn, Me.ValorLiquidoDataGridViewTextBoxColumn, Me.QtdeParcelaDataGridViewTextBoxColumn, Me.Valor1ParcelaDataGridViewTextBoxColumn, Me.Data1ParcelaDataGridViewTextBoxColumn, Me.Valor2ParcelaDataGridViewTextBoxColumn, Me.Data2ParcelaDataGridViewTextBoxColumn, Me.Valor3ParcelaDataGridViewTextBoxColumn, Me.Data3ParcelaDataGridViewTextBoxColumn, Me.Valor4ParcelaDataGridViewTextBoxColumn, Me.Data4ParcelaDataGridViewTextBoxColumn, Me.Valor5ParcelaDataGridViewTextBoxColumn, Me.Data5ParcelaDataGridViewTextBoxColumn, Me.Valor6ParcelaDataGridViewTextBoxColumn, Me.Data6ParcelaDataGridViewTextBoxColumn})
        Me.VendasDataGridView.DataSource = Me.VendasBindingSource
        Me.VendasDataGridView.Location = New System.Drawing.Point(10, 19)
        Me.VendasDataGridView.Name = "VendasDataGridView"
        Me.VendasDataGridView.ReadOnly = True
        Me.VendasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VendasDataGridView.Size = New System.Drawing.Size(623, 180)
        Me.VendasDataGridView.TabIndex = 5
        '
        'CodigoVendaTextBox
        '
        Me.CodigoVendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "CodigoVenda", True))
        Me.CodigoVendaTextBox.Location = New System.Drawing.Point(698, 249)
        Me.CodigoVendaTextBox.Name = "CodigoVendaTextBox"
        Me.CodigoVendaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoVendaTextBox.TabIndex = 8
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(12, 140)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(62, 20)
        Me.lblCliente.TabIndex = 9
        Me.lblCliente.Text = "Cliente:"
        '
        'lblNome
        '
        Me.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(125, 140)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(531, 22)
        Me.lblNome.TabIndex = 10
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(72, 140)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(47, 22)
        Me.lblCodigo.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VendasDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 209)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vendas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 380)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(645, 230)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Itens de Venda"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoVendaDataGridViewTextBoxColumn1, Me.CodigoItemEstoqueDataGridViewTextBoxColumn, Me.ValorItemDataGridViewTextBoxColumn, Me.QuantidadeDataGridViewTextBoxColumn, Me.ValorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItensVendasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(10, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(623, 194)
        Me.DataGridView1.TabIndex = 0
        '
        'ItensVendasBindingSource
        '
        Me.ItensVendasBindingSource.DataMember = "ItensVendas"
        Me.ItensVendasBindingSource.DataSource = Me.BancoDataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(700, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'CodigoVendaDataGridViewTextBoxColumn
        '
        Me.CodigoVendaDataGridViewTextBoxColumn.DataPropertyName = "CodigoVenda"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.CodigoVendaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CodigoVendaDataGridViewTextBoxColumn.HeaderText = "Nº Venda"
        Me.CodigoVendaDataGridViewTextBoxColumn.Name = "CodigoVendaDataGridViewTextBoxColumn"
        Me.CodigoVendaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoVendaDataGridViewTextBoxColumn.Width = 76
        '
        'CodigoClienteDataGridViewTextBoxColumn
        '
        Me.CodigoClienteDataGridViewTextBoxColumn.DataPropertyName = "CodigoCliente"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.CodigoClienteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CodigoClienteDataGridViewTextBoxColumn.HeaderText = "CodigoCliente"
        Me.CodigoClienteDataGridViewTextBoxColumn.Name = "CodigoClienteDataGridViewTextBoxColumn"
        Me.CodigoClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoClienteDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoVendedorDataGridViewTextBoxColumn
        '
        Me.CodigoVendedorDataGridViewTextBoxColumn.DataPropertyName = "CodigoVendedor"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.CodigoVendedorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CodigoVendedorDataGridViewTextBoxColumn.HeaderText = "CodigoVendedor"
        Me.CodigoVendedorDataGridViewTextBoxColumn.Name = "CodigoVendedorDataGridViewTextBoxColumn"
        Me.CodigoVendedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoVendedorDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoTipoPagamentoDataGridViewTextBoxColumn
        '
        Me.CodigoTipoPagamentoDataGridViewTextBoxColumn.DataPropertyName = "CodigoTipoPagamento"
        Me.CodigoTipoPagamentoDataGridViewTextBoxColumn.HeaderText = "CodigoTipoPagamento"
        Me.CodigoTipoPagamentoDataGridViewTextBoxColumn.Name = "CodigoTipoPagamentoDataGridViewTextBoxColumn"
        Me.CodigoTipoPagamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoTipoPagamentoDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoFormaPagamentoDataGridViewTextBoxColumn
        '
        Me.CodigoFormaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "CodigoFormaPagamento"
        Me.CodigoFormaPagamentoDataGridViewTextBoxColumn.HeaderText = "CodigoFormaPagamento"
        Me.CodigoFormaPagamentoDataGridViewTextBoxColumn.Name = "CodigoFormaPagamentoDataGridViewTextBoxColumn"
        Me.CodigoFormaPagamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoFormaPagamentoDataGridViewTextBoxColumn.Visible = False
        '
        'DataVendaDataGridViewTextBoxColumn
        '
        Me.DataVendaDataGridViewTextBoxColumn.DataPropertyName = "DataVenda"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DataVendaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataVendaDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataVendaDataGridViewTextBoxColumn.Name = "DataVendaDataGridViewTextBoxColumn"
        Me.DataVendaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DataVendaDataGridViewTextBoxColumn.Width = 55
        '
        'ValorCompraDataGridViewTextBoxColumn
        '
        Me.ValorCompraDataGridViewTextBoxColumn.DataPropertyName = "ValorCompra"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.ValorCompraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.ValorCompraDataGridViewTextBoxColumn.HeaderText = "Valor R$"
        Me.ValorCompraDataGridViewTextBoxColumn.Name = "ValorCompraDataGridViewTextBoxColumn"
        Me.ValorCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorCompraDataGridViewTextBoxColumn.Width = 75
        '
        'ValorEntradaDataGridViewTextBoxColumn
        '
        Me.ValorEntradaDataGridViewTextBoxColumn.DataPropertyName = "ValorEntrada"
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.ValorEntradaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.ValorEntradaDataGridViewTextBoxColumn.HeaderText = "Entrada R$"
        Me.ValorEntradaDataGridViewTextBoxColumn.Name = "ValorEntradaDataGridViewTextBoxColumn"
        Me.ValorEntradaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorEntradaDataGridViewTextBoxColumn.Width = 85
        '
        'ValorDescontoDataGridViewTextBoxColumn
        '
        Me.ValorDescontoDataGridViewTextBoxColumn.DataPropertyName = "ValorDesconto"
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.ValorDescontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ValorDescontoDataGridViewTextBoxColumn.HeaderText = "Desconto R$"
        Me.ValorDescontoDataGridViewTextBoxColumn.Name = "ValorDescontoDataGridViewTextBoxColumn"
        Me.ValorDescontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorDescontoDataGridViewTextBoxColumn.Width = 95
        '
        'ValorLiquidoDataGridViewTextBoxColumn
        '
        Me.ValorLiquidoDataGridViewTextBoxColumn.DataPropertyName = "ValorLiquido"
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.ValorLiquidoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.ValorLiquidoDataGridViewTextBoxColumn.HeaderText = "Pagar R$"
        Me.ValorLiquidoDataGridViewTextBoxColumn.Name = "ValorLiquidoDataGridViewTextBoxColumn"
        Me.ValorLiquidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorLiquidoDataGridViewTextBoxColumn.Width = 75
        '
        'QtdeParcelaDataGridViewTextBoxColumn
        '
        Me.QtdeParcelaDataGridViewTextBoxColumn.DataPropertyName = "QtdeParcela"
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.QtdeParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.QtdeParcelaDataGridViewTextBoxColumn.HeaderText = "Parcelas"
        Me.QtdeParcelaDataGridViewTextBoxColumn.Name = "QtdeParcelaDataGridViewTextBoxColumn"
        Me.QtdeParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Valor1ParcelaDataGridViewTextBoxColumn
        '
        Me.Valor1ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Valor1Parcela"
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        Me.Valor1ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.Valor1ParcelaDataGridViewTextBoxColumn.HeaderText = "1º Parcela"
        Me.Valor1ParcelaDataGridViewTextBoxColumn.Name = "Valor1ParcelaDataGridViewTextBoxColumn"
        Me.Valor1ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Data1ParcelaDataGridViewTextBoxColumn
        '
        Me.Data1ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Data1Parcela"
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.Data1ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.Data1ParcelaDataGridViewTextBoxColumn.HeaderText = "1º Vencimento"
        Me.Data1ParcelaDataGridViewTextBoxColumn.Name = "Data1ParcelaDataGridViewTextBoxColumn"
        Me.Data1ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Valor2ParcelaDataGridViewTextBoxColumn
        '
        Me.Valor2ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Valor2Parcela"
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        Me.Valor2ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.Valor2ParcelaDataGridViewTextBoxColumn.HeaderText = "2º Parcela"
        Me.Valor2ParcelaDataGridViewTextBoxColumn.Name = "Valor2ParcelaDataGridViewTextBoxColumn"
        Me.Valor2ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Data2ParcelaDataGridViewTextBoxColumn
        '
        Me.Data2ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Data2Parcela"
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        Me.Data2ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.Data2ParcelaDataGridViewTextBoxColumn.HeaderText = "2º Vencimento"
        Me.Data2ParcelaDataGridViewTextBoxColumn.Name = "Data2ParcelaDataGridViewTextBoxColumn"
        Me.Data2ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Valor3ParcelaDataGridViewTextBoxColumn
        '
        Me.Valor3ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Valor3Parcela"
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.Valor3ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.Valor3ParcelaDataGridViewTextBoxColumn.HeaderText = "3º Parcela"
        Me.Valor3ParcelaDataGridViewTextBoxColumn.Name = "Valor3ParcelaDataGridViewTextBoxColumn"
        Me.Valor3ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Data3ParcelaDataGridViewTextBoxColumn
        '
        Me.Data3ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Data3Parcela"
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.Data3ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle16
        Me.Data3ParcelaDataGridViewTextBoxColumn.HeaderText = "3º Vencimento"
        Me.Data3ParcelaDataGridViewTextBoxColumn.Name = "Data3ParcelaDataGridViewTextBoxColumn"
        Me.Data3ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Valor4ParcelaDataGridViewTextBoxColumn
        '
        Me.Valor4ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Valor4Parcela"
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        Me.Valor4ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle17
        Me.Valor4ParcelaDataGridViewTextBoxColumn.HeaderText = "4º Parcela"
        Me.Valor4ParcelaDataGridViewTextBoxColumn.Name = "Valor4ParcelaDataGridViewTextBoxColumn"
        Me.Valor4ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Data4ParcelaDataGridViewTextBoxColumn
        '
        Me.Data4ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Data4Parcela"
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        Me.Data4ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle18
        Me.Data4ParcelaDataGridViewTextBoxColumn.HeaderText = "4º Vencimento"
        Me.Data4ParcelaDataGridViewTextBoxColumn.Name = "Data4ParcelaDataGridViewTextBoxColumn"
        Me.Data4ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Valor5ParcelaDataGridViewTextBoxColumn
        '
        Me.Valor5ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Valor5Parcela"
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        Me.Valor5ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle19
        Me.Valor5ParcelaDataGridViewTextBoxColumn.HeaderText = "5º Parcela"
        Me.Valor5ParcelaDataGridViewTextBoxColumn.Name = "Valor5ParcelaDataGridViewTextBoxColumn"
        Me.Valor5ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Data5ParcelaDataGridViewTextBoxColumn
        '
        Me.Data5ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Data5Parcela"
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        Me.Data5ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle20
        Me.Data5ParcelaDataGridViewTextBoxColumn.HeaderText = "5º Vencimento"
        Me.Data5ParcelaDataGridViewTextBoxColumn.Name = "Data5ParcelaDataGridViewTextBoxColumn"
        Me.Data5ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Valor6ParcelaDataGridViewTextBoxColumn
        '
        Me.Valor6ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Valor6Parcela"
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White
        Me.Valor6ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle21
        Me.Valor6ParcelaDataGridViewTextBoxColumn.HeaderText = "6º Parcela"
        Me.Valor6ParcelaDataGridViewTextBoxColumn.Name = "Valor6ParcelaDataGridViewTextBoxColumn"
        Me.Valor6ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Data6ParcelaDataGridViewTextBoxColumn
        '
        Me.Data6ParcelaDataGridViewTextBoxColumn.DataPropertyName = "Data6Parcela"
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White
        Me.Data6ParcelaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle22
        Me.Data6ParcelaDataGridViewTextBoxColumn.HeaderText = "6º Vencimento"
        Me.Data6ParcelaDataGridViewTextBoxColumn.Name = "Data6ParcelaDataGridViewTextBoxColumn"
        Me.Data6ParcelaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoVendaDataGridViewTextBoxColumn1
        '
        Me.CodigoVendaDataGridViewTextBoxColumn1.DataPropertyName = "CodigoVenda"
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        Me.CodigoVendaDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle24
        Me.CodigoVendaDataGridViewTextBoxColumn1.HeaderText = "CodigoVenda"
        Me.CodigoVendaDataGridViewTextBoxColumn1.Name = "CodigoVendaDataGridViewTextBoxColumn1"
        Me.CodigoVendaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CodigoVendaDataGridViewTextBoxColumn1.Visible = False
        '
        'CodigoItemEstoqueDataGridViewTextBoxColumn
        '
        Me.CodigoItemEstoqueDataGridViewTextBoxColumn.DataPropertyName = "CodigoItemEstoque"
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White
        Me.CodigoItemEstoqueDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle25
        Me.CodigoItemEstoqueDataGridViewTextBoxColumn.HeaderText = "Nº Item"
        Me.CodigoItemEstoqueDataGridViewTextBoxColumn.Name = "CodigoItemEstoqueDataGridViewTextBoxColumn"
        Me.CodigoItemEstoqueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorItemDataGridViewTextBoxColumn
        '
        Me.ValorItemDataGridViewTextBoxColumn.DataPropertyName = "ValorItem"
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White
        Me.ValorItemDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle26
        Me.ValorItemDataGridViewTextBoxColumn.HeaderText = "Preço R$"
        Me.ValorItemDataGridViewTextBoxColumn.Name = "ValorItemDataGridViewTextBoxColumn"
        Me.ValorItemDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantidadeDataGridViewTextBoxColumn
        '
        Me.QuantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade"
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White
        Me.QuantidadeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle27
        Me.QuantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.Name = "QuantidadeDataGridViewTextBoxColumn"
        Me.QuantidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorDataGridViewTextBoxColumn
        '
        Me.ValorDataGridViewTextBoxColumn.DataPropertyName = "Valor"
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White
        Me.ValorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle28
        Me.ValorDataGridViewTextBoxColumn.HeaderText = "Valor R$"
        Me.ValorDataGridViewTextBoxColumn.Name = "ValorDataGridViewTextBoxColumn"
        Me.ValorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmHistoricoVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(664, 619)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CodigoVendaTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(CodigoVendaLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHistoricoVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico de Venda por Cliente"
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItensVendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancoDataSet As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents TableAdapterManager As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendasTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendasTableAdapter
    Friend WithEvents VendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoVendaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ItensVendasTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItensVendasTableAdapter
    Friend WithEvents ItensVendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CodigoVendaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoVendedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoTipoPagamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoFormaPagamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataVendaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorEntradaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorDescontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorLiquidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtdeParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor1ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data1ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor2ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data2ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor3ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data3ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor4ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data4ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor5ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data5ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor6ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data6ParcelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoVendaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoItemEstoqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
