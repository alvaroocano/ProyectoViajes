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
    public partial class ModificarReserva : Form
    {
        public ModificarReserva()
        {
            InitializeComponent();
        }

        ControladorReserva cr = new ControladorReserva();
        ControladorMenu cm = new ControladorMenu();

        int idReserva = 0;
        public void SetDatos(int id,string destino, int nroPersonas, string fechaIda, string fechaVuelta)
        {
            selectDestino.Text = destino.ToString();
            numPersonas.Value = nroPersonas;
            txtFechaIda.Text = fechaIda.ToString();
            txtFechaVuelta.Text = fechaVuelta.ToString();
            idReserva = id;
            
        }

        private void ModificarReserva_Load(object sender, EventArgs e)
        {
            selectDestino.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InfoReserva ir = new InfoReserva();
            cr.modificarReserva(idReserva, selectDestino.Text, numPersonas, txtFechaIda.Text, txtFechaVuelta.Text, this, ir);
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
