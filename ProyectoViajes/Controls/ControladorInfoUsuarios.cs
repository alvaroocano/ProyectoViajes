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

namespace ProyectoViajes.Controls
{
    internal class ControladorInfoUsuarios
    {
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
        public void crearEtiqueta(int id, string user, string correo,DateTime fechaNacimiento, int posicion, System.Windows.Forms.GroupBox g)
        {
            Label GrupoLbl = new System.Windows.Forms.Label();
            GrupoLbl.AutoSize = true;
            GrupoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
           System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)
           (0)));
            GrupoLbl.Location = new System.Drawing.Point(75, posicion);
            GrupoLbl.Name = "lblEmpleado";
            GrupoLbl.Size = new System.Drawing.Size(291, 20);
            GrupoLbl.TabIndex = 1;
            GrupoLbl.Text = id + " " + user + " " + correo +" "+fechaNacimiento.ToString();

            Button botonEditar = new System.Windows.Forms.Button();
            botonEditar.AutoSize = true;
            botonEditar.Size = new System.Drawing.Size(82, 24);
            new System.Drawing.Point(GrupoLbl.Right + 5, posicion);

            g.Controls.Add(GrupoLbl);
            g.Controls.Add(botonEditar);
        }

        public void crearEmpleados(List<Usuario> lista, System.Windows.Forms.GroupBox g)
        {
            int pos = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(lista[i].Id, lista[i].User, lista[i].Correo, lista[i].FechaNacimiento, pos, g);

            }
        }

        public void refrescar(Form form)
        {
            form.Refresh();
        }





    }


}
