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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoViajes.Views
{
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        ControladorInfoUsuarios ciu = new ControladorInfoUsuarios();

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {

        }

        public void SetDatos(string user, string email, string fecha)
        {
            textBoxUser.Text = user.ToString();
            textBoxEmail.Text = email.ToString();
            textBoxFecha.Text = fecha.ToString();
        }

       
    }
}
