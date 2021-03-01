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
    public class MProveedor
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Proveedor proveedor)
        {

            string consulta = "insert into Proveedores values (@Nombre,@Email,@Telefono,@PersonaContacto)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Nombre", proveedor.NombreProveedor, DbType.String);
            parametros.Add("@Email", proveedor.Email, DbType.String);
            parametros.Add("@Telefono", proveedor.Telefono, DbType.String);
            parametros.Add("@PersonaContacto", proveedor.PersonaContacto, DbType.String);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Proveedor proveedor)
        {

            string consulta = "Update Proveedores set NombreProveedor=@Nombre,Email=@Email,Telefono=@Telefono,PersonaContacto=@PersonaContacto where IdProveedor=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Nombre", proveedor.NombreProveedor, DbType.String);
            parametros.Add("@Email", proveedor.Email, DbType.String);
            parametros.Add("@Telefono", proveedor.Telefono, DbType.String);
            parametros.Add("@PersonaContacto", proveedor.PersonaContacto, DbType.String);
            parametros.Add("@id", proveedor.IdProveedor, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Proveedor proveedor)
        {
            string consulta = "Delete from Proveedores where IdProveedor=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", proveedor.IdProveedor, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Proveedor> Listado()
        {
            string consulta = "SELECT * FROM Proveedores";
            List<Proveedor> listado = new List<Proveedor>();

            cn.Open();
            listado = cn.Query<Proveedor>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Proveedor ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Proveedores where IdProveedor=@id";
            DynamicParameters parametros = new DynamicParameters();
            Proveedor proveedor = new Proveedor();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            proveedor = cn.QuerySingle<Proveedor>(consulta, parametros);
            cn.Close();

            return proveedor;
        }



    }
}
