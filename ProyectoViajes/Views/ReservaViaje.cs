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
using static ProyectoViajes.Controls.ControladorInicioSesion;

namespace ProyectoViajes.Views
{
    public partial class ReservaViaje : Form
    {
        public ReservaViaje()
        {
            InitializeComponent();
        }
        
        ControladorReserva cr = new ControladorReserva();

        private void ReservaViaje_Load(object sender, EventArgs e)
        {
            string usuarioActual = UsuarioActual.NombreUsuario;
            txtUsuario.Text = usuarioActual;
            
            fechaIda.MinDate = DateTime.Now;
            fechaIda.Value = DateTime.Now;
            fechaVuelta.MinDate = DateTime.Now.AddDays(1);
            fechaVuelta.Value = DateTime.Now.AddDays(1);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cr.realizarReserva(txtUsuario, selectDestino, nroPersonas, fechaIda, fechaVuelta, this);
        }
    }
}
