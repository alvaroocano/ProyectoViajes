using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoViajes.Models;
using System.Windows.Forms;
using static ProyectoViajes.Controls.ControladorInicioSesion;
using System.Xml.Serialization;
using ProyectoViajes.Views;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoViajes.Controls
{
    public class ControladorUsuariosAdmin
    {
        ControladorRegistro cr = new ControladorRegistro();

        public void modificarUsuario(string nuevoNombre, string nuevoCorreo, DateTime nuevaFechaNacimiento, int idUsuario)
        {
            try
            {
                string connectionString = construirCadenaConexión();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Usuarios SET [user] = @Nombre, correo = @Correo, fechaNacimiento = @FechaNacimiento WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nuevoNombre);
                        command.Parameters.AddWithValue("@Correo", nuevoCorreo);
                        command.Parameters.AddWithValue("@FechaNacimiento", nuevaFechaNacimiento);
                        command.Parameters.AddWithValue("@Id", idUsuario);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario modificado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el usuario.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar usuario: {ex.Message}");
            }
        }

        public void validarUsuario(TextBox nombre, TextBox correo, DateTimePicker fecha, int id, Form form1, Form form2)
        {

            var usuarioAModificar = ListaDatosUsuarios.listaUsuarios.FirstOrDefault(x => x.Id.Equals(id));

            if (usuarioAModificar != null)
            {
                bool todoBien = true;

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

                DateTime fechaBien = fecha.Value;
                if (!cr.EsMayorDeEdad(fechaBien))
                {
                    MessageBox.Show("Debe ser mayor de edad");
                    todoBien = false;
                }


                if (todoBien)
                {
                    modificarUsuario(nombre.Text, correo.Text, fechaBien, id);
                    form1.Hide();
                    form1.Close();
                    form2.ShowDialog();
                }

            }
        }

        public string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\BaseDatosViajes.mdf"));
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            return connectionString;
        }

        public string construirCadenaConexionPruebas()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\BaseDatosPruebas.mdf"));
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            return connectionString;
        }

        public DataTable obtenerUsuarios(string cadenaConexion)
        {
            DataTable dtUsuarios = new DataTable();

            // Cadena de conexión a la base de datos
            string connectionString = cadenaConexion;
            // Query para seleccionar todos los registros de la tabla Proyectos
            string query = "SELECT * FROM Usuarios";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un adaptador de datos y ejecutar la consulta
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Llenar el DataTable con los resultados de la consulta
                    adapter.Fill(dtUsuarios);
                }
            }

            return dtUsuarios;
        }

        public void eliminarUsuariosSeleccionados(DataGridView dataGridView)
        {
            // Lista para almacenar los IDs de los usuarios seleccionados para eliminar
            List<int> idsUsuariosAEliminar = new List<int>();

            // Iterar sobre las filas del DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Verificar si la fila está seleccionada y el checkbox de "Eliminar" está marcado
                DataGridViewCheckBoxCell checkbox = row.Cells["Borrar"] as DataGridViewCheckBoxCell;
                if (checkbox != null && Convert.ToBoolean(checkbox.Value))
                {
                    // Obtener el nombre de usuario de la fila actual
                    string usuario = Convert.ToString(row.Cells["userDataGridViewTextBoxColumn"].Value);

                    // Si el usuario no es "admin", agregar el ID a la lista de IDs de usuarios a eliminar
                    if (usuario != "admin")
                    {
                        int idUsuario = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                        idsUsuariosAEliminar.Add(idUsuario);
                    }
                    else
                    {
                        // Mostrar un mensaje informativo de que el usuario "admin" no puede ser eliminado
                        MessageBox.Show("El usuario 'admin' no puede ser eliminado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            // Verificar si hay usuarios seleccionados para eliminar (que no sean "admin")
            if (idsUsuariosAEliminar.Count > 0)
            {
                // Cadena de conexión a la base de datos
                string connectionString = construirCadenaConexión();

                // Query para eliminar los usuarios seleccionados
                string query = "DELETE FROM Usuarios WHERE Id IN (" + string.Join(",", idsUsuariosAEliminar) + ")";

                // Crear la conexión y ejecutar la consulta de eliminación
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int registrosEliminados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se eliminaron correctamente {registrosEliminados} usuarios.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado usuarios para eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        public Usuario ObtenerDetallesUsuarioPorID(int id)
        {
            string connectionString = construirCadenaConexión();

            // Query SQL para obtener los detalles del usuario por su ID
            string query = "SELECT * FROM Usuarios";

            // Crea una instancia del objeto Usuario para almacenar los datos del usuario encontrado
            Usuario usuario = null;

            // Crea la conexión y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agrega el parámetro para el ID del usuario
                    command.Parameters.AddWithValue("@ID", id);

                    // Ejecuta la consulta y obtén el resultado
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verifica si se encontró el usuario y lee los datos del usuario
                        if (reader.Read())
                        {
                            // Crea una instancia de Usuario y asigna los datos del usuario
                            usuario = new Usuario
                            {
                                id = id,
                                user = reader["user"].ToString(),
                                correo = reader["correo"].ToString()
                            };
                        }
                    }
                }
            }

            // Devuelve el objeto Usuario encontrado o null si no se encontró ningún usuario con ese ID
            return usuario;
        }

    }

}
