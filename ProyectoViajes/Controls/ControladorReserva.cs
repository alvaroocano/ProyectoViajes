using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoViajes.Models;

namespace ProyectoViajes.Controls
{
    internal class ControladorReserva
    {
        public void escribirJSON(List<Reserva> lista)
        {

            try
            {

                string jsonString = JsonSerializer.Serialize(lista);
                string rutaArchivo = "reservas.json";
                File.WriteAllText(rutaArchivo, jsonString);
                MessageBox.Show($"Reservas guardadas en: {rutaArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {

            }
        }

        public void realizarReserva(System.Windows.Forms.TextBox textBox,System.Windows.Forms.ComboBox comboBox, System.Windows.Forms.NumericUpDown numericUpDown, System.Windows.Forms.DateTimePicker dateTimePickerIda, System.Windows.Forms.DateTimePicker dateTimePickerVuelta, Form form)
        {
            // Validar que la fecha de vuelta sea posterior a la fecha de ida
            if (dateTimePickerVuelta.Value <= dateTimePickerIda.Value)
            {
                MessageBox.Show("La fecha de vuelta debe ser posterior a la fecha de ida.");
                return;
            }

            // Obtener los datos de los controles
            string usuario = textBox.Text;
            string destino = comboBox.Text;
            int nroPersonas = (int)numericUpDown.Value;
            DateTime fechaIda = dateTimePickerIda.Value;
            DateTime fechaVuelta = dateTimePickerVuelta.Value;

            string fechaIdaFormateada = fechaIda.ToString("yyyy-MM-dd");
            string fechaVueltaFormateada = fechaIda.ToString("yyyy-MM-dd");

            // Crear una nueva instancia de Reserva
            Reserva nuevaReserva = new Reserva(usuario, destino, nroPersonas, fechaIdaFormateada, fechaVueltaFormateada);

            // Agregar la nueva reserva a la lista
            ListaDatosReservas.listaReservas.Add(nuevaReserva);

            // Escribir la lista actualizada en el archivo JSON
            escribirJSON(ListaDatosReservas.listaReservas);
            MessageBox.Show("Reserva Confirmada");
            form.Close();
        }

        public static class ListaDatosReservas
        {
            public static List<Reserva> listaReservas = new List<Reserva>();
        }
    }
}
