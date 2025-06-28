using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ProyectoFinalAereolinea
{
    public class DaoBoleto
    {
        public int IdUsuario { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string NumeroTicket { get; set; }
        public string Estado { get; set; } = "emitido";
        public string Asiento { get; set; }
    }

    public class DaoAsiento
    {
        private string connectionString = "server=localhost;database=aerolinea;uid=root;pwd=root;";

        public List<string> ObtenerAsientosOcupados()
        {
            List<string> ocupados = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT asiento FROM boletos WHERE estado = 'emitido'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ocupados.Add(reader.GetString("asiento"));
                }
            }

            return ocupados;
        }
    }
}
