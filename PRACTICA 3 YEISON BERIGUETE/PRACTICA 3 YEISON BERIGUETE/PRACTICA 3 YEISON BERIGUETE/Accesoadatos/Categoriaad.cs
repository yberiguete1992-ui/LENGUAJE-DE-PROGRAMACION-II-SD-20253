using PRACTICA_3_YEISON_BERIGUETE.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRACTICA_3_YEISON_BERIGUETE.AccesoADatos
{
    public class Categoriaad
    {
      
        public int ObtenerSiguienteID()
        {
            int siguienteID = 1;
            SqlConnection conexion = Conexionbasededatos.AbrirConexion();
            string query = "SELECT MAX(CategoriaID) FROM CATEGORIAS";
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
                MessageBox.Show("Error al obtener el siguiente ID de la categoría: " + ex.Message, "Error de BD");
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

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            SqlConnection conexion = null;
            SqlDataReader lector = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();
               
                string sql = "SELECT CATEGORIAID, NOMBRECATEGORIA AS Nombrecategoria FROM CATEGORIAS";
                SqlCommand comando = new SqlCommand(sql, conexion);
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria c = new Categoria
                    {
                        CategoriaID = lector.GetInt32(0),
                        Nombrecategoria = lector.GetString(1) 
                    };
                    lista.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener categorías: " + ex.Message);
            }
            finally
            {
                if (lector != null) lector.Close();
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return lista;
        }
        public int InsertarCategoria(Categoria categoria)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();
                string query = "INSERT INTO CATEGORIAS (CATEGORIAID, NOMBRECATEGORIA) VALUES (@ID, @Nombre)";
                SqlCommand comando = new SqlCommand(query, conexion);

                
                comando.Parameters.AddWithValue("@ID", categoria.CategoriaID);
                comando.Parameters.AddWithValue("@Nombre", categoria.Nombrecategoria);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar categoría: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }

        public int ActualizarCategoria(Categoria categoria)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();
                
                string sql = "UPDATE CATEGORIAS SET NOMBRECATEGORIA = @Nombre WHERE CATEGORIAID = @ID";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Nombre", categoria.Nombrecategoria);
                comando.Parameters.AddWithValue("@ID", categoria.CategoriaID);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar categoría: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }
        public int EliminarCategoria(int categoriaID)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();
                string sql = "DELETE FROM CATEGORIAS WHERE CategoriaID = @ID";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", categoriaID);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar categoría: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }
    }
}