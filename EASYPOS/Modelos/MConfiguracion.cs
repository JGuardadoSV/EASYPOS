using Dapper;
using EASYPOS.Herramientas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Modelos
{
   public class MConfiguracion
    {
        readonly IDbConnection cn = Conexion.conectar();


        public Configuracion ObtenerUna()
        {
            string consulta = "SELECT * FROM Configuracion where IdConfiguracion=1";

            Configuracion config = new Configuracion();

          
            cn.Open();
            config = cn.QuerySingle<Configuracion>(consulta);
            cn.Close();

            return config;
        }

        public Configuracion Autenticacion(string usuario, string clave)
        {
            string consulta = "SELECT * FROM Configuracion where IdConfiguracion=1 and Usuario=@usuario and Clave=@contra";
            DynamicParameters parametros = new DynamicParameters();
            
            parametros.Add("@usuario", usuario.Trim(), DbType.String);
            parametros.Add("@contra", clave.Trim(), DbType.String);
            Configuracion config = new Configuracion();


            cn.Open();
            config = cn.QuerySingleOrDefault<Configuracion>(consulta,parametros,commandType:CommandType.Text);
            cn.Close();

            return config;
        }

    }
}
