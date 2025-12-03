using System;
using System.Windows.Forms;

namespace ProyectofinalYeisonberiguete
{
    public partial class FormAgregarEstudiante : Form
    {
        private int EstudianteID { get; set; }

        public FormAgregarEstudiante() 
        {
            InitializeComponent();
            this.EstudianteID = 0;
        }

        public FormAgregarEstudiante(Estudiante estudiante) 
        {
            InitializeComponent();
            this.EstudianteID = estudiante.ID;
            txtNombre.Text = estudiante.Nombre;
            txtApellido.Text = estudiante.Apellido;

    
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            bool resultado = false;

            if (EstudianteID == 0)
            {
                if (EstudianteDAL.InsertarEstudiante(nombre, apellido) > 0) resultado = true;
            }
            else
            {
                resultado = EstudianteDAL.ActualizarEstudiante(EstudianteID, nombre, apellido);
            }

            if (resultado)
            {
                MessageBox.Show("Operación realizada con éxito.", "Éxito");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
         
        {
           
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de eliminar al estudiante {txtNombre.Text} {txtApellido.Text}?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            
            if (confirmacion == DialogResult.Yes)
            {
                
                if (EstudianteDAL.EliminarEstudiante(EstudianteID))
                {
                    MessageBox.Show("Estudiante eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                
            }
        }
        

        }
    }
