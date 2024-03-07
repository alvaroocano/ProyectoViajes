using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoViajes.Controls
{
    
    internal class ControladorNaves
    {
        ControladorBBDD cb = new ControladorBBDD();
        public void insertarNaves(TextBox nombre, NumericUpDown capacidad, CheckBox disponible,ComboBox estado)
        {
            // Cadena de conexión a la base de datos
            string connectionString = cb.construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Naves (Nombre, Capacidad, Disponible, EstadoMantenimiento) VALUES (@Nombre, @Capacidad, @Disponible, @EstadoMantenimiento)";
            // Valores para los parámetros
            string nom = nombre.Text;
            int cap = Convert.ToInt32(capacidad.Value); 
            bool dis = disponible.Checked;
            string est = Convert.ToString(estado.SelectedItem);

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
                    command.Parameters.AddWithValue("@Nombre", nom);
                    command.Parameters.AddWithValue("@Capacidad", cap);
                    command.Parameters.AddWithValue("@Disponible", dis);
                    command.Parameters.AddWithValue("@EstadoMantenimiento", est);
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

        public void CargarNavesEnComboBox(ComboBox comboBox)
        {
            string connectionString = cb.construirCadenaConexión();
            string query = "SELECT Nombre FROM Naves";

            // Limpiar ComboBox
            comboBox.Items.Clear();
            comboBox.Items.Add("Todos"); // Agregar opción "Todos"

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar naves: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }

        public void CargarDatosEnDataGridView(DataGridView dataGridView, string naveSeleccionada)
        {
            string connectionString = cb.construirCadenaConexión();
            string query;

            if (naveSeleccionada == "Todos")
            {
                query = "SELECT * FROM Naves";
            }
            else
            {
                query = $"SELECT * FROM Naves WHERE Nombre = '{naveSeleccionada}'";
            }

            try
            {
                // Crear un DataTable para almacenar los datos
                DataTable dataTable = new DataTable();

                // Establecer la conexión y ejecutar la consulta
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Crear un SqlDataAdapter para obtener los datos de la consulta
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Llenar el DataTable con los datos obtenidos
                            adapter.Fill(dataTable);
                        }
                    }
                }

                // Asignar el DataTable como origen de datos del DataGridView
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}
