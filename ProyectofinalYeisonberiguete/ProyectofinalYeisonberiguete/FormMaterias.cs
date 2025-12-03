using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectofinalYeisonberiguete
{
    public partial class FormMaterias : Form
    {
        public FormMaterias()
        {
            InitializeComponent();
            this.Text = "Listado de Materias";
            CargarListaMaterias();
        }

        private void CargarListaMaterias()
        {
            try
            {
                dgvMaterias.DataSource = MateriaDAL.ObtenerTodasLasMaterias();
                dgvMaterias.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de materias: " + ex.Message, "Error");
            }
        }

        
        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            FormAgregarMateria form = new FormAgregarMateria();

            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarListaMaterias(); 
            }
        }

        
        private void dgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMaterias.Rows[e.RowIndex];

                
                Materia materiaSeleccionada = new Materia
                {
                    ID = Convert.ToInt32(fila.Cells["ID"].Value),
                    NombreMateria = fila.Cells["NombreMateria"].Value.ToString()
                };

                
                FormAgregarMateria form = new FormAgregarMateria(materiaSeleccionada);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    CargarListaMaterias(); 
                }
            }
        }
    }
}
