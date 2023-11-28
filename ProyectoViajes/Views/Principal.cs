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

namespace ProyectoViajes.Views
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        ControladorPrincipal cp = new ControladorPrincipal();
        public bool isAdmin;
        private void Principal_Load(object sender, EventArgs e)
        {
            cp.esconderMenu(menuStrip,isAdmin);
        }

        
    }
}
