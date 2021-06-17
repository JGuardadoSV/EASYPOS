using EASYPOS.Controladores;
using EASYPOS.Entidades;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using con = EASYPOS.Entidades.Contratos;
namespace EASYPOS.Formularios.Reportes
{
    public partial class FReporteDocumentos : Form
    {
        int id;
        List<TablaPagos> lista = new List<TablaPagos>();
        public FReporteDocumentos(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FReporteDocumentos_Load(object sender, EventArgs e)
        {
            try
            {
                CContratos cContratos = new CContratos();
                con contrato = new con();
                contrato = cContratos.uno(id);
                CConfiguracion cConfiguracion = new CConfiguracion();
                Configuracion c = new Configuracion();
                c = cConfiguracion.ObtenerConfiguracion();
                string informacion = c.NombreEmpresa + " - " + c.Telefono;
                string titulo = "CREDITO DE MOTOCICLETA";
                if (contrato.NoEsMoto==1)
                {
                    titulo = "CREDITO SG";
                }

                string dir = "-";
                if (contrato.DireccionCasa!=null)
                {
                    dir = contrato.DireccionCasa;
                }
                string parte1 = "POR MEDIO DE ESTE PAGARÉ SIN PROTESTO ME OBLIGO A PAGAR EN LA CIUDAD DE "+ c.municipio.ToUpper() +", A LA ORDEN DE INVERSIONES SG LA SUMA DE $"+contrato.Financiamiento.Value.ToString("F")+" MÁS INTERESES MENSUALES DISTRIBUIDA EN "+contrato.Meses+" CUOTAS DE $"+contrato.Cuota.Value.ToString("F")+ ", EN CONCEPTO DE COMPRA DE "+ contrato.DescripcionProducto+".";
                string parte2 = "ENTREGADO ESTE DIA "+contrato.FechaInicio.Value.Date.ToShortDateString()+". LA PRIMERA PRIMA DE $"+ contrato.PrimaNeta.Value.ToString("F")+". EL PAGO MENSUAL SE HARA EN EL LUGAR PACTADO.";
                string parte3 = "PARA TODOS LOS EFECTOS DE ESTA OBLIGACION MERCANTIL FIJAMOS COMO DOMICILIO LA CIUDAD DE NUEVA CONCEPCION CHALATENANGO, Y EN CASO DE ACCION JUDICIAL RENUNCIO AL DECRETO DE APELAR DE DERECHO DE EMBARGO, SENTENCIA DE REMATE Y TODA OTRA PROVIDENCIA APELABLE QUE SE DICTARE EN EL JUICIO EJECUTIVO O SUS INCIDENCIAS, SIENDO A MI CARGO TODOS LOS GASTOS QUE INVERSIONES SG HICIERE EN EL NOMBRE DE ESTE PAGARÉ, EN CUALQUIER CONCEPTO, INCLUIDOS LOS DE CANCELACION Y DE COBRANZA JUDICIALES Y EXTRAJUDICIALES.";

                ReportParameter[] p = new ReportParameter[]
         {

                new ReportParameter("informacion",informacion),
                new ReportParameter("producto",contrato.DescripcionProducto.ToString().ToUpper()),
                new ReportParameter("cliente","CLIENTE: "+contrato.NombreCompleto.ToString().ToUpper()),
                new ReportParameter("direccion","DIRECCIÓN: "+dir.ToUpper()),
                new ReportParameter("financiamiento","FINANCIAMIENTO: $"+contrato.Financiamiento.ToString()),
                new ReportParameter("financiamiento2",contrato.Financiamiento.ToString()),
                new ReportParameter("cuota1","CUOTA: $"+contrato.Cuota.ToString()),
                new ReportParameter("fechacredito","FECHA DE CRÉDITO: "+contrato.FechaInicio.Value.ToShortDateString()),
                new ReportParameter("precio",contrato.Precio.ToString()),
                new ReportParameter("prima",contrato.Prima.ToString()),
                new ReportParameter("meses",contrato.Meses.ToString()),
                new ReportParameter("titulo",titulo),
                new ReportParameter("parte1",parte1),
                new ReportParameter("parte2",parte2),
                new ReportParameter("parte3",parte3),
                new ReportParameter("dui",contrato.Dui),
                new ReportParameter("telefono",contrato.Celular),
                new ReportParameter("direccion2",dir),
                new ReportParameter("cliente2",contrato.NombreCompleto)


         };

                



                List<Cuotas> listado = new List<Cuotas>();
                Controladores.CCuota cCuota = new Controladores.CCuota();
                listado = cCuota.Listado(contrato.IdContrato);


                ReportDataSource rds = new ReportDataSource();
               // rds.Name = "Listado";
               // rds.Value = listado;
              //  this.reportViewer1.LocalReport.DataSources.Add(rds);

                generarTabla();
                rds = new ReportDataSource();
                rds.Name = "Listadofghfgh";
                rds.Value = lista;
                this.reportViewer1.LocalReport.DataSources.Add(rds);


                
                this.reportViewer1.LocalReport.SetParameters(p);
                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {




            }

            
        }

        private void generarTabla()
        {
            CContratos cContratos = new CContratos();
            con contrato = new con();
            contrato = cContratos.uno(id);

            decimal total = contrato.Financiamiento.Value;
            decimal restante = total;
            DateTime fecha = contrato.FechaInicio.Value;
            for (int i = 1; i <= contrato.Meses; i++)
            {
                restante -= Math.Round(total / contrato.Meses, 2);
                fecha = fecha.AddMonths(1);
                TablaPagos p = new TablaPagos();
                p.Correlativo = i;
                p.Fecha = fecha;
                p.Capital = Math.Round(total / contrato.Meses, 2);
                p.Interes = Math.Round(total * contrato.Tasa, 2);
                p.Restante = restante;
                p.Cuota = p.Capital + p.Interes;

                if (p.Restante < 0)
                {
                    p.Capital = p.Capital + p.Restante;
                    p.Cuota = p.Capital + p.Interes;
                    p.Restante = 0;
                }

                if (p.Restante > 0 && p.Restante <= 1)
                {
                    p.Capital = p.Capital + p.Restante;
                    p.Cuota = p.Cuota + p.Restante;
                    p.Restante = 0;
                }

                lista.Add(p);

            }
        }
    }
}
