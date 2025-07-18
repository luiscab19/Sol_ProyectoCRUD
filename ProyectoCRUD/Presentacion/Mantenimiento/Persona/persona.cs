﻿using ProyectoCRUD.Presentacion.Mantenimiento.Materia.Acciones;
using ProyectoCRUD.Presentacion.Mantenimiento.Persona.acciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Persona
{
    public partial class persona : Form
    {
        public persona()
        {
            InitializeComponent();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text=DateTime.Now.ToLongTimeString();
            lblfecha.Text=DateTime.Now.ToShortDateString();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarPersona form = new AgregarPersona();
            form.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarPersona form = new EliminarPersona();
            form.Show();
        }
    }
}
