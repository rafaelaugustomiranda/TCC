<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorios))
        Me.Rel2 = New System.Windows.Forms.RadioButton
        Me.btnRelatorio = New System.Windows.Forms.Button
        Me.Rel1 = New System.Windows.Forms.RadioButton
        Me.Rel3 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.rel4 = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.rel5 = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.rel6 = New System.Windows.Forms.RadioButton
        Me.BancoDataSet = New SistemaGerenciamentoVendas.BancoDataSet
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrupoTableAdapter = New SistemaGerenciamentoVendas.BancoDataSetTableAdapters.GrupoTableAdapter
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rel2
        '
        Me.Rel2.AutoSize = True
        Me.Rel2.Location = New System.Drawing.Point(39, 167)
        Me.Rel2.Name = "Rel2"
        Me.Rel2.Size = New System.Drawing.Size(185, 17)
        Me.Rel2.TabIndex = 0
        Me.Rel2.TabStop = True
        Me.Rel2.Text = "Grafico de Quantidade x Produtos"
        Me.Rel2.UseVisualStyleBackColor = True
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelatorio.Location = New System.Drawing.Point(130, 251)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(124, 52)
        Me.btnRelatorio.TabIndex = 1
        Me.btnRelatorio.Text = "&OK"
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'Rel1
        '
        Me.Rel1.AutoSize = True
        Me.Rel1.Location = New System.Drawing.Point(287, 111)
        Me.Rel1.Name = "Rel1"
        Me.Rel1.Size = New System.Drawing.Size(62, 17)
        Me.Rel1.TabIndex = 1
        Me.Rel1.TabStop = True
        Me.Rel1.Text = "Clientes"
        Me.Rel1.UseVisualStyleBackColor = True
        '
        'Rel3
        '
        Me.Rel3.AutoSize = True
        Me.Rel3.Location = New System.Drawing.Point(39, 111)
        Me.Rel3.Name = "Rel3"
        Me.Rel3.Size = New System.Drawing.Size(185, 17)
        Me.Rel3.TabIndex = 2
        Me.Rel3.TabStop = True
        Me.Rel3.Text = "Grafico de Quantidade x Produtos"
        Me.Rel3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Histórico de Compra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Histórico de Venda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(263, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Venda"
        '
        'rel4
        '
        Me.rel4.AutoSize = True
        Me.rel4.Location = New System.Drawing.Point(287, 167)
        Me.rel4.Name = "rel4"
        Me.rel4.Size = New System.Drawing.Size(61, 17)
        Me.rel4.TabIndex = 6
        Me.rel4.TabStop = True
        Me.rel4.Text = "Vendas"
        Me.rel4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pagamento das Vendas"
        '
        'rel5
        '
        Me.rel5.AutoSize = True
        Me.rel5.Location = New System.Drawing.Point(38, 225)
        Me.rel5.Name = "rel5"
        Me.rel5.Size = New System.Drawing.Size(203, 17)
        Me.rel5.TabIndex = 8
        Me.rel5.TabStop = True
        Me.rel5.Text = "Quantidade de Pagamento Efetuados"
        Me.rel5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(263, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Estoque"
        '
        'rel6
        '
        Me.rel6.AutoSize = True
        Me.rel6.Location = New System.Drawing.Point(287, 222)
        Me.rel6.Name = "rel6"
        Me.rel6.Size = New System.Drawing.Size(100, 17)
        Me.rel6.TabIndex = 10
        Me.rel6.TabStop = True
        Me.rel6.Text = "Estoque Minimo"
        Me.rel6.UseVisualStyleBackColor = True
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "BancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GrupoBindingSource
        '
        Me.GrupoBindingSource.DataMember = "Grupo"
        Me.GrupoBindingSource.DataSource = Me.BancoDataSet
        '
        'GrupoTableAdapter
        '
        Me.GrupoTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(425, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'frmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(419, 309)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rel6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rel5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rel4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Rel2)
        Me.Controls.Add(Me.Rel3)
        Me.Controls.Add(Me.Rel1)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRelatorios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios"
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rel2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents Rel1 As System.Windows.Forms.RadioButton
    Friend WithEvents Rel3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rel4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rel5 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rel6 As System.Windows.Forms.RadioButton
    Friend WithEvents BancoDataSet As SistemaGerenciamentoVendas.BancoDataSet
    Friend WithEvents GrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GrupoTableAdapter As SistemaGerenciamentoVendas.BancoDataSetTableAdapters.GrupoTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
