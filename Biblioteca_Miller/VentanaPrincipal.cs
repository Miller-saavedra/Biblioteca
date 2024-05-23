using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Biblioteca_Miller
{
    public partial class VentanaPrincipal : Form
    {
       
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_autor_Leave(object sender, EventArgs e)
        {
            if (txt_autor.Text == "")
            {
                txt_autor.Text = "Ingresa el autor del libro que deseas buscar";
                txt_autor.ForeColor = Color.Black;

            }
        }

        private void txt_autor_Enter(object sender, EventArgs e)
        {
            if (txt_autor.Text == "")
            {
                txt_autor.Text = "Ingresa el autor del libro que deseas buscar";
                txt_autor.ForeColor = Color.Black;

            }
        }

        private void txt_nombrelibro_Leave(object sender, EventArgs e)
        {
            if (txt_nombrelibro.Text == "")
            {
                txt_nombrelibro.Text = "Nombre del libro";
                txt_nombrelibro.ForeColor = Color.Black;
            }
        }

        private void txt_nombrelibro_Enter(object sender, EventArgs e)
        {
            if (txt_nombrelibro.Text == "")
            {
                txt_nombrelibro.Text = "Nombre del libro";
                txt_nombrelibro.ForeColor = Color.Black;
            }
        }

        private void btn_buscar1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {

            
        }
    }    
}

