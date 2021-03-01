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
    public class MPresentacion
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Presentacion presentacion)
        {

            string consulta = "insert into Presentaciones values (@NombrePresentacion,@PresentacionSuperior,@PresentacionInferior,@CantidadPresentacion)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombrePresentacion", presentacion.NombrePresentacion, DbType.String);
            parametros.Add("@PresentacionSuperior", presentacion.PresentacionSuperior, DbType.Int32);
            parametros.Add("@PresentacionInferior", presentacion.PresentacionInferior, DbType.Int32);
            parametros.Add("@CantidadPresentacion", presentacion.CantidadPresentacion, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Presentacion presentacion)
        {

            string consulta = "Update Presentaciones set NombreProveedor=@Nombre,Email=@Email,Telefono=@Telefono,PersonaContacto=@PersonaContacto where IdPresentacion=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@NombrePresentacion", presentacion.NombrePresentacion, DbType.String);
            parametros.Add("@PresentacionSuperior", presentacion.PresentacionSuperior, DbType.Int32);
            parametros.Add("@PresentacionInferior", presentacion.PresentacionInferior, DbType.Int32);
            parametros.Add("@CantidadPresentacion", presentacion.CantidadPresentacion, DbType.Int32);
            parametros.Add("@id", presentacion.IdPresentacion, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Presentacion presentacion)
        {
            string consulta = "Delete from Presentaciones where IdPresentacion=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", presentacion.IdPresentacion, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Presentacion> Listado()
        {
            string consulta = "SELECT * FROM Presentaciones";
            List<Presentacion> listado = new List<Presentacion>();

            cn.Open();
            listado = cn.Query<Presentacion>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Presentacion ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Presentaciones where IdPresentacion=@id";
            DynamicParameters parametros = new DynamicParameters();
            Presentacion presentacion = new Presentacion();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            presentacion = cn.QuerySingle<Presentacion>(consulta, parametros);
            cn.Close();

            return presentacion;
        }
    }
}
