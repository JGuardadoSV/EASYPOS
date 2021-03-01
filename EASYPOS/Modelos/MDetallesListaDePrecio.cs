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
    public class MDetallesListaDePrecio
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(DetallesListaDePrecio detallesListaDePrecio)
        {

            string consulta = "insert into DetallesListaDePrecios values (@IdLista_FK,@IdDetalleInventario_FK)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdLista_FK", detallesListaDePrecio.IdLista_FK, DbType.Int32);
            parametros.Add("@IdDetalleInventario_FK", detallesListaDePrecio.IdDetalleInventario_FK, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(DetallesListaDePrecio detallesListaDePrecio)
        {

            string consulta = "Update DetallesListaDePrecios set IdLista_FK=@IdLista_FK, IdDetalleInventario_FK=@IdDetalleInventario_FK where IdDetalleLista=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdLista_FK", detallesListaDePrecio.IdLista_FK, DbType.Int32);
            parametros.Add("@IdDetalleInventario_FK", detallesListaDePrecio.IdDetalleInventario_FK, DbType.Int32);
            parametros.Add("@id", detallesListaDePrecio.IdDetalleLista, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(DetallesListaDePrecio detallesListaDePrecio)
        {
            string consulta = "Delete from DetallesListaDePrecios where IdDetalleLista=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", detallesListaDePrecio.IdDetalleLista, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<DetallesListaDePrecio> Listado()
        {
            string consulta = "SELECT * FROM DetallesListaDePrecios";
            List<DetallesListaDePrecio> listado = new List<DetallesListaDePrecio>();

            cn.Open();
            listado = cn.Query<DetallesListaDePrecio>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public DetallesListaDePrecio ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM DetallesListaDePrecios where IdDetalleLista=@id";
            DynamicParameters parametros = new DynamicParameters();
            DetallesListaDePrecio detallesListaDePrecio = new DetallesListaDePrecio();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            detallesListaDePrecio = cn.QuerySingle<DetallesListaDePrecio>(consulta, parametros);
            cn.Close();

            return detallesListaDePrecio;
        }


    }
}
