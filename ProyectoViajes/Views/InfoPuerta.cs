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
    }
}
