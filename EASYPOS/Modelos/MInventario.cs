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
    public class MInventario
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Inventario inventario)
        {

            string consulta = "insert into Inventarios values (	@TipoInventario,@IdSucursal_FK)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@TipoInventario", inventario.TipoInventario, DbType.Int32);
            parametros.Add("@IdSucursal_FK", inventario.IdSucursal_FK, DbType.Int32);
           
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Inventario inventario)
        {

            string consulta = "Update Inventarios set TipoInventario=@TipoInventario,IdSucursal_FK=@IdSucursal_FK where IdInventario=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@TipoInventario", inventario.TipoInventario, DbType.Int32);
            parametros.Add("@IdSucursal_FK", inventario.IdSucursal_FK, DbType.Int32);
            parametros.Add("@id", inventario.IdInventario, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Inventario inventario)
        {
            string consulta = "Delete from Inventarios where IdInventario=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", inventario.IdInventario, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Inventario> Listado()
        {
            string consulta = "SELECT * FROM Inventarios";
            List<Inventario> listado = new List<Inventario>();

            cn.Open();
            listado = cn.Query<Inventario>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Inventario ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Inventarios where IdInventario=@id";
            DynamicParameters parametros = new DynamicParameters();
            Inventario inventario = new Inventario();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            inventario = cn.QuerySingle<Inventario>(consulta, parametros);
            cn.Close();

            return inventario;
        }
    }
}
