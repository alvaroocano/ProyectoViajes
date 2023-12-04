using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoViajes.Views;

namespace ProyectoViajes.Controls
{
    internal class ControladorMenu
    {

        public void infoUsuarios(Form form)
        {
            InfoUsuarios iu = new InfoUsuarios();
            form.Hide();
            form.Close();
            iu.ShowDialog();
        }

        public void crearUsuario(Form form)
        {
            CrearUsuarioAdmin cua = new CrearUsuarioAdmin();
            form.Hide();
            form.Close();
            cua.ShowDialog();
        }

        public void borrarUsuario(Form form)
        {
            BorrarUsuariosAdmin bua = new BorrarUsuariosAdmin();
            form.Hide();
            form.Close();
            bua.ShowDialog();
        }

        public void correo(Form form)
        {
            FormularioCorreo fc = new FormularioCorreo();
            fc.ShowDialog();
        }

        public void reserva(Form form)
        {
            ReservaViaje rv = new ReservaViaje();
            rv.ShowDialog();
        }

    }
}
