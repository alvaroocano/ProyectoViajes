using ProyectoViajes.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoViajes.Views
{
    public partial class FormularioCorreo : Form
    {
        public FormularioCorreo()
        {
            InitializeComponent();
        }

        ControladorContacto cc = new ControladorContacto();
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            cc.SimularEnvioCorreo(txtDestinatario.Text,txtAsunto.Text,txtCorreo.Text);
        }

        private void FormularioCorreo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal p = new Principal();
            p.Show();
        }
    }
}
