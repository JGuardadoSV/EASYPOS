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
    public class MProductoPOS
    {
        readonly IDbConnection cn = Conexion.conectar();

        public List<ProductoPOS> Listado(int id)
        {
            string consulta = "ListadoProductosPorInventario";
            List<ProductoPOS> listado = new List<ProductoPOS>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            listado = cn.Query<ProductoPOS>(consulta,parametros,commandType:CommandType.StoredProcedure).ToList();
            cn.Close();
            return listado;
        }
        
        public ProductoPOS ObtenerUno(int id)
        {
            string consulta = "ProductosPorId";
            DynamicParameters parametros = new DynamicParameters();
            ProductoPOS productoPOS = new ProductoPOS();
            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            productoPOS = cn.QuerySingle<ProductoPOS>(consulta, parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
            return productoPOS;
        }

    }
}
