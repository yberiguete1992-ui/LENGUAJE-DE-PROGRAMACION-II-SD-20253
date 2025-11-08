using System;
using System.Windows.Forms;
using System.Linq;
using PRACTICA_3_YEISON_BERIGUETE;


namespace PRACTICA_3_YEISONYBD
{
    public partial class FormCategorias : Form
    {
        
        public FormCategorias()
        {
            InitializeComponent();

            botonguardarcat.Click += botonguardar_Click;
            botonactualizarcat.Click += botonactualizar_Click;
            botoneliminarcat.Click += botoneliminar_Click;
            datagridviewcategorias.CellClick += dataGridViewCategorias_CellClick;

            textidcategoria.Visible = false;

            CargarCategorias();
            LimpiarCampos();
        }

        private void CargarCategorias()
        {
            try
            {
                using (var db = new MINIMARKET_YEISONYBDEntities())
                {
                   
                    db.Configuration.LazyLoadingEnabled = false;
                    datagridviewcategorias.DataSource = db.CATEGORIAS.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error de Base de Datos");
            }
        }

        private void botonguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textnombrecategoria.Text))
            {
                MessageBox.Show("El nombre de la categoría es obligatorio.", "Validación");
                return;
            }
            using (var db = new MINIMARKET_YEISONYBDEntities())
            {
                try
                {
                    CATEGORIA nuevaCategoria = new CATEGORIA
                    {
                        NOMBRECATEGORIA = textnombrecategoria.Text 
                    };
                    db.CATEGORIAS.Add(nuevaCategoria);
                    db.SaveChanges();

                    MessageBox.Show("Categoría guardada.", "Éxito");
                    CargarCategorias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la categoría: " + ex.Message, "Error");
                }
            }
        }

        private void botonactualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textidcategoria.Text, out int idCategoria)) return; 

            using (var db = new MINIMARKET_YEISONYBDEntities())
            {
                try
                {
                    var categoriaActualizar = db.CATEGORIAS.FirstOrDefault(c => c.CATEGORIAID == idCategoria);
                    if (categoriaActualizar != null)
                    {
                        categoriaActualizar.NOMBRECATEGORIA = textnombrecategoria.Text;
                        db.SaveChanges();

                        MessageBox.Show("Categoría actualizada.", "Éxito");
                        CargarCategorias();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la categoría: " + ex.Message, "Error");
                }
            }
        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textidcategoria.Text, out int idCategoria)) return;

            if (MessageBox.Show("¿Seguro que desea eliminar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new MINIMARKET_YEISONYBDEntities())
                {
                    try
                    {
                        var categoriaEliminar = db.CATEGORIAS.FirstOrDefault(c => c.CATEGORIAID == idCategoria);
                        if (categoriaEliminar != null)
                        {
                            db.CATEGORIAS.Remove(categoriaEliminar);
                            db.SaveChanges();
                            MessageBox.Show("Categoría eliminada.", "Éxito");
                            CargarCategorias();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la categoría: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            textidcategoria.Text = string.Empty;
            textnombrecategoria.Text = string.Empty;

            botonguardarcat.Enabled = true;
            botonactualizarcat.Enabled = false;
            botoneliminarcat.Enabled = false;
        }

        private void dataGridViewCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagridviewcategorias.Rows[e.RowIndex];
                textidcategoria.Text = row.Cells["CATEGORIAID"].Value?.ToString();
                textnombrecategoria.Text = row.Cells["NOMBRECATEGORIA"].Value?.ToString();

                botonguardarcat.Enabled = false;
                botonactualizarcat.Enabled = true;
                botoneliminarcat.Enabled = true;
            }
        }
      
    }
}