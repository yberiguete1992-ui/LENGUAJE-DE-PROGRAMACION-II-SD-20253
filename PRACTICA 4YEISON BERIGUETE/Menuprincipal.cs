using PRACTICA_3_YEISONYBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_3_YEISON_BERIGUETE
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void Menuprincipal_Load(object sender, EventArgs e)
        {

        }

        private void botonclientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
        }
       
        private void botoncategorias_Click(object sender, EventArgs e)
        {
            FormCategorias formCategorias = new FormCategorias();
            formCategorias.Show();
        }

        private void botonproveedores_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.Show(); 
        }

        private void botonproductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.Show(); 
        }
    }
}
