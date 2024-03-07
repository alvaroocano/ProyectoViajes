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
using ProyectoViajes.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoViajes.Views
{
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        ControladorUsuariosAdmin ciu = new ControladorUsuariosAdmin();
        ControladorMenu cm = new ControladorMenu();
        ControladorRegistro cr = new ControladorRegistro();

        private int idGlobal;

        public void SetDatos(int id)
        {
            Usuario usuario = ciu.ObtenerDetallesUsuarioPorID(id);

            // Verifica si se encontró el usuario
            if (usuario != null)
            {
                // Asigna los datos del usuario a los controles del formulario
                textBoxUser.Text = usuario.user;
                textBoxEmail.Text = usuario.correo;
                idGlobal = usuario.Id;
            }
            else
            {
                // Si no se encuentra el usuario, muestra un mensaje de error o realiza alguna otra acción
                MessageBox.Show("No se encontró el usuario con el ID especificado.");
                // Puedes cerrar el formulario o realizar alguna otra acción aquí
                this.Close();
            }
        }

        infoUsuariosBBDD iub = new infoUsuariosBBDD();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ciu.validarUsuario(textBoxUser, textBoxEmail, fechaNacimiento, idGlobal, this, iub);
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            cr.volverBlanco(textBoxUser);
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            cr.volverBlanco(textBoxEmail);
        }

        

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.infoUsuarios(this);
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }
        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cm.modificarReserva(this);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ModificarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
