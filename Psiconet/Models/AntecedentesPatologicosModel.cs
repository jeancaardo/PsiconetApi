using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class AntecedentesPatologicosModel
    {   
        public int IdAntPat { get; set; }
        public String SNC { get; set; }

        public String Respiratorios { get; set; }

        public String Cardiovascular { get; set; }

        public String Digestivo { get; set; }

        public String Nefrourologicos { get; set; }

        public String Infecciosos { get; set; }

        public String Endocrinologicos { get; set; }

        public String Metabolico { get; set; }

        public String Alergias { get; set; }

        public String Traumaticos { get; set; }

        public String GinecoObstetricos { get; set; }

        public String Quirurgicos { get; set; }

        public String Reumatologicos { get; set; }

        public String Traumatologicos { get; set; }

        public String Otro { get; set; }
    }
}
