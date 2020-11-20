using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class ExamenesComplementariosModel
    {
        public int IdExaCom { get; set; }

        public String Laboratorio { get; set; }

        public String LaboratorioDesc { get; set; }

        public String Ecografia { get; set; }

        public String EcografiaDesc { get; set;}

        public String Tomografias { get; set; }

        public String TomografiasDesc { get; set;}

        public String Otros { get; set; }

        public String OtrosDesc { get; set; }
    }
}
