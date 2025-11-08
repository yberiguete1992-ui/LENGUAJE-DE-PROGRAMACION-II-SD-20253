using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PRACTICA_3_YEISON_BERIGUETE;

namespace PRACTICA_3_YEISON_BERIGUETE
{
    public partial class Formulariopractica4cs : Form
    {
        public Formulariopractica4cs()
        {
            InitializeComponent();
        }

        private void Formulariopractica4cs_Load(object sender, EventArgs e)
        {

        }

            private void botonCargar_Click(object sender, EventArgs e)
        {
           
            CargarClientes(); 
        }

        private void CargarClientes()
        {
           
            using (var contexto = new MINIMARKET_YEISONYBDEntities())
            {
                try
                {
                  
                    var listaClientes = contexto.CLIENTES.ToList();

        
                    dataGridView1.DataSource = listaClientes;

                    
                    MessageBox.Show($"Se cargaron {listaClientes.Count} clientes.", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                   
                    string mensajeError = "Error al cargar: " + ex.Message;
                    if (ex.InnerException != null)
                    {
                        mensajeError += "\nDetalle de la BD: " + ex.InnerException.Message;
                    }

                    MessageBox.Show(mensajeError, "ERROR CRÍTICO DE BASE DE DATOS",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
