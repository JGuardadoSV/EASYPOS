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
using EASYPOS.Controladores;

namespace EASYPOS.Modelos
{
    public class MCuota
    {
        readonly IDbConnection cn = Conexion.conectar();


        public int Insertar(Cuotas cuota)
        {

            string consulta = "insert into Cuotas (Fecha,Monto,IdContrato_FK,Capital,Intereses) values (@Fecha,@Monto,@IdContrato_FK,@Capital,@Intereses)";
            DynamicParameters parametros = new DynamicParameters();
            // int idventa;
            parametros.Add("@Fecha", cuota.Fecha, DbType.DateTime);
            parametros.Add("@Monto", cuota.Monto, DbType.Decimal);
            /* parametros.Add("@IdContrato_FK", cuota.IdContrato_FK, DbType.Int32);
             //parametros.Add("@TipoDocumento", cuota.TipoDocumento, DbType.Int32);
             parametros.Add("@Correlativo", cuota.Correlativo, DbType.Int64);
             parametros.Add("@IdCorrelativo_FK", cuota.IdCorrelativo_FK, DbType.Int32);*/
            parametros.Add("@IdContrato_FK", cuota.IdContrato_FK, DbType.Int32);
            parametros.Add("@Capital", cuota.Capital, DbType.Decimal);
            parametros.Add("@Intereses", cuota.Intereses, DbType.Decimal);
            //parametros.Add("@Cancelada", 0);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            //idventa = cn.QuerySingle<int>("Select max(IdVenta) id from ventas", commandType: CommandType.Text);
            cn.Close();

            CCorrelativo correlativo = new CCorrelativo();
            correlativo.ActualizarCorrelativo(cuota.IdCorrelativo_FK);


            return 1;
        }

        public void actualizarCuotasRestantes(int idContrato)
        {
            List<Cuotas> listado = this.Listado(idContrato);
            Cuotas ultimapagada = listado.Where(x => x.Cancelada == 1).OrderByDescending(x => x.FechaDePago).First();
            List<Cuotas> sinpagar = listado.Where(x => x.Cancelada == 0).ToList();
            decimal montoextra = ultimapagada.ACapitalExtra.Value;
            //decimal sumarestante = sinpagar.Sum(x => x.Capital).Value;
            if (montoextra > 0)
            {


                int cuantascrubre = decimal.ToInt32(montoextra / ultimapagada.Capital.Value);

                sinpagar = sinpagar.OrderByDescending(x => x.IdCuota).ToList();
                int contador = 1;
                foreach (Cuotas item in sinpagar)
                {

                    if (contador <= cuantascrubre)
                    {
                        item.Cancelada = 1;
                        item.Monto = 0;
                        //item.Capital = 0;
                        item.Intereses = 0;
                        item.FechaDePago = DateTime.Now;
                        
                        if (item.Capital< ultimapagada.Capital.Value)
                        {
                            montoextra -= item.Capital.Value;
                        }
                        else
                        {
                            montoextra -= ultimapagada.Capital.Value;
                        }
                        item.Capital = 0;
                        int x = ActualizarCancelada(item);
                        contador++;

                    }
                    else
                    {
                        if (montoextra > 0)
                        {
                            item.Cancelada = 0;
                            item.Monto = item.Monto - montoextra;
                            item.Capital = item.Capital - montoextra;
                            if (item.Capital.Value==0)
                            {
                                item.Cancelada = 1;
                                item.Monto = 0;
                                item.Capital = 0;
                                item.Intereses = 0;
                                item.FechaDePago = DateTime.Now;
                            }
                            //item.Intereses = 0;
                            int x = ActualizarCancelada(item);

                            montoextra -= montoextra;
                        }
                    }

                }



            }

        }
        public int ActualizarCancelada(Cuotas cuota)
        {

            string consulta = "Update cuotas set Cancelada=@Cancelada,Monto=@Monto,Capital=@Capital,Intereses=@Intereses,FechaDePago=@FechaDePago where IdCuota=@id";
            DynamicParameters parametros = new DynamicParameters();
            // int idventa;

            parametros.Add("@Cancelada", cuota.Cancelada);
            parametros.Add("@Monto", cuota.Monto);
            parametros.Add("@Capital", cuota.Capital);
            parametros.Add("@Intereses", cuota.Intereses);
            parametros.Add("@id", cuota.IdCuota);
            parametros.Add("@FechaDePago", cuota.FechaDePago);

            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

            // CCorrelativo correlativo = new CCorrelativo();
            //correlativo.ActualizarCorrelativo(cuota.IdCorrelativo_FK);


            return cuota.IdCuota;
        }
        public int Actualizar(Cuotas cuota)
        {

            string consulta = "Update cuotas set Correlativo=@Correlativo,IdCorrelativo_FK=@IdCorrelativo_FK,FechaDePago=@FechaDePago,Cancelada=@Cancelada,MontoCancelado= @MontoCancelado,AIntereses= @AIntereses,ACapital= @ACapital,ACapitalExtra= @ACapitalExtra,CapitalPendiente= @CapitalPendiente,EfectivoRecibido= @EfectivoRecibido,Cambio=@Cambio,comentario=@comentario,mora=@mora where IdCuota=@id";
            DynamicParameters parametros = new DynamicParameters();
            // int idventa;
            parametros.Add("@FechaDePago", DateTime.Now);
            parametros.Add("@Cancelada", 1);
            parametros.Add("@id", cuota.IdCuota);
            //parametros.Add("@TipoDocumento", cuota.TipoDocumento, DbType.Int32);
            parametros.Add("@Correlativo", cuota.Correlativo, DbType.Int64);
            parametros.Add("@IdCorrelativo_FK", cuota.IdCorrelativo_FK, DbType.Int32);

            parametros.Add("@MontoCancelado", cuota.MontoCancelado, DbType.Decimal);
            parametros.Add("@AIntereses", cuota.AIntereses, DbType.Decimal);
            parametros.Add("@ACapital", cuota.ACapital, DbType.Decimal);
            parametros.Add("@ACapitalExtra", cuota.ACapitalExtra, DbType.Decimal);
            parametros.Add("@CapitalPendiente", cuota.CapitalPendiente, DbType.Decimal);
            parametros.Add("@EfectivoRecibido", cuota.EfectivoRecibido, DbType.Decimal);
            parametros.Add("@Cambio", cuota.Cambio, DbType.Decimal);
            parametros.Add("@comentario", cuota.comentario, DbType.String);
            parametros.Add("@mora", cuota.mora, DbType.Decimal);







            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();

            CCorrelativo correlativo = new CCorrelativo();
            correlativo.ActualizarCorrelativo(cuota.IdCorrelativo_FK);

            // CCorrelativo correlativo = new CCorrelativo();
            //correlativo.ActualizarCorrelativo(cuota.IdCorrelativo_FK);


            return cuota.IdCuota;
        }

        public void Eliminar(Cuotas cuota)
        {
            string consulta = "Delete from Cuotas where IdCuota=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", cuota.IdCuota, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Cuotas> Listado(int id)
        {
            string consulta = "SELECT * FROM Cuotas where IdContrato_FK=@Id";
            List<Cuotas> listado = new List<Cuotas>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Id", id, DbType.Int32);
            cn.Open();
            listado = cn.Query<Cuotas>(consulta, parametros).ToList();
            cn.Close();
            return listado;
        }

        public Cuotas ObtenerUno(int id)
        {
            string consulta = "SELECT * FROM Cuotas where IdCuota=@Id";
            DynamicParameters parametros = new DynamicParameters();
            Cuotas cuota = new Cuotas();

            parametros.Add("@id", id, DbType.Int32);
            cn.Open();
            cuota = cn.QuerySingle<Cuotas>(consulta, parametros);
            cn.Close();

            return cuota;
        }
    }
}
