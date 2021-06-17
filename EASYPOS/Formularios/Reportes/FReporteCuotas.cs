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
    public partial class FReporteCuotas : Form
    {
        DateTime f1, f2;
        public FReporteCuotas(DateTime f1, DateTime f2)
        {
            this.f1 = f1;
            this.f2 = f2;
            InitializeComponent();
        }

        private void FReporteCuotas_Load(object sender, EventArgs e)
        {
            
            
            
            CConfiguracion cConfiguracion = new CConfiguracion();
            Configuracion c = new Configuracion();
            c = cConfiguracion.ObtenerConfiguracion();
            string informacion = c.NombreEmpresa + " - " + c.Telefono;

            ReportParameter[] p = new ReportParameter[]
     {

                new ReportParameter("informacion",informacion),
                new ReportParameter("nombrenegocio",c.NombreEmpresa.ToString().ToUpper()),
                new ReportParameter("fechas","Periodo del "+f1.Date.ToShortDateString()+" al "+f2.Date.ToShortDateString())


     };



            List<Pagos> listado = new List<Pagos>();
            CPagos cPagos = new CPagos();
            listado = cPagos.ListadoReporte(f1,f2);


            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Listado";
            rds.Value = listado;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
