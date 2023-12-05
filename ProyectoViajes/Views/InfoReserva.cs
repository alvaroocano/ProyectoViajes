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
using static ProyectoViajes.Controls.ControladorReserva;

namespace ProyectoViajes.Views
{
    public partial class InfoReserva : Form
    {
        public InfoReserva()
        {
            InitializeComponent();
        }

        ControladorReserva cr = new ControladorReserva();

        private void InfoReserva_Load(object sender, EventArgs e)
        {
            cr.crearReservas(groupBox);
        }
    }
}
