using System;
using MySql.Data.MySqlClient;
using ProyectoFinalAereolinea.Backend;

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

        public void Guardar()
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string sql = @"INSERT INTO Boletos (id_usuario, origen, destino, fecha, hora, asiento, estado, numero_ticket) 
                               VALUES (@id_usuario, @origen, @destino, @fecha, @hora, @asiento, @estado, @numero_ticket)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);
                    cmd.Parameters.AddWithValue("@origen", Origen);
                    cmd.Parameters.AddWithValue("@destino", Destino);
                    cmd.Parameters.AddWithValue("@fecha", Fecha);
                    cmd.Parameters.AddWithValue("@hora", Hora);
                    cmd.Parameters.AddWithValue("@asiento", Asiento);
                    cmd.Parameters.AddWithValue("@estado", Estado);
                    cmd.Parameters.AddWithValue("@numero_ticket", NumeroTicket);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
