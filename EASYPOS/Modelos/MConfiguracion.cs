using Dapper;
using EASYPOS.Entidades;
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

        public void Guardar(Configuracion config)
        {
            string consulta = "Update Configuracion set Impresora=@Impresora,NombreEmpresa=@NombreEmpresa,NIT=@NIT,Telefono=@Telefono,Propietario=@Propietario,NRC=@NRC,Direccion=@Direccion,Usuario=@Usuario,Clave=@Clave where IdConfiguracion=1";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Impresora", config.Impresora, DbType.String);
            parametros.Add("@NombreEmpresa", config.NombreEmpresa, DbType.String);
            parametros.Add("@NIT", config.NIT, DbType.String);
            parametros.Add("@Telefono", config.Telefono, DbType.String);
            parametros.Add("@Propietario", config.Propietario, DbType.String);
            parametros.Add("@NRC", config.NRC, DbType.String);
            parametros.Add("@Direccion", config.Direccion, DbType.String);
            parametros.Add("@Usuario", config.Usuario, DbType.String);
            parametros.Add("@Clave", config.Clave, DbType.String);
            
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
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
