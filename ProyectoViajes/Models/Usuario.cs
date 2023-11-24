using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoViajes.Models
{
    public class Usuario
    {
        private int id;
        private String user;
        private String pass;
        private String correo;
        private DateTime fechaNacimiento;

        public Usuario()
        {

        }

        public Usuario(int id, string user, string pass, string correo, DateTime fechaNacimiento)
        {
            this.Id = id;
            this.User = user;
            this.Pass = pass;
            this.Correo = correo;
            this.FechaNacimiento = fechaNacimiento;
        }

        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
