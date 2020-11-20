using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class DiagnosticoPsiquiatricoModel
    {
        public int IdDiaPsi { get; set; }

        public string[][] TP { get; set;}
        public string[][] CMG { get; set;}
        public string CuidadoPersonal { get; set;}
        public string Ocupacion { get; set;}
        public string Familia { get; set;}
        public string SocialGral { get; set;}
        public string FV { get; set;}
        public string FV_Cod { get; set;}
        public string ET { get; set;}
        public string ET_Cod { get; set;}
        public string EL { get; set;}
        public string EL_Cod { get; set;}
        public string CA { get; set;}
        public string CA_Cod { get; set;}
        public string PCC { get; set;}
        public string FPP { get; set;}
        public string ERPS { get; set;}
    }
}
