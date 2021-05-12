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
    public class MVenta
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Venta venta)
        {

            string consulta = "insert into Ventas values (@Fecha,@IdCliente_FK,@IdEmpleado_FK,@TipoDocumento,@Correlativo,@IdCorrelativo_FK)";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Fecha", venta.Fecha, DbType.DateTime);
            parametros.Add("@IdCliente_FK", venta.IdCliente_FK, DbType.Int32);
            parametros.Add("@IdEmpleado_FK", venta.IdEmpleado_FK, DbType.Int32);
            parametros.Add("@TipoDocumento", venta.TipoDocumento, DbType.Int32);
            parametros.Add("@Correlativo", venta.Correlativo, DbType.Int64);
            parametros.Add("@IdCorrelativo_FK", venta.IdCorrelativo_FK, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Actualizar(Venta venta)
        {

            string consulta = "Update Ventas set Fecha=@Fecha,IdCliente_FK=@IdCliente_FK,IdEmpleado_FK=@IdEmpleado_FK,TipoDocumento=@TipoDocumento,Correlativo=@Corelativo,IdCorrelativo_FK=@IdCorrelativo_FK where IdVenta=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@Fecha", venta.Fecha, DbType.DateTime);
            parametros.Add("@IdCliente_FK", venta.IdCliente_FK, DbType.Int32);
            parametros.Add("@IdEmpleado_FK", venta.IdEmpleado_FK, DbType.Int32);
            parametros.Add("@TipoDocumento", venta.TipoDocumento, DbType.Int32);
            parametros.Add("@Correlativo", venta.Correlativo, DbType.Int64);
            parametros.Add("@IdCorrelativo_FK", venta.IdCorrelativo_FK, DbType.Int32);
            parametros.Add("@id", venta.IdVenta, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
        public void Eliminar(Venta venta)
        {
            string consulta = "Delete from Ventas where IdVenta=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", venta.IdVenta, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Venta> Listado()
        {
            string consulta = "SELECT * FROM Ventas";
            List<Venta> listado = new List<Venta>();

            cn.Open();
            listado = cn.Query<Venta>(consulta).ToList();
            cn.Close();
            return listado;
        }

        public Venta ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Ventas where IdVenta=@id";
            DynamicParameters parametros = new DynamicParameters();
            Venta venta = new Venta();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            venta = cn.QuerySingle<Venta>(consulta, parametros);
            cn.Close();

            return venta;
        }
    }
}