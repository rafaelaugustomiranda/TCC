<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagamentoVendas
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
        Dim JurosLabel As System.Windows.Forms.Label
        Dim ValorPagarLabel As System.Windows.Forms.Label
        Dim NumeroDaParcelaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagamentoVendas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblCodigoCliente = New System.Windows.Forms.Label
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet = New SistemaGerenciamentoVendas.BancoDataSet
        Me.btnProcurar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.JurosTextBox = New System.Windows.Forms.TextBox
        Me.PagamentoVendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.ValorPagarTextBox = New System.Windows.Forms.TextBox
        Me.NumeroDaParcelaLabel1 = New System.Windows.Forms.Label
        Me.lblDivida = New System.Windows.Forms.Label
        Me.btnEfetuarPagamento = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PagamentoVendaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PagamentoVendaTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.PagamentoVendaTableAdapter
        Me.TableAdapterManager = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
        Me.ClienteTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
        Me.btnCalculaJuros = New System.Windows.Forms.Button
        Me.lblRegistros = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        JurosLabel = New System.Windows.Forms.Label
        ValorPagarLabel = New System.Windows.Forms.Label
        NumeroDaParcelaLabel = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PagamentoVendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagamentoVendaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JurosLabel
        '
        JurosLabel.AutoSize = True
        JurosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JurosLabel.ForeColor = System.Drawing.Color.Indigo
        JurosLabel.Location = New System.Drawing.Point(158, 20)
        JurosLabel.Name = "JurosLabel"
        JurosLabel.Size = New System.Drawing.Size(86, 20)
        JurosLabel.TabIndex = 16
        JurosLabel.Text = "Juros R$:"
        '
        'ValorPagarLabel
        '
        ValorPagarLabel.AutoSize = True
        ValorPagarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorPagarLabel.ForeColor = System.Drawing.Color.Blue
        ValorPagarLabel.Location = New System.Drawing.Point(281, 20)
        ValorPagarLabel.Name = "ValorPagarLabel"
        ValorPagarLabel.Size = New System.Drawing.Size(89, 20)
        ValorPagarLabel.TabIndex = 18
        ValorPagarLabel.Text = "Pagar R$:"
        ValorPagarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumeroDaParcelaLabel
        '
        NumeroDaParcelaLabel.AutoSize = True
        NumeroDaParcelaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroDaParcelaLabel.ForeColor = System.Drawing.Color.DimGray
        NumeroDaParcelaLabel.Location = New System.Drawing.Point(25, 20)
        NumeroDaParcelaLabel.Name = "NumeroDaParcelaLabel"
        NumeroDaParcelaLabel.Size = New System.Drawing.Size(98, 20)
        NumeroDaParcelaLabel.TabIndex = 55
        NumeroDaParcelaLabel.Text = "Nº Parcela:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.ClienteComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 421)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 64)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nome:"
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigoCliente.Location = New System.Drawing.Point(75, 25)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(49, 26)
        Me.lblCodigoCliente.TabIndex = 3
        Me.lblCodigoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DataSource = Me.ClienteBindingSource
        Me.ClienteComboBox.DisplayMember = "Nome"
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(130, 25)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(378, 28)
        Me.ClienteComboBox.TabIndex = 0
        Me.ClienteComboBox.ValueMember = "CodigoCliente"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.BancoDataSet
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "BancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnProcurar
        '
        Me.btnProcurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcurar.Image = CType(resources.GetObject("btnProcurar.Image"), System.Drawing.Image)
        Me.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcurar.Location = New System.Drawing.Point(17, 570)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(166, 45)
        Me.btnProcurar.TabIndex = 8
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(NumeroDaParcelaLabel)
        Me.GroupBox2.Controls.Add(Me.JurosTextBox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ValorPagarTextBox)
        Me.GroupBox2.Controls.Add(Me.NumeroDaParcelaLabel1)
        Me.GroupBox2.Controls.Add(JurosLabel)
        Me.GroupBox2.Controls.Add(Me.lblDivida)
        Me.GroupBox2.Controls.Add(ValorPagarLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 483)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 81)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações:"
        '
        'JurosTextBox
        '
        Me.JurosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagamentoVendaBindingSource, "Juros", True))
        Me.JurosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JurosTextBox.ForeColor = System.Drawing.Color.Indigo
        Me.JurosTextBox.Location = New System.Drawing.Point(150, 42)
        Me.JurosTextBox.Name = "JurosTextBox"
        Me.JurosTextBox.Size = New System.Drawing.Size(100, 26)
        Me.JurosTextBox.TabIndex = 53
        Me.JurosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PagamentoVendaBindingSource
        '
        Me.PagamentoVendaBindingSource.DataMember = "PagamentoVenda"
        Me.PagamentoVendaBindingSource.DataSource = Me.BancoDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(384, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Divida Total R$"
        '
        'ValorPagarTextBox
        '
        Me.ValorPagarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagamentoVendaBindingSource, "ValorPagar", True))
        Me.ValorPagarTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorPagarTextBox.ForeColor = System.Drawing.Color.Blue
        Me.ValorPagarTextBox.Location = New System.Drawing.Point(277, 42)
        Me.ValorPagarTextBox.Name = "ValorPagarTextBox"
        Me.ValorPagarTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ValorPagarTextBox.TabIndex = 55
        Me.ValorPagarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumeroDaParcelaLabel1
        '
        Me.NumeroDaParcelaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumeroDaParcelaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PagamentoVendaBindingSource, "NumeroDaParcela", True))
        Me.NumeroDaParcelaLabel1.Location = New System.Drawing.Point(24, 42)
        Me.NumeroDaParcelaLabel1.Name = "NumeroDaParcelaLabel1"
        Me.NumeroDaParcelaLabel1.Size = New System.Drawing.Size(100, 26)
        Me.NumeroDaParcelaLabel1.TabIndex = 56
        Me.NumeroDaParcelaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDivida
        '
        Me.lblDivida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDivida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivida.ForeColor = System.Drawing.Color.Red
        Me.lblDivida.Location = New System.Drawing.Point(399, 42)
        Me.lblDivida.Name = "lblDivida"
        Me.lblDivida.Size = New System.Drawing.Size(100, 26)
        Me.lblDivida.TabIndex = 66
        Me.lblDivida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEfetuarPagamento
        '
        Me.btnEfetuarPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEfetuarPagamento.Image = CType(resources.GetObject("btnEfetuarPagamento.Image"), System.Drawing.Image)
        Me.btnEfetuarPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEfetuarPagamento.Location = New System.Drawing.Point(379, 570)
        Me.btnEfetuarPagamento.Name = "btnEfetuarPagamento"
        Me.btnEfetuarPagamento.Size = New System.Drawing.Size(166, 45)
        Me.btnEfetuarPagamento.TabIndex = 25
        Me.btnEfetuarPagamento.Text = "Pagamento"
        Me.btnEfetuarPagamento.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(597, 142)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'PagamentoVendaDataGridView
        '
        Me.PagamentoVendaDataGridView.AllowUserToAddRows = False
        Me.PagamentoVendaDataGridView.AllowUserToDeleteRows = False
        Me.PagamentoVendaDataGridView.AllowUserToResizeColumns = False
        Me.PagamentoVendaDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PagamentoVendaDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PagamentoVendaDataGridView.AutoGenerateColumns = False
        Me.PagamentoVendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.PagamentoVendaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.PagamentoVendaDataGridView.DataSource = Me.PagamentoVendaBindingSource
        Me.PagamentoVendaDataGridView.Location = New System.Drawing.Point(18, 134)
        Me.PagamentoVendaDataGridView.MultiSelect = False
        Me.PagamentoVendaDataGridView.Name = "PagamentoVendaDataGridView"
        Me.PagamentoVendaDataGridView.ReadOnly = True
        Me.PagamentoVendaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.PagamentoVendaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PagamentoVendaDataGridView.ShowCellErrors = False
        Me.PagamentoVendaDataGridView.ShowEditingIcon = False
        Me.PagamentoVendaDataGridView.Size = New System.Drawing.Size(528, 262)
        Me.PagamentoVendaDataGridView.TabIndex = 63
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoVenda"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoVenda"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodigoCliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CodigoCliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NumeroDaParcela"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NumeroDaParcela"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Valor"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Parcela R$"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Juros"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "Juros R$"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ValorPagar"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "Valor a Pagar R$"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DataDoPagamento"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Data do Pagamento"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 130
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DataDoVencimento"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn9.HeaderText = "Data do Vencimento"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DiferencaDosDias"
        Me.DataGridViewTextBoxColumn10.HeaderText = "DiferencaDosDias"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Pago"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Pago"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'PagamentoVendaTableAdapter
        '
        Me.PagamentoVendaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CidadeTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.GrupoTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoCompraTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoVendaTableAdapter = Nothing
        Me.TableAdapterManager.ItemEstoqueTableAdapter = Nothing
        Me.TableAdapterManager.ItensVendasTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoVendaTableAdapter = Me.PagamentoVendaTableAdapter
        Me.TableAdapterManager.TipoPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'btnCalculaJuros
        '
        Me.btnCalculaJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculaJuros.Image = CType(resources.GetObject("btnCalculaJuros.Image"), System.Drawing.Image)
        Me.btnCalculaJuros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculaJuros.Location = New System.Drawing.Point(197, 570)
        Me.btnCalculaJuros.Name = "btnCalculaJuros"
        Me.btnCalculaJuros.Size = New System.Drawing.Size(172, 45)
        Me.btnCalculaJuros.TabIndex = 64
        Me.btnCalculaJuros.Text = "Calcular Juros"
        Me.btnCalculaJuros.UseVisualStyleBackColor = True
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.Location = New System.Drawing.Point(102, 401)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(0, 20)
        Me.lblRegistros.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 401)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Registro(s):"
        '
        'frmPagamentoVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(574, 627)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnProcurar)
        Me.Controls.Add(Me.btnCalculaJuros)
        Me.Controls.Add(Me.PagamentoVendaDataGridView)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnEfetuarPagamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPagamentoVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagamento das Vendas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PagamentoVendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagamentoVendaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEfetuarPagamento As System.Windows.Forms.Button
    Friend WithEvents btnProcurar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BancoDataSet As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents PagamentoVendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagamentoVendaTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.PagamentoVendaTableAdapter
    Friend WithEvents TableAdapterManager As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JurosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorPagarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PagamentoVendaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ClienteTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalculaJuros As System.Windows.Forms.Button
    Friend WithEvents NumeroDaParcelaLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDivida As System.Windows.Forms.Label
    Friend WithEvents lblRegistros As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCodigoCliente As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
