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
    public partial class UCCadPagamento : UserControl
    {
        Pagamento pagamento = new Pagamento();

        public UCCadPagamento()
        {
            InitializeComponent();

            pagamento.fornecedor.usuario.Codigo = FrmPrincipal.Instance.Codigo;

            btnPesquisar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnSalvar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtFornec.Text.Equals(""))
            {
                pagamento.fornecedor.Nome = txtFornec.Text;

                pagamento.fornecedor.Nome += "%";

                pagamento.fornecedor.Nome = new string(pagamento.fornecedor.Nome.Reverse().ToArray());

                pagamento.fornecedor.Nome += "%";

                pagamento.fornecedor.Nome = new string(pagamento.fornecedor.Nome.Reverse().ToArray());

                try
                {
                    dgvFornecedor.DataSource = pagamento.fornecedor.ListarNome(1);
                    dgvFornecedor.DataMember = pagamento.fornecedor.ListarNome(1).Tables[0].TableName;

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
                    dgvFornecedor.DataSource = pagamento.fornecedor.Listar(1);
                    dgvFornecedor.DataMember = pagamento.fornecedor.Listar(1).Tables[0].TableName;

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

        private void TxtCod_Leave(object sender, EventArgs e)
        {
            if (!txtCod.Text.Equals(""))
            {
                pagamento.fornecedor.Codigo = Convert.ToInt32(txtCod.Text);

                try
                {
                    if (pagamento.fornecedor.ChecaCodigo() == false)
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

        private void TxtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void DgvFornecedor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFornecedor.RowCount > 0)
            {
                txtCod.Text = Convert.ToString(dgvFornecedor.CurrentRow.Cells[0].Value);
            }
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            if (!txtValor.Text.Equals(""))
            {
                if (txtValor.Text.ElementAt(0) == '$')
                {
                    txtValor.Text = txtValor.Text.Replace("$", "0");
                }

                if (txtValor.Text.ElementAt(0) == 'R' && txtValor.Text.ElementAt(1) != '$')
                {
                    txtValor.Text = txtValor.Text.Replace("R", "0");
                }

                txtValor.Text = txtValor.Text.Replace("R$", "0");

                try
                {
                    float valor = float.Parse(txtValor.Text);

                    if (valor == 0)
                    {
                        txtValor.Clear();
                    }
                    else
                    {
                        txtValor.Text = string.Format("{0:c}", valor);
                    }
                }
                catch
                {
                    txtValor.Clear();
                }
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TxtPrazo_Leave(object sender, EventArgs e)
        {
            txtPrazo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!txtPrazo.Text.Equals(""))
            {
                txtPrazo.TextMaskFormat = MaskFormat.IncludeLiterals;

                try
                {
                    DateTime data = Convert.ToDateTime(txtPrazo.Text);
                    lblPrazo.Visible = false;

                    lblPassada.Visible = false;

                    if (data < DateTime.Today)
                    {
                        lblPassada.Visible = true;
                    }
                }
                catch
                {
                    lblPassada.Visible = false;
                    lblPrazo.Visible = true;
                }
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            txtPrazo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!txtDesc.Text.Equals("") && !txtPrazo.Text.Equals("") &&
            !txtValor.Text.Equals("") && !txtCod.Text.Equals("") &&
            lblCod.Visible == false && lblPrazo.Visible == false && lblPassada.Visible == false)
            {
                pagamento.Desc = txtDesc.Text;

                txtValor.Text = txtValor.Text.Replace("R$", "0");
                pagamento.Valor = Convert.ToDouble(txtValor.Text);

                txtPrazo.TextMaskFormat = MaskFormat.IncludeLiterals;
                pagamento.Prazo = Convert.ToDateTime(txtPrazo.Text);

                pagamento.fornecedor.Codigo = Convert.ToInt32(txtCod.Text);

                try
                {
                    pagamento.Inserir();

                    txtDesc.Clear();
                    txtValor.Clear();
                    txtPrazo.Clear();
                    txtCod.Clear();
                    txtFornec.Clear();

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
