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

namespace ProyectoViajes.Views
{
    public partial class InfoPuerta : Form
    {
        public InfoPuerta()
        {
            InitializeComponent();
        }

        ControladorMenu cm = new ControladorMenu();

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.infoUsuarios(this);
        }

        private void linkReservaPuerta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cm.reserva();
        }

        ControladorPrincipal cp = new ControladorPrincipal();
        public bool isAdmin;
        private void InfoPuerta_Load(object sender, EventArgs e)
        {
            cp.esconderMenu(menuStrip);
        }

        private void InfoPuerta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal pr = new Principal();
            pr.ShowDialog();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cm.modificarReserva(this);
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            
            pictureBox1.Location = new Point(
                (splitContainer1.Panel1.Width - pictureBox1.Width) / 2,
                (splitContainer1.Panel1.Height - pictureBox1.Height) / 2
            );
        }

        private void textoDeAgostini_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
