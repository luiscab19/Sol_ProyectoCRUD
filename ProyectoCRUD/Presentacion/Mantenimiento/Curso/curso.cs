using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Curso
{
    public partial class curso : Form
    {
        public curso()
        {
            InitializeComponent();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text=DateTime.Now.ToLongTimeString();
            lblfecha.Text=DateTime.Now.ToShortDateString();
        }
    }
}
