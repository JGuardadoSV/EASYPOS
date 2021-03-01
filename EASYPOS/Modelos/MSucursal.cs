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
   public class MSucursal
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Sucursal sucursal)
        {

            string consulta = "insert into Sucursales values (@NombreSucursal,@Direccion,@Telefono)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombreSucursal", sucursal.NombreSucursal, DbType.String);
            parametros.Add("@Direccion", sucursal.Direccion, DbType.String);
            parametros.Add("@Telefono", sucursal.Telefono, DbType.String);
            
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Sucursal sucursal)
        {

            string consulta = "Update Sucursales set NombreSucursal=@NombreSucursal,Direccion=@Direccion,Telefono=@Telefono where IdSucursal=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombreSucursal", sucursal.NombreSucursal, DbType.String);
            parametros.Add("@Direccion", sucursal.Direccion, DbType.String);
            parametros.Add("@Telefono", sucursal.Telefono, DbType.String);
            parametros.Add("@id", sucursal.IdSucursal, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Sucursal sucursal)
        {
            string consulta = "Delete from Sucursales where IdSucursal=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", sucursal.IdSucursal, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Sucursal> Listado()
        {
            string consulta = "SELECT * FROM Sucursales";
            List<Sucursal> listado = new List<Sucursal>();

            cn.Open();
            listado = cn.Query<Sucursal>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Sucursal ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Sucursales where IdSucursal=@id";
            DynamicParameters parametros = new DynamicParameters();
            Sucursal sucursal = new Sucursal();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            sucursal = cn.QuerySingle<Sucursal>(consulta, parametros);
            cn.Close();

            return sucursal;
        }
    }
}
