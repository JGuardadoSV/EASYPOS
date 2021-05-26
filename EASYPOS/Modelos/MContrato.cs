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
    public class MContrato
    {
        readonly IDbConnection cn = Conexion.conectar();

        public int Insertar(Contratos contrato)
        {

            string consulta = "insert into Contratos values (@NombreCompleto,@Dui,@Nit,@TelefonoFijo,@Celular,@DireccionCasa,@DireccionTrabajo,@TelefonoTrabajo,@Referencia1,@DireccionReferencia1,@TelefonoReferencia1,@Referencia2,@DireccionReferencia2,@TelefonoReferencia2,@Precio,@Prima,@Financiamiento,@Cuota,@GastosEscritura,@PrimaNeta,@PrimaInicial,@DescripcionProducto,@Marca,@Modelo,@Chasis,@Anio,@Fecha,@DuiReferencia,@NitReferencia,@Meses,@Estado,@FechaInicio)";            
            DynamicParameters parametros = new DynamicParameters();

            //parametros.Add("@IdContrato", contrato.IdContrato, DbType.Int32);
            parametros.Add("@NombreCompleto", contrato.NombreCompleto, DbType.String);
            parametros.Add("@Dui", contrato.Dui, DbType.String);
            parametros.Add("@Nit", contrato.Nit, DbType.String);
            parametros.Add("@TelefonoFijo", contrato.TelefonoFijo, DbType.String);
            parametros.Add("@Celular", contrato.Celular, DbType.String);
            parametros.Add("@DireccionCasa", contrato.DireccionCasa, DbType.String);
            parametros.Add("@DireccionTrabajo", contrato.DireccionTrabajo, DbType.String);
            parametros.Add("@TelefonoTrabajo", contrato.TelefonoTrabajo, DbType.String);
            parametros.Add("@Referencia1", contrato.Referencia1, DbType.String);
            parametros.Add("@DireccionReferencia1", contrato.DireccionReferencia1, DbType.String);
            parametros.Add("@TelefonoReferencia1", contrato.TelefonoReferencia1, DbType.String);
            parametros.Add("@Referencia2", contrato.Referencia2, DbType.String);
            parametros.Add("@DireccionReferencia2", contrato.DireccionReferencia2, DbType.String);
            parametros.Add("@TelefonoReferencia2", contrato.TelefonoReferencia2, DbType.String);
            parametros.Add("@Precio", contrato.Precio, DbType.Decimal);
            parametros.Add("@Prima", contrato.Prima, DbType.Decimal);
            parametros.Add("@Financiamiento", contrato.Financiamiento, DbType.Decimal);
            parametros.Add("@Cuota", contrato.Cuota, DbType.Decimal);
            parametros.Add("@GastosEscritura", contrato.GastosEscritura, DbType.Decimal);
            parametros.Add("@PrimaNeta", contrato.PrimaNeta, DbType.Decimal);
            parametros.Add("@PrimaInicial", contrato.PrimaInicial, DbType.Decimal);
            parametros.Add("@DescripcionProducto", contrato.DescripcionProducto, DbType.String);
            parametros.Add("@Marca", contrato.Marca, DbType.String);
            parametros.Add("@Modelo", contrato.Modelo, DbType.String);
            parametros.Add("@Chasis", contrato.Chasis, DbType.String);
            parametros.Add("@Anio", contrato.Anio, DbType.Int32);
            parametros.Add("@Fecha", contrato.Fecha, DbType.DateTime);
            parametros.Add("@FechaInicio", contrato.FechaInicio, DbType.DateTime);
            parametros.Add("@DuiReferencia", contrato.DuiReferencia, DbType.String);
            parametros.Add("@NitReferencia", contrato.NitReferencia, DbType.String);
            parametros.Add("@Meses", contrato.Meses, DbType.Int32);
            parametros.Add("@Estado", contrato.Estado, DbType.Int32);

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

            int id;

            consulta = "Select Max(IdContrato) id from Contratos";
            id=cn.QueryFirst<int>(consulta, commandType: CommandType.Text);
            return id;

        }

        public List<Contratos> Atrasados()
        {
            string consulta = "select a.* from contratos a inner join cuotas b on a.IdContrato = b.IdContrato_FK where DATEDIFF(month, b.FechaDePago, getdate())>= 1";
            List<Contratos> listado = new List<Contratos>();
            cn.Open();
            listado = cn.Query<Contratos>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public List<Contratos> Busqueda(string cliente, Boolean atrasados=false)
        {
            string consulta = "select * from Contratos where NombreCompleto like '%'+ @cliente +'%' or DUI  like '%'+ @cliente +'%'";
            if (atrasados)
            {
                consulta = "select a.* from contratos a inner join cuotas b on a.IdContrato = b.IdContrato_FK where (a.NombreCompleto like '%'+ @cliente +'%' or DUI  like '%'+ @cliente +'%') and DATEDIFF(month, b.FechaDePago, getdate())>= 1";
            }
            List<Contratos> listado = new List<Contratos>();
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@cliente", cliente, DbType.String);
            cn.Open();
            listado = cn.Query<Contratos>(consulta, parametros,commandType:CommandType.Text).ToList();
            cn.Close();
            return listado;
        }

        public List<Contratos> Listado(Boolean cotizaciones)
        {
            string consulta = "SELECT * FROM Contratos where Estado=0";

            if (cotizaciones)
            {
                 consulta = "SELECT * FROM Contratos where Estado=1";

            }
            List<Contratos> listado = new List<Contratos>();

            cn.Open();
            listado = cn.Query<Contratos>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public int Actualizar(Contratos contrato)
        {

            string consulta = "Update Contratos set NombreCompleto=@NombreCompleto,Dui=@Dui,Nit=@Nit,TelefonoFijo=@TelefonoFijo,Celular=@Celular,DireccionCasa=@DireccionCasa,DireccionTrabajo=@DireccionTrabajo,TelefonoTrabajo=@TelefonoTrabajo,Referencia1=@Referencia1,DireccionReferencia1=@DireccionReferencia1,TelefonoReferencia1=@TelefonoReferencia1,Referencia2=@Referencia2,DireccionReferencia2=@DireccionReferencia2,TelefonoReferencia2=@TelefonoReferencia2,Precio=@Precio,Prima=@Prima,Financiamiento=@Financiamiento,Cuota=@Cuota,GastosEscritura=@GastosEscritura,PrimaNeta=@PrimaNeta,PrimaInicial=@PrimaInicial,DescripcionProducto=@DescripcionProducto,Marca=@Marca,Modelo=@Modelo,Chasis=@Chasis,Anio=@Anio,Fecha=@Fecha,FechaInicio=@FechaInicio ,DuiReferencia=@DuiReferencia,NitReferencia=@NitReferencia,Meses=@Meses,Estado=@Estado where IdContrato=@IdContrato";
            DynamicParameters parametros = new DynamicParameters();
            
            parametros.Add("@IdContrato", contrato.IdContrato, DbType.Int32);
            parametros.Add("@NombreCompleto", contrato.NombreCompleto, DbType.String);
            parametros.Add("@Dui", contrato.Dui, DbType.String);
            parametros.Add("@Nit", contrato.Nit, DbType.String);
            parametros.Add("@TelefonoFijo", contrato.TelefonoFijo, DbType.String);
            parametros.Add("@Celular", contrato.Celular, DbType.String);
            parametros.Add("@DireccionCasa", contrato.DireccionCasa, DbType.String);
            parametros.Add("@DireccionTrabajo", contrato.DireccionTrabajo, DbType.String);
            parametros.Add("@TelefonoTrabajo", contrato.TelefonoTrabajo, DbType.String);
            parametros.Add("@Referencia1", contrato.Referencia1, DbType.String);
            parametros.Add("@DireccionReferencia1", contrato.DireccionReferencia1, DbType.String);
            parametros.Add("@TelefonoReferencia1", contrato.TelefonoReferencia1, DbType.String);
            parametros.Add("@Referencia2", contrato.Referencia2, DbType.String);
            parametros.Add("@DireccionReferencia2", contrato.DireccionReferencia2, DbType.String);
            parametros.Add("@TelefonoReferencia2", contrato.TelefonoReferencia2, DbType.String);
            parametros.Add("@Precio", contrato.Precio, DbType.Decimal);
            parametros.Add("@Prima", contrato.Prima, DbType.Decimal);
            parametros.Add("@Financiamiento", contrato.Financiamiento, DbType.Decimal);
            parametros.Add("@Cuota", contrato.Cuota, DbType.Decimal);
            parametros.Add("@GastosEscritura", contrato.GastosEscritura, DbType.Decimal);
            parametros.Add("@PrimaNeta", contrato.PrimaNeta, DbType.Decimal);
            parametros.Add("@PrimaInicial", contrato.PrimaInicial, DbType.Decimal);
            parametros.Add("@DescripcionProducto", contrato.DescripcionProducto, DbType.String);
            parametros.Add("@Marca", contrato.Marca, DbType.String);
            parametros.Add("@Modelo", contrato.Modelo, DbType.String);
            parametros.Add("@Chasis", contrato.Chasis, DbType.String);
            parametros.Add("@Anio", contrato.Anio, DbType.Int32);
            parametros.Add("@Fecha", contrato.Fecha, DbType.DateTime);
            parametros.Add("@DuiReferencia", contrato.DuiReferencia, DbType.String);
            parametros.Add("@NitReferencia", contrato.NitReferencia, DbType.String);
            parametros.Add("@Meses", contrato.Meses, DbType.Int32);
            parametros.Add("@Estado", contrato.Estado, DbType.Int32);
            parametros.Add("@FechaInicio", contrato.FechaInicio, DbType.DateTime);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

            return 1;

        }

        public void Eliminar(Contratos contrato)
        {
            string consulta = "Delete from Contratos where IdContrato=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", contrato.IdContrato, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

    }
}
