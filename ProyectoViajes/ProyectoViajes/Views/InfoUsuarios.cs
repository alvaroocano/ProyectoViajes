using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoViajes.Models;
using static ProyectoViajes.Controls.ControladorInicioSesion;
using System.Xml.Serialization;
using ProyectoViajes.Controls;

namespace ProyectoViajes.Views
{
    public partial class InfoUsuarios : Form
    {
        public InfoUsuarios()
        {
            InitializeComponent();
        }

        ControladorUsuariosAdmin ciu = new ControladorUsuariosAdmin();
        ControladorMenu cm = new ControladorMenu();

        private void InfoUsuarios_Load(object sender, EventArgs e)
        {
            ciu.crearUsuarios(ListaDatosUsuarios.listaUsuarios, groupBox);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ciu.refrescar(this);
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            ciu.filtrar(groupBox, txtFiltrar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciu.ordenar(comboBox1.Text, groupBox);
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.borrarUsuario(this);
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

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
