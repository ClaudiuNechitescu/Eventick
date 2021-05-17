using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Eventick
{
    public class Administradores
    {
        private string usuario;        
        private string email;        
        private int cp;
        private string contraseña;

        public string Usuario { get { return usuario;} set { usuario = value; } }
        public string Email { get { return usuario; } set { usuario = value; } }
        public int Cp { get { return cp; } set { cp = value; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }

        public Administradores()
        {

        }

        public Administradores(string usu, string correo, int codigo_postal, string clave)
        {
            usuario = usu;
            email = correo;
            cp = codigo_postal;
            contraseña = clave;
        }

        public static List<Administradores> ComprobarAdmin(MySqlConnection conexion, string nombre)
        {
            List<Administradores> administradores = new List<Administradores>();

            string consulta = String.Format("SELECT * FROM admin WHERE nombre='{0}' OR email='{0}'", nombre);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Administradores admin = new Administradores();
                    admin.usuario = reader.GetString(0);
                    admin.email = reader.GetString(1);
                    admin.cp = reader.GetInt32(2);
                    admin.contraseña = reader.GetString(3);
                    administradores.Add(admin);
                }
            }
            reader.Close();
            return administradores;
        }

        public static List<Administradores> ComprobarAdminPorEmail(MySqlConnection conexion, string email)
        {
            List<Administradores> administradores = new List<Administradores>();

            string consulta = "";

            foreach (char caracter in email)
            {
                if (email.Length > 12 && email.Contains("@"))
                {
                    consulta = String.Format("SELECT * FROM admin WHERE email='{0}'", email);
                }
                else
                {
                    consulta = String.Format("SELECT * FROM admin WHERE nombre='{0}'", email);
                }
            }

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Administradores admin = new Administradores();
                    admin.usuario = reader.GetString(0);
                    admin.email = reader.GetString(1);
                    admin.cp = reader.GetInt32(2);
                    admin.contraseña = reader.GetString(3);
                    administradores.Add(admin);
                }
            }
            reader.Close();
            return administradores;
        }

        public static string ComprobarAdminClave(MySqlConnection conexion, string nombre, string clave)
        {
            string contraseña = "";
            string consulta = String.Format("SELECT * FROM admin WHERE nombre='{0}' OR email='{0}' AND contrasenia='{1}'", nombre, clave);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Administradores admin = new Administradores();
                    admin.usuario = reader.GetString(0);
                    admin.email = reader.GetString(1);
                    admin.cp = reader.GetInt32(2);
                    admin.contraseña = reader.GetString(3);                    
                    contraseña = admin.contraseña;
                }
            }
            reader.Close();
            return contraseña;
        }


        public static int AgregarEvento(MySqlConnection conexion , Eventos ev) // Pasar el evento cargado
        {
            int retorno;
            string consulta = String.Format("INSERT INTO evento (id, titulo, descripcion, localidad, duracion, tipo, precio) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')");
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int EliminarEvento(MySqlConnection conexion, string id)
        {
            int retorno;
            string consulta = String.Format("DELETE FROM evento WHERE id='{0}'",id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static int AgregarActividad(MySqlConnection conexion, Actividad act) // Pasar la actividad cargada
        {
            int retorno;
            string consulta = String.Format("INSERT INTO actividad (id, titulo, descripcion, localidad, distancia, circular, dificultad, duracion, tipo) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", act.Id, act.Titulo, act.Descripcion, act.Localidad, act.Distancia, act.Circular, act.Dificultad, act.Duracion, act.Tipo);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int EliminarActividad(MySqlConnection conexion, string id)
        {
            int retorno;
            string consulta = String.Format("DELETE FROM actividad WHERE id='{0}'", id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
