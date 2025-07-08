using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesoCRUD.Datos
{
    public class Conexion
    {
        private string Basededatos;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        public Conexion()
        {
            this.Basededatos = "sistema_crud"; // Nombre de la base de datos
            this.Servidor = "localhost";      // Servidor
            this.Puerto = "5432";             // Puerto
            this.Usuario = "postgres";        // Usuario
            this.Clave = "31211294";          // Contraseña
        }

        public NpgsqlConnection CrearConexion()
        {
            NpgsqlConnection Cadena = new NpgsqlConnection();

            try
            {
                // Cadena de conexión completa
                Cadena.ConnectionString = "Server=" + this.Servidor + ";" +
                                         "Port=" + this.Puerto + ";" +
                                         "User Id=" + this.Usuario + ";" +
                                         "Password=" + this.Clave + ";" +
                                         "Database=" + this.Basededatos + ";";

                // Abrir la conexión para probarla
                Cadena.Open();
                // Cerrarla inmediatamente después de probar
                Cadena.Close();
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw new Exception("Error al establecer la conexión: " + ex.Message);
            }

            return Cadena;
        }

        // Método para obtener una instancia única (Singleton)
        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
