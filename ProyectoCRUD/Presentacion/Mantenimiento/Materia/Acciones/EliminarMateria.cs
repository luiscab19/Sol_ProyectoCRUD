using Npgsql;
using ProcesoCRUD.Datos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Materia.Acciones
{
    public partial class EliminarMateria : Form
    {
        public EliminarMateria()
        {
            InitializeComponent();
        }

        private void EliminarMateria_Load(object sender, EventArgs e)
        {
            // Configuración inicial del formulario
            this.Text = "Eliminar Materia";
            labelNombreMateria.Text = "Nombre de la materia que desea eliminar:";
            buttonAceptar.Text = "Eliminar";
            buttonAceptar.BackColor = Color.FromArgb(255, 128, 128); // Rojo claro para indicar peligro
        }

        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            // Validar campo obligatorio
            if (string.IsNullOrWhiteSpace(textBoxEliminarMateria.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la materia a eliminar.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEliminarMateria.Focus();
                return;
            }

            string nombreMateria = textBoxEliminarMateria.Text.Trim();

            // Confirmación antes de eliminar
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar la materia '{nombreMateria}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                // Obtener conexión usando tu clase Conexion
                using (NpgsqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    // Primero verificamos si la materia existe
                    string queryVerificar = @"SELECT COUNT(*) FROM materia 
                                           WHERE materia_na = @Nombre";

                    using (NpgsqlCommand verificarCmd = new NpgsqlCommand(queryVerificar, connection))
                    {
                        verificarCmd.Parameters.AddWithValue("@Nombre", nombreMateria);

                        long existe = (long)verificarCmd.ExecuteScalar();

                        if (existe == 0)
                        {
                            MessageBox.Show($"No se encontró la materia '{nombreMateria}'.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Procedemos con la eliminación
                    string queryEliminar = @"DELETE FROM materia 
                                          WHERE materia_na = @Nombre";

                    using (NpgsqlCommand eliminarCmd = new NpgsqlCommand(queryEliminar, connection))
                    {
                        eliminarCmd.Parameters.AddWithValue("@Nombre", nombreMateria);

                        int result = eliminarCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show($"Materia '{nombreMateria}' eliminada correctamente.", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la materia.", "Error",
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

        // Métodos de eventos no utilizados (se pueden eliminar si no son necesarios)
        private void labelNombreMateria_Click_1(object sender, EventArgs e) { }
        private void textBoxEliminarMateria_TextChanged(object sender, EventArgs e) { }
    }
}