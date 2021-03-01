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
    public class MRol
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Rol rol)
        {

            string consulta = "insert into Roles values (@NombreRol)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombreRol", rol.NombreRol, DbType.String);
            
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Rol rol)
        {

            string consulta = "Update Roles set NombreRol=@NombreRol where IdRol=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombreRol", rol.NombreRol, DbType.String);
            parametros.Add("@id", rol.IdRol, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Rol rol)
        {
            string consulta = "Delete from Roles where IdRol=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", rol.IdRol, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Rol> Listado()
        {
            string consulta = "SELECT * FROM Roles";
            List<Rol> listado = new List<Rol>();

            cn.Open();
            listado = cn.Query<Rol>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Rol ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Roles where IdRol=@id";
            DynamicParameters parametros = new DynamicParameters();
            Rol rol = new Rol();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            rol = cn.QuerySingle<Rol>(consulta, parametros);
            cn.Close();

            return rol;
        }

    }
}
