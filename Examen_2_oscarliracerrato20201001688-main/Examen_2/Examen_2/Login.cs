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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private async void Conectar_Click(object sender, EventArgs e)
        {
            if (Usuario.Text == string.Empty)
            {
                errorProvider1.SetError(Usuario, "Ingrese el usuario");
                Usuario.Focus();
                return;
            }
            errorProvider1.Clear();
            if (Contra.Text == string.Empty)
            {
                errorProvider1.SetError(Contra, "Ingrese la clave");
                Usuario.Focus();
                return;
            }
            errorProvider1.Clear();
            Usuario_Datos Colesterol = new Usuario_Datos();

            bool valido = await(Colesterol.LoginAsync(Usuario.Text, Contra.Text));

            if (valido)
            {
                //mostrar si puede acceder 
                Menu_de_opciones menu = new Menu_de_opciones();
                Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrecto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
