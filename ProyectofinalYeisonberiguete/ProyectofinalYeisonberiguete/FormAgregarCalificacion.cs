using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectofinalYeisonberiguete
{
    public partial class FormAgregarCalificacion : Form
    {
        private int CalificacionID { get; set; }
        private Calificacion CalificacionActual { get; set; }

        public FormAgregarCalificacion(Calificacion calificacion = null)
        {
            InitializeComponent();
            CargarCombos(); 

            if (calificacion == null)
            {
                
                this.Text = "Agregar Nueva Calificación";
                this.CalificacionID = 0;
                this.CalificacionActual = new Calificacion();
                this.btnEliminar.Visible = false;
            }
            else
            {
                
                this.Text = "Editar Calificación";
                this.CalificacionID = calificacion.ID;
                this.CalificacionActual = calificacion;
                this.btnEliminar.Visible = true;
                CargarDatosParaEdicion(calificacion);
            }

            
            AsignarEventosCalculo();
            CalcularYMostrarResultados();
        }

        private void CargarCombos()
        {
            
            DataTable dtEstudiantes = EstudianteDAL.ObtenerTodosLosEstudiantes();
            cmbEstudiante.DataSource = dtEstudiantes;
            cmbEstudiante.DisplayMember = "NombreCompleto"; 
            cmbEstudiante.ValueMember = "ID";

           
            DataTable dtMaterias = MateriaDAL.ObtenerTodasLasMaterias();
            cmbMateria.DataSource = dtMaterias;
            cmbMateria.DisplayMember = "NombreMateria";
            cmbMateria.ValueMember = "ID";
        }

        private void CargarDatosParaEdicion(Calificacion c)
        {
            cmbEstudiante.SelectedValue = c.EstudianteID;
            cmbMateria.SelectedValue = c.MateriaID;
            txtC1.Text = c.Calificacion1.ToString();
            txtC2.Text = c.Calificacion2.ToString();
            txtC3.Text = c.Calificacion3.ToString();
            txtC4.Text = c.Calificacion4.ToString();
            txtExamen.Text = c.Examen.ToString();

            
            cmbEstudiante.Enabled = false;
            cmbMateria.Enabled = false;
        }

        private void AsignarEventosCalculo()
        {
            
            EventHandler handler = (sender, e) => { CalcularYMostrarResultados(); };
            txtC1.TextChanged += handler;
            txtC2.TextChanged += handler;
            txtC3.TextChanged += handler;
            txtC4.TextChanged += handler;
            txtExamen.TextChanged += handler;
        }

        private void CalcularYMostrarResultados()
        {
            
            decimal c1, c2, c3, c4, examen;

            if (!decimal.TryParse(txtC1.Text, out c1) || c1 < 0 || c1 > 100) { lblTotalCalificacion.Text = "Error C1"; return; }
            if (!decimal.TryParse(txtC2.Text, out c2) || c2 < 0 || c2 > 100) { lblTotalCalificacion.Text = "Error C2"; return; }
            if (!decimal.TryParse(txtC3.Text, out c3) || c3 < 0 || c3 > 100) { lblTotalCalificacion.Text = "Error C3"; return; }
            if (!decimal.TryParse(txtC4.Text, out c4) || c4 < 0 || c4 > 100) { lblTotalCalificacion.Text = "Error C4"; return; }
            if (!decimal.TryParse(txtExamen.Text, out examen) || examen < 0 || examen > 100) { lblTotalCalificacion.Text = "Error Examen"; return; }

            
            this.CalificacionActual.Calificacion1 = c1;
            this.CalificacionActual.Calificacion2 = c2;
            this.CalificacionActual.Calificacion3 = c3;
            this.CalificacionActual.Calificacion4 = c4;
            this.CalificacionActual.Examen = examen;

            
            lblTotalCalificacion.Text = this.CalificacionActual.TotalCalificacion.ToString("N2");
            lblClasificacion.Text = this.CalificacionActual.Clasificacion;
            lblEstado.Text = this.CalificacionActual.Estado;
            lblEstado.ForeColor = (this.CalificacionActual.Estado == "Aprobado") ? Color.Green : Color.Red;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                CalcularYMostrarResultados();
                if (lblTotalCalificacion.Text.StartsWith("Error"))
                {
                    MessageBox.Show("Corrija las calificaciones. Deben ser números entre 0 y 100.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                this.CalificacionActual.EstudianteID = (int)cmbEstudiante.SelectedValue;
                this.CalificacionActual.MateriaID = (int)cmbMateria.SelectedValue;

                bool resultado = false;

                if (CalificacionID == 0)
                {
                    if (CalificacionDAL.InsertarCalificacion(this.CalificacionActual) > 0) resultado = true;
                }
                else
                {
                    this.CalificacionActual.ID = CalificacionID;
                    resultado = CalificacionDAL.ActualizarCalificacion(this.CalificacionActual);
                }

                if (resultado)
                {
                    MessageBox.Show("Operación realizada con éxito.", "Éxito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: Verifique las selecciones y los datos. Detalle: " + ex.Message, "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show($"¿Eliminar esta calificación (ID: {CalificacionID})?",
                                                        "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                if (CalificacionDAL.EliminarCalificacion(CalificacionID))
                {
                    MessageBox.Show("Calificación eliminada con éxito.", "Éxito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}