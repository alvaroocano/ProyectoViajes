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
    public partial class ReservaViaje : Form
    {
        public ReservaViaje()
        {
            InitializeComponent();
        }

        private void ReservaViaje_Load(object sender, EventArgs e)
        {
            string usuarioActual = SesionUsuario.UsuarioActual;
            txtUsuario.Text = usuarioActual;
            fechaIda.MinDate = DateTime.Now;
            fechaVuelta.MinDate = DateTime.Now.AddDays(1);
        }
    }
}
