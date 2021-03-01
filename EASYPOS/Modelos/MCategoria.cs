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
    public class MCategoria
    {
        readonly IDbConnection cn = Conexion.conectar();
        

        public void Insertar(Categoria categoria)    {

            string consulta = "insert into CATEGORIAS values (@nombre)";
            DynamicParameters parametros = new DynamicParameters();
            
            parametros.Add("@nombre", categoria.NombreCategoria, DbType.String);
            cn.Open();
            cn.Execute(consulta, parametros,commandType:CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Categoria categoria)     {

            string consulta = "Update CATEGORIAS set NombreCategoria=@nombre where IdCategoria=@id";
            DynamicParameters parametros = new DynamicParameters();
            
            parametros.Add("@nombre", categoria.NombreCategoria, DbType.String);
            parametros.Add("@id", categoria.IdCategoria, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Categoria categoria)      {
            string consulta = "Delete from CATEGORIAS where IdCategoria=@id";
            DynamicParameters parametros = new DynamicParameters();
            
            parametros.Add("@id", categoria.IdCategoria, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Categoria> Listado()
        {
            string consulta = "SELECT * FROM CATEGORIAS";
            List<Categoria> listado = new List<Categoria>();
            
            cn.Open();
            listado =  cn.Query<Categoria>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Categoria ObtenerUna(int id)
        {
            string consulta = "SELECT * FROM CATEGORIAS where IdCategoria=@id";
            DynamicParameters parametros = new DynamicParameters();
            Categoria categoria = new Categoria();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            categoria = cn.QuerySingle<Categoria>(consulta,parametros);
            cn.Close();
            
            return categoria;
        }

        

    }
}
