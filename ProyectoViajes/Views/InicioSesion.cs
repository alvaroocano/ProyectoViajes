﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoViajes.Controls;

namespace ProyectoViajes
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        ControladorInicioSesion cis = new ControladorInicioSesion();


        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            cis.redirigirRegistro();
            

        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
           
            cis.cargarUsuarios();
           
        }

        public static int contador = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cis.validarUsuario(txtUsuario.Text,txtContrasena.Text.GetHashCode().ToString(),this);
           
        }
    }
}
