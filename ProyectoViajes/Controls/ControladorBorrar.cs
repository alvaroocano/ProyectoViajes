using ProyectoViajes.Models;
using ProyectoViajes.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProyectoViajes.Controls.ControladorInicioSesion;

namespace ProyectoViajes.Controls
{
    internal class ControladorBorrar
    {
        ControladorRegistro cr = new ControladorRegistro();
        public void crearEtiqueta(string correo, int posicion, System.Windows.Forms.GroupBox g)
        {
            System.Windows.Forms.CheckBox LblUsuario = new System.Windows.Forms.CheckBox();
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
           System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)
           (0)));
            LblUsuario.Location = new System.Drawing.Point(275, posicion);
            LblUsuario.Name = "lblEmpleado";
            LblUsuario.Size = new System.Drawing.Size(291, 20);
            LblUsuario.TabIndex = 1;
            LblUsuario.Text = correo;


            g.Controls.Add(LblUsuario);

        }

        public void cargarUsuarios(List<Usuario> lista, System.Windows.Forms.GroupBox g)
        {
            int pos = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(lista[i].Correo, pos, g);

            }

        }

        private List<System.Windows.Forms.CheckBox> ListaChecked = new List<System.Windows.Forms.CheckBox>();
        public void borrarCheckBoxes(System.Windows.Forms.GroupBox g)
        {
            var checkboxes = g.Controls.OfType<System.Windows.Forms.CheckBox>().Where(x => x.GetType() == typeof(System.Windows.Forms.CheckBox));

            foreach (var ch in checkboxes)
            {
                if (ch.Checked)
                {
                    ListaChecked.Add(ch);
                }
            }

            foreach (var ch in ListaChecked)
            {
                int indice = ListaDatosUsuarios.listaUsuarios.FindIndex(x => x.Correo.Equals(ch.Text));
                if (indice != -1)
                {
                    ListaDatosUsuarios.listaUsuarios.RemoveAt(indice);
                }
            }

            g.Controls.Clear();
            int pos = 0;
            for (int i = 1; i < ListaDatosUsuarios.listaUsuarios.Count; i++)
            {
                pos = pos + 20;
                crearEtiqueta(ListaDatosUsuarios.listaUsuarios[i].Correo, pos, g);

            }

            cr.escribirXML();
        }
    }

    
}
