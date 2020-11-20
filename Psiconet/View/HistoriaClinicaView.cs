using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Psiconet.Controllers;
using Psiconet.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Psiconet.View
{
    [Route("api/historiaclinica")]
    public class HistoriaClinicaView : Controller
    {
        // GET: api/<controller>
        [HttpGet("getHistoriaInternacion")]
        public HistoriaClinicaInternacionModel getHistoriaClinica(int idpaciente)
        {
            HistoriaClinicaInternacionController oHis = new HistoriaClinicaInternacionController();
            HistoriaClinicaInternacionModel oHisInt = new HistoriaClinicaInternacionModel();
            oHisInt = oHis.obtenerHistoriaClinica(idpaciente);

            return oHisInt;
        }

        [HttpPut("putHistoriaInternacion")]
        public int putHistoriaClinica([FromBody] HistoriaClinicaInternacionModel historia)
        {
            HistoriaClinicaInternacionController oHis = new HistoriaClinicaInternacionController();
            HistoriaClinicaInternacionModel oHisInt = new HistoriaClinicaInternacionModel();
            int res = oHis.insertarHistoriaClinica(historia);

            return res;
        }

        [HttpGet("getHistoriaPsiquiatrica")]
        public HistoriaClinicaPsiquiatricaModel getHistoriaClinicaPsiquiatrica(int idpaciente)
        {
            HistoriaClinicaPsiquiatricaController oHis = new HistoriaClinicaPsiquiatricaController();
            return oHis.obtenerHistoriaPsiquiatrica(idpaciente);
        }

        [HttpPut("putHistoriaPsiquiatrica")]
        public int putHistoriaClinicaPsiquiatrica([FromBody] HistoriaClinicaPsiquiatricaModel historia)
        {
            HistoriaClinicaPsiquiatricaController oHis = new HistoriaClinicaPsiquiatricaController();
            return oHis.insertarHistoriaClinicaPsiquiatrica(historia);

            
        }
    }
}
