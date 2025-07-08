using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesoCRUD.Entidades
{
    public class E_Inscripcion
    {
        public int Inscripcion_id { get; set; }
        public int Persona_id { get; set; }
        public string Estudiante_nombre { get; set; }
        public int Curso_id { get; set; }
        public string Curso_nombre { get; set; }
        public decimal? Calificacion { get; set; }
    }
}
