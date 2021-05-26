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
    public partial class FReporteMora : Form
    {
        int id;
        List<TablaPagos> tabla = new List<TablaPagos>();
        public FReporteMora(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FReporteMora_Load(object sender, EventArgs e)
        {
            CContratos cContratos = new CContratos();
            con contrato = new con();
            contrato = cContratos.uno(id);
            CConfiguracion cConfiguracion = new CConfiguracion();
            Configuracion c = new Configuracion();
            c = cConfiguracion.ObtenerConfiguracion();
            string informacion = c.NombreEmpresa + " - " + c.Telefono;

            ReportParameter[] p = new ReportParameter[]
     {
                new ReportParameter("costo",contrato.Precio.ToString()),
                new ReportParameter("prima",contrato.Prima.ToString()),
                new ReportParameter("financiamiento",contrato.Financiamiento.ToString()),
                new ReportParameter("meses",contrato.Meses.ToString()),
                new ReportParameter("articulo",contrato.DescripcionProducto),
                new ReportParameter("cliente",contrato.NombreCompleto),
                new ReportParameter("informacion",informacion)



     };



            List<Cuotas> listado = new List<Cuotas>();
            CCuota cCuota = new CCuota();
            listado = cCuota.Listado(contrato.IdContrato);


            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Listadofghfgh";
            rds.Value = listado;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        

        private void generarTabla(decimal monto,int meses,DateTime fecha, decimal tasa)
        {
            tasa = 0.03M;
            decimal total = monto;
            decimal restante = monto;

            for (int i = 1; i <= meses; i++)
            {
                restante -= Math.Round(total / meses, 2);
                fecha = fecha.AddMonths(1);
                TablaPagos p = new TablaPagos();
                p.Correlativo = i;
                p.Fecha = fecha;
                p.Capital = Math.Round(total / meses, 2);
                p.Interes = Math.Round(total * tasa, 2);
                p.Restante = restante;
                p.Cuota = p.Capital + p.Interes;

                if (p.Restante < 0)
                {
                    p.Capital = p.Capital + p.Restante;
                    p.Restante = 0;
                }

                tabla.Add(p);

            }
        }
    }
}
