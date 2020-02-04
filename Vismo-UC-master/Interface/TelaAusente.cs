using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vismo
{
    public partial class TelaAusente : Form
    {
        public TelaAusente()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                
            }
            else
            {
                if(radioButton2.Checked == true)
                {

                }
                else
                {
                    if(radioButton3.Checked == true)
                    {

                    }
                    else
                    {
                        if(radioButton4.Checked == true)
                        {

                        }
                    }
                }
            }

            if(rd1.Checked == true)
            {

               
            }
            else
            {
                if (rd2.Checked == true)
                {

                }
                else
                {
                    if(rd3.Checked == true)
                    {

                    }
                    else
                    {
                        if(rd4.Checked == true)
                        {

                        }
                    }
                }

            }
            formAus2 formAus2 = new formAus2();
            this.Hide();
            formAus2.Show();
        }
    }
}
