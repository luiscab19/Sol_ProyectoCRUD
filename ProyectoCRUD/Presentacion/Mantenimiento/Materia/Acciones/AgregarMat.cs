using Npgsql;
using ProcesoCRUD.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Materia.Acciones
{
    public partial class AgregarMat : Form
    {
        public AgregarMat()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            // Configuración inicial del formulario
            this.Text = "Añadir Nueva Materia";
            labelNombreMateria.Text = "Nombre de la materia:";
            labelContenido.Text = "Contenido programático:";
            buttonAceptar.Text = "Guardar";

            // Configurar el TextBox de contenido
            textBoxContenido.Multiline = true;
            textBoxContenido.ScrollBars = ScrollBars.Vertical;
            textBoxContenido.Height = 100;
        }

        private void labelNombreMateria_Click(object sender, EventArgs e)
        {

        }

        private void labelContenido_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAgregarMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContenido_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(textBoxAgregarMateria.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la materia.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAgregarMateria.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxContenido.Text))
            {
                MessageBox.Show("Debe ingresar el contenido programático.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContenido.Focus();
                return;
            }

            try
            {
                // Obtener conexión usando tu clase Conexion
                using (NpgsqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    string query = @"INSERT INTO materia (materia_na, materia_de) 
                                    VALUES (@Nombre, @Contenido)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", textBoxAgregarMateria.Text.Trim());
                        command.Parameters.AddWithValue("@Contenido", textBoxContenido.Text.Trim());

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Materia agregada correctamente.", "Éxito",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la materia.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarMat_Load(object sender, EventArgs e)
        {

        }
    }
}
