using Datos;
using Entidad;
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
    public partial class Reparación_PC : Form
    {
        Class1 Datclass = new Class1();
        dclientes datos_cliente;
        public Reparación_PC()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Desac()
        {
            Nombre_Client.Enabled = false;
            Celular.Enabled = false;
            Des_soli.Enabled = false;
            Tipo_de_soporte.Enabled = false;
            Celular.Enabled = false;
            Precio.Enabled = false;
            Des_Res.Enabled = false;
            fecha_date.Enabled = false;
        }

        private void cancel_cel_Click(object sender, EventArgs e)
        {
            Nombre_Client.Text = string.Empty;
            Celular.Text = string.Empty;
            Des_soli.Text = string.Empty;
            Tipo_de_soporte.Text = string.Empty;
            Celular.Text = string.Empty;
            Precio.Text = string.Empty;
            Des_Res.Text = string.Empty;
            fecha_date.Value = DateTime.Now;
            Desac();
        }

       

        private void menu_Click(object sender, EventArgs e)
        {
            Menu_de_opciones menu = new Menu_de_opciones();
            Hide();
            menu.Show();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            //aqui boton almacenar
            datos_cliente = new dclientes();
            if (Nombre_Client.Text == "")
            {
                errorProvider1.SetError(Nombre_Client, "Ingrese su nombre");
                Nombre_Client.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Des_soli.Text))
            {
                errorProvider1.SetError(Des_soli, "Ingrese su solicitud");
                Des_soli.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Tipo_de_soporte.Text))
            {
                errorProvider1.SetError(Tipo_de_soporte, "Ingrese su solicitud");
                Tipo_de_soporte.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Celular.Text))
            {
                errorProvider1.SetError(Celular, "Ingrese su solicitud");
                Celular.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Des_Res.Text))
            {
                errorProvider1.SetError(Des_Res, "Ingrese su respuesta");
                Des_Res.Focus();
                return;
            }
            if (string.IsNullOrEmpty(fecha_date.Text))
            {
                errorProvider1.SetError(fecha_date, "Ingrese la fecha");
                fecha_date.Focus();
                return;
            }

            datos_cliente.Nombre_del_cliente = Nombre_Client.Text;
            datos_cliente.Solicitud = Des_soli.Text;
            datos_cliente.Soporte = Tipo_de_soporte.Text;
            datos_cliente.Celular = Convert.ToInt32(Celular.Text);
            datos_cliente.Precio = Convert.ToInt32(Precio.Text);
            datos_cliente.Respuesta = Des_Res.Text;
            datos_cliente.Fecha = fecha_date.Value;

            bool inserto = await Datclass.datosAsync(datos_cliente);

            if (inserto)
            {
                MessageBox.Show("Ticket Guardado ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ticket no Guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void cancel_cel_Click_1(object sender, EventArgs e)
        {

        }
    }

}
