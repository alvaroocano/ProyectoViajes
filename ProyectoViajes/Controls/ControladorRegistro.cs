using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        // Carga el usuario administrador predeterminado en la lista global
        public void cargarUsuarios()
        {
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("yyyy-MM-dd");
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario(1, "admin", "1234", "admin@admin.com", fechaFormateada));
        }

        // Lee la lista de usuarios desde el archivo XML y la devuelve
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
                Console.WriteLine("Error leyendo XML: " + e.Message);
                return new List<Usuario>();
            }
        }

        // Escribe la lista completa de usuarios en el archivo XML
        public void escribirXML()
        {
            try
            {
                // Obtiene la lista actual de usuarios (utilizando la lista global)
                List<Usuario> usuariosActuales = ListaDatosUsuarios.listaUsuarios;

                // Verifica si el usuario "admin" ya está presente
                if (!usuariosActuales.Any(u => u.User == "admin"))
                {
                    // Agrega al usuario "admin" si no está presente
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
                Console.WriteLine("Error escribiendo XML: " + e.Message);
            }
        }

        // Verifica si la fecha de nacimiento indica que el usuario es mayor de edad
        public bool EsMayorDeEdad(DateTime fecha)
        {
            int edad = DateTime.Now.Year - fecha.Year;

            if (DateTime.Now < fecha.AddYears(edad))
            {
                edad--;
            }

            return edad >= 18;
        }

        // Obtiene el último Id de usuario registrado en la lista global
        private int ObtenerUltimoId()
        {
            if (ListaDatosUsuarios.listaUsuarios.Count > 0)
            {
                return ListaDatosUsuarios.listaUsuarios.Max(u => u.Id);
            }
            else
            {
                return 0;
            }
        }

        
        ControladorBBDD cbbdd = new ControladorBBDD();
        public void insertarUsuario(TextBox user, TextBox pass, TextBox correo, DateTimePicker fechaNacimiento)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = cbbdd.construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Usuarios ([user], pass, correo, fechaNacimiento) VALUES (@User, @Pass, @Correo, @FechaNacimiento)";
            // Valores para los parámetros
            string usuario = user.Text;
            string password = pass.Text;
            string correoE = correo.Text;
            string fechaNac = Convert.ToString(fechaNacimiento.Value);

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    // No se añade a la inserción el campo código proyecto porque es autonumérico, aunque se puede configurar para poder
                    // insertarlo a la fuerza.
                    command.Parameters.AddWithValue("@User", usuario);
                    command.Parameters.AddWithValue("@Pass", password);
                    command.Parameters.AddWithValue("@Correo", correoE);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNac);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                    }
                }
            }

        }


        // Valida los datos del nuevo usuario y lo registra
        public void validarUsuario(TextBox nombre, TextBox pass, TextBox correo, DateTimePicker fechaNacimiento, TextBox errorEdad, Form form, Form form1)
        {
            bool todoBien = true;

            // Validaciones para el nombre
            if (nombre.Text.Equals(""))
            {
                nombre.BackColor = Color.Red;
                todoBien = false;
                MessageBox.Show("El nombre no puede estar vacío");
            }
            else if (!Regex.IsMatch(nombre.Text, "[a-zA-z]+$"))
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

            // Validaciones para la contraseña
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

            // Validaciones para el correo
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

            // Verifica si el correo ya ha sido registrado
            for (int i = 0; i < ListaDatosUsuarios.listaUsuarios.Count; i++)
            {
                if (correo.Text.Equals(ListaDatosUsuarios.listaUsuarios[i].Correo))
                {
                    correo.BackColor = Color.Red;
                    todoBien = false;
                    MessageBox.Show("El correo ya ha sido registrado, por favor, inicie sesión");
                }
            }

            DateTime fechaSeleccionada = fechaNacimiento.Value;

            // Verifica si el usuario es mayor de edad
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
                // Obtiene el último Id de usuario registrado
                int ultimoId = ObtenerUltimoId();

                // Incrementa el Id en 1 para obtener el nuevo Id
                int nuevoId = ultimoId + 1;

                MessageBox.Show("Todo OK");

                DateTime fecha = fechaNacimiento.Value;
                string fechaFormateada = fecha.ToString("yyyy-MM-dd");

                // Utiliza el nuevo Id al registrar el nuevo usuario
                insertarUsuario(nombre, pass, correo, fechaNacimiento);
                form.Hide();
                form.Close();
                form1.ShowDialog();
            }
        }

        // Cambia el color de fondo de una caja de texto a blanco
        public void volverBlanco(TextBox caja)
        {
            caja.BackColor = Color.White;
        }

        // Vuelve al formulario de inicio de sesión desde el formulario de registro
        public void volverAIniSes(Registro reg, InicioSesion inis)
        {
            reg.Hide();
            reg.Close();
            inis.ShowDialog();
        }
    }

}
