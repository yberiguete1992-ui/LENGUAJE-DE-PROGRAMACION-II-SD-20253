using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectofinalYeisonberiguete
{
    public static class EstudianteDAL
    {
        
        public static DataTable ObtenerTodosLosEstudiantes()
        {
            DataTable dtEstudiantes = new DataTable();
            string query = "SELECT ID, Nombre, Apellido FROM Estudiante ORDER BY ID ASC";

            using (SqlConnection conn = ConexionDB.GetConnection())
            {
                if (conn != null)
                {
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        adapter.Fill(dtEstudiantes);
                    }
                    catch (SqlException ex) { MessageBox.Show("Error SELECT: " + ex.Message, "Error BD"); }
                }
            }
            return dtEstudiantes;
        }

        
        public static int InsertarEstudiante(string nombre, string apellido)
        {
            string query = "INSERT INTO Estudiante (Nombre, Apellido) VALUES (@Nombre, @Apellido); SELECT SCOPE_IDENTITY();";
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido)) return 0;

            using (SqlConnection conn = ConexionDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (conn == null) return 0;
                try
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    object resultado = cmd.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : 0;
                }
                catch (SqlException ex) { MessageBox.Show("Error INSERT: " + ex.Message, "Error BD"); return 0; }
            }
        }

        
        public static bool ActualizarEstudiante(int id, string nombre, string apellido)
        {
            string query = "UPDATE Estudiante SET Nombre = @Nombre, Apellido = @Apellido WHERE ID = @ID";
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido)) return false;

            using (SqlConnection conn = ConexionDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (conn == null) return false;
                try
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex) { MessageBox.Show("Error UPDATE: " + ex.Message, "Error BD"); return false; }
            }
        }

        
        public static bool EliminarEstudiante(int id)
        {
            string query = "DELETE FROM Estudiante WHERE ID = @ID";

            using (SqlConnection conn = ConexionDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (conn == null) return false;
                try
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex) { MessageBox.Show("Error DELETE (Verifique FK): " + ex.Message, "Error BD"); return false; }
            }
        }
    }
}