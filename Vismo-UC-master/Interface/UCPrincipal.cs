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
using WindowsFormsApplication2;
namespace Vismo
{
    public partial class UCPrincipal : UserControl
    {
        bool fodase = false;
        public UCPrincipal()
        {
            InitializeComponent();

            BackColor = FrmPrincipal.Instance.PanelFill.BackColor;

            lblNoti.Visible = false;
            lblPerfil.Visible = false;

            if(this.BackColor == Color.DimGray)
            {
                lblAlternar.ForeColor = Color.Coral;
            }
       
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UCPerfil uc = new UCPerfil();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCPerfil"].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCPrincipal_Load(object sender, EventArgs e)
        {
            timer3.Start();
            timer4.Start();
            int hora;
          hora = DateTime.Now.Hour;
      

            lblRelogioHora.Text = Convert.ToString(DateTime.Now.Hour );
            lblRelogioMinuto.Text = Convert.ToString(DateTime.Now.Minute );
            Aut1.Visible = false;
            Aut2.Visible = false;
            Aus1.Visible = false;
            Aus2.Visible = false;
            Disp1.Visible = false;
            Disp2.Visible = false;

            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(lblAlternar, "Clique uma vez para manter os modos fixos, clique duas para manter alternado.");
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;



        }

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
           

          
      
                lblRelogioHora.Text = Convert.ToString(DateTime.Now.Hour);
                
           
           
            int minuto;
            minuto = DateTime.Now.Minute;

            if(minuto <10)
            {
                lblRelogioMinuto.Text = Convert.ToString("0"+DateTime.Now.Minute);
            }
            else
            {
                lblRelogioMinuto.Text = Convert.ToString(DateTime.Now.Minute);
            }




        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(timer2.Interval == 3000)
            {
            
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(timer3.Interval == 1000)
            {
                label2.Visible = false;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if(timer4.Interval == 2000)
            {
                label2.Visible = true; ;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCPerfil uc = new UCPerfil();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCPerfil"].BringToFront();
        }

        private void btnNotificacao_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

            lblPerfil.Visible = false;
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblPerfil.Visible = true;
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
           
        }

        private void piclogo2_Click(object sender, EventArgs e)
        {

            UCPerfil uc = new UCPerfil();
            uc.Dock = DockStyle.Fill;
            FrmPrincipal.Instance.PanelFill.Controls.Add(uc);

            FrmPrincipal.Instance.PanelFill.Controls["UCPerfil"].BringToFront();
            MessageBox.Show("kkkk");
        }

        private void piclogo2_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            lblNoti.Visible = false;

            pictureBox2.Visible = true ;
         
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            lblNoti.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void Aut1_MouseMove(object sender, MouseEventArgs e)
        {
            Aut1.Visible = false;
            Aut1.Enabled = false;

        }

        private void Aut2_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication2.FormAutonomo formAutonomo = new FormAutonomo();
            formAutonomo.Show();
           
        }

        private void lblAlternar_MouseMove(object sender, MouseEventArgs e)
        {
             Aut1.Visible = true;
             Aut2.Visible = true;
             Aus1.Visible = true;
             Aus2.Visible = true;
            Disp1.Visible = true;
            Disp2.Visible = true;
        }

        private void lblAlternar_MouseLeave(object sender, EventArgs e)
        {
            if(fodase == true)
            {
                Aut1.Visible = true;
                Aut2.Visible = true;
                Aus1.Visible = true;
                Aus2.Visible = true;
                Disp1.Visible = true;
                Disp2.Visible = true;

            }
            else
            {
                Aut1.Visible = false;
                Aut2.Visible = false;
                Aus1.Visible = false;
                Aus2.Visible = false;
                Disp1.Visible = false;
                Disp2.Visible = false;

            }
           
        }

        private void lblAlternar_Click(object sender, EventArgs e)
        {
            fodase = true;
            Aut1.Visible = true;
            Aut2.Visible = true;
            Aus1.Visible = true;
            Aus2.Visible = true;
           Disp1.Visible = true;
           Disp2.Visible = true;
        }

        private void lblAlternar_DoubleClick(object sender, EventArgs e)
        {
            fodase = false;
            Aut1.Visible = false;
            Aut2.Visible = false;
            Aus1.Visible = false;
            Aus2.Visible = false;
           Disp1.Visible = false;
           Disp2.Visible = false;
        }

      

     
        private void Aus1_MouseMove(object sender, MouseEventArgs e)
        {
           
            Aus1.Visible = false;
            
        }


      
        private void Disp1_MouseMove(object sender, MouseEventArgs e)
        {
            Disp1.Visible = false;
        }

        private void Disp1_MouseLeave(object sender, EventArgs e)
        {


            Disp1.Visible = true;
        }

        private void Aut1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void Aut1_Click_1(object sender, EventArgs e)
        {

        }

        private void Aut2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Aut2_MouseLeave(object sender, EventArgs e)
        {
            Aut1.Visible = true;
            Aut1.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void Aus2_Click(object sender, EventArgs e)
        {
            TelaAusente telaAusente = new TelaAusente();
            telaAusente.Show();
        }

        private void Aus2_MouseLeave(object sender, EventArgs e)
        {
            Aus1.Visible = true;
        }

        private void Disp2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você entrou no modo disponivel");
        }
    }
}
