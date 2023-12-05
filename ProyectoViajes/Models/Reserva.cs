using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoViajes.Models
{
    internal class Reserva
    {
        private String usuario;
        private String destino;
        private int nroPersonas;
        private String fechaIda;
        private String fechaVuelta;

        public Reserva(string usuario, string destino, int nroPersonas, String fechaIda, String fechaVuelta)
        {
            this.Usuario = usuario;
            this.Destino = destino;
            this.NroPersonas = nroPersonas;
            this.FechaIda = fechaIda;
            this.FechaVuelta = fechaVuelta;
        }

        public Reserva()
        {

        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Destino { get => destino; set => destino = value; }
        public int NroPersonas { get => nroPersonas; set => nroPersonas = value; }
        public String FechaIda { get => fechaIda; set => fechaIda = value; }
        public String FechaVuelta { get => fechaVuelta; set => fechaVuelta = value; }
    }

    
}
