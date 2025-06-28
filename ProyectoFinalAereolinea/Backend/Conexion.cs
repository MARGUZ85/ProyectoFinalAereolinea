using MySql.Data.MySqlClient;

namespace ProyectoFinalAereolinea.Backend
{
    public class Conexion
    {
        private static string conn = "server=localhost;database=aerolinea;uid=root;pwd=root;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(conn);
        }
    }
}
