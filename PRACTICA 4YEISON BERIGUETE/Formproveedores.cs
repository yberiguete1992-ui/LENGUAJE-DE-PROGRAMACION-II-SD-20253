using System;
using System.Windows.Forms;
using System.Linq;
using PRACTICA_3_YEISON_BERIGUETE;

namespace PRACTICA_3_YEISON_BERIGUETE
{
    public partial class FormProveedores : Form
    {
      
        public FormProveedores()
        {
            InitializeComponent();

      
            botonguardarprov.Click += botonguardar_Click;
            botonactualizarprov.Click += botonactualizar_Click;
            botoneliminarprov.Click += botoneliminar_Click;
            datagridviewproveedores.CellClick += dataGridViewProveedores_CellClick;

            textidproveedor.Visible = false;
            CargarProveedores();
            LimpiarCampos();
        }

        private void CargarProveedores()
        {
            try
            {
                using (var db = new MINIMARKET_YEISONYBDEntities())
                {
                    
                    db.Configuration.LazyLoadingEnabled = false;
                    datagridviewproveedores.DataSource = db.PROVEEDORES.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error de Base de Datos");
            }
        }

        private void botonguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textnombreprov.Text)) return;

           
            using (var db = new MINIMARKET_YEISONYBDEntities())
            {
                try
                {
                    PROVEEDORE nuevoProveedor = new PROVEEDORE
                    {
                     
                        NOMBREPROVEEDOR = textnombreprov.Text,
                        TELEFONO = texttelefonoprov.Text,
                        CORREOELECTRONIC = textidproveedor.Text
                    };
                    db.PROVEEDORES.Add(nuevoProveedor);
                    db.SaveChanges();
                    MessageBox.Show("Proveedor guardado.", "Éxito");
                    CargarProveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el proveedor: " + ex.Message, "Error");
                }
            }
        }

        private void botonactualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textidproveedor.Text, out int idProveedor)) return;

         
            using (var db = new MINIMARKET_YEISONYBDEntities())
            {
                try
                {
                    var proveedorActualizar = db.PROVEEDORES.FirstOrDefault(p => p.PROVEEDORID == idProveedor);
                    if (proveedorActualizar != null)
                    {
                        
                        proveedorActualizar.NOMBREPROVEEDOR = textnombreprov.Text;
                        proveedorActualizar.TELEFONO = texttelefonoprov.Text;
                        proveedorActualizar.CORREOELECTRONIC = textcorreoprov.Text;

                        db.SaveChanges();
                        MessageBox.Show("Proveedor actualizado.", "Éxito");
                        CargarProveedores();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el proveedor: " + ex.Message, "Error");
                }
            }
        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textidproveedor.Text, out int idProveedor)) return;

            if (MessageBox.Show("¿Seguro que desea eliminar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                using (var db = new MINIMARKET_YEISONYBDEntities())
                {
                    try
                    {
                        var proveedorEliminar = db.PROVEEDORES.FirstOrDefault(p => p.PROVEEDORID == idProveedor);
                        if (proveedorEliminar != null)
                        {
                            db.PROVEEDORES.Remove(proveedorEliminar);
                            db.SaveChanges();
                            MessageBox.Show("Proveedor eliminado.", "Éxito");
                            CargarProveedores();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el proveedor: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            textidproveedor.Text = string.Empty;
            textnombreprov.Text = string.Empty;
           
            texttelefonoprov.Text = string.Empty;
            textcorreoprov.Text = string.Empty; 

            botonguardarprov.Enabled = true;
            botonactualizarprov.Enabled = false;
            botoneliminarprov.Enabled = false;
        }

        private void dataGridViewProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagridviewproveedores.Rows[e.RowIndex];

                textidproveedor.Text = row.Cells["PROVEEDORID"].Value?.ToString();
                textnombreprov.Text = row.Cells["NOMBREPROVEEDOR"].Value?.ToString();
                texttelefonoprov.Text = row.Cells["TELEFONO"].Value?.ToString();
                textcorreoprov.Text = row.Cells["CORREOELECTRONIC"].Value?.ToString();

                botonguardarprov.Enabled = false;
                botonactualizarprov.Enabled = true;
                botoneliminarprov.Enabled = true;
            }
        }
    }
}