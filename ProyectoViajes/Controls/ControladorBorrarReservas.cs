using ProyectoViajes.Models;
using ProyectoViajes.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static ProyectoViajes.Controls.ControladorInicioSesion;
using static ProyectoViajes.Controls.ControladorReserva;

namespace ProyectoViajes.Controls
{
    internal class ControladorBorrarReservas
    {
        ControladorReserva cr = new ControladorReserva();
        public void crearEtiqueta(int id, string user, string destino, int nroPersonas, string fechaIda, string fechaVuelta, int posicion, System.Windows.Forms.Panel p)
        {
            System.Windows.Forms.CheckBox LblReserva = new System.Windows.Forms.CheckBox();
            LblReserva.AutoSize = true;
            LblReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
           System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)
           (0)));
            LblReserva.Location = new System.Drawing.Point(75, posicion);
            LblReserva.Name = "lblEmpleado";
            LblReserva.Size = new System.Drawing.Size(291, 20);
            LblReserva.TabIndex = 1;
            LblReserva.Name = id.ToString();
            LblReserva.Text = id + " " + user + " " + destino + " " + nroPersonas + " " + fechaIda + " " + fechaVuelta;

            p.Controls.Add(LblReserva);
        }

        public void crearReservas(System.Windows.Forms.Panel p)
        {

            List<Reserva> lista = cr.leerJSON(ListaDatosReservas.listaReservas);
            int pos = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                pos = pos + 30;
                crearEtiqueta(lista[i].Id, lista[i].Usuario, lista[i].Destino, lista[i].NroPersonas, lista[i].FechaIda, lista[i].FechaVuelta, pos, p);

            }
        }

        private List<System.Windows.Forms.CheckBox> ListaChecked = new List<System.Windows.Forms.CheckBox>();
        public void borrarCheckBoxes(System.Windows.Forms.Panel p)
        {
            var checkboxes = p.Controls.OfType<System.Windows.Forms.CheckBox>().Where(x => x.GetType() == typeof(System.Windows.Forms.CheckBox));

            foreach (var ch in checkboxes)
            {
                if (ch.Checked)
                {
                    // Divide el Text del CheckBox para obtener el ID
                    string[] parts = ch.Text.Split(' ');
                    if (parts.Length > 0)
                    {
                        int idToDelete;
                        if (int.TryParse(parts[0], out idToDelete))
                        {
                            // Elimina todas las reservas con el ID correspondiente
                            ListaDatosReservas.listaReservas.RemoveAll(x => x.Id == idToDelete);
                        }
                    }
                }
            }

            p.Controls.Clear();
            int pos = 0;
            for (int i = 0; i < ListaDatosReservas.listaReservas.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(ListaDatosReservas.listaReservas[i].Id, ListaDatosReservas.listaReservas[i].Usuario, ListaDatosReservas.listaReservas[i].Destino, ListaDatosReservas.listaReservas[i].NroPersonas, ListaDatosReservas.listaReservas[i].FechaIda, ListaDatosReservas.listaReservas[i].FechaVuelta, pos, p);
            }

            cr.escribirJSON();
        }


    }
}
