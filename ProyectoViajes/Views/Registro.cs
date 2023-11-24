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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        ControladorRegistro cr = new ControladorRegistro();

        private void Registro_Load(object sender, EventArgs e)
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cr.validarEmpleado(txtUsuario, txtContrasena, txtCorreo, fechaNacimiento, edadError);

            
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
