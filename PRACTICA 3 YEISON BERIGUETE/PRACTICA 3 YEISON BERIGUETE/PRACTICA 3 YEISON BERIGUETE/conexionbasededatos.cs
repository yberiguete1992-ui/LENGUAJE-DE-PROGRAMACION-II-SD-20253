using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PRACTICA_3_YEISON_BERIGUETE.AccesoADatos
{
    
    public static class Conexionbasededatos
    {
        
        public static SqlConnection AbrirConexion()
        {
            SqlConnection conexion = null;
            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["cadena_conexion_bd"].ConnectionString;
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión. Revise App.config y SQL Server: " + ex.Message, "Error de Conexión");
                return null;
            }
        }

        
        public static void CerrarConexion(SqlConnection conexion)
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}