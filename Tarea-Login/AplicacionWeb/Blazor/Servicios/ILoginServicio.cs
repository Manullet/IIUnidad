using Modelos;

namespace Blazor.Servicios
{
    public interface ILoginServicio
    {


        Task<bool> ValidarUsuario(Login Login);


    }
}
