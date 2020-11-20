using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class SeguimienoPsiquiatricoModel
    {
        public int IdSegPsi { get; set; }
        
        public string Subjetivo { get; set; }

        public string Objetivo { get; set; }

        public string Evaluacion { get; set; }

        public string Plan { get; set; }

        public string[][] HojaFlujo { get; set; }
    }
}
