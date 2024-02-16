using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoViajes.Controls
{
    internal class ControladorContacto
    {
        public void SimularEnvioCorreo(string destinatario, string asunto, string cuerpo)
        {
            try
            {
                // Validar si el destinatario es una dirección de correo electrónico válida
                if (!EsDireccionCorreoValida(destinatario))
                {
                    MessageBox.Show("La dirección de correo electrónico del destinatario no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Carpeta donde se guardará el archivo (en el directorio bin\Debug)
                string carpetaProyecto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                string nombreArchivo = $"CorreoSimulado_{DateTime.Now:yyyyMMddHHmmss}.txt";

                // Construir la ruta del archivo
                string rutaArchivo = Path.Combine(carpetaProyecto, nombreArchivo);

                // Crear el archivo y escribir el contenido
                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    writer.WriteLine($"Destinatario: {destinatario}");
                    writer.WriteLine($"Asunto: {asunto}");
                    writer.WriteLine($"Cuerpo: {cuerpo}");
                }

                MessageBox.Show($"Correo simulado guardado en: {rutaArchivo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al simular el correo: {ex.Message}");
            }
        }

        private bool EsDireccionCorreoValida(string correo)
        {
            // Expresión regular simple para validar direcciones de correo electrónico
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Validar la dirección de correo electrónico utilizando la expresión regular
            return Regex.IsMatch(correo, patronCorreo);
        }
    }
}
