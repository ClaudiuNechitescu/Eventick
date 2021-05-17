
namespace Eventick
{
    partial class frmLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.MaskedTextBox();
            this.lblEntrarComoInvitado = new System.Windows.Forms.Label();
            this.lblCambiarContraseña = new System.Windows.Forms.Label();
            this.picReajustar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picFondoLogIn = new System.Windows.Forms.PictureBox();
            this.panelBarranav = new System.Windows.Forms.Panel();
            this.lblusuario_correo = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picReajustar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoLogIn)).BeginInit();
            this.panelBarranav.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(464, 237);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(326, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(464, 360);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(326, 27);
            this.txtContraseña.TabIndex = 2;
            // 
            // lblEntrarComoInvitado
            // 
            this.lblEntrarComoInvitado.AutoSize = true;
            this.lblEntrarComoInvitado.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEntrarComoInvitado.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblEntrarComoInvitado.Location = new System.Drawing.Point(851, 399);
            this.lblEntrarComoInvitado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrarComoInvitado.Name = "lblEntrarComoInvitado";
            this.lblEntrarComoInvitado.Size = new System.Drawing.Size(104, 13);
            this.lblEntrarComoInvitado.TabIndex = 6;
            this.lblEntrarComoInvitado.Text = "Entrar como invitado";
            this.lblEntrarComoInvitado.Click += new System.EventHandler(this.lblEntrarComoInvitado_Click);
            // 
            // lblCambiarContraseña
            // 
            this.lblCambiarContraseña.AutoSize = true;
            this.lblCambiarContraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCambiarContraseña.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCambiarContraseña.Location = new System.Drawing.Point(440, 399);
            this.lblCambiarContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCambiarContraseña.Name = "lblCambiarContraseña";
            this.lblCambiarContraseña.Size = new System.Drawing.Size(101, 13);
            this.lblCambiarContraseña.TabIndex = 10;
            this.lblCambiarContraseña.Text = "Cambiar contraseña";
            this.lblCambiarContraseña.Click += new System.EventHandler(this.lblCambiarContraseña_Click);
            // 
            // picReajustar
            // 
            this.picReajustar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picReajustar.Image = ((System.Drawing.Image)(resources.GetObject("picReajustar.Image")));
            this.picReajustar.Location = new System.Drawing.Point(1310, 4);
            this.picReajustar.Margin = new System.Windows.Forms.Padding(2);
            this.picReajustar.Name = "picReajustar";
            this.picReajustar.Size = new System.Drawing.Size(22, 21);
            this.picReajustar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReajustar.TabIndex = 13;
            this.picReajustar.TabStop = false;
            this.picReajustar.Click += new System.EventHandler(this.picReajustar_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(605, 150);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(214, 39);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(1284, 4);
            this.picMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(22, 21);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizar.TabIndex = 7;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(1336, 4);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(22, 21);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrar.TabIndex = 5;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // picFondoLogIn
            // 
            this.picFondoLogIn.Image = ((System.Drawing.Image)(resources.GetObject("picFondoLogIn.Image")));
            this.picFondoLogIn.Location = new System.Drawing.Point(-1, 26);
            this.picFondoLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.picFondoLogIn.Name = "picFondoLogIn";
            this.picFondoLogIn.Size = new System.Drawing.Size(1380, 738);
            this.picFondoLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondoLogIn.TabIndex = 0;
            this.picFondoLogIn.TabStop = false;
            // 
            // panelBarranav
            // 
            this.panelBarranav.Controls.Add(this.picCerrar);
            this.panelBarranav.Controls.Add(this.picReajustar);
            this.panelBarranav.Controls.Add(this.picMinimizar);
            this.panelBarranav.Location = new System.Drawing.Point(-1, 0);
            this.panelBarranav.Name = "panelBarranav";
            this.panelBarranav.Size = new System.Drawing.Size(1380, 27);
            this.panelBarranav.TabIndex = 16;
            // 
            // lblusuario_correo
            // 
            this.lblusuario_correo.AutoSize = true;
            this.lblusuario_correo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblusuario_correo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblusuario_correo.Location = new System.Drawing.Point(461, 222);
            this.lblusuario_correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusuario_correo.Name = "lblusuario_correo";
            this.lblusuario_correo.Size = new System.Drawing.Size(78, 13);
            this.lblusuario_correo.TabIndex = 17;
            this.lblusuario_correo.Text = "Usuario/correo";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.lblcontraseña.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblcontraseña.Location = new System.Drawing.Point(461, 345);
            this.lblcontraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(61, 13);
            this.lblcontraseña.TabIndex = 18;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1378, 759);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario_correo);
            this.Controls.Add(this.panelBarranav);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblCambiarContraseña);
            this.Controls.Add(this.lblEntrarComoInvitado);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picFondoLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventick - Inicio sesión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogIn_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogIn_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLogIn_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picReajustar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoLogIn)).EndInit();
            this.panelBarranav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondoLogIn;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox txtContraseña;
        private System.Windows.Forms.Label lblEntrarComoInvitado;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Label lblCambiarContraseña;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picReajustar;
        private System.Windows.Forms.Panel panelBarranav;
        private System.Windows.Forms.Label lblusuario_correo;
        private System.Windows.Forms.Label lblcontraseña;
    }
}

