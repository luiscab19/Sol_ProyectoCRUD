using Npgsql;
using ProcesoCRUD.Datos;
using System;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Seccion.Acciones
{
    public partial class Eliminar_Seccion : Form
    {
        public Eliminar_Seccion()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            // Validar campo obligatorio
            if (string.IsNullOrWhiteSpace(textBoxEliminarSeccion.Text))
            {
                MessageBox.Show("Debe ingresar el ID de la sección a eliminar.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEliminarSeccion.Focus();
                return;
            }

            // Validar que el ID sea un número válido
            if (!int.TryParse(textBoxEliminarSeccion.Text.Trim(), out int seccionId))
            {
                MessageBox.Show("El ID de la sección debe ser un número entero válido.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEliminarSeccion.Focus();
                return;
            }

            // Confirmar con el usuario antes de eliminar
            DialogResult confirmacion = MessageBox.Show($"¿Está seguro que desea eliminar la sección con ID {seccionId}?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                // Obtener conexión usando la clase Conexion
                using (NpgsqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    string query = "DELETE FROM seccion WHERE seccion_id = @SeccionId";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SeccionId", seccionId);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Sección eliminada correctamente.", "Éxito",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la sección con el ID especificado.", "Error",
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

        // Métodos existentes (pueden dejarse vacíos si no se necesita implementación adicional)
        private void Eliminar_Seccion_Load(object sender, EventArgs e) { }
        private void labelNombreSeccion_Click(object sender, EventArgs e) { }
        private void textBoxEliminarSeccion_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}