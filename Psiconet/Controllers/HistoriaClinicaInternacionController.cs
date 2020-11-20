using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Psiconet.Models;

namespace Psiconet.Controllers
{
    public class HistoriaClinicaInternacionController : Controller
    {
        
        private HistoriaClinicaInternacionModel newHistoriaInternacion(DataRow dr)
        {
            HistoriaClinicaInternacionModel histInt = new HistoriaClinicaInternacionModel() ;
            MotivoIngresoModel motivoIngreso = new MotivoIngresoModel();
            InterrogatorioAparatoSistemaModel interrogatorio = new InterrogatorioAparatoSistemaModel();
            AntecedentesPatologicosModel antecedentesPatologicos = new AntecedentesPatologicosModel();
            AntecedentesToxicosModel antecedentesToxicos = new AntecedentesToxicosModel();
            ExamenesFisicosModel examenesFisicos = new ExamenesFisicosModel();
            ExamenesComplementariosModel examenesComplementarios = new ExamenesComplementariosModel();
            DiagnosticoModel diagnostico = new DiagnosticoModel();


            histInt.IdHisInt = Convert.ToInt32(dr.Field<Decimal>("IDHISINT"));
            histInt.IdPaciente = Convert.ToInt32(dr.Field<Decimal>("IDPACIENTE"));
            motivoIngreso.IdMotIng = Convert.ToInt32(dr.Field<Decimal>("IDMOTING"));
            motivoIngreso.MotivoIng = dr.Field<string>("MOTIVO_ING");
            interrogatorio.AC = dr.Field<string>("AC");
            interrogatorio.AC_desc = dr.Field<string>("AC_DESC");
            interrogatorio.AD = dr.Field<string>("AD");
            interrogatorio.AD_desc = dr.Field<string>("AD_DESC");
            interrogatorio.AGU = dr.Field<string>("AGU");
            interrogatorio.AGU_desc = dr.Field<string>("AGU_DESC");
            interrogatorio.AR = dr.Field<string>("AR");
            interrogatorio.AR_desc = dr.Field<string>("AR_DESC");
            interrogatorio.IdIntApaSis = Convert.ToInt32(dr.Field<Decimal>("IDINTAPASIS"));
            interrogatorio.ORG_sentidos =  dr.Field<string>("ORG_SENTIDOS");
            interrogatorio.OS_desc = dr.Field<string>("OS_DESC");
            interrogatorio.SE =  dr.Field<string>("SE");
            interrogatorio.SE_desc = dr.Field<string>("SE_DESC");
            interrogatorio.SME =  dr.Field<string>("SME");
            interrogatorio.SME_desc = dr.Field<string>("SME_DESC");
            interrogatorio.SNG =  dr.Field<string>("SNG");
            interrogatorio.SNG_desc = dr.Field<string>("SNG_DESC");
            interrogatorio.ST =  dr.Field<string>("ST");
            interrogatorio.ST_desc = dr.Field<string>("ST_DESC");
            antecedentesPatologicos.Alergias = dr.Field<string>("ALERGIAS");
            antecedentesPatologicos.Cardiovascular = dr.Field<string>("CARDIOVASCULAR");
            antecedentesPatologicos.Digestivo = dr.Field<string>("DIGESTIVO");
            antecedentesPatologicos.Endocrinologicos = dr.Field<string>("ENDOCRINOLOGICOS");
            antecedentesPatologicos.GinecoObstetricos = dr.Field<string>("GINECOOBSTETRICOS");
            antecedentesPatologicos.IdAntPat = Convert.ToInt32(dr.Field<Decimal>("IDANTPAT"));
            antecedentesPatologicos.Infecciosos = dr.Field<string>("INFECCIOSOS");
            antecedentesPatologicos.Metabolico = dr.Field<string>("METABOLICO");
            antecedentesPatologicos.Nefrourologicos = dr.Field<string>("NEFROUROLOGICOS");
            antecedentesPatologicos.Otro = dr.Field<string>("OTRO");
            antecedentesPatologicos.Quirurgicos = dr.Field<string>("QUIRURGICOS");
            antecedentesPatologicos.Respiratorios = dr.Field<string>("RESPIRATORIOS");
            antecedentesPatologicos.Reumatologicos = dr.Field<string>("REUMATOLOGICOS");
            antecedentesPatologicos.SNC = dr.Field<string>("SNC");
            antecedentesPatologicos.Traumaticos = dr.Field<string>("TRAUMATICOS");
            antecedentesPatologicos.Traumatologicos = dr.Field<string>("TRAUMATOLOGICOS");
            antecedentesToxicos.Alcoholismo =  dr.Field<string>("ALCOHOLISMO");
            antecedentesToxicos.Frec_Alc = dr.Field<string>("FREC_ALC");
            antecedentesToxicos.Higiene =  dr.Field<string>("HIGIENE");
            antecedentesToxicos.IdAntTox = Convert.ToInt32(dr.Field<Decimal>("IDANTTOX"));
            antecedentesToxicos.Ingesta =  dr.Field<string>("INGESTA");
            antecedentesToxicos.Tabaquismo =  dr.Field<string>("TABAQUISMO");
            antecedentesToxicos.ToxicoManias = dr.Field<string>("TOXICOMANIAS");
            examenesFisicos.Boca = dr.Field<string>("BOCA");
            examenesFisicos.ChoquePunta = dr.Field<string>("CHOQUE_PUNTA");
            examenesFisicos.Colaborador = dr.Field<string>("COLABORADOR");
            examenesFisicos.Convulsiones = dr.Field<string>("CONVULSIONES");
            examenesFisicos.CuelloForma = dr.Field<string>("CUELLO_FORMA");
            examenesFisicos.DisMotora = dr.Field<string>("DIS_MOTORA");
            examenesFisicos.Drenajes = dr.Field<string>("DRENAJES");
            examenesFisicos.ECG = dr.Field<string>("ECG");
            examenesFisicos.Edemas = dr.Field<string>("EDEMAS");
            examenesFisicos.EstGral = dr.Field<string>("EST_GRAL");
            examenesFisicos.Facies = dr.Field<string>("FACIES");
            examenesFisicos.FC = dr.Field<string>("FC");
            examenesFisicos.FR = dr.Field<string>("FR");
            examenesFisicos.Fuerza = dr.Field<string>("FUERZA");
            examenesFisicos.Glasgow = dr.Field<string>("GLASGOW");
            examenesFisicos.Godet = dr.Field<string>("GODET");
            examenesFisicos.IdExaFis = Convert.ToInt32(dr.Field<Decimal>("IDEXAFIS"));
            examenesFisicos.LadoDefLoc = dr.Field<string>("LADO_DEF_LOC");
            examenesFisicos.LadoDisMotora = dr.Field<string>("LADO_DIS_MOTORA");
            examenesFisicos.LadoTemperatura = dr.Field<string>("LADO_TEMPERATURA");
            examenesFisicos.Lenguaje = dr.Field<string>("LENGUAJE");
            examenesFisicos.Lesiones = dr.Field<string>("LESIONES");
            examenesFisicos.Marcha = dr.Field<string>("MARCHA");
            examenesFisicos.Memoria = dr.Field<string>("MEMORIA");
            examenesFisicos.MorfologiaCabeza = dr.Field<string>("MORFOLOGIA_CABEZA");
            examenesFisicos.MurmulloVes = dr.Field<string>("MURMULLO_VES");
            examenesFisicos.Nariz = dr.Field<string>("NARIZ");
            examenesFisicos.NecesidadOX = dr.Field<string>("NECESIDAD_OX");
            examenesFisicos.ObsParesCraneales = dr.Field<string>("OBS_PARES_CRANEALES");
            examenesFisicos.Oidos = dr.Field<string>("OIDOS");
            examenesFisicos.Orientado = dr.Field<string>("ORIENTADO");
            examenesFisicos.OtrasLesiones = dr.Field<string>("OTRAS_LESIONES");
            examenesFisicos.OtrosCV = dr.Field<string>("OTROS_CV");
            examenesFisicos.OtrosRes = dr.Field<string>("OTROS_RES");
            examenesFisicos.ParesCraneales = dr.Field<string>("PARES_CRANEALES");
            examenesFisicos.PielColor = dr.Field<string>("PIEL_COLOR");
            examenesFisicos.PielHidratacion = dr.Field<string>("PIEL_HIDRATACION");
            examenesFisicos.PPR = Convert.ToBoolean(dr.Field<Decimal>("PPR"));
            examenesFisicos.Pulsos = dr.Field<string>("PULSOS");
            examenesFisicos.PUMED = Convert.ToBoolean(dr.Field<Decimal>("PUMED"));
            examenesFisicos.PUSUP = Convert.ToBoolean(dr.Field<Decimal>("PUSUP"));
            examenesFisicos.Reflejos = dr.Field<string>("REFLEJOS");
            examenesFisicos.Renal = dr.Field<string>("RENAL");
            examenesFisicos.RenalDesc = dr.Field<string>("RENAL_DESC");
            examenesFisicos.RigidezNuca = dr.Field<string>("RIGIDEZ_NUCA");
            examenesFisicos.RXTorax = dr.Field<string>("RX_TORAX");
            examenesFisicos.SatOX =dr.Field<string>("SAT_OX");
            examenesFisicos.Sensibilidad = dr.Field<string>("SENSIBILIDAD");
            examenesFisicos.Silencios = dr.Field<string>("SILENCIOS");   
            examenesFisicos.SintomasCV = dr.Field<string>("SINTOMAS_CV");
            examenesFisicos.SintomasRes = dr.Field<string>("SINTOMAS_RES");
            examenesFisicos.TCS = dr.Field<string>("TCS");
            examenesFisicos.Temperatura = dr.Field<string>("TEMPERATURA");
            examenesFisicos.TemperaturaMot = dr.Field<string>("TEMPERATURA_MOT");
            examenesFisicos.TipoDisMotora = dr.Field<string>("TIPO_DIS_MOTORA");
            examenesFisicos.Tono = dr.Field<string>("TONO");
            examenesFisicos.Topografia = dr.Field<string>("TOPOGRAFIA");
            examenesFisicos.Trofismo = dr.Field<string>("TROFISMO");
            examenesFisicos.Piramidalismo = Convert.ToBoolean(dr.Field<Decimal>("PIRAMIDALISMO"));
            examenesFisicos.Extrapiramidalismo = Convert.ToBoolean(dr.Field<Decimal>("EXTRAPIRAMIDALISMO"));
            examenesFisicos.MovimientosAnormales = Convert.ToBoolean(dr.Field<Decimal>("MOVIMIENTOSANORMALES"));
            examenesFisicos.LadoParesCraneales = dr.Field<string>("LADO_PARES_CRANEALES");
            examenesFisicos.HundimientosProminencias = dr.Field<string>("HUNDIMIENTOSPROMINENCIAS");
            examenesFisicos.ParpadosNormales = Convert.ToBoolean(dr.Field<Decimal>("PARPADOSNORMALES"));
            examenesFisicos.OjosSimetricos = Convert.ToBoolean(dr.Field<Decimal>("OJOSSIMETRICOS"));
            examenesFisicos.ReflejoFotomotor = Convert.ToBoolean(dr.Field<Decimal>("REFLEJOFOTOMOTOR"));
            examenesFisicos.Consensual = Convert.ToBoolean(dr.Field<Decimal>("CONSENSUAL"));
            examenesFisicos.Flexion = Convert.ToBoolean(dr.Field<Decimal>("FLEXION"));
            examenesFisicos.Rotacion = Convert.ToBoolean(dr.Field<Decimal>("ROTACION"));
            examenesFisicos.Extension = Convert.ToBoolean(dr.Field<Decimal>("EXTENSION"));
            examenesFisicos.Adenomegalias = Convert.ToBoolean(dr.Field<Decimal>("ADENOMEGALIAS"));
            examenesFisicos.CrecimientoTiroides = Convert.ToBoolean(dr.Field<Decimal>("CRECIMIENTOTIROIDES"));
            examenesFisicos.PulsosCarotideos = Convert.ToBoolean(dr.Field<Decimal>("PULSOSCAROTIDEOS"));
            examenesFisicos.Soplos = Convert.ToBoolean(dr.Field<Decimal>("SOPLOS"));
            examenesFisicos.Sistolica = dr.Field<string>("SISTOLICA");
            examenesFisicos.Diastolica = dr.Field<string>("DIASTOLICA");
            examenesFisicos.R1 = Convert.ToBoolean(dr.Field<Decimal>("R1"));
            examenesFisicos.R2 = Convert.ToBoolean(dr.Field<Decimal>("R2"));
            examenesFisicos.R3 = Convert.ToBoolean(dr.Field<Decimal>("R3"));
            examenesFisicos.R4 = Convert.ToBoolean(dr.Field<Decimal>("R4"));
            examenesFisicos.EIC = Convert.ToBoolean(dr.Field<Decimal>("EIC"));
            examenesFisicos.IY = Convert.ToBoolean(dr.Field<Decimal>("IY"));
            examenesFisicos.ColapsoInsp = Convert.ToBoolean(dr.Field<Decimal>("COLAPSO_INSP"));
            examenesFisicos.RHY = Convert.ToBoolean(dr.Field<Decimal>("RHY"));
            examenesFisicos.Sonoro = Convert.ToBoolean(dr.Field<Decimal>("SONORO"));
            examenesFisicos.Mate = Convert.ToBoolean(dr.Field<Decimal>("MATE"));
            examenesFisicos.Submate = Convert.ToBoolean(dr.Field<Decimal>("SUBMATE"));
            examenesFisicos.Timpanico = Convert.ToBoolean(dr.Field<Decimal>("TIMPANICO"));
            examenesFisicos.Hipersonoro = Convert.ToBoolean(dr.Field<Decimal>("HIPERSONORO"));
            examenesFisicos.Crepitantes = Convert.ToBoolean(dr.Field<Decimal>("CREPITANTES"));
            examenesFisicos.Subcrepitantes = Convert.ToBoolean(dr.Field<Decimal>("SUBCREPITANTES"));
            examenesFisicos.Roncus = Convert.ToBoolean(dr.Field<Decimal>("RONCUS"));
            examenesFisicos.Sibilancias = Convert.ToBoolean(dr.Field<Decimal>("SIBILANCIAS"));
            examenesFisicos.SoplosRes = Convert.ToBoolean(dr.Field<Decimal>("SOPLOS_RES"));
            examenesFisicos.Pectoriloquia = Convert.ToBoolean(dr.Field<Decimal>("PECTORILOQUIA"));
            examenesFisicos.Broncofonia = Convert.ToBoolean(dr.Field<Decimal>("BRONCOFONIA"));
            examenesFisicos.Frote = Convert.ToBoolean(dr.Field<Decimal>("FROTE"));
            examenesFisicos.TosInsuficiente = Convert.ToBoolean(dr.Field<Decimal>("TOSINSUFICIENTE"));
            examenesFisicos.Secreciones = Convert.ToBoolean(dr.Field<Decimal>("SECRECIONES"));
            examenesFisicos.Blando = Convert.ToBoolean(dr.Field<Decimal>("BLANDO"));
            examenesFisicos.Depresible = Convert.ToBoolean(dr.Field<Decimal>("DEPRESIBLE"));
            examenesFisicos.Indoloro = Convert.ToBoolean(dr.Field<Decimal>("INDOLORO"));
            examenesFisicos.Catarsis = Convert.ToBoolean(dr.Field<Decimal>("CATARSIS"));
            examenesFisicos.RHA = dr.Field<string>("RHA");
            examenesFisicos.Espontaneo = Convert.ToBoolean(dr.Field<Decimal>("ESPONTANEO"));
            examenesFisicos.Palpitacion = Convert.ToBoolean(dr.Field<Decimal>("PALPITACION"));
            examenesFisicos.Defensa = Convert.ToBoolean(dr.Field<Decimal>("DEFENSA"));
            examenesFisicos.Peritonismo = Convert.ToBoolean(dr.Field<Decimal>("PERITONISMO"));
            examenesFisicos.Vomitos = Convert.ToBoolean(dr.Field<Decimal>("VOMITOS"));
            examenesFisicos.Diarrea = Convert.ToBoolean(dr.Field<Decimal>("DIARREA"));
            examenesFisicos.Constipacion = Convert.ToBoolean(dr.Field<Decimal>("CONSTIPACION"));
            examenesFisicos.Adenomegalias_abd = Convert.ToBoolean(dr.Field<Decimal>("ADENOMEGALIAS_ABD"));
            examenesFisicos.Hepatomegalia = Convert.ToBoolean(dr.Field<Decimal>("HEPATOMEGALIA"));
            examenesFisicos.Esplenomegalia = Convert.ToBoolean(dr.Field<Decimal>("ESPLENOMEGALIA"));
            examenesFisicos.Masas = Convert.ToBoolean(dr.Field<Decimal>("MASAS"));
            examenesFisicos.Distension = Convert.ToBoolean(dr.Field<Decimal>("DISTENSION"));
            examenesFisicos.Ascitis = Convert.ToBoolean(dr.Field<Decimal>("ASCITIS"));
            examenesFisicos.Disuria = Convert.ToBoolean(dr.Field<Decimal>("DISURIA"));
            examenesFisicos.Polaquiuria = Convert.ToBoolean(dr.Field<Decimal>("POLAQUIURIA"));
            examenesFisicos.Tenesmo = Convert.ToBoolean(dr.Field<Decimal>("TENESMO"));
            examenesFisicos.Hematuria = Convert.ToBoolean(dr.Field<Decimal>("HEMATURIA"));
            examenesFisicos.PusupLado = dr.Field<string>("PUSUP_LADO");
            examenesFisicos.PumedLado = dr.Field<string>("PUMED_LADO");
            examenesFisicos.PPRLado = dr.Field<string>("PPR_LADO");
            examenesFisicos.Espontanea = Convert.ToBoolean(dr.Field<Decimal>("ESPONTANEA"));
            examenesFisicos.Sondaje = Convert.ToBoolean(dr.Field<Decimal>("SONDAJE"));
            examenesFisicos.Articulares = Convert.ToBoolean(dr.Field<Decimal>("ARTICULARES"));
            examenesFisicos.Oseas = Convert.ToBoolean(dr.Field<Decimal>("OSEAS"));
            examenesFisicos.LadoDeformidad= dr.Field<string>("LADO_DEFORMIDAD");
            examenesFisicos.Esclerosis = Convert.ToBoolean(dr.Field<Decimal>("ESCLEROSIS"));
            examenesFisicos.Cifosis = Convert.ToBoolean(dr.Field<Decimal>("CIFOSIS"));
            examenesFisicos.Lordosis = Convert.ToBoolean(dr.Field<Decimal>("LORDOSIS"));
            examenesComplementarios.Ecografia =  dr.Field<string>("ECOGRAFIA");
            examenesComplementarios.EcografiaDesc = dr.Field<string>("ECOGRAFIA_DESC");
            examenesComplementarios.IdExaCom = Convert.ToInt32(dr.Field<Decimal>("IDEXACOM"));
            examenesComplementarios.Laboratorio =  dr.Field<string>("LABORATORIO");
            examenesComplementarios.LaboratorioDesc = dr.Field<string>("LABORATORIO_DESC");
            examenesComplementarios.Otros =  dr.Field<string>("OTROS");
            examenesComplementarios.OtrosDesc = dr.Field<string>("OTROS_DESC");
            examenesComplementarios.Tomografias =  dr.Field<string>("TOMOGRAFIAS");
            examenesComplementarios.TomografiasDesc = dr.Field<string>("TOMOGRAFIAS_DESC");
            diagnostico.Analgesia = dr.Field<string>("ANALGESIA");
            diagnostico.AntecedentesEnfAct = dr.Field<string>("ANTECEDENTES_ENF_ACT");
            diagnostico.ComentarioIngreso = dr.Field<string>("COMENTARIOINGRESO");
            diagnostico.Diagnosticos = dr.Field<string>("DIAGNOSTICOS");
            diagnostico.EnfermedadActual = dr.Field<string>("ENFERMEDAD_ACTUAL");
            diagnostico.IdDiagnostico = Convert.ToInt32(dr.Field<Decimal>("IDDIAGNOSTICO"));
            diagnostico.Indicaciones = dr.Field<string>("INDICACIONES");
            diagnostico.OtrasInd = dr.Field<string>("OTRAS_IND");

            histInt.AntecedentesPatologicos = antecedentesPatologicos;
            histInt.AntecedentesToxicos = antecedentesToxicos;
            histInt.Diagnostico = diagnostico;
            histInt.ExamenesComplementarios = examenesComplementarios;
            histInt.ExamenesFisicos = examenesFisicos;
            histInt.Interrogatorio = interrogatorio;
            histInt.MotivoIngreso = motivoIngreso;

            return histInt;
        }


        public HistoriaClinicaInternacionModel obtenerHistoriaClinica(int IdPaciente) {
            
            DataTable dt;
            HistoriaClinicaInternacionModel obj = null;

            dt = DataHelper.ExecuteQuery("S_HIS_INT", IdPaciente);

            if (dt.Rows.Count > 0)
            {
                obj = newHistoriaInternacion(dt.Rows[0]);
            }
            return obj;
        }

        public int insertarHistoriaClinica (HistoriaClinicaInternacionModel historia)
        {

            int id1 = DataHelper.ExecuteNonQuery("IU_MOT_ING",
            //Motivo de ingreso

            historia.MotivoIngreso.IdMotIng,
            historia.MotivoIngreso.MotivoIng
            );

            int id2 = DataHelper.ExecuteNonQuery("IU_INT_APA_SIS",
            //Interrogatorio
            historia.Interrogatorio.IdIntApaSis,
            historia.Interrogatorio.SNG,
            historia.Interrogatorio.SNG_desc,
            historia.Interrogatorio.AR,
            historia.Interrogatorio.AR_desc,
            historia.Interrogatorio.AC,
            historia.Interrogatorio.AC_desc,
            historia.Interrogatorio.AD,
            historia.Interrogatorio.AD_desc,
            historia.Interrogatorio.AGU,
            historia.Interrogatorio.AGU_desc,
            historia.Interrogatorio.SME,
            historia.Interrogatorio.SME_desc,
            historia.Interrogatorio.SE,
            historia.Interrogatorio.SE_desc,
            historia.Interrogatorio.ORG_sentidos,
            historia.Interrogatorio.OS_desc,
            historia.Interrogatorio.ST,
            historia.Interrogatorio.ST_desc);

            int id3 = DataHelper.ExecuteNonQuery("IU_ANT_PAT",
            //antecedentes Patologicos
            historia.AntecedentesPatologicos.IdAntPat,
            historia.AntecedentesPatologicos.SNC,
            historia.AntecedentesPatologicos.Respiratorios,
            historia.AntecedentesPatologicos.Cardiovascular,
            historia.AntecedentesPatologicos.Digestivo,
            historia.AntecedentesPatologicos.Nefrourologicos,
            historia.AntecedentesPatologicos.Infecciosos,
            historia.AntecedentesPatologicos.Endocrinologicos,
            historia.AntecedentesPatologicos.Metabolico,
            historia.AntecedentesPatologicos.Alergias,
            historia.AntecedentesPatologicos.Traumaticos,
            historia.AntecedentesPatologicos.GinecoObstetricos,
            historia.AntecedentesPatologicos.Quirurgicos,
            historia.AntecedentesPatologicos.Reumatologicos,
            historia.AntecedentesPatologicos.Traumatologicos,
            historia.AntecedentesPatologicos.Otro);


            int id4 = DataHelper.ExecuteNonQuery("IU_ANT_TOX",
            //antecedentes Toxicos
            historia.AntecedentesToxicos.IdAntTox,
            historia.AntecedentesToxicos.Ingesta,
            historia.AntecedentesToxicos.ToxicoManias,
            historia.AntecedentesToxicos.Higiene,
            historia.AntecedentesToxicos.Tabaquismo,
            historia.AntecedentesToxicos.Alcoholismo,
            historia.AntecedentesToxicos.Frec_Alc);

            int id5 = DataHelper.ExecuteNonQuery("IU_EXA_FIS",
            //examenes fisicos
            historia.ExamenesFisicos.IdExaFis,
            historia.ExamenesFisicos.EstGral,
            historia.ExamenesFisicos.TCS,
            historia.ExamenesFisicos.PielColor,
            historia.ExamenesFisicos.PielHidratacion,
            historia.ExamenesFisicos.Temperatura,
            historia.ExamenesFisicos.Edemas,
            historia.ExamenesFisicos.Lesiones,
            historia.ExamenesFisicos.Godet,
            historia.ExamenesFisicos.Glasgow,
            historia.ExamenesFisicos.Orientado,
            historia.ExamenesFisicos.Colaborador,
            historia.ExamenesFisicos.Marcha,
            historia.ExamenesFisicos.Lenguaje,
            historia.ExamenesFisicos.Memoria,
            historia.ExamenesFisicos.Fuerza,
            historia.ExamenesFisicos.Reflejos,
            historia.ExamenesFisicos.Tono,
            historia.ExamenesFisicos.DisMotora,
            historia.ExamenesFisicos.TipoDisMotora,
            historia.ExamenesFisicos.LadoDisMotora,
            historia.ExamenesFisicos.ParesCraneales,
            historia.ExamenesFisicos.ObsParesCraneales,
            historia.ExamenesFisicos.Sensibilidad,
            historia.ExamenesFisicos.RigidezNuca,
            historia.ExamenesFisicos.Convulsiones,
            historia.ExamenesFisicos.MorfologiaCabeza,
            historia.ExamenesFisicos.Facies,
            historia.ExamenesFisicos.Boca,
            historia.ExamenesFisicos.Nariz,
            historia.ExamenesFisicos.Oidos,
            historia.ExamenesFisicos.CuelloForma,
            historia.ExamenesFisicos.SintomasCV,
            historia.ExamenesFisicos.ChoquePunta,
            historia.ExamenesFisicos.FC,
            historia.ExamenesFisicos.Pulsos,
            historia.ExamenesFisicos.Silencios,
            historia.ExamenesFisicos.OtrosCV,
            historia.ExamenesFisicos.ECG,
            historia.ExamenesFisicos.SintomasRes,
            historia.ExamenesFisicos.SatOX,
            historia.ExamenesFisicos.FR,
            historia.ExamenesFisicos.NecesidadOX,
            historia.ExamenesFisicos.MurmulloVes,
            historia.ExamenesFisicos.RXTorax,
            historia.ExamenesFisicos.OtrosRes,
            historia.ExamenesFisicos.Topografia,
            historia.ExamenesFisicos.Renal,
            historia.ExamenesFisicos.RenalDesc,
            Convert.ToInt32(historia.ExamenesFisicos.PUSUP),
            Convert.ToInt32(historia.ExamenesFisicos.PUMED),
            Convert.ToInt32(historia.ExamenesFisicos.PPR),
            historia.ExamenesFisicos.LadoDefLoc,
            historia.ExamenesFisicos.TemperaturaMot,
            historia.ExamenesFisicos.LadoTemperatura,
            historia.ExamenesFisicos.Trofismo,
            historia.ExamenesFisicos.Drenajes,
            historia.ExamenesFisicos.OtrasLesiones,
            Convert.ToInt32(historia.ExamenesFisicos.Piramidalismo),
            Convert.ToInt32(historia.ExamenesFisicos.Extrapiramidalismo),
            Convert.ToInt32(historia.ExamenesFisicos.MovimientosAnormales),
            historia.ExamenesFisicos.LadoParesCraneales,
            historia.ExamenesFisicos.HundimientosProminencias,
            Convert.ToInt32(historia.ExamenesFisicos.ParpadosNormales),
            Convert.ToInt32(historia.ExamenesFisicos.OjosSimetricos),
            Convert.ToInt32(historia.ExamenesFisicos.ReflejoFotomotor),
            Convert.ToInt32(historia.ExamenesFisicos.Consensual),
            Convert.ToInt32(historia.ExamenesFisicos.Flexion),
            Convert.ToInt32(historia.ExamenesFisicos.Rotacion),
            Convert.ToInt32(historia.ExamenesFisicos.Extension),
            Convert.ToInt32(historia.ExamenesFisicos.Adenomegalias),
            Convert.ToInt32(historia.ExamenesFisicos.CrecimientoTiroides),
            Convert.ToInt32(historia.ExamenesFisicos.PulsosCarotideos),
            Convert.ToInt32(historia.ExamenesFisicos.Soplos),
            historia.ExamenesFisicos.Sistolica,
            historia.ExamenesFisicos.Diastolica,
            Convert.ToInt32(historia.ExamenesFisicos.R1),
            Convert.ToInt32(historia.ExamenesFisicos.R2),
            Convert.ToInt32(historia.ExamenesFisicos.R3),
            Convert.ToInt32(historia.ExamenesFisicos.R4),
            Convert.ToInt32(historia.ExamenesFisicos.EIC),
            Convert.ToInt32(historia.ExamenesFisicos.IY),
            Convert.ToInt32(historia.ExamenesFisicos.ColapsoInsp),
            Convert.ToInt32(historia.ExamenesFisicos.RHY),
            Convert.ToInt32(historia.ExamenesFisicos.Sonoro),
            Convert.ToInt32(historia.ExamenesFisicos.Mate),
            Convert.ToInt32(historia.ExamenesFisicos.Submate),
            Convert.ToInt32(historia.ExamenesFisicos.Timpanico),
            Convert.ToInt32(historia.ExamenesFisicos.Hipersonoro),
            Convert.ToInt32(historia.ExamenesFisicos.Crepitantes),
            Convert.ToInt32(historia.ExamenesFisicos.Subcrepitantes),
            Convert.ToInt32(historia.ExamenesFisicos.Roncus),
            Convert.ToInt32(historia.ExamenesFisicos.Sibilancias),
            Convert.ToInt32(historia.ExamenesFisicos.SoplosRes),
            Convert.ToInt32(historia.ExamenesFisicos.Pectoriloquia),
            Convert.ToInt32(historia.ExamenesFisicos.Broncofonia),
            Convert.ToInt32(historia.ExamenesFisicos.Frote),
            Convert.ToInt32(historia.ExamenesFisicos.TosInsuficiente),
            Convert.ToInt32(historia.ExamenesFisicos.Secreciones),
            Convert.ToInt32(historia.ExamenesFisicos.Blando),
            Convert.ToInt32(historia.ExamenesFisicos.Depresible),
            Convert.ToInt32(historia.ExamenesFisicos.Indoloro),
            Convert.ToInt32(historia.ExamenesFisicos.Catarsis),
            historia.ExamenesFisicos.RHA,
            Convert.ToInt32(historia.ExamenesFisicos.Espontaneo),
            Convert.ToInt32(historia.ExamenesFisicos.Palpitacion),
            Convert.ToInt32(historia.ExamenesFisicos.Defensa),
            Convert.ToInt32(historia.ExamenesFisicos.Peritonismo),
            Convert.ToInt32(historia.ExamenesFisicos.Vomitos),
            Convert.ToInt32(historia.ExamenesFisicos.Diarrea),
            Convert.ToInt32(historia.ExamenesFisicos.Constipacion),
            Convert.ToInt32(historia.ExamenesFisicos.Adenomegalias_abd),
            Convert.ToInt32(historia.ExamenesFisicos.Hepatomegalia),
            Convert.ToInt32(historia.ExamenesFisicos.Esplenomegalia),
            Convert.ToInt32(historia.ExamenesFisicos.Masas),
            Convert.ToInt32(historia.ExamenesFisicos.Distension),
            Convert.ToInt32(historia.ExamenesFisicos.Ascitis),
            Convert.ToInt32(historia.ExamenesFisicos.Disuria),
            Convert.ToInt32(historia.ExamenesFisicos.Polaquiuria),
            Convert.ToInt32(historia.ExamenesFisicos.Tenesmo),
            Convert.ToInt32(historia.ExamenesFisicos.Hematuria),
            historia.ExamenesFisicos.PusupLado,
            historia.ExamenesFisicos.PumedLado,
            historia.ExamenesFisicos.PPRLado,
            Convert.ToInt32(historia.ExamenesFisicos.Espontanea),
            Convert.ToInt32(historia.ExamenesFisicos.Sondaje),
            Convert.ToInt32(historia.ExamenesFisicos.Articulares),
            Convert.ToInt32(historia.ExamenesFisicos.Oseas),
            historia.ExamenesFisicos.LadoDeformidad,
            Convert.ToInt32(historia.ExamenesFisicos.Esclerosis),
            Convert.ToInt32(historia.ExamenesFisicos.Cifosis),
            Convert.ToInt32(historia.ExamenesFisicos.Lordosis)
            );



            int id6 = DataHelper.ExecuteNonQuery("IU_EXA_COM",
            //examenes complementarios
            historia.ExamenesComplementarios.IdExaCom,
            historia.ExamenesComplementarios.Laboratorio,
            historia.ExamenesComplementarios.LaboratorioDesc,
            historia.ExamenesComplementarios.Ecografia,
            historia.ExamenesComplementarios.EcografiaDesc,
            historia.ExamenesComplementarios.Tomografias,
            historia.ExamenesComplementarios.TomografiasDesc,
            historia.ExamenesComplementarios.Otros,
            historia.ExamenesComplementarios.OtrosDesc);


            int id7 = DataHelper.ExecuteNonQuery("IU_DIAGNOSTICO",
            //diagnostico
            historia.Diagnostico.IdDiagnostico,
            historia.Diagnostico.EnfermedadActual,
            historia.Diagnostico.AntecedentesEnfAct,
            historia.Diagnostico.Diagnosticos,
            historia.Diagnostico.Indicaciones,
            historia.Diagnostico.Analgesia,
            historia.Diagnostico.OtrasInd,
            historia.Diagnostico.ComentarioIngreso);

            int idHis;

            if (historia.IdHisInt != 0)
            {
                idHis = historia.IdHisInt;
            }
            else
            {
                idHis = DataHelper.ExecuteNonQuery("I_HIS_INT", historia.IdPaciente, id1, id2, id3, id4, id5, id6, id7);
            }
            return idHis;
        }
    }
}