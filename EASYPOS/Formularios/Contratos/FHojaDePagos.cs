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
    public partial class FHojaDePagos : Form
    {
        int id;
        public FHojaDePagos(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FHojaDePagos_Load(object sender, EventArgs e)
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



            List<Pagos> listado = new List<Pagos>();
            Controladores.CPagos cPagos = new Controladores.CPagos();
            listado = cPagos.Listado(contrato.IdContrato);


            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Listado";
            rds.Value = listado;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomPercent = 150;
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
