namespace ProyectoViajes.Views
{
    partial class InfoNaves
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navesDataSet1 = new ProyectoViajes.NavesDataSet1();
            this.navesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navesTableAdapter = new ProyectoViajes.NavesDataSet1TableAdapters.NavesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.estadoMantenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.capacidadDataGridViewTextBoxColumn,
            this.disponibleDataGridViewCheckBoxColumn,
            this.estadoMantenimientoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.navesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(233, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // navesDataSet1
            // 
            this.navesDataSet1.DataSetName = "NavesDataSet1";
            this.navesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // navesBindingSource
            // 
            this.navesBindingSource.DataMember = "Naves";
            this.navesBindingSource.DataSource = this.navesDataSet1;
            // 
            // navesTableAdapter
            // 
            this.navesTableAdapter.ClearBeforeFill = true;
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
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacidadDataGridViewTextBoxColumn
            // 
            this.capacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacidadDataGridViewTextBoxColumn.Name = "capacidadDataGridViewTextBoxColumn";
            this.capacidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // disponibleDataGridViewCheckBoxColumn
            // 
            this.disponibleDataGridViewCheckBoxColumn.DataPropertyName = "Disponible";
            this.disponibleDataGridViewCheckBoxColumn.HeaderText = "Disponible";
            this.disponibleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.disponibleDataGridViewCheckBoxColumn.Name = "disponibleDataGridViewCheckBoxColumn";
            this.disponibleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // estadoMantenimientoDataGridViewTextBoxColumn
            // 
            this.estadoMantenimientoDataGridViewTextBoxColumn.DataPropertyName = "EstadoMantenimiento";
            this.estadoMantenimientoDataGridViewTextBoxColumn.HeaderText = "EstadoMantenimiento";
            this.estadoMantenimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoMantenimientoDataGridViewTextBoxColumn.Name = "estadoMantenimientoDataGridViewTextBoxColumn";
            this.estadoMantenimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InfoNaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 455);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InfoNaves";
            this.Text = "InfoNaves";
            this.Load += new System.EventHandler(this.InfoNaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NavesDataSet1 navesDataSet1;
        private System.Windows.Forms.BindingSource navesBindingSource;
        private NavesDataSet1TableAdapters.NavesTableAdapter navesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disponibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoMantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}