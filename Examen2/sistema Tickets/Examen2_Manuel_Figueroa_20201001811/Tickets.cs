using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos1;

namespace Examen2_Manuel_Figueroa_20201001811
{
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }
        ClienteDatos cliente = new ClienteDatos();


        private void TicketsFrom_Load(object sender, EventArgs e)
        { 

        }

        private async void LlenarDataGrid()
        {
            TicketsdataGridView1.DataSource=await cliente.DevolverListaAsync();
        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Menu formulario = new Menu();
            Hide();
            formulario.Show();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (TicketsdataGridView1.SelectedRows.Count>0)
            {
                bool eliminado = await cliente.EliminarAsync(TicketsdataGridView1.CurrentRow.Cells["Nombre_Cliente"].Value.ToString());
                if (eliminado)
                {
                    LlenarDataGrid();
                    MessageBox.Show("Cliente Eliminado","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente No Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
