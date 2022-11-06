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
            if (TicketsdataGridView1.SelectedRows.Count > 0)
            {
                bool eliminado = await cliente.EliminarAsync(TicketsdataGridView1.CurrentRow.Cells["Codigo_Cliente"].Value.ToString());
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

        private async void button1_Click(object sender, EventArgs e)
        {
            bool valido = await (cliente.BuscarCliente(TxtBuscar.Text));

            if (valido)
            {
                TicketsdataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                LlenarDataGrid();
            }
            else
            {
                MessageBox.Show("NO se encontro cliente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }



        

    }
}
