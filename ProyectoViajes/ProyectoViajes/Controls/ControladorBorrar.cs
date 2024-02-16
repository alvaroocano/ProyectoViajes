using ProyectoViajes.Models;
using ProyectoViajes.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static ProyectoViajes.Controls.ControladorInicioSesion;

namespace ProyectoViajes.Controls
{
    internal class ControladorBorrar
    {
        // Instancia del ControladorRegistro para acceder a sus métodos
        ControladorRegistro cr = new ControladorRegistro();

        // Crea y agrega una etiqueta CheckBox con el correo especificado al panel
        public void crearEtiqueta(string correo, int posicion, System.Windows.Forms.Panel p)
        {
            System.Windows.Forms.CheckBox LblUsuario = new System.Windows.Forms.CheckBox();
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            LblUsuario.Location = new System.Drawing.Point(275, posicion);
            LblUsuario.Name = "lblEmpleado";
            LblUsuario.Size = new System.Drawing.Size(291, 20);
            LblUsuario.TabIndex = 1;
            LblUsuario.Text = correo;

            p.Controls.Add(LblUsuario);
        }

        // Carga usuarios en el panel creando etiquetas CheckBox para cada uno
        public void cargarUsuarios(List<Usuario> lista, System.Windows.Forms.Panel p)
        {
            int pos = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(lista[i].Correo, pos, p);
            }
        }

        // Lista de CheckBox marcados para borrado
        private List<System.Windows.Forms.CheckBox> ListaChecked = new List<System.Windows.Forms.CheckBox>();

        // Borra usuarios seleccionados y actualiza el panel
        public void borrarCheckBoxes(System.Windows.Forms.Panel p)
        {
            // Obtén todos los CheckBox en el panel que están marcados
            var checkboxes = p.Controls.OfType<System.Windows.Forms.CheckBox>().Where(x => x.GetType() == typeof(System.Windows.Forms.CheckBox));

            // Agrega los CheckBox marcados a la lista de borrado
            foreach (var ch in checkboxes)
            {
                if (ch.Checked)
                {
                    ListaChecked.Add(ch);
                }
            }

            // Elimina los usuarios correspondientes de la lista de usuarios
            foreach (var ch in ListaChecked)
            {
                int indice = ListaDatosUsuarios.listaUsuarios.FindIndex(x => x.Correo.Equals(ch.Text));
                if (indice != -1)
                {
                    ListaDatosUsuarios.listaUsuarios.RemoveAt(indice);
                }
            }

            // Limpia el panel y vuelve a cargar las etiquetas actualizadas
            p.Controls.Clear();
            int pos = 0;
            for (int i = 1; i < ListaDatosUsuarios.listaUsuarios.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(ListaDatosUsuarios.listaUsuarios[i].Correo, pos, p);
            }

            // Escribe los cambios en el archivo XML
            cr.escribirXML();
        }
    }
}
