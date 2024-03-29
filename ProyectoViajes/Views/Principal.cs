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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        ControladorPrincipal cp = new ControladorPrincipal();
        ControladorMenu cm = new ControladorMenu();

        public bool isAdmin;
        private void Principal_Load(object sender, EventArgs e)
        {
            cp.esconderMenu(menuStrip);
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void linkReservaNamek_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoNamek infNam = new InfoNamek();
            this.Hide();
            infNam.ShowDialog();
        }

        private void linkReservaPuerta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoPuerta infPu = new InfoPuerta();
            this.Hide();
            infPu.ShowDialog();
        }

        private void linkReservaAgostini_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoDeAgostini infDA = new InfoDeAgostini();
            this.Hide();
            infDA.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.infoUsuarios(this);
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.crearUsuario(this);
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.correo(this);
        }

        private void linkContacto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cm.correo(this);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cm.modificarReserva(this);
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearNave cn = new CrearNave();
            cn.ShowDialog();
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InfoNaves infN = new InfoNaves();
            infN.ShowDialog();
        }
    }
}
