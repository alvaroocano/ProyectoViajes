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
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.infoUsuarios(this);
        }
    }
}
