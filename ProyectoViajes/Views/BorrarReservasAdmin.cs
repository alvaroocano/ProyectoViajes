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
    public partial class BorrarReservasAdmin : Form
    {
        public BorrarReservasAdmin()
        {
            InitializeComponent();
        }

        ControladorBorrarReservas cbr = new ControladorBorrarReservas();
        ControladorMenu cm = new ControladorMenu();
        private void BorrarReservasAdmin_Load(object sender, EventArgs e)
        {
            cbr.crearReservas(panel1);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cbr.borrarCheckBoxes(panel1);
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.infoUsuarios(this);
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.borrarUsuario(this);
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cm.borrarReservas(this);
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cm.modificarReserva(this);
        }
    }
}
