using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class PlanTerapeuticoPronosticoModel
    {
        public int IdPlaTerPro { get; set; }

        public string[][] Plan { get; set; }

        public string[] Pronostico { get; set; }
    }
}
