using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ProyectoFinalAereolinea
{
    public class DaoAsiento
    {
        private string connectionString = "server=localhost;database=aerolinea;uid=root;pwd=root;";

        public List<string> ObtenerAsientosOcupados()
        {
            List<string> ocupados = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT asiento FROM boletos WHERE estado = 'emitido' AND tipo_vuelo = 'ida'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ocupados.Add(reader.GetString("asiento"));
                }
            }

            return ocupados;
        }

        public List<string> ObtenerAsientosOcupadosRegreso()
        {
            List<string> ocupadosRegreso = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT asiento FROM boletos WHERE estado = 'emitido' AND tipo_vuelo = 'regreso'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ocupadosRegreso.Add(reader.GetString("asiento"));
                }
            }

            return ocupadosRegreso;
        }
    }
}
