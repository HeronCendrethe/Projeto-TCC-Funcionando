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
using Vismo._venda;

namespace Vismo._registros
{
    public partial class UCRegVenda : UserControl
    {
        Venda venda = new Venda();

        public UCRegVenda()
        {
            InitializeComponent();

            venda.usuario.Codigo = FrmPrincipal.Instance.Codigo;

            btnPesquisar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnDetalhe.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnVenda.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;

            txtData.Text = Convert.ToString(DateTime.Today);

            try
            {
                dgvVenda.DataSource = venda.Listar();
                dgvVenda.DataMember = venda.Listar().Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        private void ExibeDetalhe()
        {
            venda.Codigo = Convert.ToInt32(dgvVenda.CurrentRow.Cells[0].Value);

            dgvDetalhe.Visible = true;
            dgvVenda.Visible = false;

            btnDetalhe.Text = "Voltar";

            try
            {
                dgvDetalhe.DataSource = venda.DetalheVenda();
                dgvDetalhe.DataMember = venda.DetalheVenda().Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        private void TxtData_Leave(object sender, EventArgs e)
        {
            txtData.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!txtData.Text.Equals(""))
            {
                txtData.TextMaskFormat = MaskFormat.IncludeLiterals;

                try
                {
                    DateTime data = Convert.ToDateTime(txtData.Text);
                    lblData.Visible = false;
                }
                catch
                {
                    lblData.Visible = true;
                }
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            txtData.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtCod.Text.Equals("") && !txtData.Text.Equals("") && lblData.Visible == false)
            {
                txtData.TextMaskFormat = MaskFormat.IncludeLiterals;
                venda.Data = Convert.ToDateTime(txtData.Text);

                string data1 = Convert.ToString(venda.Data);
                string data2 = Convert.ToString(venda.Data.AddDays(1));

                try
                {
                    dgvVenda.DataSource = venda.ListarData(data1, data2);
                    dgvVenda.DataMember = venda.ListarData(data1, data2).Tables[0].TableName;
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
                venda.Codigo = Convert.ToInt32(txtCod.Text);

                try
                {
                    dgvVenda.DataSource = venda.ListarCodigo();
                    dgvVenda.DataMember = venda.ListarCodigo().Tables[0].TableName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DgvVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibeDetalhe();
        }

        private void BtnDetalhe_Click(object sender, EventArgs e)
        {
            if (btnDetalhe.Text == "Voltar")
            {
                try
                {
                    dgvVenda.DataSource = venda.Listar();
                    dgvVenda.DataMember = venda.Listar().Tables[0].TableName;

                    dgvDetalhe.Visible = false;
                    dgvVenda.Visible = true;

                    btnDetalhe.Text = "Exibir Detalhes";
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
                ExibeDetalhe();
            }
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            UCNovaVenda uc = new UCNovaVenda();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCNovaVenda"].BringToFront();
        }
    }
}
