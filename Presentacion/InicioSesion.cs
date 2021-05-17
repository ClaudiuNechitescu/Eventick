using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eventick
{
    public partial class frmLogIn : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        ConexionBD bdatos = new ConexionBD();

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            Herramientas.CambiarColor(btnIniciarSesion);
            Herramientas.CambiarColor(btnRegistrarse);

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmLogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmLogIn_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            CrearCuenta registro = new CrearCuenta();
            registro.Visible = true;
            Visible = false;
        }

        private void picReajustar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                picReajustar.Image = Image.FromFile(@"..\..\..\Iconos\maximizar.png");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                picReajustar.Image = Image.FromFile(@"..\..\..\Iconos\maximizar2.png");
            }
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (Cajasvacias() == 0)
            {
                if (bdatos.AbrirConexion())
                {
                    if (txtUsuario.Text.Contains("ayto"))
                    {
                        if (Administradores.ComprobarAdmin(bdatos.Conexion, txtUsuario.Text).Count > 0)
                        {
                            if (Administradores.ComprobarAdminPorEmail(bdatos.Conexion, txtUsuario.Text).Count > 0)
                            {
                                if (Administradores.ComprobarAdminClave(bdatos.Conexion, txtUsuario.Text, txtContraseña.Text) == txtContraseña.Text)
                                {
                                    PantallaCarga pantalla_de_carga = new PantallaCarga();
                                    pantalla_de_carga.Visible = true;
                                    Visible = false;
                                }
                                else
                                {
                                    MessageBox.Show("Esta contraseña es incorrecta, por favor contacta con el equipo de eventick para crear una nueva o intentalo de nuevo", "Error - Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    Limpiacajas();
                                    bdatos.CerrarConexion();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Este email es incorrecto, por favor contacta con el equipo de eventick para crear uno nuevo o intentalo de nuevo", "Error - Email incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                Limpiacajas();
                                bdatos.CerrarConexion();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Este administrador no existe, por favor contacta con el equipo de eventick para crear una nueva o intentalo de nuevo", "Error - Administrador no existe", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Limpiacajas();
                            bdatos.CerrarConexion();
                        }
                    }
                    else
                    {
                        if (Usuarios.ComprobarUsuario(bdatos.Conexion, txtUsuario.Text).Count > 0)
                        {
                            if (Usuarios.ComprobarPorEmail(bdatos.Conexion, txtUsuario.Text).Count > 0)
                            {
                                if (Usuarios.ComprobarClave(bdatos.Conexion, txtUsuario.Text, txtContraseña.Text) == txtContraseña.Text)
                                {
                                    PantallaCarga pantalla_de_carga = new PantallaCarga();
                                    pantalla_de_carga.Visible = true;
                                    Visible = false;
                                }
                                else
                                {
                                    MessageBox.Show("La contraseña es incorrecta", "Error - Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    Limpiacajas();
                                    bdatos.CerrarConexion();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El email introducido es incorrecto", "Error - Email incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                Limpiacajas();
                                bdatos.CerrarConexion();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Este usuario no está registrado, debe registrarse antes de iniciar sesión", "Error - Usuario no existe", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Limpiacajas();
                            bdatos.CerrarConexion();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido conectar con la base de datos", "Error - Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                }
            }
            else
            {
                if (Cajasvacias() == 1)
                {
                    MessageBox.Show("Los campos Usuario y Contraseña están vacios", "Error - Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                }
                else
                {
                    if (Cajasvacias() == 2)
                    {
                        MessageBox.Show("El campo Usuario está vacío", "Error - Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Limpiacajas();
                        bdatos.CerrarConexion();
                    }
                    else
                    {
                        MessageBox.Show("El campo Contraseña está vacío", "Error - Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Limpiacajas();
                        bdatos.CerrarConexion();
                    }
                }
            }
        }

        private void Limpiacajas()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private int Cajasvacias()
        {
            if (txtUsuario.Text == string.Empty && txtContraseña.Text == string.Empty)
            {
                return 1;
            }
            else
            {
                if (txtUsuario.Text == string.Empty)
                {
                    return 2;
                }
                else
                {
                    if (txtContraseña.Text == string.Empty)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        private void lblEntrarComoInvitado_Click(object sender, EventArgs e)
        {
            PantallaCarga pantalla_de_carga = new PantallaCarga();
            pantalla_de_carga.Visible = true;
            Visible = false;
        }

        private void lblCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambiarContraseña cambiar_contraseña = new CambiarContraseña();
            cambiar_contraseña.Visible = true;
            Visible = false;
        }
    }
}
