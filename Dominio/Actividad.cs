using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventick
{
    public class Actividad : Elemento_a_ofrecer
    {        
        private double distancia;
        private int circular;
        private string dificultad;

        public double Distancia { get { return distancia; } set { distancia = value; } }
        public int Circular { get {return circular; } set {circular = value; } }
        public string Dificultad { get{return dificultad; } set {dificultad = value; } }

        public Actividad()
        {

        }

        public Actividad(string identificador, string tittle, string descrip, string local, DateTime tiempo, int tip,double km,  int circulo, string dificil) : base(identificador,tittle,descrip,local,tiempo,tip)
        {
            distancia = km;
            circular = circulo;
            dificultad = dificil;
        }
    }
}
