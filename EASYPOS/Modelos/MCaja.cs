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
    public class MCaja
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Caja caja)
        {

            string consulta = "insert into Cajas values (@FechaApertura,@FechaCierre,@IdEmpleadoApertura_FK,@MontoInicial,@SumaEntradas,@SumaSalidas,@Faltante,@Sobrante,@Observaciones,@IdEmpleadoCierre_FK,@IdSucursal_FK,@Estado)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@FechaApertura", caja.FechaApertura, DbType.String);
            parametros.Add("@FechaCierre", caja.FechaCierre, DbType.String);
            parametros.Add("@IdEmpleadoApertura_FK", caja.IdEmpleadoApertura_FK, DbType.String);
            parametros.Add("@MontoInicial", caja.MontoInicial, DbType.String);
            parametros.Add("@SumaEntradas", caja.SumaEntradas, DbType.String);
            parametros.Add("@SumaSalidas", caja.SumaSalidas, DbType.String);
            parametros.Add("@Faltante", caja.Faltante, DbType.String);
            parametros.Add("@Sobrante", caja.Sobrante, DbType.String);
            parametros.Add("@Observaciones", caja.Observaciones, DbType.String);
            parametros.Add("@IdEmpleadoCierre_FK", caja.IdEmpleadoCierre_FK, DbType.String);
            parametros.Add("@IdSucursal_FK", caja.IdSucursal_FK, DbType.String);
            parametros.Add("@Estado", caja.Estado, DbType.String);

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Caja caja)
        {

            string consulta = "Update Cajas set FechaApertura=@FechaApertura,FechaCierre=@FechaCierre,IdEmpleadoApertura_FK=@IdEmpleadoApertura_FK,MontoInicial=@MontoInicial,SumaEntradas=@SumaEntradas,SumaSalidas=@SumaSalidas,Faltante=@Faltante,Sobrante=@Sobrante,Observaciones=@Observaciones,IdEmpleadoCierre_FK=@IdEmpleadoCierre_FK,IdSucursal_FK=@IdSucursal_FK,Estado=@Estado where IdCaja=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@FechaApertura", caja.FechaApertura, DbType.String);
            parametros.Add("@FechaCierre", caja.FechaCierre, DbType.String);
            parametros.Add("@IdEmpleadoApertura_FK", caja.IdEmpleadoApertura_FK, DbType.String);
            parametros.Add("@MontoInicial", caja.MontoInicial, DbType.String);
            parametros.Add("@SumaEntradas", caja.SumaEntradas, DbType.String);
            parametros.Add("@SumaSalidas", caja.SumaSalidas, DbType.String);
            parametros.Add("@Faltante", caja.Faltante, DbType.String);
            parametros.Add("@Sobrante", caja.Sobrante, DbType.String);
            parametros.Add("@Observaciones", caja.Observaciones, DbType.String);
            parametros.Add("@IdEmpleadoCierre_FK", caja.IdEmpleadoCierre_FK, DbType.String);
            parametros.Add("@IdSucursal_FK", caja.IdSucursal_FK, DbType.String);
            parametros.Add("@Estado", caja.Estado, DbType.String);
            parametros.Add("@id", caja.IdCaja, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Caja caja)
        {
            string consulta = "Delete from Cajas where IdCaja=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", caja.IdCaja, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Caja> Listado()
        {
            string consulta = "SELECT * FROM Cajas";
            List<Caja> listado = new List<Caja>();

            cn.Open();
            listado = cn.Query<Caja>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Caja ObtenerUna(int id)
        {
            string consulta = "SELECT * FROM Cajas where IdCaja=@id";
            DynamicParameters parametros = new DynamicParameters();
            Caja caja = new Caja();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            caja = cn.QuerySingle<Caja>(consulta, parametros);
            cn.Close();

            return caja;
        }
    }
}
