using ProyectoViajes.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoViajes.Views
{
    public partial class InfoNaves : Form
    {
        public InfoNaves()
        {
            InitializeComponent();
        }

        ControladorNaves cn = new ControladorNaves();

        private void InfoNaves_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'navesDataSet1.Naves' Puede moverla o quitarla según sea necesario.
            this.navesTableAdapter.Fill(this.navesDataSet1.Naves);
            cn.CargarNavesEnComboBox(comboBox1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.CargarDatosEnDataGridView(dataGridView1, comboBox1.SelectedItem.ToString());
        }
    }
}
