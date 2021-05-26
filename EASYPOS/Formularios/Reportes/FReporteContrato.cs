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
    public partial class FReporteContrato : Form
    {
        int tipo;
        public FReporteContrato(int tipo=1)
        {
            this.tipo = tipo;
            InitializeComponent();
        }

        private void FReporteContrato_Load(object sender, EventArgs e)
        {
            CContratos cContratos = new CContratos();
            List<con> listado = new List<con>();

            ReportParameter[] p = new ReportParameter[2];
            CConfiguracion cConfiguracion = new CConfiguracion();
            Configuracion c = new Configuracion();
            c = cConfiguracion.ObtenerConfiguracion();
            string informacion = c.NombreEmpresa + " - " + c.Telefono;
            p[1] = new ReportParameter("informacion", informacion);
           
            if (tipo==1)
            {
                p[0] = new ReportParameter("titulo", "Contratos Activos");
                listado = cContratos.Listado(false);
            }
            else
            {
                p[0] = new ReportParameter("titulo", "Contratos en mora");
                listado = cContratos.Atrasados();
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Listado";
            rds.Value = listado;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();

        }
    }
}
