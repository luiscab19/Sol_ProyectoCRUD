using Npgsql;
using ProcesoCRUD.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Persona.acciones
{
    public partial class AgregarPersona : Form
    {
        public AgregarPersona()
        {
            InitializeComponent();
            CargarTiposPersona();
        }

        private void CargarTiposPersona()
        {
            try
            {
                using (NpgsqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    string query = "SELECT tipo_persona_id, tipo_persona_de FROM tipo_persona";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxTipoPersona.DataSource = dt;
                    comboBoxTipoPersona.DisplayMember = "tipo_persona_de";
                    comboBoxTipoPersona.ValueMember = "tipo_persona_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de persona: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(textBoxAgregarNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la persona.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAgregarNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxCedula.Text))
            {
                MessageBox.Show("Debe ingresar la cédula de la persona.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCedula.Focus();
                return;
            }

            if (comboBoxTipoPersona.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de persona.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxTipoPersona.Focus();
                return;
            }

            // Validar que la cédula sea numérica
            if (!int.TryParse(textBoxCedula.Text.Trim(), out int cedula))
            {
                MessageBox.Show("La cédula debe contener solo números.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCedula.Focus();
                return;
            }

            try
            {
                using (NpgsqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    connection.Open();

                    string query = @"INSERT INTO persona (persona_no, persona_id, tipo_persona_id) 
                                    VALUES (@Nombre, @Cedula, @TipoPersonaId)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", textBoxAgregarNombre.Text.Trim());
                        command.Parameters.AddWithValue("@Cedula", cedula); // Usamos el valor ya convertido a int
                        command.Parameters.AddWithValue("@TipoPersonaId", (int)comboBoxTipoPersona.SelectedValue);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Persona agregada correctamente.", "Éxito",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la persona.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                if (ex.Message.Contains("23505")) // Violación de clave única (cédula duplicada)
                {
                    MessageBox.Show("Ya existe una persona con esta cédula.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error de base de datos: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos existentes (pueden dejarse vacíos si no se necesita implementación adicional)
        private void label1_Click(object sender, EventArgs e) { }
        private void labelNombreMateria_Click(object sender, EventArgs e) { }
        private void textBoxAgregarNombre_TextChanged(object sender, EventArgs e) { }
        private void labelCedula_Click(object sender, EventArgs e) { }
        private void textBoxCedula_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void comboBoxTipoPersona_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}