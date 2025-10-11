using System.Windows.Forms;

namespace ACTIVIDAD_PRACTICA2_YEISON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            mensaje.Text = "Texto cambiado";
        }

        private void botonmostartexto_Click(object sender, EventArgs e)
        {
            labelresultadotexto.Text = "Su mensaje fue: " + entrada.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
