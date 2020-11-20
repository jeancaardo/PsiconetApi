using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Psiconet.Controllers;
using Psiconet.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Psiconet.View
{
    [EnableCors]
    [Route("api/iniciarsesion")]
    public class IniciarSesionView : Controller
    {
        // POST: api/<controller>/
        [HttpPut("LogearUsuario")]
        public UsuarioModel LogearUsuario([FromBody] InicioSesionModel usu)
        {

            InicioSesionController obj = new InicioSesionController();


            UsuarioModel res = obj.IniciarSesion(usu);

            return res;
        }

        
    }
}
