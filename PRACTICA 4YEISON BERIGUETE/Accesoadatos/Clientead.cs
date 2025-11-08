using System;
using System.Data; 
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using PRACTICA_3_YEISON_BERIGUETE.Modelos;

namespace PRACTICA_3_YEISON_BERIGUETE.AccesoADatos
{
    public class Clientead
    {
       
        public int ObtenerSiguienteID()
        {
            int siguienteID = 1;
            SqlConnection conexion = Conexionbasededatos.AbrirConexion();

            string query = "SELECT MAX(CLIENTEID) FROM CLIENTES";

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
                MessageBox.Show("Error al obtener el siguiente ID: " + ex.Message, "Error de BD");
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

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conexion = null;
            SqlDataReader lector = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();
                string sql = "SELECT ClienteID, NombreCompleto, CorreoElectronico, Telefono, Direccion FROM CLIENTES";
                SqlCommand comando = new SqlCommand(sql, conexion);
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente c = new Cliente
                    {
                        ClienteID = lector.GetInt32(0),
                        NombreCompleto = lector.GetString(1),
                        
                        CorreoElectronico = lector.IsDBNull(2) ? null : lector.GetString(2),
                        Telefono = lector.IsDBNull(3) ? null : lector.GetString(3),
                        Direccion = lector.IsDBNull(4) ? null : lector.GetString(4)
                    };
                    lista.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener clientes: " + ex.Message);
            }
            finally
            {
                if (lector != null) lector.Close();
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return lista;
        }

        public int InsertarCliente(Cliente cliente)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();

                
                string query = "INSERT INTO CLIENTES (CLIENTEID, NOMBRECOMPLETO, CORREOELECTRONICO, TELEFONO, DIRECCION) " +
                               "VALUES (@ClienteID, @Nombre, @Correo, @Telefono, @Direccion)";

                SqlCommand comando = new SqlCommand(query, conexion);

               
                comando.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);

                
                comando.Parameters.AddWithValue("@Nombre", cliente.NombreCompleto);
                comando.Parameters.AddWithValue("@Correo", (object)cliente.CorreoElectronico ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Telefono", (object)cliente.Telefono ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Direccion", (object)cliente.Direccion ?? DBNull.Value);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cliente: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }

        public int ActualizarCliente(Cliente cliente)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();
                string sql = "UPDATE CLIENTES SET NombreCompleto = @Nombre, CorreoElectronico = @Correo, Telefono = @Telefono, Direccion = @Direccion WHERE ClienteID = @ID";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Nombre", cliente.NombreCompleto);
                comando.Parameters.AddWithValue("@Correo", (object)cliente.CorreoElectronico ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Telefono", (object)cliente.Telefono ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Direccion", (object)cliente.Direccion ?? DBNull.Value);
                comando.Parameters.AddWithValue("@ID", cliente.ClienteID);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cliente: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }

        public int EliminarCliente(int clienteID)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();
                string sql = "DELETE FROM CLIENTES WHERE ClienteID = @ID";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", clienteID);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }
    }
}