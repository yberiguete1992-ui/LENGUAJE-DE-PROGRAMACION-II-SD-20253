using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACTIVIDAD_PRACTICA2_YEISON
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void timerprogreso_Tick(object sender, EventArgs e)
        {
            if (progreso.Value < progreso.Maximum)
            {
                progreso.Value = progreso.Value + 1;

            }
            else
            {
              
                timerprogreso.Stop();
                progreso.Value = 0;
                MessageBox.Show("¡Proceso Completado!", "Finalizado");
            }
        }

        private void buttoniniciar_Click(object sender, EventArgs e)
        {
            timerprogreso.Start();
        }

        private void buttondetener_Click(object sender, EventArgs e)
        {
            timerprogreso.Stop();
        }
    
    }
}
