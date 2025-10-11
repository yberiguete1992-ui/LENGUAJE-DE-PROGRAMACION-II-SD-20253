using Microsoft.VisualBasic.Logging;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void buttonabrir_Click(object sender, EventArgs e)
        {
            {

                openFileabrir.Filter = "Archivos de Texto (*.txt)|*.txt|Todos los Archivos (*.*)|*.*";
                openFileabrir.Title = "Se debe eleccionar un documento de texto para abrir";

                if (openFileabrir.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileabrir.FileName))
                        {
                            textBoxcontenido.Text = sr.ReadToEnd();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al leer el documento: " + ex.Message, "Error de documento");
                    }
                }
            }
        }

        private void buttonguardar_Click(object sender, EventArgs e)
            
                {
                    saveFileguardar.Filter = "Archivos de Texto (*.txt)|*.txt|Todos los Archivos (*.*)|*.*";
                    saveFileguardar.Title = "Se debe eleccionar un documento de texto para guardar";

                    if (saveFileguardar.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileguardar.FileName))
                            {
                            sw.Write(textBoxcontenido.Text);

                            MessageBox.Show("El documento se ha guardado correctamente.", "Guardado con exito.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hay un error al guardar el documento: " + ex.Message, "Error de documento");
                    }
                }

        }
    }

}
