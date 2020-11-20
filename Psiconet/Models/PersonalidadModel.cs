using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class PersonalidadModel
    {
        public int IdPersonalidad { get; set; }

        public string NecPsicodiagnostico { get; set; }
        public string ValoracionOPD { get; set; }
        public string ElYo { get; set; }    
        public string[] MecanismoDefensa { get; set; }
        public string ACR { get; set; }
        public string PruebaRealidad { get; set; }
        public string AutoPercepcion { get; set; }
        public string RCPAI { get; set; }
        public string ROI { get; set; }
        public string ProcesosCognitivos { get; set; }
        public string RegresionAdaptativa { get; set; }
        public string FiltroEstimulos { get; set; }
        public string FSI { get; set; }
        public string FA { get; set; }
        public string CD { get; set; }
        public string[] Presentacion { get; set; }
        public string[] Vestido  { get; set; }
        public string[] Actitud { get; set; }
        public string[] Conciencia { get; set; }
        public string[] Orientacion { get; set; }
        public string[] Atencion { get; set; }
        public string[] Memoria { get; set; }
        public string[] Paramnesias { get; set; }
        public string[] Sensopercepcion { get; set; }
        public string[] Alucinaciones { get; set; }
        public string[] Imaginacion { get; set; }
        public string NivelInteligencia { get; set; }
        public string CI { get; set; }
        public string Ritmo { get; set; }
        public string Alteracion { get; set; }
        public string Taquipsiquia { get; set; }
        public string Bradipsquia { get; set; }
        public string[] Pensamiento { get; set; }
        public string[] Ideacion { get; set; }
        public string[] IdeaDelirante { get; set; }
        public string IMuerte { get; set; }
        public string ISuicidio { get; set; }
        public string IVida { get; set; }
        public string PensamientoSuicida { get; set; }
        public string[] EsqCorporal { get; set; }
        public string Distorsion { get; set; }
        public string[] Juicio { get; set; }
        public string[] Condicionado { get; set; }
        public string GradoIP { get; set; }
        public string PermanenciaIP { get; set; }
        public string AlcanceIP { get; set; }
        public string AparicionIP { get; set; }
        public string TGIncapacidad { get; set; }
        public string[] Lenguaje { get; set; }
        public string[] Afectividad { get; set; }
        public string[] ActividadPM { get; set; }
        public string[] Voluntad { get; set; }
        public string[] Habitos { get; set; }
        public string Demanda { get; set; }

    }
}
