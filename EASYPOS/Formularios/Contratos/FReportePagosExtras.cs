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
    public partial class FReportePagosExtras : Form
    {
        int id;
        public FReportePagosExtras(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FReportePagosExtras_Load(object sender, EventArgs e)
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

                new ReportParameter("informacion",informacion),
                new ReportParameter("producto",contrato.DescripcionProducto.ToString()),
                new ReportParameter("cliente","CLIENTE: "+contrato.NombreCompleto.ToString().ToUpper()),
                new ReportParameter("nombrenegocio",c.NombreEmpresa.ToString().ToUpper()),
                new ReportParameter("capital",contrato.Restante.ToString()),
                new ReportParameter("inicio",contrato.FechaInicio.ToString())
                

     };



            List<OtrosPagos> listado = new List<OtrosPagos>();
            COtrosPagos cOtros = new COtrosPagos();
            listado = cOtros.Listado(contrato.IdContrato);


            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Listado";
            rds.Value = listado;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(p);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
