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
            infoUsuariosBBDD iu = new infoUsuariosBBDD();
            form.Hide();
            iu.ShowDialog();
        }

        public void crearUsuario(Form form)
        {
            CrearUsuarioAdmin cua = new CrearUsuarioAdmin();
            form.Hide();
            cua.ShowDialog();
        }

        public void borrarUsuario(Form form)
        {
            BorrarUsuariosAdmin bua = new BorrarUsuariosAdmin();
            form.Hide();
            bua.ShowDialog();
        }

        public void correo(Form form)
        {
            FormularioCorreo fc = new FormularioCorreo();
            form.Hide();
            fc.ShowDialog();
        }

        public void reserva(Form form)
        {
            ReservaViaje rv = new ReservaViaje();
            form.Hide();
            rv.ShowDialog();
        }

        public void modificarReserva(Form form)
        {
            InfoReserva mr = new InfoReserva();
            form.Hide();
            mr.ShowDialog();
        }

        public void borrarReservas(Form form)
        {
            BorrarReservasAdmin mr = new BorrarReservasAdmin();
            form.Hide();
            mr.ShowDialog();
        }

        public void paginaPrincipal(Form form)
        {
            Principal principal = new Principal();
            form.Hide();
            principal.ShowDialog();
        }

    }
}
