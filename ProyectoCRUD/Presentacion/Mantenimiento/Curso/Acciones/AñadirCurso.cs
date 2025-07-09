using Npgsql;
using ProcesoCRUD.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoCRUD.Presentacion.Mantenimiento.Curso.Acciones
{
    public partial class AñadirCurso : Form
    {
        private NpgsqlConnection connection;

        public AñadirCurso()
        {
            InitializeComponent();
            connection = new Conexion().CrearConexion();

            // Asignar manualmente el evento si es necesario
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void textBoxAgregarCodigo_TextChanged(object sender, EventArgs e) { }
        private void labelSeccion_Click(object sender, EventArgs e) { }
        private void comboBoxSeccion_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void comboBoxMateria_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void comboBoxProfesor_SelectedIndexChanged(object sender, EventArgs e) { }

        private void AñadirCurso_Load(object sender, EventArgs e)
        {
            CargarComboboxes();
        }

        private void CargarComboboxes()
        {
            try
            {
                CargarMaterias();
                CargarProfesores();
                CargarSecciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMaterias()
        {
            using (connection = new Conexion().CrearConexion())
            {
                connection.Open();
                string query = "SELECT materia_na, materia_de FROM materia ORDER BY materia_na";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    comboBoxMateria.DataSource = dt;
                    comboBoxMateria.DisplayMember = "materia_na";
                    comboBoxMateria.ValueMember = "materia_na";
                }
            }
        }

        private void CargarProfesores()
        {
            using (connection = new Conexion().CrearConexion())
            {
                connection.Open();
                string query = @"SELECT p.persona_id, p.persona_no 
                               FROM persona p
                               WHERE p.tipo_persona_id = 2
                               ORDER BY p.persona_no";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    comboBoxProfesor.DataSource = dt;
                    comboBoxProfesor.DisplayMember = "persona_no";
                    comboBoxProfesor.ValueMember = "persona_id";
                }
            }
        }

        private void CargarSecciones()
        {
            using (connection = new Conexion().CrearConexion())
            {
                connection.Open();
                string query = "SELECT seccion_id, seccion_de FROM seccion ORDER BY seccion_de";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    comboBoxSeccion.DataSource = dt;
                    comboBoxSeccion.DisplayMember = "seccion_de";
                    comboBoxSeccion.ValueMember = "seccion_id";
                }
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    string materia = comboBoxMateria.SelectedValue?.ToString();
                    int seccionId = (int)comboBoxSeccion.SelectedValue;
                    int profesorId = (int)comboBoxProfesor.SelectedValue;

                    using (connection = new Conexion().CrearConexion())
                    {
                        connection.Open();

                        string queryVerificar = @"SELECT COUNT(*) FROM curso 
                                               WHERE seccion_id = @SeccionId 
                                               AND materia_na = @Materia
                                               AND persona_id = @ProfesorId";
                        using (NpgsqlCommand cmdVerificar = new NpgsqlCommand(queryVerificar, connection))
                        {
                            cmdVerificar.Parameters.AddWithValue("@SeccionId", seccionId);
                            cmdVerificar.Parameters.AddWithValue("@Materia", materia);
                            cmdVerificar.Parameters.AddWithValue("@ProfesorId", profesorId);

                            long existe = (long)cmdVerificar.ExecuteScalar();

                            if (existe > 0)
                            {
                                MessageBox.Show("Ya existe un curso con esta configuración", "Error",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string queryInsertar = @"INSERT INTO curso (seccion_id, materia_na, persona_id) 
                                              VALUES (@SeccionId, @Materia, @ProfesorId)";

                        using (NpgsqlCommand cmdInsertar = new NpgsqlCommand(queryInsertar, connection))
                        {
                            cmdInsertar.Parameters.AddWithValue("@SeccionId", seccionId);
                            cmdInsertar.Parameters.AddWithValue("@Materia", materia);
                            cmdInsertar.Parameters.AddWithValue("@ProfesorId", profesorId);

                            int result = cmdInsertar.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Curso agregado correctamente", "Éxito",
                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar curso: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (comboBoxMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una materia", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxMateria.Focus();
                return false;
            }

            if (comboBoxSeccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una sección", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxSeccion.Focus();
                return false;
            }

            if (comboBoxProfesor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un profesor", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxProfesor.Focus();
                return false;
            }

            return true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}