using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios
{
    public class UsuarioRepositorio : IUsuarioReposotirio
    {
        private string cadenaConexion;

        public UsuarioRepositorio(string _cadenaConexion)
        {
            cadenaConexion = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(cadenaConexion);
        }

        public Task<bool> Actualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetLista()
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> GetPorCodigo(string codigo)
        {
            Usuario User = new Usuario();

            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT * FROM usuario WHERE Codigo = @Codigo;";
                User = await conexion.QueryFirstAsync<Usuario>(sql, new { codigo });
            }
            catch (Exception ex)
            {
            }
            return User;
        }

        public Task<bool> Nuevo(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
