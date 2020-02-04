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

namespace Vismo._venda
{
    public partial class UCNovaVenda : UserControl
    {
        Produto produto = new Produto();

        int row = 0;

        public UCNovaVenda()
        {
            InitializeComponent();

            produto.usuario.Codigo = FrmPrincipal.Instance.Codigo;

            btnPesquisar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnAdicionar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnConfirmar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnRelatorio.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
        }

        private void Adiciona()
        {
            if (dgvLista.RowCount == 0)
            {
                dgvLista.RowCount += 1;

                for (int j = 0; j <= 1; j++)
                {
                    dgvLista.Rows[row].Cells[j].Value = dgvPesquisa.CurrentRow.Cells[j].Value;
                }

                dgvLista.Rows[row].Cells[2].Value = Convert.ToInt32(txtQtd.Text);
                dgvLista.Rows[row].Cells[3].Value = dgvPesquisa.CurrentRow.Cells[3].Value;

                row += 1;

                lblTotal.Text = Convert.ToString(dgvPesquisa.CurrentRow.Cells[1].Value);
                float valor = float.Parse(lblTotal.Text);
                valor *= Convert.ToInt32(txtQtd.Text);

                lblTotal.Text = string.Format("{0:c}", valor);
            }
            else
            {
                int aux = 0;

                for (int i = 1; i <= dgvLista.RowCount; i++)
                {
                    if (Convert.ToString(dgvPesquisa.CurrentRow.Cells[0].Value) ==
                    Convert.ToString(dgvLista.Rows[i - 1].Cells[0].Value))
                    {
                        int x = Convert.ToInt32(dgvLista.Rows[i - 1].Cells[2].Value);
                        x += Convert.ToInt32(txtQtd.Text);
                        dgvLista.Rows[i - 1].Cells[2].Value = x;

                        aux = 1;
                    }
                }

                if (aux == 0)
                {
                    dgvLista.RowCount += 1;

                    for (int j = 0; j <= 1; j++)
                    {
                        dgvLista.Rows[row].Cells[j].Value = dgvPesquisa.CurrentRow.Cells[j].Value;
                    }

                    dgvLista.Rows[row].Cells[2].Value = Convert.ToInt32(txtQtd.Text);
                    dgvLista.Rows[row].Cells[3].Value = dgvPesquisa.CurrentRow.Cells[3].Value;

                    row += 1;
                }

                string valor = Convert.ToString(dgvPesquisa.CurrentRow.Cells[1].Value);

                lblTotal.Text = lblTotal.Text.Replace("R$", "0");

                float z = float.Parse(valor) * Convert.ToInt32(txtQtd.Text);

                float y = z + float.Parse(lblTotal.Text);

                lblTotal.Text = string.Format("{0:c}", y);
            }

            txtQtd.Text = "1";
        }

        private void EditaDgvPesquisa(int tipo)
        {
            if (dgvPesquisa.RowCount > 0 && (tipo == 6 || tipo == 9))
            {
                dgvPesquisa.Columns["QtdEstoque"].DataPropertyName = null;

                for (int i = 0; i < dgvPesquisa.RowCount; i++)
                {
                    dgvPesquisa.Rows[i].Cells[2].Value = "-";
                }
            }
            else if (dgvPesquisa.RowCount > 0)
            {
                for (int i = 0; i < dgvPesquisa.RowCount; i++)
                {
                    for (int j = 0; j < dgvLista.RowCount; j++)
                    {
                        if (Convert.ToString(dgvPesquisa.Rows[i].Cells[0].Value) ==
                        Convert.ToString(dgvLista.Rows[j].Cells[0].Value))
                        {
                            int qtd = Convert.ToInt32(dgvPesquisa.Rows[i].Cells[2].Value);
                            qtd -= Convert.ToInt32(dgvLista.Rows[j].Cells[2].Value);
                            dgvPesquisa.Rows[i].Cells[2].Value = qtd;
                        }
                    }
                }
            }
        }


        private void RadioNome_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNome.Checked)
            {
                lblNome.Visible = true;
                txtNome.Visible = true;

                lblCod.Visible = false;
                txtCod.Visible = false;
                txtCod.Clear();
            }
            else
            {
                lblNome.Visible = false;
                txtNome.Visible = false;
                txtNome.Clear();

                lblCod.Visible = true;
                txtCod.Visible = true;
            }
        }

        private void ChkFornecido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFornecido.Checked)
            {
                chkLocal.Checked = false; chkLocal.Enabled = true;
                chkEstoque.Checked = false; chkEstoque.Enabled = true;

                chkFornecido.Enabled = false;
            }
        }

        private void ChkLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLocal.Checked)
            {
                chkFornecido.Checked = false; chkFornecido.Enabled = true;
                chkEstoque.Checked = false; chkEstoque.Enabled = true;

                chkLocal.Enabled = false;
            }
        }

        private void ChkEstoque_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEstoque.Checked)
            {
                chkFornecido.Checked = false; chkFornecido.Enabled = true;
                chkLocal.Checked = false; chkLocal.Enabled = true;

                chkEstoque.Enabled = false;
            }
        }


        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            //dgvPesquisa.DataSource = null;

            int tipo;

            if (chkFornecido.Checked)
            {
                tipo = 5;
            }
            else if (chkLocal.Checked)
            {
                tipo = 4;
            }
            else
            {
                tipo = 6;
            }

            if (!txtNome.Text.Equals(""))
            {
                produto.Nome = txtNome.Text;
                produto.Nome += "%";
                produto.Nome = new string(produto.Nome.Reverse().ToArray());
                produto.Nome += "%";
                produto.Nome = new string(produto.Nome.Reverse().ToArray());

                try
                {
                    dgvPesquisa.AutoGenerateColumns = false;
                    dgvPesquisa.Columns["QtdEstoque"].DataPropertyName = "qtd";

                    dgvPesquisa.DataSource = produto.ListarNome(tipo, 0);
                    dgvPesquisa.DataMember = produto.ListarNome(tipo, 0).Tables[0].TableName;

                    EditaDgvPesquisa(tipo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MessageBox.Show(ex.Message);
                }
            }
            else if (!txtCod.Text.Equals(""))
            {
                if (tipo == 5)
                {
                    tipo = 7;
                }
                else if (tipo == 6)
                {
                    tipo = 8;
                }
                else
                {
                    tipo = 9;
                }

                produto.Codigo = Convert.ToInt32(txtCod.Text);

                try
                {
                    dgvPesquisa.AutoGenerateColumns = false;
                    dgvPesquisa.Columns["QtdEstoque"].DataPropertyName = "qtd";

                    dgvPesquisa.DataSource = produto.ListarNome(tipo, 0);
                    dgvPesquisa.DataMember = produto.ListarNome(tipo, 0).Tables[0].TableName;

                    EditaDgvPesquisa(tipo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= dgvPesquisa.RowCount; i++)
            {
                if (Convert.ToString(dgvPesquisa.Rows[i-1].Cells[2].Value) == "-")
                {
                    dgvPesquisa.Rows[i - 1].Cells[2].Value = "1.5";
                }
            }

            if (Convert.ToDouble(dgvPesquisa.CurrentRow.Cells[2].Value) > 0 &&
            Convert.ToDouble(dgvPesquisa.CurrentRow.Cells[2].Value) >= Convert.ToInt32(txtQtd.Text) &&
            Convert.ToString(dgvPesquisa.CurrentRow.Cells[2].Value) != "1.5")
            {
                Adiciona();

                int x = Convert.ToInt32(dgvPesquisa.CurrentRow.Cells[2].Value);
                x -= Convert.ToInt32(txtQtd.Text);
                dgvPesquisa.CurrentRow.Cells[2].Value = x;
            }
            else if (Convert.ToString(dgvPesquisa.CurrentRow.Cells[2].Value) == "1.5")
            {
                Adiciona();

                dgvPesquisa.CurrentRow.Cells[2].Value = "-";
            }
            else
            {
                MessageBox.Show("Produto em falta no estoque, não é possível adicioná-lo na lista", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TxtValor_Leave(sender, e);
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

                        lblTroco.Text = "-";

                        lblValor.Visible = false;
                    }
                    else
                    {
                        lblTotal.Text = lblTotal.Text.Replace("R$", "0");

                        float aux = float.Parse(lblTotal.Text);

                        float valor2 = float.Parse(txtValor.Text) - float.Parse(lblTotal.Text);

                        if (float.Parse(txtValor.Text) >= float.Parse(lblTotal.Text))
                        {
                            txtValor.Text = string.Format("{0:c}", valor);
                            lblTroco.Text = string.Format("{0:c}", valor2);

                            lblValor.Visible = false;
                        }
                        else
                        {
                            lblValor.Visible = true;

                            lblTroco.Text = "-";
                        }

                        lblTotal.Text = string.Format("{0:c}", aux);
                        txtValor.Text = string.Format("{0:c}", valor);
                    }
                }
                catch
                {
                    txtValor.Clear();

                    lblTroco.Text = "-";

                    lblValor.Visible = false;
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

        private void TxtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxtQtd_Leave(object sender, EventArgs e)
        {
            if (txtQtd.Text.Equals("") || Convert.ToInt32(txtQtd.Text) == 0)
            {
                txtQtd.Text = "1";
            }
        }

        private void DgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Remover produto da lista?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string valor = Convert.ToString(dgvLista.CurrentRow.Cells[1].Value);
                valor.Replace("R$", "0");
                float x = float.Parse(valor);

                int qtd = Convert.ToInt32(dgvLista.CurrentRow.Cells[2].Value);
                x *= qtd;

                valor = lblTotal.Text;
                valor = valor.Replace("R$", "0");

                float y = float.Parse(valor);

                y -= x;
                lblTotal.Text = string.Format("{0:c}", y);

                dgvLista.Rows.RemoveAt(e.RowIndex);
                row --;
            }
        }

        private void LblTotal_TextChanged(object sender, EventArgs e)
        {
            if (lblTotal.Text != "R$0,00")
            {
                txtValor.Enabled = true;
            }
            else
            {
                txtValor.Enabled = false;
                txtValor.Clear();
                lblTroco.Text = "-";
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (lblValor.Visible == false && lblTroco.Text != "-")
            {
                Venda venda = new Venda();

                venda.usuario.Codigo = produto.usuario.Codigo;

                venda.Data = DateTime.Now;

                string valor = lblTotal.Text;
                valor = valor.Replace("R$", "0");
                venda.Valor = Convert.ToDouble(valor);

                try
                {
                    venda.Inserir();
                    venda.PegaCodigo();

                    for (int i = 0; i < dgvLista.RowCount; i++)
                    {
                        venda.Item = Convert.ToInt32(dgvLista.Rows[i].Cells[3].Value);
                        venda.Qtd = Convert.ToInt32(dgvLista.Rows[i].Cells[2].Value);

                        venda.InserirItem();
                    }

                    MessageBox.Show("Venda realizada com sucesso", "Confirmação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmPrincipal.Instance.PanelFill.Controls.Clear();

                    UCNovaVenda uc = new UCNovaVenda();
                    uc.Dock = DockStyle.Fill;
                    FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

                    FrmPrincipal.Instance.PanelFill.Controls["UCNovaVenda"].BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar realizar venda.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            UCRegVenda uc = new UCRegVenda();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCRegVenda"].BringToFront();
            uc.btnVenda.Visible = true;
        }
    }
}
