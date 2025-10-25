using System;
using System.Windows.Forms;
using PRACTICA_3_YEISON_BERIGUETE.AccesoADatos;
using PRACTICA_3_YEISON_BERIGUETE.Modelos;

namespace PRACTICA_3_YEISON_BERIGUETE
{
    public partial class FormProductos : Form
    {
        private Productoad productoad = new Productoad();
        private Categoriaad categoriaad = new Categoriaad();
        

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            
            CargarCategorias();
            CargarDatos();
            LimpiarCampos();
        }

        private void CargarDatos()
        {
            var productos = productoad.ObtenerProductos();

            
            datagridviewproductos.DataSource = productos;

            datagridviewproductos.Refresh();

            if (productos.Count == 0)
            {
                MessageBox.Show("La lista de productos está vacía. Confirme que la tabla PRODUCTOS tiene datos.", "Diagnóstico");
            }
        
        }

        private void CargarCategorias()
        {
            try
            {
               
                cboxcategoria.DataSource = categoriaad.ObtenerCategorias();
                cboxcategoria.DisplayMember = "Nombrecategoria"; 
                cboxcategoria.ValueMember = "CategoriaID";       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error");
            }
        }

        private void LimpiarCampos()
        {
            textidproducto.Text = productoad.ObtenerSiguienteID().ToString();
            textnombreprod.Clear();
            textdescripcioprod.Clear();
            textprecioprod.Clear();
            textstockprod.Clear();
            cboxcategoria.SelectedIndex = -1; 
            botonactualizarprod.Enabled = false;
            botoneliminarprod.Enabled = false;
            botonguardarprod.Enabled = true;
        }

        private void datagridviewproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagridviewproductos.Rows[e.RowIndex];
                textidproducto.Text = row.Cells["PRODUCTOID"].Value?.ToString();
                textnombreprod.Text = row.Cells["NombreProducto"].Value?.ToString(); 
                textdescripcioprod.Text = row.Cells["Descripcion"].Value?.ToString();
                textprecioprod.Text = row.Cells["Precio"].Value?.ToString();
                textstockprod.Text = row.Cells["Stock"].Value?.ToString();

                
                if (row.Cells["CategoriaID"].Value != DBNull.Value)
                    cboxcategoria.SelectedValue = Convert.ToInt32(row.Cells["CategoriaID"].Value);

                botonactualizarprod.Enabled = true;
                botoneliminarprod.Enabled = true;
                botonguardarprod.Enabled = false;
            }
        }

        private void botonguardarprod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textnombreprod.Text) || string.IsNullOrWhiteSpace(textprecioprod.Text) || cboxcategoria.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Nombre, Precio y Categoría).", "Advertencia");
                return;
            }

            try
            {
                Producto nuevoProducto = new Producto
                {
                    ProductoID = Convert.ToInt32(textidproducto.Text),
                    NombreProducto = textnombreprod.Text,
                    Descripcion = textdescripcioprod.Text,
                    Precio = Convert.ToDecimal(textprecioprod.Text),
                    Stock = Convert.ToInt32(textstockprod.Text),
                    CategoriaID = Convert.ToInt32(cboxcategoria.SelectedValue)
            
                };

                int resultado = productoad.InsertarProducto(nuevoProducto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto guardado correctamente.", "Éxito");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error");
            }
        }

        private void botonactualizarprod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textidproducto.Text))
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Advertencia");
                return;
            }

            try
            {
                Producto productoActualizar = new Producto
                {
                    ProductoID = Convert.ToInt32(textidproducto.Text),
                    NombreProducto = textnombreprod.Text,
                    Descripcion = textdescripcioprod.Text,
                    Precio = Convert.ToDecimal(textprecioprod.Text),
                    Stock = Convert.ToInt32(textstockprod.Text),
                    CategoriaID = Convert.ToInt32(cboxcategoria.SelectedValue)
                };

                int resultado = productoad.ActualizarProducto(productoActualizar);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito");
                    CargarDatos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error");
            }
        }

        private void botoneliminarprod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textidproducto.Text))
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia");
                return;
            }

            if (MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int productoID = Convert.ToInt32(textidproducto.Text);
                    int resultado = productoad.EliminarProducto(productoID);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente.", "Éxito");
                        CargarDatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error");
                }
            }
        }

        private void botonlimpiarprod_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void datagridviewproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}