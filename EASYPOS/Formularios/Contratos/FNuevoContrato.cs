using EASYPOS.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EASYPOS.Entidades;
using contrato = EASYPOS.Entidades.Contratos;
namespace EASYPOS.Formularios.Contratos
{
    public partial class FNuevoContrato : Form
    {
        contrato contratoUp,contraton=new contrato();
        public FNuevoContrato(EASYPOS.Entidades.Contratos contrato=null)
        {
            this.contratoUp = contrato;
            InitializeComponent();
        }

        private void FNuevoContrato_Load(object sender, EventArgs e)
        {
            if (contratoUp == null)
            {
                contraton.Meses = 18;
                contraton.GastosEscritura = 0;
                contraton.PrimaNeta = 0;
                contraton.PrimaInicial = contraton.PrimaNeta;
                contratosBindingSource.Add(contraton);
                
            }
            else
            {
                contratosBindingSource.DataSource = contratoUp;
                if (contratoUp.Estado==1)
                    estadoCheckBox.Checked=true;
                else
                    estadoCheckBox.Checked = false;
            }

        
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CContratos cContratos = new CContratos();
            contrato contrato = new contrato();
            contrato = (EASYPOS.Entidades.Contratos)contratosBindingSource.Current;
            if (estadoCheckBox.Checked)
                contrato.Estado = 1;
            else
                contrato.Estado = 0;

            cContratos.Insertar(contrato);

            if (contratoUp==null)
                MessageBox.Show(this, "Contrato guardado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Contrato actualizado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal monto = decimal.Parse(financiamientoTextBox.Text.Trim()); 
            int meses = int.Parse(mesesTextBox.Text); 
            decimal cuota =  Math.Round(monto/meses,2); 
            decimal tasa = Math.Round(3M /100,2); 
            DateTime fecha = fechaInicioDateTimePicker.Value;
            

             FTablaAmortizacion f = new FTablaAmortizacion( monto,  meses,  cuota,  tasa,  fecha);
            f.ShowDialog();
        }

        private void gastosEscrituraTextBox_TextChanged(object sender, EventArgs e)
        {
            decimal gastos = decimal.Parse(gastosEscrituraTextBox.Text);
            this.contraton.GastosEscritura = gastos;
            contraton.PrimaNeta = contraton.Prima + contraton.GastosEscritura;
            contraton.PrimaInicial = contraton.PrimaNeta;
        }

        private void primaTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

            
            decimal precio = decimal.Parse(precioTextBox.Text);
            decimal prima = decimal.Parse(primaTextBox.Text);
            decimal financiamiento = precio - prima;
                decimal interes = financiamiento * 0.03M;

                decimal capital = financiamiento / contraton.Meses;
                decimal cuota = Math.Round(capital + interes, 2);
                financiamientoTextBox.Text = financiamiento.ToString() ;
                //            ((contrato)contratosBindingSource.Current).Financiamiento = financiamiento;
                contraton.Financiamiento = financiamiento;
                contraton.Cuota = cuota;
                cuotaTextBox.Text = contraton.Cuota.ToString();

                

            }
            catch (Exception)
            {

                MessageBox.Show("ERror");
            }
        }
    }
}
