<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoricoVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoricoVendas))
        Me.HistoricoVendaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HistoricoVendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet = New SistemaGerenciamentoVendas.BancoDataSet
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnLimpaFiltroCompra = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnFiltroCompra = New System.Windows.Forms.Button
        Me.txtDataFimCompra = New System.Windows.Forms.TextBox
        Me.txtDataInicioCompra = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ItemEstoqueComboBox = New System.Windows.Forms.ComboBox
        Me.ItemEstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblnItem = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TableAdapterManager = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
        Me.ItemEstoqueTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HistoricoVendaTableAdapter1 = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoVendaTableAdapter
        Me.btnConsultar = New System.Windows.Forms.Button
        CType(Me.HistoricoVendaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoricoVendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ItemEstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HistoricoVendaDataGridView
        '
        Me.HistoricoVendaDataGridView.AutoGenerateColumns = False
        Me.HistoricoVendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistoricoVendaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.HistoricoVendaDataGridView.DataSource = Me.HistoricoVendaBindingSource
        Me.HistoricoVendaDataGridView.Location = New System.Drawing.Point(12, 145)
        Me.HistoricoVendaDataGridView.Name = "HistoricoVendaDataGridView"
        Me.HistoricoVendaDataGridView.Size = New System.Drawing.Size(501, 238)
        Me.HistoricoVendaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoItemEstoque"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nº do Item"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Quantidade"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Quantidade"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Valor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor R$"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DataVenda"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Data da Venda"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'HistoricoVendaBindingSource
        '
        Me.HistoricoVendaBindingSource.DataMember = "HistoricoVenda"
        Me.HistoricoVendaBindingSource.DataSource = Me.BancoDataSet
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "BancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnLimpaFiltroCompra)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(528, 145)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(325, 299)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Consulta por:"
        '
        'btnLimpaFiltroCompra
        '
        Me.btnLimpaFiltroCompra.Image = CType(resources.GetObject("btnLimpaFiltroCompra.Image"), System.Drawing.Image)
        Me.btnLimpaFiltroCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpaFiltroCompra.Location = New System.Drawing.Point(80, 236)
        Me.btnLimpaFiltroCompra.Name = "btnLimpaFiltroCompra"
        Me.btnLimpaFiltroCompra.Size = New System.Drawing.Size(169, 54)
        Me.btnLimpaFiltroCompra.TabIndex = 3
        Me.btnLimpaFiltroCompra.Text = "Limpar Consulta"
        Me.btnLimpaFiltroCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpaFiltroCompra.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnFiltroCompra)
        Me.GroupBox1.Controls.Add(Me.txtDataFimCompra)
        Me.GroupBox1.Controls.Add(Me.txtDataInicioCompra)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 105)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(52, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "* Campo Requirido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(167, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(167, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "*"
        '
        'btnFiltroCompra
        '
        Me.btnFiltroCompra.Image = CType(resources.GetObject("btnFiltroCompra.Image"), System.Drawing.Image)
        Me.btnFiltroCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltroCompra.Location = New System.Drawing.Point(189, 25)
        Me.btnFiltroCompra.Name = "btnFiltroCompra"
        Me.btnFiltroCompra.Size = New System.Drawing.Size(110, 58)
        Me.btnFiltroCompra.TabIndex = 5
        Me.btnFiltroCompra.Text = "Consultar"
        Me.btnFiltroCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFiltroCompra.UseVisualStyleBackColor = True
        '
        'txtDataFimCompra
        '
        Me.txtDataFimCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataFimCompra.Location = New System.Drawing.Point(64, 57)
        Me.txtDataFimCompra.Name = "txtDataFimCompra"
        Me.txtDataFimCompra.Size = New System.Drawing.Size(100, 26)
        Me.txtDataFimCompra.TabIndex = 4
        Me.txtDataFimCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtDataFimCompra, "8/6/2009, 20/9/2009")
        '
        'txtDataInicioCompra
        '
        Me.txtDataInicioCompra.BackColor = System.Drawing.SystemColors.Window
        Me.txtDataInicioCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataInicioCompra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDataInicioCompra.Location = New System.Drawing.Point(64, 25)
        Me.txtDataInicioCompra.Name = "txtDataInicioCompra"
        Me.txtDataInicioCompra.Size = New System.Drawing.Size(100, 26)
        Me.txtDataInicioCompra.TabIndex = 3
        Me.txtDataInicioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtDataInicioCompra, "8/6/2009, 20/9/2009")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fim"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Início"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ItemEstoqueComboBox)
        Me.GroupBox2.Controls.Add(Me.lblnItem)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 95)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item de Estoque"
        '
        'ItemEstoqueComboBox
        '
        Me.ItemEstoqueComboBox.DataSource = Me.ItemEstoqueBindingSource
        Me.ItemEstoqueComboBox.DisplayMember = "Descricao"
        Me.ItemEstoqueComboBox.FormattingEnabled = True
        Me.ItemEstoqueComboBox.Location = New System.Drawing.Point(73, 57)
        Me.ItemEstoqueComboBox.Name = "ItemEstoqueComboBox"
        Me.ItemEstoqueComboBox.Size = New System.Drawing.Size(228, 28)
        Me.ItemEstoqueComboBox.TabIndex = 3
        Me.ItemEstoqueComboBox.ValueMember = "CodigoItemEstoque"
        '
        'ItemEstoqueBindingSource
        '
        Me.ItemEstoqueBindingSource.DataMember = "ItemEstoque"
        Me.ItemEstoqueBindingSource.DataSource = Me.BancoDataSet
        '
        'lblnItem
        '
        Me.lblnItem.AutoSize = True
        Me.lblnItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnItem.ForeColor = System.Drawing.Color.Red
        Me.lblnItem.Location = New System.Drawing.Point(97, 22)
        Me.lblnItem.Name = "lblnItem"
        Me.lblnItem.Size = New System.Drawing.Size(0, 20)
        Me.lblnItem.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nº do Item:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Item:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(541, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CidadeTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'ItemEstoqueTableAdapter
        '
        Me.ItemEstoqueTableAdapter.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(103, 389)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Registro(s):"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Exemplo de Data"
        '
        'HistoricoVendaTableAdapter1
        '
        Me.HistoricoVendaTableAdapter1.ClearBeforeFill = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(200, 389)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(115, 56)
        Me.btnConsultar.TabIndex = 11
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'frmHistoricoVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(526, 451)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.HistoricoVendaDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHistoricoVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de HistoricoVendas"
        CType(Me.HistoricoVendaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoricoVendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ItemEstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancoDataSet As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents HistoricoVendaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HistoricoVendaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLimpaFiltroCompra As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnFiltroCompra As System.Windows.Forms.Button
    Friend WithEvents txtDataFimCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtDataInicioCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblnItem As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ItemEstoqueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemEstoqueTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.ItemEstoqueTableAdapter
    Friend WithEvents ItemEstoqueComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents HistoricoVendaTableAdapter1 As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.HistoricoVendaTableAdapter
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
End Class
