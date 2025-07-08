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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text=DateTime.Now.ToLongTimeString();
            lblfecha.Text=DateTime.Now.ToShortDateString();
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            reporte form = new reporte();
            form.Show();
        }

        private void buttonNotas_Click(object sender, EventArgs e)
        {
            notas form = new notas();
            form.Show();
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            inscripcion form = new inscripcion();
            form.Show();

        }

        private void buttonMantenimiento_Click(object sender, EventArgs e)
        {
            mantenimiento form = new mantenimiento();
            form.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}

