using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectofinalYeisonberiguete
{
    public static class CalificacionDAL
    {
        
        public static DataTable ObtenerTodasLasCalificaciones()
        {
            DataTable dtCalificaciones = new DataTable();
            string query = @"
                SELECT 
                    C.ID, 
                    C.EstudianteID, 
                    E.Nombre + ' ' + E.Apellido AS NombreEstudiante, 
                    C.MateriaID, 
                    M.NombreMateria,
                    C.Calificacion1, C.Calificacion2, C.Calificacion3, C.Calificacion4, C.Examen
                FROM Calificacion C
                INNER JOIN Estudiante E ON C.EstudianteID = E.ID
                INNER JOIN Materias M ON C.MateriaID = M.ID
                ORDER BY NombreEstudiante, NombreMateria";

            using (SqlConnection conn = ConexionDB.GetConnection())
            {
                if (conn != null)
                {
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        adapter.Fill(dtCalificaciones);

                        
                        dtCalificaciones.Columns.Add("TotalCalificacion", typeof(decimal));
                        dtCalificaciones.Columns.Add("Clasificacion", typeof(string));
                        dtCalificaciones.Columns.Add("Estado", typeof(string));

                        
                        foreach (DataRow row in dtCalificaciones.Rows)
                        {
                            
                            Calificacion temp = new Calificacion
                            {
                                Calificacion1 = Convert.ToDecimal(row["Calificacion1"]),
                                Calificacion2 = Convert.ToDecimal(row["Calificacion2"]),
                                Calificacion3 = Convert.ToDecimal(row["Calificacion3"]),
                                Calificacion4 = Convert.ToDecimal(row["Calificacion4"]),
                                Examen = Convert.ToDecimal(row["Examen"])
                            };
                            row["TotalCalificacion"] = temp.TotalCalificacion;
                            row["Clasificacion"] = temp.Clasificacion;
                            row["Estado"] = temp.Estado;
                        }
                    }
                    catch (SqlException ex) { MessageBox.Show("Error SELECT Calificaciones: " + ex.Message, "Error BD"); }
                }
            }
            return dtCalificaciones;
        }

        
        public static int InsertarCalificacion(Calificacion c)
        {
            string query = @"INSERT INTO Calificacion (EstudianteID, MateriaID, Calificacion1, Calificacion2, Calificacion3, Calificacion4, Examen) 
                             VALUES (@EstudianteID, @MateriaID, @C1, @C2, @C3, @C4, @Examen); 
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = ConexionDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (conn == null) return 0;
                try
                {
                    cmd.Parameters.AddWithValue("@EstudianteID", c.EstudianteID);
                    cmd.Parameters.AddWithValue("@MateriaID", c.MateriaID);
                    cmd.Parameters.AddWithValue("@C1", c.Calificacion1);
                    cmd.Parameters.AddWithValue("@C2", c.Calificacion2);
                    cmd.Parameters.AddWithValue("@C3", c.Calificacion3);
                    cmd.Parameters.AddWithValue("@C4", c.Calificacion4);
                    cmd.Parameters.AddWithValue("@Examen", c.Examen);

                    object resultado = cmd.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : 0;
                }
                catch (SqlException ex) { MessageBox.Show("Error INSERT Calificación: " + ex.Message, "Error BD"); return 0; }
            }
        }
        public static bool ActualizarCalificacion(Calificacion c)
        {
            string query = @"UPDATE Calificacion SET EstudianteID = @EstudianteID, MateriaID = @MateriaID, 
                             Calificacion1 = @C1, Calificacion2 = @C2, Calificacion3 = @C3, Calificacion4 = @C4, Examen = @Examen 
                             WHERE ID = @ID";

            using (SqlConnection conn = ConexionDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (conn == null) return false;
                try
                {
                    cmd.Parameters.AddWithValue("@ID", c.ID);
                    cmd.Parameters.AddWithValue("@EstudianteID", c.EstudianteID);
                    cmd.Parameters.AddWithValue("@MateriaID", c.MateriaID);
                    cmd.Parameters.AddWithValue("@C1", c.Calificacion1);
                    cmd.Parameters.AddWithValue("@C2", c.Calificacion2);
                    cmd.Parameters.AddWithValue("@C3", c.Calificacion3);
                    cmd.Parameters.AddWithValue("@C4", c.Calificacion4);
                    cmd.Parameters.AddWithValue("@Examen", c.Examen);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex) { MessageBox.Show("Error UPDATE Calificación: " + ex.Message, "Error BD"); return false; }
            }
        }

        
        public static bool EliminarCalificacion(int id)
        {
            string query = "DELETE FROM Calificacion WHERE ID = @ID";

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
                catch (SqlException ex) { MessageBox.Show("Error DELETE Calificación: " + ex.Message, "Error BD"); return false; }
            }
        }
    }
}