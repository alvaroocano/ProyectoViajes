using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoViajes.Models;
using ProyectoViajes.Views;

namespace ProyectoViajes.Controls
{
    internal class ControladorPrincipal
    {
    
        ControladorInicioSesion cis = new ControladorInicioSesion();
        string nombreUsuario = UsuarioActual.NombreUsuario;
        public void esconderMenu(MenuStrip m)
        {
            if (nombreUsuario.Equals("admin"))
            {
                m.Show();
            }
            else
            {
                m.Hide();
            }
        }

    }
}
