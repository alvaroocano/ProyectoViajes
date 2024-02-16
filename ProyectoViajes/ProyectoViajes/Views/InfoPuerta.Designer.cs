namespace ProyectoViajes.Views
{
    partial class InfoPuerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoPuerta));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tituloPuerta = new System.Windows.Forms.Label();
            this.fotoPuerta = new System.Windows.Forms.PictureBox();
            this.linkReservaPuerta = new System.Windows.Forms.LinkLabel();
            this.textoPuerta = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPuerta)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tituloPuerta, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fotoPuerta, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkReservaPuerta, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textoPuerta, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 49, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 418F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1776, 926);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tituloPuerta
            // 
            this.tituloPuerta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tituloPuerta.AutoSize = true;
            this.tituloPuerta.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPuerta.Location = new System.Drawing.Point(746, 361);
            this.tituloPuerta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloPuerta.Name = "tituloPuerta";
            this.tituloPuerta.Size = new System.Drawing.Size(283, 31);
            this.tituloPuerta.TabIndex = 9;
            this.tituloPuerta.Text = "Planeta Puerta Celestial";
            // 
            // fotoPuerta
            // 
            this.fotoPuerta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fotoPuerta.Image = ((System.Drawing.Image)(resources.GetObject("fotoPuerta.Image")));
            this.fotoPuerta.Location = new System.Drawing.Point(698, 16);
            this.fotoPuerta.Margin = new System.Windows.Forms.Padding(4);
            this.fotoPuerta.Name = "fotoPuerta";
            this.fotoPuerta.Size = new System.Drawing.Size(380, 331);
            this.fotoPuerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPuerta.TabIndex = 0;
            this.fotoPuerta.TabStop = false;
            // 
            // linkReservaPuerta
            // 
            this.linkReservaPuerta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkReservaPuerta.AutoSize = true;
            this.linkReservaPuerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReservaPuerta.Location = new System.Drawing.Point(823, 810);
            this.linkReservaPuerta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkReservaPuerta.Name = "linkReservaPuerta";
            this.linkReservaPuerta.Size = new System.Drawing.Size(129, 25);
            this.linkReservaPuerta.TabIndex = 3;
            this.linkReservaPuerta.TabStop = true;
            this.linkReservaPuerta.Text = "Reserva Aquí";
            this.linkReservaPuerta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReservaPuerta_LinkClicked);
            // 
            // textoPuerta
            // 
            this.textoPuerta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textoPuerta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoPuerta.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPuerta.Location = new System.Drawing.Point(446, 396);
            this.textoPuerta.Margin = new System.Windows.Forms.Padding(4);
            this.textoPuerta.Name = "textoPuerta";
            this.textoPuerta.ReadOnly = true;
            this.textoPuerta.Size = new System.Drawing.Size(883, 388);
            this.textoPuerta.TabIndex = 1;
            this.textoPuerta.Text = resources.GetString("textoPuerta.Text");
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1776, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.borrarToolStripMenuItem.Text = "Eliminar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.empleadosToolStripMenuItem.Text = "Reservas";
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // InfoPuerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 945);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfoPuerta";
            this.Text = "InfoPuerta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoPuerta_FormClosed);
            this.Load += new System.EventHandler(this.InfoPuerta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPuerta)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tituloPuerta;
        private System.Windows.Forms.PictureBox fotoPuerta;
        private System.Windows.Forms.LinkLabel linkReservaPuerta;
        private System.Windows.Forms.RichTextBox textoPuerta;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}