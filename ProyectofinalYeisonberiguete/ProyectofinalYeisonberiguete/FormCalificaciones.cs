using System;
using System.Data;
using System.Windows.Forms;
using System.IO; 
using System.Text; 

namespace ProyectofinalYeisonberiguete
{
    public partial class FormCalificaciones : Form
    {
        public FormCalificaciones()
        {
            InitializeComponent();
            this.Text = "Listado de Calificaciones";
            CargarListaCalificaciones();
        }

        private void CargarListaCalificaciones()
        {
            try
            {
                dgvCalificaciones.DataSource = CalificacionDAL.ObtenerTodasLasCalificaciones();
                dgvCalificaciones.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de calificaciones: " + ex.Message, "Error");
            }
        }

        private void btnAgregarCalificacion_Click(object sender, EventArgs e)
        {
            
            FormAgregarCalificacion form = new FormAgregarCalificacion();

            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarListaCalificaciones();
            }
        }

        
        private void dgvCalificaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCalificaciones.Rows[e.RowIndex];

                
                Calificacion calificacionSeleccionada = new Calificacion
                {
                    ID = Convert.ToInt32(fila.Cells["ID"].Value),
                    EstudianteID = Convert.ToInt32(fila.Cells["EstudianteID"].Value),
                    MateriaID = Convert.ToInt32(fila.Cells["MateriaID"].Value),
                    Calificacion1 = Convert.ToDecimal(fila.Cells["Calificacion1"].Value),
                    Calificacion2 = Convert.ToDecimal(fila.Cells["Calificacion2"].Value),
                    Calificacion3 = Convert.ToDecimal(fila.Cells["Calificacion3"].Value),
                    Calificacion4 = Convert.ToDecimal(fila.Cells["Calificacion4"].Value),
                    Examen = Convert.ToDecimal(fila.Cells["Examen"].Value)
                };

               
                FormAgregarCalificacion form = new FormAgregarCalificacion(calificacionSeleccionada);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    CargarListaCalificaciones();
                }
            }
        }

        
        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewToCSV(dgvCalificaciones);
        }

        
        private void ExportarDataGridViewToCSV(DataGridView dgv)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "Reporte_Calificaciones_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            sw.Write(dgv.Columns[i].HeaderText);
                            if (i < dgv.Columns.Count - 1) sw.Write(",");
                        }
                        sw.WriteLine();

                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv.Columns.Count; j++)
                            {
                                string valor = dgv.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;

                                
                                if (valor.Contains(",") || valor.Contains("\"") || valor.Contains("\n"))
                                {
                                    valor = "\"" + valor.Replace("\"", "\"\"") + "\"";
                                }

                                sw.Write(valor);
                                if (j < dgv.Columns.Count - 1) sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Exportación completada con éxito.", "Exportación CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void FormCalificaciones_Load(object sender, EventArgs e)
        {
           
        }
    }
}
