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
    public partial class FrmLogin : Form
    {
        Usuario usuario = new Usuario();

        public FrmLogin()
        {
            InitializeComponent();
        }

        //verifica usuário e senha
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            usuario.Email = txtUsuario.Text;
            usuario.Nome = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;

            string buscaNome = "SELECT codigo, nome FROM Usuario WHERE nome = @nome AND senha = @senha";
            string buscaEmail = "SELECT codigo, email FROM Usuario WHERE email = @email AND senha = @senha";

            try
            {
                if (usuario.ConfirmaLogin(buscaNome) == true || usuario.ConfirmaLogin(buscaEmail) == true)
                {



                    usuario.GetCodigo();



                    FrmPrincipal tela = new FrmPrincipal(usuario.Codigo);
                    tela.Show();

                    txtUsuario.Clear();
                    txtSenha.Clear();

                    txtUsuario.Focus();

                    Hide();
                }
                else
                {
                    lblLogin.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        //abre a tela de cadastro de usuário
        private void LblConta_Click(object sender, EventArgs e)
        {
            FrmUsuario tela = new FrmUsuario();
            tela.Show();

            Hide();
        }

        private void BtnSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        //minimiza o form
        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //fecha o from
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
