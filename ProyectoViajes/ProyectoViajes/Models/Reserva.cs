using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoViajes.Models
{
    internal class Reserva
    {
        private int id;
        private String usuario;
        private String destino;
        private int nroPersonas;
        private String fechaIda;
        private String fechaVuelta;



        public Reserva()
        {

        }

        public Reserva(int id, string usuario, string destino, int nroPersonas, string fechaIda, string fechaVuelta)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Destino = destino;
            this.NroPersonas = nroPersonas;
            this.FechaIda = fechaIda;
            this.FechaVuelta = fechaVuelta;
        }

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Destino { get => destino; set => destino = value; }
        public int NroPersonas { get => nroPersonas; set => nroPersonas = value; }
        public string FechaIda { get => fechaIda; set => fechaIda = value; }
        public string FechaVuelta { get => fechaVuelta; set => fechaVuelta = value; }
    }

    
}
