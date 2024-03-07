using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoViajes.Models
{
    internal class NaveEspacial
    {
        private string Nombre;
        private int CapacidadPasajeros;
        private bool Disponible;
        private string EstadoMantenimiento;

        public NaveEspacial() { }

        public NaveEspacial(int capacidadPasajeros, bool disponible, string estadoMantenimiento)
        {
            CapacidadPasajeros1 = capacidadPasajeros;
            Disponible1 = disponible;
            EstadoMantenimiento1 = estadoMantenimiento;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int CapacidadPasajeros1 { get => CapacidadPasajeros; set => CapacidadPasajeros = value; }
        public bool Disponible1 { get => Disponible; set => Disponible = value; }
        public string EstadoMantenimiento1 { get => EstadoMantenimiento; set => EstadoMantenimiento = value; }
    }
}
