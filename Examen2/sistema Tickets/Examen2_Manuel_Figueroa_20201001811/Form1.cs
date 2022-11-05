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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtBoxUsuario.Text == string.Empty)
            {
                errorProvider1.SetError(TxtBoxUsuario, "Ingrese el usuario");
                TxtBoxUsuario.Focus();
                return;
            }
            errorProvider1.Clear();
            if (TxtBoxClave.Text == string.Empty)
            {
                errorProvider1.SetError(TxtBoxClave, "Ingrese la clave");
                TxtBoxUsuario.Focus();
                return;
            }
            errorProvider1.Clear();
            UsuarioDatos UserDatos = new UsuarioDatos();
            
            bool valido = await (UserDatos.LoginAsync(TxtBoxUsuario.Text, TxtBoxClave.Text));

            if (valido)
            {
                //mostrar si puede acceder 
                Menu formulario = new Menu();
                Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrecto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
    }

