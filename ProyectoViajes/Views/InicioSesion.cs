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
using ProyectoViajes.Views;
using static ProyectoViajes.Controls.ControladorInicioSesion;

namespace ProyectoViajes
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        ControladorInicioSesion cis = new ControladorInicioSesion();


        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            cis.redirigirRegistro();
            

        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
           
            cis.cargarUsuarios();
           
        }

        public static int contador = 0;
        int intentosFallidos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            if (cis.validarCredenciales(usuario, contraseña))
            {
                // Las credenciales son válidas, mostrar el formulario deseado
                UsuarioActual.EstablecerNombreUsuario(usuario);
                Principal pr = new Principal();
                pr.Show();
            }
            else
            {
                intentosFallidos++;

                if (intentosFallidos >= 4)
                {
                    // Si el usuario introduce mal el usuario y contraseña al cuarto intento, cerrar la aplicación
                    MessageBox.Show("Has excedido el número máximo de intentos fallidos. La aplicación se cerrará.");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.");
                }
            }

        }
    }
}
