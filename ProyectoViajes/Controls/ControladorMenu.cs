using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoViajes.Views;

namespace ProyectoViajes.Controls
{
    internal class ControladorMenu
    {

        public void infoUsuarios(Form form)
        {
            InfoUsuarios iu = new InfoUsuarios();
            form.Hide();
            form.Close();
            iu.ShowDialog();
        }

    }
}
