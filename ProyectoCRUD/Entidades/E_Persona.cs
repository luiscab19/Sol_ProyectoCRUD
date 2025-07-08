using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ProcesoCRUD.Entidades
{
    public class E_Persona
    {
        public int Persona_id { get; set; }
        public string Persona_no { get; set; }
        public string Persona_de { get; set; }
        public int Tipo_persona_id { get; set; }
        public string Tipo_persona_de { get; set; }

        public E_Persona()
        {
            Persona_no = " ";
            Persona_de = " ";
            Tipo_persona_de =  "";
        }

    }
}

