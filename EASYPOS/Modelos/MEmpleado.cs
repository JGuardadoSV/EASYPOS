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
   public  class MEmpleado
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Empleado empleado)
        {

            string consulta = "insert into Empleados values (@NombresEmpleado,@ApellidosEmpleado,@IdRol_FK,@DUI,@NIT,@Telefono,@Email)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombresEmpleado", empleado.NombresEmpleado, DbType.String);
            parametros.Add("@ApellidosEmpleado", empleado.ApellidosEmpleado, DbType.String);
            parametros.Add("@IdRol_FK", empleado.IdRol_FK, DbType.Int32);
            parametros.Add("@DUI", empleado.DUI, DbType.String);
            parametros.Add("@NIT", empleado.NIT, DbType.String);
            parametros.Add("@Telefono", empleado.Telefono, DbType.String);
            parametros.Add("@Email", empleado.Email, DbType.String);
            
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Empleado empleado)
        {

            string consulta = "Update Empleados set NombresEmpleado=@NombresEmpleado,ApellidosEmpleado=@ApellidosEmpleado,IdRol_FK=@IdRol_FK,DUI=@DUI,NIT=@NIT,Telefono=@Telefono,Email=@Email where IdEmpleado=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombresEmpleado", empleado.NombresEmpleado, DbType.String);
            parametros.Add("@ApellidosEmpleado", empleado.ApellidosEmpleado, DbType.String);
            parametros.Add("@IdRol_FK", empleado.IdRol_FK, DbType.Int32);
            parametros.Add("@DUI", empleado.DUI, DbType.String);
            parametros.Add("@NIT", empleado.NIT, DbType.String);
            parametros.Add("@Telefono", empleado.Telefono, DbType.String);
            parametros.Add("@Email", empleado.Email, DbType.String);
            parametros.Add("@id", empleado.IdEmpleado, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Empleado empleado)
        {
            string consulta = "Delete from Empleados where IdEmpleado=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", empleado.IdEmpleado, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Empleado> Listado()
        {
            string consulta = "SELECT * FROM Empleados";
            List<Empleado> listado = new List<Empleado>();

            cn.Open();
            listado = cn.Query<Empleado>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Empleado ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Empleados where IdEmpleado=@id";
            DynamicParameters parametros = new DynamicParameters();
            Empleado empleado = new Empleado();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            empleado = cn.QuerySingle<Empleado>(consulta, parametros);
            cn.Close();

            return empleado;
        }
    }
}
