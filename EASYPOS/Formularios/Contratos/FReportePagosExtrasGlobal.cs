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
namespace EASYPOS.Formularios.Contratos
{
    public partial class FReportePagosExtrasGlobal : Form
    {
        DateTime f1, f2;
        public FReportePagosExtrasGlobal(DateTime f1, DateTime f2)
        {
            this.f1 = f1;
            this.f2 = f2;
            InitializeComponent();
        }

        private void FReportePagosExtras_Load(object sender, EventArgs e)
        {
            
            CConfiguracion cConfiguracion = new CConfiguracion();
            Configuracion c = new Configuracion();
            c = cConfiguracion.ObtenerConfiguracion();
            string informacion = c.NombreEmpresa + " - " + c.Telefono;

            ReportParameter[] p = new ReportParameter[]
     {

                new ReportParameter("informacion",informacion),
                new ReportParameter("nombrenegocio",c.NombreEmpresa.ToString().ToUpper()),
                new ReportParameter("fechas","Del "+f1.Date.Date.ToShortDateString()+" al " + f2.Date.Date.ToShortDateString())
                

     };



            List<OtrosPagos> listado = new List<OtrosPagos>();
            COtrosPagos cOtros = new COtrosPagos();
            listado = cOtros.ListadoReporte(f1,f2);


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
