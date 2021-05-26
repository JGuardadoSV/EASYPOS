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
    public partial class FCalculos : Form
    {
        public decimal precio, cuota,prima,financiamiento;public int meses;
        string nombre;
        public FCalculos(string nombre)
        {
            this.nombre=nombre;
            InitializeComponent();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMeses_KeyUp(object sender, KeyEventArgs e)
        {
            calculo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FTablaAmortizacion f = new FTablaAmortizacion(this.precio, this.meses, this.cuota, 0.03M, DateTime.Now,this.prima,nombre);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46
                               && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        void calculo()
        {
            if (txtPrecio.Text.Length>0 && txtMeses.Text.Length>0 && txtPrima.Text.Length>0)
            {
                this.precio = decimal.Parse(txtPrecio.Text);
                this.prima = decimal.Parse(txtPrima.Text);
                this.financiamiento = precio - prima;
                decimal interes = financiamiento * 0.03M;
                this.meses = int.Parse(txtMeses.Text);
                decimal capital = financiamiento / meses;
                this.cuota = Math.Round(capital + interes, 2);
                txtFinanciamiento.Text = financiamiento.ToString();

                labelCuota.Text = this.cuota.ToString("C");



            }
            else
            {
                labelCuota.Text = "$0.000";
            }
            
        }
    }
}
