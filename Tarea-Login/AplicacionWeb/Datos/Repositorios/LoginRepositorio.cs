using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
using Dapper;

namespace Datos.Repositorios
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private string cadenaConexion;

        public LoginRepositorio(string _cadenaConexion)
        {
            cadenaConexion = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(cadenaConexion);
        }

        public async Task<bool> ValidarUsuario(Login Login)
        {
            bool valido = false;

            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT 1 FROM usuario WHERE Codigo = @Codigo AND Clave = @Clave;";
                valido = await conexion.ExecuteScalarAsync<bool>(sql, new { Login.Codigo, Login.Clave });
            }
            catch (Exception ex)
            {
            }
            return valido;
        }
    }
}
