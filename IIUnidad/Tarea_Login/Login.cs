using Datos;

namespace Tarea_Login
{
    public partial class Login : Form
    {
        public Login()
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
                Bienvenido formulario = new Bienvenido();
                Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrecto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}