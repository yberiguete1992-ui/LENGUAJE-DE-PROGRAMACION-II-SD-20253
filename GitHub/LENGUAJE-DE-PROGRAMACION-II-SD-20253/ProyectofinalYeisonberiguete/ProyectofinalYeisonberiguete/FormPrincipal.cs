using System;
using System.Windows.Forms;

namespace ProyectofinalYeisonberiguete
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.Text = "Menú Principal - Control de Calificaciones";
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            
            this.Hide();

           
            FormEstudiantes form = new FormEstudiantes();
            form.ShowDialog();

            
            this.Show();
        }

        
        private void btnMaterias_Click(object sender, EventArgs e)
        {
            
            this.Hide(); 
            FormMaterias form = new FormMaterias();
            form.ShowDialog();
            this.Show(); 
            
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCalificaciones form = new FormCalificaciones();
            form.ShowDialog();
            this.Show();
        }
    }
}