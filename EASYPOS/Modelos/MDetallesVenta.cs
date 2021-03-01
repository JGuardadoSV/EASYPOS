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
    public class MDetallesVenta
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(DetallesVenta detallesVenta)
        {

            string consulta = "insert into DetallesVenta values (@IdDetalleInventario_FK,@Cantidad,@IdPresentacion_FK,@IdVenta_FK,@DecuentoAplicado,@PrecioVenta)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdDetalleInventario_FK", detallesVenta.IdDetalleInventario_FK, DbType.Int32);
            parametros.Add("@Cantidad", detallesVenta.Cantidad, DbType.Int32);
            parametros.Add("@IdPresentacion_FK", detallesVenta.IdPresentacion_FK, DbType.Int32);
            parametros.Add("@IdVenta_FK", detallesVenta.IdVenta_FK, DbType.Int32);
            parametros.Add("@DecuentoAplicado", detallesVenta.DecuentoAplicado, DbType.Decimal);
            parametros.Add("@PrecioVenta", detallesVenta.PrecioVenta, DbType.Decimal);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(DetallesVenta detallesVenta)
        {

            string consulta = "Update DetallesVenta set IdDetalleInventario_FK=@IdDetalleInventario_FK,Cantidad=@Cantidad,IdPresentacion_FK=@IdPresentacion_FK,IdVenta_FK=@IdVenta_FK,DecuentoAplicado=@DecuentoAplicado,PrecioVenta=@PrecioVenta where IdDetalleVenta=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdDetalleInventario_FK", detallesVenta.IdDetalleInventario_FK, DbType.Int32);
            parametros.Add("@Cantidad", detallesVenta.Cantidad, DbType.Int32);
            parametros.Add("@IdPresentacion_FK", detallesVenta.IdPresentacion_FK, DbType.Int32);
            parametros.Add("@IdVenta_FK", detallesVenta.IdVenta_FK, DbType.Int32);
            parametros.Add("@DecuentoAplicado", detallesVenta.DecuentoAplicado, DbType.Decimal);
            parametros.Add("@PrecioVenta", detallesVenta.PrecioVenta, DbType.Decimal);
            parametros.Add("@id", detallesVenta.IdDetalleVenta, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(DetallesVenta detallesVenta)
        {
            string consulta = "Delete from DetallesVenta where IdDetalleVenta=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", detallesVenta.IdDetalleVenta, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<DetallesVenta> Listado()
        {
            string consulta = "SELECT * FROM DetallesVenta";
            List<DetallesVenta> listado = new List<DetallesVenta>();

            cn.Open();
            listado = cn.Query<DetallesVenta>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public DetallesVenta ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM DetallesVenta where IdDetalleVenta=@id";
            DynamicParameters parametros = new DynamicParameters();
            DetallesVenta detallesVenta = new DetallesVenta();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            detallesVenta = cn.QuerySingle<DetallesVenta>(consulta, parametros);
            cn.Close();

            return detallesVenta;
        }
    }
}
