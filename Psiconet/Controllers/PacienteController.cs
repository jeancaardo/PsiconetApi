using Psiconet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Psiconet.Controllers
{
    public class PacienteController
    {
        private PacienteModel newPaciente(DataRow dr)
        {
            PacienteModel obj = new PacienteModel();
            
            obj.idPaciente = Convert.ToInt32(dr.Field<Decimal>("IDPACIENTE"));
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

        public int insertarPaciente(PacienteModel paciente)
        {
            int res = DataHelper.ExecuteNonQuery("I_PACIENTE", paciente.idPaciente, paciente.IdPersona);

            return res;
        }

        public PacienteModel[] BuscarPacienteDatos(string cadena)
        {

            string[] strlist = cadena.Split(" ");
            string cadena1, cadena2, cadena3;

            if (strlist.Length == 3)
            {
                cadena1 = strlist[0];

                cadena2 = strlist[1];

                cadena3 = strlist[2];
            }
            else if (strlist.Length == 2)
            {
                cadena1 = strlist[0];

                cadena2 = strlist[1];

                cadena3 = "";
            }
            else if (strlist.Length == 1)
            {
                cadena1 = strlist[0];

                cadena2 = "";

                cadena3 = "";
            }
            else
            {
                cadena1 = "";

                cadena2 = "";

                cadena3 = "";

            }
            DataTable dt;
            dt = DataHelper.ExecuteQuery("S_BUSQUEDA_PACIENTE", cadena1, cadena2, cadena3);

            int i = 0;

            PacienteModel[] p = null;

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (i != 0)
                    {
                        PacienteModel[] aux = p;
                        p = new PacienteModel[i + 1];
                        p = aux;

                    }
                    else
                    {
                        p = new PacienteModel[i + 1];
                    }
                    p[i] = newPaciente(dr);
                    i = i + 1;
                }
            }
            return p;
        }
    }
}
