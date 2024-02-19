using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoViajes.Controls;
using static ProyectoViajes.Controls.ControladorReserva;

namespace ProyectoViajes.Views
{
    public partial class InfoReserva : Form
    {
        public InfoReserva()
        {
            InitializeComponent();
        }

        ControladorReserva cr = new ControladorReserva();
        ControladorMenu cm = new ControladorMenu();

        private void InfoReserva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDatosViajesDataSet.Reservas' Puede moverla o quitarla según sea necesario.
            this.reservasTableAdapter1.Fill(this.baseDatosViajesDataSet.Reservas);
            // TODO: esta línea de código carga datos en la tabla 'baseDatosViajesDataSet.Reservas' Puede moverla o quitarla según sea necesario.


            DataTable dtProyectos = cr.obtenerReservas();

            if (dtProyectos.Rows.Count > 0)
            {
                // Hay datos disponibles, enlaza el DataGridView con el DataTable
                dataGridView1.DataSource = dtProyectos;
            }
            else
            {this.reservasTableAdapter.Fill(this.baseDatosViajesDataSet.Reservas);
                // No hay datos disponibles, muestra un mensaje informativo
                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay datos disponibles.";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.AutoSize = false;
                lblMensaje.Dock = DockStyle.Fill;
                Controls.Add(lblMensaje);
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.modificarReserva(this);
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.borrarUsuario(this);
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cm.modificarReserva(this);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.borrarReservas(this);
        }
    }
}
