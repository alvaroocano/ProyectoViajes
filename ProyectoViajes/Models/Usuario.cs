﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoViajes.Models
{
    public class Usuario
    {
        public int id;
        public String user;
        private String pass;
        public String correo;
        private String fechaNacimiento;

        public Usuario()
        {

        }

        public Usuario(int id, string user, string pass, string correo, string fechaNacimiento)
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
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
