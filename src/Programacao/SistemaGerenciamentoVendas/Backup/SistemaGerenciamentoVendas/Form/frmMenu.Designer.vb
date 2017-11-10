Imports System.Windows.Forms.Screen
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ribbonControl2 = New mRibbon.RibbonControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.RibbonGroup9 = New mRibbon.RibbonGroup
        Me.RibbonButton1 = New mRibbon.RibbonButton
        Me.ribbonGroup3 = New mRibbon.RibbonGroup
        Me.btnRelatorios = New mRibbon.RibbonButton
        Me.ribbonGroup1 = New mRibbon.RibbonGroup
        Me.btnPagamento = New mRibbon.RibbonButton
        Me.btnVendas = New mRibbon.RibbonButton
        Me.ribbonGroup2 = New mRibbon.RibbonGroup
        Me.btnSeguranca = New mRibbon.RibbonButton
        Me.btnTipoPagamento = New mRibbon.RibbonButton
        Me.btnFormaPagamento = New mRibbon.RibbonButton
        Me.btnVendedores = New mRibbon.RibbonButton
        Me.btnGrupos = New mRibbon.RibbonButton
        Me.btnEstoque = New mRibbon.RibbonButton
        Me.btnClientes = New mRibbon.RibbonButton
        Me.btnCidades = New mRibbon.RibbonButton
        Me.RibbonGroup7 = New mRibbon.RibbonGroup
        Me.btnSobre = New mRibbon.RibbonButton
        Me.RibbonGroup8 = New mRibbon.RibbonGroup
        Me.btnCascata = New mRibbon.RibbonButton
        Me.btnHorizontal = New mRibbon.RibbonButton
        Me.btnVertical = New mRibbon.RibbonButton
        Me.RibbonGroup4 = New mRibbon.RibbonGroup
        Me.RibbonButton8 = New mRibbon.RibbonButton
        Me.RibbonButton9 = New mRibbon.RibbonButton
        Me.RibbonButton10 = New mRibbon.RibbonButton
        Me.RibbonGroup5 = New mRibbon.RibbonGroup
        Me.RibbonButton11 = New mRibbon.RibbonButton
        Me.RibbonButton12 = New mRibbon.RibbonButton
        Me.RibbonGroup6 = New mRibbon.RibbonGroup
        Me.RibbonButton13 = New mRibbon.RibbonButton
        Me.RibbonButton14 = New mRibbon.RibbonButton
        Me.RibbonButton15 = New mRibbon.RibbonButton
        Me.RibbonButton16 = New mRibbon.RibbonButton
        Me.RibbonButton17 = New mRibbon.RibbonButton
        Me.RibbonButton18 = New mRibbon.RibbonButton
        Me.RibbonButton19 = New mRibbon.RibbonButton
        Me.RibbonButton20 = New mRibbon.RibbonButton
        Me.RibbonButton21 = New mRibbon.RibbonButton
        Me.RibbonButton22 = New mRibbon.RibbonButton
        Me.RibbonButton23 = New mRibbon.RibbonButton
        Me.RibbonButton24 = New mRibbon.RibbonButton
        Me.RibbonButton25 = New mRibbon.RibbonButton
        Me.RibbonButton26 = New mRibbon.RibbonButton
        Me.RibbonButton27 = New mRibbon.RibbonButton
        Me.RibbonButton28 = New mRibbon.RibbonButton
        Me.RibbonButton29 = New mRibbon.RibbonButton
        Me.RibbonButton30 = New mRibbon.RibbonButton
        Me.RibbonButton31 = New mRibbon.RibbonButton
        Me.StatusStrip1.SuspendLayout()
        Me.ribbonControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.RibbonGroup9.SuspendLayout()
        Me.ribbonGroup3.SuspendLayout()
        Me.ribbonGroup1.SuspendLayout()
        Me.ribbonGroup2.SuspendLayout()
        Me.RibbonGroup7.SuspendLayout()
        Me.RibbonGroup8.SuspendLayout()
        Me.RibbonGroup4.SuspendLayout()
        Me.RibbonGroup5.SuspendLayout()
        Me.RibbonGroup6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 719)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(77, 19)
        Me.ToolStripStatusLabel1.Text = "Usuário:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(146, 19)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(54, 19)
        Me.ToolStripStatusLabel3.Text = "Hora:"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(146, 19)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(54, 19)
        Me.ToolStripStatusLabel5.Text = "Data:"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(146, 19)
        Me.ToolStripStatusLabel6.Text = "ToolStripStatusLabel6"
        '
        'ribbonControl2
        '
        Me.ribbonControl2.Controls.Add(Me.TabPage2)
        Me.ribbonControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl2.Name = "ribbonControl2"
        Me.ribbonControl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ribbonControl2.SelectedIndex = 0
        Me.ribbonControl2.Size = New System.Drawing.Size(1284, 136)
        Me.ribbonControl2.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.RibbonGroup9)
        Me.TabPage2.Controls.Add(Me.ribbonGroup3)
        Me.TabPage2.Controls.Add(Me.ribbonGroup1)
        Me.TabPage2.Controls.Add(Me.ribbonGroup2)
        Me.TabPage2.Controls.Add(Me.RibbonGroup7)
        Me.TabPage2.Controls.Add(Me.RibbonGroup8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1276, 107)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Menu"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RibbonGroup9
        '
        Me.RibbonGroup9.Controls.Add(Me.RibbonButton1)
        Me.RibbonGroup9.Location = New System.Drawing.Point(804, 3)
        Me.RibbonGroup9.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonGroup9.Name = "RibbonGroup9"
        Me.RibbonGroup9.Size = New System.Drawing.Size(80, 97)
        Me.RibbonGroup9.TabIndex = 15
        Me.RibbonGroup9.TabStop = False
        Me.RibbonGroup9.Text = "Consultas"
        '
        'RibbonButton1
        '
        Me.RibbonButton1.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton1.IsFlat = False
        Me.RibbonButton1.IsPressed = False
        Me.RibbonButton1.Location = New System.Drawing.Point(4, 6)
        Me.RibbonButton1.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton1.Name = "RibbonButton1"
        Me.RibbonButton1.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton1.Size = New System.Drawing.Size(71, 64)
        Me.RibbonButton1.TabIndex = 14
        Me.RibbonButton1.Text = "&Consultas"
        Me.RibbonButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ribbonGroup3
        '
        Me.ribbonGroup3.Controls.Add(Me.btnRelatorios)
        Me.ribbonGroup3.Location = New System.Drawing.Point(886, 3)
        Me.ribbonGroup3.Margin = New System.Windows.Forms.Padding(1)
        Me.ribbonGroup3.Name = "ribbonGroup3"
        Me.ribbonGroup3.Size = New System.Drawing.Size(121, 97)
        Me.ribbonGroup3.TabIndex = 3
        Me.ribbonGroup3.TabStop = False
        Me.ribbonGroup3.Text = "Relatórios"
        '
        'btnRelatorios
        '
        Me.btnRelatorios.BackColor = System.Drawing.Color.Transparent
        Me.btnRelatorios.Image = CType(resources.GetObject("btnRelatorios.Image"), System.Drawing.Image)
        Me.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelatorios.IsFlat = False
        Me.btnRelatorios.IsPressed = False
        Me.btnRelatorios.Location = New System.Drawing.Point(4, 6)
        Me.btnRelatorios.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRelatorios.Name = "btnRelatorios"
        Me.btnRelatorios.Padding = New System.Windows.Forms.Padding(2)
        Me.btnRelatorios.Size = New System.Drawing.Size(113, 64)
        Me.btnRelatorios.TabIndex = 14
        Me.btnRelatorios.Text = "&Relatórios"
        Me.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ribbonGroup1
        '
        Me.ribbonGroup1.Controls.Add(Me.btnPagamento)
        Me.ribbonGroup1.Controls.Add(Me.btnVendas)
        Me.ribbonGroup1.Location = New System.Drawing.Point(636, 3)
        Me.ribbonGroup1.Margin = New System.Windows.Forms.Padding(1)
        Me.ribbonGroup1.Name = "ribbonGroup1"
        Me.ribbonGroup1.Size = New System.Drawing.Size(166, 97)
        Me.ribbonGroup1.TabIndex = 2
        Me.ribbonGroup1.TabStop = False
        Me.ribbonGroup1.Text = "Movimentações"
        '
        'btnPagamento
        '
        Me.btnPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnPagamento.Image = CType(resources.GetObject("btnPagamento.Image"), System.Drawing.Image)
        Me.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPagamento.IsFlat = False
        Me.btnPagamento.IsPressed = False
        Me.btnPagamento.Location = New System.Drawing.Point(83, 8)
        Me.btnPagamento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPagamento.Name = "btnPagamento"
        Me.btnPagamento.Padding = New System.Windows.Forms.Padding(2)
        Me.btnPagamento.Size = New System.Drawing.Size(77, 64)
        Me.btnPagamento.TabIndex = 7
        Me.btnPagamento.Text = "&Pagamento"
        Me.btnPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnVendas
        '
        Me.btnVendas.BackColor = System.Drawing.Color.Transparent
        Me.btnVendas.Image = CType(resources.GetObject("btnVendas.Image"), System.Drawing.Image)
        Me.btnVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVendas.IsFlat = False
        Me.btnVendas.IsPressed = False
        Me.btnVendas.Location = New System.Drawing.Point(4, 8)
        Me.btnVendas.Margin = New System.Windows.Forms.Padding(1)
        Me.btnVendas.Name = "btnVendas"
        Me.btnVendas.Padding = New System.Windows.Forms.Padding(2)
        Me.btnVendas.Size = New System.Drawing.Size(77, 64)
        Me.btnVendas.TabIndex = 6
        Me.btnVendas.Text = "&Vendas"
        Me.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ribbonGroup2
        '
        Me.ribbonGroup2.Controls.Add(Me.btnSeguranca)
        Me.ribbonGroup2.Controls.Add(Me.btnTipoPagamento)
        Me.ribbonGroup2.Controls.Add(Me.btnFormaPagamento)
        Me.ribbonGroup2.Controls.Add(Me.btnVendedores)
        Me.ribbonGroup2.Controls.Add(Me.btnGrupos)
        Me.ribbonGroup2.Controls.Add(Me.btnEstoque)
        Me.ribbonGroup2.Controls.Add(Me.btnClientes)
        Me.ribbonGroup2.Controls.Add(Me.btnCidades)
        Me.ribbonGroup2.Location = New System.Drawing.Point(4, 3)
        Me.ribbonGroup2.Margin = New System.Windows.Forms.Padding(1)
        Me.ribbonGroup2.Name = "ribbonGroup2"
        Me.ribbonGroup2.Size = New System.Drawing.Size(630, 97)
        Me.ribbonGroup2.TabIndex = 1
        Me.ribbonGroup2.TabStop = False
        Me.ribbonGroup2.Text = "Cadastros"
        '
        'btnSeguranca
        '
        Me.btnSeguranca.BackColor = System.Drawing.Color.Transparent
        Me.btnSeguranca.Image = CType(resources.GetObject("btnSeguranca.Image"), System.Drawing.Image)
        Me.btnSeguranca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSeguranca.IsFlat = False
        Me.btnSeguranca.IsPressed = False
        Me.btnSeguranca.Location = New System.Drawing.Point(546, 7)
        Me.btnSeguranca.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeguranca.Name = "btnSeguranca"
        Me.btnSeguranca.Padding = New System.Windows.Forms.Padding(2)
        Me.btnSeguranca.Size = New System.Drawing.Size(77, 65)
        Me.btnSeguranca.TabIndex = 8
        Me.btnSeguranca.Text = "&Segurança"
        Me.btnSeguranca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnTipoPagamento
        '
        Me.btnTipoPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnTipoPagamento.Image = CType(resources.GetObject("btnTipoPagamento.Image"), System.Drawing.Image)
        Me.btnTipoPagamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTipoPagamento.IsFlat = False
        Me.btnTipoPagamento.IsPressed = False
        Me.btnTipoPagamento.Location = New System.Drawing.Point(386, 7)
        Me.btnTipoPagamento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnTipoPagamento.Name = "btnTipoPagamento"
        Me.btnTipoPagamento.Padding = New System.Windows.Forms.Padding(2)
        Me.btnTipoPagamento.Size = New System.Drawing.Size(77, 65)
        Me.btnTipoPagamento.TabIndex = 7
        Me.btnTipoPagamento.Text = "&Tipos de Pagamento"
        Me.btnTipoPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnFormaPagamento
        '
        Me.btnFormaPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnFormaPagamento.Image = CType(resources.GetObject("btnFormaPagamento.Image"), System.Drawing.Image)
        Me.btnFormaPagamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFormaPagamento.IsFlat = False
        Me.btnFormaPagamento.IsPressed = False
        Me.btnFormaPagamento.Location = New System.Drawing.Point(307, 7)
        Me.btnFormaPagamento.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFormaPagamento.Name = "btnFormaPagamento"
        Me.btnFormaPagamento.Padding = New System.Windows.Forms.Padding(2)
        Me.btnFormaPagamento.Size = New System.Drawing.Size(77, 65)
        Me.btnFormaPagamento.TabIndex = 6
        Me.btnFormaPagamento.Text = "&Formas de Pagamento"
        Me.btnFormaPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnVendedores
        '
        Me.btnVendedores.BackColor = System.Drawing.Color.Transparent
        Me.btnVendedores.Image = CType(resources.GetObject("btnVendedores.Image"), System.Drawing.Image)
        Me.btnVendedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVendedores.IsFlat = False
        Me.btnVendedores.IsPressed = False
        Me.btnVendedores.Location = New System.Drawing.Point(232, 7)
        Me.btnVendedores.Margin = New System.Windows.Forms.Padding(1)
        Me.btnVendedores.Name = "btnVendedores"
        Me.btnVendedores.Padding = New System.Windows.Forms.Padding(2)
        Me.btnVendedores.Size = New System.Drawing.Size(73, 64)
        Me.btnVendedores.TabIndex = 3
        Me.btnVendedores.Text = "&Vendedores"
        Me.btnVendedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGrupos
        '
        Me.btnGrupos.BackColor = System.Drawing.Color.Transparent
        Me.btnGrupos.Image = CType(resources.GetObject("btnGrupos.Image"), System.Drawing.Image)
        Me.btnGrupos.IsFlat = False
        Me.btnGrupos.IsPressed = False
        Me.btnGrupos.Location = New System.Drawing.Point(157, 6)
        Me.btnGrupos.Margin = New System.Windows.Forms.Padding(1)
        Me.btnGrupos.Name = "btnGrupos"
        Me.btnGrupos.Padding = New System.Windows.Forms.Padding(2)
        Me.btnGrupos.Size = New System.Drawing.Size(73, 64)
        Me.btnGrupos.TabIndex = 2
        Me.btnGrupos.Text = "&Grupos"
        Me.btnGrupos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnEstoque
        '
        Me.btnEstoque.BackColor = System.Drawing.Color.Transparent
        Me.btnEstoque.Image = CType(resources.GetObject("btnEstoque.Image"), System.Drawing.Image)
        Me.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEstoque.IsFlat = False
        Me.btnEstoque.IsPressed = False
        Me.btnEstoque.Location = New System.Drawing.Point(465, 7)
        Me.btnEstoque.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEstoque.Name = "btnEstoque"
        Me.btnEstoque.Padding = New System.Windows.Forms.Padding(2)
        Me.btnEstoque.Size = New System.Drawing.Size(77, 65)
        Me.btnEstoque.TabIndex = 5
        Me.btnEstoque.Text = "&Estoque"
        Me.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Transparent
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClientes.IsFlat = False
        Me.btnClientes.IsPressed = False
        Me.btnClientes.Location = New System.Drawing.Point(7, 7)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(1)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(2)
        Me.btnClientes.Size = New System.Drawing.Size(73, 64)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "&Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCidades
        '
        Me.btnCidades.BackColor = System.Drawing.Color.Transparent
        Me.btnCidades.Image = CType(resources.GetObject("btnCidades.Image"), System.Drawing.Image)
        Me.btnCidades.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCidades.IsFlat = False
        Me.btnCidades.IsPressed = False
        Me.btnCidades.Location = New System.Drawing.Point(82, 7)
        Me.btnCidades.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCidades.Name = "btnCidades"
        Me.btnCidades.Padding = New System.Windows.Forms.Padding(2)
        Me.btnCidades.Size = New System.Drawing.Size(73, 64)
        Me.btnCidades.TabIndex = 0
        Me.btnCidades.Text = "&Cidades"
        Me.btnCidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonGroup7
        '
        Me.RibbonGroup7.Controls.Add(Me.btnSobre)
        Me.RibbonGroup7.Location = New System.Drawing.Point(1181, 3)
        Me.RibbonGroup7.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonGroup7.Name = "RibbonGroup7"
        Me.RibbonGroup7.Size = New System.Drawing.Size(89, 97)
        Me.RibbonGroup7.TabIndex = 14
        Me.RibbonGroup7.TabStop = False
        Me.RibbonGroup7.Text = "Sobre"
        '
        'btnSobre
        '
        Me.btnSobre.Image = CType(resources.GetObject("btnSobre.Image"), System.Drawing.Image)
        Me.btnSobre.IsFlat = False
        Me.btnSobre.IsPressed = False
        Me.btnSobre.Location = New System.Drawing.Point(4, 4)
        Me.btnSobre.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSobre.Name = "btnSobre"
        Me.btnSobre.Padding = New System.Windows.Forms.Padding(2)
        Me.btnSobre.Size = New System.Drawing.Size(81, 73)
        Me.btnSobre.TabIndex = 0
        Me.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RibbonGroup8
        '
        Me.RibbonGroup8.Controls.Add(Me.btnCascata)
        Me.RibbonGroup8.Controls.Add(Me.btnHorizontal)
        Me.RibbonGroup8.Controls.Add(Me.btnVertical)
        Me.RibbonGroup8.Location = New System.Drawing.Point(1009, 3)
        Me.RibbonGroup8.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonGroup8.Name = "RibbonGroup8"
        Me.RibbonGroup8.Size = New System.Drawing.Size(170, 97)
        Me.RibbonGroup8.TabIndex = 15
        Me.RibbonGroup8.TabStop = False
        Me.RibbonGroup8.Text = "Organizar Janelas"
        '
        'btnCascata
        '
        Me.btnCascata.Image = CType(resources.GetObject("btnCascata.Image"), System.Drawing.Image)
        Me.btnCascata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCascata.IsFlat = False
        Me.btnCascata.IsPressed = False
        Me.btnCascata.Location = New System.Drawing.Point(4, 54)
        Me.btnCascata.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCascata.Name = "btnCascata"
        Me.btnCascata.Padding = New System.Windows.Forms.Padding(2)
        Me.btnCascata.Size = New System.Drawing.Size(158, 23)
        Me.btnCascata.TabIndex = 2
        Me.btnCascata.Text = "Cascata"
        Me.btnCascata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHorizontal
        '
        Me.btnHorizontal.Image = CType(resources.GetObject("btnHorizontal.Image"), System.Drawing.Image)
        Me.btnHorizontal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHorizontal.IsFlat = False
        Me.btnHorizontal.IsPressed = False
        Me.btnHorizontal.Location = New System.Drawing.Point(4, 29)
        Me.btnHorizontal.Margin = New System.Windows.Forms.Padding(1)
        Me.btnHorizontal.Name = "btnHorizontal"
        Me.btnHorizontal.Padding = New System.Windows.Forms.Padding(2)
        Me.btnHorizontal.Size = New System.Drawing.Size(158, 23)
        Me.btnHorizontal.TabIndex = 1
        Me.btnHorizontal.Text = "Horizontal"
        Me.btnHorizontal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVertical
        '
        Me.btnVertical.Image = CType(resources.GetObject("btnVertical.Image"), System.Drawing.Image)
        Me.btnVertical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVertical.IsFlat = False
        Me.btnVertical.IsPressed = False
        Me.btnVertical.Location = New System.Drawing.Point(4, 4)
        Me.btnVertical.Margin = New System.Windows.Forms.Padding(1)
        Me.btnVertical.Name = "btnVertical"
        Me.btnVertical.Padding = New System.Windows.Forms.Padding(2)
        Me.btnVertical.Size = New System.Drawing.Size(158, 23)
        Me.btnVertical.TabIndex = 0
        Me.btnVertical.Text = "Vertical"
        Me.btnVertical.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RibbonGroup4
        '
        Me.RibbonGroup4.Controls.Add(Me.RibbonButton8)
        Me.RibbonGroup4.Controls.Add(Me.RibbonButton9)
        Me.RibbonGroup4.Controls.Add(Me.RibbonButton10)
        Me.RibbonGroup4.Location = New System.Drawing.Point(726, 3)
        Me.RibbonGroup4.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonGroup4.Name = "RibbonGroup4"
        Me.RibbonGroup4.Size = New System.Drawing.Size(252, 97)
        Me.RibbonGroup4.TabIndex = 3
        Me.RibbonGroup4.TabStop = False
        Me.RibbonGroup4.Text = "Consultas"
        '
        'RibbonButton8
        '
        Me.RibbonButton8.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton8.Image = CType(resources.GetObject("RibbonButton8.Image"), System.Drawing.Image)
        Me.RibbonButton8.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton8.IsFlat = False
        Me.RibbonButton8.IsPressed = False
        Me.RibbonButton8.Location = New System.Drawing.Point(162, 6)
        Me.RibbonButton8.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton8.Name = "RibbonButton8"
        Me.RibbonButton8.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton8.Size = New System.Drawing.Size(77, 64)
        Me.RibbonButton8.TabIndex = 10
        Me.RibbonButton8.Text = "&Clientes"
        Me.RibbonButton8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton9
        '
        Me.RibbonButton9.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton9.Image = CType(resources.GetObject("RibbonButton9.Image"), System.Drawing.Image)
        Me.RibbonButton9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton9.IsFlat = False
        Me.RibbonButton9.IsPressed = False
        Me.RibbonButton9.Location = New System.Drawing.Point(83, 6)
        Me.RibbonButton9.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton9.Name = "RibbonButton9"
        Me.RibbonButton9.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton9.Size = New System.Drawing.Size(77, 64)
        Me.RibbonButton9.TabIndex = 9
        Me.RibbonButton9.Text = "&Grupos"
        Me.RibbonButton9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton10
        '
        Me.RibbonButton10.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton10.Image = CType(resources.GetObject("RibbonButton10.Image"), System.Drawing.Image)
        Me.RibbonButton10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton10.IsFlat = False
        Me.RibbonButton10.IsPressed = False
        Me.RibbonButton10.Location = New System.Drawing.Point(4, 6)
        Me.RibbonButton10.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton10.Name = "RibbonButton10"
        Me.RibbonButton10.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton10.Size = New System.Drawing.Size(77, 64)
        Me.RibbonButton10.TabIndex = 8
        Me.RibbonButton10.Text = "&Cidades"
        Me.RibbonButton10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonGroup5
        '
        Me.RibbonGroup5.Controls.Add(Me.RibbonButton11)
        Me.RibbonGroup5.Controls.Add(Me.RibbonButton12)
        Me.RibbonGroup5.Location = New System.Drawing.Point(558, 4)
        Me.RibbonGroup5.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonGroup5.Name = "RibbonGroup5"
        Me.RibbonGroup5.Size = New System.Drawing.Size(166, 97)
        Me.RibbonGroup5.TabIndex = 2
        Me.RibbonGroup5.TabStop = False
        Me.RibbonGroup5.Text = "Movimentações"
        '
        'RibbonButton11
        '
        Me.RibbonButton11.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton11.Image = CType(resources.GetObject("RibbonButton11.Image"), System.Drawing.Image)
        Me.RibbonButton11.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton11.IsFlat = False
        Me.RibbonButton11.IsPressed = False
        Me.RibbonButton11.Location = New System.Drawing.Point(85, 8)
        Me.RibbonButton11.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton11.Name = "RibbonButton11"
        Me.RibbonButton11.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton11.Size = New System.Drawing.Size(77, 64)
        Me.RibbonButton11.TabIndex = 7
        Me.RibbonButton11.Text = "&Pagamento"
        Me.RibbonButton11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton12
        '
        Me.RibbonButton12.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton12.Image = CType(resources.GetObject("RibbonButton12.Image"), System.Drawing.Image)
        Me.RibbonButton12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton12.IsFlat = False
        Me.RibbonButton12.IsPressed = False
        Me.RibbonButton12.Location = New System.Drawing.Point(4, 8)
        Me.RibbonButton12.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton12.Name = "RibbonButton12"
        Me.RibbonButton12.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton12.Size = New System.Drawing.Size(77, 64)
        Me.RibbonButton12.TabIndex = 6
        Me.RibbonButton12.Text = "&Vendas"
        Me.RibbonButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonGroup6
        '
        Me.RibbonGroup6.Controls.Add(Me.RibbonButton13)
        Me.RibbonGroup6.Controls.Add(Me.RibbonButton14)
        Me.RibbonGroup6.Controls.Add(Me.RibbonButton15)
        Me.RibbonGroup6.Controls.Add(Me.RibbonButton16)
        Me.RibbonGroup6.Controls.Add(Me.RibbonButton17)
        Me.RibbonGroup6.Controls.Add(Me.RibbonButton18)
        Me.RibbonGroup6.Controls.Add(Me.RibbonButton19)
        Me.RibbonGroup6.Location = New System.Drawing.Point(6, 5)
        Me.RibbonGroup6.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonGroup6.Name = "RibbonGroup6"
        Me.RibbonGroup6.Size = New System.Drawing.Size(550, 97)
        Me.RibbonGroup6.TabIndex = 1
        Me.RibbonGroup6.TabStop = False
        Me.RibbonGroup6.Text = "Cadastros"
        '
        'RibbonButton13
        '
        Me.RibbonButton13.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton13.Image = CType(resources.GetObject("RibbonButton13.Image"), System.Drawing.Image)
        Me.RibbonButton13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton13.IsFlat = False
        Me.RibbonButton13.IsPressed = False
        Me.RibbonButton13.Location = New System.Drawing.Point(386, 7)
        Me.RibbonButton13.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton13.Name = "RibbonButton13"
        Me.RibbonButton13.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton13.Size = New System.Drawing.Size(77, 65)
        Me.RibbonButton13.TabIndex = 7
        Me.RibbonButton13.Text = "&Tipos de Pagamento"
        Me.RibbonButton13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton14
        '
        Me.RibbonButton14.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton14.Image = CType(resources.GetObject("RibbonButton14.Image"), System.Drawing.Image)
        Me.RibbonButton14.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton14.IsFlat = False
        Me.RibbonButton14.IsPressed = False
        Me.RibbonButton14.Location = New System.Drawing.Point(307, 7)
        Me.RibbonButton14.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton14.Name = "RibbonButton14"
        Me.RibbonButton14.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton14.Size = New System.Drawing.Size(77, 65)
        Me.RibbonButton14.TabIndex = 6
        Me.RibbonButton14.Text = "&Formas de Pagamento"
        Me.RibbonButton14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton15
        '
        Me.RibbonButton15.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton15.Image = CType(resources.GetObject("RibbonButton15.Image"), System.Drawing.Image)
        Me.RibbonButton15.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton15.IsFlat = False
        Me.RibbonButton15.IsPressed = False
        Me.RibbonButton15.Location = New System.Drawing.Point(232, 7)
        Me.RibbonButton15.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton15.Name = "RibbonButton15"
        Me.RibbonButton15.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton15.Size = New System.Drawing.Size(73, 64)
        Me.RibbonButton15.TabIndex = 3
        Me.RibbonButton15.Text = "&Vendedores"
        Me.RibbonButton15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton16
        '
        Me.RibbonButton16.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton16.Image = CType(resources.GetObject("RibbonButton16.Image"), System.Drawing.Image)
        Me.RibbonButton16.IsFlat = False
        Me.RibbonButton16.IsPressed = False
        Me.RibbonButton16.Location = New System.Drawing.Point(157, 6)
        Me.RibbonButton16.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton16.Name = "RibbonButton16"
        Me.RibbonButton16.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton16.Size = New System.Drawing.Size(73, 64)
        Me.RibbonButton16.TabIndex = 2
        Me.RibbonButton16.Text = "&Grupos"
        Me.RibbonButton16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton17
        '
        Me.RibbonButton17.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton17.Image = CType(resources.GetObject("RibbonButton17.Image"), System.Drawing.Image)
        Me.RibbonButton17.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton17.IsFlat = False
        Me.RibbonButton17.IsPressed = False
        Me.RibbonButton17.Location = New System.Drawing.Point(465, 7)
        Me.RibbonButton17.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton17.Name = "RibbonButton17"
        Me.RibbonButton17.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton17.Size = New System.Drawing.Size(77, 65)
        Me.RibbonButton17.TabIndex = 5
        Me.RibbonButton17.Text = "&Estoque"
        Me.RibbonButton17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton18
        '
        Me.RibbonButton18.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton18.Image = CType(resources.GetObject("RibbonButton18.Image"), System.Drawing.Image)
        Me.RibbonButton18.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton18.IsFlat = False
        Me.RibbonButton18.IsPressed = False
        Me.RibbonButton18.Location = New System.Drawing.Point(7, 7)
        Me.RibbonButton18.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton18.Name = "RibbonButton18"
        Me.RibbonButton18.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton18.Size = New System.Drawing.Size(73, 64)
        Me.RibbonButton18.TabIndex = 1
        Me.RibbonButton18.Text = "&Clientes"
        Me.RibbonButton18.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton19
        '
        Me.RibbonButton19.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton19.Image = CType(resources.GetObject("RibbonButton19.Image"), System.Drawing.Image)
        Me.RibbonButton19.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton19.IsFlat = False
        Me.RibbonButton19.IsPressed = False
        Me.RibbonButton19.Location = New System.Drawing.Point(82, 7)
        Me.RibbonButton19.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton19.Name = "RibbonButton19"
        Me.RibbonButton19.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton19.Size = New System.Drawing.Size(73, 64)
        Me.RibbonButton19.TabIndex = 0
        Me.RibbonButton19.Text = "&Cidades"
        Me.RibbonButton19.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton20
        '
        Me.RibbonButton20.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton20.Image = CType(resources.GetObject("RibbonButton20.Image"), System.Drawing.Image)
        Me.RibbonButton20.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton20.IsFlat = False
        Me.RibbonButton20.IsPressed = False
        Me.RibbonButton20.Location = New System.Drawing.Point(162, 6)
        Me.RibbonButton20.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton20.Name = "RibbonButton20"
        Me.RibbonButton20.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton20.Size = New System.Drawing.Size(77, 64)
        Me.RibbonButton20.TabIndex = 10
        Me.RibbonButton20.Text = "&Clientes"
        Me.RibbonButton20.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton21
        '
        Me.RibbonButton21.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton21.Image = CType(resources.GetObject("RibbonButton21.Image"), System.Drawing.Image)
        Me.RibbonButton21.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton21.IsFlat = False
        Me.RibbonButton21.IsPressed = False
        Me.RibbonButton21.Location = New System.Drawing.Point(83, 6)
        Me.RibbonButton21.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton21.Name = "RibbonButton21"
        Me.RibbonButton21.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton21.Size = New System.Drawing.Size(77, 64)
        Me.RibbonButton21.TabIndex = 9
        Me.RibbonButton21.Text = "&Grupos"
        Me.RibbonButton21.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton22
        '
        Me.RibbonButton22.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton22.Image = CType(resources.GetObject("RibbonButton22.Image"), System.Drawing.Image)
        Me.RibbonButton22.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton22.IsFlat = False
        Me.RibbonButton22.IsPressed = False
        Me.RibbonButton22.Location = New System.Drawing.Point(4, 6)
        Me.RibbonButton22.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton22.Name = "RibbonButton22"
        Me.RibbonButton22.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton22.Size = New System.Drawing.Size(77, 64)
        Me.RibbonButton22.TabIndex = 8
        Me.RibbonButton22.Text = "&Cidades"
        Me.RibbonButton22.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton23
        '
        Me.RibbonButton23.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton23.Image = CType(resources.GetObject("RibbonButton23.Image"), System.Drawing.Image)
        Me.RibbonButton23.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton23.IsFlat = False
        Me.RibbonButton23.IsPressed = False
        Me.RibbonButton23.Location = New System.Drawing.Point(85, 8)
        Me.RibbonButton23.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton23.Name = "RibbonButton23"
        Me.RibbonButton23.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton23.Size = New System.Drawing.Size(77, 64)
        Me.RibbonButton23.TabIndex = 7
        Me.RibbonButton23.Text = "&Pagamento"
        Me.RibbonButton23.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton24
        '
        Me.RibbonButton24.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton24.Image = CType(resources.GetObject("RibbonButton24.Image"), System.Drawing.Image)
        Me.RibbonButton24.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton24.IsFlat = False
        Me.RibbonButton24.IsPressed = False
        Me.RibbonButton24.Location = New System.Drawing.Point(4, 8)
        Me.RibbonButton24.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton24.Name = "RibbonButton24"
        Me.RibbonButton24.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton24.Size = New System.Drawing.Size(77, 64)
        Me.RibbonButton24.TabIndex = 6
        Me.RibbonButton24.Text = "&Vendas"
        Me.RibbonButton24.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton25
        '
        Me.RibbonButton25.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton25.Image = CType(resources.GetObject("RibbonButton25.Image"), System.Drawing.Image)
        Me.RibbonButton25.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton25.IsFlat = False
        Me.RibbonButton25.IsPressed = False
        Me.RibbonButton25.Location = New System.Drawing.Point(386, 7)
        Me.RibbonButton25.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton25.Name = "RibbonButton25"
        Me.RibbonButton25.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton25.Size = New System.Drawing.Size(77, 65)
        Me.RibbonButton25.TabIndex = 7
        Me.RibbonButton25.Text = "&Tipos de Pagamento"
        Me.RibbonButton25.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton26
        '
        Me.RibbonButton26.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton26.Image = CType(resources.GetObject("RibbonButton26.Image"), System.Drawing.Image)
        Me.RibbonButton26.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton26.IsFlat = False
        Me.RibbonButton26.IsPressed = False
        Me.RibbonButton26.Location = New System.Drawing.Point(307, 7)
        Me.RibbonButton26.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton26.Name = "RibbonButton26"
        Me.RibbonButton26.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton26.Size = New System.Drawing.Size(77, 65)
        Me.RibbonButton26.TabIndex = 6
        Me.RibbonButton26.Text = "&Formas de Pagamento"
        Me.RibbonButton26.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton27
        '
        Me.RibbonButton27.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton27.Image = CType(resources.GetObject("RibbonButton27.Image"), System.Drawing.Image)
        Me.RibbonButton27.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton27.IsFlat = False
        Me.RibbonButton27.IsPressed = False
        Me.RibbonButton27.Location = New System.Drawing.Point(232, 7)
        Me.RibbonButton27.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton27.Name = "RibbonButton27"
        Me.RibbonButton27.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton27.Size = New System.Drawing.Size(73, 64)
        Me.RibbonButton27.TabIndex = 3
        Me.RibbonButton27.Text = "&Vendedores"
        Me.RibbonButton27.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton28
        '
        Me.RibbonButton28.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton28.Image = CType(resources.GetObject("RibbonButton28.Image"), System.Drawing.Image)
        Me.RibbonButton28.IsFlat = False
        Me.RibbonButton28.IsPressed = False
        Me.RibbonButton28.Location = New System.Drawing.Point(157, 6)
        Me.RibbonButton28.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton28.Name = "RibbonButton28"
        Me.RibbonButton28.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton28.Size = New System.Drawing.Size(73, 64)
        Me.RibbonButton28.TabIndex = 2
        Me.RibbonButton28.Text = "&Grupos"
        Me.RibbonButton28.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton29
        '
        Me.RibbonButton29.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton29.Image = CType(resources.GetObject("RibbonButton29.Image"), System.Drawing.Image)
        Me.RibbonButton29.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton29.IsFlat = False
        Me.RibbonButton29.IsPressed = False
        Me.RibbonButton29.Location = New System.Drawing.Point(465, 7)
        Me.RibbonButton29.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton29.Name = "RibbonButton29"
        Me.RibbonButton29.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton29.Size = New System.Drawing.Size(77, 65)
        Me.RibbonButton29.TabIndex = 5
        Me.RibbonButton29.Text = "&Estoque"
        Me.RibbonButton29.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton30
        '
        Me.RibbonButton30.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton30.Image = CType(resources.GetObject("RibbonButton30.Image"), System.Drawing.Image)
        Me.RibbonButton30.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton30.IsFlat = False
        Me.RibbonButton30.IsPressed = False
        Me.RibbonButton30.Location = New System.Drawing.Point(7, 7)
        Me.RibbonButton30.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton30.Name = "RibbonButton30"
        Me.RibbonButton30.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton30.Size = New System.Drawing.Size(73, 64)
        Me.RibbonButton30.TabIndex = 1
        Me.RibbonButton30.Text = "&Clientes"
        Me.RibbonButton30.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RibbonButton31
        '
        Me.RibbonButton31.BackColor = System.Drawing.Color.Transparent
        Me.RibbonButton31.Image = CType(resources.GetObject("RibbonButton31.Image"), System.Drawing.Image)
        Me.RibbonButton31.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RibbonButton31.IsFlat = False
        Me.RibbonButton31.IsPressed = False
        Me.RibbonButton31.Location = New System.Drawing.Point(82, 7)
        Me.RibbonButton31.Margin = New System.Windows.Forms.Padding(1)
        Me.RibbonButton31.Name = "RibbonButton31"
        Me.RibbonButton31.Padding = New System.Windows.Forms.Padding(2)
        Me.RibbonButton31.Size = New System.Drawing.Size(73, 64)
        Me.RibbonButton31.TabIndex = 0
        Me.RibbonButton31.Text = "&Cidades"
        Me.RibbonButton31.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 743)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ribbonControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Sistema Gerencimento de Vendas [Essence Brasil]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ribbonControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.RibbonGroup9.ResumeLayout(False)
        Me.ribbonGroup3.ResumeLayout(False)
        Me.ribbonGroup1.ResumeLayout(False)
        Me.ribbonGroup2.ResumeLayout(False)
        Me.RibbonGroup7.ResumeLayout(False)
        Me.RibbonGroup8.ResumeLayout(False)
        Me.RibbonGroup4.ResumeLayout(False)
        Me.RibbonGroup5.ResumeLayout(False)
        Me.RibbonGroup6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ribbonControl2 As mRibbon.RibbonControl
    Private WithEvents ribbonGroup3 As mRibbon.RibbonGroup
    Private WithEvents ribbonGroup1 As mRibbon.RibbonGroup
    Private WithEvents btnPagamento As mRibbon.RibbonButton
    Private WithEvents btnVendas As mRibbon.RibbonButton
    Private WithEvents btnEstoque As mRibbon.RibbonButton
    Private WithEvents ribbonGroup2 As mRibbon.RibbonGroup
    Private WithEvents btnVendedores As mRibbon.RibbonButton
    Private WithEvents btnGrupos As mRibbon.RibbonButton
    Private WithEvents btnClientes As mRibbon.RibbonButton
    Private WithEvents btnCidades As mRibbon.RibbonButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents btnFormaPagamento As mRibbon.RibbonButton
    Private WithEvents btnTipoPagamento As mRibbon.RibbonButton
    Private WithEvents RibbonGroup4 As mRibbon.RibbonGroup
    Private WithEvents RibbonButton8 As mRibbon.RibbonButton
    Private WithEvents RibbonButton9 As mRibbon.RibbonButton
    Private WithEvents RibbonButton10 As mRibbon.RibbonButton
    Private WithEvents RibbonGroup5 As mRibbon.RibbonGroup
    Private WithEvents RibbonButton11 As mRibbon.RibbonButton
    Private WithEvents RibbonButton12 As mRibbon.RibbonButton
    Private WithEvents RibbonGroup6 As mRibbon.RibbonGroup
    Private WithEvents RibbonButton13 As mRibbon.RibbonButton
    Private WithEvents RibbonButton14 As mRibbon.RibbonButton
    Private WithEvents RibbonButton15 As mRibbon.RibbonButton
    Private WithEvents RibbonButton16 As mRibbon.RibbonButton
    Private WithEvents RibbonButton17 As mRibbon.RibbonButton
    Private WithEvents RibbonButton18 As mRibbon.RibbonButton
    Private WithEvents RibbonButton19 As mRibbon.RibbonButton
    Private WithEvents RibbonButton20 As mRibbon.RibbonButton
    Private WithEvents RibbonButton21 As mRibbon.RibbonButton
    Private WithEvents RibbonButton22 As mRibbon.RibbonButton
    Private WithEvents RibbonButton23 As mRibbon.RibbonButton
    Private WithEvents RibbonButton24 As mRibbon.RibbonButton
    Private WithEvents RibbonButton25 As mRibbon.RibbonButton
    Private WithEvents RibbonButton26 As mRibbon.RibbonButton
    Private WithEvents RibbonButton27 As mRibbon.RibbonButton
    Private WithEvents RibbonButton28 As mRibbon.RibbonButton
    Private WithEvents RibbonButton29 As mRibbon.RibbonButton
    Private WithEvents RibbonButton30 As mRibbon.RibbonButton
    Private WithEvents RibbonButton31 As mRibbon.RibbonButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RibbonGroup8 As mRibbon.RibbonGroup
    Friend WithEvents btnCascata As mRibbon.RibbonButton
    Friend WithEvents btnHorizontal As mRibbon.RibbonButton
    Friend WithEvents btnVertical As mRibbon.RibbonButton
    Private WithEvents RibbonGroup7 As mRibbon.RibbonGroup
    Private WithEvents btnRelatorios As mRibbon.RibbonButton
    Friend WithEvents btnSobre As mRibbon.RibbonButton
    Public WithEvents btnSeguranca As mRibbon.RibbonButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents RibbonGroup9 As mRibbon.RibbonGroup
    Private WithEvents RibbonButton1 As mRibbon.RibbonButton

End Class
