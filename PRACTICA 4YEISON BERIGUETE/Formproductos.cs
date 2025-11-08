using System;
using System.Windows.Forms;
using System.Linq;
using PRACTICA_3_YEISON_BERIGUETE;
using System.Data.Entity; 
namespace PRACTICA_3_YEISON_BERIGUETE
{
    public partial class FormProductos : Form
    {
       
        public FormProductos()
        {
            InitializeComponent();

            botonguardarprod.Click += botonguardar_Click;
            botonactualizarprod.Click += botonactualizar_Click;
            botoneliminarprod.Click += botoneliminar_Click;
            datagridviewproductos.CellClick += dataGridViewProductos_CellClick;

            textidproducto.Visible = false;

            CargarCategoriasComboBox();
            CargarProductos();
            LimpiarCampos();
        }

        private void CargarCategoriasComboBox()
        {
            using (var db = new MINIMARKET_YEISONYBDEntities())
            {
                var categorias = db.CATEGORIAS.Select(c => new
                {
                    c.CATEGORIAID,
                    c.NOMBRECATEGORIA
                }).ToList();

                cboxcategoria.DataSource = categorias;
                cboxcategoria.DisplayMember = "NOMBRECATEGORIA";
                cboxcategoria.ValueMember = "CATEGORIAID";

                cboxcategoria.SelectedIndex = -1;
            }
        }

        private void CargarProductos()
        {
            try
            {
                using (var db = new MINIMARKET_YEISONYBDEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;

                    datagridviewproductos.DataSource = db.PRODUCTOS
                        .Include(p => p.CATEGORIA)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error de Base de Datos");
            }
        }

        
        private void botonguardar_Click(object sender, EventArgs e)
        {
          
            if (!decimal.TryParse(textprecioprod.Text, out decimal precio) ||
                !int.TryParse(textstockprod.Text, out int stock) ||
                cboxcategoria.SelectedValue == null)
            {
                MessageBox.Show("Verifique el precio, stock y la categoría.", "Validación");
                return;
            }

            
            using (var db = new MINIMARKET_YEISONYBDEntities())
            {
                try
                {
                    PRODUCTO nuevoProducto = new PRODUCTO
                    {
                   
                        NOMBREPRODUCTO = textnombreprod.Text,
                     
                        DESCRIPCION = textdescripcioprod.Text,
                        PRECIO = precio,
                        Stock = stock,
                        CATEGORIAID = (int)cboxcategoria.SelectedValue
                    };
                    db.PRODUCTOS.Add(nuevoProducto);
                    db.SaveChanges();

                    MessageBox.Show("Producto guardado.", "Éxito");
                    CargarProductos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error");
                }
            }
        }

        private void botonactualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textidproducto.Text, out int idProducto) ||
                !decimal.TryParse(textprecioprod.Text, out decimal precio) ||
                !int.TryParse(textstockprod.Text, out int stock) || 
                cboxcategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto y verifique los datos.", "Validación");
                return;
            }

       
            using (var db = new MINIMARKET_YEISONYBDEntities())
            {
                try
                {
                    var productoActualizar = db.PRODUCTOS.FirstOrDefault(p => p.PRODUCTOID == idProducto);
                    if (productoActualizar != null)
                    {
                      
                        productoActualizar.NOMBREPRODUCTO = textnombreprod.Text;
                        productoActualizar.DESCRIPCION = textdescripcioprod.Text;
                        productoActualizar.PRECIO = precio;
                        productoActualizar.Stock = stock;
                        productoActualizar.CATEGORIAID = (int)cboxcategoria.SelectedValue;

                        db.SaveChanges();

                        MessageBox.Show("Producto actualizado.", "Éxito");
                        CargarProductos();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error");
                }
            }
        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textidproducto.Text, out int idProducto)) return;

            if (MessageBox.Show("¿Seguro que desea eliminar el producto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new MINIMARKET_YEISONYBDEntities())
                {
                    try
                    {
                        var productoEliminar = db.PRODUCTOS.FirstOrDefault(p => p.PRODUCTOID == idProducto);
                        if (productoEliminar != null)
                        {
                            db.PRODUCTOS.Remove(productoEliminar);
                            db.SaveChanges();
                            MessageBox.Show("Producto eliminado.", "Éxito");
                            CargarProductos();
                            LimpiarCampos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            textidproducto.Text = string.Empty;
            textnombreprod.Text = string.Empty;
            textdescripcioprod.Text = string.Empty; 
            textprecioprod.Text = string.Empty;
            textstockprod.Text = string.Empty;
            cboxcategoria.SelectedIndex = -1;

            botonguardarprod.Enabled = true;
            botonactualizarprod.Enabled = false;
            botoneliminarprod.Enabled = false;
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagridviewproductos.Rows[e.RowIndex];

                textidproducto.Text = row.Cells["PRODUCTOID"].Value?.ToString();
               
                textnombreprod.Text = row.Cells["NOMBREPRODUCTO"].Value?.ToString();
                
                textdescripcioprod.Text = row.Cells["DESCRIPCION"].Value?.ToString();
                textprecioprod.Text = row.Cells["PRECIO"].Value?.ToString();
            
                textstockprod.Text = row.Cells["Stock"].Value?.ToString();
                if (row.Cells["CATEGORIAID"].Value != DBNull.Value)
                {
                    int categoriaId = (int)row.Cells["CATEGORIAID"].Value;
                    cboxcategoria.SelectedValue = categoriaId;
                }

                botonguardarprod.Enabled = false;
                botonactualizarprod.Enabled = true;
                botoneliminarprod.Enabled = true;
            }
        }
    }
}