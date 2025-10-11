using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVIDAD_PRACTICA2_YEISON
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void labelestado_Click(object sender, EventArgs e)
        {

        }

        private void buttonverificar_Click(object sender, EventArgs e)
        {
            int numeroConvertido;
            if (int.TryParse(textBoxverificarnumero.Text, out numeroConvertido))
            {
                labelestado.Text = "VALIDADO: ¡Ha ingresado un número entero válido!";
                labelestado.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelestado.Text = "Aviso: ¡No ha ingresa un numero valido!";
                labelestado.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void buttonsaludar_Click(object sender, EventArgs e)
        {
            string mensaje = "Hola, soy Yeison SD-17-20813!";
            string titulo = "datos";
            MessageBox.Show(mensaje, titulo);

        }

        private void buttonverfecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePickerfecha.Value;
            labelfechaelegida.Text = "Fecha elegida: " + fecha.ToShortDateString();

        }
    }
}

