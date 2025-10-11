using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVIDAD_PRACTICA2_YEISON
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void botonaceptar_Click(object sender, EventArgs e)
        {
            string mensajeResultado = "Debe elegir alguna de las opciones.";


            if (radioButtoneleccion1.Checked)
            {
                mensajeResultado = "Seleccion Realizada: " + radioButtoneleccion1.Text;
            }
            else if (radioButtoneleccion2.Checked)
            {
                mensajeResultado = "Seleccion Realizada: " + radioButtoneleccion2.Text;
            }
            else if (radioButtoneleccion3.Checked)
            {
                mensajeResultado = "Seleccion Realizada: " + radioButtoneleccion3.Text;

            }
            labeleleccionseleccionada.Text = mensajeResultado;
        }

        private void comboBoxloscores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorSeleccionado = comboBoxloscores.SelectedItem.ToString();
            if (comboBoxloscores.SelectedItem != null)

            switch (colorSeleccionado)
            {
                case "Rojo":
                    this.BackColor = System.Drawing.Color.Red;
                    break;

                case "Azul":
                    this.BackColor = System.Drawing.Color.Blue;
                    break;

                case "Verde":
                    this.BackColor = System.Drawing.Color.Green;
                    break;

                default:
                    this.BackColor = System.Drawing.SystemColors.Control;
                    break;

            }
        }
    }
}
        



