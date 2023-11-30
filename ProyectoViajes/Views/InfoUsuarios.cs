using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoViajes.Models;
using static ProyectoViajes.Controls.ControladorInicioSesion;
using System.Xml.Serialization;
using ProyectoViajes.Controls;

namespace ProyectoViajes.Views
{
    public partial class InfoUsuarios : Form
    {
        public InfoUsuarios()
        {
            InitializeComponent();
        }

        ControladorInfoUsuarios ciu = new ControladorInfoUsuarios();

        private void InfoUsuarios_Load(object sender, EventArgs e)
        {
            ciu.crearEmpleados(ListaDatosUsuarios.listaUsuarios, groupBox);
        }

       
    }
}
