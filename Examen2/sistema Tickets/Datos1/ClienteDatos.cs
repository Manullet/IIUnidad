﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Datos1
{
    public class ClienteDatos
    {
        public async Task<bool> insertarAsync(Cliente Clientes)
        {
            bool inserto = false;
            try
            {

                string sql = "INSERT INTO cliente VALUES (@Codigo_Cliente, @Nombre_cliente, @Telefono, @Desc_Solicitud, @Precio, @Tipo_Soporte );";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        
                        comando.Parameters.Add("@Codigo_Cliente", MySqlDbType.VarChar, 15).Value = Clientes.Codigo;
                        comando.Parameters.Add("@Nombre_cliente", MySqlDbType.VarChar, 20).Value = Clientes.Nombre_Cliente;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 45).Value = Clientes.Telefono;
                        comando.Parameters.Add("@Desc_Solicitud", MySqlDbType.VarChar, 100).Value = Clientes.Desc_soli;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal, 8).Value = Clientes.Precio;
                        comando.Parameters.Add("@Tipo_Soporte", MySqlDbType.VarChar, 45).Value = Clientes.Tipo_so;

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


    }
}
