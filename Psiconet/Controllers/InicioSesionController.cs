using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Psiconet.Models;
using System.Data.OracleClient;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Psiconet.Controllers
{
    public class InicioSesionController : Controller
    {
        private UsuarioModel CrearUsuarios (DataRow dr)
        {
            UsuarioModel usuario = new UsuarioModel();

            int idUsuario = dr.Field<int>("IDUSUARIO");

            int idPersona = dr.Field<int>("IDPERSONA");

            string nombre = dr.Field<String>("nomUsuario");

            string contrasenia = dr.Field<String>("contrasenia");

            usuario.idPersona = idPersona;
            usuario.idUsuario = idUsuario;
            usuario.usuario = nombre; 
            usuario.password = contrasenia;

            return usuario;
        }
        public UsuarioModel IniciarSesion (InicioSesionModel usuario)
        {
            UsuarioModel usuarioInexistente = null;
            try
            {
                DataTable dt;

                dt = DataHelper.ExecuteQuery("S_Usuario", usuario.usuario);

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    var usuExistente = CrearUsuarios(dr);

                    if ((usuExistente.usuario == usuario.usuario) && (usuExistente.password == usuario.password))
                    {
                        return usuExistente;
                    }
                }
                return usuarioInexistente;
            }
            catch {
                return usuarioInexistente;
            };

        }
    }
}