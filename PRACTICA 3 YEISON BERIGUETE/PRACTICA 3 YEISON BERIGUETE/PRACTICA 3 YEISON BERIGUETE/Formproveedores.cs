using System;
using System.Windows.Forms;
using PRACTICA_3_YEISON_BERIGUETE.AccesoADatos;
using PRACTICA_3_YEISON_BERIGUETE.Modelos;

namespace PRACTICA_3_YEISON_BERIGUETE
{
    public partial class FormProveedores : Form
    {
        private Proveedorad proveedorDAL = new Proveedorad();

        public FormProveedores()
        {
            InitializeComponent();

           
            textidproveedor.Visible = false;
            CargarProveedores();

            
            botonguardarprov.Click += botonguardarprov_Click;
            botonactualizarprov.Click += botonactualizarprov_Click;
            botoneliminarprov.Click += botoneliminarprov_Click;
            botonlimpiarprov.Click += botonlimpiarprov_Click;

            
            datagridviewproveedores.CellClick += datagridviewproveedores_CellClick;
        }


        private void CargarProveedores()
        {
            try
            {
                datagridviewproveedores.DataSource = proveedorDAL.ObtenerProveedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error de Base de Datos");
            }
        }

        private void LimpiarCampos()
        {
            textidproveedor.Text = string.Empty;
            textnombreprov.Text = string.Empty;
            textcorreoprov.Text = string.Empty;
            texttelefonoprov.Text = string.Empty;
           
            botonguardarprov.Enabled = true;
            botonactualizarprov.Enabled = false;
            botoneliminarprov.Enabled = false;
        }


        private void datagridviewproveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagridviewproveedores.Rows[e.RowIndex];

             
                textidproveedor.Text = row.Cells["ProveedorID"].Value?.ToString();
                textnombreprov.Text = row.Cells["NombreProveedor"].Value?.ToString();
                textcorreoprov.Text = row.Cells["CorreoElectronic"].Value?.ToString();
                texttelefonoprov.Text = row.Cells["Telefono"].Value?.ToString();
                botonguardarprov.Enabled = false;
                botonactualizarprov.Enabled = true;
                botoneliminarprov.Enabled = true;
            }
        }

        private void botonguardarprov_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textnombreprov.Text))
            {
                MessageBox.Show("El nombre del proveedor es obligatorio.", "Validación");
                return;
            }

            
            int nuevoID = proveedorDAL.ObtenerSiguienteID();
            if (nuevoID <= 0) return;

          
            Proveedor nuevoProveedor = new Proveedor
            {
                PROVEEDORID = nuevoID,
                NOMBREPROVEEDOR = textnombreprov.Text,
                CORREOELECTRONIC = textcorreoprov.Text,
                TELEFONO = texttelefonoprov.Text,
                
            };

           
            if (proveedorDAL.InsertarProveedor(nuevoProveedor) > 0)
            {
                MessageBox.Show("Proveedor guardado exitosamente.", "Éxito");
                CargarProveedores();
            }
            else
            {
                MessageBox.Show("Error al guardar el proveedor.", "Error");
            }
        }

        private void botonactualizarprov_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textidproveedor.Text))
            {
                MessageBox.Show("Debe seleccionar un proveedor para actualizar.", "Error");
                return;
            }

            Proveedor proveedorActualizado = new Proveedor
            {
                PROVEEDORID = int.Parse(textidproveedor.Text),
                NOMBREPROVEEDOR = textnombreprov.Text,
                CORREOELECTRONIC = textcorreoprov.Text,
                TELEFONO = texttelefonoprov.Text,
               
            };

            if (proveedorDAL.ActualizarProveedor(proveedorActualizado) > 0)
            {
                MessageBox.Show("Proveedor actualizado exitosamente.", "Éxito");
                CargarProveedores();
            }
        }

        private void botoneliminarprov_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textidproveedor.Text)) return;

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar este proveedor?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(textidproveedor.Text);

                if (proveedorDAL.EliminarProveedor(id) > 0)
                {
                    MessageBox.Show("Proveedor eliminado.", "Éxito");
                    CargarProveedores();
                }
            }
        }

        private void botonlimpiarprov_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}