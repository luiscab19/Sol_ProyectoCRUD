using Npgsql;
using ProcesoCRUD.Datos;
using ProcesoCRUD.Entidades;
using ProyectoCRUD.Presentacion.Mantenimiento.Materia.Acciones;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Materia
{
    public partial class materia : Form
    {
        private NpgsqlConnection connection;

        public materia()
        {
            InitializeComponent();
            connection = new Conexion().CrearConexion();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void materia_Load(object sender, EventArgs e)
        {
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarMat form = new AgregarMat();
            form.Show();

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void lblfecha_Click(object sender, EventArgs e) { }

        private void lblhora_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarMateria form = new EliminarMateria();
            form.Show();

        }
    }
}