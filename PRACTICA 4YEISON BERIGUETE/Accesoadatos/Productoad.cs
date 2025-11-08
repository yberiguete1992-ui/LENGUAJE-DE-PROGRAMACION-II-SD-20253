using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using PRACTICA_3_YEISON_BERIGUETE.Modelos;

namespace PRACTICA_3_YEISON_BERIGUETE.AccesoADatos
{
    public class Productoad
    {
        
        public int ObtenerSiguienteID()
        {
            int siguienteID = 1;
            SqlConnection conexion = Conexionbasededatos.AbrirConexion();
            string query = "SELECT MAX(ProductoID) FROM PRODUCTOS";
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
                MessageBox.Show("Error al obtener el siguiente ID del producto: " + ex.Message, "Error de BD");
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

    
        public List<Producto> ObtenerProductos()
        {
            List<Producto> lista = new List<Producto>();
            SqlConnection conexion = null;
            SqlDataReader lector = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();

                string sql = @"
                   SELECT 
                       P.PRODUCTOID,                  
                       P.NOMBREPRODUCTO AS NombreProducto, 
                       P.DESCRIPCION,                 
                       P.PRECIO,                      
                       P.Stock,                       
                       P.CATEGORIAID AS CategoriaID,       
                       C.NOMBRECATEGORIA AS NombreCategoria, 
                       NULL AS ProveedorID,                
                       NULL AS NombreProveedor  

                   FROM 
                       PRODUCTOS P
                   LEFT JOIN  
                       CATEGORIAS C ON P.CATEGORIAID = C.CATEGORIAID";

                SqlCommand comando = new SqlCommand(sql, conexion);
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Producto p = new Producto
                    {
                        ProductoID = (int)lector["PRODUCTOID"],
                        NombreProducto = lector["NombreProducto"].ToString(),
                        Descripcion = lector["DESCRIPCION"] == DBNull.Value ? string.Empty : lector["DESCRIPCION"].ToString(),
                        Precio = (decimal)lector["PRECIO"],
                        Stock = (int)lector["Stock"],


                        CategoriaID = lector["CategoriaID"] == DBNull.Value ? 0 : (int)lector["CategoriaID"],
                        NombreCategoria = lector["NombreCategoria"] == DBNull.Value ? string.Empty : lector["NombreCategoria"].ToString(),


                        ProveedorID = lector["ProveedorID"] == DBNull.Value ? 0 : (int)lector["ProveedorID"],
                        NombreProveedor = lector["NombreProveedor"] == DBNull.Value ? string.Empty : lector["NombreProveedor"].ToString()
                    };
                    lista.Add(p);
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Error al obtener productos: " + ex.Message);
            }
            finally
            {
                if (lector != null) lector.Close();
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return lista;
        }

        
        public int InsertarProducto(Producto producto)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();

                string query = @"
                    INSERT INTO PRODUCTOS (PRODUCTOID, NOMBREPRODUCTO, DESCRIPCION, PRECIO, Stock, CATEGORIAID) 
                    VALUES (@ID, @Nombre, @Descripcion, @Precio, @Stock, @CatID)";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@ID", producto.ProductoID);
                comando.Parameters.AddWithValue("@Nombre", producto.NombreProducto);
                comando.Parameters.AddWithValue("@Descripcion", (object)producto.Descripcion ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@Stock", producto.Stock);
                comando.Parameters.AddWithValue("@CatID", producto.CategoriaID);
               

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar producto: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }

        
        public int ActualizarProducto(Producto producto)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();

               
                string sql = @"
                    UPDATE PRODUCTOS SET 
                        NOMBREPRODUCTO = @Nombre, DESCRIPCION = @Descripcion, PRECIO = @Precio, Stock = @Stock, 
                        CATEGORIAID = @CatID
                    WHERE PRODUCTOID = @ID";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Nombre", producto.NombreProducto);
                comando.Parameters.AddWithValue("@Descripcion", (object)producto.Descripcion ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@Stock", producto.Stock);
                comando.Parameters.AddWithValue("@CatID", producto.CategoriaID);
               
                comando.Parameters.AddWithValue("@ID", producto.ProductoID);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }

        public int EliminarProducto(int productoID)
        {
            int filasAfectadas = 0;
            SqlConnection conexion = null;

            try
            {
                conexion = Conexionbasededatos.AbrirConexion();
                string sql = "DELETE FROM PRODUCTOS WHERE ProductoID = @ID";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", productoID);

                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
            finally
            {
                Conexionbasededatos.CerrarConexion(conexion);
            }
            return filasAfectadas;
        }
    }
}