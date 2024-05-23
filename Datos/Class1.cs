using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionSQL // clase para para crear la conexion del login con la base de datos
    {
        static string conexionstring = "server= localhost\\SQLEXPRESS;database = usuario;" + "integrated security= true"; // conexion con la base de datos local
        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string usuario, string contrasena) // va a retornar un numero en este caso el metodo que como parametro va a recibir lo que se le ingrese en usuario y contraseña
        {
            int count;
            con.Open(); // se abre la conexion
            string query = "Select Count(*) From usuarios where usuario = '" + usuario + "'" + // hace una busqueda en la base de datos que se alojara en query
                " and contrasena = '" + contrasena + "'";
            SqlCommand cmd = new SqlCommand(query, con); // encargado de arrojar el resultado de la busqueda, hace la busqueda
            count = Convert.ToInt32(cmd.ExecuteScalar()); // devuelve el valor en numero de cuantas personas coinciden con los registros ingresados
            con.Close();
            return count;
        }
    }

}