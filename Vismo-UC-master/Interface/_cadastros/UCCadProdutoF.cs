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
    public partial class UCCadProdutoF : UserControl
    {
        Produto produto = new Produto();

        public UCCadProdutoF()
        {
            InitializeComponent();

            produto.fornecedor.usuario.Codigo = FrmPrincipal.Instance.Codigo;

            btnSalvar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnPesquisar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
        }

        //lista os fornecederes cadastrados para preenchimento do campo de código de fornecedor
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtNomeFornec.Text.Equals(""))
            {
                produto.fornecedor.Nome = txtNomeFornec.Text;

                produto.fornecedor.Nome += "%";

                produto.fornecedor.Nome = new string(produto.fornecedor.Nome.Reverse().ToArray());

                produto.fornecedor.Nome += "%";

                produto.fornecedor.Nome = new string(produto.fornecedor.Nome.Reverse().ToArray());

                try
                {
                    dgvFornecedor.DataSource = produto.fornecedor.ListarNome(1);
                    dgvFornecedor.DataMember = produto.fornecedor.ListarNome(1).Tables[0].TableName;

                    dgvFornecedor.Columns["status"].Visible = false;
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
                try
                {
                    dgvFornecedor.DataSource = produto.fornecedor.Listar(1);
                    dgvFornecedor.DataMember = produto.fornecedor.Listar(1).Tables[0].TableName;

                    dgvFornecedor.Columns["status"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); 

                    MessageBox.Show(ex.Message);
                }
            }

            if (dgvFornecedor.RowCount > 0)
            {
                lblRegistro.Visible = false;
            }
            else
            {
                lblRegistro.Visible = true;
            }
        }

        //preenche o campo de código de fornecedor
        private void DgvFornecedor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFornecedor.RowCount > 0)
            {
                txtFornecedor.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[0].Value);
            }
        }


        //checa se o nome de produto já existe
        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                produto.Nome = txtNome.Text;

                try
                {
                    if (produto.ChecaNome(1) == true)
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
        //formata a caixa de texto de preço
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

        //checa se código de fornecedor informado é válido
        private void TxtFornecedor_Leave(object sender, EventArgs e)
        {
            if (!txtFornecedor.Text.Equals(""))
            {
                produto.fornecedor.Codigo = Convert.ToInt32(txtFornecedor.Text);

                try
                {
                    if (produto.fornecedor.ChecaCodigo() == false)
                    {
                        lblCod.Visible = true;
                    }
                    else
                    {
                        lblCod.Visible = false;
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


        //permite apenas inserção de valores numéricos e vírgula na caixa de texto de preço
        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        //permite apenas inserção de valores numéricos no campo de quantidade
        private void TxtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //permite apenas inserção de valores numéricos no campo de código de fornecedor
        private void TxtFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

     
        //cadastra o produto
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals("") && !txtPreco.Text.Equals("") &&
                !txtQtd.Text.Equals("") && !txtFornecedor.Text.Equals("") &&
                lblNome.Visible == false && lblCod.Visible == false)
            {
                produto.Nome = txtNome.Text;

                txtPreco.Text = txtPreco.Text.Replace("R$", "0");
                produto.Preco = Convert.ToDouble(txtPreco.Text);

                produto.Qtd = Convert.ToInt32(txtQtd.Text);

                try
                {
                    produto.Inserir(1);

                    txtNome.Clear();
                    txtPreco.Clear();
                    txtQtd.Clear();
                    txtFornecedor.Clear();
                    txtNomeFornec.Clear();

                    dgvFornecedor.DataSource = null;

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
    }
}
