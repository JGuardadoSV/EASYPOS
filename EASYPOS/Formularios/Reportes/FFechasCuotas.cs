using EASYPOS.Formularios.Contratos;
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
    public partial class FFechasCuotas: Form
    {
        public FFechasCuotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime f1, f2;

            f1 = dateTimePicker1.Value;
            f2 = dateTimePicker2.Value;
            if (radioButton1.Checked)
            {
                FReporteCuotas fReporte = new FReporteCuotas(f1, f2);
                fReporte.ShowDialog();
            }
            else
            {
                FReportePagosExtrasGlobal fReporte = new FReportePagosExtrasGlobal(f1, f2);
                fReporte.ShowDialog();

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
