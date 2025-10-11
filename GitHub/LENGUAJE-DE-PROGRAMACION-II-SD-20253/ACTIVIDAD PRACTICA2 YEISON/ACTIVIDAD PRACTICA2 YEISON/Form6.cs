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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonconvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxtemperatura.Text, out double temperatura))
            {
                double fahrenheit = temperatura * 1.8 + 32;

                labelresultado.Text = $" {temperatura.ToString("F2")} °C = {fahrenheit.ToString("F2")}°F";
                labelresultado.ForeColor = System.Drawing.Color.Black;

            }
            else
            {
                labelresultado.Text = "ERROR: Debe ingrsar un valor numérico válido.";
                labelresultado.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}

