using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vismo._cadastros;

namespace Vismo
{
    public partial class UCCadastro : UserControl
    {
        public UCCadastro()
        {
            InitializeComponent();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnProdutoF_Click(object sender, EventArgs e)
        {
            UCCadProdutoF uc = new UCCadProdutoF();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadProdutoF"].BringToFront();
        }

        private void BtnProdutoL_Click(object sender, EventArgs e)
        {
            UCCadProdutoL uc = new UCCadProdutoL();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadProdutoL"].BringToFront();
        }

        private void BtnProdutoE_Click(object sender, EventArgs e)
        {
            UCCadProdutoE uc = new UCCadProdutoE();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadProdutoE"].BringToFront();
        }

        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            UCCadPagamento uc = new UCCadPagamento();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadPagamento"].BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCCadFornecedor uc = new UCCadFornecedor();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadFornecedor"].BringToFront();
        }

        private void picProdutoSEstoque_Click(object sender, EventArgs e)
        {
            UCCadProdutoE uc = new UCCadProdutoE();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadProdutoE"].BringToFront();
        }

        private void picProdutoLocal_Click(object sender, EventArgs e)
        {
            UCCadProdutoL uc = new UCCadProdutoL();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadProdutoL"].BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UCCadProdutoF uc = new UCCadProdutoF();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadProdutoF"].BringToFront();
        }

        private void picPagamento_Click(object sender, EventArgs e)
        {
            UCCadPagamento uc = new UCCadPagamento();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCCadPagamento"].BringToFront();
        }

        private void picPagamento_MouseLeave(object sender, EventArgs e)
        {
           
            picPagamento.BackColor = Color.Transparent;
        }

        private void picPagamento_MouseMove(object sender, MouseEventArgs e)
        {
         
            picPagamento.BackColor = Color.Black;
        }

        private void picProdutoSEstoque_MouseLeave(object sender, EventArgs e)
        {
            picProdutoSEstoque.BackColor = Color.Transparent;
        }

        private void picProdutoSEstoque_MouseMove(object sender, MouseEventArgs e)
        {
            picProdutoSEstoque.BackColor = Color.Black;
        }

        private void picProdutoLocal_MouseLeave(object sender, EventArgs e)
        {
            picProdutoLocal.BackColor = Color.Transparent;
        }

        private void picProdutoLocal_MouseMove(object sender, MouseEventArgs e)
        {
            picProdutoLocal.BackColor = Color.Black;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.Black;
        }

        private void picFornecedor_MouseLeave(object sender, EventArgs e)
        {
            picFornecedor.BackColor = Color.Transparent;
        }

        private void picFornecedor_MouseMove(object sender, MouseEventArgs e)
        {
            picFornecedor.BackColor = Color.Black;
        }

        private void UCCadastro_Load(object sender, EventArgs e)
        {
    
        }
    }
}
