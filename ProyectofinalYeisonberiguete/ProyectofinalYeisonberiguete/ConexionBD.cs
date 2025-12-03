using System.Configuration; 
using System.Data.SqlClient; 
using System.Windows.Forms;  


namespace ProyectofinalYeisonberiguete
{
    public static class ConexionDB
    {
       
        private static string GetConnectionString()
        {
            try
            {
               
                return ConfigurationManager.ConnectionStrings["ConexionCalificaciones"].ConnectionString;
            }
            catch (System.Exception ex)
            {
              
                MessageBox.Show("Error de configuración (App.config). Detalle: " + ex.Message,
                                "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static SqlConnection GetConnection()
        {
            string connectionString = GetConnectionString();
            if (string.IsNullOrEmpty(connectionString))
            {
                return null;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                return conn; 
            }
            catch (SqlException ex)
            {
                
                MessageBox.Show("Error de conexión con el servidor SQL EXPRESS. Revise la cadena o el servidor. Detalle: " + ex.Message,
                                "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}