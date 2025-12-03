using System;
using System.Windows.Forms;

namespace ProyectofinalYeisonberiguete
{
    public partial class FormAgregarMateria : Form
    {
        private int MateriaID { get; set; }

        public FormAgregarMateria() 
        {
            InitializeComponent();
            this.Text = "Agregar Nueva Materia";
            this.MateriaID = 0;

         
            this.btnEliminar.Visible = false;
        }

        public FormAgregarMateria(Materia materia) 
        {
            InitializeComponent();
            this.Text = "Editar Materia";
            this.MateriaID = materia.ID;
            txtNombreMateria.Text = materia.NombreMateria;

            
            this.btnEliminar.Visible = true;
        }

       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMateria.Text.Trim();
            bool resultado = false;

            if (MateriaID == 0) 
            {
                if (MateriaDAL.InsertarMateria(nombre) > 0) resultado = true;
            }
            else 
            {
                resultado = MateriaDAL.ActualizarMateria(MateriaID, nombre);
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
            DialogResult confirmacion = MessageBox.Show($"¿Eliminar la materia: {txtNombreMateria.Text}?",
                                                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                if (MateriaDAL.EliminarMateria(MateriaID))
                {
                    MessageBox.Show("Materia eliminada con éxito.", "Éxito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}