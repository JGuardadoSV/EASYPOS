using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Herramientas
{
    public static class Conexion
    {

        public static IDbConnection conectar()
        {
            IDbConnection connection;

            
                var cadena = ConfigurationManager.ConnectionStrings["principal"].ConnectionString;
                connection = new SqlConnection(cadena);
              
            // Properly initialize your connection here.
            return connection;
        }
        /*
         public static IDbConnection Conectar()
        {
            IDbConnection con;
            string cadena = "Data source=(local);" +
                "Initial Catalog=Inventario;" +
                "Integrated security=true";
            SqlConnection cn = new SqlConnection(cadena);
            con = cn;
            return con;
        }
         */
    }
}
