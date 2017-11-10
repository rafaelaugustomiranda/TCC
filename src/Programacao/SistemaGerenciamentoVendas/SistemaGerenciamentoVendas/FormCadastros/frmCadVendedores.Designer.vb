<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadVendedores
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
        Dim CodigoVendedorLabel As System.Windows.Forms.Label
        Dim VendedorLabel As System.Windows.Forms.Label
        Dim DataAdmissaoLabel As System.Windows.Forms.Label
        Dim DataDemissaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadVendedores))
        Me.BancoDataSet = New SistemaGerenciamentoVendas.BancoDataSet
        Me.VendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendedorTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendedorTableAdapter
        Me.TableAdapterManager = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
        Me.VendedorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CodigoVendedorTextBox = New System.Windows.Forms.TextBox
        Me.VendedorTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnNovo = New System.Windows.Forms.Button
        Me.Calendario1 = New System.Windows.Forms.MonthCalendar
        Me.btnCalendarioAdmissao = New System.Windows.Forms.Button
        Me.DataAdmissaoTextBox = New System.Windows.Forms.TextBox
        Me.DataDemissaoTextBox = New System.Windows.Forms.TextBox
        Me.btnCalendarioDemissao = New System.Windows.Forms.Button
        Me.Calendario2 = New System.Windows.Forms.MonthCalendar
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CodigoVendedorLabel = New System.Windows.Forms.Label
        VendedorLabel = New System.Windows.Forms.Label
        DataAdmissaoLabel = New System.Windows.Forms.Label
        DataDemissaoLabel = New System.Windows.Forms.Label
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VendedorBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoVendedorLabel
        '
        CodigoVendedorLabel.AutoSize = True
        CodigoVendedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoVendedorLabel.Location = New System.Drawing.Point(33, 146)
        CodigoVendedorLabel.Name = "CodigoVendedorLabel"
        CodigoVendedorLabel.Size = New System.Drawing.Size(63, 20)
        CodigoVendedorLabel.TabIndex = 1
        CodigoVendedorLabel.Text = "Codigo:"
        '
        'VendedorLabel
        '
        VendedorLabel.AutoSize = True
        VendedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendedorLabel.Location = New System.Drawing.Point(13, 181)
        VendedorLabel.Name = "VendedorLabel"
        VendedorLabel.Size = New System.Drawing.Size(83, 20)
        VendedorLabel.TabIndex = 3
        VendedorLabel.Text = "Vendedor:"
        '
        'DataAdmissaoLabel
        '
        DataAdmissaoLabel.AutoSize = True
        DataAdmissaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataAdmissaoLabel.Location = New System.Drawing.Point(13, 213)
        DataAdmissaoLabel.Name = "DataAdmissaoLabel"
        DataAdmissaoLabel.Size = New System.Drawing.Size(83, 20)
        DataAdmissaoLabel.TabIndex = 5
        DataAdmissaoLabel.Text = "Admissao:"
        '
        'DataDemissaoLabel
        '
        DataDemissaoLabel.AutoSize = True
        DataDemissaoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataDemissaoLabel.Location = New System.Drawing.Point(247, 213)
        DataDemissaoLabel.Name = "DataDemissaoLabel"
        DataDemissaoLabel.Size = New System.Drawing.Size(84, 20)
        DataDemissaoLabel.TabIndex = 7
        DataDemissaoLabel.Text = "Demissao:"
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "BancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendedorBindingSource
        '
        Me.VendedorBindingSource.DataMember = "Vendedor"
        Me.VendedorBindingSource.DataSource = Me.BancoDataSet
        '
        'VendedorTableAdapter
        '
        Me.VendedorTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ItensVendasTableAdapter = Nothing
        Me.TableAdapterManager.PagamentoVendaTableAdapter = Nothing
        Me.TableAdapterManager.TipoPagamentoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendasTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Me.VendedorTableAdapter
        '
        'VendedorBindingNavigator
        '
        Me.VendedorBindingNavigator.AddNewItem = Nothing
        Me.VendedorBindingNavigator.BindingSource = Me.VendedorBindingSource
        Me.VendedorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VendedorBindingNavigator.CountItemFormat = "de {0}"
        Me.VendedorBindingNavigator.DeleteItem = Nothing
        Me.VendedorBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.VendedorBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VendedorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.VendedorBindingNavigator.Location = New System.Drawing.Point(116, 254)
        Me.VendedorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VendedorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VendedorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VendedorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VendedorBindingNavigator.Name = "VendedorBindingNavigator"
        Me.VendedorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VendedorBindingNavigator.Size = New System.Drawing.Size(234, 27)
        Me.VendedorBindingNavigator.TabIndex = 0
        Me.VendedorBindingNavigator.Text = "BindingNavigator1"
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
        'CodigoVendedorTextBox
        '
        Me.CodigoVendedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "CodigoVendedor", True))
        Me.CodigoVendedorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoVendedorTextBox.Location = New System.Drawing.Point(102, 146)
        Me.CodigoVendedorTextBox.Name = "CodigoVendedorTextBox"
        Me.CodigoVendedorTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CodigoVendedorTextBox.TabIndex = 2
        '
        'VendedorTextBox
        '
        Me.VendedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Vendedor", True))
        Me.VendedorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendedorTextBox.Location = New System.Drawing.Point(102, 178)
        Me.VendedorTextBox.Name = "VendedorTextBox"
        Me.VendedorTextBox.Size = New System.Drawing.Size(329, 26)
        Me.VendedorTextBox.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(443, 140)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcluir.Location = New System.Drawing.Point(351, 293)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(73, 57)
        Me.btnExcluir.TabIndex = 23
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir o Registro")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(273, 293)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 57)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancelar o Registro")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(115, 293)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(73, 57)
        Me.btnSalvar.TabIndex = 20
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Salvar o Registro")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNovo.Location = New System.Drawing.Point(37, 293)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(73, 57)
        Me.btnNovo.TabIndex = 19
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnNovo, "Adicionar um Novo Registro")
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Calendario1
        '
        Me.Calendario1.Location = New System.Drawing.Point(103, 52)
        Me.Calendario1.Name = "Calendario1"
        Me.Calendario1.TabIndex = 26
        Me.Calendario1.Visible = False
        '
        'btnCalendarioAdmissao
        '
        Me.btnCalendarioAdmissao.FlatAppearance.BorderSize = 0
        Me.btnCalendarioAdmissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendarioAdmissao.Image = CType(resources.GetObject("btnCalendarioAdmissao.Image"), System.Drawing.Image)
        Me.btnCalendarioAdmissao.Location = New System.Drawing.Point(202, 209)
        Me.btnCalendarioAdmissao.Name = "btnCalendarioAdmissao"
        Me.btnCalendarioAdmissao.Size = New System.Drawing.Size(27, 27)
        Me.btnCalendarioAdmissao.TabIndex = 27
        Me.btnCalendarioAdmissao.UseVisualStyleBackColor = True
        '
        'DataAdmissaoTextBox
        '
        Me.DataAdmissaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "DataAdmissao", True))
        Me.DataAdmissaoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataAdmissaoTextBox.Location = New System.Drawing.Point(102, 209)
        Me.DataAdmissaoTextBox.Name = "DataAdmissaoTextBox"
        Me.DataAdmissaoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DataAdmissaoTextBox.TabIndex = 29
        '
        'DataDemissaoTextBox
        '
        Me.DataDemissaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "DataDemissao", True))
        Me.DataDemissaoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataDemissaoTextBox.Location = New System.Drawing.Point(331, 209)
        Me.DataDemissaoTextBox.Name = "DataDemissaoTextBox"
        Me.DataDemissaoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DataDemissaoTextBox.TabIndex = 30
        '
        'btnCalendarioDemissao
        '
        Me.btnCalendarioDemissao.FlatAppearance.BorderSize = 0
        Me.btnCalendarioDemissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendarioDemissao.Image = CType(resources.GetObject("btnCalendarioDemissao.Image"), System.Drawing.Image)
        Me.btnCalendarioDemissao.Location = New System.Drawing.Point(437, 206)
        Me.btnCalendarioDemissao.Name = "btnCalendarioDemissao"
        Me.btnCalendarioDemissao.Size = New System.Drawing.Size(27, 27)
        Me.btnCalendarioDemissao.TabIndex = 31
        Me.btnCalendarioDemissao.UseVisualStyleBackColor = True
        '
        'Calendario2
        '
        Me.Calendario2.Location = New System.Drawing.Point(300, 52)
        Me.Calendario2.Name = "Calendario2"
        Me.Calendario2.TabIndex = 32
        Me.Calendario2.Visible = False
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAlterar.Location = New System.Drawing.Point(194, 293)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(73, 57)
        Me.btnAlterar.TabIndex = 22
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Editar o Registro")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Cadastro de Vendedores"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(352, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 15)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "* Campo Requerido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(446, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "*"
        '
        'frmCadVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(469, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCalendarioDemissao)
        Me.Controls.Add(Me.DataDemissaoTextBox)
        Me.Controls.Add(Me.DataAdmissaoTextBox)
        Me.Controls.Add(Me.btnCalendarioAdmissao)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(CodigoVendedorLabel)
        Me.Controls.Add(Me.CodigoVendedorTextBox)
        Me.Controls.Add(VendedorLabel)
        Me.Controls.Add(Me.VendedorTextBox)
        Me.Controls.Add(DataAdmissaoLabel)
        Me.Controls.Add(DataDemissaoLabel)
        Me.Controls.Add(Me.VendedorBindingNavigator)
        Me.Controls.Add(Me.Calendario2)
        Me.Controls.Add(Me.Calendario1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Vendedores"
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VendedorBindingNavigator.ResumeLayout(False)
        Me.VendedorBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancoDataSet As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents VendedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendedorTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.VendedorTableAdapter
    Friend WithEvents TableAdapterManager As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendedorBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CodigoVendedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VendedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents btnExcluir As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnSalvar As System.Windows.Forms.Button
    Private WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Calendario1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnCalendarioAdmissao As System.Windows.Forms.Button
    Friend WithEvents DataAdmissaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDemissaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnCalendarioDemissao As System.Windows.Forms.Button
    Friend WithEvents Calendario2 As System.Windows.Forms.MonthCalendar
    Private WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
