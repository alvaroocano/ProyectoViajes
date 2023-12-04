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
        InicioSesion inis = new InicioSesion();

        private void Registro_Load(object sender, EventArgs e)
        {
            edadError.Hide();
            txtUsuario.Select();
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
            cr.validarUsuario(txtUsuario, txtContrasena, txtCorreo, fechaNacimiento, edadError,this, inis);

            
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cr.volverAIniSes(this, inis);
        }

        private void groupBoxInicioSesion_Enter(object sender, EventArgs e)
        {

        }
    }
}
