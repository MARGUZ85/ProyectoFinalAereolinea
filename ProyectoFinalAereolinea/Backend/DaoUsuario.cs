using MySql.Data.MySqlClient;

namespace ProyectoFinalAereolinea.Backend
{
    public class DaoUsuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }

        public int Guardar()
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                string sql = "INSERT INTO Usuarios (nombre, correo_electronico, telefono) VALUES (@nombre, @correo, @telefono)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@correo", CorreoElectronico);
                    cmd.Parameters.AddWithValue("@telefono", Telefono);
                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }
    }
}
