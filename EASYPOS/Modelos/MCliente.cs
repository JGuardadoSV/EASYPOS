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
    public class MCliente
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Cliente cliente)
        {

            string consulta = "insert into Clientes values (@NombreCliente,	@DUI,@NIT,@Giro,@NRC,@DireccionCliente,@Telefono)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombreCliente", cliente.NombreCliente, DbType.String);
            parametros.Add("@DUI", cliente.DUI, DbType.String);
            parametros.Add("@NIT", cliente.NIT, DbType.String);
            parametros.Add("@Giro", cliente.Giro, DbType.String);
            parametros.Add("@NRC", cliente.NRC, DbType.String);
            parametros.Add("@DireccionCliente", cliente.DireccionCliente, DbType.String);
            parametros.Add("@Telefono", cliente.Telefono, DbType.String);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Cliente cliente)
        {

            string consulta = "Update Clientes set NombreCliente = @NombreCliente,DUI = @DUI,NIT = @NIT,Giro = @Giro,NRC = @NRC,DireccionCliente = @DireccionCliente,Telefono = @Telefono where IdCliente=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombreCliente", cliente.NombreCliente, DbType.String);
            parametros.Add("@DUI", cliente.DUI, DbType.String);
            parametros.Add("@NIT", cliente.NIT, DbType.String);
            parametros.Add("@Giro", cliente.Giro, DbType.String);
            parametros.Add("@NRC", cliente.NRC, DbType.String);
            parametros.Add("@DireccionCliente", cliente.DireccionCliente, DbType.String);
            parametros.Add("@Telefono", cliente.Telefono, DbType.String);
            parametros.Add("@id", cliente.IdCliente, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Cliente cliente)
        {
            string consulta = "Delete from Clientes where IdCliente=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", cliente.IdCliente, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Cliente> Listado()
        {
            string consulta = "SELECT * FROM Clientes";
            List<Cliente> listado = new List<Cliente>();

            cn.Open();
            listado = cn.Query<Cliente>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Cliente ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Clientes where IdCliente=@id";
            DynamicParameters parametros = new DynamicParameters();
            Cliente cliente = new Cliente();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            cliente = cn.QuerySingle<Cliente>(consulta, parametros);
            cn.Close();

            return cliente;
        }



    }
}
