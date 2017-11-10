<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cliente")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Estoque Minimo")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Histórico de Compra")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Histórico de Venda")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pagamento da Venda")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vendas")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Relatórios de", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnLimparCliente = New System.Windows.Forms.Button
        Me.cbCampos = New System.Windows.Forms.ComboBox
        Me.btnConsultarCliente = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtParametroCliente = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtParametroEstoque = New System.Windows.Forms.TextBox
        Me.btnLimparEstoque = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnConsultarEstoque = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnConsultarCompra = New System.Windows.Forms.Button
        Me.btnLimparCompra = New System.Windows.Forms.Button
        Me.ItemEstoqueComboBox = New System.Windows.Forms.ComboBox
        Me.ItemEstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet = New SistemaGerenciamentoVendas.BancoDataSet
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btnConsultarVenda = New System.Windows.Forms.Button
        Me.btnLimparVenda = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.btnLimparPago = New System.Windows.Forms.Button
        Me.btnConsultarPago = New System.Windows.Forms.Button
        Me.rbNao = New System.Windows.Forms.RadioButton
        Me.rbSim = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnVendas = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet1 = New SistemaGerenciamentoVendas.BancoDataSet
        Me.BoxRelatorio = New System.Windows.Forms.GroupBox
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ItemEstoqueTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
        Me.TableAdapterManager = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
        Me.CidadeTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.CidadeTableAdapter
        Me.ClienteTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
        Me.HistoricoCompraTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoCompraTableAdapter
        Me.HistoricoVendaTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoVendaTableAdapter
        Me.PagamentoVendaTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.PagamentoVendaTableAdapter
        Me.TipoPagamentoTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TipoPagamentoTableAdapter
        Me.FormaPagamentoTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.FormaPagamentoTableAdapter
        Me.VendedorTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendedorTableAdapter
        Me.ItensVendasTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItensVendasTableAdapter
        Me.VendasTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendasTableAdapter
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.ItemEstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BoxRelatorio.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BoxRelatorio)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.crv)
        Me.SplitContainer1.Size = New System.Drawing.Size(923, 710)
        Me.SplitContainer1.SplitterDistance = 257
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(9, 276)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(248, 194)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnLimparCliente)
        Me.TabPage1.Controls.Add(Me.cbCampos)
        Me.TabPage1.Controls.Add(Me.btnConsultarCliente)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtParametroCliente)
        Me.TabPage1.Location = New System.Drawing.Point(4, 58)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(240, 132)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cliente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnLimparCliente
        '
        Me.btnLimparCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimparCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparCliente.Image = CType(resources.GetObject("btnLimparCliente.Image"), System.Drawing.Image)
        Me.btnLimparCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimparCliente.Location = New System.Drawing.Point(121, 67)
        Me.btnLimparCliente.Name = "btnLimparCliente"
        Me.btnLimparCliente.Size = New System.Drawing.Size(99, 54)
        Me.btnLimparCliente.TabIndex = 17
        Me.btnLimparCliente.Text = "Limpar"
        Me.btnLimparCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimparCliente.UseVisualStyleBackColor = True
        '
        'cbCampos
        '
        Me.cbCampos.FormattingEnabled = True
        Me.cbCampos.Items.AddRange(New Object() {"Codigo", "Nome"})
        Me.cbCampos.Location = New System.Drawing.Point(75, 15)
        Me.cbCampos.Name = "cbCampos"
        Me.cbCampos.Size = New System.Drawing.Size(145, 21)
        Me.cbCampos.TabIndex = 0
        '
        'btnConsultarCliente
        '
        Me.btnConsultarCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConsultarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarCliente.Image = CType(resources.GetObject("btnConsultarCliente.Image"), System.Drawing.Image)
        Me.btnConsultarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultarCliente.Location = New System.Drawing.Point(21, 67)
        Me.btnConsultarCliente.Name = "btnConsultarCliente"
        Me.btnConsultarCliente.Size = New System.Drawing.Size(94, 53)
        Me.btnConsultarCliente.TabIndex = 16
        Me.btnConsultarCliente.Text = "Filtrar"
        Me.btnConsultarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultarCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Campos :"
        '
        'txtParametroCliente
        '
        Me.txtParametroCliente.Location = New System.Drawing.Point(21, 42)
        Me.txtParametroCliente.Name = "txtParametroCliente"
        Me.txtParametroCliente.Size = New System.Drawing.Size(199, 20)
        Me.txtParametroCliente.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtParametroEstoque)
        Me.TabPage2.Controls.Add(Me.btnLimparEstoque)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.btnConsultarEstoque)
        Me.TabPage2.Location = New System.Drawing.Point(4, 58)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(240, 132)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Estoque Minimo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtParametroEstoque
        '
        Me.txtParametroEstoque.Location = New System.Drawing.Point(63, 27)
        Me.txtParametroEstoque.Name = "txtParametroEstoque"
        Me.txtParametroEstoque.Size = New System.Drawing.Size(157, 20)
        Me.txtParametroEstoque.TabIndex = 18
        '
        'btnLimparEstoque
        '
        Me.btnLimparEstoque.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimparEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparEstoque.Image = CType(resources.GetObject("btnLimparEstoque.Image"), System.Drawing.Image)
        Me.btnLimparEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimparEstoque.Location = New System.Drawing.Point(121, 67)
        Me.btnLimparEstoque.Name = "btnLimparEstoque"
        Me.btnLimparEstoque.Size = New System.Drawing.Size(99, 54)
        Me.btnLimparEstoque.TabIndex = 17
        Me.btnLimparEstoque.Text = "Limpar"
        Me.btnLimparEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimparEstoque.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Estoque <"
        '
        'btnConsultarEstoque
        '
        Me.btnConsultarEstoque.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConsultarEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarEstoque.Image = CType(resources.GetObject("btnConsultarEstoque.Image"), System.Drawing.Image)
        Me.btnConsultarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultarEstoque.Location = New System.Drawing.Point(21, 67)
        Me.btnConsultarEstoque.Name = "btnConsultarEstoque"
        Me.btnConsultarEstoque.Size = New System.Drawing.Size(94, 53)
        Me.btnConsultarEstoque.TabIndex = 16
        Me.btnConsultarEstoque.Text = "Filtrar"
        Me.btnConsultarEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultarEstoque.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnConsultarCompra)
        Me.TabPage3.Controls.Add(Me.btnLimparCompra)
        Me.TabPage3.Controls.Add(Me.ItemEstoqueComboBox)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 58)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(240, 132)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Historico Compra"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnConsultarCompra
        '
        Me.btnConsultarCompra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConsultarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarCompra.Image = CType(resources.GetObject("btnConsultarCompra.Image"), System.Drawing.Image)
        Me.btnConsultarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultarCompra.Location = New System.Drawing.Point(21, 67)
        Me.btnConsultarCompra.Name = "btnConsultarCompra"
        Me.btnConsultarCompra.Size = New System.Drawing.Size(94, 53)
        Me.btnConsultarCompra.TabIndex = 16
        Me.btnConsultarCompra.Text = "Filtrar"
        Me.btnConsultarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultarCompra.UseVisualStyleBackColor = True
        '
        'btnLimparCompra
        '
        Me.btnLimparCompra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimparCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparCompra.Image = CType(resources.GetObject("btnLimparCompra.Image"), System.Drawing.Image)
        Me.btnLimparCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimparCompra.Location = New System.Drawing.Point(121, 67)
        Me.btnLimparCompra.Name = "btnLimparCompra"
        Me.btnLimparCompra.Size = New System.Drawing.Size(99, 54)
        Me.btnLimparCompra.TabIndex = 17
        Me.btnLimparCompra.Text = "Limpar"
        Me.btnLimparCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimparCompra.UseVisualStyleBackColor = True
        '
        'ItemEstoqueComboBox
        '
        Me.ItemEstoqueComboBox.DataSource = Me.ItemEstoqueBindingSource
        Me.ItemEstoqueComboBox.DisplayMember = "Descricao"
        Me.ItemEstoqueComboBox.FormattingEnabled = True
        Me.ItemEstoqueComboBox.Location = New System.Drawing.Point(21, 30)
        Me.ItemEstoqueComboBox.Name = "ItemEstoqueComboBox"
        Me.ItemEstoqueComboBox.Size = New System.Drawing.Size(199, 21)
        Me.ItemEstoqueComboBox.TabIndex = 3
        Me.ItemEstoqueComboBox.ValueMember = "CodigoItemEstoque"
        '
        'ItemEstoqueBindingSource
        '
        Me.ItemEstoqueBindingSource.DataMember = "ItemEstoque"
        Me.ItemEstoqueBindingSource.DataSource = Me.BancoDataSet
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "BancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item :"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnConsultarVenda)
        Me.TabPage4.Controls.Add(Me.btnLimparVenda)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.ComboBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 58)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(240, 132)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Historico Venda "
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnConsultarVenda
        '
        Me.btnConsultarVenda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConsultarVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarVenda.Image = CType(resources.GetObject("btnConsultarVenda.Image"), System.Drawing.Image)
        Me.btnConsultarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultarVenda.Location = New System.Drawing.Point(21, 67)
        Me.btnConsultarVenda.Name = "btnConsultarVenda"
        Me.btnConsultarVenda.Size = New System.Drawing.Size(94, 53)
        Me.btnConsultarVenda.TabIndex = 18
        Me.btnConsultarVenda.Text = "Filtrar"
        Me.btnConsultarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultarVenda.UseVisualStyleBackColor = True
        '
        'btnLimparVenda
        '
        Me.btnLimparVenda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimparVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparVenda.Image = CType(resources.GetObject("btnLimparVenda.Image"), System.Drawing.Image)
        Me.btnLimparVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimparVenda.Location = New System.Drawing.Point(121, 67)
        Me.btnLimparVenda.Name = "btnLimparVenda"
        Me.btnLimparVenda.Size = New System.Drawing.Size(99, 54)
        Me.btnLimparVenda.TabIndex = 19
        Me.btnLimparVenda.Text = "Limpar"
        Me.btnLimparVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimparVenda.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Item :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ItemEstoqueBindingSource
        Me.ComboBox1.DisplayMember = "Descricao"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(21, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "CodigoItemEstoque"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnLimparPago)
        Me.TabPage5.Controls.Add(Me.btnConsultarPago)
        Me.TabPage5.Controls.Add(Me.rbNao)
        Me.TabPage5.Controls.Add(Me.rbSim)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 58)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(240, 132)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Pagamento das Vendas"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnLimparPago
        '
        Me.btnLimparPago.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimparPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparPago.Image = CType(resources.GetObject("btnLimparPago.Image"), System.Drawing.Image)
        Me.btnLimparPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimparPago.Location = New System.Drawing.Point(121, 67)
        Me.btnLimparPago.Name = "btnLimparPago"
        Me.btnLimparPago.Size = New System.Drawing.Size(99, 54)
        Me.btnLimparPago.TabIndex = 20
        Me.btnLimparPago.Text = "Limpar"
        Me.btnLimparPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimparPago.UseVisualStyleBackColor = True
        '
        'btnConsultarPago
        '
        Me.btnConsultarPago.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConsultarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarPago.Image = CType(resources.GetObject("btnConsultarPago.Image"), System.Drawing.Image)
        Me.btnConsultarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultarPago.Location = New System.Drawing.Point(21, 67)
        Me.btnConsultarPago.Name = "btnConsultarPago"
        Me.btnConsultarPago.Size = New System.Drawing.Size(94, 53)
        Me.btnConsultarPago.TabIndex = 19
        Me.btnConsultarPago.Text = "Filtrar"
        Me.btnConsultarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultarPago.UseVisualStyleBackColor = True
        '
        'rbNao
        '
        Me.rbNao.AutoSize = True
        Me.rbNao.Location = New System.Drawing.Point(146, 35)
        Me.rbNao.Name = "rbNao"
        Me.rbNao.Size = New System.Drawing.Size(45, 17)
        Me.rbNao.TabIndex = 3
        Me.rbNao.Text = "Não"
        Me.rbNao.UseVisualStyleBackColor = True
        '
        'rbSim
        '
        Me.rbSim.AutoSize = True
        Me.rbSim.Checked = True
        Me.rbSim.Location = New System.Drawing.Point(49, 35)
        Me.rbSim.Name = "rbSim"
        Me.rbSim.Size = New System.Drawing.Size(42, 17)
        Me.rbSim.TabIndex = 2
        Me.rbSim.TabStop = True
        Me.rbSim.Text = "Sim"
        Me.rbSim.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Pago?"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btnLimpar)
        Me.TabPage6.Controls.Add(Me.btnVendas)
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Controls.Add(Me.ClienteComboBox)
        Me.TabPage6.Location = New System.Drawing.Point(4, 58)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(240, 132)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Vendas"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpar.Location = New System.Drawing.Point(121, 67)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(99, 54)
        Me.btnLimpar.TabIndex = 18
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnVendas
        '
        Me.btnVendas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendas.Image = CType(resources.GetObject("btnVendas.Image"), System.Drawing.Image)
        Me.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVendas.Location = New System.Drawing.Point(21, 67)
        Me.btnVendas.Name = "btnVendas"
        Me.btnVendas.Size = New System.Drawing.Size(94, 53)
        Me.btnVendas.TabIndex = 17
        Me.btnVendas.Text = "Filtrar"
        Me.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVendas.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cliente"
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DataSource = Me.ClienteBindingSource
        Me.ClienteComboBox.DisplayMember = "Nome"
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(21, 30)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(199, 21)
        Me.ClienteComboBox.TabIndex = 0
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
        'BoxRelatorio
        '
        Me.BoxRelatorio.Controls.Add(Me.TreeView1)
        Me.BoxRelatorio.Location = New System.Drawing.Point(9, 12)
        Me.BoxRelatorio.Name = "BoxRelatorio"
        Me.BoxRelatorio.Size = New System.Drawing.Size(237, 258)
        Me.BoxRelatorio.TabIndex = 0
        Me.BoxRelatorio.TabStop = False
        Me.BoxRelatorio.Text = "Tipos de Relatórios"
        '
        'TreeView1
        '
        Me.TreeView1.HotTracking = True
        Me.TreeView1.Location = New System.Drawing.Point(9, 19)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Cliente"
        TreeNode2.Name = "Node3"
        TreeNode2.Text = "Estoque Minimo"
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "Histórico de Compra"
        TreeNode4.Name = "Node1"
        TreeNode4.Text = "Histórico de Venda"
        TreeNode5.Name = "Node2"
        TreeNode5.Text = "Pagamento da Venda"
        TreeNode6.Name = "Node3"
        TreeNode6.Text = "Vendas"
        TreeNode7.Checked = True
        TreeNode7.Name = "NodeRelatorios"
        TreeNode7.Text = "Relatórios de"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7})
        Me.TreeView1.ShowNodeToolTips = True
        Me.TreeView1.Size = New System.Drawing.Size(215, 227)
        Me.TreeView1.TabIndex = 2
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.DisplayGroupTree = False
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.ShowGotoPageButton = False
        Me.crv.ShowGroupTreeButton = False
        Me.crv.Size = New System.Drawing.Size(662, 710)
        Me.crv.TabIndex = 0
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'ItemEstoqueTableAdapter
        '
        Me.ItemEstoqueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CidadeTableAdapter = Me.CidadeTableAdapter1
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter1
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.GrupoTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoCompraTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoVendaTableAdapter = Nothing
        Me.TableAdapterManager.ItemEstoqueTableAdapter = Me.ItemEstoqueTableAdapter
        Me.TableAdapterManager.ItensVendasTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoVendaTableAdapter = Nothing
        Me.TableAdapterManager.TipoPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        '
        'CidadeTableAdapter1
        '
        Me.CidadeTableAdapter1.ClearBeforeFill = True
        '
        'ClienteTableAdapter1
        '
        Me.ClienteTableAdapter1.ClearBeforeFill = True
        '
        'HistoricoCompraTableAdapter
        '
        Me.HistoricoCompraTableAdapter.ClearBeforeFill = True
        '
        'HistoricoVendaTableAdapter
        '
        Me.HistoricoVendaTableAdapter.ClearBeforeFill = True
        '
        'PagamentoVendaTableAdapter1
        '
        Me.PagamentoVendaTableAdapter1.ClearBeforeFill = True
        '
        'TipoPagamentoTableAdapter
        '
        Me.TipoPagamentoTableAdapter.ClearBeforeFill = True
        '
        'FormaPagamentoTableAdapter
        '
        Me.FormaPagamentoTableAdapter.ClearBeforeFill = True
        '
        'VendedorTableAdapter
        '
        Me.VendedorTableAdapter.ClearBeforeFill = True
        '
        'ItensVendasTableAdapter
        '
        Me.ItensVendasTableAdapter.ClearBeforeFill = True
        '
        'VendasTableAdapter
        '
        Me.VendasTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(923, 710)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Relatórios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ItemEstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoxRelatorio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BoxRelatorio As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCampos As System.Windows.Forms.ComboBox
    Friend WithEvents txtParametroCliente As System.Windows.Forms.TextBox
    Friend WithEvents BancoDataSet As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents ItemEstoqueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemEstoqueTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
    Friend WithEvents TableAdapterManager As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemEstoqueComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClienteTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents BancoDataSet1 As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents CidadeTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.CidadeTableAdapter
    Friend WithEvents btnConsultarCliente As System.Windows.Forms.Button
    Friend WithEvents btnLimparCliente As System.Windows.Forms.Button
    Friend WithEvents btnLimparCompra As System.Windows.Forms.Button
    Friend WithEvents btnConsultarCompra As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLimparEstoque As System.Windows.Forms.Button
    Friend WithEvents btnConsultarEstoque As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtParametroEstoque As System.Windows.Forms.TextBox
    Friend WithEvents HistoricoCompraTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoCompraTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnConsultarVenda As System.Windows.Forms.Button
    Friend WithEvents btnLimparVenda As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents HistoricoVendaTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoVendaTableAdapter
    Friend WithEvents PagamentoVendaTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.PagamentoVendaTableAdapter
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btnLimparPago As System.Windows.Forms.Button
    Friend WithEvents btnConsultarPago As System.Windows.Forms.Button
    Friend WithEvents rbNao As System.Windows.Forms.RadioButton
    Friend WithEvents rbSim As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoPagamentoTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TipoPagamentoTableAdapter
    Friend WithEvents FormaPagamentoTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.FormaPagamentoTableAdapter
    Friend WithEvents VendedorTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendedorTableAdapter
    Friend WithEvents ItensVendasTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItensVendasTableAdapter
    Friend WithEvents VendasTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendasTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnVendas As System.Windows.Forms.Button
End Class
