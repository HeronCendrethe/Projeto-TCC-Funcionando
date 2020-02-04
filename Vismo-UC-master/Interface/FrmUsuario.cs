using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;

namespace Vismo
{
    public partial class FrmUsuario : Form
    {
        Usuario usuario = new Usuario();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        //cabeçalho da tela
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        //ação para criação de conta de usuário
        private void BtnConcluir_Click(object sender, EventArgs e)
        {
            if (!txtPrincipal.Text.Equals("") && !txtEmail.Text.Equals("") &&
                !txtSenha.Text.Equals("") && !txtConfSenha.Text.Equals("") &&
                !txtPadrao.Text.Equals("") && !txtSenhaP.Text.Equals("") &&
                !txtSenhaP.Text.Equals("") && lblUsuario.Visible == false &&
                lblEmail1.Visible == false && lblSenha.Visible == false &&
                lblSenhaP.Visible == false)
            {
                usuario.Nome = txtPrincipal.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;

                usuario.NomePadrao = txtPadrao.Text;
                usuario.SenhaPadrao = txtSenhaP.Text;

                try
                {
                    usuario.Inserir();
                    usuario.GetCodigo();
                    usuario.CriaPreferencia();

                    MessageBox.Show("Conta de Usuário criada com sucesso.", "Confirmação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Application.OpenForms["FrmLogin"].Show();

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar se conectar com o Banco de Dados", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    MessageBox.Show(ex.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Validação de todos os campos é necessária para criação de conta de Usuário", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ação para retornar a tela de Login
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FrmLogin"].Show();

            Close();
        }


        //validação de campos do formulário
        private void TxtPrincipal_Leave(object sender, EventArgs e)
        {
            if (!txtPrincipal.Text.Equals(""))
            {
                usuario.Nome = txtPrincipal.Text;

                try
                {
                    if (usuario.ChecaNome() == true)
                    {
                        lblUsuario.Visible = true;
                    }
                    else
                    {
                        lblUsuario.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MessageBox.Show(ex.Message);
                }
            }   
        }

        private void TxtConfSenha_Leave(object sender, EventArgs e)
        {
            if (!txtSenha.Text.Equals("") && !txtConfSenha.Text.Equals(""))
            {
                if (txtSenha.Text != txtConfSenha.Text)
                {
                    lblSenha.Visible = true;
                }
                else
                {
                    lblSenha.Visible = false;
                }
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Equals(""))
            {
                string login = new string(txtEmail.Text.Reverse().ToArray());

                for (int i = 0; i < txtEmail.Text.Length; i++)
                {
                    if (txtEmail.Text.ElementAt(i) == '@')
                    {
                        if (login.Substring(0, 4) == "moc.")
                        {
                            i = txtEmail.Text.Length;

                            lblEmail2.Visible = false;

                            usuario.Email = txtEmail.Text;

                            try
                            {
                                if (usuario.ChecaEmail() == true)
                                {
                                    lblEmail1.Visible = true;
                                }
                                else
                                {
                                    lblEmail1.Visible = false;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            lblEmail2.Visible = true;
                            lblEmail1.Visible = false;
                        }
                    }
                    else
                    {
                        lblEmail2.Visible = true;
                        lblEmail1.Visible = false;
                    }
                }
            }
        }

        private void TxtConfSenhaP_Leave(object sender, EventArgs e)
        {
            if (!txtSenhaP.Text.Equals("") && !txtConfSenhaP.Text.Equals(""))
            {
                if (txtSenhaP.Text != txtConfSenhaP.Text)
                {
                    lblSenhaP.Visible = true;
                }
                else
                {
                    lblSenhaP.Visible = false;
                }
            }
        }

        private void TxtPadrao_Leave(object sender, EventArgs e)
        {
            if (!txtPadrao.Text.Equals(""))
            {
                usuario.NomePadrao = txtPadrao.Text;

                try
                {
                    if (usuario.ChecaNomePadrao() == true)
                    {
                        lblPadrao.Visible = true;
                    }
                    else
                    {
                        lblPadrao.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MessageBox.Show(ex.Message);
                }              
            }
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            txtConfSenha.Clear();
            lblSenha.Visible = false;
        }

        private void TxtSenhaP_TextChanged(object sender, EventArgs e)
        {
            txtConfSenhaP.Clear();
            lblSenhaP.Visible = false;
        }


        //ações para exibir senha no formulário
        private void BtnSenha_Click(object sender, EventArgs e)
        {
            if (txtConfSenha.UseSystemPasswordChar == true)
            {
                txtConfSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfSenha.UseSystemPasswordChar = true;
            }
        }

        private void BtnSenhaP_Click(object sender, EventArgs e)
        {
            if (txtConfSenhaP.UseSystemPasswordChar == true)
            {
                txtConfSenhaP.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfSenhaP.UseSystemPasswordChar = true;
            }
        }
    }
}
