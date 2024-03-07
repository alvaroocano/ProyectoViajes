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

namespace ProyectoViajes.Views
{
    public partial class InfoNamek : Form
    {
        public InfoNamek()
        {
            InitializeComponent();
        }

        ControladorMenu cm = new ControladorMenu();

        private void linkReservaNamek_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cm.reserva();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.infoUsuarios(this);
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        ControladorPrincipal cp = new ControladorPrincipal();
        public bool isAdmin;
        private void InfoNamek_Load(object sender, EventArgs e)
        {
            cp.esconderMenu(menuStrip);
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cm.modificarReserva(this);
        }

        private void InfoNamek_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal pr = new Principal();
            pr.ShowDialog();
        }
    }
}
