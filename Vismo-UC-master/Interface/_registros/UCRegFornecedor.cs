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

namespace Vismo
{
    public partial class UCRegFornecedor : UserControl
    {
        Fornecedor fornecedor = new Fornecedor();

        //1 = status habilitado, 2 = status desabilitado; variável usada como parâmetro em método de pesquisa
        int i = 1;

        public UCRegFornecedor()
        {
            InitializeComponent();

            btnPesquisar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnStatus.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnEditar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnRemover.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;

            try
            {
                fornecedor.usuario.Codigo = FrmPrincipal.Instance.Codigo;

                dgvFornecedor.DataSource = fornecedor.Listar(i);
                dgvFornecedor.DataMember = fornecedor.Listar(i).Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                fornecedor.Nome = txtNome.Text;

                fornecedor.Nome += "%";

                fornecedor.Nome = new string(fornecedor.Nome.Reverse().ToArray());

                fornecedor.Nome += "%";

                fornecedor.Nome = new string(fornecedor.Nome.Reverse().ToArray());

                try
                {
                    dgvFornecedor.DataSource = fornecedor.ListarNome(i);
                    dgvFornecedor.DataMember = fornecedor.ListarNome(i).Tables[0].TableName;
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
                    dgvFornecedor.DataSource = fornecedor.Listar(i);
                    dgvFornecedor.DataMember = fornecedor.Listar(i).Tables[0].TableName;
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

        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (i == 1)
            {
                fornecedor.Status = "Desabilitado";

                i = 0;
            }
            else
            {
                fornecedor.Status = "Habilitado";

                i = 1;
            }

            BtnPesquisar_Click(sender, e);
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.RowCount > 0)
            {
                if (MessageBox.Show("Alterar status de fornecedor?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fornecedor.Codigo = Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value);
                    fornecedor.Status = Convert.ToString(dgvFornecedor.CurrentRow.Cells[2].Value);


                    if (fornecedor.Status ==  "Habilitado")
                    {
                        fornecedor.Status = "Desabilitado";
                    }
                    else
                    {
                        fornecedor.Status = "Habilitado";
                    }

                    try
                    {
                        fornecedor.AlteraStatus();

                        MessageBox.Show("Registro de fornecedor alterado.", "Confirmação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmPrincipal.Instance.PanelFill.Controls.Clear();

                        UCRegFornecedor uc = new UCRegFornecedor();
                        uc.Dock = DockStyle.Fill;
                        FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

                        FrmPrincipal.Instance.PanelFill.Controls["UCRegFornecedor"].BringToFront();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.RowCount > 0)
            {
                if (MessageBox.Show("Editar registro de fornecedor?", "Confirmação",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fornecedor.Codigo = Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value);

                    UCAttFornecedor uc = new UCAttFornecedor(fornecedor.Codigo);
                    uc.Dock = DockStyle.Fill;
                    FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

                    FrmPrincipal.Instance.PanelFill.Controls["UCAttFornecedor"].BringToFront();
                }
            }
        }
    }
}
