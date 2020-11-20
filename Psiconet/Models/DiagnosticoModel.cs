using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class DiagnosticoModel
    {
        public int IdDiagnostico { get; set; }

        public String EnfermedadActual { get; set; }

        public String AntecedentesEnfAct { get; set; }

        public String Diagnosticos { get; set; }

        public String Indicaciones { get; set; }

        public String Analgesia { get; set; }

        public String OtrasInd { get; set; }

        public String ComentarioIngreso { get; set; }
    }
}
