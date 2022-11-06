using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Class1
    {
        public async Task<bool> datosAsync(Entidad.dclientes Clientes)
        {
            bool inserto = false;
            try
            {

                string sql = "INSERT INTO Cliente VALUES (@idCliente, @Nombre_del_cliente, @Precio, @Celular, @Solicitud, @Soporte,@Respuesta, @Fecha);";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena_de_Datos))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;

                        comando.Parameters.Add("@idCliente", MySqlDbType.VarChar, 15).Value = Clientes.idCliente;
                        comando.Parameters.Add("@Nombre_del_cliente", MySqlDbType.VarChar, 45).Value = Clientes.Nombre_del_cliente;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal, 10).Value = Clientes.Precio;
                        comando.Parameters.Add("@Celular", MySqlDbType.VarChar, 45).Value = Clientes.Celular;
                        comando.Parameters.Add("@Solicitud", MySqlDbType.VarChar, 200).Value = Clientes.Solicitud;
                        comando.Parameters.Add("@Soporte", MySqlDbType.VarChar, 45).Value = Clientes.Soporte;
                        comando.Parameters.Add("@Respuesta", MySqlDbType.VarChar, 200).Value = Clientes.Respuesta;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = Clientes.Fecha;

                        await comando.ExecuteNonQueryAsync();
                        inserto = true;


                    }
                }

            }
            catch (Exception ex)
            {


            }
            return inserto;

        }
        public async Task<DataTable> listAsync()
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM cliente";
                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena_de_Datos))
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
        public async Task<bool> EliAsync(string ID)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM Cliente WHERE idCliente=@idCliente;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena_de_Datos))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@idCliente", MySqlDbType.VarChar, 45).Value = ID;
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
