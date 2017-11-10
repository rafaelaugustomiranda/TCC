<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadItemEstoque
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
        Dim CodigoItemEstoqueLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim DetalheLabel As System.Windows.Forms.Label
        Dim UnidadeLabel As System.Windows.Forms.Label
        Dim CodigoGrupoLabel As System.Windows.Forms.Label
        Dim EstoqueDisponivelLabel As System.Windows.Forms.Label
        Dim PrecoVendaLabel As System.Windows.Forms.Label
        Dim CustoReposicaoLabel As System.Windows.Forms.Label
        Dim DataUltimaCompraLabel As System.Windows.Forms.Label
        Dim DataUltimaVendaLabel As System.Windows.Forms.Label
        Dim VendasMesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadItemEstoque))
        Me.ItemEstoqueBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ItemEstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet = New SistemaGerenciamentoVendas.BancoDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CodigoItemEstoqueTextBox = New System.Windows.Forms.TextBox
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox
        Me.DetalheTextBox = New System.Windows.Forms.TextBox
        Me.UnidadeTextBox = New System.Windows.Forms.TextBox
        Me.EstoqueDisponivelTextBox = New System.Windows.Forms.TextBox
        Me.PrecoVendaTextBox = New System.Windows.Forms.TextBox
        Me.CustoReposicaoTextBox = New System.Windows.Forms.TextBox
        Me.DataUltimaCompraTextBox = New System.Windows.Forms.TextBox
        Me.DataUltimaVendaTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.VendasMesTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCalendarioCompra = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnNovo = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CalendarioCompra = New System.Windows.Forms.MonthCalendar
        Me.GrupoComboBox = New System.Windows.Forms.ComboBox
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemEstoqueTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
        Me.TableAdapterManager = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
        Me.GrupoTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.GrupoTableAdapter
        Me.HistoricoCompraTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoCompraTableAdapter
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        CodigoItemEstoqueLabel = New System.Windows.Forms.Label
        DescricaoLabel = New System.Windows.Forms.Label
        DetalheLabel = New System.Windows.Forms.Label
        UnidadeLabel = New System.Windows.Forms.Label
        CodigoGrupoLabel = New System.Windows.Forms.Label
        EstoqueDisponivelLabel = New System.Windows.Forms.Label
        PrecoVendaLabel = New System.Windows.Forms.Label
        CustoReposicaoLabel = New System.Windows.Forms.Label
        DataUltimaCompraLabel = New System.Windows.Forms.Label
        DataUltimaVendaLabel = New System.Windows.Forms.Label
        VendasMesLabel = New System.Windows.Forms.Label
        CType(Me.ItemEstoqueBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemEstoqueBindingNavigator.SuspendLayout()
        CType(Me.ItemEstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoItemEstoqueLabel
        '
        CodigoItemEstoqueLabel.AutoSize = True
        CodigoItemEstoqueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoItemEstoqueLabel.Location = New System.Drawing.Point(452, 125)
        CodigoItemEstoqueLabel.Name = "CodigoItemEstoqueLabel"
        CodigoItemEstoqueLabel.Size = New System.Drawing.Size(63, 20)
        CodigoItemEstoqueLabel.TabIndex = 1
        CodigoItemEstoqueLabel.Text = "Codigo:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescricaoLabel.Location = New System.Drawing.Point(14, 161)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(84, 20)
        DescricaoLabel.TabIndex = 3
        DescricaoLabel.Text = "Descricao:"
        '
        'DetalheLabel
        '
        DetalheLabel.AutoSize = True
        DetalheLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DetalheLabel.Location = New System.Drawing.Point(29, 193)
        DetalheLabel.Name = "DetalheLabel"
        DetalheLabel.Size = New System.Drawing.Size(69, 20)
        DetalheLabel.TabIndex = 5
        DetalheLabel.Text = "Detalhe:"
        '
        'UnidadeLabel
        '
        UnidadeLabel.AutoSize = True
        UnidadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UnidadeLabel.Location = New System.Drawing.Point(278, 193)
        UnidadeLabel.Name = "UnidadeLabel"
        UnidadeLabel.Size = New System.Drawing.Size(73, 20)
        UnidadeLabel.TabIndex = 7
        UnidadeLabel.Text = "Unidade:"
        '
        'CodigoGrupoLabel
        '
        CodigoGrupoLabel.AutoSize = True
        CodigoGrupoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoGrupoLabel.Location = New System.Drawing.Point(40, 125)
        CodigoGrupoLabel.Name = "CodigoGrupoLabel"
        CodigoGrupoLabel.Size = New System.Drawing.Size(58, 20)
        CodigoGrupoLabel.TabIndex = 9
        CodigoGrupoLabel.Text = "Grupo:"
        '
        'EstoqueDisponivelLabel
        '
        EstoqueDisponivelLabel.AutoSize = True
        EstoqueDisponivelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstoqueDisponivelLabel.Location = New System.Drawing.Point(8, 30)
        EstoqueDisponivelLabel.Name = "EstoqueDisponivelLabel"
        EstoqueDisponivelLabel.Size = New System.Drawing.Size(149, 20)
        EstoqueDisponivelLabel.TabIndex = 11
        EstoqueDisponivelLabel.Text = "Estoque Disponivel:"
        '
        'PrecoVendaLabel
        '
        PrecoVendaLabel.AutoSize = True
        PrecoVendaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecoVendaLabel.Location = New System.Drawing.Point(37, 28)
        PrecoVendaLabel.Name = "PrecoVendaLabel"
        PrecoVendaLabel.Size = New System.Drawing.Size(105, 20)
        PrecoVendaLabel.TabIndex = 15
        PrecoVendaLabel.Text = "Preco Venda:"
        '
        'CustoReposicaoLabel
        '
        CustoReposicaoLabel.AutoSize = True
        CustoReposicaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustoReposicaoLabel.Location = New System.Drawing.Point(15, 57)
        CustoReposicaoLabel.Name = "CustoReposicaoLabel"
        CustoReposicaoLabel.Size = New System.Drawing.Size(135, 20)
        CustoReposicaoLabel.TabIndex = 17
        CustoReposicaoLabel.Text = "Custo Reposicao:"
        '
        'DataUltimaCompraLabel
        '
        DataUltimaCompraLabel.AutoSize = True
        DataUltimaCompraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataUltimaCompraLabel.Location = New System.Drawing.Point(19, 337)
        DataUltimaCompraLabel.Name = "DataUltimaCompraLabel"
        DataUltimaCompraLabel.Size = New System.Drawing.Size(136, 20)
        DataUltimaCompraLabel.TabIndex = 19
        DataUltimaCompraLabel.Text = "Data Ult. Compra:"
        '
        'DataUltimaVendaLabel
        '
        DataUltimaVendaLabel.AutoSize = True
        DataUltimaVendaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataUltimaVendaLabel.Location = New System.Drawing.Point(345, 340)
        DataUltimaVendaLabel.Name = "DataUltimaVendaLabel"
        DataUltimaVendaLabel.Size = New System.Drawing.Size(127, 20)
        DataUltimaVendaLabel.TabIndex = 21
        DataUltimaVendaLabel.Text = "Data Ult. Venda:"
        '
        'VendasMesLabel
        '
        VendasMesLabel.AutoSize = True
        VendasMesLabel.Location = New System.Drawing.Point(55, 61)
        VendasMesLabel.Name = "VendasMesLabel"
        VendasMesLabel.Size = New System.Drawing.Size(102, 20)
        VendasMesLabel.TabIndex = 47
        VendasMesLabel.Text = "Vendas Mes:"
        '
        'ItemEstoqueBindingNavigator
        '
        Me.ItemEstoqueBindingNavigator.AddNewItem = Nothing
        Me.ItemEstoqueBindingNavigator.BindingSource = Me.ItemEstoqueBindingSource
        Me.ItemEstoqueBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ItemEstoqueBindingNavigator.CountItemFormat = "de {0}"
        Me.ItemEstoqueBindingNavigator.DeleteItem = Nothing
        Me.ItemEstoqueBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ItemEstoqueBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ItemEstoqueBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ItemEstoqueBindingNavigator.Location = New System.Drawing.Point(195, 372)
        Me.ItemEstoqueBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ItemEstoqueBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ItemEstoqueBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ItemEstoqueBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ItemEstoqueBindingNavigator.Name = "ItemEstoqueBindingNavigator"
        Me.ItemEstoqueBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ItemEstoqueBindingNavigator.Size = New System.Drawing.Size(234, 27)
        Me.ItemEstoqueBindingNavigator.TabIndex = 0
        Me.ItemEstoqueBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(56, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CodigoItemEstoqueTextBox
        '
        Me.CodigoItemEstoqueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemEstoqueBindingSource, "CodigoItemEstoque", True))
        Me.CodigoItemEstoqueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoItemEstoqueTextBox.Location = New System.Drawing.Point(517, 123)
        Me.CodigoItemEstoqueTextBox.Name = "CodigoItemEstoqueTextBox"
        Me.CodigoItemEstoqueTextBox.Size = New System.Drawing.Size(61, 26)
        Me.CodigoItemEstoqueTextBox.TabIndex = 2
        Me.CodigoItemEstoqueTextBox.Text = "10018"
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemEstoqueBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(104, 158)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(474, 26)
        Me.DescricaoTextBox.TabIndex = 4
        '
        'DetalheTextBox
        '
        Me.DetalheTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemEstoqueBindingSource, "Detalhe", True))
        Me.DetalheTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetalheTextBox.Location = New System.Drawing.Point(104, 190)
        Me.DetalheTextBox.Name = "DetalheTextBox"
        Me.DetalheTextBox.Size = New System.Drawing.Size(168, 26)
        Me.DetalheTextBox.TabIndex = 6
        '
        'UnidadeTextBox
        '
        Me.UnidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemEstoqueBindingSource, "Unidade", True))
        Me.UnidadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnidadeTextBox.Location = New System.Drawing.Point(357, 190)
        Me.UnidadeTextBox.Name = "UnidadeTextBox"
        Me.UnidadeTextBox.Size = New System.Drawing.Size(124, 26)
        Me.UnidadeTextBox.TabIndex = 8
        '
        'EstoqueDisponivelTextBox
        '
        Me.EstoqueDisponivelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemEstoqueBindingSource, "EstoqueDisponivel", True))
        Me.EstoqueDisponivelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstoqueDisponivelTextBox.Location = New System.Drawing.Point(163, 25)
        Me.EstoqueDisponivelTextBox.Name = "EstoqueDisponivelTextBox"
        Me.EstoqueDisponivelTextBox.Size = New System.Drawing.Size(97, 26)
        Me.EstoqueDisponivelTextBox.TabIndex = 12
        '
        'PrecoVendaTextBox
        '
        Me.PrecoVendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemEstoqueBindingSource, "PrecoVenda", True))
        Me.PrecoVendaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecoVendaTextBox.Location = New System.Drawing.Point(180, 25)
        Me.PrecoVendaTextBox.MaxLength = 10
        Me.PrecoVendaTextBox.Name = "PrecoVendaTextBox"
        Me.PrecoVendaTextBox.Size = New System.Drawing.Size(72, 26)
        Me.PrecoVendaTextBox.TabIndex = 16
        '
        'CustoReposicaoTextBox
        '
        Me.CustoReposicaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemEstoqueBindingSource, "CustoReposicao", True))
        Me.CustoReposicaoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustoReposicaoTextBox.Location = New System.Drawing.Point(180, 57)
        Me.CustoReposicaoTextBox.MaxLength = 10
        Me.CustoReposicaoTextBox.Name = "CustoReposicaoTextBox"
        Me.CustoReposicaoTextBox.Size = New System.Drawing.Size(72, 26)
        Me.CustoReposicaoTextBox.TabIndex = 18
        '
        'DataUltimaCompraTextBox
        '
        Me.DataUltimaCompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemEstoqueBindingSource, "DataUltimaCompra", True))
        Me.DataUltimaCompraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataUltimaCompraTextBox.Location = New System.Drawing.Point(161, 334)
        Me.DataUltimaCompraTextBox.Name = "DataUltimaCompraTextBox"
        Me.DataUltimaCompraTextBox.Size = New System.Drawing.Size(98, 26)
        Me.DataUltimaCompraTextBox.TabIndex = 20
        '
        'DataUltimaVendaTextBox
        '
        Me.DataUltimaVendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemEstoqueBindingSource, "DataUltimaVenda", True))
        Me.DataUltimaVendaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataUltimaVendaTextBox.Location = New System.Drawing.Point(484, 333)
        Me.DataUltimaVendaTextBox.Name = "DataUltimaVendaTextBox"
        Me.DataUltimaVendaTextBox.Size = New System.Drawing.Size(111, 26)
        Me.DataUltimaVendaTextBox.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(VendasMesLabel)
        Me.GroupBox1.Controls.Add(Me.VendasMesTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.EstoqueDisponivelTextBox)
        Me.GroupBox1.Controls.Add(EstoqueDisponivelLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 106)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quantidades"
        '
        'VendasMesTextBox
        '
        Me.VendasMesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemEstoqueBindingSource, "VendasMes", True))
        Me.VendasMesTextBox.Location = New System.Drawing.Point(163, 59)
        Me.VendasMesTextBox.Name = "VendasMesTextBox"
        Me.VendasMesTextBox.Size = New System.Drawing.Size(97, 26)
        Me.VendasMesTextBox.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(261, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "*"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PrecoVendaTextBox)
        Me.GroupBox2.Controls.Add(Me.CustoReposicaoTextBox)
        Me.GroupBox2.Controls.Add(CustoReposicaoLabel)
        Me.GroupBox2.Controls.Add(PrecoVendaLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(311, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 104)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Preços/Custos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(258, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(258, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "R$"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "R$"
        '
        'btnCalendarioCompra
        '
        Me.btnCalendarioCompra.FlatAppearance.BorderSize = 0
        Me.btnCalendarioCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendarioCompra.Image = CType(resources.GetObject("btnCalendarioCompra.Image"), System.Drawing.Image)
        Me.btnCalendarioCompra.Location = New System.Drawing.Point(278, 334)
        Me.btnCalendarioCompra.Name = "btnCalendarioCompra"
        Me.btnCalendarioCompra.Size = New System.Drawing.Size(27, 27)
        Me.btnCalendarioCompra.TabIndex = 28
        Me.btnCalendarioCompra.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.Location = New System.Drawing.Point(438, 411)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(73, 57)
        Me.btnExcluir.TabIndex = 40
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir o Registro")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAlterar.Location = New System.Drawing.Point(278, 411)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(73, 57)
        Me.btnAlterar.TabIndex = 39
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Editar o Registro")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(359, 411)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 57)
        Me.btnCancelar.TabIndex = 38
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar o Registro")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(200, 410)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(73, 57)
        Me.btnSalvar.TabIndex = 37
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar o Registro")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNovo.Location = New System.Drawing.Point(121, 410)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(73, 57)
        Me.btnNovo.TabIndex = 36
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnNovo, "Adicionar um Novo Registro")
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(607, 133)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'CalendarioCompra
        '
        Me.CalendarioCompra.Location = New System.Drawing.Point(119, 179)
        Me.CalendarioCompra.Name = "CalendarioCompra"
        Me.CalendarioCompra.TabIndex = 42
        Me.CalendarioCompra.Visible = False
        '
        'GrupoComboBox
        '
        Me.GrupoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ItemEstoqueBindingSource, "CodigoGrupo", True))
        Me.GrupoComboBox.DataSource = Me.GrupoBindingSource
        Me.GrupoComboBox.DisplayMember = "Grupo"
        Me.GrupoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GrupoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoComboBox.FormattingEnabled = True
        Me.GrupoComboBox.Location = New System.Drawing.Point(104, 121)
        Me.GrupoComboBox.Name = "GrupoComboBox"
        Me.GrupoComboBox.Size = New System.Drawing.Size(325, 28)
        Me.GrupoComboBox.TabIndex = 44
        Me.GrupoComboBox.ValueMember = "CodigoGrupo"
        '
        'GrupoBindingSource
        '
        Me.GrupoBindingSource.DataMember = "Grupo"
        Me.GrupoBindingSource.DataSource = Me.BancoDataSet
        '
        'ItemEstoqueTableAdapter
        '
        Me.ItemEstoqueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CidadeTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.GrupoTableAdapter = Me.GrupoTableAdapter
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
        'GrupoTableAdapter
        '
        Me.GrupoTableAdapter.ClearBeforeFill = True
        '
        'HistoricoCompraTableAdapter1
        '
        Me.HistoricoCompraTableAdapter1.ClearBeforeFill = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Cadastro de Item de Estoque"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(584, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(483, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "* Campo Requerido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(435, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(263, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "*"
        '
        'frmCadItemEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(613, 478)
        Me.Controls.Add(Me.CalendarioCompra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(CodigoGrupoLabel)
        Me.Controls.Add(Me.GrupoComboBox)
        Me.Controls.Add(CodigoItemEstoqueLabel)
        Me.Controls.Add(Me.CodigoItemEstoqueTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnCalendarioCompra)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(DataUltimaVendaLabel)
        Me.Controls.Add(Me.DataUltimaVendaTextBox)
        Me.Controls.Add(DataUltimaCompraLabel)
        Me.Controls.Add(Me.DataUltimaCompraTextBox)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(DetalheLabel)
        Me.Controls.Add(Me.DetalheTextBox)
        Me.Controls.Add(UnidadeLabel)
        Me.Controls.Add(Me.UnidadeTextBox)
        Me.Controls.Add(Me.ItemEstoqueBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadItemEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Item de Estoque"
        CType(Me.ItemEstoqueBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemEstoqueBindingNavigator.ResumeLayout(False)
        Me.ItemEstoqueBindingNavigator.PerformLayout()
        CType(Me.ItemEstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancoDataSet As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents ItemEstoqueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemEstoqueTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
    Friend WithEvents TableAdapterManager As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemEstoqueBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CodigoItemEstoqueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescricaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DetalheTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstoqueDisponivelTextBox As System.Windows.Forms.TextBox

    Friend WithEvents PrecoVendaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustoReposicaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataUltimaCompraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataUltimaVendaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox


    Friend WithEvents btnCalendarioCompra As System.Windows.Forms.Button
    Private WithEvents btnExcluir As System.Windows.Forms.Button
    Private WithEvents btnAlterar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnSalvar As System.Windows.Forms.Button
    Private WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CalendarioCompra As System.Windows.Forms.MonthCalendar
    Friend WithEvents GrupoTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.GrupoTableAdapter
    Friend WithEvents GrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GrupoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HistoricoCompraTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoCompraTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents VendasMesTextBox As System.Windows.Forms.TextBox
End Class
