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
        ControladorRegistro cr = new ControladorRegistro();
        InfoUsuarios info = new InfoUsuarios();

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {

        }

        private int idGlobal;

        public void SetDatos(string user, string email, string fecha, int id)
        {
            textBoxUser.Text = user.ToString();
            textBoxEmail.Text = email.ToString();
            textBoxFecha.Text = fecha.ToString();
            idGlobal = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ciu.modificarUsuario(textBoxUser, textBoxEmail, textBoxFecha, idGlobal,this, info);
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

        private void textBoxFecha_Click(object sender, EventArgs e)
        {
            cr.volverBlanco(textBoxFecha);
        }
    }
}
