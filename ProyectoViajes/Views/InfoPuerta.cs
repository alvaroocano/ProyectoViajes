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
    public partial class InfoPuerta : Form
    {
        public InfoPuerta()
        {
            InitializeComponent();
        }

        ControladorMenu cm = new ControladorMenu();

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

        private void linkReservaPuerta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cm.reserva(this);
        }

        ControladorPrincipal cp = new ControladorPrincipal();
        public bool isAdmin;
        private void InfoPuerta_Load(object sender, EventArgs e)
        {
            
            cp.esconderMenu(menuStrip, isAdmin);
        }

        private void InfoPuerta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal pr = new Principal();
            pr.ShowDialog();
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
