using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class DatosPersonaModel
    {   
        public int IdDatos { get; set; }

        public int IdPersona { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string EstadoCivil { get; set; }

        public string Genero { get; set; }

        public string Ocupacion { get; set; }

        public string Domicilio { get; set; }

        public string Localidad { get; set; }

        public string CodigoPostal { get; set; }

        public string Idioma { get; set; }

        public string email { get; set; }

        public string Telefono { get; set; }
    }
}
