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
    
    public partial class form1 : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public form1()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            /* aca tenemos un if simple que se esta conectando a un objeto que esta en la capa de negocios que a la vez se va a conectar a la capa de datos
             * para entrar a la base de datos como tal y preguntar que si hay un resultado que de igual a 1 quiere decir que si se encontro ese unico registro y que puede acceder */
            
            if (cn.conSQL(txt_usuario.Text,txt_contrasena.Text) == 1) 
            {
                MessageBox.Show("puede ingresar");
                this.Hide();
                VentanaPrincipal v1 = new VentanaPrincipal();
                v1.Show();

            }
            else
            {
                MessageBox.Show("No puede ingresar, el usuario no ha sido encontrado");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
        //opcion de ocultar contraseña
        private void muestra_CheckedChanged(object sender, EventArgs e)
        {
            if (muestra.Checked)
            {
                txt_contrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txt_contrasena.UseSystemPasswordChar = true;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "Ingrese su usuario";
                txt_usuario.ForeColor = Color.Black;

            }
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "Ingrese su usuario")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor= Color.Black;
            }
        }

        private void txt_contrasena_Leave(object sender, EventArgs e)
        {
            if (txt_contrasena.Text == "")
            {
                txt_contrasena.Text = "Ingrese su contraseña";
                txt_contrasena.ForeColor = Color.Black;
                txt_contrasena.UseSystemPasswordChar= false;
            }
        }

        private void txt_contrasena_Enter(object sender, EventArgs e)
        {
            if (txt_contrasena.Text == "Ingrese su contraseña")
            {
                txt_contrasena.Text = "";
                txt_contrasena.ForeColor = Color.Black;
                txt_contrasena.UseSystemPasswordChar = true;
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
