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

namespace ProyectoCRUD.Presentacion.Mantenimiento.Seccion.Acciones
{
    public partial class AgregarSeccion : Form
    {
        public AgregarSeccion()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void labelContenido_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreMateria_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContenido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAgregarMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCodigo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAgregarCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSeccion_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContenido_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(textBoxAgregarCodigo.Text))
            {
                MessageBox.Show("Debe ingresar el codigo de la materia.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAgregarCodigo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxContenido.Text))
            {
                MessageBox.Show("Debe ingresar el contenido programático.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContenido.Focus();
                return;
            }

            // Validar que el código sea un número válido
            if (!int.TryParse(textBoxAgregarCodigo.Text.Trim(), out int codigo))
            {
                MessageBox.Show("El código debe ser un número entero válido.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAgregarCodigo.Focus();
                return;
            }

            try
            {
                // Obtener conexión usando tu clase Conexion
                using (NpgsqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    string query = @"INSERT INTO seccion (seccion_id, seccion_de) 
                            VALUES (@Codigo, @Seccion)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Codigo", codigo); // Usamos el entero convertido
                        command.Parameters.AddWithValue("@Seccion", textBoxContenido.Text.Trim());

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
