using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vismo._registros;

namespace Vismo
{
    public partial class UCRegistro : UserControl
    {
        public UCRegistro()
        {
            InitializeComponent();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            UCRegFornecedor uc = new UCRegFornecedor();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCRegFornecedor"].BringToFront();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            UCRegProduto uc = new UCRegProduto();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCRegProduto"].BringToFront();
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            UCRegVenda uc = new UCRegVenda();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCRegVenda"].BringToFront();
        }

        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            UCRegPagamento uc = new UCRegPagamento();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCRegPagamento"].BringToFront();
        }
    }
}
