using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Datos.Interfaces
{
    public interface IUsuarioReposotirio
    {
        Task<Usuario> GetPorCodigo(string codigo);
        Task<bool> Nuevo(Usuario usuario);
        Task<bool> Actualizar(Usuario usuario);
        Task<bool> Eliminar(string codigo);
        Task<IEnumerable<Usuario>> GetLista();

    }
}
