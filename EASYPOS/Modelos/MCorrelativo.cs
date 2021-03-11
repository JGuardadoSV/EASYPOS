using EASYPOS.Entidades;
using EASYPOS.Herramientas;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASYPOS.Modelos
{
    public class MCorrelativo
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Correlativo correlativo)
        {

            string consulta = "insert into Correlativos values (@FechaCreacion,@Inicio,@Fin,@Autorizacion,@TipoDeDocumento,@FechaDeAutorizacion,@ValorActual,@IdSucursal_FK)";
            DynamicParameters parametros = new DynamicParameters();

            
            
            parametros.Add("@FechaCreacion", correlativo.FechaCreacion, DbType.DateTime);
            parametros.Add("@Inicio", correlativo.Inicio, DbType.Int32);
            parametros.Add("@Fin", correlativo.Fin, DbType.Int64);
            parametros.Add("@Autorizacion", correlativo.Autorizacion, DbType.String);
            parametros.Add("@TipoDeDocumento", correlativo.TipoDeDocumento, DbType.Int32);
            parametros.Add("@FechaDeAutorizacion", correlativo.FechaDeAutorizacion, DbType.DateTime);
            parametros.Add("@ValorActual", correlativo.ValorActual, DbType.Int64);
            parametros.Add("@IdSucursal_FK", correlativo.IdSucursal_FK, DbType.Int64);

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Correlativo correlativo)
        {

            string consulta = "Update Correlativos set FechaCreacion=@FechaCreacion,Inicio=@Inicio,Fin=@Fin,Autorizacion=@Autorizacion,TipoDeDocumento=@TipoDeDocumento,FechaDeAutorizacion=@FechaDeAutorizacion,ValorActual=@ValorActual,IdSucursal_FK=@IdSucursal_FK where IdCorrelativo=@id";
            DynamicParameters parametros = new DynamicParameters();

            
            parametros.Add("@FechaCreacion", correlativo.FechaCreacion, DbType.DateTime);
            parametros.Add("@Inicio", correlativo.Inicio, DbType.Int32);
            parametros.Add("@Fin", correlativo.Fin, DbType.Int32);
            parametros.Add("@Autorizacion", correlativo.Autorizacion, DbType.String);
            parametros.Add("@TipoDeDocumento", correlativo.TipoDeDocumento, DbType.Int32);
            parametros.Add("@FechaDeAutorizacion", correlativo.FechaDeAutorizacion, DbType.DateTime);
            parametros.Add("@ValorActual", correlativo.ValorActual, DbType.Int64);
            parametros.Add("@IdSucursal_FK", correlativo.IdSucursal_FK, DbType.Int64);
            parametros.Add("@id", correlativo.IdCorrelativo, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Correlativo correlativo)
        {
            string consulta = "Delete from Correlativos where IdCorrelativo=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", correlativo.IdCorrelativo, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Correlativo> Listado()
        {
            string consulta = "SELECT * FROM Correlativos";
            List<Correlativo> listado = new List<Correlativo>();

            cn.Open();
            listado = cn.Query<Correlativo>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Correlativo ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Correlativos where IdCorrelativo=@id";
            DynamicParameters parametros = new DynamicParameters();
            Correlativo correlativo = new Correlativo();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            correlativo = cn.QuerySingle<Correlativo>(consulta, parametros);
            cn.Close();

            return correlativo;
        }



    }
}
