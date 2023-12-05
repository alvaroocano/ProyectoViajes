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

        private int ObtenerUltimoId()
        {
            // Obtén el último Id de usuario registrado en la lista
            if (ListaDatosReservas.listaReservas.Count > 0)
            {
                return ListaDatosUsuarios.listaUsuarios.Max(u => u.Id);
            }
            else
            {
                return 1;
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
            int id = ObtenerUltimoId();
            string usuario = textBox.Text;
            string destino = comboBox.Text;
            int nroPersonas = (int)numericUpDown.Value;
            DateTime fechaIda = dateTimePickerIda.Value;
            DateTime fechaVuelta = dateTimePickerVuelta.Value;

            string fechaIdaFormateada = fechaIda.ToString("yyyy-MM-dd");
            string fechaVueltaFormateada = fechaIda.ToString("yyyy-MM-dd");

            // Crear una nueva instancia de Reserva
            Reserva nuevaReserva = new Reserva(id, usuario, destino, nroPersonas, fechaIdaFormateada, fechaVueltaFormateada);

            // Agregar la nueva reserva a la lista
            ListaDatosReservas.listaReservas.Add(nuevaReserva);

            // Escribir la lista actualizada en el archivo JSON
            escribirJSON(ListaDatosReservas.listaReservas);
            MessageBox.Show("Reserva Confirmada");
            form.Close();
        }

        public void crearEtiqueta(int id, string user, string destino, int nroPersonas, string fechaIda, string fechaVuelta, int posicion, System.Windows.Forms.GroupBox g)
        {
            Label GrupoLbl = new System.Windows.Forms.Label();
            GrupoLbl.AutoSize = true;
            GrupoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
           System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)
           (0)));
            GrupoLbl.Location = new System.Drawing.Point(75, posicion);
            GrupoLbl.Name = "lblEmpleado";
            GrupoLbl.Size = new System.Drawing.Size(291, 20);
            GrupoLbl.TabIndex = 1;
            GrupoLbl.Text = id+" "+user + " " + destino + " " + nroPersonas +" "+fechaIda+" "+fechaVuelta;

            Button botonEditar = new System.Windows.Forms.Button();
            botonEditar.AutoSize = true;
            botonEditar.Size = new System.Drawing.Size(82, 20);
            botonEditar.Location = new System.Drawing.Point(GrupoLbl.Right + 20, posicion);
            botonEditar.Text = "Modificar";

            ModificarReserva mr = new ModificarReserva();
            InfoUsuarios info = new InfoUsuarios();

            mr.SetDatos(destino, nroPersonas, fechaIda, fechaVuelta);

            botonEditar.Click += (sender, e) => MiBoton_Click(sender, e, destino, nroPersonas, fechaIda, fechaVuelta, info, mr);

            g.Controls.Add(GrupoLbl);
            g.Controls.Add(botonEditar);
        }

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

            }
            return lista;
        }

        public void crearReservas(System.Windows.Forms.GroupBox g)
        {
            List<Reserva> lista = leerJSON(ListaDatosReservas.listaReservas);
            int pos = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                pos = pos + 30;
                crearEtiqueta(lista[i].Id,lista[i].Usuario, lista[i].Destino, lista[i].NroPersonas, lista[i].FechaIda, lista[i].FechaVuelta, pos, g);

            }
        }

        private void MiBoton_Click(object sender, EventArgs e, string destino, int nroPersonas, string fechaIda, string fechaVuelta, Form form1, Form form2)
        {

            form1.Hide();
            form1.Close();
            form2.ShowDialog();

        }

        public static class ListaDatosReservas
        {
            public static List<Reserva> listaReservas = new List<Reserva>();
        }


    }
}
