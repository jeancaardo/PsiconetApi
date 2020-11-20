using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class HistoriaClinicaInternacionModel
    {
        public int IdHisInt { get; set; }

        public int IdPaciente { get; set; }

        public MotivoIngresoModel MotivoIngreso { get; set; }

        public InterrogatorioAparatoSistemaModel Interrogatorio { get; set; }

        public AntecedentesPatologicosModel AntecedentesPatologicos { get; set; }

        public AntecedentesToxicosModel AntecedentesToxicos { get; set; }

        public ExamenesFisicosModel ExamenesFisicos { get; set; }

        public ExamenesComplementariosModel ExamenesComplementarios { get; set; }

        public DiagnosticoModel Diagnostico { get; set; }
    }
}
