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
    public partial class UCPerfil : UserControl
    {
        Tema tema = new Tema();

        public UCPerfil()
        {
            InitializeComponent();
        }

        private void MudaCor(int r, int g, int b)
        {
            FrmPrincipal.Instance.PanelLeft.BackColor = Color.FromArgb(r, g, b);

            tema.R = Convert.ToString(r);
            tema.G = Convert.ToString(g);
            tema.B = Convert.ToString(b);

            tema.usuario.Codigo = FrmPrincipal.Instance.Codigo;

            try
            {
                tema.AttCor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar salvar tema de usuário.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }

        private void CboTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTema.SelectedIndex)
            {
                case 0:
                    MudaCor(44, 44, 44);

                    break;

                case 1:
                    MudaCor(166, 0, 0);

                    break;

                case 2:
                    MudaCor(39, 50, 177);

                    break;

                case 3:
                    MudaCor(64, 169, 46);

                    break;

                case 4:
                    MudaCor(255, 60, 157);

                    break;

                case 5:
                    MudaCor(214, 219, 13);

                    break;
            }
        }
    }
}
