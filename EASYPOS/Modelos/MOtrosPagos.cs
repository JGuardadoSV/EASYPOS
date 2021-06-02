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
    public class MOtrosPagos
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(OtrosPagos pago)
        {
            
            string consulta = "insert into OtrosPagos values (@fecha,@monto,@comentario,@efectivo,@cambio,@IdContrato_FK)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@fecha", pago.fecha, DbType.DateTime);
            parametros.Add("@monto", pago.monto, DbType.Decimal);
            parametros.Add("@comentario", pago.comentario, DbType.String);
            parametros.Add("@efectivo", pago.efectivo, DbType.Decimal);
            parametros.Add("@cambio", pago.cambio, DbType.Decimal);
            parametros.Add("@IdContrato_FK", pago.IdContrato_FK, DbType.Int32);

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }

        public List<OtrosPagos> ListadoReporte(DateTime f1, DateTime f2)
        {
            string consulta = "select Convert(varchar(10),a.fecha,105) fecha,monto,comentario,efectivo,cambio from OtrosPagos a where cast(a.fecha as date) between @fecha1 and @fecha2";
            List<OtrosPagos> listado = new List<OtrosPagos>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@fecha1", f1.Date, DbType.DateTime);
            parametros.Add("@fecha2", f2.Date, DbType.DateTime);
            cn.Open();
            listado = cn.Query<OtrosPagos>(consulta, parametros, commandType: CommandType.Text).ToList();
            cn.Close();
            return listado;
        }

        public void Actualizar(OtrosPagos pago)
        {

            string consulta = "Update OtrosPagos set fecha=@fecha,monto=@monto,comentario=@comentario,efectivo=@efectivo,cambio=@cambio,IdContrato_FK=@IdContrato_FK where IdPago=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@fecha", pago.fecha, DbType.DateTime);
            parametros.Add("@monto", pago.monto, DbType.Decimal);
            parametros.Add("@comentario", pago.comentario, DbType.String);
            parametros.Add("@efectivo", pago.efectivo, DbType.Decimal);
            parametros.Add("@cambio", pago.cambio, DbType.Decimal);
            parametros.Add("@IdContrato_FK", pago.IdContrato_FK, DbType.Int32);
            parametros.Add("@id", pago.IdPago, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(OtrosPagos pago)
        {
            string consulta = "Delete from OtrosPagos where IdPago=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", pago.IdPago, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<OtrosPagos> Listado(int id)
        {
            string consulta = "SELECT * FROM OtrosPagos where IdContrato_FK=@id";
            List<OtrosPagos> listado = new List<OtrosPagos>();
            DynamicParameters parametros = new DynamicParameters();
            OtrosPagos pago = new OtrosPagos();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            listado = cn.Query<OtrosPagos>(consulta,parametros).ToList();
            cn.Close();
            return listado;
        }

        public OtrosPagos ObtenerUna(int id)
        {
            string consulta = "SELECT * FROM OtrosPagos where IdPago=@id";
            DynamicParameters parametros = new DynamicParameters();
            OtrosPagos pago = new OtrosPagos();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            pago = cn.QuerySingle<OtrosPagos>(consulta, parametros);
            cn.Close();

            return pago;
        }
    }
}
