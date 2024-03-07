namespace ProyectoViajes.Views
{
    partial class ReservaViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaViaje));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombreCompañia = new System.Windows.Forms.Label();
            this.groupBoxInicioSesion = new System.Windows.Forms.GroupBox();
            this.fechaVuelta = new System.Windows.Forms.DateTimePicker();
            this.fechaIda = new System.Windows.Forms.DateTimePicker();
            this.lblfechaVuelta = new System.Windows.Forms.Label();
            this.lblfechaIda = new System.Windows.Forms.Label();
            this.nroPersonas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.selectDestino = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nroPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(469, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nombreCompañia
            // 
            this.nombreCompañia.AutoSize = true;
            this.nombreCompañia.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCompañia.Location = new System.Drawing.Point(436, 190);
            this.nombreCompañia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreCompañia.Name = "nombreCompañia";
            this.nombreCompañia.Size = new System.Drawing.Size(235, 27);
            this.nombreCompañia.TabIndex = 3;
            this.nombreCompañia.Text = "CelestialOdysseys";
            this.nombreCompañia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxInicioSesion
            // 
            this.groupBoxInicioSesion.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBoxInicioSesion.Controls.Add(this.fechaVuelta);
            this.groupBoxInicioSesion.Controls.Add(this.fechaIda);
            this.groupBoxInicioSesion.Controls.Add(this.lblfechaVuelta);
            this.groupBoxInicioSesion.Controls.Add(this.lblfechaIda);
            this.groupBoxInicioSesion.Controls.Add(this.nroPersonas);
            this.groupBoxInicioSesion.Controls.Add(this.label2);
            this.groupBoxInicioSesion.Controls.Add(this.selectDestino);
            this.groupBoxInicioSesion.Controls.Add(this.btnCancelar);
            this.groupBoxInicioSesion.Controls.Add(this.btnAceptar);
            this.groupBoxInicioSesion.Controls.Add(this.label1);
            this.groupBoxInicioSesion.Controls.Add(this.lblUsuario);
            this.groupBoxInicioSesion.Controls.Add(this.txtUsuario);
            this.groupBoxInicioSesion.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInicioSesion.Location = new System.Drawing.Point(304, 235);
            this.groupBoxInicioSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInicioSesion.Name = "groupBoxInicioSesion";
            this.groupBoxInicioSesion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxInicioSesion.Size = new System.Drawing.Size(488, 390);
            this.groupBoxInicioSesion.TabIndex = 4;
            this.groupBoxInicioSesion.TabStop = false;
            this.groupBoxInicioSesion.Text = "Reservar Viaje";
            // 
            // fechaVuelta
            // 
            this.fechaVuelta.CalendarFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVuelta.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVuelta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVuelta.Location = new System.Drawing.Point(243, 254);
            this.fechaVuelta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fechaVuelta.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.fechaVuelta.MinDate = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.fechaVuelta.Name = "fechaVuelta";
            this.fechaVuelta.Size = new System.Drawing.Size(169, 26);
            this.fechaVuelta.TabIndex = 13;
            this.fechaVuelta.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // fechaIda
            // 
            this.fechaIda.CalendarFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIda.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIda.Location = new System.Drawing.Point(243, 212);
            this.fechaIda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fechaIda.MaxDate = new System.DateTime(2026, 12, 1, 0, 0, 0, 0);
            this.fechaIda.MinDate = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            this.fechaIda.Name = "fechaIda";
            this.fechaIda.Size = new System.Drawing.Size(169, 26);
            this.fechaIda.TabIndex = 12;
            this.fechaIda.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // lblfechaVuelta
            // 
            this.lblfechaVuelta.AutoSize = true;
            this.lblfechaVuelta.Location = new System.Drawing.Point(51, 249);
            this.lblfechaVuelta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfechaVuelta.Name = "lblfechaVuelta";
            this.lblfechaVuelta.Size = new System.Drawing.Size(161, 30);
            this.lblfechaVuelta.TabIndex = 10;
            this.lblfechaVuelta.Text = "Fecha Vuelta";
            // 
            // lblfechaIda
            // 
            this.lblfechaIda.AutoSize = true;
            this.lblfechaIda.Location = new System.Drawing.Point(85, 208);
            this.lblfechaIda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfechaIda.Name = "lblfechaIda";
            this.lblfechaIda.Size = new System.Drawing.Size(126, 30);
            this.lblfechaIda.TabIndex = 9;
            this.lblfechaIda.Text = "Fecha Ida";
            // 
            // nroPersonas
            // 
            this.nroPersonas.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroPersonas.Location = new System.Drawing.Point(243, 156);
            this.nroPersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nroPersonas.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nroPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nroPersonas.Name = "nroPersonas";
            this.nroPersonas.Size = new System.Drawing.Size(120, 28);
            this.nroPersonas.TabIndex = 8;
            this.nroPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nº Personas";
            // 
            // selectDestino
            // 
            this.selectDestino.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDestino.FormattingEnabled = true;
            this.selectDestino.Items.AddRange(new object[] {
            "Puerta Celestial",
            "DeAgostini",
            "Namek"});
            this.selectDestino.Location = new System.Drawing.Point(243, 110);
            this.selectDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectDestino.Name = "selectDestino";
            this.selectDestino.Size = new System.Drawing.Size(169, 31);
            this.selectDestino.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(271, 327);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 38);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(123, 326);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 38);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destino";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(117, 48);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(95, 30);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(243, 48);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(169, 31);
            this.txtUsuario.TabIndex = 0;
            // 
            // ReservaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 651);
            this.Controls.Add(this.groupBoxInicioSesion);
            this.Controls.Add(this.nombreCompañia);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReservaViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservaViaje";
            this.Load += new System.EventHandler(this.ReservaViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInicioSesion.ResumeLayout(false);
            this.groupBoxInicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nroPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nombreCompañia;
        private System.Windows.Forms.GroupBox groupBoxInicioSesion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox selectDestino;
        private System.Windows.Forms.NumericUpDown nroPersonas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfechaVuelta;
        private System.Windows.Forms.Label lblfechaIda;
        private System.Windows.Forms.DateTimePicker fechaVuelta;
        private System.Windows.Forms.DateTimePicker fechaIda;
    }
}