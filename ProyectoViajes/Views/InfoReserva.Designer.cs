﻿namespace ProyectoViajes.Views
{
    partial class InfoReserva
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
            this.titulo = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baseDatosViajesDataSetReservas = new ProyectoViajes.BaseDatosViajesDataSetReservas();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasTableAdapter = new ProyectoViajes.BaseDatosViajesDataSetReservasTableAdapters.ReservasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroPersonasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVueltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosViajesDataSetReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(427, 55);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(185, 42);
            this.titulo.TabIndex = 8;
            this.titulo.Text = "Reservas";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.borrarToolStripMenuItem.Text = "Eliminar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.empleadosToolStripMenuItem.Text = "Reservas";
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.nroPersonasDataGridViewTextBoxColumn,
            this.fechaIdaDataGridViewTextBoxColumn,
            this.fechaVueltaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(75, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(893, 387);
            this.dataGridView1.TabIndex = 11;
            // 
            // baseDatosViajesDataSetReservas
            // 
            this.baseDatosViajesDataSetReservas.DataSetName = "BaseDatosViajesDataSetReservas";
            this.baseDatosViajesDataSetReservas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "Reservas";
            this.reservasBindingSource.DataSource = this.baseDatosViajesDataSetReservas;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "destino";
            this.destinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            this.destinoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nroPersonasDataGridViewTextBoxColumn
            // 
            this.nroPersonasDataGridViewTextBoxColumn.DataPropertyName = "nroPersonas";
            this.nroPersonasDataGridViewTextBoxColumn.HeaderText = "nroPersonas";
            this.nroPersonasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nroPersonasDataGridViewTextBoxColumn.Name = "nroPersonasDataGridViewTextBoxColumn";
            this.nroPersonasDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaIdaDataGridViewTextBoxColumn
            // 
            this.fechaIdaDataGridViewTextBoxColumn.DataPropertyName = "fechaIda";
            this.fechaIdaDataGridViewTextBoxColumn.HeaderText = "fechaIda";
            this.fechaIdaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaIdaDataGridViewTextBoxColumn.Name = "fechaIdaDataGridViewTextBoxColumn";
            this.fechaIdaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaVueltaDataGridViewTextBoxColumn
            // 
            this.fechaVueltaDataGridViewTextBoxColumn.DataPropertyName = "fechaVuelta";
            this.fechaVueltaDataGridViewTextBoxColumn.HeaderText = "fechaVuelta";
            this.fechaVueltaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaVueltaDataGridViewTextBoxColumn.Name = "fechaVueltaDataGridViewTextBoxColumn";
            this.fechaVueltaDataGridViewTextBoxColumn.Width = 125;
            // 
            // InfoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.titulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfoReserva";
            this.Text = "ModificarReserva";
            this.Load += new System.EventHandler(this.InfoReserva_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDatosViajesDataSetReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BaseDatosViajesDataSetReservas baseDatosViajesDataSetReservas;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private BaseDatosViajesDataSetReservasTableAdapters.ReservasTableAdapter reservasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPersonasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVueltaDataGridViewTextBoxColumn;
    }
}