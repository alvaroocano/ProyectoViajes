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
    public partial class ModificarReserva : Form
    {
        public ModificarReserva()
        {
            InitializeComponent();
        }

        public void SetDatos(string destino, int nroPersonas, string fechaIda, string fechaVuelta)
        {
            selectDestino.Text = destino.ToString();
            numPersonas.Value = nroPersonas;
            txtFechaIda.Text = fechaIda.ToString();
            txtFechaVuelta.Text = fechaVuelta.ToString();
            
            
        }

        private void ModificarReserva_Load(object sender, EventArgs e)
        {
            selectDestino.Select();
        }
    }
}
