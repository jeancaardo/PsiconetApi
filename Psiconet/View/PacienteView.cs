using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Psiconet.Controllers;
using Psiconet.Models;

namespace Psiconet.View
{
    [EnableCors]
    [Route("api/paciente")]
    public class PacienteView : Controller
    {
        [HttpPut("PutPaciente")]
        public int PutPersona([FromBody] PacienteModel paciente)
        {
            PacienteController obj = new PacienteController();

            int res = obj.insertarPaciente(paciente);

            return res;
        }

        [HttpGet("GetBusquedaPaciente")]
        public PacienteModel[] GetPersona(string cadena)
        {
            PacienteModel[] res = null;
            PacienteController obj = new PacienteController();

            res = obj.BuscarPacienteDatos(cadena);
 
            return res;
        }
    }
}