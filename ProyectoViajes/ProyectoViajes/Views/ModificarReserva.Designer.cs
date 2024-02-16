namespace ProyectoViajes.Views
{
    partial class ModificarReserva
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectDestino = new System.Windows.Forms.ComboBox();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaVuelta = new System.Windows.Forms.DateTimePicker();
            this.fechaIda = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(438, 345);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 49);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(265, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 49);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha de Ida:";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestino.Location = new System.Drawing.Point(321, 99);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(86, 24);
            this.labelDestino.TabIndex = 14;
            this.labelDestino.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nº Personas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modificar Reserva";
            // 
            // selectDestino
            // 
            this.selectDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDestino.FormattingEnabled = true;
            this.selectDestino.Items.AddRange(new object[] {
            "Puerta Celestial",
            "DeAgostini",
            "Namek"});
            this.selectDestino.Location = new System.Drawing.Point(438, 99);
            this.selectDestino.Name = "selectDestino";
            this.selectDestino.Size = new System.Drawing.Size(121, 26);
            this.selectDestino.TabIndex = 1;
            // 
            // numPersonas
            // 
            this.numPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPersonas.Location = new System.Drawing.Point(438, 154);
            this.numPersonas.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(120, 26);
            this.numPersonas.TabIndex = 2;
            this.numPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha de Vuelta:";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 22;
            this.menuStrip.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.borrarToolStripMenuItem.Text = "Eliminar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.empleadosToolStripMenuItem.Text = "Reservas";
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // fechaVuelta
            // 
            this.fechaVuelta.CalendarFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVuelta.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaVuelta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVuelta.Location = new System.Drawing.Point(438, 271);
            this.fechaVuelta.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.fechaVuelta.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaVuelta.Name = "fechaVuelta";
            this.fechaVuelta.Size = new System.Drawing.Size(128, 22);
            this.fechaVuelta.TabIndex = 23;
            this.fechaVuelta.Value = new System.DateTime(2023, 11, 22, 0, 0, 0, 0);
            // 
            // fechaIda
            // 
            this.fechaIda.CalendarFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIda.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIda.Location = new System.Drawing.Point(438, 215);
            this.fechaIda.MaxDate = new System.DateTime(2026, 12, 30, 0, 0, 0, 0);
            this.fechaIda.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fechaIda.Name = "fechaIda";
            this.fechaIda.Size = new System.Drawing.Size(128, 22);
            this.fechaIda.TabIndex = 24;
            this.fechaIda.Value = new System.DateTime(2023, 11, 22, 0, 0, 0, 0);
            // 
            // ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fechaIda);
            this.Controls.Add(this.fechaVuelta);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.selectDestino);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarReserva";
            this.Load += new System.EventHandler(this.ModificarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectDestino;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker fechaVuelta;
        private System.Windows.Forms.DateTimePicker fechaIda;
    }
}