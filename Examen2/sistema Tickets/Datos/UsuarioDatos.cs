using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidad;

namespace Datos
{
    public class UsuarioDatos
    {

        public async Task<bool> LoginAsync(string Nombre, string clave)     
        {

            bool valido = false;
            try
            {
                string sql = "SELECT 1 FROM usuario WHERE Nombre=@Nombre AND Clave=@Clave;";

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

        public async Task<DataTable> DevolverListaAsync()
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuario";
                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {


            }
            return dt;
        }


        public async Task<bool> insertarAsync(Usuario usuario)
        {
            bool inserto = false;
            try
            {

                string sql = "INSERT INTO usuario VALUES (@Nombre, @Clave);";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 45).Value = usuario.Nombre;
                        comando.Parameters.Add("@Clave", MySqlDbType.VarChar, 45).Value = usuario.Clave;

                        await comando.ExecuteNonQueryAsync();
                        inserto = true;


                    }
                }

            }
            catch (Exception)
            {


            }
            return inserto;
        }

        public async Task<bool> ActualizarAsync(Usuario usuario)
        {
            bool actualizo = false;
            try
            {
                string sql = "UPDATE usuario SET Correo=@Correo, Clave=@Clave WHERE Codigo=@Codigo;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 45).Value = usuario.Nombre;
                        comando.Parameters.Add("@Clave", MySqlDbType.VarChar, 45).Value = usuario.Clave;

                        await comando.ExecuteNonQueryAsync();
                        actualizo = true;


                    }
                }

            }
            catch (Exception)
            {
            }
            return actualizo;
        }

        public async Task<bool> EliminarAsync(string Nombre)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FREOM usuario WHERE Correo=@Correo;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 20).Value = Nombre;
                        await comando.ExecuteNonQueryAsync();
                        elimino = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return elimino;
        }





    }
}
