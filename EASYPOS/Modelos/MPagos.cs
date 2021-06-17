using Dapper;
using EASYPOS.Controladores;
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
    public class MPagos
    {
        readonly IDbConnection cn = Conexion.conectar();
        public int Insertar(Pagos pago)
        {
            string consulta = "insert into Pagos (FechaPago,Monto,Recibido,Cambio,ACapital,AIntereses,AMora,ACApitalExtra,CapitalRestante,Comentario,Correlativo,IdCorrelativo_FK,IdCuota_FK) values (@FechaPago,@Monto,@Recibido,@Cambio,@ACapital,@AIntereses,@AMora,@ACApitalExtra,@CapitalRestante,@Comentario,@Correlativo,@IdCorrelativo_FK,@IdCuota_FK)";
            DynamicParameters parametros = new DynamicParameters();
            
            parametros.Add("@FechaPago", pago.FechaPago, DbType.DateTime);
            parametros.Add("@Monto", pago.Monto, DbType.Decimal);
            parametros.Add("@Recibido", pago.Recibido, DbType.Decimal);
            parametros.Add("@Cambio", pago.Cambio, DbType.Decimal);
            parametros.Add("@ACapital", pago.ACapital, DbType.Decimal);
            parametros.Add("@AMora", pago.AMora, DbType.Decimal);
            parametros.Add("@ACApitalExtra", pago.ACApitalExtra, DbType.Decimal); 
            parametros.Add("@AIntereses", pago.AIntereses, DbType.Decimal);
            parametros.Add("@CapitalRestante", pago.CapitalRestante, DbType.Decimal);
            parametros.Add("@Comentario", pago.Comentario, DbType.String);
            parametros.Add("@Correlativo", pago.Correlativo, DbType.Int32);
            parametros.Add("@IdCorrelativo_FK", pago.IdCorrelativo_FK, DbType.Int32);
            parametros.Add("@IdCuota_FK", pago.IdCuota_FK, DbType.Int32);
            
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

            CCorrelativo correlativo = new CCorrelativo();
            correlativo.ActualizarCorrelativo(pago.IdCorrelativo_FK);

            return 1;
        }

        public List<Pagos> ListadoReporte(DateTime f1, DateTime f2)
        {
            List<Pagos> listado = new List<Pagos>();
            List<Pagos> listado2 = new List<Pagos>();
            // try
            //    {
            string consulta = "Select * from pagos where cast(FechaPago as date) between @fecha1 and @fecha2";

            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@fecha1", f1.Date, DbType.DateTime);
            parametros.Add("@fecha2", f2.Date, DbType.DateTime);
            cn.Open();
            listado = cn.Query<Pagos>(consulta, parametros, commandType: CommandType.Text).ToList();
            foreach (Pagos cuota in listado)
            {
                cuota.FechaPago = cuota.FechaPago.Date;
                listado2.Add(cuota);
            }
            cn.Close();
            //   }
            //   catch (Exception ex)
            //    {


            //    }

            return listado2;
        }

        public List<Pagos> Listado(int idContrato)
        {
            
                string consulta = "select a.* from pagos a inner join cuotas b on a.IdCuota_FK=b.IdCuota where b.IdContrato_FK=@Id";
                List<Pagos> listado = new List<Pagos>();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@Id", idContrato, DbType.Int32);
                cn.Open();
                listado = cn.Query<Pagos>(consulta, parametros).ToList();
                cn.Close();
                return listado;
            
        }

        public decimal extra(int idContrato)
        {

            string consulta = "select top 1 a.ACApitalExtra extra from pagos a inner join cuotas b on a.IdCuota_FK=b.IdCuota where b.IdContrato_FK=@Id order by IdPago desc";
            decimal pago = 0;
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Id", idContrato, DbType.Int32);
            cn.Open();
            pago = cn.QuerySingle<decimal>(consulta, parametros);
            cn.Close();
            return pago;

        }
    }
}
