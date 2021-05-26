using EASYPOS.Controladores;
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

namespace EASYPOS.Formularios.Ventas
{
    public partial class FHistorialVentas : Form
    {
        CVenta cVentas = new CVenta();
        DateTime f1 = DateTime.Now, f2 = DateTime.Now;
        public FHistorialVentas()
        {
            InitializeComponent();
        }

        private void FHistorialVentas_Load(object sender, EventArgs e)
        {

            busqueda(this.f1, this.f2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            busqueda(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void ventaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Venta venta = (Venta)ventaBindingSource.Current;
            CVenta cVenta = new CVenta();





            FVenta fventa = new FVenta(  venta.Fecha.ToString(),venta.Correlativo.ToString(),cVenta.DetallesVenta(venta.IdVenta));
            fventa.ShowDialog();
        }

        void busqueda(DateTime f1, DateTime f2)
        {
            ventaBindingSource.DataSource = cVentas.Listado(f1,f2);
        }
    }
}
