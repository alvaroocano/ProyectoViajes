using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                MessageBox.Show(e.Message);
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
        public void validarReserva(int idReserva, string destino, int nroPersonas, DateTime fechaIda, DateTime fechaVuelta)
        {
            if (fechaVuelta <= fechaIda)
            {
                MessageBox.Show("La fecha de vuelta debe ser posterior a la fecha de ida.");
                return;
            }

            modificarReserva(idReserva, destino, nroPersonas, fechaIda, fechaVuelta);
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

        ControladorBBDD cub = new ControladorBBDD();
        // Modifica una reserva existente
        public void modificarReserva(int id, string destino, int nroPersonas, DateTime fechaIda, DateTime fechaVuelta)
        {
            try
            {
                string connectionString = cub.construirCadenaConexión();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Reservas SET destino = @Destino, nroPersonas = @NroPersonas, fechaIda = @FechaIda, fechaVuelta = @FechaVuelta WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Destino", destino);
                        command.Parameters.AddWithValue("@NroPersonas", nroPersonas);
                        command.Parameters.AddWithValue("@FechaIda", fechaIda);
                        command.Parameters.AddWithValue("@FechaVuelta", fechaVuelta);
                        command.Parameters.AddWithValue("@Id", id);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reserva modificado correctamente.");
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

        // Verifica si la fecha de vuelta es válida
        private bool EsFechaVueltaValida(DateTime fechaIda, DateTime fechaVuelta)
        {
            if (fechaVuelta > fechaIda)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ControladorBBDD cbbdd = new ControladorBBDD();  
        public void insertarReservas(TextBox usuario, ComboBox destino, NumericUpDown nroPersonas, DateTimePicker fechaIda, DateTimePicker fechaVuelta)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = cbbdd.construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Reservas (usuario, destino, nroPersonas, fechaIda, fechaVuelta) VALUES (@Usuario, @Destino, @NroPersonas, @FechaIda, @FechaVuelta)";
            // Valores para los parámetros
            string usr = usuario.Text;
            string dest = Convert.ToString(destino.SelectedItem);
            string nroP = Convert.ToString(nroPersonas.Value);
            string fechaI = Convert.ToString(fechaIda.Value);
            string fechaV = Convert.ToString(fechaVuelta.Value);


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
                    command.Parameters.AddWithValue("@Usuario", usr);
                    command.Parameters.AddWithValue("@Destino", dest);
                    command.Parameters.AddWithValue("@NroPersonas", nroP);
                    command.Parameters.AddWithValue("@FechaIda", fechaI);
                    command.Parameters.AddWithValue("@FechaVuelta", fechaV);
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
        public DataTable obtenerReservas()
        {
            DataTable dtProyectos = new DataTable();

            // Cadena de conexión a la base de datos
            string connectionString = cbbdd.construirCadenaConexión();
            // Query para seleccionar todos los registros de la tabla Proyectos
            string query = "SELECT * FROM Reservas";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un adaptador de datos y ejecutar la consulta
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Llenar el DataTable con los resultados de la consulta
                    adapter.Fill(dtProyectos);
                }
            }

            return dtProyectos;
        }

        public Reserva ObtenerDetallesReservaPorID(int id)
        {
            string connectionString = cub.construirCadenaConexión();

            // Query SQL para obtener los detalles de la reserva por su ID
            string query = "SELECT * FROM Reservas WHERE Id = @ID";

            // Crea una instancia del objeto Reserva para almacenar los datos de la reserva encontrada
            Reserva reserva = null;

            // Crea la conexión y ejecuta la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agrega el parámetro para el ID de la reserva
                    command.Parameters.AddWithValue("@ID", id);

                    // Ejecuta la consulta y obtén el resultado
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verifica si se encontró la reserva y lee los datos de la misma
                        if (reader.Read())
                        {
                            // Crea una instancia de Reserva y asigna los datos de la reserva
                            reserva = new Reserva
                            {
                                Id = id,
                                Usuario = reader["usuario"].ToString(),
                                Destino = reader["destino"].ToString(),
                                NroPersonas = Convert.ToInt32(reader["nroPersonas"]),
                                FechaIda = reader["fechaIda"].ToString(),
                                FechaVuelta = reader["fechaVuelta"].ToString()
                            };
                        }
                    }
                }
            }

            // Devuelve el objeto Reserva encontrado o null si no se encontró ninguna reserva con ese ID
            return reserva;
        }

        public void eliminarReservasSeleccionadas(DataGridView dataGridView)
        {
            List<int> idsReservasAEliminar = new List<int>();

            // Iterar sobre las filas del DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Verificar si la fila está seleccionada y el checkbox de "Eliminar" está marcado
                DataGridViewCheckBoxCell checkbox = row.Cells["Eliminar"] as DataGridViewCheckBoxCell;
                if (checkbox != null && Convert.ToBoolean(checkbox.Value))
                {
                    int idReserva = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                    idsReservasAEliminar.Add(idReserva); 
                }
            }

            // Verificar si hay usuarios seleccionados para eliminar (que no sean "admin")
            if (idsReservasAEliminar.Count > 0)
            {
                // Cadena de conexión a la base de datos
                string connectionString = cub.construirCadenaConexión();

                // Query para eliminar los usuarios seleccionados
                string query = "DELETE FROM Reservas WHERE Id IN (" + string.Join(",", idsReservasAEliminar) + ")";

                // Crear la conexión y ejecutar la consulta de eliminación
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int registrosEliminados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se anularon correctamente {registrosEliminados} reservas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado usuarios para eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Clase estática para almacenar la lista de reservas
        public static class ListaDatosReservas
        {
            public static List<Reserva> listaReservas = new List<Reserva>();
        }
    }

}
