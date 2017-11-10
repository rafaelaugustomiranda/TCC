<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadCliente
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
        Dim CodigoClienteLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim ComplementoLabel As System.Windows.Forms.Label
        Dim CodigoCidadeLabel As System.Windows.Forms.Label
        Dim RGLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim ValorMaiorCompraLabel As System.Windows.Forms.Label
        Dim TitulosAbertoSPCLabel As System.Windows.Forms.Label
        Dim IndicePontualidadeLabel As System.Windows.Forms.Label
        Dim DataCadastroLabel As System.Windows.Forms.Label
        Dim DataUltimaCompraLabel As System.Windows.Forms.Label
        Dim DataNascimentoLabel As System.Windows.Forms.Label
        Dim ObsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadCliente))
        Me.BancoDataSet = New SistemaGerenciamentoVendas.BancoDataSet
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
        Me.TableAdapterManager = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
        Me.CidadeTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.CidadeTableAdapter
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CodigoClienteTextBox = New System.Windows.Forms.TextBox
        Me.NomeTextBox = New System.Windows.Forms.TextBox
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox
        Me.BairroTextBox = New System.Windows.Forms.TextBox
        Me.ComplementoTextBox = New System.Windows.Forms.TextBox
        Me.RGMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.FaxMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.ValorMaiorCompraTextBox = New System.Windows.Forms.TextBox
        Me.TitulosAbertoSPCTextBox = New System.Windows.Forms.TextBox
        Me.IndicePontualidadeTextBox = New System.Windows.Forms.TextBox
        Me.ObsTextBox = New System.Windows.Forms.TextBox
        Me.UFTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnNovo = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CidadeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CEPTextBox = New System.Windows.Forms.TextBox
        Me.CidadeComboBox = New System.Windows.Forms.ComboBox
        Me.ToolTipText = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnHistoricoVendas = New System.Windows.Forms.Button
        Me.DataCadastroTextBox = New System.Windows.Forms.TextBox
        Me.DataUltimaCompraTextBox = New System.Windows.Forms.TextBox
        Me.DataNascimentoTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        CodigoClienteLabel = New System.Windows.Forms.Label
        NomeLabel = New System.Windows.Forms.Label
        EnderecoLabel = New System.Windows.Forms.Label
        BairroLabel = New System.Windows.Forms.Label
        ComplementoLabel = New System.Windows.Forms.Label
        CodigoCidadeLabel = New System.Windows.Forms.Label
        RGLabel = New System.Windows.Forms.Label
        CPFLabel = New System.Windows.Forms.Label
        TelefoneLabel = New System.Windows.Forms.Label
        FaxLabel = New System.Windows.Forms.Label
        ValorMaiorCompraLabel = New System.Windows.Forms.Label
        TitulosAbertoSPCLabel = New System.Windows.Forms.Label
        IndicePontualidadeLabel = New System.Windows.Forms.Label
        DataCadastroLabel = New System.Windows.Forms.Label
        DataUltimaCompraLabel = New System.Windows.Forms.Label
        DataNascimentoLabel = New System.Windows.Forms.Label
        ObsLabel = New System.Windows.Forms.Label
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CidadeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoClienteLabel
        '
        CodigoClienteLabel.AutoSize = True
        CodigoClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoClienteLabel.Location = New System.Drawing.Point(28, 155)
        CodigoClienteLabel.Name = "CodigoClienteLabel"
        CodigoClienteLabel.Size = New System.Drawing.Size(63, 20)
        CodigoClienteLabel.TabIndex = 1
        CodigoClienteLabel.Text = "Codigo:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(36, 185)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(55, 20)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnderecoLabel.Location = New System.Drawing.Point(9, 215)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(82, 20)
        EnderecoLabel.TabIndex = 5
        EnderecoLabel.Text = "Endereço:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BairroLabel.Location = New System.Drawing.Point(36, 247)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(55, 20)
        BairroLabel.TabIndex = 7
        BairroLabel.Text = "Bairro:"
        '
        'ComplementoLabel
        '
        ComplementoLabel.AutoSize = True
        ComplementoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComplementoLabel.Location = New System.Drawing.Point(322, 247)
        ComplementoLabel.Name = "ComplementoLabel"
        ComplementoLabel.Size = New System.Drawing.Size(112, 20)
        ComplementoLabel.TabIndex = 9
        ComplementoLabel.Text = "Complemento:"
        '
        'CodigoCidadeLabel
        '
        CodigoCidadeLabel.AutoSize = True
        CodigoCidadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoCidadeLabel.Location = New System.Drawing.Point(28, 282)
        CodigoCidadeLabel.Name = "CodigoCidadeLabel"
        CodigoCidadeLabel.Size = New System.Drawing.Size(63, 20)
        CodigoCidadeLabel.TabIndex = 11
        CodigoCidadeLabel.Text = "Cidade:"
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RGLabel.Location = New System.Drawing.Point(53, 311)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(38, 20)
        RGLabel.TabIndex = 13
        RGLabel.Text = "RG:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPFLabel.Location = New System.Drawing.Point(390, 314)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(44, 20)
        CPFLabel.TabIndex = 15
        CPFLabel.Text = "CPF:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(16, 343)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(75, 20)
        TelefoneLabel.TabIndex = 17
        TelefoneLabel.Text = "Telefone:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FaxLabel.Location = New System.Drawing.Point(395, 343)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(39, 20)
        FaxLabel.TabIndex = 19
        FaxLabel.Text = "Fax:"
        '
        'ValorMaiorCompraLabel
        '
        ValorMaiorCompraLabel.AutoSize = True
        ValorMaiorCompraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorMaiorCompraLabel.Location = New System.Drawing.Point(9, 378)
        ValorMaiorCompraLabel.Name = "ValorMaiorCompraLabel"
        ValorMaiorCompraLabel.Size = New System.Drawing.Size(175, 20)
        ValorMaiorCompraLabel.TabIndex = 21
        ValorMaiorCompraLabel.Text = "Valor da Maior Compra:"
        '
        'TitulosAbertoSPCLabel
        '
        TitulosAbertoSPCLabel.AutoSize = True
        TitulosAbertoSPCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitulosAbertoSPCLabel.Location = New System.Drawing.Point(15, 413)
        TitulosAbertoSPCLabel.Name = "TitulosAbertoSPCLabel"
        TitulosAbertoSPCLabel.Size = New System.Drawing.Size(169, 20)
        TitulosAbertoSPCLabel.TabIndex = 23
        TitulosAbertoSPCLabel.Text = "Titulos Aberto no SPC:"
        '
        'IndicePontualidadeLabel
        '
        IndicePontualidadeLabel.AutoSize = True
        IndicePontualidadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IndicePontualidadeLabel.Location = New System.Drawing.Point(9, 445)
        IndicePontualidadeLabel.Name = "IndicePontualidadeLabel"
        IndicePontualidadeLabel.Size = New System.Drawing.Size(175, 20)
        IndicePontualidadeLabel.TabIndex = 25
        IndicePontualidadeLabel.Text = "Indice de Pontualidade:"
        '
        'DataCadastroLabel
        '
        DataCadastroLabel.AutoSize = True
        DataCadastroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataCadastroLabel.Location = New System.Drawing.Point(295, 378)
        DataCadastroLabel.Name = "DataCadastroLabel"
        DataCadastroLabel.Size = New System.Drawing.Size(139, 20)
        DataCadastroLabel.TabIndex = 27
        DataCadastroLabel.Text = "Data do Cadastro:"
        '
        'DataUltimaCompraLabel
        '
        DataUltimaCompraLabel.AutoSize = True
        DataUltimaCompraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataUltimaCompraLabel.Location = New System.Drawing.Point(276, 413)
        DataUltimaCompraLabel.Name = "DataUltimaCompraLabel"
        DataUltimaCompraLabel.Size = New System.Drawing.Size(158, 20)
        DataUltimaCompraLabel.TabIndex = 29
        DataUltimaCompraLabel.Text = "Data da Ult. Compra:"
        '
        'DataNascimentoLabel
        '
        DataNascimentoLabel.AutoSize = True
        DataNascimentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataNascimentoLabel.Location = New System.Drawing.Point(320, 448)
        DataNascimentoLabel.Name = "DataNascimentoLabel"
        DataNascimentoLabel.Size = New System.Drawing.Size(114, 20)
        DataNascimentoLabel.TabIndex = 31
        DataNascimentoLabel.Text = "Data de Nasc.:"
        '
        'ObsLabel
        '
        ObsLabel.AutoSize = True
        ObsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsLabel.Location = New System.Drawing.Point(15, 470)
        ObsLabel.Name = "ObsLabel"
        ObsLabel.Size = New System.Drawing.Size(42, 20)
        ObsLabel.TabIndex = 33
        ObsLabel.Text = "Obs:"
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "BancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.BancoDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CidadeTableAdapter = Me.CidadeTableAdapter
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.FormaPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.GrupoTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoCompraTableAdapter = Nothing
        Me.TableAdapterManager.HistoricoVendaTableAdapter = Nothing
        Me.TableAdapterManager.ItemEstoqueTableAdapter = Nothing
        Me.TableAdapterManager.ItensVendasTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoVendaTableAdapter = Nothing
        Me.TableAdapterManager.TipoPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        '
        'CidadeTableAdapter
        '
        Me.CidadeTableAdapter.ClearBeforeFill = True
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Nothing
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.CountItemFormat = "de {0}"
        Me.ClienteBindingNavigator.DeleteItem = Nothing
        Me.ClienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ClienteBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(347, 488)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(234, 27)
        Me.ClienteBindingNavigator.TabIndex = 0
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorMoveFirstItem.ToolTipText = "Primeiro Registro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
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
        Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.BindingNavigatorMoveNextItem.ToolTipText = "Proximo Registro"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.ToolTipText = "Ultimo Registro"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CodigoClienteTextBox
        '
        Me.CodigoClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CodigoCliente", True))
        Me.CodigoClienteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoClienteTextBox.Location = New System.Drawing.Point(97, 155)
        Me.CodigoClienteTextBox.Name = "CodigoClienteTextBox"
        Me.CodigoClienteTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CodigoClienteTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(97, 185)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(524, 26)
        Me.NomeTextBox.TabIndex = 1
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(97, 215)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(524, 26)
        Me.EnderecoTextBox.TabIndex = 2
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Bairro", True))
        Me.BairroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BairroTextBox.Location = New System.Drawing.Point(97, 247)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(200, 26)
        Me.BairroTextBox.TabIndex = 3
        '
        'ComplementoTextBox
        '
        Me.ComplementoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Complemento", True))
        Me.ComplementoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComplementoTextBox.Location = New System.Drawing.Point(440, 247)
        Me.ComplementoTextBox.Name = "ComplementoTextBox"
        Me.ComplementoTextBox.Size = New System.Drawing.Size(181, 26)
        Me.ComplementoTextBox.TabIndex = 4
        '
        'RGMaskedTextBox
        '
        Me.RGMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "RG", True))
        Me.RGMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGMaskedTextBox.Location = New System.Drawing.Point(97, 311)
        Me.RGMaskedTextBox.Mask = "00,000,000-0"
        Me.RGMaskedTextBox.Name = "RGMaskedTextBox"
        Me.RGMaskedTextBox.Size = New System.Drawing.Size(274, 26)
        Me.RGMaskedTextBox.TabIndex = 8
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(440, 311)
        Me.CPFMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(181, 26)
        Me.CPFMaskedTextBox.TabIndex = 9
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(97, 343)
        Me.TelefoneMaskedTextBox.Mask = "(999)0000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(274, 26)
        Me.TelefoneMaskedTextBox.TabIndex = 10
        '
        'FaxMaskedTextBox
        '
        Me.FaxMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Fax", True))
        Me.FaxMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaxMaskedTextBox.Location = New System.Drawing.Point(440, 343)
        Me.FaxMaskedTextBox.Mask = "(999)0000-0000"
        Me.FaxMaskedTextBox.Name = "FaxMaskedTextBox"
        Me.FaxMaskedTextBox.Size = New System.Drawing.Size(181, 26)
        Me.FaxMaskedTextBox.TabIndex = 11
        '
        'ValorMaiorCompraTextBox
        '
        Me.ValorMaiorCompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ValorMaiorCompra", True))
        Me.ValorMaiorCompraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorMaiorCompraTextBox.Location = New System.Drawing.Point(191, 378)
        Me.ValorMaiorCompraTextBox.Name = "ValorMaiorCompraTextBox"
        Me.ValorMaiorCompraTextBox.Size = New System.Drawing.Size(86, 26)
        Me.ValorMaiorCompraTextBox.TabIndex = 12
        '
        'TitulosAbertoSPCTextBox
        '
        Me.TitulosAbertoSPCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "TitulosAbertoSPC", True))
        Me.TitulosAbertoSPCTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitulosAbertoSPCTextBox.Location = New System.Drawing.Point(191, 413)
        Me.TitulosAbertoSPCTextBox.Name = "TitulosAbertoSPCTextBox"
        Me.TitulosAbertoSPCTextBox.Size = New System.Drawing.Size(86, 26)
        Me.TitulosAbertoSPCTextBox.TabIndex = 13
        '
        'IndicePontualidadeTextBox
        '
        Me.IndicePontualidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "IndicePontualidade", True))
        Me.IndicePontualidadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndicePontualidadeTextBox.Location = New System.Drawing.Point(191, 445)
        Me.IndicePontualidadeTextBox.Name = "IndicePontualidadeTextBox"
        Me.IndicePontualidadeTextBox.Size = New System.Drawing.Size(86, 26)
        Me.IndicePontualidadeTextBox.TabIndex = 14
        '
        'ObsTextBox
        '
        Me.ObsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Obs", True))
        Me.ObsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObsTextBox.Location = New System.Drawing.Point(77, 477)
        Me.ObsTextBox.Multiline = True
        Me.ObsTextBox.Name = "ObsTextBox"
        Me.ObsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ObsTextBox.Size = New System.Drawing.Size(200, 54)
        Me.ObsTextBox.TabIndex = 18
        '
        'UFTextBox
        '
        Me.UFTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UFTextBox.Location = New System.Drawing.Point(593, 279)
        Me.UFTextBox.MaxLength = 2
        Me.UFTextBox.Name = "UFTextBox"
        Me.UFTextBox.Size = New System.Drawing.Size(28, 26)
        Me.UFTextBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "CEP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(552, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "UF:"
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(440, 540)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(72, 59)
        Me.btnExcluir.TabIndex = 23
        Me.ToolTipText.SetToolTip(Me.btnExcluir, "Excluir o Registro")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.Location = New System.Drawing.Point(282, 540)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(72, 58)
        Me.btnAlterar.TabIndex = 21
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTipText.SetToolTip(Me.btnAlterar, "Editar o Registro")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(362, 540)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 58)
        Me.btnCancelar.TabIndex = 22
        Me.ToolTipText.SetToolTip(Me.btnCancelar, "Cancelar o Registro")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(204, 540)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(72, 59)
        Me.btnSalvar.TabIndex = 20
        Me.ToolTipText.SetToolTip(Me.btnSalvar, "Salvar o Registro")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(125, 540)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(73, 59)
        Me.btnNovo.TabIndex = 19
        Me.ToolTipText.SetToolTip(Me.btnNovo, "Adicionar um Novo Registro")
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(597, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'CidadeBindingSource
        '
        Me.CidadeBindingSource.DataMember = "Cidade"
        Me.CidadeBindingSource.DataSource = Me.BancoDataSet
        '
        'CEPTextBox
        '
        Me.CEPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPTextBox.Location = New System.Drawing.Point(440, 278)
        Me.CEPTextBox.Name = "CEPTextBox"
        Me.CEPTextBox.Size = New System.Drawing.Size(106, 26)
        Me.CEPTextBox.TabIndex = 6
        '
        'CidadeComboBox
        '
        Me.CidadeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CidadeBindingSource, "Cidade", True))
        Me.CidadeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteBindingSource, "CodigoCidade", True))
        Me.CidadeComboBox.DataSource = Me.CidadeBindingSource
        Me.CidadeComboBox.DisplayMember = "Cidade"
        Me.CidadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CidadeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeComboBox.FormattingEnabled = True
        Me.CidadeComboBox.Location = New System.Drawing.Point(97, 279)
        Me.CidadeComboBox.Name = "CidadeComboBox"
        Me.CidadeComboBox.Size = New System.Drawing.Size(257, 28)
        Me.CidadeComboBox.TabIndex = 5
        Me.CidadeComboBox.ValueMember = "CodigoCidade"
        '
        'ToolTipText
        '
        Me.ToolTipText.IsBalloon = True
        Me.ToolTipText.ShowAlways = True
        Me.ToolTipText.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipText.ToolTipTitle = "Cadastro de Cliente"
        '
        'btnHistoricoVendas
        '
        Me.btnHistoricoVendas.Image = CType(resources.GetObject("btnHistoricoVendas.Image"), System.Drawing.Image)
        Me.btnHistoricoVendas.Location = New System.Drawing.Point(562, 135)
        Me.btnHistoricoVendas.Name = "btnHistoricoVendas"
        Me.btnHistoricoVendas.Size = New System.Drawing.Size(59, 44)
        Me.btnHistoricoVendas.TabIndex = 24
        Me.ToolTipText.SetToolTip(Me.btnHistoricoVendas, "Histórico de Vendas por Cliente")
        Me.btnHistoricoVendas.UseVisualStyleBackColor = True
        '
        'DataCadastroTextBox
        '
        Me.DataCadastroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DataCadastro", True))
        Me.DataCadastroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataCadastroTextBox.Location = New System.Drawing.Point(440, 380)
        Me.DataCadastroTextBox.Name = "DataCadastroTextBox"
        Me.DataCadastroTextBox.Size = New System.Drawing.Size(181, 26)
        Me.DataCadastroTextBox.TabIndex = 15
        '
        'DataUltimaCompraTextBox
        '
        Me.DataUltimaCompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DataUltimaCompra", True))
        Me.DataUltimaCompraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataUltimaCompraTextBox.Location = New System.Drawing.Point(439, 412)
        Me.DataUltimaCompraTextBox.Name = "DataUltimaCompraTextBox"
        Me.DataUltimaCompraTextBox.Size = New System.Drawing.Size(182, 26)
        Me.DataUltimaCompraTextBox.TabIndex = 16
        '
        'DataNascimentoTextBox
        '
        Me.DataNascimentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DataNascimento", True))
        Me.DataNascimentoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataNascimentoTextBox.Location = New System.Drawing.Point(439, 448)
        Me.DataNascimentoTextBox.Name = "DataNascimentoTextBox"
        Me.DataNascimentoTextBox.Size = New System.Drawing.Size(182, 26)
        Me.DataNascimentoTextBox.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(627, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(434, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "* Campo Requerido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(627, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(303, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(360, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(627, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "*"
        '
        'frmCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(644, 611)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataNascimentoTextBox)
        Me.Controls.Add(Me.DataUltimaCompraTextBox)
        Me.Controls.Add(Me.DataCadastroTextBox)
        Me.Controls.Add(Me.btnHistoricoVendas)
        Me.Controls.Add(Me.CidadeComboBox)
        Me.Controls.Add(Me.CEPTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UFTextBox)
        Me.Controls.Add(CodigoClienteLabel)
        Me.Controls.Add(Me.CodigoClienteTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(BairroLabel)
        Me.Controls.Add(Me.BairroTextBox)
        Me.Controls.Add(ComplementoLabel)
        Me.Controls.Add(Me.ComplementoTextBox)
        Me.Controls.Add(CodigoCidadeLabel)
        Me.Controls.Add(RGLabel)
        Me.Controls.Add(Me.RGMaskedTextBox)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFMaskedTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxMaskedTextBox)
        Me.Controls.Add(ValorMaiorCompraLabel)
        Me.Controls.Add(Me.ValorMaiorCompraTextBox)
        Me.Controls.Add(TitulosAbertoSPCLabel)
        Me.Controls.Add(Me.TitulosAbertoSPCTextBox)
        Me.Controls.Add(IndicePontualidadeLabel)
        Me.Controls.Add(Me.IndicePontualidadeTextBox)
        Me.Controls.Add(DataCadastroLabel)
        Me.Controls.Add(DataUltimaCompraLabel)
        Me.Controls.Add(DataNascimentoLabel)
        Me.Controls.Add(ObsLabel)
        Me.Controls.Add(Me.ObsTextBox)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCadCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CidadeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancoDataSet As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CodigoClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComplementoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RGMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CPFMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelefoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents FaxMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ValorMaiorCompraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitulosAbertoSPCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IndicePontualidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btnExcluir As System.Windows.Forms.Button
    Private WithEvents btnAlterar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnSalvar As System.Windows.Forms.Button
    Private WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents UFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.CidadeTableAdapter
    Friend WithEvents CidadeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CEPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTipText As System.Windows.Forms.ToolTip
    Friend WithEvents btnHistoricoVendas As System.Windows.Forms.Button
    Friend WithEvents DataCadastroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataUltimaCompraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataNascimentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
