using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Principal;
using Oracle.ManagedDataAccess.Types;

namespace Psiconet
{
    public class DataHelper
    {
       

        

        public static DataTable ExecuteQuery(String query, params object[]? parametros)
        {
            
            

            OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=25demayo;");
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (object par in parametros)
            {
                OracleParameter ora = new OracleParameter();
                cmd.Parameters.Add(ora = Converter(par));
            }
            cmd.Parameters.Add("inRefPrm", OracleDbType.RefCursor, ParameterDirection.Output);

            var datareader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(datareader);

            cmd.Dispose();
            con.Close();

            

            return dt;
        }

        public static int ExecuteNonQuery(String query, params object[] parametros)
        {



            OracleConnection con = new OracleConnection("Data Source=localhost;User ID=SYSTEM;Password=25demayo;");
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (object par in parametros)
            {
                OracleParameter ora = new OracleParameter();
                cmd.Parameters.Add(ora = Converter(par));
            }
            cmd.Parameters.Add("res", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteScalar();

            int res = Convert.ToInt32(cmd.Parameters["res"].Value.ToString());

            cmd.Dispose();
            con.Close();

            

            return res;
        }

        public static OracleParameter Converter(Object ob)
        {
            
            String aux = ob.GetType().ToString();
            OracleParameter res = new OracleParameter();
            if (aux == "System.String")
            {
                

                res.OracleDbType = OracleDbType.NVarchar2;
                res.Value = ob;
            }else if (aux == "System.Boolean")
            {


                res.OracleDbType = OracleDbType.Boolean;
                res.Value = ob;
            }else if (aux == "System.Int32")
            {


                res.OracleDbType = OracleDbType.Int32;
                res.Value = ob;
            }else if (aux == "System.Short")
            {


                res.OracleDbType = OracleDbType.Int16;
                res.Value = ob;
            }else if (aux == "System.Long")
            {


                res.OracleDbType = OracleDbType.Int64;
                res.Value = ob;
            }else if (aux == "System.Float")
            {


                res.OracleDbType = OracleDbType.Decimal;
                res.Value = ob;
            } else if (aux == "System.Decimal")
            {


                res.OracleDbType = OracleDbType.Double;
                res.Value = ob;
            }else if (aux == "System.DateTime")
            {


                res.OracleDbType = OracleDbType.Date;
                res.Value = ob;
            }




            return res;
        }
    }
}
