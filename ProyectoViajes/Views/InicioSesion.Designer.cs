namespace ProyectoViajes
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.nombreCompañia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInicioSesion = new System.Windows.Forms.GroupBox();
            this.lblRegistro = new System.Windows.Forms.LinkLabel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInicioSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreCompañia
            // 
            this.nombreCompañia.AutoSize = true;
            this.nombreCompañia.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCompañia.Location = new System.Drawing.Point(335, 139);
            this.nombreCompañia.Name = "nombreCompañia";
            this.nombreCompañia.Size = new System.Drawing.Size(188, 21);
            this.nombreCompañia.TabIndex = 0;
            this.nombreCompañia.Text = "CelestialOdysseys";
            this.nombreCompañia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxInicioSesion
            // 
            this.groupBoxInicioSesion.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBoxInicioSesion.Controls.Add(this.lblRegistro);
            this.groupBoxInicioSesion.Controls.Add(this.lbl2);
            this.groupBoxInicioSesion.Controls.Add(this.btnCancelar);
            this.groupBoxInicioSesion.Controls.Add(this.btnAceptar);
            this.groupBoxInicioSesion.Controls.Add(this.txtContrasena);
            this.groupBoxInicioSesion.Controls.Add(this.label1);
            this.groupBoxInicioSesion.Controls.Add(this.lblUsuario);
            this.groupBoxInicioSesion.Controls.Add(this.txtUsuario);
            this.groupBoxInicioSesion.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInicioSesion.Location = new System.Drawing.Point(276, 188);
            this.groupBoxInicioSesion.Name = "groupBoxInicioSesion";
            this.groupBoxInicioSesion.Size = new System.Drawing.Size(295, 296);
            this.groupBoxInicioSesion.TabIndex = 2;
            this.groupBoxInicioSesion.TabStop = false;
            this.groupBoxInicioSesion.Text = "Iniciar Sesión";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(100, 263);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(109, 21);
            this.lblRegistro.TabIndex = 7;
            this.lblRegistro.TabStop = true;
            this.lblRegistro.Text = "¡Registrate!";
            this.lblRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegistro_LinkClicked);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(71, 247);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(160, 16);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "¿No estás registrado?";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(166, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 31);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(54, 198);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 31);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasena.Location = new System.Drawing.Point(135, 127);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '·';
            this.txtContrasena.Size = new System.Drawing.Size(128, 32);
            this.txtContrasena.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(50, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 24);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Location = new System.Drawing.Point(135, 60);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(128, 32);
            this.txtUsuario.TabIndex = 0;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.groupBoxInicioSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nombreCompañia);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInicioSesion.ResumeLayout(false);
            this.groupBoxInicioSesion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreCompañia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInicioSesion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.LinkLabel lblRegistro;
    }
}

