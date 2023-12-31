﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoViajes.Models;
using System.Windows.Forms;
using static ProyectoViajes.Controls.ControladorInicioSesion;
using System.Xml.Serialization;
using ProyectoViajes.Views;
using System.Drawing;
using System.Text.RegularExpressions;

namespace ProyectoViajes.Controls
{
    internal class ControladorUsuariosAdmin
    {
        ControladorRegistro cr = new ControladorRegistro(); 
        
        public void crearEtiqueta(int id, string user, string correo,string fechaNacimiento, int posicion, System.Windows.Forms.GroupBox g)
        {
            Label GrupoLbl = new System.Windows.Forms.Label();
            GrupoLbl.AutoSize = true;
            GrupoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
           System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)
           (0)));
            GrupoLbl.Location = new System.Drawing.Point(75, posicion);
            GrupoLbl.Name = "lblEmpleado";
            GrupoLbl.Size = new System.Drawing.Size(291, 20);
            GrupoLbl.TabIndex = 1;
            GrupoLbl.Text = id + " " + user + " " + correo +" "+fechaNacimiento.ToString();

            Button botonEditar = new System.Windows.Forms.Button();
            botonEditar.AutoSize = true;
            botonEditar.Size = new System.Drawing.Size(82, 20);
            botonEditar.Location = new System.Drawing.Point(GrupoLbl.Right + 20, posicion);
            botonEditar.Text = "Modificar";

            ModificarUsuario mus = new ModificarUsuario();
            InfoUsuarios info = new InfoUsuarios();

            mus.SetDatos(user, correo, fechaNacimiento, id);

            botonEditar.Click += (sender, e) => MiBoton_Click(sender, e, user, correo, fechaNacimiento, id, info, mus);

            g.Controls.Add(GrupoLbl);
            g.Controls.Add(botonEditar);
        }

        public void crearUsuarios(List<Usuario> lista, System.Windows.Forms.GroupBox g)
        {
            int pos = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                pos = pos + 30;
                crearEtiqueta(lista[i].Id, lista[i].User, lista[i].Correo, lista[i].FechaNacimiento, pos, g);

            }
        }

        public void refrescar(Form form)
        {
            form.Refresh();
        }

        private void MiBoton_Click(object sender, EventArgs e, string user, string email, string fecha, int id,Form form1, Form form2)
        {

            form1.Hide();
            form1.Close();
            form2.ShowDialog();
            
        }

        public void modificarUsuario(TextBox nombre, TextBox correo, DateTimePicker fecha, int id, Form form1, Form form2)
        {
           
            var usuarioAModificar = ListaDatosUsuarios.listaUsuarios.FirstOrDefault(x => x.Id.Equals(id));

            if(usuarioAModificar != null)
            {
                bool todoBien = true;

                if (nombre.Text.Equals(""))
                {
                    nombre.BackColor = Color.Red;
                    todoBien = false;
                    MessageBox.Show("El nombre no puede estar vacío");

                }
                else if (!Regex.IsMatch(nombre.Text, "[a-zA-z]+$"))
                {
                    nombre.BackColor = Color.Red;
                    todoBien = false;
                    MessageBox.Show("El nombre debe contener únicamente letras");
                }
                else if (nombre.Text.Length > 8)
                {
                    nombre.BackColor = Color.Red;
                    todoBien = false;
                    MessageBox.Show("El nombre no puede tener más de 8 caracteres");
                }

                if (correo.Text.Equals(""))
                {
                    correo.BackColor = Color.Red;
                    todoBien = false;
                    MessageBox.Show("El correo no puede estar vacío");
                }
                else if (!Regex.IsMatch(correo.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    correo.BackColor = Color.Red;
                    todoBien = false;
                    MessageBox.Show("El correo no es válido");

                }

                 DateTime fechaBien = fecha.Value;
                 if (!cr.EsMayorDeEdad(fechaBien))
                 {
                    MessageBox.Show("Debe ser mayor de edad");
                    todoBien = false;
                 }
                

                if (todoBien)
                {
                    usuarioAModificar.User = nombre.Text;
                    usuarioAModificar.Correo = correo.Text;
                    usuarioAModificar.FechaNacimiento = fecha.Text;

                    Usuario us = new Usuario(usuarioAModificar.Id, usuarioAModificar.User, usuarioAModificar.Pass, usuarioAModificar.Correo, usuarioAModificar.FechaNacimiento);

                    int indiceUsuario = ListaDatosUsuarios.listaUsuarios.FindIndex(u => u.Id == usuarioAModificar.Id);
                    ListaDatosUsuarios.listaUsuarios.RemoveAt(indiceUsuario);
                    ListaDatosUsuarios.listaUsuarios.Insert(indiceUsuario, us);
                    cr.escribirXML();
                    MessageBox.Show("Todo OK ");
                    form1.Hide();
                    form1.Close();
                    form2.ShowDialog();
                }
                
            }
        }

        public void filtrar(System.Windows.Forms.GroupBox g, System.Windows.Forms.TextBox t)
        {
            g.Controls.Clear();
            string texto = t.Text.ToLower();

            var listaFiltrada = ListaDatosUsuarios.listaUsuarios.Where(x => x.User.ToLower().StartsWith(texto)).ToList();
            crearUsuarios(listaFiltrada, g);
        }

        public void ordenar(string ordenarPor, System.Windows.Forms.GroupBox g)
        {
            switch (ordenarPor)
            {
                case "id":
                    g.Controls.Clear();
                    var listaOrdenada = ListaDatosUsuarios.listaUsuarios.OrderBy(m => m.Id).ToList();

                    crearUsuarios(listaOrdenada, g);
                break;

                case "nombre":
                    g.Controls.Clear();
                    listaOrdenada = ListaDatosUsuarios.listaUsuarios.OrderBy(m => m.User).ToList();

                    crearUsuarios(listaOrdenada, g);
                break;

                case "fecha de nacimiento":
                    g.Controls.Clear();
                    listaOrdenada = ListaDatosUsuarios.listaUsuarios.OrderBy(m => m.FechaNacimiento).ToList();

                    crearUsuarios(listaOrdenada, g);
                break;
            }
        }



    }


}
