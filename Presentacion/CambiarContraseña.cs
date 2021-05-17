using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eventick
{
    public partial class CambiarContraseña : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        ConexionBD bdatos = new ConexionBD();

        public CambiarContraseña()
        {
            InitializeComponent();
        }




        private void picAtras_Click(object sender, EventArgs e)
        {
            frmLogIn inicio_sesion = new frmLogIn();
            inicio_sesion.Visible = true;
            Visible = false;
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picReajustar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                picReajustar.Image = Image.FromFile(@"..\..\img\max.png");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                picReajustar.Image = Image.FromFile(@"..\..\img\min.png");
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (Cajasvacias() == 0)
            {
                if (bdatos.AbrirConexion())
                {
                    if (Usuarios.ComprobarUsuario(bdatos.Conexion, txtEmail.Text).Count > 0)
                    {
                        if (Usuarios.ComprobarPorEmail(bdatos.Conexion, txtEmail.Text).Count > 0)
                        {
                            if (Usuarios.ComprobarClave(bdatos.Conexion, txtEmail.Text, txtViejaContraseña.Text) == txtViejaContraseña.Text)
                            {
                                DialogResult confirmacion = MessageBox.Show("Cambiarás tu contraseña. ¿Desea continuar?",
                                                "Cambio de contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (confirmacion == DialogResult.Yes)
                                {
                                    if (Usuarios.CambiarContraseña(bdatos.Conexion, txtEmail.Text, txtNuevaContraseña.Text) != 0)
                                    {
                                        MessageBox.Show("La contraseña se ha cambiado con exito", "Contraseña cambiada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Limpiacajas();
                                        bdatos.CerrarConexion();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La contraseña no se ha cambiado", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        Limpiacajas();
                                        bdatos.CerrarConexion();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("La contraseña antigua es incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                Limpiacajas();
                                bdatos.CerrarConexion();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El email introducido es incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Limpiacajas();
                            bdatos.CerrarConexion();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este usuario no está registrado, debe registrarse para cambiar su contraseña", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Limpiacajas();
                        bdatos.CerrarConexion();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido conectar con la base de datos", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                }
            }
            else
            {
                if (Cajasvacias() == 1)
                {
                    MessageBox.Show("Los campos usuario, contraseña y confirmar contraseña están vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                }
                else
                {
                    if (Cajasvacias() == 2)
                    {
                        MessageBox.Show("El campo Usuario/Email está vacío", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Limpiacajas();
                        bdatos.CerrarConexion();
                    }
                    else
                    {
                        if (Cajasvacias() == 3)
                        {
                            MessageBox.Show("El campo Contraseña está vacío", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Limpiacajas();
                            bdatos.CerrarConexion();
                        }
                        else
                        {
                            MessageBox.Show("El campo Confirmar contraseña está vacío", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Limpiacajas();
                            bdatos.CerrarConexion();
                        }
                    }
                }
            }
        }

        private void Limpiacajas()
        {
            txtEmail.Clear();
            txtViejaContraseña.Clear();
            txtNuevaContraseña.Clear();
        }

        private int Cajasvacias()
        {
            if (txtEmail.Text == string.Empty && txtViejaContraseña.Text == string.Empty && txtNuevaContraseña.Text == string.Empty)
            {
                return 1;
            }
            else
            {
                if (txtEmail.Text == string.Empty)
                {
                    return 2;
                }
                else
                {
                    if (txtViejaContraseña.Text == string.Empty)
                    {
                        return 3;
                    }
                    else
                    {
                        if (txtNuevaContraseña.Text == string.Empty)
                        {
                            return 0;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        private void CambiarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void CambiarContraseña_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void CambiarContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
