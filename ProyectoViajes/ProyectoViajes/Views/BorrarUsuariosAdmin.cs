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
using static ProyectoViajes.Controls.ControladorInicioSesion;

namespace ProyectoViajes.Views
{
    public partial class BorrarUsuariosAdmin : Form
    {
        public BorrarUsuariosAdmin()
        {
            InitializeComponent();
        }
        ControladorMenu cm = new ControladorMenu();
        ControladorBorrar cb = new ControladorBorrar();
        ControladorUsuariosAdmin cua = new ControladorUsuariosAdmin();  
        private void BorrarUsuariosAdmin_Load(object sender, EventArgs e)
        {
            cb.cargarUsuarios(ListaDatosUsuarios.listaUsuarios, panel1);
        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.borrarUsuario(this);
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.infoUsuarios(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb.borrarCheckBoxes(panel1);
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
