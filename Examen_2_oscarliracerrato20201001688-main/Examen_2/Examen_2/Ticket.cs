using Datos;
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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            DataGrid();
        }
        private async void DataGrid()
        {
            dataGridView1.DataSource = await dat_class.listAsync();
        }
        Class1 dat_class = new Class1();

        private async void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool eliminado = await dat_class.EliAsync(dataGridView1.CurrentRow.Cells["idCliente"].Value.ToString());
                if (eliminado)
                {
                    DataGrid();
                    MessageBox.Show("Cliente Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente No Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Menu_de_opciones menu = new Menu_de_opciones();
            Hide();
            menu.Show();
        }
    }
}
