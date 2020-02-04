using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Controle;
using Vismo._venda;

namespace Vismo
{
    public partial class FrmPrincipal : Form
    {
        Usuario usuario;

        static FrmPrincipal obj;
       
        public FrmPrincipal(int codigo)
        {
            InitializeComponent();

            timer2.Start();
         


            usuario = new Usuario();
            usuario.Codigo = codigo;
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnTema, "Alternar entre o modo noturno e claro.");
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            obj = this;

            UCPrincipal uc = new UCPrincipal();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            Tema tema = new Tema();

            tema.usuario.Codigo = usuario.Codigo;

            try
            {
                tema.GetCor();

                panelLeft.BackColor = Color.FromArgb(Convert.ToInt32(tema.R), Convert.ToInt32(tema.G), Convert.ToInt32(tema.B));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar carregar tema de usuário.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }

            
      
        }

        public static FrmPrincipal Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new FrmPrincipal(0);
                }

                return obj;
            }
        }

        public int Codigo
        {
            get
            {
                return usuario.Codigo;
            }
        }

        public Panel PanelFill
        {
            get
            {
                return panelFill; 
            }
            set
            {
                panelFill = value;
            }
        }

        public Panel PanelLeft
        {
            get
            {
                return panelLeft;
            }
            set
            {
                panelLeft = value;
            }
        }


        //painel do topo do Form principal

        //variáveis usadas nas ações do panel do topo 
        bool mouseClicked;
        Point clickedAt;

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseClicked = true;
                clickedAt = e.Location;
            }
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked == true)
            {
                Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }


        //painel esquerdo do Form principal

        //ação do botão de cadastro
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            panelFill.Controls.Clear();

            UCCadastro uc = new UCCadastro();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCCadastro"].BringToFront();

            btnCadastro.BackColor = Color.Gray;

            btnRegistro.BackColor = Color.Transparent;
            btnVenda.BackColor = Color.Transparent;
            btnEstoque.BackColor = Color.Transparent;

            btnTema.Visible = false;
        }

        //ação do botão de registro
        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            panelFill.Controls.Clear();

            UCRegistro uc = new UCRegistro();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCRegistro"].BringToFront();

            btnRegistro.BackColor = Color.Gray;

            btnCadastro.BackColor = Color.Transparent;
            btnVenda.BackColor = Color.Transparent;
            btnEstoque.BackColor = Color.Transparent;

            btnTema.Visible = false;
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            panelFill.Controls.Clear();

            UCVenda uc = new UCVenda();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCVenda"].BringToFront();

            btnVenda.BackColor = Color.Gray;

            btnCadastro.BackColor = Color.Transparent;
            btnRegistro.BackColor = Color.Transparent;
            btnEstoque.BackColor = Color.Transparent;

            btnTema.Visible = false;
        }


        //cabeçalho do Form principal

        //botão "Home"
        private void BtnHome_Click(object sender, EventArgs e)
        {
            panelFill.Controls.Clear();

            UCPrincipal uc = new UCPrincipal();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCPrincipal"].BringToFront();

            btnCadastro.BackColor = Color.Transparent;
            btnRegistro.BackColor = Color.Transparent;
            btnVenda.BackColor = Color.Transparent;
            btnEstoque.BackColor = Color.Transparent;

            btnTema.Visible = true;
        }

        private void BtnTema_Click(object sender, EventArgs e)
        {
            timer1.Start();
            logo1.Visible = false;
         


            if (panelFill.BackColor == Color.WhiteSmoke)
            {

                btnFechar.ForeColor = Color.Gray;
                btnMin.ForeColor = Color.Gray;
                lblAjuda.ForeColor = Color.Gray;
                 lblConf.ForeColor = Color.Gray;
                 lblSair.ForeColor = Color.Gray;
                lblSobre.ForeColor = Color.Gray;
             
                btnTema.ForeColor = Color.Black;
                panelFill.BackColor = Color.DimGray;
                panelLeft.BackColor = Color.Black;
                panelTop.BackColor = Color.Black;
                
             
            }
            else
            {
                logo1.Visible = true;
                lblAjuda.ForeColor = Color.Black;
                lblConf.ForeColor = Color.Black;
                lblSair.ForeColor = Color.Black;
               lblSobre.ForeColor = Color.Black;
                btnTema.ForeColor = Color.DimGray;
                panelFill.BackColor = Color.WhiteSmoke;
                panelLeft.BackColor = Color.DimGray;
                panelTop.BackColor = Color.DimGray;
               
            }
            
            panelFill.Controls.Clear();

            UCPrincipal uc = new UCPrincipal();
            uc.Dock = DockStyle.Fill;
            panelFill.Controls.Add(uc);

            panelFill.Controls["UCPrincipal"].BringToFront();
        }

        //label "Sair"
        private void LblSair_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FrmLogin"].Show();

            Close();
        }

        //label "Ajuda"
        private void LblAjuda_Click(object sender, EventArgs e)
        {
            //link do site aqui
            //System.Diagnostics.Process.Start("");
        }

        //botão "Minimizar"
        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //botão "Fechar"
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
         
            panelFill.Visible =false;
            panelLeft.Visible =false;
             panelTop.Visible =false;
 

            panelLeft.BackColor = Color.DimGray;
            panelTop.BackColor = Color.DimGray;
         


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

           

            if (timer2.Interval == 3000)
            {

                piclogo.Visible = false;



                panelFill.Visible = true;
                panelLeft.Visible = true;
                 panelTop.Visible = true;
 


            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        
        }
    }
}
