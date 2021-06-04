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
                ReportParameter[] p = new ReportParameter[]
         {

                new ReportParameter("informacion",informacion),
                new ReportParameter("producto",contrato.DescripcionProducto.ToString()),
                new ReportParameter("cliente","CLIENTE: "+contrato.NombreCompleto.ToString().ToUpper()),
                new ReportParameter("direccion","DIRECCIÓN: "+contrato.DireccionCasa.ToString().ToUpper()),
                new ReportParameter("financiamiento","FINANCIAMIENTO: $"+contrato.Financiamiento.ToString()),
                new ReportParameter("financiamiento2",contrato.Financiamiento.ToString()),
                new ReportParameter("cuota1","CUOTA: $"+contrato.Cuota.ToString()),
                new ReportParameter("fechacredito","FECHA DE CRÉDITO: "+contrato.FechaInicio.Value.ToShortDateString()),
                new ReportParameter("precio",contrato.Precio.ToString()),
                new ReportParameter("prima",contrato.Prima.ToString()),
                new ReportParameter("meses",contrato.Meses.ToString()),
                new ReportParameter("titulo",titulo)


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
                p.Interes = Math.Round(total * 0.03m, 2);
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
