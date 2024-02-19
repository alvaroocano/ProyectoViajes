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
    public partial class infoUsuariosBBDD : Form
    {
        public infoUsuariosBBDD()
        {
            InitializeComponent();
        }
        ControladorUsuariosAdmin ciu = new ControladorUsuariosAdmin();
        private void infoUsuariosBBDD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'baseDatosViajesDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.baseDatosViajesDataSet.Usuarios);
            
            DataTable dtProyectos = ciu.obtenerUsuarios();

            if (dtProyectos.Rows.Count > 0)
            {
                // Hay datos disponibles, enlaza el DataGridView con el DataTable
                dataGridView1.DataSource = dtProyectos;
            }
            else
            {
                // No hay datos disponibles, muestra un mensaje informativo
                Label lblMensaje = new Label();
                lblMensaje.Text = "No hay datos disponibles.";
                lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
                lblMensaje.AutoSize = false;
                lblMensaje.Dock = DockStyle.Fill;
                Controls.Add(lblMensaje);
            }
        }

        ControladorMenu cm = new ControladorMenu();

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.borrarUsuario(this);
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.paginaPrincipal(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ciu.eliminarUsuariosSeleccionados(dataGridView1);
        }
    }
}
