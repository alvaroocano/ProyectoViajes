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
        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cm.modificarReserva(this);
        }

        private void InfoReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal p = new Principal();
            p.Show();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.Close();
            p.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic se hizo en la columna de botones y no en el encabezado de la columna
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Modificar")
            {
                // Obtén el valor del ID del usuario de la fila en la que se hizo clic
                int idReserva = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                // Abre el formulario ModificarUsuario y pasa el ID del usuario
                ModificarReserva formularioModificar = new ModificarReserva();
                formularioModificar.SetDatos(idReserva);
                formularioModificar.ShowDialog();
                this.Hide();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.eliminarReservasSeleccionadas(dataGridView1);
            this.Close();
        }
    }
}
