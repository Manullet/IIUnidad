using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;


namespace Blazor.Servicios
{
    public class LoginServicio : ILoginServicio
    {

        private readonly Config _configuracion;
        private ILoginRepositorio loginRepositorio;

        public LoginServicio(Config config)
        {
            _configuracion = config;
            loginRepositorio = new LoginRepositorio(config.CadenaConexion);
        }


        public async Task<bool> ValidarUsuario(Login Login)
        {
            return await loginRepositorio.ValidarUsuario(Login);
        }
    }
}
