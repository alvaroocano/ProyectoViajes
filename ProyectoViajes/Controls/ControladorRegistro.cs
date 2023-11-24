using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoViajes.Models;
using static ProyectoViajes.Controls.ControladorInicioSesion;

namespace ProyectoViajes.Controls
{
    internal class ControladorRegistro
    {
        public void cargarUsuarios()
        {
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario(1, "admin", "1234", "admin@admin.com", DateTime.Now));

        }

        public void escribirXML()
        {
            try
            {
                using (var writer = new StreamWriter("usuarios.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(ListaDatosUsuarios.listaUsuarios.GetType());
                    serializer.Serialize(writer, ListaDatosUsuarios.listaUsuarios, namespaces);
                }
            }
            catch (Exception e) { }
        }

        public void leerXML()
        {
            try
            {
                string xml = File.ReadAllText("usuarios.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new
                    XmlSerializer(ListaDatosUsuarios.listaUsuarios.GetType());
                    ListaDatosUsuarios.listaUsuarios = (List<Usuario>)serializer.Deserialize(reader);
                    System.Console.WriteLine(xml);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }
        }

        bool EsMayorDeEdad(DateTime fecha)
        {
            // Calcular la edad
            int edad = DateTime.Now.Year - fecha.Year;

            // Ajustar la edad si aún no ha pasado el cumpleaños de este año
            if (DateTime.Now < fecha.AddYears(edad))
            {
                edad--;
            }

            // Verificar si la edad es 18 o más
            return edad >= 18;
        }

        private int contador = 1;
        public void validarEmpleado(TextBox nombre, TextBox pass, TextBox correo, DateTimePicker fechaNacimiento, TextBox errorEdad)
        {
            bool todoBien = true;

            if (nombre.Text.Equals(""))
            {
                nombre.BackColor = Color.Red;
                todoBien = false;
            }

            if (pass.Text.Equals(""))
            {
                pass.BackColor = Color.Red;
                todoBien = false;
            }

            if (correo.Text.Equals(""))
            {
                correo.BackColor = Color.Red;
                todoBien = false;
            }

            DateTime fechaSeleccionada = fechaNacimiento.Value;

            if (!EsMayorDeEdad(fechaSeleccionada))
            {
                errorEdad.Show();
                todoBien = false;
            }
            else
            {
                errorEdad.Hide();
            }

            if (todoBien)
            {
                MessageBox.Show("Todo OK");
                int idUsuario = contador++;

            }
        }

        public void volverBlanco(TextBox caja)
        {
            caja.BackColor = Color.White;
        }

    }
}
