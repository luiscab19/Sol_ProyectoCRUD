using Npgsql;
using ProcesoCRUD.Datos;
using System;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Curso.Acciones
{
    public partial class EliminarCurso : Form
    {
        public EliminarCurso()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            // Validar campo obligatorio
            if (string.IsNullOrWhiteSpace(textBoxEliminarCurso.Text))
            {
                MessageBox.Show("Debe ingresar el ID del curso a eliminar.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEliminarCurso.Focus();
                return;
            }

            // Validar que el ID sea un número válido
            if (!int.TryParse(textBoxEliminarCurso.Text.Trim(), out int cursoId))
            {
                MessageBox.Show("El ID del curso debe ser un número entero válido.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEliminarCurso.Focus();
                return;
            }

            // Confirmar con el usuario antes de eliminar
            DialogResult confirmacion = MessageBox.Show($"¿Está seguro que desea eliminar el curso con ID {cursoId}?",
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

                    // Primero eliminamos las inscripciones relacionadas al curso
                    string queryInscripciones = "DELETE FROM inscripcion WHERE curso_id = @CursoId";
                    using (NpgsqlCommand cmdInscripciones = new NpgsqlCommand(queryInscripciones, connection))
                    {
                        cmdInscripciones.Parameters.AddWithValue("@CursoId", cursoId);
                        cmdInscripciones.ExecuteNonQuery();
                    }

                    // Luego eliminamos el curso
                    string queryCurso = "DELETE FROM curso WHERE curso_id = @CursoId";
                    using (NpgsqlCommand command = new NpgsqlCommand(queryCurso, connection))
                    {
                        command.Parameters.AddWithValue("@CursoId", cursoId);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Curso eliminado correctamente.", "Éxito",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el curso con el ID especificado.", "Error",
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

        // Métodos existentes (se mantienen igual)
        private void EliminarCurso_Load(object sender, EventArgs e) { }
        private void labelNombreCurso_Click(object sender, EventArgs e) { }
        private void textBoxEliminarCurso_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}