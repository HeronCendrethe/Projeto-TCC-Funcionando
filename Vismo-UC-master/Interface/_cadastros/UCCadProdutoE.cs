using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;

namespace Vismo._cadastros
{
    public partial class UCCadProdutoE : UserControl
    {
        Produto produto = new Produto();

        public UCCadProdutoE()
        {
            InitializeComponent();

            produto.usuario.Codigo = FrmPrincipal.Instance.Codigo;

            btnSalvar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals("") && !txtPreco.Text.Equals("") && lblNome.Visible == false)
            {
                produto.Nome = txtNome.Text;

                txtPreco.Text = txtPreco.Text.Replace("R$", "0");
                produto.Preco = Convert.ToDouble(txtPreco.Text);

                try
                {
                    produto.Inserir(3);

                    txtNome.Clear();
                    txtPreco.Clear();

                    MessageBox.Show("Cadastro realizado com sucesso.", "Confirmação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar se conectar com o Banco de Dados", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TxtPreco_Leave(object sender, EventArgs e)
        {
            if (!txtPreco.Text.Equals(""))
            {
                if (txtPreco.Text.ElementAt(0) == '$')
                {
                    txtPreco.Text = txtPreco.Text.Replace("$", "0");
                }

                if (txtPreco.Text.ElementAt(0) == 'R' && txtPreco.Text.ElementAt(1) != '$')
                {
                    txtPreco.Text = txtPreco.Text.Replace("R", "0");
                }

                txtPreco.Text = txtPreco.Text.Replace("R$", "0");

                try
                {
                    float valor = float.Parse(txtPreco.Text);

                    if (valor == 0)
                    {
                        txtPreco.Clear();
                    }
                    else
                    {
                        txtPreco.Text = string.Format("{0:c}", valor);
                    }
                }
                catch
                {
                    txtPreco.Clear();
                }
            }
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                produto.Nome = txtNome.Text;

                try
                {
                    if (produto.ChecaNome(3) == true)
                    {
                        lblNome.Visible = true;
                    }
                    else
                    {
                        lblNome.Visible = false;
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
    }
}
