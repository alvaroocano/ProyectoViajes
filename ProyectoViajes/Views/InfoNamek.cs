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
            cm.reserva(this);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.infoUsuarios(this);
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.borrarUsuario(this);
        }
    }
}
