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
            cr.crearReservas(groupBox);
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
