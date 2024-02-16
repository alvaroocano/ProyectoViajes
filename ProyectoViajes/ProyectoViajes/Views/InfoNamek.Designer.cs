namespace ProyectoViajes.Views
{
    partial class InfoNamek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoNamek));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tituloNamek = new System.Windows.Forms.Label();
            this.pictureNamek = new System.Windows.Forms.PictureBox();
            this.linkReservaNamek = new System.Windows.Forms.LinkLabel();
            this.textoNamek = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNamek)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1620, 28);
            this.menuStrip.TabIndex = 1;
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
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tituloNamek, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureNamek, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkReservaNamek, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textoNamek, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 49, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1620, 926);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tituloNamek
            // 
            this.tituloNamek.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tituloNamek.AutoSize = true;
            this.tituloNamek.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloNamek.Location = new System.Drawing.Point(717, 361);
            this.tituloNamek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloNamek.Name = "tituloNamek";
            this.tituloNamek.Size = new System.Drawing.Size(186, 31);
            this.tituloNamek.TabIndex = 9;
            this.tituloNamek.Text = "Planeta Namek";
            // 
            // pictureNamek
            // 
            this.pictureNamek.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureNamek.Image = ((System.Drawing.Image)(resources.GetObject("pictureNamek.Image")));
            this.pictureNamek.Location = new System.Drawing.Point(620, 16);
            this.pictureNamek.Margin = new System.Windows.Forms.Padding(4);
            this.pictureNamek.Name = "pictureNamek";
            this.pictureNamek.Size = new System.Drawing.Size(380, 331);
            this.pictureNamek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNamek.TabIndex = 0;
            this.pictureNamek.TabStop = false;
            // 
            // linkReservaNamek
            // 
            this.linkReservaNamek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkReservaNamek.AutoSize = true;
            this.linkReservaNamek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReservaNamek.Location = new System.Drawing.Point(745, 846);
            this.linkReservaNamek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkReservaNamek.Name = "linkReservaNamek";
            this.linkReservaNamek.Size = new System.Drawing.Size(129, 25);
            this.linkReservaNamek.TabIndex = 3;
            this.linkReservaNamek.TabStop = true;
            this.linkReservaNamek.Text = "Reserva Aquí";
            this.linkReservaNamek.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReservaNamek_LinkClicked);
            // 
            // textoNamek
            // 
            this.textoNamek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textoNamek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoNamek.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNamek.Location = new System.Drawing.Point(368, 396);
            this.textoNamek.Margin = new System.Windows.Forms.Padding(4);
            this.textoNamek.Name = "textoNamek";
            this.textoNamek.ReadOnly = true;
            this.textoNamek.Size = new System.Drawing.Size(883, 430);
            this.textoNamek.TabIndex = 1;
            this.textoNamek.Text = resources.GetString("textoNamek.Text");
            // 
            // InfoNamek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1001);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfoNamek";
            this.Text = "InfoNamek";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoNamek_FormClosed);
            this.Load += new System.EventHandler(this.InfoNamek_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNamek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureNamek;
        private System.Windows.Forms.RichTextBox textoNamek;
        private System.Windows.Forms.LinkLabel linkReservaNamek;
        private System.Windows.Forms.Label tituloNamek;
    }
}