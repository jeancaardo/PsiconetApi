using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Psiconet.Models;

namespace Psiconet.Controllers
{
    public class PersonaController : Controller
    {   
        private PersonaModel newPersona(DataRow dr)
        {
            PersonaModel obj = new PersonaModel();

            obj.IdPersona = Convert.ToInt32(dr.Field<Decimal>("IDPERSONA"));

            obj.Dni = dr.Field<int>("DNI");

            obj.Fecha_nac = dr.Field<DateTime>("FECHA_NAC");

            obj.Tipo_Doc = dr.Field<string>("TIPO_DOC");

            obj.Nacionalidad = dr.Field<string>("NACIONALIDAD");

            obj.Datos_personales = newDatos(dr);

            return obj;
        }

        private DatosPersonaModel newDatos(DataRow dr)
        {
            DatosPersonaModel obj = new DatosPersonaModel();

            obj.Apellido = dr.Field<string>("APELLIDO");

            obj.Nombre = dr.Field<string>("NOMBRE");

            obj.IdDatos = Convert.ToInt32(dr.Field<Decimal>("IDDATOS"));

            obj.EstadoCivil = dr.Field<string>("ESTADOCIVIL");

            obj.Genero = dr.Field<string>("GENERO");

            obj.Idioma = dr.Field<string>("IDIOMA");

            obj.Localidad = dr.Field<string>("LOCALIDAD");

            obj.Ocupacion = dr.Field<string>("OCUPACION");

            obj.Telefono = dr.Field<string>("TELEFONO");

            obj.IdPersona = Convert.ToInt32(dr.Field<Decimal>("IDPERSONA"));

            obj.CodigoPostal = dr.Field<string>("CODIGO_POSTAL");

            obj.email = dr.Field<string>("EMAIL");

            obj.Domicilio = dr.Field<string>("DOMICILIO");

            return obj;
        }



        public int CrearActualizarPersona(int accion, PersonaModel persona)
        {

            int res = DataHelper.ExecuteNonQuery("IU_PERSONA", persona.IdPersona, persona.Dni, persona.Tipo_Doc, persona.Nacionalidad, persona.Fecha_nac);

            return res;
        }

        public int CrearActualizarDatosPersona(int accion, DatosPersonaModel datos)
        {

            int res = DataHelper.ExecuteNonQuery("IU_DATOSPERSONA", datos.IdDatos, datos.IdPersona, datos.Nombre, datos.Apellido,
                datos.Genero, datos.Telefono, datos.Domicilio, datos.EstadoCivil, datos.Ocupacion, datos.Localidad, datos.CodigoPostal,
                datos.Idioma, datos.email);

            return res;
        }

        public PersonaModel ObtenerPersona(int idpersona)
        {
            DataTable dt;
            PersonaModel obj = null;

            dt = DataHelper.ExecuteQuery("S_PERSONA", idpersona);
            if (dt.Rows.Count > 0)
            {
                obj = newPersona(dt.Rows[0]);
            }
            return obj;
        }
        public PersonaModel[] ObtenerAllPersonas()
        {
            

            DataTable dt;

            dt = DataHelper.ExecuteQuery("S_PERSONA", 0);

            int i = 0;

            PersonaModel[] p = null;

            foreach (DataRow dr in dt.Rows)
            {
                if (i != 0)
                {
                    PersonaModel[] aux = p;
                    p = new PersonaModel[i + 1];
                    p = aux;
                    
                }
                else
                {
                    p = new PersonaModel[i + 1];
                }
                p[i] = newPersona(dr);
                i = i + 1;
            }
            return p;
        }


        public PersonaModel ObtenerPersonaDatos(int idpersona)
        {
            DataTable dt;
            PersonaModel obj = null;

            dt = DataHelper.ExecuteQuery("S_PERSONA_DATOSPERSONA", idpersona);
            if (dt.Rows.Count > 0)
            {
                obj = newPersona(dt.Rows[0]);
            }
            return obj;
        }

        

        
    }
}