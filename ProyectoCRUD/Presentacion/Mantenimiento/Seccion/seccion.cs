using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Seccion
{
    public partial class seccion : Form
    {
        public seccion()
        {
            InitializeComponent();
        }

        private void seccion_Load(object sender, EventArgs e)
        {
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text=DateTime.Now.ToLongTimeString();
            lblfecha.Text=DateTime.Now.ToShortDateString();
        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }
    }
}
