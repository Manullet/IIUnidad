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
using Entidades;

namespace Examen2_Manuel_Figueroa_20201001811
{
    public partial class Computadora : Form
    {
        public Computadora()
        {
            InitializeComponent();
        }

        ClienteDatos Clientesdato = new ClienteDatos();
        Cliente clientesE;

        private void BtnMenu_Click(object sender, EventArgs e)
        {

            Menu formulario = new Menu();
            Hide();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtNombre.Text=string.Empty;
            TxtPrecio.Text=string.Empty;    
            TxtSoli.Text=string.Empty;  
            TxtSopor.Text=string.Empty;
            TxtTelefono.Text=string.Empty;
            TxtRespuesta.Text=string.Empty; 
            dateTimePicker1.Value=DateTime.Now;
            Desactivar();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            clientesE = new Cliente();
            if (TxtNombre.Text=="")
            {
                errorProvider1.SetError(TxtNombre, "Ingrese su nombre");
                TxtNombre.Focus();
                return;
            }
            if(string.IsNullOrEmpty(TxtSoli.Text))
            {
                errorProvider1.SetError(TxtSoli,"Ingrese su solicitud");
                TxtSoli.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtSopor.Text))
            {
                errorProvider1.SetError(TxtSopor, "Ingrese el tipo de soporte");
                TxtSopor.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtTelefono.Text))
            {
                errorProvider1.SetError(TxtTelefono, "Ingrese su Telefono");
                TxtTelefono.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtRespuesta.Text))
            {
                errorProvider1.SetError(TxtRespuesta, "Ingrese su respuesta");
                TxtRespuesta.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                errorProvider1.SetError(dateTimePicker1, "Ingrese la fecha");
                dateTimePicker1.Focus();
                return;
            }

            clientesE.Nombre_Cliente=TxtNombre.Text;
            clientesE.Desc_soli=TxtSoli.Text;
            clientesE.Tipo_so=TxtSopor.Text;
            clientesE.Telefono = Convert.ToInt32(TxtTelefono.Text);
            clientesE.Precio = Convert.ToInt32(TxtPrecio.Text);
            clientesE.Descripcion=TxtRespuesta.Text;
            clientesE.Fecha=dateTimePicker1.Value;

            bool inserto = await Clientesdato.insertarAsync(clientesE);

            if (inserto)
            {
                MessageBox.Show("Ticket Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ticket no Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            TxtPrecio.Enabled=false;
        }




        private void Desactivar()
        {
            TxtNombre.Enabled=false;
            TxtPrecio.Enabled=false;
            TxtSoli.Enabled=false;
            TxtSopor.Enabled=false;
            TxtTelefono.Enabled=false;
            TxtRespuesta.Enabled=false;
            dateTimePicker1.Enabled=false;

        }

        
    }
}
