using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectofinalYeisonberiguete
{
    public static class MateriaDAL
    {
        
        public static DataTable ObtenerTodasLasMaterias()
        {
            DataTable dtMaterias = new DataTable();
            string query = "SELECT ID, NombreMateria FROM Materias ORDER BY ID ASC";

            using (SqlConnection conn = ConexionDB.GetConnection())
            {
                if (conn != null)
                {
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        adapter.Fill(dtMaterias);
                    }
                    catch (SqlException ex) { MessageBox.Show("Error SELECT Materias: " + ex.Message, "Error BD"); }
                }
            }
            return dtMaterias;
        }

        
        public static int InsertarMateria(string nombreMateria)
        {
            string query = "INSERT INTO Materias (NombreMateria) VALUES (@NombreMateria); SELECT SCOPE_IDENTITY();";
            if (string.IsNullOrWhiteSpace(nombreMateria)) return 0;

            using (SqlConnection conn = ConexionDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (conn == null) return 0;
                try
                {
                    cmd.Parameters.AddWithValue("@NombreMateria", nombreMateria);
                    object resultado = cmd.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : 0;
                }
                catch (SqlException ex) { MessageBox.Show("Error INSERT Materia: " + ex.Message, "Error BD"); return 0; }
            }
        }

        
        public static bool ActualizarMateria(int id, string nombreMateria)
        {
            string query = "UPDATE Materias SET NombreMateria = @NombreMateria WHERE ID = @ID";
            if (string.IsNullOrWhiteSpace(nombreMateria)) return false;

            using (SqlConnection conn = ConexionDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (conn == null) return false;
                try
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@NombreMateria", nombreMateria);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex) { MessageBox.Show("Error UPDATE Materia: " + ex.Message, "Error BD"); return false; }
            }
        }

        
        public static bool EliminarMateria(int id)
        {
            string query = "DELETE FROM Materias WHERE ID = @ID";

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
                catch (SqlException ex)
                {
                    MessageBox.Show("Error DELETE Materia (Verifique si tiene calificaciones asociadas): " + ex.Message, "Error BD");
                    return false;
                }
            }
        }
    }
}