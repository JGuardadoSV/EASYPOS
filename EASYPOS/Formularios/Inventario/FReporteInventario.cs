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

namespace EASYPOS.Formularios.Inventario
{
    public partial class FReporteInventario : Form
    {
        int tipo = 0,idinventario;
        public FReporteInventario(int tipo,int idinventario)
        {
            this.tipo = tipo;
            this.idinventario = idinventario;
            InitializeComponent();
        }

        private void FReporteInventario_Load(object sender, EventArgs e)
        {
            CDetallesInventario cDetalles = new CDetallesInventario();
            
            List<DetallesInventario> listado = new List<DetallesInventario>();

            ReportParameter[] p = new ReportParameter[3];
            CConfiguracion cConfiguracion = new CConfiguracion();
            Configuracion c = new Configuracion();
            c = cConfiguracion.ObtenerConfiguracion();
            string informacion = c.NombreEmpresa + " - " + c.Telefono;
            p[1] = new ReportParameter("informacion", informacion);
            p[2] = new ReportParameter("nombrenegocio", c.NombreEmpresa);

            if (tipo == 0)
            {
                p[0] = new ReportParameter("tipo", "Todos los productos");
                listado = cDetalles.Listado(idinventario);
            }
            else if (tipo == 1) {
                p[0] = new ReportParameter("tipo", "Productos propios");
                listado = cDetalles.ListadoPropio(idinventario);
            }
            else
            {
                p[0] = new ReportParameter("tipo", "Productos en consignacion");
                listado = cDetalles.ListadoConsignacion(idinventario);
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Listado";
            rds.Value = listado;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
