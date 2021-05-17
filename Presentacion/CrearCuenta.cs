using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eventick
{
    public partial class CrearCuenta : Form
    {
        ConexionBD bdatos = new ConexionBD();

        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            frmLogIn inicio_sesion = new frmLogIn();
            inicio_sesion.Visible = true;
            Visible = false;
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

        private void picMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            switch (Cajasvacias())
            {
                case 0:

                    if (bdatos.AbrirConexion())
                    {
                        if (NohaynombreAyuntamiento() == true)
                        {
                            if (Usuarios.ComprobarUsuario(bdatos.Conexion, txtUsuario.Text).Count == 0)
                            {
                                if (Usuarios.ComprobarPorEmail(bdatos.Conexion, txtEmail.Text).Count == 0)
                                {
                                    Usuarios usu = new Usuarios();
                                    usu.Nick = txtUsuario.Text;
                                    usu.Nombre = txtUsuario_Nombre.Text;
                                    usu.Apellidos = txtApellido.Text;
                                    usu.Email = txtEmail.Text;
                                    if (ContraseñaConfirmada() == true)
                                    {
                                        usu.Contraseña = txtConfirmarContraseña.Text;
                                        if (Usuarios.AgregarUsuario(bdatos.Conexion, usu) == 1)
                                        {
                                            MessageBox.Show("El usuario se ha registrado con exito", "¡Usuario registrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Limpiacajas();
                                            bdatos.CerrarConexion();
                                            frmLogIn inicio_sesion = new frmLogIn();
                                            inicio_sesion.Visible = true;
                                            Visible = false;
                                        }
                                        else
                                        {
                                            MessageBox.Show("El usuario no ha sido registrado", "Error - registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                            Limpiacajas();
                                            bdatos.CerrarConexion();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Las contraseñas no coinciden", "Error - Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        txtContraseña.Clear();
                                        txtConfirmarContraseña.Clear();
                                        bdatos.CerrarConexion();
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("El email introducido ya está registrado", "Error - Email incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    Limpiacajas();
                                    bdatos.CerrarConexion();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Este usuario ya está registrado, debe iniciar sesión", "Error - Usuario ya existe", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                Limpiacajas();
                                bdatos.CerrarConexion();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No te puedes registrar como administrador", "Error - Registro de la palabra 'ayto' en el usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Limpiacajas();
                            bdatos.CerrarConexion();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido conectar con la base de datos", "Error - Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Limpiacajas();
                        bdatos.CerrarConexion();
                    }

                    break;

                case 1:
                    MessageBox.Show("Todos los campos están vacíos", "Error - Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                    break;

                case 2:
                    MessageBox.Show("El campo nombre está vacío", "Error - Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                    break;

                case 3:
                    MessageBox.Show("El campo apellidos está vacío", "Error - Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                    break;

                case 4:
                    MessageBox.Show("El campo usuario está vacío", "Error - Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                    break;

                case 5:
                    MessageBox.Show("El campo email está vacío", "Error - Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                    break;

                case 6:
                    MessageBox.Show("El campo contraseña está vacío", "Error - Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                    break;

                case 7:
                    MessageBox.Show("El campo confirmar contraseña está vacío", "Error - Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Limpiacajas();
                    bdatos.CerrarConexion();
                    break;


            }
        }

        private void Limpiacajas()
        {
            txtUsuario_Nombre.Clear();
            txtUsuario.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();
        }

        private bool NohaynombreAyuntamiento()
        {
            if (txtUsuario.Text.Contains("ayto"))
            {
                return false;
            }
            else
            {
                if (txtEmail.Text.Contains("ayto"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private int Cajasvacias()
        {
            if (txtUsuario_Nombre.Text == string.Empty && txtApellido.Text == string.Empty && txtEmail.Text == string.Empty && txtContraseña.Text == string.Empty && txtConfirmarContraseña.Text == string.Empty)
            {
                return 1;
            }
            else
            {
                if (txtUsuario_Nombre.Text == string.Empty)
                {
                    return 2;
                }
                else
                {
                    if (txtApellido.Text == string.Empty)
                    {
                        return 3;
                    }
                    else
                    {
                        if (txtUsuario.Text == string.Empty)
                        {
                            return 4;
                        }
                        else
                        {
                            if (txtEmail.Text == string.Empty)
                            {
                                return 5;
                            }
                            else
                            {
                                if (txtContraseña.Text == string.Empty)
                                {
                                    return 6;
                                }
                                else
                                {
                                    if (txtConfirmarContraseña.Text == string.Empty)
                                    {
                                        return 7;
                                    }
                                    else
                                    {
                                        return 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool ContraseñaConfirmada()
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
