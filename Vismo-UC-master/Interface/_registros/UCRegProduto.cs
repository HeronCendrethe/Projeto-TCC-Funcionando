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
using Vismo._alteracoes;

namespace Vismo._registros
{
    public partial class UCRegProduto : UserControl
    {
        Produto produto = new Produto();

        //1 = pesquisa por produto fornecido, 2 = pesquisa por produto local, 3 = pesquisa por produto sem estoque
        int i = 1;

        //1 = status habilitado, 2 = status desabilitado; variável usada como parâmetro em método de pesquisa
        int j = 1;

        private void Listar()
        {
            try
            {
                dgvProduto.DataSource = produto.Listar(i, j);
                dgvProduto.DataMember = produto.Listar(i, j).Tables[0].TableName;

                switch (i)
                {
                    case 1:
                        dgvProduto.Columns["codigoUsuario"].Visible = false;
                        dgvProduto.Columns["codigoFornecedor"].Visible = false;

                        dgvProduto.Columns["Qtd"].Visible = true;

                        dgvProduto.Columns["Codigo"].Width = 50;
                        dgvProduto.Columns["Status"].Width = 100;
                        break;

                    case 2:
                        dgvProduto.Columns["Qtd"].Visible = true;

                        dgvProduto.Columns["Codigo"].Width = 50;
                        dgvProduto.Columns["Status"].Width = 100;
                        break;

                    case 3:
                        dgvProduto.Columns["Qtd"].Visible = false;

                        dgvProduto.Columns["Codigo"].Width = 100;
                        dgvProduto.Columns["Status"].Width = 150;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        public UCRegProduto()
        {
            InitializeComponent();

            produto.usuario.Codigo = FrmPrincipal.Instance.Codigo;

            btnPesquisar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnStatus.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnEditar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnRemover.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;

            Listar();
        }


        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                produto.Nome = txtNome.Text;

                produto.Nome += "%";

                produto.Nome = new string(produto.Nome.Reverse().ToArray());

                produto.Nome += "%";

                produto.Nome = new string(produto.Nome.Reverse().ToArray());

                try
                {
                    dgvProduto.DataSource = produto.ListarNome(i, j);
                    dgvProduto.DataMember = produto.ListarNome(i, j).Tables[0].TableName;
                   
                    switch (i)
                    {
                        case 1:
                            dgvProduto.Columns["codigoUsuario"].Visible = false;
                            dgvProduto.Columns["codigoFornecedor"].Visible = false;

                            dgvProduto.Columns["Qtd"].Visible = true;

                            dgvProduto.Columns["Codigo"].Width = 50;
                            dgvProduto.Columns["Status"].Width = 100;
                            break;

                        case 2:
                            dgvProduto.Columns["Qtd"].Visible = true;

                            dgvProduto.Columns["Codigo"].Width = 50;
                            dgvProduto.Columns["Status"].Width = 100;
                            break;

                        case 3:
                            dgvProduto.Columns["Qtd"].Visible = false;

                            dgvProduto.Columns["Codigo"].Width = 100;
                            dgvProduto.Columns["Status"].Width = 150;
                            break;
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
                Listar();
            }

            if (dgvProduto.RowCount > 0)
            {
                lblRegistro.Visible = false;
            }
            else
            {
                lblRegistro.Visible = true;
            }
        }

        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (j == 1)
            {
                produto.Status = "Desabilitado";

                j = 0;
            }
            else
            {
                produto.Status = "Habilitado";

                j = 1; 
            }

            BtnPesquisar_Click(sender, e);
        }

        private void RadioFor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFor.Checked)
            {
                i = 1;

                BtnPesquisar_Click(sender, e);
            }
        }

        private void RadioLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLocal.Checked)
            {
                i = 2;

                BtnPesquisar_Click(sender, e);
            } 
        }

        private void RadioEstoque_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEstoque.Checked)
            {
                i = 3;

                BtnPesquisar_Click(sender, e);
            }   
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            if (dgvProduto.RowCount > 0)
            {
                if (MessageBox.Show("Alterar status de produto?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    produto.Codigo = Convert.ToInt32(dgvProduto.CurrentRow.Cells[0].Value);
                    produto.Status = Convert.ToString(dgvProduto.CurrentRow.Cells[4].Value);

                    if (produto.Status == "Habilitado")
                    {
                        produto.Status = "Desabilitado";
                    }
                    else
                    {
                        produto.Status = "Habilitado";
                    }

                    try
                    {
                        produto.AlteraStatus();

                        MessageBox.Show("Registro de produto alterado.", "Confirmação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmPrincipal.Instance.PanelFill.Controls.Clear();

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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProduto.RowCount > 0)
            {
                if (MessageBox.Show("Editar registro de produto?", "Confirmação",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    produto.Codigo = Convert.ToInt32(dgvProduto.CurrentRow.Cells[0].Value);

                    if (radioFor.Checked)
                    {
                        UCAttProdutoF uc = new UCAttProdutoF(produto.Codigo);
                        uc.Dock = DockStyle.Fill;
                        FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

                        FrmPrincipal.Instance.PanelFill.Controls["UCAttProdutoF"].BringToFront();
                    }        
                    else if (radioLocal.Checked)
                    {
                        UCAttProdutoL uc = new UCAttProdutoL(produto.Codigo);
                        uc.Dock = DockStyle.Fill;
                        FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

                        FrmPrincipal.Instance.PanelFill.Controls["UCAttProdutoL"].BringToFront();
                    }
                    else
                    {
                        UCAttProdutoE uc = new UCAttProdutoE(produto.Codigo);
                        uc.Dock = DockStyle.Fill;
                        FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

                        FrmPrincipal.Instance.PanelFill.Controls["UCAttProdutoE"].BringToFront();
                    }
                }
            }
        }
    }
}
