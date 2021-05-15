using EASYPOS.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPOS.Formularios.Contratos
{
    public partial class FTablaAmortizacion : Form
    {
        decimal monto,  tasa, cuota;
        int meses;
        DateTime fecha;
        List<TablaPagos> tabla = new List<TablaPagos>();
        public FTablaAmortizacion(decimal monto, int meses, decimal cuota, decimal tasa,DateTime fecha)
        {
            this.monto = monto;
            this.meses = meses;
            this.cuota = cuota;
            this.fecha = fecha;
            this.tasa = tasa;
            InitializeComponent();
        }

        private void FTablaAmortizacion_Load(object sender, EventArgs e)
        {
            generarTabla();
            tablaPagosBindingSource.DataSource = tabla;
        }

        private void generarTabla()
        {
            decimal total = monto;
            decimal restante = monto;
            
            for (int i = 1; i <= meses; i++)
            {
                restante -= Math.Round(total / meses, 2);
                fecha=fecha.AddMonths(1);
                TablaPagos p = new TablaPagos();
                p.Correlativo = i;
                p.Fecha = fecha;
                p.Capital = Math.Round(total/meses,2);
                p.Interes = Math.Round(total * tasa,2);
                p.Restante = restante;
                p.Cuota = p.Capital + p.Interes;

                if (p.Restante<0)
                {
                    p.Capital = p.Capital + p.Restante;
                    p.Restante = 0;
                }

                tabla.Add(p);

            }
        }
    }
}
