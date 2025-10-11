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
    public partial class Form9 : Form
    {
        private double valorinicial = 0;
        private string operaciones = "";

        private bool alaesperadelsegundonumero = false;
        


        public Form9()
        {
            InitializeComponent();
        }

        private void buttoncero_Click(object sender, EventArgs e)
        {
            textBoxver.Text = textBoxver.Text + "0";

        }

        private void buttonuno_Click(object sender, EventArgs e)
        {
            textBoxver.Text = textBoxver.Text + "1";
        }

        private void buttondos_Click(object sender, EventArgs e)
        {
            textBoxver.Text = textBoxver.Text + "2";
        }

        private void buttontres_Click(object sender, EventArgs e)
        {
            textBoxver.Text = textBoxver.Text + "3";
        }

        private void buttoncuatro_Click(object sender, EventArgs e)
        {
            textBoxver.Text = textBoxver.Text + "4";
        }

        private void buttoncinco_Click(object sender, EventArgs e)
        {
            textBoxver.Text = textBoxver.Text + "5";
        }

        private void buttonseis_Click(object sender, EventArgs e)
        {
            textBoxver.Text = textBoxver.Text + "6";
        }

        private void buttonsiete_Click(object sender, EventArgs e)
        {
            textBoxver.Text = textBoxver.Text + "7";
        }

        private void buttonocho_Click(object sender, EventArgs e)
        {
            textBoxver.Text = textBoxver.Text + "8";
        }

        private void buttonnueve_Click(object sender, EventArgs e)
        {
            textBoxver.Text = textBoxver.Text + "9";
        }

        private void buttonlimpiar_Click(object sender, EventArgs e)
        {
            textBoxver.Text = "";
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
           
            double segundonumero = 0;

           
            if (double.TryParse(textBoxver.Text, out segundonumero))
            {
           
                double resultado = 0;

                switch (operaciones)
                {
                    case "+":
                        resultado = valorinicial + segundonumero;
                        break;
                    case "-":
                        resultado = valorinicial - segundonumero;
                        break;
                    case "*":
                        resultado = valorinicial * segundonumero;
                        break;
                    case "/":
                   
                        if (segundonumero != 0)
                        {
                            resultado = valorinicial / segundonumero;
                        }
                        else
                        {
                            MessageBox.Show("¡División por cero no permitida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                  
                            textBoxver.Text = "0";
                            valorinicial = 0;
                            operaciones = "";
                            return;
                        }
                        break;
                    default:
                 
                        return;
                }
                textBoxver.Text = resultado.ToString();
                valorinicial = resultado;
            }
            alaesperadelsegundonumero = true;
            operaciones = "";
        }


        private void buttonsuma_Click(object sender, EventArgs e)
                        {
                            if (double.TryParse(textBoxver.Text, out valorinicial))
                            {
                                operaciones = "+";
                                textBoxver.Text = "";
                                alaesperadelsegundonumero = true;
                            }
                            else
                            {
                                MessageBox.Show("Se debe ingregar un numero valido", "Error de entrada");
                                textBoxver.Text = "";
                            }
                        }

        private void buttonresta_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxver.Text, out valorinicial))
            {
                operaciones = "-";
                textBoxver.Text = "";
                alaesperadelsegundonumero = true;
            }
        }

        private void buttonmultiplicacion_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxver.Text, out valorinicial))
            {
                operaciones = "*";
                alaesperadelsegundonumero = true;

            }
}
        

        private void buttondivision_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxver.Text, out valorinicial))
            {
                operaciones = "/";
                textBoxver.Text = "";
                alaesperadelsegundonumero = true;
            }
    }
    }
}
