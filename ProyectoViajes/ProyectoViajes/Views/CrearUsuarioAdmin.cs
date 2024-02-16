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
    public partial class CrearUsuarioAdmin : Form
    {
        public CrearUsuarioAdmin()
        {
            InitializeComponent();
        }

        ControladorRegistro cr = new ControladorRegistro();
        ControladorMenu cm = new ControladorMenu(); 
        InfoUsuarios iu = new InfoUsuarios();

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cr.validarUsuario(txtUsuario, txtContrasena, txtCorreo, fechaNacimiento, edadError, this, iu);
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.infoUsuarios(this);
        }

        private void CrearUsuarioAdmin_Load(object sender, EventArgs e)
        {
            edadError.Hide();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            cr.volverBlanco(txtUsuario);
        }

        private void txtContrasena_Click(object sender, EventArgs e)
        {
            cr.volverBlanco(txtContrasena);
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            cr.volverBlanco(txtCorreo);
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
