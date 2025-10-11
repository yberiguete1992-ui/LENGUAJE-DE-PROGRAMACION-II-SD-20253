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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void botonsumar_Click(object sender, EventArgs e)
        {
            int num1, num2, Resultado;
            try
            {
                num1 = int.Parse(textBoxNumero1.Text);
                num2 = int.Parse (textBoxNumero2.Text);

                Resultado = num1 + num2;
                labelResultadoSuma.Text = "La suma es: " + Resultado.ToString();
            }
            catch (FormatException)
            {
                labelResultadoSuma.Text = "Error: Debe ingresar solamente numeros validos para la suma.";

            }
        }
    }
}
