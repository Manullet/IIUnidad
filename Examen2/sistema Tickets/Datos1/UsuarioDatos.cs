using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos1
{
    public class UsuarioDatos
    {

        public async Task<bool> LoginAsync(string Nombre, string clave)
        {

            bool valido = false;
            try
            {
                string sql = "SELECT 4 FROM usuario WHERE Nombre=@Nombre AND Clave=@Clave;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 45).Value = Nombre;
                        comando.Parameters.Add("@Clave", MySqlDbType.VarChar, 45).Value = clave;

                        valido = Convert.ToBoolean(await comando.ExecuteScalarAsync());



                    }
                }
            }
            catch (Exception ex)
            {


            }
            return valido;

        }




    }
}
