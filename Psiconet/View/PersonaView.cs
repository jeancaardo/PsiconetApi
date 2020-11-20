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
    [Route("api/persona")]
    public class PersonaView : Controller
    {
        // POST: api/<controller>/5
        [HttpPut("PutPersona")]
        public int PutPersona([FromBody] PersonaModel persona, int accion)
        {
            PersonaController obj = new PersonaController();

            int res = obj.CrearActualizarPersona(accion, persona);

            return res;
        }

        [HttpGet("GetPersona")]
        public PersonaModel GetPersona(int idpersona)
        {
            PersonaModel res = null;
            PersonaController obj = new PersonaController();
            if (idpersona != 0) {
                res = obj.ObtenerPersona(idpersona);
            }
            return res;
        }

        [HttpGet("GetAllPersona")]
        public PersonaModel[] GetAllPersona()
        {
            PersonaController obj = new PersonaController();

            var persona = obj.ObtenerAllPersonas();

            return persona;
        }

        [HttpPut("PutDatosPersona")]
        public int PutDatosPersona([FromBody] DatosPersonaModel datos, int accion)
        {
            PersonaController obj = new PersonaController();

            int res = obj.CrearActualizarDatosPersona(accion, datos);

            return res;
        }

        [HttpGet("GetPersonaDatos")]
        public PersonaModel GetPersonaDatos(int idpersona)
        {
            PersonaModel res = null;
            PersonaController obj = new PersonaController();
            if (idpersona != 0)
            {
                res = obj.ObtenerPersonaDatos(idpersona);
            }
            return res;
        }
    }
}
