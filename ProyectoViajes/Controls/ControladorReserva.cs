using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoViajes.Models;
using ProyectoViajes.Views;
using static ProyectoViajes.Controls.ControladorInicioSesion;

namespace ProyectoViajes.Controls
{
    internal class ControladorReserva
    {
        // Escribe la lista de reservas en un archivo JSON
        public void escribirJSON()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(ListaDatosReservas.listaReservas);
                string rutaArchivo = "reservas.json";
                File.WriteAllText(rutaArchivo, jsonString);
                MessageBox.Show($"Reservas guardadas en: {rutaArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                // Manejar excepciones si es necesario
            }
        }

        // Lee la lista de reservas desde un archivo JSON y la devuelve
        public List<Reserva> leerJSON()
        {
            try
            {
                if (File.Exists("reservas.json"))
                {
                    string jsonString = File.ReadAllText("reservas.json");
                    ListaDatosReservas.listaReservas = JsonSerializer.Deserialize<List<Reserva>>(jsonString);
                    System.Console.WriteLine(jsonString);
                }
            }
            catch (Exception e)
            {
                // Manejar excepciones si es necesario
            }
            return ListaDatosReservas.listaReservas;
        }

        // Obtiene el último Id de reserva registrado
        private int ObtenerUltimoId()
        {
            List<Reserva> lista = leerJSON();
            if (lista.Count == 0)
            {
                return 1;
            }
            else
            {
                return lista.Max(u => u.Id) + 1;
            }
        }

        // Realiza una nueva reserva y la agrega a la lista de reservas
        public void realizarReserva(System.Windows.Forms.TextBox textBox, System.Windows.Forms.ComboBox comboBox, System.Windows.Forms.NumericUpDown numericUpDown, System.Windows.Forms.DateTimePicker dateTimePickerIda, System.Windows.Forms.DateTimePicker dateTimePickerVuelta, Form form)
        {
            if (dateTimePickerVuelta.Value <= dateTimePickerIda.Value)
            {
                MessageBox.Show("La fecha de vuelta debe ser posterior a la fecha de ida.");
                return;
            }

            int id = ObtenerUltimoId();
            string usuario = textBox.Text;
            string destino = comboBox.Text;
            int nroPersonas = (int)numericUpDown.Value;
            DateTime fechaIda = dateTimePickerIda.Value;
            DateTime fechaVuelta = dateTimePickerVuelta.Value;

            string fechaIdaFormateada = fechaIda.ToString("yyyy-MM-dd");
            string fechaVueltaFormateada = fechaVuelta.ToString("yyyy-MM-dd");

            Reserva nuevaReserva = new Reserva(id, usuario, destino, nroPersonas, fechaIdaFormateada, fechaVueltaFormateada);
            ListaDatosReservas.listaReservas.Add(nuevaReserva);

            escribirJSON();
            MessageBox.Show("Reserva Confirmada");
            form.Close();
        }

        // Crea una etiqueta con la información de una reserva y un botón para editar
        public void crearEtiqueta(int id, string user, string destino, int nroPersonas, string fechaIda, string fechaVuelta, int posicion, System.Windows.Forms.GroupBox g)
        {
            Label GrupoLbl = new System.Windows.Forms.Label();
            GrupoLbl.AutoSize = true;
            GrupoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GrupoLbl.Location = new System.Drawing.Point(75, posicion);
            GrupoLbl.Name = "lblEmpleado";
            GrupoLbl.Size = new System.Drawing.Size(291, 20);
            GrupoLbl.TabIndex = 1;
            GrupoLbl.Text = id + " " + user + " " + destino + " " + nroPersonas + " " + fechaIda + " " + fechaVuelta;

            Button botonEditar = new System.Windows.Forms.Button();
            botonEditar.AutoSize = true;
            botonEditar.Size = new System.Drawing.Size(82, 20);
            botonEditar.Location = new System.Drawing.Point(GrupoLbl.Right + 100, posicion);
            botonEditar.Text = "Modificar";

            ModificarReserva mr = new ModificarReserva();
            InfoUsuarios info = new InfoUsuarios();

            mr.SetDatos(id, destino, nroPersonas, fechaIda, fechaVuelta);

            botonEditar.Click += (sender, e) => MiBoton_Click(sender, e, destino, nroPersonas, fechaIda, fechaVuelta, info, mr);

            g.Controls.Add(GrupoLbl);
            g.Controls.Add(botonEditar);
        }

        // Lee la lista de reservas desde un archivo JSON y la devuelve
        public List<Reserva> leerJSON(List<Reserva> lista)
        {
            try
            {
                if (File.Exists("reservas.json"))
                {
                    string jsonString = File.ReadAllText("reservas.json");
                    lista = JsonSerializer.Deserialize<List<Reserva>>(jsonString);
                    System.Console.WriteLine(jsonString);
                }
            }
            catch (Exception e)
            {
                // Manejar excepciones si es necesario
            }
            return lista;
        }

        // Crea las etiquetas de reservas en un formulario
        public void crearReservas(System.Windows.Forms.GroupBox g)
        {
            List<Reserva> lista = leerJSON(ListaDatosReservas.listaReservas);
            int pos = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                pos = pos + 30;
                crearEtiqueta(lista[i].Id, lista[i].Usuario, lista[i].Destino, lista[i].NroPersonas, lista[i].FechaIda, lista[i].FechaVuelta, pos, g);
            }
        }

        // Manejador de eventos del botón de edición de reserva
        private void MiBoton_Click(object sender, EventArgs e, string destino, int nroPersonas, string fechaIda, string fechaVuelta, Form form1, Form form2)
        {
            form1.Hide();
            form1.Close();
            form2.ShowDialog();
        }

        // Modifica una reserva existente
        public void modificarReserva(int id, string destino, NumericUpDown nroPersonas, string fechaIda, string fechaVuelta, Form form1, Form form2)
        {
            List<Reserva> listaReservas = leerJSON(ListaDatosReservas.listaReservas);

            Reserva reservaExistente = listaReservas.FirstOrDefault(reserva => reserva.Id == id);

            if (!EsFechaVueltaValida(fechaIda, fechaVuelta))
            {
                MessageBox.Show("La fecha de vuelta debe ser mayor que la fecha de ida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reservaExistente.Destino = destino;
            reservaExistente.NroPersonas = (int)nroPersonas.Value;
            reservaExistente.FechaIda = fechaIda;
            reservaExistente.FechaVuelta = fechaVuelta;

            MessageBox.Show("Reserva modificada con éxito");

            escribirJSON();
            form1.Hide();
            form1.Close();
            form2.ShowDialog();
        }

        // Verifica si la fecha de vuelta es válida
        private bool EsFechaVueltaValida(string fechaIda, string fechaVuelta)
        {
            DateTime fechaIdaDateTime, fechaVueltaDateTime;
            if (!DateTime.TryParse(fechaIda, out fechaIdaDateTime) || !DateTime.TryParse(fechaVuelta, out fechaVueltaDateTime))
            {
                MessageBox.Show("Error al convertir las fechas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return fechaVueltaDateTime > fechaIdaDateTime;
        }

        // Clase estática para almacenar la lista de reservas
        public static class ListaDatosReservas
        {
            public static List<Reserva> listaReservas = new List<Reserva>();
        }
    }

}
