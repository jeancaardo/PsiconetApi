using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class PersonaModel
    {
        public int IdPersona { get; set; }

        public int Dni { get; set; }

        public DateTime Fecha_nac { get; set; }

        public string Tipo_Doc { get; set; }

        public string Nacionalidad { get; set; }

        public DatosPersonaModel? Datos_personales { get; set; }
}
}
