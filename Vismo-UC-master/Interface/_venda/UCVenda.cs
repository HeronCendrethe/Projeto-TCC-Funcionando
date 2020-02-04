using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vismo._venda
{
    public partial class UCVenda : UserControl
    {
        public UCVenda()
        {
            InitializeComponent();
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
