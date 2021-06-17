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

namespace EASYPOS.Formularios.Contratos
{
    public partial class FCalculos : Form
    {
        public decimal precio, cuota,prima,financiamiento,gastos,tasa;public int meses;
        string nombre;
        public bool singastos = false;
        public List<intereses> intereses = new List<intereses>();
        CIntereses cIntereses = new CIntereses();
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
            FTablaAmortizacion f = new FTablaAmortizacion(this.precio, this.meses, this.cuota, this.tasa, DateTime.Now,this.prima-this.gastos,nombre);
            f.ShowDialog();
        }

        private void textBoxTasa_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTasa.Text.Length>0)
            {
                calculo(true);
            }
            
        }

        private void textBoxgatos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxSinGastos_CheckedChanged(object sender, EventArgs e)
        {
           /* if (checkBoxSinGastos.Checked==true)
            {
                decimal gastos = decimal.Parse(textBoxgatos.Text);
                decimal primaneta = decimal.Parse(textBoxPrimaNeta.Text) + gastos;

                textBoxgatos.Text = "0.00";
                textBoxPrimaNeta.Text = primaneta.ToString("F");

                this.gastos = 0;
                this.singastos = true;
            }
            else
            {


                decimal gastos = 35.00M; ;
                    decimal primaneta = decimal.Parse(textBoxPrimaNeta.Text) - gastos;

                    textBoxgatos.Text = gastos.ToString("F");
                    textBoxPrimaNeta.Text = primaneta.ToString("F");

                    this.gastos = gastos;
                    this.singastos = false;
                
            }*/
        }

        private void checkBoxGastos_CheckedChanged(object sender, EventArgs e)
        {
            calculo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FCalculos_Load(object sender, EventArgs e)
        {
           // intereses = cIntereses.Obtener();
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

        void calculo(bool tasa=false)
        {
            if (txtPrecio.Text.Length>0 && txtMeses.Text.Length>0 && txtPrima.Text.Length>0)
            {
                this.prima = decimal.Parse(txtPrima.Text);
                this.tasa = 0.03M;

                
                this.precio = decimal.Parse(txtPrecio.Text);
                this.prima = decimal.Parse(txtPrima.Text);

                if (prima>(precio*0.35m))
                {
                    this.tasa = 0.025M;
                }

                if (tasa)
                {
                    this.tasa = decimal.Parse(textBoxTasa.Text) / 100;
                }
                if (checkBoxGastos.Checked)
                    this.gastos = 0;
                else
                    this.gastos = 35M;



                this.financiamiento = precio - (prima - gastos);
                decimal interes = financiamiento * this.tasa;
                this.meses = int.Parse(txtMeses.Text);
                decimal capital = financiamiento / meses;
                this.cuota = Math.Round(capital + interes, 2);
                txtFinanciamiento.Text = financiamiento.ToString();
                //this.gastos = 35.00M;
                textBoxPrimaNeta.Text = (prima - this.gastos).ToString("F");
                textBoxgatos.Text = gastos.ToString("F");
                txtTasaAplicada.Text = (this.tasa * 100).ToString() ;
                labelCuota.Text = this.cuota.ToString("C");
                textBoxTasa.Text = (this.tasa * 100M).ToString("F");



            }
            else
            {
                labelCuota.Text = "$0.000";
            }
            
        }
    }
}
