using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class AntecedentesToxicosModel
    {
        public int IdAntTox { get; set; }

        public String Ingesta { get; set; }

        public String ToxicoManias { get; set; }

        public String Higiene { get; set; }

        public String Tabaquismo { get; set; }

        public String Alcoholismo { get; set; }

        public String Frec_Alc { get; set; }
    }
}
