<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsulta))
        Me.rbClientes = New System.Windows.Forms.RadioButton
        Me.rbEstoque = New System.Windows.Forms.RadioButton
        Me.rbContas = New System.Windows.Forms.RadioButton
        Me.rbHistCompra = New System.Windows.Forms.RadioButton
        Me.rbHistVendas = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnRelatorio = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbClientes
        '
        Me.rbClientes.AutoSize = True
        Me.rbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbClientes.Location = New System.Drawing.Point(23, 96)
        Me.rbClientes.Name = "rbClientes"
        Me.rbClientes.Size = New System.Drawing.Size(76, 24)
        Me.rbClientes.TabIndex = 0
        Me.rbClientes.TabStop = True
        Me.rbClientes.Text = "Cliente"
        Me.rbClientes.UseVisualStyleBackColor = True
        '
        'rbEstoque
        '
        Me.rbEstoque.AutoSize = True
        Me.rbEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEstoque.Location = New System.Drawing.Point(23, 134)
        Me.rbEstoque.Name = "rbEstoque"
        Me.rbEstoque.Size = New System.Drawing.Size(141, 24)
        Me.rbEstoque.TabIndex = 1
        Me.rbEstoque.TabStop = True
        Me.rbEstoque.Text = "Estoque Minimo"
        Me.rbEstoque.UseVisualStyleBackColor = True
        '
        'rbContas
        '
        Me.rbContas.AutoSize = True
        Me.rbContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbContas.Location = New System.Drawing.Point(23, 168)
        Me.rbContas.Name = "rbContas"
        Me.rbContas.Size = New System.Drawing.Size(156, 24)
        Me.rbContas.TabIndex = 2
        Me.rbContas.TabStop = True
        Me.rbContas.Text = "Contas a Receber"
        Me.rbContas.UseVisualStyleBackColor = True
        '
        'rbHistCompra
        '
        Me.rbHistCompra.AutoSize = True
        Me.rbHistCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHistCompra.Location = New System.Drawing.Point(215, 96)
        Me.rbHistCompra.Name = "rbHistCompra"
        Me.rbHistCompra.Size = New System.Drawing.Size(171, 24)
        Me.rbHistCompra.TabIndex = 3
        Me.rbHistCompra.TabStop = True
        Me.rbHistCompra.Text = "Histórico de Compra"
        Me.rbHistCompra.UseVisualStyleBackColor = True
        '
        'rbHistVendas
        '
        Me.rbHistVendas.AutoSize = True
        Me.rbHistVendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHistVendas.Location = New System.Drawing.Point(215, 134)
        Me.rbHistVendas.Name = "rbHistVendas"
        Me.rbHistVendas.Size = New System.Drawing.Size(174, 24)
        Me.rbHistVendas.TabIndex = 4
        Me.rbHistVendas.TabStop = True
        Me.rbHistVendas.Text = "Historico  de Vendas"
        Me.rbHistVendas.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(425, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelatorio.Location = New System.Drawing.Point(138, 198)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(120, 53)
        Me.btnRelatorio.TabIndex = 6
        Me.btnRelatorio.Text = "OK"
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(424, 259)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbHistVendas)
        Me.Controls.Add(Me.rbHistCompra)
        Me.Controls.Add(Me.rbContas)
        Me.Controls.Add(Me.rbEstoque)
        Me.Controls.Add(Me.rbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbClientes As System.Windows.Forms.RadioButton
    Friend WithEvents rbEstoque As System.Windows.Forms.RadioButton
    Friend WithEvents rbContas As System.Windows.Forms.RadioButton
    Friend WithEvents rbHistCompra As System.Windows.Forms.RadioButton
    Friend WithEvents rbHistVendas As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
End Class
