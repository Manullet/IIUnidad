using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class Menu_de_opciones : Form
    {
        public Menu_de_opciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_de_opciones_Load(object sender, EventArgs e)
        {

        }

        private void Repara_Cel_Click(object sender, EventArgs e)
        {
            Form1 Repar_Cel = new Form1();
            Hide();
            Repar_Cel.Show();
        }

        private void Repara_PC_Click(object sender, EventArgs e)
        {

            Reparación_PC Repar_PC = new Reparación_PC();
            Hide();
            Repar_PC.Show();
        }

        private void Ticket_Click(object sender, EventArgs e)
        {

            Ticket Tickets = new Ticket();
            Hide();
            Tickets.Show();
        }
    }
}
