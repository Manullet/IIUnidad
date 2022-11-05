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
                errorProvider1.SetError(TxtSopor, "Ingrese su solicitud");
                TxtSopor.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtTelefono.Text))
            {
                errorProvider1.SetError(TxtTelefono, "Ingrese su solicitud");
                TxtTelefono.Focus();
                return;
            }

            clientesE.Nombre_Cliente=TxtNombre.Text;
            clientesE.Desc_soli=TxtSoli.Text;
            clientesE.Tipo_so=TxtSopor.Text;
            clientesE.Telefono = Convert.ToInt32(TxtTelefono.Text);
            clientesE.Precio = Convert.ToInt32(TxtPrecio.Text);

            bool inserto = await Clientesdato.insertarAsync(clientesE);

            if (inserto)
            {
                MessageBox.Show("cliente no guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("cliente no guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        
    }
}
