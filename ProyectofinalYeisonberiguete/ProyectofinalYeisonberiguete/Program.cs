using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProyectofinalYeisonberiguete;

namespace ProyectofinalYeisonberiguete
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            using (SqlConnection conn = ConexionDB.GetConnection())
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    MessageBox.Show("¡Conexión Exitosa con la Base de Datos!", "Éxito");
                }
            }

          
            Application.Run(new FormPrincipal());

        }
    }
}