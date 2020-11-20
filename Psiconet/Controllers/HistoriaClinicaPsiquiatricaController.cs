using Microsoft.AspNetCore.Mvc;
using Psiconet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Controllers
{
    public class HistoriaClinicaPsiquiatricaController : Controller
    {
        private HistoriaClinicaPsiquiatricaModel newHistoriaPsiquiatrica (DataRow dr)
        {
            MotivoConsultaPsiquiatricaModel motConPsi = new MotivoConsultaPsiquiatricaModel();
            PersonalidadModel per = new PersonalidadModel();
            DiagnosticoPsiquiatricoModel diaPsi = new DiagnosticoPsiquiatricoModel();
            PlanTerapeuticoPronosticoModel plaTerPro = new PlanTerapeuticoPronosticoModel();
            SeguimienoPsiquiatricoModel segPsi = new SeguimienoPsiquiatricoModel();
            HistoriaClinicaPsiquiatricaModel hisCliPsi = new HistoriaClinicaPsiquiatricaModel();

            motConPsi.IdMotConPsi = Convert.ToInt32(dr.Field<decimal>("IDMOTCONPSI"));
            motConPsi.Antecedentes = dr.Field<string>("Antecedentes");
            motConPsi.Motivo = dr.Field<string>("MOTIVO");

            per.ACR = dr.Field<string>("ACR");
            per.Actitud = dr.Field<string>("ACTITUD").Split(',');
            per.ActividadPM = dr.Field<string>("ACTIVIDADPM").Split(',');
            per.Afectividad = dr.Field<string>("AFECTIVIDAD").Split(',');
            per.AlcanceIP = dr.Field<string>("ALCANCEIP");
            per.Alteracion = dr.Field<string>("ALTERACION");
            per.Alucinaciones = dr.Field<string>("ALUCINACIONES").Split(',');
            per.AparicionIP = dr.Field<string>("APARICIONIP");
            per.Atencion = dr.Field<string>("ATENCION").Split(',');
            per.AutoPercepcion = dr.Field<string>("AUTOPERCEPCION");
            per.Bradipsquia = dr.Field<string>("BRADIPSIQUIA");
            per.CD = dr.Field<string>("CD");
            per.CI = dr.Field<string>("CI");
            per.Conciencia = dr.Field<string>("CONCIENCIA").Split(',');
            per.Condicionado = dr.Field<string>("CONDICIONADO").Split(',');
            per.Demanda = dr.Field<string>("DEMANDA");
            per.Distorsion = dr.Field<string>("DISTORSION");
            per.ElYo = dr.Field<string>("ELYO");
            per.EsqCorporal = dr.Field<string>("ESQCORPORAL").Split(',');
            per.FA = dr.Field<string>("FA");
            per.FiltroEstimulos = dr.Field<string>("FILTROESTIMULOS");
            per.FSI = dr.Field<string>("FSI");
            per.GradoIP = dr.Field<string>("GRADOIP");
            per.Habitos = dr.Field<string>("HABITOS").Split(',');
            per.Ideacion = dr.Field<string>("IDEACION").Split(',');
            per.IdeaDelirante = dr.Field<string>("IDEADELIRANTE").Split(',');
            per.IdPersonalidad = Convert.ToInt32(dr.Field<Decimal>("IDPERSONALIDAD"));
            per.Imaginacion = dr.Field<string>("IMAGINACION").Split(',');
            per.IMuerte = dr.Field<string>("IMUERTE");
            per.ISuicidio = dr.Field<string>("ISUICIDIO");
            per.IVida = dr.Field<string>("IVIDA");
            per.Juicio = dr.Field<string>("JUICIO").Split(',');
            per.Lenguaje = dr.Field<string>("LENGUAJE").Split(',');
            per.MecanismoDefensa = dr.Field<string>("MECDEF").Split(',');
            per.NecPsicodiagnostico = dr.Field<string>("NECPSICODIAGNOSTICO");
            per.Memoria = dr.Field<string>("MEMORIA").Split(',');
            per.NivelInteligencia = dr.Field<string>("NIVELINTELIGENCIA");
            per.Orientacion = dr.Field<string>("ORIENTACION").Split(',');
            per.Paramnesias = dr.Field<string>("PARAMNESIAS").Split(',');
            per.Pensamiento = dr.Field<string>("PENSAMIENTO").Split(',');
            per.PensamientoSuicida = dr.Field<string>("PENSAMIENTOSUICIDA");
            per.PermanenciaIP = dr.Field<string>("PERMANENCIAIP");
            per.Presentacion = dr.Field<string>("PRESENTACION").Split(',');
            per.ProcesosCognitivos = dr.Field<string>("PROCESOSCOGNITIVOS");
            per.PruebaRealidad = dr.Field<string>("PRUEBAREALIDAD");
            per.RCPAI = dr.Field<string>("RCPAI");
            per.RegresionAdaptativa = dr.Field<string>("REGRESIONADAPTATIVA");
            per.Ritmo = dr.Field<string>("RITMO");
            per.ROI = dr.Field<string>("ROI");
            per.Sensopercepcion = dr.Field<string>("SENSOPERCEPCION").Split(',');
            per.Taquipsiquia = dr.Field<string>("TAQUIPSIQUIA");
            per.TGIncapacidad = dr.Field<string>("TGINCAPACIDAD");
            per.ValoracionOPD = dr.Field<string>("VALORACIONOPD");
            per.Vestido = dr.Field<string>("VESTIDO").Split(',');
            per.Voluntad = dr.Field<string>("VOLUNTAD").Split(',');
            

            diaPsi.CA = dr.Field<string>("CA");
            diaPsi.CA_Cod = dr.Field<string>("CA_COD");
            diaPsi.CMG = deStringABidimensional(dr.Field<string>("CMG"), 2);
            diaPsi.CuidadoPersonal = dr.Field<string>("CUIDADOPERSONAL");
            diaPsi.EL = dr.Field<string>("EL");
            diaPsi.EL_Cod = dr.Field<string>("EL_COD");
            diaPsi.ERPS = dr.Field<string>("ERPS");
            diaPsi.ET = dr.Field<string>("ET");
            diaPsi.ET_Cod = dr.Field<string>("ET_COD");
            diaPsi.Familia = dr.Field<string>("FAMILIA");
            diaPsi.FPP = dr.Field<string>("FPP");
            diaPsi.FV = dr.Field<string>("FV");
            diaPsi.FV_Cod = dr.Field<string>("FV_COD");
            diaPsi.IdDiaPsi = Convert.ToInt32(dr.Field<Decimal>("IDDIAPSI"));
            diaPsi.Ocupacion = dr.Field<string>("OCUPACION");
            diaPsi.PCC = dr.Field<string>("PCC");
            diaPsi.SocialGral = dr.Field<string>("SOCIALGRAL");
            diaPsi.TP = deStringABidimensional(dr.Field<string>("TP"), 2);

            plaTerPro.IdPlaTerPro = Convert.ToInt32(dr.Field<Decimal>("IDPLATERPRO"));
            plaTerPro.Plan = deStringABidimensional(dr.Field<string>("PLAN"), 3);
            plaTerPro.Pronostico = dr.Field<string>("PRONOSTICO").Split(',');

            segPsi.Evaluacion = dr.Field<string>("EVALUACION");
            segPsi.HojaFlujo = deStringABidimensional(dr.Field<string>("HOJAFLUJO"), 8);
            segPsi.IdSegPsi = Convert.ToInt32(dr.Field<Decimal>("IDSEGPSI"));
            segPsi.Objetivo = dr.Field<string>("OBJETIVO");
            segPsi.Plan = dr.Field<string>("PLANSEG");
            segPsi.Subjetivo = dr.Field<string>("SUBJETIVO");

            hisCliPsi.IdHisCliPsi = Convert.ToInt32(dr.Field<Decimal>("IDHISCLIPSI"));
            hisCliPsi.DiaPsi = diaPsi;
            hisCliPsi.MotCon = motConPsi;
            hisCliPsi.Per = per;
            hisCliPsi.PlaTerPro = plaTerPro;
            hisCliPsi.SegPsi = segPsi;

            return hisCliPsi;
        }

        private String[][] deStringABidimensional(string cadena, int division)
        {
            String[] aux = cadena.Split(',');
            String[] aux2 = new String[division];
            String[][] res = new String[aux.Length / division][];
            if(aux.Length > 1)
            {
                for (int i = 0; i < aux.Length / division; i++)
                { 
                    for(int j = 0; j<division; j++) { aux2[j] = aux[j + division * i]; }

                    res[i] = aux2;
                }
            }

            return res;
        }

        private String deBidimensionalAstring(String[][] array)
        {
            List<String> aux = array[0].ToList();
            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    for(int j = 0; j < array[i].Length; j++)
                    {
                        aux.Add(array[i][j]);
                    }
                    
                }
            }
            return String.Join(',', aux);
        }

        public int insertarHistoriaClinicaPsiquiatrica(HistoriaClinicaPsiquiatricaModel oHisCliPsi)
        {

            decimal Id1 = DataHelper.ExecuteNonQuery("IU_MOTCONPSI",
            oHisCliPsi.MotCon.IdMotConPsi,
            oHisCliPsi.MotCon.Motivo,
            oHisCliPsi.MotCon.Antecedentes);

            decimal Id2 = DataHelper.ExecuteNonQuery("IU_PERSONALIDAD",
            oHisCliPsi.Per.IdPersonalidad,
            oHisCliPsi.Per.NecPsicodiagnostico,
            oHisCliPsi.Per.ValoracionOPD,
            oHisCliPsi.Per.ElYo,
            string.Join(',', oHisCliPsi.Per.MecanismoDefensa),
            oHisCliPsi.Per.ACR,
            oHisCliPsi.Per.PruebaRealidad,
            oHisCliPsi.Per.AutoPercepcion,
            oHisCliPsi.Per.RCPAI,
            oHisCliPsi.Per.ROI,
            oHisCliPsi.Per.ProcesosCognitivos,
            oHisCliPsi.Per.RegresionAdaptativa,
            oHisCliPsi.Per.FiltroEstimulos,
            oHisCliPsi.Per.FSI,
            oHisCliPsi.Per.FA,
            oHisCliPsi.Per.CD,
            string.Join(',', oHisCliPsi.Per.Presentacion),
            string.Join(',', oHisCliPsi.Per.Vestido),
            string.Join(',', oHisCliPsi.Per.Actitud),
            string.Join(',', oHisCliPsi.Per.Conciencia),
            string.Join(',', oHisCliPsi.Per.Orientacion),
            string.Join(',', oHisCliPsi.Per.Atencion),
            string.Join(',', oHisCliPsi.Per.Memoria),
            string.Join(',', oHisCliPsi.Per.Paramnesias),
            string.Join(',', oHisCliPsi.Per.Sensopercepcion),
            string.Join(',', oHisCliPsi.Per.Alucinaciones),
            string.Join(',', oHisCliPsi.Per.Imaginacion),
            oHisCliPsi.Per.NivelInteligencia,
            oHisCliPsi.Per.CI,
            oHisCliPsi.Per.Ritmo,
            oHisCliPsi.Per.Alteracion,
            oHisCliPsi.Per.Taquipsiquia,
            oHisCliPsi.Per.Bradipsquia,
            string.Join(',', oHisCliPsi.Per.Pensamiento),
            string.Join(',', oHisCliPsi.Per.Ideacion),
            string.Join(',', oHisCliPsi.Per.IdeaDelirante),
            oHisCliPsi.Per.IMuerte,
            oHisCliPsi.Per.ISuicidio,
            oHisCliPsi.Per.IVida,
            oHisCliPsi.Per.PensamientoSuicida,
            string.Join(',', oHisCliPsi.Per.EsqCorporal),
            oHisCliPsi.Per.Distorsion,
            string.Join(',', oHisCliPsi.Per.Juicio),
            string.Join(',', oHisCliPsi.Per.Condicionado),
            oHisCliPsi.Per.GradoIP,
            oHisCliPsi.Per.PermanenciaIP,
            oHisCliPsi.Per.AlcanceIP,
            oHisCliPsi.Per.AparicionIP,
            oHisCliPsi.Per.TGIncapacidad,
            string.Join(',', oHisCliPsi.Per.Lenguaje),
            string.Join(',', oHisCliPsi.Per.Afectividad),
            string.Join(',', oHisCliPsi.Per.ActividadPM),
            string.Join(',', oHisCliPsi.Per.Voluntad),
            string.Join(',', oHisCliPsi.Per.Habitos),
            oHisCliPsi.Per.Demanda);

            decimal Id3 = DataHelper.ExecuteNonQuery("IU_DIAPSI",
            oHisCliPsi.DiaPsi.IdDiaPsi,
            deBidimensionalAstring(oHisCliPsi.DiaPsi.TP),
            deBidimensionalAstring(oHisCliPsi.DiaPsi.CMG),
            oHisCliPsi.DiaPsi.CuidadoPersonal,
            oHisCliPsi.DiaPsi.Ocupacion,
            oHisCliPsi.DiaPsi.Familia,
            oHisCliPsi.DiaPsi.SocialGral,
            oHisCliPsi.DiaPsi.FV,
            oHisCliPsi.DiaPsi.ET,
            oHisCliPsi.DiaPsi.EL,
            oHisCliPsi.DiaPsi.CA,
            oHisCliPsi.DiaPsi.PCC,
            oHisCliPsi.DiaPsi.FPP,
            oHisCliPsi.DiaPsi.ERPS,
            oHisCliPsi.DiaPsi.FV_Cod,
            oHisCliPsi.DiaPsi.ET_Cod,
            oHisCliPsi.DiaPsi.EL_Cod,
            oHisCliPsi.DiaPsi.CA_Cod);

            Decimal Id4 = DataHelper.ExecuteNonQuery("IU_PLATERPRO",
            oHisCliPsi.PlaTerPro.IdPlaTerPro,
            deBidimensionalAstring(oHisCliPsi.PlaTerPro.Plan),
            string.Join(',', oHisCliPsi.PlaTerPro.Pronostico));

            Decimal Id5 = DataHelper.ExecuteNonQuery("IU_SEGPSI",
            oHisCliPsi.SegPsi.IdSegPsi,
            oHisCliPsi.SegPsi.Subjetivo,
            oHisCliPsi.SegPsi.Objetivo,
            oHisCliPsi.SegPsi.Evaluacion,
            oHisCliPsi.SegPsi.Plan,
            deBidimensionalAstring( oHisCliPsi.SegPsi.HojaFlujo));

            int Id6 = DataHelper.ExecuteNonQuery("IU_HISCLIPSI", oHisCliPsi.IdHisCliPsi, Id1, Id2, Id3, Id4, Id5, oHisCliPsi.IdPaciente);

            return Id6;
        }


        public HistoriaClinicaPsiquiatricaModel obtenerHistoriaPsiquiatrica(int IdPaciente) {
            DataTable dt;
            HistoriaClinicaPsiquiatricaModel obj = null;

            dt = DataHelper.ExecuteQuery("S_HISCLIPSI", IdPaciente);

            if (dt.Rows.Count > 0)
            {
                obj = newHistoriaPsiquiatrica(dt.Rows[0]);
            }
            return obj;
        }
    }
}
