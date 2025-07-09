using Npgsql;
using ProcesoCRUD.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Persona.acciones
{
    public partial class EliminarPersona : Form
    {
        public EliminarPersona()
        {
            InitializeComponent();
        }

        private void labelCedulaPersona_Click(object sender, EventArgs e)
        {
            // Método vacío para el evento click del label
        }

        private void textBoxEliminarPersona_TextChanged(object sender, EventArgs e)
        {
            // Método vacío para el evento de cambio de texto
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado una cédula
            if (string.IsNullOrWhiteSpace(textBoxEliminarPersona.Text))
            {
                MessageBox.Show("Debe ingresar la cédula de la persona a eliminar.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEliminarPersona.Focus();
                return;
            }

            // Validar que la cédula sea numérica
            if (!int.TryParse(textBoxEliminarPersona.Text.Trim(), out int cedula))
            {
                MessageBox.Show("La cédula debe contener solo números.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEliminarPersona.Focus();
                return;
            }

            // Confirmar con el usuario antes de eliminar
            DialogResult confirmacion = MessageBox.Show($"¿Está seguro que desea eliminar a la persona con cédula {cedula}?",
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

                    string query = "DELETE FROM persona WHERE persona_id = @Cedula";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Cedula", cedula);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Persona eliminada correctamente.", "Éxito",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró una persona con esa cédula.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error de base de datos al eliminar la persona: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarPersona_Load(object sender, EventArgs e)
        {

        }
    }
}