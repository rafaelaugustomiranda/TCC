Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim sql As String = "Select Usuario, Senha from Usuarios where Usuario = @Usuario and Senha = @Senha"
        Dim Conexao As New SqlConnection(StringConexao)
        Dim Comando As New SqlCommand(sql, Conexao)
        Dim reader As SqlDataReader


        Conexao.Open()
        Comando.Parameters.Clear()
        Comando.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
        Comando.Parameters.AddWithValue("@Senha", PasswordTextBox.Text)
        reader = Comando.ExecuteReader()
        reader.Read()


        If UsernameTextBox.Text <> String.Empty And PasswordTextBox.Text <> String.Empty Then
            If reader.HasRows = True Then
                If UsernameTextBox.Text = reader("Usuario").ToString() And PasswordTextBox.Text = reader("Senha").ToString() Then
                    
                    If reader("Usuario").ToString() = "Administrador" Then
                        My.Forms.frmMenu.btnSeguranca.Enabled = True
                    Else
                        My.Forms.frmMenu.btnSeguranca.Enabled = False
                    End If
                    Me.Close()
                    usuario = reader("Usuario").ToString()
                    My.Forms.frmMenu.Show()
                Else
                    MessageBox.Show("Usuário Senha ou Inválido, Verifique com o Administrador", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    reader.Close()
                    Conexao.Close()
                    Application.Exit()
                End If
            Else
                MessageBox.Show("Usuário Senha ou Inválido, Verifique com o Administrador", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                reader.Close()
                Conexao.Close()
                Application.Exit()
            End If
        Else
            MessageBox.Show("Usuário em Branco ou Senha em Branco", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            reader.Close()
            Conexao.Close()
            Application.Exit()
        End If
        
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub
End Class