using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoViajes.Views;

namespace ProyectoViajes.Controls
{
    internal class ControladorPrincipal
    {
    
        ControladorInicioSesion cis = new ControladorInicioSesion();
        public void esconderMenu(MenuStrip m, bool esAdmin)
        {
            if (esAdmin)
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
