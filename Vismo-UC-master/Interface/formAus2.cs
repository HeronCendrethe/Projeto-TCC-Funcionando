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
    public partial class formAus2 : Form
    {
        public formAus2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TelaAusente telaAusente = new TelaAusente();
            telaAusente.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {

            }
            else
            {
                if (radioButton2.Checked == true)
                {

                }
                else
                {
                    if (radioButton3.Checked == true)
                    {

                    }
                    else
                    {
                        if (radioButton4.Checked == true)
                        {

                        }
                    }
                }
            }

            this.Close();
        }
    }
}
