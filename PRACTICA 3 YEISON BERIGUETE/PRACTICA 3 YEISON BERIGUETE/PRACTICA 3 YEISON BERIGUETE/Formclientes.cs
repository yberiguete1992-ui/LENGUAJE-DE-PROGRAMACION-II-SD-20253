using System;
using System.Windows.Forms;
using PRACTICA_3_YEISON_BERIGUETE.AccesoADatos;
using PRACTICA_3_YEISON_BERIGUETE.Modelos;

namespace PRACTICA_3_YEISON_BERIGUETE
{
    public partial class FormClientes : Form
    {
        
        private Clientead clientead = new Clientead();

        public FormClientes()
        {
            InitializeComponent();

            
            botonguardar.Click += botonguardar_Click;
            botonactualizar.Click += botonactualizar_Click;
            botoneliminar.Click += botoneliminar_Click;
            botonlimpiar.Click += botonlimpiar_Click;
            datagridviewclientes.CellClick += datagridviewclientes_CellClick;

            
            textidcliente.Visible = false;
            CargarClientes();
        }


        private void CargarClientes()
        {
            try
            {
               
                datagridviewclientes.DataSource = clientead.ObtenerClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error de Base de Datos");
            }
        }

        private void LimpiarCampos()
        {
            textidcliente.Text = string.Empty;
            textnombre.Text = string.Empty;
            textcorreo.Text = string.Empty;
            texttelefono.Text = string.Empty;
            textdireccion.Text = string.Empty;

            
            botonguardar.Enabled = true;
            botonactualizar.Enabled = false;
            botoneliminar.Enabled = false;
        }

      

        private void datagridviewclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagridviewclientes.Rows[e.RowIndex];

                
                textidcliente.Text = row.Cells["ClienteID"].Value?.ToString();
                textnombre.Text = row.Cells["NombreCompleto"].Value?.ToString();
                textcorreo.Text = row.Cells["CorreoElectronico"].Value?.ToString();
                texttelefono.Text = row.Cells["Telefono"].Value?.ToString();
                textdireccion.Text = row.Cells["Direccion"].Value?.ToString();

               
                botonguardar.Enabled = false;
                botonactualizar.Enabled = true;
                botoneliminar.Enabled = true;
            }
        }

private void botonguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textnombre.Text))
            {
                MessageBox.Show("El nombre del cliente es obligatorio.", "Validación");
                return;
            }

            
            int nuevoID = clientead.ObtenerSiguienteID();
            if (nuevoID <= 0) return; 

            
            Cliente nuevoCliente = new Cliente
            {
                ClienteID = nuevoID, 
                NombreCompleto = textnombre.Text,
                CorreoElectronico = textcorreo.Text,
                Telefono = texttelefono.Text,
                Direccion = textdireccion.Text
            };

            
            if (clientead.InsertarCliente(nuevoCliente) > 0)
            {
                MessageBox.Show("Cliente guardado exitosamente.", "Éxito");
                CargarClientes();
            }
            else
            {
                MessageBox.Show("Error al guardar el cliente.", "Error");
            }
        }

        private void botonactualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textidcliente.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente para actualizar.", "Error");
                return;
            }

            
            Cliente clienteActualizado = new Cliente
            {
                ClienteID = int.Parse(textidcliente.Text),
                NombreCompleto = textnombre.Text,
                CorreoElectronico = textcorreo.Text,
                Telefono = texttelefono.Text,
                Direccion = textdireccion.Text
            };

            
            if (clientead.ActualizarCliente(clienteActualizado) > 0)
            {
                MessageBox.Show("Cliente actualizado exitosamente.", "Éxito");
                CargarClientes();
            }
        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textidcliente.Text)) return;

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(textidcliente.Text);

                
                if (clientead.EliminarCliente(id) > 0)
                {
                    MessageBox.Show("Cliente eliminado.", "Éxito");
                    CargarClientes();
                }
            }
        }

        private void botonlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}