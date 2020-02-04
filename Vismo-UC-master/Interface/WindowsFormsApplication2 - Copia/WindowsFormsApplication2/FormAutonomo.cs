using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    public partial class FormAutonomo : Form
    {
        bool click = false;
        bool mouse2 = false;
        bool click2 = false;
        bool mouse3 = false;
      
        public FormAutonomo()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Totalvenda.Visible = true;
            totalvendamanha.Visible = true;
            totalvendanoite.Visible = true;
            totalvendatarde.Visible = true;
            lblVendas.Visible = true; ;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (click == true)
            {
               
                Totalvenda.Visible = true;
                totalvendamanha.Visible = true;
                totalvendanoite.Visible = true;
                totalvendatarde.Visible = true;
                lblVendas.Visible = true;
            }
            else 
            {
                lblVendas.Visible = false;
                Totalvenda.Visible = false;
                totalvendamanha.Visible = false;
                totalvendanoite.Visible = false;
                totalvendatarde.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            log log = new log();
            log.Show();
            this.Hide();
            this.Opacity = 0;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(picvoltar, "Voltar para a tela inicial.");
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            lblVendas.Visible = false;
            Totalvenda.Visible = false;
            totalvendamanha.Visible = false;
            totalvendanoite.Visible = false;
            totalvendatarde.Visible = false;

            lblTotalCancelamento.Visible = false;
            lblcancelamentos.Visible = false;
            lblTotalCancelamentoManha.Visible = false;
            lblTotalCancelamentoTarde.Visible = false;
            lblCancelamentoNoite.Visible = false;

         

            toolTip1.AutoPopDelay = 2500;
            toolTip1.InitialDelay = 50;
            toolTip1.ReshowDelay = 5;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(button1, "Dê um click para manter as estatísticas fixas.");
            toolTip1.AutoPopDelay = 2500;
            toolTip1.InitialDelay = 50;
            toolTip1.ReshowDelay = 5;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(button2, "Dê um click para manter as estatísticas fixas.");


        }

      

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            click = true;
         
           if(mouse2 == false)
            {
                Totalvenda.Visible = true;
                totalvendamanha.Visible = true;
                totalvendanoite.Visible = true;
                totalvendatarde.Visible = true;
                lblVendas.Visible = true;
                mouse2 = true;
            }
           else if(mouse2 == true )
            {
                     Totalvenda.Visible = false;
                totalvendamanha.Visible = false;
                totalvendanoite.Visible = false;
                totalvendatarde.Visible = false;
                      lblVendas.Visible = false;
                mouse2 = false;
                click = false;

            }
           

                     
               
            

           

        }

        private void button1_DoubleClick(object sender, System.EventArgs e)
        {

            Totalvenda.Visible = false;
            totalvendamanha.Visible = false;
            totalvendanoite.Visible = false;
            totalvendatarde.Visible = false;
            lblVendas.Visible = false;



        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            lblTotalCancelamento.Visible = true;
            lblcancelamentos.Visible = true;
            lblTotalCancelamentoManha.Visible = true;
            lblTotalCancelamentoTarde.Visible = true;
            lblCancelamentoNoite.Visible = true;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (click2== true)
            {

                     lblTotalCancelamento.Visible = true;
                         lblcancelamentos.Visible = true;
                lblTotalCancelamentoManha.Visible = true;
                lblTotalCancelamentoTarde.Visible = true;
                     lblCancelamentoNoite.Visible = true;
            }
            else
            {
                lblTotalCancelamento.Visible = false;
                lblcancelamentos.Visible = false;
                lblTotalCancelamentoManha.Visible = false;
                lblTotalCancelamentoTarde.Visible = false;
                lblCancelamentoNoite.Visible = false;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click2 = true;

            if (mouse3 == false)
            {

                lblTotalCancelamento.Visible = true;
                lblcancelamentos.Visible = true;
                lblTotalCancelamentoManha.Visible = true;
                lblTotalCancelamentoTarde.Visible = true;
                lblCancelamentoNoite.Visible = true;
                mouse3 = true;
            }
            else if (mouse3 == true)
            {
                lblTotalCancelamento.Visible = false;
                lblcancelamentos.Visible = false;
                lblTotalCancelamentoManha.Visible = false;
                lblTotalCancelamentoTarde.Visible = false;
                lblCancelamentoNoite.Visible = false;
                mouse3 = false;
                click2 = false;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer1.Interval == 4000)
            {
              
                this.Show();
                this.Opacity = 100;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
