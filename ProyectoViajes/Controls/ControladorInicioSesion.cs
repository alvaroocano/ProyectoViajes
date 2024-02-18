using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoViajes.Models;
using ProyectoViajes.Views;

namespace ProyectoViajes.Controls
{
    internal class ControladorInicioSesion
    {
       
       
        public void redirigirRegistro()
        {
            Registro reg = new Registro();
            reg.ShowDialog();
            
        }

        public void cargarUsuarios()
        {
            List<Usuario> usuariosActuales = leerXML();

            // Verificar si el usuario "admin" ya está presente
            if (!usuariosActuales.Any(u => u.User == "admin"))
            {
                DateTime fechaActual = DateTime.Now;
                string fechaFormateada = fechaActual.ToString("yyyy-MM-dd");
                // Agregar al usuario "admin" si no está presente
                usuariosActuales.Add(new Usuario(1, "admin", "1234", "admin@admin.com",fechaFormateada));
            }

            // Actualizar la lista global
            ListaDatosUsuarios.listaUsuarios = usuariosActuales;

        }



        // Lee usuarios desde el archivo XML y devuelve la lista
        public List<Usuario> leerXML()
        {
            string archivo;
            try
            {
                string xml = File.ReadAllText("usuarios.xml");
                archivo = xml;
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(ListaDatosUsuarios.listaUsuarios.GetType());
                    ListaDatosUsuarios.listaUsuarios = (List<Usuario>)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo XML: " + e.Message);
            }
            return ListaDatosUsuarios.listaUsuarios;
        }

        // Valida el usuario y contraseña, inicia sesión y muestra el formulario principal
        public void validarUsuario(string usuario, string pass, InicioSesion inis)
        {
            int contador = InicioSesion.contador;

            int posicion = leerXML().FindIndex(x => x.User == usuario);
            if (posicion != -1 && leerXML()[posicion].Pass == pass || (usuario == "admin" && leerXML()[posicion].Pass == "1234"))
            {
                inis.Hide();
                Principal pr = new Principal();

                if (usuario.Equals("admin"))
                {
                    pr.isAdmin = true;
                }
                
                SesionUsuario.IniciarSesion(usuario);
                pr.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                contador++;
            }

            if (contador == 3)
            {
                MessageBox.Show("3 intentos incorrectos");
                Application.Exit();
                contador = 0;
            }

            InicioSesion.contador = contador;
        }

        // Clase para almacenar la lista global de usuarios
        public static class ListaDatosUsuarios
        {
            public static List<Usuario> listaUsuarios = new List<Usuario>();
        }

        // Clase para gestionar la sesión del usuario
        public static class SesionUsuario
        {
            public static string UsuarioActual { get; private set; }

            public static void IniciarSesion(string nombreUsuario)
            {
                UsuarioActual = nombreUsuario;
            }

            public static void CerrarSesion()
            {
                UsuarioActual = null;
            }
        }

        ControladorBBDD cbbdd = new ControladorBBDD();

        public bool validarCredenciales(string usuario, string contraseña)
        {
            // Cadena de conexión a la base de datos
            string connectionString = cbbdd.construirCadenaConexión();

            // Query para buscar un usuario con el nombre y contraseña proporcionados
            string query = "SELECT COUNT(*) FROM Usuarios WHERE [user] = @Usuario AND pass = @Contraseña";

            // Variable para almacenar el resultado de la consulta
            int count;

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    // Ejecutar la consulta y obtener el resultado
                    count = (int)command.ExecuteScalar();
                }
            }

            // Si count es mayor que cero, se encontró un usuario con el nombre y contraseña proporcionados
            return count > 0;
        }



    }
}
