Public NotInheritable Class frmSobre

    Private Sub frmSobre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "Sistema de Gerenciamento de Vendas"
        Me.LabelVersion.Text = "Versão 1.0"
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.TextBoxDescription.Text = "Atenção: Este programa de computador é protegido por leis de direitos autorais e intelectuais. A reprodução não autorizada por expressa pelo seu desenvolvedor ou a distribuição deste programa ou uma parte,pode causar severeas penalidades civil ou criminal"
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
