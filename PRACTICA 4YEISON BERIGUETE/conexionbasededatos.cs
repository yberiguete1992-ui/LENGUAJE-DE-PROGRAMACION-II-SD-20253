using System;
using System.Data.SqlClient;
using System.Configuration; // Necesario
using System.Windows.Forms;
using System.Data; // Necesario para usar ConnectionState

namespace PRACTICA_3_YEISON_BERIGUETE.AccesoADatos
{
    public static class Conexionbasededatos
    {
        public static SqlConnection AbrirConexion()
        {
            SqlConnection conexion = null;
            try
            {
                
                string connectionString = "data source=PATRICIAV\\SQLEXPRESS;initial catalog=MINIMARKET_YEISONYBD;integrated security=True;trustservercertificate=True;";

            
                conexion = new SqlConnection(connectionString);

                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error al abrir la conexión. Debe revisar la cadena de conexión: " + ex.Message, "Error de Conexión");
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