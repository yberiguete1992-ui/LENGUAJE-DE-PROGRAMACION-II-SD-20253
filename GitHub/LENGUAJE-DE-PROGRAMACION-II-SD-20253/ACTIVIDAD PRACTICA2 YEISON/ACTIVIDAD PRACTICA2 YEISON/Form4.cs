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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonagregar_Click(object sender, EventArgs e)
        {
            if (!System.String.IsNullOrWhiteSpace(textBoxelementonuevo.Text))
            {
                listBoxelementos.Items.Add(textBoxelementonuevo.Text);
                textBoxelementonuevo.Clear();
                textBoxelementonuevo.Focus();

            }
            else
            {
                MessageBox.Show("Debe ingresar algín elemento para añadir al listado.", "Aviso");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public partial class form4 : Form4
        {
            private int contador = 0;
            public form4()
            {
                InitializeComponent();
            }
            private void buttoncontar_Click(object sender, EventArgs e)
            {
                contador = contador + 1;

                labelcontar.Text = "Veces presionado: " + contador.ToString();
            }

        

        }
    }
}

