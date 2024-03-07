using ProyectoViajes.Controls;
using ProyectoViajes.Models;
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

        ControladorReserva cr = new ControladorReserva();
        ControladorMenu cm = new ControladorMenu();

        int idReserva = 0;
        public void SetDatos(int id)
        {
            Reserva reserva = cr.ObtenerDetallesReservaPorID(id);

            // Verifica si se encontró el usuario
            if (reserva != null)
            {
                // Asigna los datos del usuario a los controles del formulario
                selectDestino.SelectedItem = reserva.Destino;
                numPersonas.Value = reserva.NroPersonas;
                idReserva = reserva.Id;
            }
            else
            {
                // Si no se encuentra el usuario, muestra un mensaje de error o realiza alguna otra acción
                MessageBox.Show("No se encontró el usuario con el ID especificado.");
                // Puedes cerrar el formulario o realizar alguna otra acción aquí
                this.Close();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cr.validarReserva(idReserva, selectDestino.SelectedItem.ToString(), Convert.ToInt16(numPersonas.Value), fechaIda.Value, fechaVuelta.Value);
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.modificarReserva(this);
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cm.modificarReserva(this);
        }
    }
}
