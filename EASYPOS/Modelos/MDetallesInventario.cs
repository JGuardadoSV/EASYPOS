﻿using EASYPOS.Entidades;
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
    public class MDetallesInventario
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(DetallesInventario detallesInventario)
        {

            string consulta = "insert into DetallesInventario values (@IdInventario_FK,@IdProducto_FK,@Existencias)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdInventario_FK", detallesInventario.IdInventario_FK, DbType.Int32);
            parametros.Add("@IdProducto_FK", detallesInventario.IdProducto_FK, DbType.Int32);
            parametros.Add("@Existencias", detallesInventario.Existencias, DbType.Int32);

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(DetallesInventario detallesInventario)
        {

            string consulta = "Update DetallesInventario set IdInventario_FK=@IdInventario_FK,IdProducto_FK=@IdProducto_FK, Existencias=@Existencias where IdDetalle=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@IdInventario_FK", detallesInventario.IdInventario_FK, DbType.Int32);
            parametros.Add("@IdProducto_FK", detallesInventario.IdProducto_FK, DbType.Int32);
            parametros.Add("@Existencias", detallesInventario.Existencias, DbType.Int32);
            parametros.Add("@id", detallesInventario.IdDetalle, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }



        internal void ActualizarExistencias(int idactual, string existencias)
        {
            string consulta = "Update DetallesInventario set  Existencias=@Existencias where IdDetalle=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Existencias", int.Parse(existencias), DbType.Int32);
            parametros.Add("@id", idactual, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        internal void DisminuirExistencias(int idactual, int cantidad)
        {
            string consulta = "Update DetallesInventario set  Existencias=Existencias-@Existencias where IdDetalle=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Existencias", cantidad, DbType.Int32);
            parametros.Add("@id", idactual, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public void Eliminar(DetallesInventario detallesInventario)
        {
            string consulta = "Delete from DetallesInventario where IdDetalle=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", detallesInventario.IdDetalle, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }
        
        public List<DetallesInventario> Listado(int id)
        {
            string consulta = "ListadoDetallesInventario";
            List<DetallesInventario> listado = new List<DetallesInventario>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            listado = cn.Query<DetallesInventario>(consulta, parametros, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return listado;
        }

        public List<DetallesInventario> ListadoPropio(int id)
        {
            string consulta = "ListadoDetallesInventarioPropio";
            List<DetallesInventario> listado = new List<DetallesInventario>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            listado = cn.Query<DetallesInventario>(consulta, parametros, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return listado;
        }
        public List<DetallesInventario> ListadoConsignacion(int id)
        {
            string consulta = "ListadoDetallesInventarioConsignacion";
            List<DetallesInventario> listado = new List<DetallesInventario>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            listado = cn.Query<DetallesInventario>(consulta, parametros, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return listado;
        }


    }
}
