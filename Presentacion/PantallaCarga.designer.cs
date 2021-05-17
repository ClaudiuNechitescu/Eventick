
namespace Eventick
{
    partial class PantallaCarga
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCarga));
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // picFondo
            // 
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.Location = new System.Drawing.Point(1, 1);
            this.picFondo.Margin = new System.Windows.Forms.Padding(2);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(1410, 788);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // tmrReloj
            // 
            this.tmrReloj.Interval = 40;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // tmr2
            // 
            this.tmr2.Interval = 40;
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // picLoading
            // 
            this.picLoading.BackColor = System.Drawing.Color.Transparent;
            this.picLoading.Location = new System.Drawing.Point(681, 401);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(115, 115);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 1;
            this.picLoading.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(606, 443);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(143, 40);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "label1";
            // 
            // PantallaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 483);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.picFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaCarga";
            this.Text = "PantallaInicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Label lblTitulo;
    }
}