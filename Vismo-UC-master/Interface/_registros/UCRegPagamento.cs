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

namespace Vismo._registros
{
    public partial class UCRegPagamento : UserControl
    {
        Pagamento pagamento = new Pagamento();

        int i = 1;

        public UCRegPagamento()
        {
            InitializeComponent();

            pagamento.fornecedor.usuario.Codigo = FrmPrincipal.Instance.Codigo;

            btnPesquisar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnFinalizar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnEditar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnRemover.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
            btnDesc.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;

            try
            {
                dgvPagamento.AutoGenerateColumns = false;

                dgvPagamento.DataSource = pagamento.Listar(i);
                dgvPagamento.DataMember = pagamento.Listar(i).Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        private void RadioPendente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPendente.Checked)
            {
                i = 1;

                if (!txtNome.Text.Equals(""))
                {
                    i = 4;

                    pagamento.fornecedor.Nome = txtNome.Text;
                }

                txtPrazo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (!txtPrazo.Text.Equals(""))
                {
                    txtPrazo.TextMaskFormat = MaskFormat.IncludeLiterals;

                    i = 7;
                }

                try
                {
                    dgvPagamento.DataSource = pagamento.Listar(i);
                    dgvPagamento.DataMember = pagamento.Listar(i).Tables[0].TableName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RadioRealizado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRealizado.Checked)
            {
                i = 2;

                if (!txtNome.Text.Equals(""))
                {
                    i = 5;

                    pagamento.fornecedor.Nome = txtNome.Text;
                }

                try
                {
                    dgvPagamento.DataSource = pagamento.Listar(i);
                    dgvPagamento.DataMember = pagamento.Listar(i).Tables[0].TableName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RadioAtrasado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRealizado.Checked)
            {
                i = 3;

                if (!txtNome.Text.Equals(""))
                {
                    i = 6;

                    pagamento.fornecedor.Nome = txtNome.Text;
                }

                try
                {
                    dgvPagamento.DataSource = pagamento.Listar(i);
                    dgvPagamento.DataMember = pagamento.Listar(i).Tables[0].TableName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            //txtPrazo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            //if (!txtPrazo.Text.Equals("") && lblData.Visible == false)
            //{
            //    txtPrazo.TextMaskFormat = MaskFormat.IncludeLiterals;

            //    switch (i)
            //    {
            //        case 1:
            //            i = 7;
            //            break;

            //        case 2:
            //            i = 8;
            //            break;

            //        case 3:
            //            i = 9;
            //            break;
            //    }
            //}

            if (!txtNome.Text.Equals("") && i < 4)
            {
               switch (i)
               {
                    case 1:
                        i = 4;
                        break;

                    case 2:
                        i = 5;
                        break;

                    case 3:
                        i = 6;
                        break;
               }
            }

            try
            {
                dgvPagamento.DataSource = pagamento.Listar(i);
                dgvPagamento.DataMember = pagamento.Listar(i).Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foi encontrado um problema ao tentar se conectar com o Banco de Dados.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
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
                    lblData.Visible = false;
                }
                catch
                {
                    lblData.Visible = true;
                }
            }
        }

        private void BtnDesc_Click(object sender, EventArgs e)
        {
            if (dgvPagamento.RowCount > 0)
            {
                dgvDescricao.RowCount += 1;

                string desc = Convert.ToString(dgvPagamento.CurrentRow.Cells[3].Value);

                dgvDescricao.Visible = true;
                dgvPagamento.Visible = false;

                dgvDescricao.Rows[0].Cells[0].Value = desc;  
            }
        }
    }
}
