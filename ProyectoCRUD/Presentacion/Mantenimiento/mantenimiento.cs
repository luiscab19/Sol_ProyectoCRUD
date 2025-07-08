using ProyectoCRUD.Presentacion.Mantenimiento.Curso;
using ProyectoCRUD.Presentacion.Mantenimiento.Materia;
using ProyectoCRUD.Presentacion.Mantenimiento.Persona;
using ProyectoCRUD.Presentacion.Mantenimiento.Seccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion
{
    public partial class mantenimiento : Form
    {
        public mantenimiento()
        {
            InitializeComponent();
        }

        private void mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text=DateTime.Now.ToLongTimeString();
            lblfecha.Text=DateTime.Now.ToShortDateString();
        }

        private void buttonMateria_Click(object sender, EventArgs e)
        {
            materia form = new materia();
            form.Show();
        }

        private void buttonSeccion_Click(object sender, EventArgs e)
        {
            seccion form = new seccion();
            form.Show();
        }

        private void buttonPersona_Click(object sender, EventArgs e)
        {
            persona form = new persona();
            form.Show();
        }

        private void buttonCurso_Click(object sender, EventArgs e)
        {
            curso form = new curso();
            form.Show();
        }
    }
}
