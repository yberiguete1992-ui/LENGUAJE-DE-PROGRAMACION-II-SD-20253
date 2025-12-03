using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectofinalYeisonberiguete
{
    public partial class FormEstudiantes : Form
    {
        public FormEstudiantes()
        {
            InitializeComponent();
            CargarListaEstudiantes();
        }

        private void CargarListaEstudiantes()
        {
            try
            {
                dataGridView1.DataSource = EstudianteDAL.ObtenerTodosLosEstudiantes();
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista: " + ex.Message, "Error");
            }
        }

        
        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            FormAgregarEstudiante form = new FormAgregarEstudiante();

            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarListaEstudiantes();
            }
        }

        
        private void dgvEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                Estudiante estudianteSeleccionado = new Estudiante
                {
                    ID = Convert.ToInt32(fila.Cells["ID"].Value),
                    Nombre = fila.Cells["Nombre"].Value.ToString(),
                    Apellido = fila.Cells["Apellido"].Value.ToString()
                };

                FormAgregarEstudiante form = new FormAgregarEstudiante(estudianteSeleccionado);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    CargarListaEstudiantes();
                }
            }
        }
    }
}