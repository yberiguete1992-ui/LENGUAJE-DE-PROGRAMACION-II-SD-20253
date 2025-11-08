using System;
using System.Windows.Forms;
using System.Linq;
using PRACTICA_3_YEISON_BERIGUETE; 


namespace PRACTICA_3_YEISON_BERIGUETE
{
    public partial class FormClientes : Form
    {
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
                using (var db = new MINIMARKET_YEISONYBDEntities())
                {
                    
                    datagridviewclientes.DataSource = db.CLIENTES.ToList();
                }
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes con ORM: " + ex.Message, "Error de Base de Datos");
            }
        }

        private void botonguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textnombre.Text))
            {
                MessageBox.Show("El nombre del cliente es obligatorio.", "Validación");
                return;
            }

            
            using (var db = new MINIMARKET_YEISONYBDEntities())
            {
                try
                {
                   
                    CLIENTE nuevoCliente = new CLIENTE
                    {
                        NOMBRECOMPLETO = textnombre.Text,
                        CORREOELECTRONICO = textcorreo.Text,
                        TELEFONO = texttelefono.Text,
                        DIRECCION = textdireccion.Text
                    };

                    db.CLIENTES.Add(nuevoCliente);
                    db.SaveChanges();

                    MessageBox.Show("Cliente guardado exitosamente.", "Éxito");
                    CargarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el cliente con ORM: " + ex.Message, "Error");
                }
            }
        }

        private void botonactualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textidcliente.Text) || !int.TryParse(textidcliente.Text, out int idCliente))
            {
                MessageBox.Show("Debe seleccionar un cliente para actualizar.", "Error");
                return;
            }

           
            using (var db = new MINIMARKET_YEISONYBDEntities())
            {
                try
                {
                   
                    var clienteActualizar = db.CLIENTES.FirstOrDefault(c => c.CLIENTEID == idCliente);

                    if (clienteActualizar != null)
                    {
                      
                        clienteActualizar.NOMBRECOMPLETO = textnombre.Text;
                        clienteActualizar.CORREOELECTRONICO = textcorreo.Text;
                        clienteActualizar.TELEFONO = texttelefono.Text;
                        clienteActualizar.DIRECCION = textdireccion.Text;

                        db.SaveChanges(); 

                        MessageBox.Show("Cliente actualizado exitosamente.", "Éxito");
                        CargarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado para actualizar.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el cliente con ORM: " + ex.Message, "Error");
                }
            }
        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textidcliente.Text) || !int.TryParse(textidcliente.Text, out int idCliente)) return;

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                
                using (var db = new MINIMARKET_YEISONYBDEntities())
                {
                    try
                    {
                        
                        var clienteEliminar = db.CLIENTES.FirstOrDefault(c => c.CLIENTEID == idCliente);

                        if (clienteEliminar != null)
                        {
                            db.CLIENTES.Remove(clienteEliminar);
                            db.SaveChanges();

                            MessageBox.Show("Cliente eliminado.", "Éxito");
                            CargarClientes();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente con ORM: " + ex.Message, "Error");
                    }
                }
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
                textidcliente.Text = row.Cells["CLIENTEID"].Value?.ToString();
                textnombre.Text = row.Cells["NOMBRECOMPLETO"].Value?.ToString();
                textcorreo.Text = row.Cells["CORREOELECTRONICO"].Value?.ToString();
                texttelefono.Text = row.Cells["TELEFONO"].Value?.ToString();
                textdireccion.Text = row.Cells["DIRECCION"].Value?.ToString();

                botonguardar.Enabled = false;
                botonactualizar.Enabled = true;
                botoneliminar.Enabled = true;
            }
        }

        private void botonlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}