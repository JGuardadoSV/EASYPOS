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
    class MListasDePrecio
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(ListasDePrecio listasDePrecio)
        {

            string consulta = "insert into ListasDePrecios values (@IdInventario_FK,@Activa)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdInventario_FK", listasDePrecio.IdInventario_FK, DbType.Int32);
            parametros.Add("@Activa", listasDePrecio.Activa, DbType.Int32);
            
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(ListasDePrecio listasDePrecio)
        {

            string consulta = "Update ListasDePrecios set IdInventario_FK=@IdInventario_FK,Activa=@Activa where IdLista=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdInventario_FK", listasDePrecio.IdInventario_FK, DbType.Int32);
            parametros.Add("@Activa", listasDePrecio.Activa, DbType.Int32);
            parametros.Add("@id", listasDePrecio.IdLista, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(ListasDePrecio listasDePrecio)
        {
            string consulta = "Delete from ListasDePrecios where IdLista=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", listasDePrecio.IdLista, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<ListasDePrecio> Listado()
        {
            string consulta = "SELECT * FROM ListasDePrecios";
            List<ListasDePrecio> listado = new List<ListasDePrecio>();

            cn.Open();
            listado = cn.Query<ListasDePrecio>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public ListasDePrecio ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM ListasDePrecios where IdLista=@id";
            DynamicParameters parametros = new DynamicParameters();
            ListasDePrecio listasDePrecio = new ListasDePrecio();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            listasDePrecio = cn.QuerySingle<ListasDePrecio>(consulta, parametros);
            cn.Close();

            return listasDePrecio;
        }
    }
}
