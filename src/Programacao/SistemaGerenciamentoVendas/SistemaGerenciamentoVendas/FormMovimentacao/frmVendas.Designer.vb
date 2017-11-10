<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas
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
        Dim CodigoVendaLabel1 As System.Windows.Forms.Label
        Dim CodigoClienteLabel1 As System.Windows.Forms.Label
        Dim CodigoVendedorLabel1 As System.Windows.Forms.Label
        Dim CodigoFormaPagamentoLabel As System.Windows.Forms.Label
        Dim Valor1ParcelaLabel1 As System.Windows.Forms.Label
        Dim Valor2ParcelaLabel1 As System.Windows.Forms.Label
        Dim Valor3ParcelaLabel1 As System.Windows.Forms.Label
        Dim Valor4ParcelaLabel1 As System.Windows.Forms.Label
        Dim Valor5ParcelaLabel1 As System.Windows.Forms.Label
        Dim Valor6ParcelaLabel1 As System.Windows.Forms.Label
        Dim DataVendaLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Me.BancoDataSet = New SistemaGerenciamentoVendas.BancoDataSet
        Me.VendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendasTableAdapter
        Me.FormaPagamentoTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.FormaPagamentoTableAdapter
        Me.VendedorTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendedorTableAdapter
        Me.CodigoVendaTextBox1 = New System.Windows.Forms.TextBox
        Me.ValorDescontoTextBox = New System.Windows.Forms.TextBox
        Me.ValorEntradaTextBox1 = New System.Windows.Forms.TextBox
        Me.Valor1ParcelaTextBox1 = New System.Windows.Forms.TextBox
        Me.Valor2ParcelaTextBox1 = New System.Windows.Forms.TextBox
        Me.Valor3ParcelaTextBox1 = New System.Windows.Forms.TextBox
        Me.Valor4ParcelaTextBox1 = New System.Windows.Forms.TextBox
        Me.Valor5ParcelaTextBox1 = New System.Windows.Forms.TextBox
        Me.Valor6ParcelaTextBox1 = New System.Windows.Forms.TextBox
        Me.DataVendaTextBox1 = New System.Windows.Forms.TextBox
        Me.Data1ParcelaTextBox = New System.Windows.Forms.TextBox
        Me.Data2ParcelaTextBox = New System.Windows.Forms.TextBox
        Me.Data3ParcelaTextBox = New System.Windows.Forms.TextBox
        Me.Data4ParcelaTextBox = New System.Windows.Forms.TextBox
        Me.Data5ParcelaTextBox = New System.Windows.Forms.TextBox
        Me.Data6ParcelaTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboQuantidade = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.VendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendedorComboBox = New System.Windows.Forms.ComboBox
        Me.FormaPagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormaPagamentoComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.lblTelefone = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblEndereco = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ValorCompraLabel2 = New System.Windows.Forms.Label
        Me.ValorLiquidoLabel2 = New System.Windows.Forms.Label
        Me.btnItens = New System.Windows.Forms.Button
        Me.btnNovo = New System.Windows.Forms.Button
        Me.VendasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEfetuarVenda = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GBEntrada = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GBDesconto = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.BindingSourceItemEstoque = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemEstoqueTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
        Me.TableAdapterManager = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
        Me.ClienteTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
        Me.TipoPagamentoTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TipoPagamentoTableAdapter
        Me.TipoPagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoPagamentoComboBox = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        CodigoVendaLabel1 = New System.Windows.Forms.Label
        CodigoClienteLabel1 = New System.Windows.Forms.Label
        CodigoVendedorLabel1 = New System.Windows.Forms.Label
        CodigoFormaPagamentoLabel = New System.Windows.Forms.Label
        Valor1ParcelaLabel1 = New System.Windows.Forms.Label
        Valor2ParcelaLabel1 = New System.Windows.Forms.Label
        Valor3ParcelaLabel1 = New System.Windows.Forms.Label
        Valor4ParcelaLabel1 = New System.Windows.Forms.Label
        Valor5ParcelaLabel1 = New System.Windows.Forms.Label
        Valor6ParcelaLabel1 = New System.Windows.Forms.Label
        DataVendaLabel1 = New System.Windows.Forms.Label
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormaPagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VendasBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GBEntrada.SuspendLayout()
        Me.GBDesconto.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.BindingSourceItemEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoPagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoVendaLabel1
        '
        CodigoVendaLabel1.AutoSize = True
        CodigoVendaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoVendaLabel1.Location = New System.Drawing.Point(13, 143)
        CodigoVendaLabel1.Name = "CodigoVendaLabel1"
        CodigoVendaLabel1.Size = New System.Drawing.Size(81, 20)
        CodigoVendaLabel1.TabIndex = 42
        CodigoVendaLabel1.Text = "Venda Nº:"
        '
        'CodigoClienteLabel1
        '
        CodigoClienteLabel1.AutoSize = True
        CodigoClienteLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoClienteLabel1.Location = New System.Drawing.Point(24, 30)
        CodigoClienteLabel1.Name = "CodigoClienteLabel1"
        CodigoClienteLabel1.Size = New System.Drawing.Size(63, 20)
        CodigoClienteLabel1.TabIndex = 44
        CodigoClienteLabel1.Text = "Codigo:"
        '
        'CodigoVendedorLabel1
        '
        CodigoVendedorLabel1.AutoSize = True
        CodigoVendedorLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoVendedorLabel1.Location = New System.Drawing.Point(280, 141)
        CodigoVendedorLabel1.Name = "CodigoVendedorLabel1"
        CodigoVendedorLabel1.Size = New System.Drawing.Size(83, 20)
        CodigoVendedorLabel1.TabIndex = 46
        CodigoVendedorLabel1.Text = "Vendedor:"
        '
        'CodigoFormaPagamentoLabel
        '
        CodigoFormaPagamentoLabel.AutoSize = True
        CodigoFormaPagamentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoFormaPagamentoLabel.Location = New System.Drawing.Point(305, 312)
        CodigoFormaPagamentoLabel.Name = "CodigoFormaPagamentoLabel"
        CodigoFormaPagamentoLabel.Size = New System.Drawing.Size(105, 20)
        CodigoFormaPagamentoLabel.TabIndex = 48
        CodigoFormaPagamentoLabel.Text = "Forma Pagto:"
        '
        'Valor1ParcelaLabel1
        '
        Valor1ParcelaLabel1.AutoSize = True
        Valor1ParcelaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor1ParcelaLabel1.Location = New System.Drawing.Point(6, 74)
        Valor1ParcelaLabel1.Name = "Valor1ParcelaLabel1"
        Valor1ParcelaLabel1.Size = New System.Drawing.Size(81, 20)
        Valor1ParcelaLabel1.TabIndex = 58
        Valor1ParcelaLabel1.Text = "1º Parcela"
        '
        'Valor2ParcelaLabel1
        '
        Valor2ParcelaLabel1.AutoSize = True
        Valor2ParcelaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor2ParcelaLabel1.Location = New System.Drawing.Point(6, 109)
        Valor2ParcelaLabel1.Name = "Valor2ParcelaLabel1"
        Valor2ParcelaLabel1.Size = New System.Drawing.Size(81, 20)
        Valor2ParcelaLabel1.TabIndex = 62
        Valor2ParcelaLabel1.Text = "2º Parcela"
        '
        'Valor3ParcelaLabel1
        '
        Valor3ParcelaLabel1.AutoSize = True
        Valor3ParcelaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor3ParcelaLabel1.Location = New System.Drawing.Point(6, 143)
        Valor3ParcelaLabel1.Name = "Valor3ParcelaLabel1"
        Valor3ParcelaLabel1.Size = New System.Drawing.Size(81, 20)
        Valor3ParcelaLabel1.TabIndex = 66
        Valor3ParcelaLabel1.Text = "3º Parcela"
        '
        'Valor4ParcelaLabel1
        '
        Valor4ParcelaLabel1.AutoSize = True
        Valor4ParcelaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor4ParcelaLabel1.Location = New System.Drawing.Point(6, 179)
        Valor4ParcelaLabel1.Name = "Valor4ParcelaLabel1"
        Valor4ParcelaLabel1.Size = New System.Drawing.Size(81, 20)
        Valor4ParcelaLabel1.TabIndex = 70
        Valor4ParcelaLabel1.Text = "4º Parcela"
        '
        'Valor5ParcelaLabel1
        '
        Valor5ParcelaLabel1.AutoSize = True
        Valor5ParcelaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor5ParcelaLabel1.Location = New System.Drawing.Point(6, 212)
        Valor5ParcelaLabel1.Name = "Valor5ParcelaLabel1"
        Valor5ParcelaLabel1.Size = New System.Drawing.Size(81, 20)
        Valor5ParcelaLabel1.TabIndex = 74
        Valor5ParcelaLabel1.Text = "5º Parcela"
        '
        'Valor6ParcelaLabel1
        '
        Valor6ParcelaLabel1.AutoSize = True
        Valor6ParcelaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor6ParcelaLabel1.Location = New System.Drawing.Point(6, 249)
        Valor6ParcelaLabel1.Name = "Valor6ParcelaLabel1"
        Valor6ParcelaLabel1.Size = New System.Drawing.Size(81, 20)
        Valor6ParcelaLabel1.TabIndex = 78
        Valor6ParcelaLabel1.Text = "6º Parcela"
        '
        'DataVendaLabel1
        '
        DataVendaLabel1.AutoSize = True
        DataVendaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataVendaLabel1.Location = New System.Drawing.Point(307, 383)
        DataVendaLabel1.Name = "DataVendaLabel1"
        DataVendaLabel1.Size = New System.Drawing.Size(99, 20)
        DataVendaLabel1.TabIndex = 82
        DataVendaLabel1.Text = "Data Venda:"
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "BancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendasBindingSource
        '
        Me.VendasBindingSource.DataMember = "Vendas"
        Me.VendasBindingSource.DataSource = Me.BancoDataSet
        '
        'VendasTableAdapter
        '
        Me.VendasTableAdapter.ClearBeforeFill = True
        '
        'FormaPagamentoTableAdapter
        '
        Me.FormaPagamentoTableAdapter.ClearBeforeFill = True
        '
        'VendedorTableAdapter
        '
        Me.VendedorTableAdapter.ClearBeforeFill = True
        '
        'CodigoVendaTextBox1
        '
        Me.CodigoVendaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "CodigoVenda", True))
        Me.CodigoVendaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoVendaTextBox1.Location = New System.Drawing.Point(95, 140)
        Me.CodigoVendaTextBox1.Name = "CodigoVendaTextBox1"
        Me.CodigoVendaTextBox1.Size = New System.Drawing.Size(114, 26)
        Me.CodigoVendaTextBox1.TabIndex = 43
        '
        'ValorDescontoTextBox
        '
        Me.ValorDescontoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValorDescontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "ValorDesconto", True))
        Me.ValorDescontoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorDescontoTextBox.ForeColor = System.Drawing.Color.Red
        Me.ValorDescontoTextBox.Location = New System.Drawing.Point(178, 13)
        Me.ValorDescontoTextBox.Name = "ValorDescontoTextBox"
        Me.ValorDescontoTextBox.Size = New System.Drawing.Size(112, 28)
        Me.ValorDescontoTextBox.TabIndex = 53
        Me.ValorDescontoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ValorEntradaTextBox1
        '
        Me.ValorEntradaTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ValorEntradaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "ValorEntrada", True))
        Me.ValorEntradaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorEntradaTextBox1.ForeColor = System.Drawing.Color.Red
        Me.ValorEntradaTextBox1.Location = New System.Drawing.Point(178, 13)
        Me.ValorEntradaTextBox1.Name = "ValorEntradaTextBox1"
        Me.ValorEntradaTextBox1.Size = New System.Drawing.Size(112, 28)
        Me.ValorEntradaTextBox1.TabIndex = 57
        Me.ValorEntradaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Valor1ParcelaTextBox1
        '
        Me.Valor1ParcelaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Valor1Parcela", True))
        Me.Valor1ParcelaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor1ParcelaTextBox1.Location = New System.Drawing.Point(97, 72)
        Me.Valor1ParcelaTextBox1.Name = "Valor1ParcelaTextBox1"
        Me.Valor1ParcelaTextBox1.Size = New System.Drawing.Size(66, 26)
        Me.Valor1ParcelaTextBox1.TabIndex = 59
        '
        'Valor2ParcelaTextBox1
        '
        Me.Valor2ParcelaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Valor2Parcela", True))
        Me.Valor2ParcelaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor2ParcelaTextBox1.Location = New System.Drawing.Point(97, 107)
        Me.Valor2ParcelaTextBox1.Name = "Valor2ParcelaTextBox1"
        Me.Valor2ParcelaTextBox1.Size = New System.Drawing.Size(66, 26)
        Me.Valor2ParcelaTextBox1.TabIndex = 63
        '
        'Valor3ParcelaTextBox1
        '
        Me.Valor3ParcelaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Valor3Parcela", True))
        Me.Valor3ParcelaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor3ParcelaTextBox1.Location = New System.Drawing.Point(97, 141)
        Me.Valor3ParcelaTextBox1.Name = "Valor3ParcelaTextBox1"
        Me.Valor3ParcelaTextBox1.Size = New System.Drawing.Size(66, 26)
        Me.Valor3ParcelaTextBox1.TabIndex = 67
        '
        'Valor4ParcelaTextBox1
        '
        Me.Valor4ParcelaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Valor4Parcela", True))
        Me.Valor4ParcelaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor4ParcelaTextBox1.Location = New System.Drawing.Point(97, 176)
        Me.Valor4ParcelaTextBox1.Name = "Valor4ParcelaTextBox1"
        Me.Valor4ParcelaTextBox1.Size = New System.Drawing.Size(66, 26)
        Me.Valor4ParcelaTextBox1.TabIndex = 71
        '
        'Valor5ParcelaTextBox1
        '
        Me.Valor5ParcelaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Valor5Parcela", True))
        Me.Valor5ParcelaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor5ParcelaTextBox1.Location = New System.Drawing.Point(97, 210)
        Me.Valor5ParcelaTextBox1.Name = "Valor5ParcelaTextBox1"
        Me.Valor5ParcelaTextBox1.Size = New System.Drawing.Size(66, 26)
        Me.Valor5ParcelaTextBox1.TabIndex = 75
        '
        'Valor6ParcelaTextBox1
        '
        Me.Valor6ParcelaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Valor6Parcela", True))
        Me.Valor6ParcelaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor6ParcelaTextBox1.Location = New System.Drawing.Point(97, 247)
        Me.Valor6ParcelaTextBox1.Name = "Valor6ParcelaTextBox1"
        Me.Valor6ParcelaTextBox1.Size = New System.Drawing.Size(66, 26)
        Me.Valor6ParcelaTextBox1.TabIndex = 79
        '
        'DataVendaTextBox1
        '
        Me.DataVendaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "DataVenda", True))
        Me.DataVendaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataVendaTextBox1.Location = New System.Drawing.Point(410, 377)
        Me.DataVendaTextBox1.Name = "DataVendaTextBox1"
        Me.DataVendaTextBox1.Size = New System.Drawing.Size(197, 26)
        Me.DataVendaTextBox1.TabIndex = 83
        '
        'Data1ParcelaTextBox
        '
        Me.Data1ParcelaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Data1Parcela", True))
        Me.Data1ParcelaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data1ParcelaTextBox.Location = New System.Drawing.Point(172, 72)
        Me.Data1ParcelaTextBox.Name = "Data1ParcelaTextBox"
        Me.Data1ParcelaTextBox.Size = New System.Drawing.Size(87, 26)
        Me.Data1ParcelaTextBox.TabIndex = 84
        '
        'Data2ParcelaTextBox
        '
        Me.Data2ParcelaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Data2Parcela", True))
        Me.Data2ParcelaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data2ParcelaTextBox.Location = New System.Drawing.Point(172, 107)
        Me.Data2ParcelaTextBox.Name = "Data2ParcelaTextBox"
        Me.Data2ParcelaTextBox.Size = New System.Drawing.Size(87, 26)
        Me.Data2ParcelaTextBox.TabIndex = 85
        '
        'Data3ParcelaTextBox
        '
        Me.Data3ParcelaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Data3Parcela", True))
        Me.Data3ParcelaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data3ParcelaTextBox.Location = New System.Drawing.Point(172, 141)
        Me.Data3ParcelaTextBox.Name = "Data3ParcelaTextBox"
        Me.Data3ParcelaTextBox.Size = New System.Drawing.Size(87, 26)
        Me.Data3ParcelaTextBox.TabIndex = 86
        '
        'Data4ParcelaTextBox
        '
        Me.Data4ParcelaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Data4Parcela", True))
        Me.Data4ParcelaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data4ParcelaTextBox.Location = New System.Drawing.Point(172, 176)
        Me.Data4ParcelaTextBox.Name = "Data4ParcelaTextBox"
        Me.Data4ParcelaTextBox.Size = New System.Drawing.Size(87, 26)
        Me.Data4ParcelaTextBox.TabIndex = 87
        '
        'Data5ParcelaTextBox
        '
        Me.Data5ParcelaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Data5Parcela", True))
        Me.Data5ParcelaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data5ParcelaTextBox.Location = New System.Drawing.Point(172, 210)
        Me.Data5ParcelaTextBox.Name = "Data5ParcelaTextBox"
        Me.Data5ParcelaTextBox.Size = New System.Drawing.Size(87, 26)
        Me.Data5ParcelaTextBox.TabIndex = 88
        '
        'Data6ParcelaTextBox
        '
        Me.Data6ParcelaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "Data6Parcela", True))
        Me.Data6ParcelaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data6ParcelaTextBox.Location = New System.Drawing.Point(172, 247)
        Me.Data6ParcelaTextBox.Name = "Data6ParcelaTextBox"
        Me.Data6ParcelaTextBox.Size = New System.Drawing.Size(87, 26)
        Me.Data6ParcelaTextBox.TabIndex = 89
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cboQuantidade)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Valor1ParcelaLabel1)
        Me.GroupBox1.Controls.Add(Me.Data6ParcelaTextBox)
        Me.GroupBox1.Controls.Add(Me.Valor1ParcelaTextBox1)
        Me.GroupBox1.Controls.Add(Me.Data5ParcelaTextBox)
        Me.GroupBox1.Controls.Add(Me.Data1ParcelaTextBox)
        Me.GroupBox1.Controls.Add(Me.Data4ParcelaTextBox)
        Me.GroupBox1.Controls.Add(Valor2ParcelaLabel1)
        Me.GroupBox1.Controls.Add(Me.Data3ParcelaTextBox)
        Me.GroupBox1.Controls.Add(Me.Valor2ParcelaTextBox1)
        Me.GroupBox1.Controls.Add(Me.Data2ParcelaTextBox)
        Me.GroupBox1.Controls.Add(Valor3ParcelaLabel1)
        Me.GroupBox1.Controls.Add(Me.Valor3ParcelaTextBox1)
        Me.GroupBox1.Controls.Add(Valor4ParcelaLabel1)
        Me.GroupBox1.Controls.Add(Valor5ParcelaLabel1)
        Me.GroupBox1.Controls.Add(Valor6ParcelaLabel1)
        Me.GroupBox1.Controls.Add(Me.Valor4ParcelaTextBox1)
        Me.GroupBox1.Controls.Add(Me.Valor5ParcelaTextBox1)
        Me.GroupBox1.Controls.Add(Me.Valor6ParcelaTextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 293)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parcelas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(193, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 20)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Data"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(95, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Valor R$"
        '
        'cboQuantidade
        '
        Me.cboQuantidade.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "QtdeParcela", True))
        Me.cboQuantidade.FormattingEnabled = True
        Me.cboQuantidade.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6"})
        Me.cboQuantidade.Location = New System.Drawing.Point(97, 19)
        Me.cboQuantidade.Name = "cboQuantidade"
        Me.cboQuantidade.Size = New System.Drawing.Size(66, 28)
        Me.cboQuantidade.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 20)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Quantidade"
        '
        'VendedorBindingSource
        '
        Me.VendedorBindingSource.DataMember = "Vendedor"
        Me.VendedorBindingSource.DataSource = Me.BancoDataSet
        '
        'VendedorComboBox
        '
        Me.VendedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendasBindingSource, "CodigoVendedor", True))
        Me.VendedorComboBox.DataSource = Me.VendedorBindingSource
        Me.VendedorComboBox.DisplayMember = "Vendedor"
        Me.VendedorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendedorComboBox.FormattingEnabled = True
        Me.VendedorComboBox.Location = New System.Drawing.Point(369, 138)
        Me.VendedorComboBox.Name = "VendedorComboBox"
        Me.VendedorComboBox.Size = New System.Drawing.Size(238, 28)
        Me.VendedorComboBox.TabIndex = 90
        Me.VendedorComboBox.ValueMember = "CodigoVendedor"
        '
        'FormaPagamentoBindingSource
        '
        Me.FormaPagamentoBindingSource.DataMember = "FormaPagamento"
        Me.FormaPagamentoBindingSource.DataSource = Me.BancoDataSet
        '
        'FormaPagamentoComboBox
        '
        Me.FormaPagamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendasBindingSource, "CodigoFormaPagamento", True))
        Me.FormaPagamentoComboBox.DataSource = Me.FormaPagamentoBindingSource
        Me.FormaPagamentoComboBox.DisplayMember = "FormaPagamento"
        Me.FormaPagamentoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormaPagamentoComboBox.FormattingEnabled = True
        Me.FormaPagamentoComboBox.Location = New System.Drawing.Point(410, 309)
        Me.FormaPagamentoComboBox.Name = "FormaPagamentoComboBox"
        Me.FormaPagamentoComboBox.Size = New System.Drawing.Size(197, 28)
        Me.FormaPagamentoComboBox.TabIndex = 90
        Me.FormaPagamentoComboBox.ValueMember = "CodigoFormaPagamento"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ClienteComboBox)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.lblTelefone)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblEndereco)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblCodigo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(CodigoClienteLabel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(596, 132)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações do Cliente"
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendasBindingSource, "CodigoCliente", True))
        Me.ClienteComboBox.DataSource = Me.ClienteBindingSource
        Me.ClienteComboBox.DisplayMember = "Nome"
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(93, 57)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(418, 28)
        Me.ClienteComboBox.TabIndex = 91
        Me.ClienteComboBox.ValueMember = "CodigoCliente"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.BancoDataSet
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(517, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 113
        Me.PictureBox3.TabStop = False
        '
        'lblTelefone
        '
        Me.lblTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelefone.Location = New System.Drawing.Point(376, 30)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(135, 24)
        Me.lblTelefone.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Telefone:"
        '
        'lblEndereco
        '
        Me.lblEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndereco.Location = New System.Drawing.Point(93, 88)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(418, 24)
        Me.lblEndereco.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Endereço:"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodigo.Location = New System.Drawing.Point(93, 30)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(70, 24)
        Me.lblCodigo.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Cliente:"
        '
        'ValorCompraLabel2
        '
        Me.ValorCompraLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "ValorCompra", True))
        Me.ValorCompraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorCompraLabel2.Location = New System.Drawing.Point(180, 13)
        Me.ValorCompraLabel2.Name = "ValorCompraLabel2"
        Me.ValorCompraLabel2.Size = New System.Drawing.Size(116, 28)
        Me.ValorCompraLabel2.TabIndex = 92
        Me.ValorCompraLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ValorLiquidoLabel2
        '
        Me.ValorLiquidoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendasBindingSource, "ValorLiquido", True))
        Me.ValorLiquidoLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorLiquidoLabel2.Location = New System.Drawing.Point(181, 10)
        Me.ValorLiquidoLabel2.Name = "ValorLiquidoLabel2"
        Me.ValorLiquidoLabel2.Size = New System.Drawing.Size(116, 27)
        Me.ValorLiquidoLabel2.TabIndex = 93
        Me.ValorLiquidoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnItens
        '
        Me.btnItens.Image = CType(resources.GetObject("btnItens.Image"), System.Drawing.Image)
        Me.btnItens.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnItens.Location = New System.Drawing.Point(619, 236)
        Me.btnItens.Name = "btnItens"
        Me.btnItens.Size = New System.Drawing.Size(94, 92)
        Me.btnItens.TabIndex = 96
        Me.btnItens.Text = "&Adicionar Itens de Vendas"
        Me.btnItens.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItens.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNovo.Location = New System.Drawing.Point(619, 138)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(94, 92)
        Me.btnNovo.TabIndex = 95
        Me.btnNovo.Text = "&Nova Venda"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'VendasBindingNavigator
        '
        Me.VendasBindingNavigator.AddNewItem = Nothing
        Me.VendasBindingNavigator.BindingSource = Me.VendasBindingSource
        Me.VendasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VendasBindingNavigator.CountItemFormat = "de {0}"
        Me.VendasBindingNavigator.DeleteItem = Nothing
        Me.VendasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.VendasBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VendasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.VendasBindingNavigator.Location = New System.Drawing.Point(202, 599)
        Me.VendasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VendasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VendasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VendasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VendasBindingNavigator.Name = "VendasBindingNavigator"
        Me.VendasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VendasBindingNavigator.Size = New System.Drawing.Size(234, 27)
        Me.VendasBindingNavigator.TabIndex = 97
        Me.VendasBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorMoveFirstItem.ToolTipText = "Primeiro Registro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        Me.BindingNavigatorMovePreviousItem.ToolTipText = "Registro Anterior"
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
        Me.BindingNavigatorMoveNextItem.ToolTipText = "Proximo Registro"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.ToolTipText = "Ultimo Registro"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnEfetuarVenda
        '
        Me.btnEfetuarVenda.Image = CType(resources.GetObject("btnEfetuarVenda.Image"), System.Drawing.Image)
        Me.btnEfetuarVenda.Location = New System.Drawing.Point(619, 334)
        Me.btnEfetuarVenda.Name = "btnEfetuarVenda"
        Me.btnEfetuarVenda.Size = New System.Drawing.Size(94, 92)
        Me.btnEfetuarVenda.TabIndex = 98
        Me.btnEfetuarVenda.Text = "&Efetuar Venda"
        Me.btnEfetuarVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEfetuarVenda.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(700, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(619, 432)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 92)
        Me.btnCancelar.TabIndex = 100
        Me.btnCancelar.Text = "&Cancelar Venda"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ValorCompraLabel2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(305, 418)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 44)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 29)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "R$"
        '
        'GBEntrada
        '
        Me.GBEntrada.Controls.Add(Me.Label4)
        Me.GBEntrada.Controls.Add(Me.ValorEntradaTextBox1)
        Me.GBEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEntrada.Location = New System.Drawing.Point(305, 461)
        Me.GBEntrada.Name = "GBEntrada"
        Me.GBEntrada.Size = New System.Drawing.Size(302, 44)
        Me.GBEntrada.TabIndex = 102
        Me.GBEntrada.TabStop = False
        Me.GBEntrada.Text = "Entrada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(137, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 29)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "R$"
        '
        'GBDesconto
        '
        Me.GBDesconto.Controls.Add(Me.Label6)
        Me.GBDesconto.Controls.Add(Me.ValorDescontoTextBox)
        Me.GBDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDesconto.Location = New System.Drawing.Point(305, 504)
        Me.GBDesconto.Name = "GBDesconto"
        Me.GBDesconto.Size = New System.Drawing.Size(302, 44)
        Me.GBDesconto.TabIndex = 103
        Me.GBDesconto.TabStop = False
        Me.GBDesconto.Text = "Desconto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(137, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 29)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "R$"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.ValorLiquidoLabel2)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(305, 547)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(302, 44)
        Me.GroupBox6.TabIndex = 104
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Pagar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(137, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 29)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "R$"
        '
        'BindingSourceItemEstoque
        '
        Me.BindingSourceItemEstoque.DataMember = "ItemEstoque"
        Me.BindingSourceItemEstoque.DataSource = Me.BancoDataSet
        '
        'ItemEstoqueTableAdapter
        '
        Me.ItemEstoqueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CidadeTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Me.FormaPagamentoTableAdapter
        Me.TableAdapterManager.GrupoTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoCompraTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoVendaTableAdapter = Nothing
        Me.TableAdapterManager.ItemEstoqueTableAdapter = Me.ItemEstoqueTableAdapter
        Me.TableAdapterManager.ItensVendasTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoVendaTableAdapter = Nothing
        Me.TableAdapterManager.TipoPagamentoTableAdapter = Me.TipoPagamentoTableAdapter
        Me.TableAdapterManager.UpdateOrder = SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendasTableAdapter = Me.VendasTableAdapter
        Me.TableAdapterManager.VendedorTableAdapter = Me.VendedorTableAdapter
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TipoPagamentoTableAdapter
        '
        Me.TipoPagamentoTableAdapter.ClearBeforeFill = True
        '
        'TipoPagamentoBindingSource
        '
        Me.TipoPagamentoBindingSource.DataMember = "TipoPagamento"
        Me.TipoPagamentoBindingSource.DataSource = Me.BancoDataSet
        '
        'TipoPagamentoComboBox
        '
        Me.TipoPagamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendasBindingSource, "CodigoTipoPagamento", True))
        Me.TipoPagamentoComboBox.DataSource = Me.TipoPagamentoBindingSource
        Me.TipoPagamentoComboBox.DisplayMember = "TipoPagamento"
        Me.TipoPagamentoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoPagamentoComboBox.FormattingEnabled = True
        Me.TipoPagamentoComboBox.Location = New System.Drawing.Point(410, 343)
        Me.TipoPagamentoComboBox.Name = "TipoPagamentoComboBox"
        Me.TipoPagamentoComboBox.Size = New System.Drawing.Size(197, 28)
        Me.TipoPagamentoComboBox.TabIndex = 104
        Me.TipoPagamentoComboBox.ValueMember = "CodigoTipoPagamento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(317, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Tipo Pagto:"
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(728, 645)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TipoPagamentoComboBox)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.DataVendaTextBox1)
        Me.Controls.Add(Me.GBDesconto)
        Me.Controls.Add(Me.GBEntrada)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.FormaPagamentoComboBox)
        Me.Controls.Add(CodigoFormaPagamentoLabel)
        Me.Controls.Add(DataVendaLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEfetuarVenda)
        Me.Controls.Add(Me.VendasBindingNavigator)
        Me.Controls.Add(Me.btnItens)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.VendedorComboBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(CodigoVendaLabel1)
        Me.Controls.Add(Me.CodigoVendaTextBox1)
        Me.Controls.Add(CodigoVendedorLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minhas Vendas"
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormaPagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VendasBindingNavigator.ResumeLayout(False)
        Me.VendasBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GBEntrada.ResumeLayout(False)
        Me.GBEntrada.PerformLayout()
        Me.GBDesconto.ResumeLayout(False)
        Me.GBDesconto.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.BindingSourceItemEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoPagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancoDataSet As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents VendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendasTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendasTableAdapter
    Friend WithEvents ValorDescontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorEntradaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Valor1ParcelaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Valor2ParcelaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Valor3ParcelaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Valor4ParcelaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Valor5ParcelaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Valor6ParcelaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataVendaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Data1ParcelaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data2ParcelaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data3ParcelaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data4ParcelaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data5ParcelaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data6ParcelaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents VendedorTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendedorTableAdapter
    Friend WithEvents VendedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendedorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FormaPagamentoTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.FormaPagamentoTableAdapter
    Friend WithEvents FormaPagamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FormaPagamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents ValorLiquidoLabel2 As System.Windows.Forms.Label
    Private WithEvents btnItens As System.Windows.Forms.Button
    Private WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents VendasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnEfetuarVenda As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Public WithEvents CodigoVendaTextBox1 As System.Windows.Forms.TextBox
    Public WithEvents ValorCompraLabel2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GBEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents GBDesconto As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BindingSourceItemEstoque As System.Windows.Forms.BindingSource
    Friend WithEvents ItemEstoqueTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
    Friend WithEvents TableAdapterManager As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TipoPagamentoTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TipoPagamentoTableAdapter
    Friend WithEvents TipoPagamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoPagamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cboQuantidade As System.Windows.Forms.ComboBox
End Class
