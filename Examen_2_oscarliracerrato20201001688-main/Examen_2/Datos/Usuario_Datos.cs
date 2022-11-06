using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario_Datos
    {
        public async Task<bool> LoginAsync(string Nombre, string Contraseña)
        {

            bool valido = false;
            try
            {
                string sql = "SELECT 2 FROM Login WHERE Nombre=@Nombre AND Contraseña=@Contraseña;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena_de_Datos))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 45).Value = Nombre;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 45).Value = Contraseña;

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
