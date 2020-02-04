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
using Vismo._registros;

namespace Vismo._alteracoes
{
    public partial class UCAttProdutoL : UserControl
    {
        Produto produto = new Produto();

        string nome;

        private void FormataPreco()
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

        public UCAttProdutoL(int codigo)
        {
            InitializeComponent();

            produto.usuario.Codigo = FrmPrincipal.Instance.Codigo;

            btnSalvar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;

            produto.Codigo = codigo;

            try
            {
                produto.GetRegistro(2);

                txtNome.Text = produto.Nome;
                txtPreco.Text = Convert.ToString(produto.Preco);
                txtQtd.Text = Convert.ToString(produto.Qtd);

                FormataPreco();

                nome = produto.Nome;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);

                FrmPrincipal.Instance.PanelFill.Controls.Clear();

                UCRegProduto uc = new UCRegProduto();
                uc.Dock = DockStyle.Fill;
                FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

                FrmPrincipal.Instance.PanelFill.Controls["UCRegProduto"].BringToFront();
            }
        }

        private void TxtPreco_Leave(object sender, EventArgs e)
        {
            FormataPreco();
        }

        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TxtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                produto.Nome = txtNome.Text;

                try
                {
                    if (produto.ChecaNome(1) == true)
                    {
                        if (produto.Nome != nome)
                        {
                            lblNome.Visible = true;
                        }
                        else
                        {
                            lblNome.Visible = false;
                        }
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals("") && !txtPreco.Text.Equals("") &&
                !txtQtd.Text.Equals("") && lblNome.Visible == false)
            {
                produto.Nome = txtNome.Text;

                txtPreco.Text = txtPreco.Text.Replace("R$", "0");
                produto.Preco = Convert.ToDouble(txtPreco.Text);

                produto.Qtd = Convert.ToInt32(txtQtd.Text);

                try
                {
                    produto.Atualizar(2);

                    FrmPrincipal.Instance.PanelFill.Controls.Clear();

                    MessageBox.Show("Registro alterado com sucesso.", "Confirmação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UCRegProduto uc = new UCRegProduto();
                    uc.Dock = DockStyle.Fill;
                    FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

                    FrmPrincipal.Instance.PanelFill.Controls["UCRegProduto"].BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar se conectar com o Banco de Dados", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
