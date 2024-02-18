using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoViajes.Models
{
    public static class UsuarioActual
    {
        public static string NombreUsuario { get; private set; }

        public static void EstablecerNombreUsuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }
    }
}
