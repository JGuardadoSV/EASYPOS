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
using EASYPOS.Formularios.Reportes;

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
                //contraton.Meses = 18;
                //contraton.GastosEscritura = 0;
                //// contraton.PrimaNeta = 0;
                // contraton.PrimaInicial = contraton.PrimaNeta;
                contraton.Estado = 1;
                contratosBindingSource.Add(contraton);
                button5.Visible = false;

                
            }
            else
            {
                CContratos c = new CContratos();
                contratoUp = c.uno(contratoUp.IdContrato);
                contratosBindingSource.DataSource = contratoUp;
                if (contratoUp.Estado == 1)
                {
                    estadoCheckBox.Checked = true;

                }

                else {
                    estadoCheckBox.Checked = false;
                    estadoCheckBox.Visible = false;
                    datosgenerales.Controls["labelestado"].Visible = false;
                    button4.Visible = false;

                }
                   
                if (contratoUp.Estado==1)
                {
                    button5.Visible = false;
                }
            }

          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CContratos cContratos = new CContratos();
            contrato contrato = new contrato();
            contrato = (EASYPOS.Entidades.Contratos)contratosBindingSource.Current;


            if (contrato.Precio==0 || contrato.Cuota==0 || contrato.Financiamiento==0 || contrato.Prima==0 || contrato.Meses==0)
            {
                MessageBox.Show("Para guardar, debe de rellenar los datos del financiamiento");
                return;
            }




            if (contrato.FechaInicio==null)
            {
                //MessageBox.Show("Seleccione la fecha de inicio");
                contrato.FechaInicio = DateTime.Now;
            }
            else
            {
                if (estadoCheckBox.Checked)
                    contrato.Estado = 1;
                else
                    contrato.Estado = 0;

                int idcontrato = cContratos.Insertar(contrato);

                if (contratoUp == null)
                {
                    generarTabla(contrato.Financiamiento.Value, contrato.Meses, contrato.FechaInicio.Value, 0.03M, idcontrato, contrato.Prima.Value);
                    MessageBox.Show(this, "Contrato guardado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    CCuota c = new CCuota();
                    int cu;
                    cu = c.Listado(contratoUp.IdContrato).Count;
                    if (cu==0)
                    {
                        generarTabla(contrato.Financiamiento.Value, contrato.Meses, contrato.FechaInicio.Value, 0.03M, idcontrato, contrato.Prima.Value);
                    }
                    MessageBox.Show(this, "Contrato actualizado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                this.Close();

            }


            

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
            try
            {
                decimal monto = decimal.Parse(precioTextBox.Text.Trim());
                int meses = int.Parse(mesesTextBox.Text);
                decimal cuota = Math.Round(monto / meses, 2);
                decimal tasa = Math.Round(3M / 100, 2);
                DateTime fecha = fechaInicioDateTimePicker.Value;
                decimal prima = decimal.Parse(primaTextBox.Text);
                
                FTablaAmortizacion f = new FTablaAmortizacion(monto, meses, cuota, tasa, fecha, prima,nombreCompletoTextBox.Text);
                f.ShowDialog();
            }
            catch (Exception)
            {

               // throw;
            }
            
        }

        private void gastosEscrituraTextBox_TextChanged(object sender, EventArgs e)
        {
            if (gastosEscrituraTextBox.Text.Length>0)
            {
                try
                {
                    decimal gastos = decimal.Parse(gastosEscrituraTextBox.Text);
                    this.contraton.GastosEscritura = gastos;
                    contraton.PrimaNeta = contraton.Prima + contraton.GastosEscritura;
                    contraton.PrimaInicial = contraton.PrimaNeta;
                }
                catch (Exception)
                {

                    
                    ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).GastosEscritura = 0;
                }
                
            }
            
        }

        private void primaTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularcuota();
        }

        private void calcularcuota()
        {
            try
            {


                decimal precio = decimal.Parse(precioTextBox.Text);
                decimal prima = decimal.Parse(primaTextBox.Text);
                decimal financiamiento = precio - prima;
                decimal interes = financiamiento * 0.03M;

                decimal capital = financiamiento / contraton.Meses;
                decimal cuota = Math.Round(capital + interes, 2);
             //   financiamientoTextBox1.Text = financiamiento.ToString();
                //            ((contrato)contratosBindingSource.Current).Financiamiento = financiamiento;
                contraton.Financiamiento = financiamiento;
                contraton.Cuota = cuota;
                //cuotaTextBox.Text = contraton.Cuota.ToString();



            }
            catch (Exception)
            {

            //    MessageBox.Show("Error");
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46
                                && e.KeyChar != 8)
                e.Handled = true;
        }

        private void precioTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (precioTextBox.Text.Length==0)
            {
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).GastosEscritura = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Prima = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Financiamiento = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).PrimaInicial = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).PrimaNeta = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Cuota = 0;
                
            }
        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (precioTextBox.Text.Length == 0)
            {
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).GastosEscritura = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Prima = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Financiamiento = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).PrimaInicial = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).PrimaNeta = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Cuota = 0;

            }
        }

        private void mesesTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularcuota();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = datoscredito;
            try
            {

            
            FCalculos fCalculos = new FCalculos(nombreCompletoTextBox.Text);
            fCalculos.StartPosition = FormStartPosition.CenterParent;
            fCalculos.ShowDialog();

            if (fCalculos.DialogResult==DialogResult.OK && contratoUp==null)
            {
                    contraton = new contrato() ;
                    
                    // contratosBindingSource.ResetBindings(true);
                    contraton = (contrato) contratosBindingSource.Current;
                    contraton.Precio = fCalculos.precio;
                contraton.Meses = fCalculos.meses;
                contraton.Cuota = fCalculos.cuota;
                    //MessageBox.Show(contraton.Financiamiento.ToString());
                    contraton.Financiamiento = 0; contraton.Financiamiento= fCalculos.financiamiento;
                    contraton.Prima = fCalculos.prima;

                    if (gastosEscrituraTextBox.Text.Length>0)
                    {

                        decimal gastos = decimal.Parse(gastosEscrituraTextBox.Text);
                        contraton.GastosEscritura = gastos;
                        contraton.PrimaInicial = contraton.Prima + gastos;
                        contraton.PrimaNeta = contraton.PrimaInicial;

                    }



                
               contratosBindingSource.DataSource = contraton;
                    contratosBindingSource.ResetBindings(true);

                }

                if (fCalculos.DialogResult == DialogResult.OK && contratoUp != null)
                {
                    // contraton = new contrato();

                    // contratosBindingSource.ResetBindings(true);
                    //contraton = (contrato)contratosBindingSource.Current;
                    contratoUp.Precio = fCalculos.precio;
                    contratoUp.Meses = fCalculos.meses;
                    contratoUp.Cuota = fCalculos.cuota;
                    //MessageBox.Show(contraton.Financiamiento.ToString());
                    contratoUp.Financiamiento = 0; contratoUp.Financiamiento = fCalculos.financiamiento;
                    contratoUp.Prima = fCalculos.prima;

                    if (gastosEscrituraTextBox.Text.Length > 0)
                    {

                        decimal gastos = decimal.Parse(gastosEscrituraTextBox.Text);
                        contratoUp.GastosEscritura = gastos;
                        contratoUp.PrimaInicial = contratoUp.Prima + gastos;
                        contratoUp.PrimaNeta = contratoUp.PrimaInicial;

                    }




                    contratosBindingSource.DataSource = contratoUp;
                    contratosBindingSource.ResetBindings(true);

                }

            }
            catch (Exception)
            {

                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FCuotasPagar f = new FCuotasPagar(contratoUp.IdContrato);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FReporteDocumentos f = new FReporteDocumentos(contratoUp.IdContrato);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void generarTabla(decimal monto,int meses, DateTime fecha, decimal tasa, int idcontrato, decimal prima)
        {
            decimal total = monto;
            decimal restante = monto;
            List<TablaPagos> tabla = new List<TablaPagos>();

            for (int i = 1; i <= meses; i++)
            {
                restante -= Math.Round(total / meses, 2);
                fecha = fecha.AddMonths(1);
                TablaPagos p = new TablaPagos();
                p.Correlativo = i;
                p.Fecha = fecha;
                p.Capital = Math.Round(total / meses, 2);
                p.Interes = Math.Round(total * tasa, 2);
                p.Restante = restante;
                p.Cuota = p.Capital + p.Interes;

                if (p.Restante < 0)
                {
                    p.Capital = p.Capital + p.Restante;
                    p.Restante = 0;
                }

                tabla.Add(p);

            }

            CCuota cCuota = new CCuota();
            foreach (TablaPagos p in tabla)
            {
                Cuotas cuota = new Cuotas();

                //Fecha,Monto,IdContrato_FK,Capital,Intereses
                cuota.Fecha = p.Fecha;
                cuota.Monto = p.Cuota;
                cuota.IdContrato_FK = idcontrato;
                cuota.Capital = p.Capital;
                cuota.Intereses = p.Interes;

                cCuota.Insertar(cuota);
            }
        }
    }
}
