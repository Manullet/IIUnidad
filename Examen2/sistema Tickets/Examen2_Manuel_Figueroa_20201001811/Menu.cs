using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_Manuel_Figueroa_20201001811
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnCelular_Click(object sender, EventArgs e)
        {




            Celular formulario = new Celular();
            Hide();
            formulario.Show();
        }

        private void BtnComputo_Click(object sender, EventArgs e)
        {







            Computadora formulario = new Computadora();
            Hide();
            formulario.Show();

        }

        private void BtnTickets_Click(object sender, EventArgs e)
        {







            Tickets formulario = new Tickets();
            Hide();
            formulario.Show();

        }
    }
}
