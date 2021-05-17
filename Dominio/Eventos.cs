using System;

namespace Eventick
{
    public class Eventos : Elemento_a_ofrecer
    {
        private double precio;

        public double Precio { get { return precio; } set { precio = value; } }
        public Eventos()
        {

        }

        public Eventos(string identificador, string tittle, string descrip, string local, DateTime tiempo, int tip, double dinero) : base(identificador, tittle, descrip, local, tiempo, tip)
        {
            precio = dinero;
        }




    }
}
