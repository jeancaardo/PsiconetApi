using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class HistoriaClinicaPsiquiatricaModel
    {
        public int IdHisCliPsi { get; set; }

        public int IdPaciente { get; set; }

        public MotivoConsultaPsiquiatricaModel MotCon { get; set; }

        public PersonalidadModel Per { get; set; }

        public DiagnosticoPsiquiatricoModel DiaPsi { get; set; }

        public PlanTerapeuticoPronosticoModel PlaTerPro { get; set; }

        public SeguimienoPsiquiatricoModel SegPsi { get; set; }
    }
}
