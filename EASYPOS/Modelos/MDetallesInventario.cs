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
    public class MDetallesInventario
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(DetallesInventario detallesInventario)
        {

            string consulta = "insert into DetallesInventario values (@IdInventario_FK,@IdProducto_FK,@Existencias)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdInventario_FK", detallesInventario.IdInventario_FK, DbType.Int32);
            parametros.Add("@IdProducto_FK", detallesInventario.IdProducto_FK, DbType.Int32);
            parametros.Add("@Existencias", detallesInventario.Existencias, DbType.Int32);

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(DetallesInventario detallesInventario)
        {

            string consulta = "Update DetallesInventario set IdInventario_FK=@IdInventario_FK,IdProducto_FK=@IdProducto_FK, Existencias=@Existencias where IdDetalle=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdInventario_FK", detallesInventario.IdInventario_FK, DbType.Int32);
            parametros.Add("@IdProducto_FK", detallesInventario.IdProducto_FK, DbType.Int32);
            parametros.Add("@Existencias", detallesInventario.Existencias, DbType.Int32);
            parametros.Add("@id", detallesInventario.IdDetalle, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(DetallesInventario detallesInventario)
        {
            string consulta = "Delete from DetallesInventario where IdDetalle=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", detallesInventario.IdDetalle, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<DetallesInventario> Listado()
        {
            string consulta = "SELECT * FROM DetallesInventario";
            List<DetallesInventario> listado = new List<DetallesInventario>();

            cn.Open();
            listado = cn.Query<DetallesInventario>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public DetallesInventario ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM DetallesInventario where IdDetalle=@id";
            DynamicParameters parametros = new DynamicParameters();
            DetallesInventario detallesInventario = new DetallesInventario();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            detallesInventario = cn.QuerySingle<DetallesInventario>(consulta, parametros);
            cn.Close();

            return detallesInventario;
        }


    }
}
