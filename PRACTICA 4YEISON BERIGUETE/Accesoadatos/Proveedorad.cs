using PRACTICA_3_YEISON_BERIGUETE.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRACTICA_3_YEISON_BERIGUETE.AccesoADatos
{
    public class Proveedorad
    {
      
        public int ObtenerSiguienteID()
        {
            int siguienteID = 1;
            SqlConnection conexion = Conexionbasededatos.AbrirConexion();
            string query = "SELECT MAX(ProveedorID) FROM PROVEEDORES";
            SqlCommand comando = new SqlCommand(query, conexion);
            try
            {
                object resultado = comando.ExecuteScalar();
                if (resultado != DBNull.Value)
                {
                    siguienteID = Convert.ToInt32(resultado) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID del proveedor: " + ex.Message, "Error de BD");
                return -1;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return siguienteID;
        }

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();
            SqlConnection conexion = null;
            SqlDataReader lector = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();
                
                string sql = @"
                    SELECT 
                        PROVEEDORID, 
                        NOMBREPROVEEDOR AS NombreCompleto, 
                        TELEFONO, 
                        CORREOELECTRONIC AS CorreoElectronico 
                    FROM PROVEEDORES";

                SqlCommand comando = new SqlCommand(sql, conexion);
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Proveedor p = new Proveedor
                    {
                        PROVEEDORID = lector.GetInt32(0),
                        NOMBREPROVEEDOR = lector.GetString(1),
                        TELEFONO = lector.IsDBNull(2) ? string.Empty : lector.GetString(2),
                        CORREOELECTRONIC = lector.IsDBNull(3) ? string.Empty : lector.GetString(3)
                    };
                    lista.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener proveedores: " + ex.Message);
            }
            finally
            {
                if (lector != null) lector.Close();
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return lista;
        }

        
        public int InsertarProveedor(Proveedor proveedor)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();

        
                string query = @"
                    INSERT INTO PROVEEDORES (PROVEEDORID, NOMBREPROVEEDOR, TELEFONO, CORREOELECTRONIC) 
                    VALUES (@ID, @Nombre, @Telefono, @Correo)";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@ID", proveedor.PROVEEDORID);
                comando.Parameters.AddWithValue("@Nombre", proveedor.NOMBREPROVEEDOR);
                comando.Parameters.AddWithValue("@Telefono", (object)proveedor.TELEFONO ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Correo", (object)proveedor.CORREOELECTRONIC ?? DBNull.Value);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar proveedor: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }
        public int ActualizarProveedor(Proveedor proveedor)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();

                
                string sql = @"
                    UPDATE PROVEEDORES SET 
                        NOMBREPROVEEDOR = @Nombre, TELEFONO = @Telefono, CORREOELECTRONIC = @Correo 
                    WHERE PROVEEDORID = @ID";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", proveedor.PROVEEDORID);
                comando.Parameters.AddWithValue("@Nombre", proveedor.NOMBREPROVEEDOR);
                comando.Parameters.AddWithValue("@Telefono", (object)proveedor.TELEFONO ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Correo", (object)proveedor.CORREOELECTRONIC ?? DBNull.Value);
                

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar proveedor: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }

        
        public int EliminarProveedor(int proveedorID)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();
                string sql = "DELETE FROM PROVEEDORES WHERE PROVEEDORID = @ID";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", proveedorID);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }
    }
}