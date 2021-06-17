using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using EASYPOS.Entidades;
using EASYPOS.Herramientas;

namespace EASYPOS.Modelos
{
    public class MCuenta
    {
        readonly IDbConnection cn = Conexion.conectar();


        public void Insertar(Cuentas cuenta)
        {

            string consulta = "insert into Cuentas values (@Numero,@Banco,@Tipo,@MontoInicial,@MontoDisponible,@FechaApertura)";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@FechaApertura", cuenta.FechaApertura, DbType.DateTime);
            parametros.Add("@Numero", cuenta.Numero, DbType.String);
            parametros.Add("@Banco", cuenta.Banco, DbType.String);
            parametros.Add("@Tipo", cuenta.Tipo, DbType.Int32);
            parametros.Add("@MontoInicial", cuenta.MontoInicial, DbType.Decimal);
            parametros.Add("@MontoDisponible", cuenta.MontoDisponible, DbType.Decimal);
            

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }

        public List<Cuentas> Listado()
        {
            string consulta = "Select * from Cuentas";

            List<Cuentas> listado = new List<Cuentas>();

            cn.Open();
            listado=cn.Query<Cuentas>(consulta, commandType: CommandType.Text).ToList();
            cn.Close();

            return listado;
        }

        public void Actualizar(Cuentas cuenta)
        {

            string consulta = "update Cuentas set FechaApertura=@FechaApertura,Numero=@Numero,Banco=@Banco,Tipo=@Tipo,MontoInicial=@MontoInicial,MontoDisponible=@MontoDisponible where IdCuenta=@Id";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Id", cuenta.IdCuenta, DbType.Int32);
            parametros.Add("@FechaApertura", cuenta.FechaApertura, DbType.Date);
            parametros.Add("@Numero", cuenta.Numero, DbType.String);
            parametros.Add("@Banco", cuenta.Banco, DbType.String);
            parametros.Add("@Tipo", cuenta.Tipo, DbType.Int32);
            parametros.Add("@MontoInicial", cuenta.MontoInicial, DbType.Decimal);
            parametros.Add("@MontoDisponible", cuenta.MontoDisponible, DbType.Decimal);


            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

        }
    }
}
