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
using EASYPOS.Controladores;

namespace EASYPOS.Modelos
{
    public class MCuota
    {
        readonly IDbConnection cn = Conexion.conectar();


        public int Insertar(Cuotas cuota)
        {

            string consulta = "insert into Cuotas (Fecha,Monto,IdContrato_FK,Capital,Intereses) values (@Fecha,@Monto,@IdContrato_FK,@Capital,@Intereses)";
            DynamicParameters parametros = new DynamicParameters();
            // int idventa;
             parametros.Add("@Fecha", cuota.Fecha, DbType.DateTime);
             parametros.Add("@Monto", cuota.Monto, DbType.Decimal);
            /* parametros.Add("@IdContrato_FK", cuota.IdContrato_FK, DbType.Int32);
             //parametros.Add("@TipoDocumento", cuota.TipoDocumento, DbType.Int32);
             parametros.Add("@Correlativo", cuota.Correlativo, DbType.Int64);
             parametros.Add("@IdCorrelativo_FK", cuota.IdCorrelativo_FK, DbType.Int32);*/
            parametros.Add("@IdContrato_FK", cuota.IdContrato_FK, DbType.Int32);
            parametros.Add("@Capital", cuota.Capital, DbType.Decimal);
            parametros.Add("@Intereses", cuota.Intereses, DbType.Decimal);
            //parametros.Add("@Cancelada", 0);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            //idventa = cn.QuerySingle<int>("Select max(IdVenta) id from ventas", commandType: CommandType.Text);
            cn.Close();

            CCorrelativo correlativo = new CCorrelativo();
            correlativo.ActualizarCorrelativo(cuota.IdCorrelativo_FK);

          
            return 1;
        }

        public int Actualizar(Cuotas cuota)
        {

            string consulta = "Update cuotas set Correlativo=@Correlativo,IdCorrelativo_FK=@IdCorrelativo_FK,FechaDePago=@FechaDePago,Cancelada=@Cancelada where IdCuota=@id";
            DynamicParameters parametros = new DynamicParameters();
            // int idventa;
            parametros.Add("@FechaDePago", DateTime.Now);
            parametros.Add("@Cancelada", 1);
            parametros.Add("@id", cuota.IdCuota);
            //parametros.Add("@TipoDocumento", cuota.TipoDocumento, DbType.Int32);
            parametros.Add("@Correlativo", cuota.Correlativo, DbType.Int64);
            parametros.Add("@IdCorrelativo_FK", cuota.IdCorrelativo_FK, DbType.Int32); 

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

           // CCorrelativo correlativo = new CCorrelativo();
            //correlativo.ActualizarCorrelativo(cuota.IdCorrelativo_FK);


            return 1;
        }

        public void Eliminar(Cuotas cuota)
        {
            string consulta = "Delete from Cuotas where IdCuota=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", cuota.IdCuota, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Cuotas> Listado(int id)
        {
            string consulta = "SELECT * FROM Cuotas where IdContrato_FK=@Id";
            List<Cuotas> listado = new List<Cuotas>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Id", id, DbType.Int32);
            cn.Open();
            listado = cn.Query<Cuotas>(consulta,parametros).ToList();
            cn.Close();
            return listado;
        }

        public Cuotas ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Cuotas where IdCuota=@Id";
            DynamicParameters parametros = new DynamicParameters();
            Cuotas cuota = new Cuotas();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            cuota = cn.QuerySingle<Cuotas>(consulta, parametros);
            cn.Close();

            return cuota;
        }
    }
}
