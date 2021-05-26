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
    public partial class FTablaFinanciamiento : Form
    {
        decimal precio, cuota, prima; int meses;
        List<TablaPagos> lista= new List<TablaPagos>();
        public FTablaFinanciamiento(decimal precio,decimal cuota, decimal prima, List<TablaPagos> listado, int meses)
        {
            this.precio = precio;
            this.cuota = cuota;
            this.prima = prima;
            lista = listado;
            this.meses = meses;
            InitializeComponent();
        }

        private void FTablaFinanciamiento_Load(object sender, EventArgs e)
        {

            
              ReportParameter[] p = new ReportParameter[]
       {
                new ReportParameter("costo",precio.ToString()),
                new ReportParameter("prima",prima.ToString()),
                new ReportParameter("financiamiento",(precio-prima).ToString()),
                new ReportParameter("meses",meses.ToString()),
                new ReportParameter("articulo","Motocicleta")


       };
             
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Listadofghfgh";
            rds.Value = lista;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
