using System;
using System.Windows.Forms;
using PRACTICA_3_YEISON_BERIGUETE.AccesoADatos;
using PRACTICA_3_YEISON_BERIGUETE.Modelos;

namespace PRACTICA_3_YEISON_BERIGUETE
{
    public partial class FormCategorias : Form
    {
        private Categoriaad categoriaad = new Categoriaad();

        public FormCategorias()
        {
            InitializeComponent();


          
            textidcategoria.Visible = false;
            CargarCategorias();

            
            botonguardarcat.Click += botonguardarcat_Click;
            botonactualizarcat.Click += botonactualizarcat_Click;
            botoneliminarcat.Click += botoneliminarcat_Click;
            botonlimpiarcat.Click += botonlimpiarcat_Click;


            datagridviewcategorias.CellClick += datagridviewcategorias_CellClick;

          

        }

        

        private void CargarCategorias()
        {
            try
            {
                datagridviewcategorias.DataSource = categoriaad.ObtenerCategorias();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error de Base de Datos");
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

        private void datagridviewcategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagridviewcategorias.Rows[e.RowIndex];
                textidcategoria.Text = row.Cells["CategoriaID"].Value?.ToString();
                textnombrecategoria.Text = row.Cells["Nombrecategoria"].Value?.ToString();

                
                botonguardarcat.Enabled = false;
                botonactualizarcat.Enabled = true;
                botoneliminarcat.Enabled = true;
            }
        }

        private void botonguardarcat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textnombrecategoria.Text))
            {
                MessageBox.Show("El nombre de la categoría es obligatorio.", "Validación");
                return;
            }

        
            int nuevoID = categoriaad.ObtenerSiguienteID();
            if (nuevoID <= 0) return;

           
            Categoria nuevaCategoria = new Categoria
            {
                CategoriaID = nuevoID,
                Nombrecategoria = textnombrecategoria.Text
            };

            
            if (categoriaad.InsertarCategoria(nuevaCategoria) > 0)
            {
                MessageBox.Show("Categoría guardada exitosamente.", "Éxito");
                CargarCategorias();
            }
            else
            {
                MessageBox.Show("Error al guardar la categoría.", "Error");
            }
        }

        private void botonactualizarcat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textidcategoria.Text))
            {
                MessageBox.Show("Debe seleccionar una categoría para actualizar.", "Error");
                return;
            }

            Categoria categoriaActualizada = new Categoria
            {
                CategoriaID = int.Parse(textidcategoria.Text),
                Nombrecategoria= textnombrecategoria.Text
            };

            if (categoriaad.ActualizarCategoria(categoriaActualizada) > 0)
            {
                MessageBox.Show("Categoría actualizada exitosamente.", "Éxito");
                CargarCategorias();
            }
        }

        private void botoneliminarcat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textidcategoria.Text)) return;

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar esta categoría?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(textidcategoria.Text);

                if (categoriaad.EliminarCategoria(id) > 0)
                {
                    MessageBox.Show("Categoría eliminada.", "Éxito");
                    CargarCategorias();
                }
            }
        }

        private void botonlimpiarcat_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}