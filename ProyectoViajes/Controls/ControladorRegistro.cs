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
using ProyectoViajes.Views;
using static ProyectoViajes.Controls.ControladorInicioSesion;

namespace ProyectoViajes.Controls
{
    internal class ControladorRegistro
    {

        public void cargarUsuarios()
        {
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario(1, "admin", "1234", "admin@admin.com", DateTime.Now));

        }

        public List<Usuario> leerXML()
        {
            try
            {
                string xml = File.ReadAllText("usuarios.xml");
                using (var reader = new StringReader(xml))
                {
                    var serializer = new XmlSerializer(typeof(List<Usuario>));
                    return (List<Usuario>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
                return new List<Usuario>();
            }
        }


        public void escribirXML()
        {
            try
            {
                // Obtener la lista actual de usuarios (usando la lista global)
                List<Usuario> usuariosActuales = ListaDatosUsuarios.listaUsuarios;

                // Verificar si el usuario "admin" ya está presente
                if (!usuariosActuales.Any(u => u.User == "admin"))
                {
                    // Agregar al usuario "admin" si no está presente
                    usuariosActuales.Add(new Usuario(1, "admin", "1234", "admin@admin.com", DateTime.Now));
                }

                // Escribe la lista completa de usuarios al archivo XML
                using (var writer = new StreamWriter("usuarios.xml"))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(typeof(List<Usuario>));
                    serializer.Serialize(writer, usuariosActuales, namespaces);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo xml " + e.Message);
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

        public void validarEmpleado(TextBox nombre, TextBox pass, TextBox correo, DateTimePicker fechaNacimiento, TextBox errorEdad, Registro reg, InicioSesion inis)
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
                Random random = new Random();

                MessageBox.Show("Todo OK");
                int idUsuario = random.Next(2, 101);

                Usuario us = new Usuario(idUsuario, nombre.Text, pass.Text, correo.Text, fechaNacimiento.Value);
                ListaDatosUsuarios.listaUsuarios.Add(us);
                escribirXML();
                reg.Hide();
                reg.Close();
                inis.ShowDialog();
            }
        }

        public void volverBlanco(TextBox caja)
        {
            caja.BackColor = Color.White;
        }

        public void volverAIniSes(Registro reg,InicioSesion inis)
        {
            reg.Hide();
            reg.Close();
            inis.ShowDialog();
        }

    }
}
