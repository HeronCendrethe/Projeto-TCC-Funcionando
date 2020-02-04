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

namespace Vismo
{
    public partial class UCCadFornecedor : UserControl
    {
        Fornecedor fornecedor = new Fornecedor();

        public UCCadFornecedor()
        {
            InitializeComponent();

            btnSalvar.BackColor = FrmPrincipal.Instance.PanelLeft.BackColor;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals("") && lblNome.Visible == false)
            {
                fornecedor.Nome = txtNome.Text;
                fornecedor.usuario.Codigo = FrmPrincipal.Instance.Codigo;

                try
                {
                    fornecedor.Inserir();

                    MessageBox.Show("Cadastro realizado com sucesso.", "Confirmação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNome.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar se conectar com o Banco de Dados", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                fornecedor.Nome = txtNome.Text;
                fornecedor.usuario.Codigo = FrmPrincipal.Instance.Codigo;

                try
                {
                    if (fornecedor.ChecaNome() == true)
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
