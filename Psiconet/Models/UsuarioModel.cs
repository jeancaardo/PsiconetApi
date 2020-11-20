using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Models
{
    public class UsuarioModel
    {
        public int idPersona { get; set; }

        public int idUsuario { get; set; }

        public string usuario { get; set; }

        public string password { get; set; }
    }
}
