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

        public  Cuotas CuotaAnterior(int idCuota)
        {
            //select top 1 * from cuotas where IdCuota<4817 and IdContrato_FK=4012
            Cuotas cuota = this.ObtenerUno(idCuota);

            string consulta = "select top 1 * from cuotas where IdCuota<@idcuota and IdContrato_FK=@idcontrato order by FechaDePago desc";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@idcuota", cuota.IdCuota, DbType.Int32);
            parametros.Add("@idcontrato", cuota.IdContrato_FK, DbType.Int32);
            cn.Open();
            try
            {
                cuota = cn.QuerySingle<Cuotas>(consulta, parametros, commandType: CommandType.Text);
            }
            catch (Exception)
            {

                cuota = null;
            }
            
            cn.Close();
            return cuota;
        }

        internal void EliminarTodas(int idContrato)
        {

            string consulta = "DELETE p FROM Pagos p INNER JOIN Cuotas c   ON p.IdCuota_FK=c.IdCuota WHERE  c.IdContrato_FK=@id";
            DynamicParameters parametros = new DynamicParameters();

            parametros.Add("@id", idContrato, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();


           consulta = "Delete from Cuotas where IdContrato_Fk=@id";
            //DynamicParameters parametros = new DynamicParameters();

           //parametros.Add("@id", idContrato, DbType.Int32);
            cn.Open();
            cn.Execute(consulta, parametros, commandType: CommandType.Text);
            cn.Close();
        }

        public List<Cuotas> ListadoReporte(DateTime f1, DateTime f2)
        {
            List<Cuotas> listado = new List<Cuotas>();
            List<Cuotas> listado2 = new List<Cuotas>();
            // try
            //    {
            string consulta = "Select FechaDePago, MontoCancelado,mora,Correlativo  from cuotas where FechaDePago is Not null and MontoCancelado is Not null and cast(FechaDePago as date) between @fecha1 and @fecha2";
            
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@fecha1", f1.Date, DbType.DateTime);
            parametros.Add("@fecha2", f2.Date, DbType.DateTime);
            cn.Open();
            listado = cn.Query<Cuotas>(consulta, parametros, commandType: CommandType.Text).ToList();
            foreach (Cuotas cuota in listado)
            {
                cuota.FechaDePago = cuota.FechaDePago.Value.Date;
                listado2.Add(cuota);
            }
            cn.Close();
         //   }
         //   catch (Exception ex)
        //    {

                
        //    }
         
            return listado2;
        }

        public void actualizarCuotasRestantes(int idContrato)
        {
            CContratos cContratos = new CContratos();
            Contratos con = cContratos.uno(idContrato);
            decimal capital = Math.Round(con.Financiamiento.Value / con.Meses,2);
            CPagos cPagos = new CPagos();

            List<Cuotas> listado = this.Listado(idContrato);
           // Cuotas ultimapagada = listado.Where(x => x.Cancelada == 1).OrderByDescending(x => x.FechaDePago).First();
            List<Cuotas> sinpagar = listado.Where(x => x.Cancelada == 0).ToList();
            //decimal montoextra = ultimapagada.ACapitalExtra.Value;
            decimal montoextra = cPagos.extra(idContrato);
            //decimal sumarestante = sinpagar.Sum(x => x.Capital).Value;
            if (montoextra > 0)
            {


                int cuantascrubre = decimal.ToInt32(montoextra / capital);

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
                        
                        if (item.Capital< capital)
                        {
                            montoextra -= item.Capital.Value;
                        }
                        else
                        {
                            montoextra -= capital;
                        }
                        item.Capital = 0;
                        int x = ActualizarCancelada(item);
                        contador++;

                    }
                    else
                    {
                        if (montoextra > 0 && montoextra<capital)
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
                        else
                        {
                            if (montoextra>capital)
                            {
                                item.Cancelada = 1;
                                item.Monto = 0;
                                //item.Capital = 0;
                                item.Intereses = 0;
                                item.FechaDePago = DateTime.Now;

                                if (item.Capital < capital)
                                {
                                    montoextra -= item.Capital.Value;
                                }
                                else
                                {
                                    montoextra -= capital;
                                }
                                item.Capital = 0;
                                int x = ActualizarCancelada(item);
                            }

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

            string consulta = "Update cuotas set Monto=@Monto,Capital=@Capital,Intereses=@Intereses,Correlativo=@Correlativo,IdCorrelativo_FK=@IdCorrelativo_FK,FechaDePago=@FechaDePago,Cancelada=@Cancelada,MontoCancelado= @MontoCancelado,AIntereses= @AIntereses,ACapital= @ACapital,ACapitalExtra= @ACapitalExtra,CapitalPendiente= @CapitalPendiente,EfectivoRecibido= @EfectivoRecibido,Cambio=@Cambio,comentario=@comentario,mora=@mora where IdCuota=@id";
            DynamicParameters parametros = new DynamicParameters();
            // int idventa;
            parametros.Add("@FechaDePago", cuota.FechaDePago);
            parametros.Add("@Cancelada", cuota.Cancelada);
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


            parametros.Add("@Monto", cuota.Monto, DbType.Decimal);
            parametros.Add("@Capital", cuota.Capital, DbType.Decimal);
            parametros.Add("@Intereses", cuota.Intereses, DbType.Decimal);




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
