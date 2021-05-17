using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventick
{
    public class Elemento_a_ofrecer
    {
        private string id;
        private string titulo;
        private string descripcion;
        private string localidad;
        private DateTime duracion;
        private int tipo;

        public string Id { get { return id; } set { id = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Localidad { get { return localidad; } set { localidad = value; } }
        public DateTime Duracion { get { return duracion; } set { duracion = value; } }
        public int Tipo { get { return tipo; } set { tipo = value; } }

        public Elemento_a_ofrecer()
        {

        }

        public Elemento_a_ofrecer(string identificador, string tittle, string descrip, string local, DateTime tiempo, int tip)
        {
            id = identificador;
            titulo = tittle;
            descripcion = descrip;
            localidad = local;
            duracion = tiempo;
            tipo = tip;
        }

    }
}
