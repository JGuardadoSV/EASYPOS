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

namespace EASYPOS.Formularios.Reportes
{
    public partial class FReporteVentas : Form
    {
        DateTime f1, f2;
        public FReporteVentas(DateTime f1,DateTime f2)
        {
            this.f1 = f1;
            this.f2 = f2;
            InitializeComponent();
        }

        private void FReporteVentas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            CVenta cVentas = new CVenta();
            
            List<ReporteVentas> lista = new List<ReporteVentas>();

            lista = cVentas.Reporte(f1, f2);

           
            string fechas = f1.ToShortDateString() + " al " + f2.ToShortDateString();

            CConfiguracion cConfiguracion = new CConfiguracion();
            Configuracion c = new Configuracion();
            c = cConfiguracion.ObtenerConfiguracion();
            string informacion = c.NombreEmpresa + " - " + c.Telefono;

          

            ReportParameter[] p = new ReportParameter[]
       {
                new ReportParameter("fechas",fechas),
                new ReportParameter("informacion",informacion),
                new ReportParameter("nombrenegocio",c.NombreEmpresa)


       };
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "ListadoVentas";
            rds.Value = lista;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
