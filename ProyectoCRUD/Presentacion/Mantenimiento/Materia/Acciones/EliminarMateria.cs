using Npgsql;
using ProcesoCRUD.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Materia.Acciones
{
    public partial class EliminarMateria : Form
    {
        public EliminarMateria()
        {
            InitializeComponent();
        }

        private void labelNombreMateria_Click_1(object sender, EventArgs e)
        {
            // Método vacío para el evento click del label
        }

        private void textBoxEliminarMateria_TextChanged(object sender, EventArgs e)
        {
            // Método vacío para el evento de cambio de texto
        }

        private void EliminarMateria_Load(object sender, EventArgs e)
        {
            // Puedes cargar datos iniciales aquí si es necesario
        }

        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un nombre de materia
            if (string.IsNullOrWhiteSpace(textBoxEliminarMateria.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la materia a eliminar.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEliminarMateria.Focus();
                return;
            }

            string nombreMateria = textBoxEliminarMateria.Text.Trim();

            // Confirmar con el usuario antes de eliminar
            DialogResult confirmacion = MessageBox.Show($"¿Está seguro que desea eliminar la materia '{nombreMateria}'?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (NpgsqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    string query = "DELETE FROM materia WHERE materia_na = @NombreMateria";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreMateria", nombreMateria);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Materia eliminada correctamente.", "Éxito",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró una materia con ese nombre.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                if (ex.Message.Contains("23503")) // Violación de clave foránea
                {
                    MessageBox.Show("No se puede eliminar la materia porque está siendo utilizada en otros registros.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error de base de datos al eliminar la materia: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para el botón Cancelar
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}