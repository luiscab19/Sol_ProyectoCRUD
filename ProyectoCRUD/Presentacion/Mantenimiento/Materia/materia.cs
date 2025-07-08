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
            ConfigurarDataGridView();
            this.Resize += materia_Resize;  // Agregar manejador para el evento Resize
            this.StartPosition = FormStartPosition.CenterScreen;  // Centrar el formulario en la pantalla
        }

        private void ConfigurarDataGridView()
        {
            // Configuración básica del DataGridView
            dataGridMateria.Width = 800;  // Ancho reducido
            dataGridMateria.Height = 401;
            dataGridMateria.RowHeadersVisible = false;
            dataGridMateria.AllowUserToAddRows = false;
            dataGridMateria.ReadOnly = true;
            dataGridMateria.BackgroundColor = Color.White;
            dataGridMateria.BorderStyle = BorderStyle.Fixed3D;
            dataGridMateria.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridMateria.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridMateria.EnableHeadersVisualStyles = false;
            dataGridMateria.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridMateria.ColumnHeadersHeight = 35;
            dataGridMateria.RowTemplate.Height = 30;

            // Centrar el DataGridView en el formulario
            dataGridMateria.Anchor = AnchorStyles.None;
            dataGridMateria.Location = new Point(
                (this.ClientSize.Width - dataGridMateria.Width) / 2,
                dataGridMateria.Location.Y);
        }

        private void CargarDatos()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM materia";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridMateria.DataSource = dt;

                    // Configuración específica de columnas
                    if (dataGridMateria.Columns.Count >= 4)
                    {
                        // Configurar botones para Editar/Eliminar
                        CrearBotonesEnGrid();

                        // Configurar columnas de datos
                        dataGridMateria.Columns[2].HeaderText = "Nombre Materia";
                        dataGridMateria.Columns[3].HeaderText = "Descripción";

                        // Ajustar anchos de columnas
                        dataGridMateria.Columns[0].Width = 80;   // Editar
                        dataGridMateria.Columns[1].Width = 80;   // Eliminar
                        dataGridMateria.Columns[2].Width = 200;  // Nombre Materia
                        dataGridMateria.Columns[3].Width = 400;  // Descripción

                        // Formato de celdas
                        dataGridMateria.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        dataGridMateria.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        dataGridMateria.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                        // Centrar encabezados
                        foreach (DataGridViewColumn col in dataGridMateria.Columns)
                        {
                            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar materias: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void CrearBotonesEnGrid()
        {
            // Columna de Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.Width = 80;
            btnEditar.DefaultCellStyle.BackColor = Color.LightBlue;
            btnEditar.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnEditar.FlatStyle = FlatStyle.Flat;

            // Columna de Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Width = 80;
            btnEliminar.DefaultCellStyle.BackColor = Color.LightCoral;
            btnEliminar.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnEliminar.FlatStyle = FlatStyle.Flat;

            // Reemplazar columnas existentes
            dataGridMateria.Columns.RemoveAt(0);
            dataGridMateria.Columns.RemoveAt(0);
            dataGridMateria.Columns.Insert(0, btnEditar);
            dataGridMateria.Columns.Insert(1, btnEliminar);
        }

        private void materia_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void materia_Resize(object sender, EventArgs e)
        {
            // Recentrar el DataGridView cuando se redimensione el formulario
            dataGridMateria.Location = new Point(
                (this.ClientSize.Width - dataGridMateria.Width) / 2,
                dataGridMateria.Location.Y);
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarMateria form = new EliminarMateria();
            form.Show();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarMat form = new AgregarMat();
            form.Show();
        }

        private void dataGridMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejar clics en los botones
            if (e.RowIndex >= 0 && e.ColumnIndex <= 1) // Columnas 0 y 1 son los botones
            {
                string materia_na = dataGridMateria.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (e.ColumnIndex == 0) // Botón Editar
                {
                    // Lógica para editar
                    CargarDatos(); // Refrescar datos después de editar
                }
                else if (e.ColumnIndex == 1) // Botón Eliminar
                {
                    if (MessageBox.Show($"¿Eliminar la materia {materia_na}?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        EliminarMateria(materia_na);
                        CargarDatos(); // Refrescar datos después de eliminar
                    }
                }
            }
        }

        private void EliminarMateria(string materia_na)
        {
            try
            {
                connection.Open();
                string query = $"DELETE FROM materia WHERE materia_na = '{materia_na}'";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Materia eliminada correctamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void lblfecha_Click(object sender, EventArgs e) { }

        private void lblhora_Click(object sender, EventArgs e) { }
    }
}