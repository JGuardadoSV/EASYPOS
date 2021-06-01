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
    public class MVenta
    {
        readonly IDbConnection cn = Conexion.conectar();


        public int Insertar(Venta venta,List<ProductoPOS> detalles)
        {

            string consulta = "insert into Ventas values (@Fecha,@IdCliente_FK,@IdEmpleado_FK,@TipoDocumento,@Correlativo,@IdCorrelativo_FK,@Total,@Efectivo,@Cambio)";
            DynamicParameters parametros = new DynamicParameters();
            int idventa;
            parametros.Add("@Fecha", venta.Fecha, DbType.DateTime);
            parametros.Add("@IdCliente_FK", venta.IdCliente_FK, DbType.Int32);
            parametros.Add("@IdEmpleado_FK", venta.IdEmpleado_FK, DbType.Int32);
            parametros.Add("@TipoDocumento", venta.TipoDocumento, DbType.Int32);
            parametros.Add("@Correlativo", venta.Correlativo, DbType.Int64);
            parametros.Add("@IdCorrelativo_FK", venta.IdCorrelativo_FK, DbType.Int32);
            parametros.Add("@Total", venta.Total, DbType.Decimal);
            parametros.Add("@Efectivo", venta.Efectivo, DbType.Decimal);
            parametros.Add("@Cambio", venta.Cambio, DbType.Decimal);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            idventa = cn.QuerySingle<int>("Select max(IdVenta) id from ventas", commandType: CommandType.Text);
            cn.Close();

            CCorrelativo correlativo = new CCorrelativo();
            correlativo.ActualizarCorrelativo(venta.IdCorrelativo_FK);

            CDetallesVenta detalle = new CDetallesVenta();
            CDetallesInventario inventario = new CDetallesInventario();
            foreach (ProductoPOS p in detalles)
            {
                DetallesVenta det = new DetallesVenta();
                det.Cantidad = p.Cantidad;
                det.IdDetalleInventario_FK = p.IdDetalleInventario;
                det.IdVenta_FK = idventa;
                det.PrecioVenta = p.Precio;

                detalle.Insertar(det);

                inventario.disminuirExistencias(det.IdDetalleInventario_FK, det.Cantidad.Value);
                
            }
            return idventa;
        }

        public List<ProductoPOS> DetallesVenta(int id)
        {
            string consulta = "select c.Codigo codigo, c.NombreProducto Nombre, a.PrecioVenta Precio, a.Cantidad Cantidad, (a.PrecioVenta *a.Cantidad) Total from DetallesVenta a inner join DetallesInventario b on a.IdDetalleInventario_FK = b.IdDetalle inner join Productos c on b.IdProducto_FK = c.IdProducto where a.IdVenta_FK = @id";
            List<ProductoPOS> listado = new List<ProductoPOS>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            listado = cn.Query<ProductoPOS>(consulta, parametros).ToList();
            cn.Close();
            return listado;
        }

        public void Actualizar(Venta venta)
        {

            string consulta = "Update Ventas set Fecha=@Fecha,IdCliente_FK=@IdCliente_FK,IdEmpleado_FK=@IdEmpleado_FK,TipoDocumento=@TipoDocumento,Correlativo=@Corelativo,IdCorrelativo_FK=@IdCorrelativo_FK,Total=@Total,Efectivo=@Efectivo,Cambio=@Cambio where IdVenta=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Fecha", venta.Fecha, DbType.DateTime);
            parametros.Add("@IdCliente_FK", venta.IdCliente_FK, DbType.Int32);
            parametros.Add("@IdEmpleado_FK", venta.IdEmpleado_FK, DbType.Int32);
            parametros.Add("@TipoDocumento", venta.TipoDocumento, DbType.Int32);
            parametros.Add("@Correlativo", venta.Correlativo, DbType.Int64);
            parametros.Add("@IdCorrelativo_FK", venta.IdCorrelativo_FK, DbType.Int32);
            parametros.Add("@id", venta.IdVenta, DbType.Int32);
            parametros.Add("@Total", venta.Total, DbType.Decimal);
            parametros.Add("@Efectivo", venta.Total, DbType.Decimal);
            parametros.Add("@Cambio", venta.Total, DbType.Decimal);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Venta venta)
        {
            string consulta = "Delete from Ventas where IdVenta=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", venta.IdVenta, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Venta> Listado(DateTime f1, DateTime f2)
        {
            string consulta = "Select * from Ventas where cast(fecha as date) between @f1 and @f2";
            List<Venta> listado = new List<Venta>();
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@f1", f1.Date, DbType.DateTime);
            parametros.Add("@f2", f2.Date, DbType.DateTime);

            cn.Open();
            listado = cn.Query<Venta>(consulta,parametros).ToList();
            cn.Close();
            return listado;
        }

        public Venta ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Ventas where IdVenta=@id";
            DynamicParameters parametros = new DynamicParameters();
            Venta venta = new Venta();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            venta = cn.QuerySingle<Venta>(consulta, parametros);
            cn.Close();

            return venta;
        }


        /*
         Select a.fecha,b.NombreCliente,a.Correlativo,a.total  from ventas a
inner join clientes b on a.IdCliente_FK=b.IdCliente
where a.Fecha between @fecha1 and @fecha2
         */


        public List<ReporteVentas> Reporte(DateTime f1, DateTime f2)
        {
            string consulta = "Select Convert(varchar(10),a.fecha,105) fecha,b.NombreCliente cliente,a.Correlativo ticket,a.total  from ventas a inner join clientes b on a.IdCliente_FK = b.IdCliente where cast(a.fecha as date) between @fecha1 and @fecha2";
            List<ReporteVentas> listado = new List<ReporteVentas>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@fecha1", f1.Date, DbType.DateTime);
            parametros.Add("@fecha2", f2.Date, DbType.DateTime);
            cn.Open();
            listado = cn.Query<ReporteVentas>(consulta,parametros,commandType:CommandType.Text).ToList();
            cn.Close();
            return listado;
        }
    }
}
