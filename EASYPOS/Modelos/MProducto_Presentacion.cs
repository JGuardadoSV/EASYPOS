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
    //IdProducto_FK
    //IdPresentacion_FK

   public class MProducto_Presentacion
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Producto_Presentacion producto_Presentacion)
        {

            string consulta = "insert into Producto_Presentaciones values (@IdProducto_FK,@IdPresentacion_FK)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdProducto_FK", producto_Presentacion.IdProducto_FK, DbType.Int32);
            parametros.Add("@IdPresentacion_FK", producto_Presentacion.IdPresentacion_FK, DbType.Int32);
            
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
      
        public void Eliminar(Producto_Presentacion producto_Presentacion)
        {
            string consulta = "Delete from Producto_Presentaciones where IdProducto_FK=@IdProducto_FK and IdPresentacion_FK=@IdPresentacion_FK";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdProducto_FK", producto_Presentacion.IdProducto_FK, DbType.Int32);
            parametros.Add("@IdPresentacion_FK", producto_Presentacion.IdPresentacion_FK, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Producto_Presentacion> Listado(int id)
        {
            string consulta = "SELECT * FROM Producto_Presentaciones where IdProducto_FK=@id";
            List<Producto_Presentacion> listado = new List<Producto_Presentacion>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            listado = cn.Query<Producto_Presentacion>(consulta,parametros).ToList();
            cn.Close();
            return listado;
        }

       
    }
}
