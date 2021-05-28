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
        public FReporteDocumentos(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FReporteDocumentos_Load(object sender, EventArgs e)
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
                /*new ReportParameter("costo",contrato.Precio.ToString()),
                new ReportParameter("prima",contrato.Prima.ToString()),
                new ReportParameter("financiamiento",contrato.Financiamiento.ToString()),
                new ReportParameter("meses",contrato.Meses.ToString()),
                new ReportParameter("articulo",contrato.DescripcionProducto),
                new ReportParameter("cliente",contrato.NombreCompleto),*/
                new ReportParameter("informacion",informacion),
                new ReportParameter("producto",contrato.DescripcionProducto.ToString()),
                new ReportParameter("cliente","CLIENTE: "+contrato.NombreCompleto.ToString().ToUpper()),
                new ReportParameter("direccion","DIRECCIÓN: "+contrato.DireccionCasa.ToString().ToUpper()),
                new ReportParameter("financiamiento","FINANCIAMIENTO: $"+contrato.Financiamiento.ToString()),
                new ReportParameter("cuota","CUOTA: $"+contrato.Cuota.ToString()),
                new ReportParameter("fechacredito","FECHA DE CRÉDITO: "+contrato.FechaInicio.ToString())
                



     };



            List<Cuotas> listado = new List<Cuotas>();
            Controladores.CCuota cCuota = new Controladores.CCuota();
            listado = cCuota.Listado(contrato.IdContrato);


            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Listado";
            rds.Value = listado;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
