using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
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
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("yyyy-MM-dd");
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario(1, "admin", "1234", "admin@admin.com", fechaFormateada));

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
                    DateTime fechaActual = DateTime.Now;
                    string fechaFormateada = fechaActual.ToString("yyyy-MM-dd");
                    usuariosActuales.Add(new Usuario(1, "admin", "1234", "admin@admin.com", fechaFormateada));
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

        public bool EsMayorDeEdad(DateTime fecha)
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

        private int ObtenerUltimoId()
        {
            // Obtén el último Id de usuario registrado en la lista
            if (ListaDatosUsuarios.listaUsuarios.Count > 0)
            {
                return ListaDatosUsuarios.listaUsuarios.Max(u => u.Id);
            }
            else
            {
                return 0; // Si no hay usuarios registrados, devuelve 0 como base
            }
        }

        public void validarEmpleado(TextBox nombre, TextBox pass, TextBox correo, DateTimePicker fechaNacimiento, TextBox errorEdad, Registro reg, InicioSesion inis)
        {
            bool todoBien = true;

            if (nombre.Text.Equals(""))
            {
                nombre.BackColor = Color.Red;
                todoBien = false;
                MessageBox.Show("El nombre no puede estar vacío");

            }else if(!Regex.IsMatch(nombre.Text, "[a-zA-z]+$"))
            {
                nombre.BackColor = Color.Red;
                todoBien = false;
                MessageBox.Show("El nombre debe contener únicamente letras");
            }
            else if (nombre.Text.Length > 8)
            {
                nombre.BackColor = Color.Red;
                todoBien = false;
                MessageBox.Show("El nombre no puede tener más de 8 caracteres");
            }

            if (pass.Text.Equals(""))
            {
                pass.BackColor = Color.Red;
                todoBien = false;
                MessageBox.Show("La contraseña no puede estar vacía");
            }
            else if (pass.Text.Length > 20)
            {
                pass.BackColor = Color.Red;
                todoBien = false;
                MessageBox.Show("La contraseña no puede contener más de 20 caracteres");
            }

            if (correo.Text.Equals(""))
            {
                correo.BackColor = Color.Red;
                todoBien = false;
                MessageBox.Show("El correo no puede estar vacío");
            }
            else if (!Regex.IsMatch(correo.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                correo.BackColor = Color.Red;
                todoBien = false;
                MessageBox.Show("El correo no es válido");

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
                // Obtén el último Id de usuario registrado
                int ultimoId = ObtenerUltimoId();

                // Incrementa el Id en 1 para obtener el nuevo Id
                int nuevoId = ultimoId + 1;

                MessageBox.Show("Todo OK");

                DateTime fecha = fechaNacimiento.Value;
                string fechaFormateada = fecha.ToString("yyyy-MM-dd");

                // Utiliza el nuevo Id al registrar el nuevo usuario
                Usuario us = new Usuario(nuevoId, nombre.Text, pass.Text.GetHashCode().ToString(), correo.Text, fechaFormateada);
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
