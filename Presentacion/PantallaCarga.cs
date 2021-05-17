using System;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;

namespace Eventick
{
    public partial class PantallaCarga : Form
    {
        int cont = 0;


        public PantallaCarga()
        {
            InitializeComponent();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
                picLoading.Load("1.gif");
                picLoading.Location = new Point(this.Width / 2 - picLoading.Width / 2, this.Height / 2 + 100 - picLoading.Height / 2);
                lblTitulo.Location = new Point(this.Width / 2 - lblTitulo.Width / 2, this.Height / 2 + 250 - lblTitulo.Height / 2);
            }
            cont++;
            if (cont == 100)
            {
                tmrReloj.Stop();
                tmr2.Start();
            }
        }

        private void PantallaCarga_Load(object sender, EventArgs e)
        {
            picLoading.Parent = picFondo;
            lblTitulo.Parent = picFondo;
            this.Opacity = 0.0;
            tmrReloj.Start();
            lblTitulo.Text = GenerarFrase();
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                tmr2.Stop();
                frmLogIn inicio_sesion = new frmLogIn();
                inicio_sesion.Visible = true;
                Visible = false;
            }
        }

        private int GenerarNum()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10);
        }

        private string GenerarFrase()
        {
            string frase = "";

            switch (GenerarNum())
            {
                case 1:
                    return frase = "Preparando eventos y actividades...";

                case 2:

                    return frase = "Hinchando las ruedas de la bici...";

                case 3:

                    return frase = "¡Zapatillas listas, ganas a punto, a correr!.";

                case 4:

                    return frase = "¡Átate los cordones que empieza la aventura!";

                case 5:

                    return frase = "Si estas aburrido no dudes en viasitar nuestra sección de Senderismo";

                case 6:

                    return frase = "Calentando musculos... ¡es hora de correr!";

                case 7:

                    return frase = "¡Vamos compañero!, ¡ese sendero no podrá con nosotros!";

                case 8:

                    return frase = "Puedes unirte a los eventos que desees";

                case 9:

                    return frase = "No solo son eventos, es Eventick";

                case 10:

                    return frase = "¡A correr!";

                default:
                    return frase = "Bienvenid@ a Eventick";

            }
        }


    }
}
