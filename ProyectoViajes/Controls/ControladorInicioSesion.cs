using System;
using System.Collections.Generic;
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
        
        Registro reg = new Registro();
       
        public void redirigirRegistro()
        {
            reg.ShowDialog();
            
        }

        public void cargarUsuarios()
        {
            ListaDatosUsuarios.listaUsuarios.Add(new Usuario(1,"admin", "1234","admin@admin.com",DateTime.Now));

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

        public void validarUsuario(int contador, string usuario, string pass, InicioSesion inis)
        {
            int posicion = ListaDatosUsuarios.listaUsuarios.FindIndex(x => x.User == usuario);
            if (posicion != -1 && ListaDatosUsuarios.listaUsuarios[posicion].Pass == pass)
            {
                inis.Hide();
                Principal pr = new Principal();
                pr.Show();
            }
            else
            {
                contador++;
            }

            if (contador == 3)
            {
                MessageBox.Show("3 intentos incorrectos");
                Application.Exit();
                contador = 0;
            }

        }


        public static class ListaDatosUsuarios
        {
            public static List<Usuario> listaUsuarios = new List<Usuario>();
        }
    }

    
}
