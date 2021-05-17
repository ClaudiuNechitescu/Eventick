
namespace Eventick
{
    partial class CambiarContraseña
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContraseña));
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtViejaContraseña = new System.Windows.Forms.TextBox();
            this.panelBarranav = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picReajustar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.lblusuario_correo = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.btnCambiarContraseña = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            this.panelBarranav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReajustar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // picFondo
            // 
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.Location = new System.Drawing.Point(-1, 29);
            this.picFondo.Margin = new System.Windows.Forms.Padding(2);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(1383, 738);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // picAtras
            // 
            this.picAtras.Image = ((System.Drawing.Image)(resources.GetObject("picAtras.Image")));
            this.picAtras.Location = new System.Drawing.Point(217, 170);
            this.picAtras.Margin = new System.Windows.Forms.Padding(2);
            this.picAtras.Name = "picAtras";
            this.picAtras.Size = new System.Drawing.Size(35, 39);
            this.picAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAtras.TabIndex = 8;
            this.picAtras.TabStop = false;
            this.picAtras.Click += new System.EventHandler(this.picAtras_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(491, 285);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 33);
            this.txtEmail.TabIndex = 13;
            // 
            // txtViejaContraseña
            // 
            this.txtViejaContraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.txtViejaContraseña.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViejaContraseña.Location = new System.Drawing.Point(490, 381);
            this.txtViejaContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtViejaContraseña.Name = "txtViejaContraseña";
            this.txtViejaContraseña.PasswordChar = '*';
            this.txtViejaContraseña.Size = new System.Drawing.Size(281, 33);
            this.txtViejaContraseña.TabIndex = 14;
            // 
            // panelBarranav
            // 
            this.panelBarranav.Controls.Add(this.picCerrar);
            this.panelBarranav.Controls.Add(this.picReajustar);
            this.panelBarranav.Controls.Add(this.picMinimizar);
            this.panelBarranav.Location = new System.Drawing.Point(0, -1);
            this.panelBarranav.Name = "panelBarranav";
            this.panelBarranav.Size = new System.Drawing.Size(1382, 30);
            this.panelBarranav.TabIndex = 21;
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(1330, 4);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(22, 21);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrar.TabIndex = 14;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // picReajustar
            // 
            this.picReajustar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picReajustar.Image = ((System.Drawing.Image)(resources.GetObject("picReajustar.Image")));
            this.picReajustar.Location = new System.Drawing.Point(1304, 4);
            this.picReajustar.Margin = new System.Windows.Forms.Padding(2);
            this.picReajustar.Name = "picReajustar";
            this.picReajustar.Size = new System.Drawing.Size(22, 21);
            this.picReajustar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReajustar.TabIndex = 16;
            this.picReajustar.TabStop = false;
            this.picReajustar.Click += new System.EventHandler(this.picReajustar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(1278, 4);
            this.picMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(22, 21);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizar.TabIndex = 15;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContraseña.Location = new System.Drawing.Point(490, 478);
            this.txtNuevaContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(281, 33);
            this.txtNuevaContraseña.TabIndex = 22;
            // 
            // lblusuario_correo
            // 
            this.lblusuario_correo.AutoSize = true;
            this.lblusuario_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.lblusuario_correo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblusuario_correo.Location = new System.Drawing.Point(490, 267);
            this.lblusuario_correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusuario_correo.Name = "lblusuario_correo";
            this.lblusuario_correo.Size = new System.Drawing.Size(78, 13);
            this.lblusuario_correo.TabIndex = 23;
            this.lblusuario_correo.Text = "Usuario/correo";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.lblcontraseña.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblcontraseña.Location = new System.Drawing.Point(488, 363);
            this.lblcontraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(99, 13);
            this.lblcontraseña.TabIndex = 24;
            this.lblcontraseña.Text = "Contraseña antigua";
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.lblNuevaContraseña.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(488, 460);
            this.lblNuevaContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(95, 13);
            this.lblNuevaContraseña.TabIndex = 25;
            this.lblNuevaContraseña.Text = "Nueva contraseña";
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(194)))));
            this.btnCambiarContraseña.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnCambiarContraseña.ButtonColor = System.Drawing.Color.YellowGreen;
            this.btnCambiarContraseña.FlatAppearance.BorderSize = 0;
            this.btnCambiarContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCambiarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(685, 561);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnCambiarContraseña.OnHoverButtonColor = System.Drawing.Color.Empty;
            this.btnCambiarContraseña.OnHoverTextColor = System.Drawing.Color.Empty;
            this.btnCambiarContraseña.Size = new System.Drawing.Size(237, 39);
            this.btnCambiarContraseña.TabIndex = 26;
            this.btnCambiarContraseña.Text = "Cambiar contraseña";
            this.btnCambiarContraseña.TextColor = System.Drawing.Color.Black;
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 738);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.lblNuevaContraseña);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario_correo);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtViejaContraseña);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.picAtras);
            this.Controls.Add(this.picFondo);
            this.Controls.Add(this.panelBarranav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CambiarContraseña";
            this.Text = "RecuperarContraseña";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CambiarContraseña_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CambiarContraseña_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CambiarContraseña_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            this.panelBarranav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReajustar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.PictureBox picAtras;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtViejaContraseña;
        private System.Windows.Forms.Panel panelBarranav;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picReajustar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Label lblusuario_correo;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private ePOSOne.btnProduct.Button_WOC btnCambiarContraseña;
    }
}