using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Eventick
{
    public class Usuarios
    {
        private string nick;
        private string nombre;
        private string apellidos;
        private string email;
        private int edad;
        private int cp;
        private string contraseña;

        public string Nick { get { return nick; } set { nick = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public int Cp { get { return cp; } set { cp = value; } }
        
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }

        public Usuarios()
        {

        }

        public Usuarios(string identificador, string nom, string ape, string correo, int años, int codigo_postal, string contrasenya)
        {
            nick = identificador;
            nombre = nom;
            apellidos = ape;
            email = correo;
            edad = años;
            cp = codigo_postal;
            contraseña = contrasenya;
        }

        public static int AgregarUsuario(MySqlConnection conexion, Usuarios usu)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO usuario (nickname, nombre, apellidos, email, edad, cp, contrasenia ) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", usu.nick, usu.nombre, usu.apellidos, usu.email, usu.edad, usu.cp, usu.contraseña);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }


        public static int EliminarUsuario(MySqlConnection conexion, string id)
        {
            int retorno;
            string consulta = String.Format("DELETE FROM usuario WHERE nickname='{0}'", id);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int CambiarContraseña(MySqlConnection conexion, string nick, string clave)
        {
            int retorno;
            string consulta = String.Format("UPDATE usuario SET contrasenia='{0}' WHERE nickname='{1}' OR email='{1}'", clave, nick);
                       
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static string ComprobarClave(MySqlConnection conexion, string nick, string clave)
        {
            string contraseña = "";
            string consulta = String.Format("SELECT * FROM usuario WHERE nickname='{0}' OR email='{0}' AND contrasenia='{1}'", nick, clave);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuarios usu = new Usuarios();
                    usu.Nick = reader.GetString(0);
                    usu.Nombre = reader.GetString(1);
                    usu.Apellidos = reader.GetString(2);
                    usu.Email = reader.GetString(3);
                    usu.Edad = reader.GetInt32(4);
                    usu.Cp = reader.GetInt32(5);
                    usu.Contraseña = reader.GetString(6);
                    contraseña = usu.contraseña;
                }
            }
            reader.Close();
            return contraseña;
        }

        public static List<Usuarios> ComprobarUsuario(MySqlConnection conexion, string nick)
        {
            List<Usuarios> lista = new List<Usuarios>();

            string consulta = String.Format("SELECT * FROM usuario WHERE nickname='{0}' OR email='{0}'", nick);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuarios usu = new Usuarios();
                    usu.Nick = reader.GetString(0);
                    usu.Nombre = reader.GetString(1);
                    usu.Apellidos = reader.GetString(2);
                    usu.Email = reader.GetString(3);
                    usu.Edad = reader.GetInt32(4);
                    usu.Cp = reader.GetInt32(5);
                    usu.Contraseña = reader.GetString(6);
                    lista.Add(usu);
                }
            }
            reader.Close();
            return lista;
        }
        
        public static List<Usuarios> ComprobarPorEmail(MySqlConnection conexion, string email)
        {
            List<Usuarios> lista = new List<Usuarios>();

            string consulta = "";

            foreach (char caracter in email)
            {
                if (email.Length > 12)
                {
                    consulta = String.Format("SELECT * FROM usuario WHERE email='{0}'", email);
                }
                else
                {
                    consulta = String.Format("SELECT * FROM usuario WHERE nickname='{0}'", email);
                }
            }            

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();           

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuarios usu = new Usuarios();
                    usu.Nick = reader.GetString(0);
                    usu.Nombre = reader.GetString(1);
                    usu.Apellidos = reader.GetString(2);
                    usu.Email = reader.GetString(3);
                    usu.Edad = reader.GetInt32(4);
                    usu.Cp = reader.GetInt32(5);
                    usu.Contraseña = reader.GetString(6);
                    lista.Add(usu);
                }
            }
            reader.Close();
            return lista;
        }       
    }
}
